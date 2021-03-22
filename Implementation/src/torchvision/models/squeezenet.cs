using nn = System.AI.torch.nn;

namespace System
{

    namespace AI
    {

        public static partial class torchvision
        {

            public static partial class models
            {

                public sealed class Fire : nn.Module
                {

                    public int inplanes;

                    public nn.Conv2d squeeze;

                    public nn.ReLU squeeze_activation;

                    public nn.Conv2d expand1x1;

                    public nn.ReLU expand1x1_activation;

                    public nn.Conv2d expand3x3;

                    public nn.ReLU expand3x3_activation;

                    public Fire(int inplanes,
                                int squeeze_planes,
                                int expand1x1_planes,
                                int expand3x3_planes)
                    {
                        this.inplanes = inplanes;
                        this.squeeze = new nn.Conv2d(inplanes,
                                                     squeeze_planes,
                                                     kernel_size: 1);
                        this.squeeze_activation = new nn.ReLU();
                        this.expand1x1 = new nn.Conv2d(squeeze_planes,
                                                       expand1x1_planes,
                                                       kernel_size: 1);
                        this.expand1x1_activation = new nn.ReLU();
                        this.expand3x3 = new nn.Conv2d(squeeze_planes,
                                                       expand3x3_planes,
                                                       kernel_size: 3,
                                                       padding: 1);
                        this.expand3x3_activation = new nn.ReLU();
                    }

                    public override torch.Tensor forward(torch.Tensor x)
                    {
                        x = this.squeeze_activation.forward(this.squeeze.forward(x));
                        return torch.cat(new torch.Tensor[]{
                                             this.expand1x1_activation.forward(this.expand1x1.forward(x)),
                                             this.expand3x3_activation.forward(this.expand3x3.forward(x))
                                         }, 1);
                    }

                }

                public sealed class SqueezeNet : nn.Module
                {

                    public nn.Sequential features;

                    public nn.Sequential classifier;

                    public int num_classes;

                    public SqueezeNet(string version = "1_0",
                                      int num_classes = 1000)
                    {
                        this.num_classes = num_classes;
                        if(version == "1_0")
                        {
                            this.features = new nn.Sequential(
                                new nn.Conv2d(3, 96, kernel_size: 7, stride: 2),
                                new nn.ReLU(),
                                new nn.MaxPool2d(kernel_size: 3, stride: 2),
                                new Fire(96, 16, 64, 64),
                                new Fire(128, 16, 64, 64),
                                new Fire(128, 32, 128, 128),
                                new nn.MaxPool2d(kernel_size: 3, stride: 2),
                                new Fire(256, 32, 128, 128),
                                new Fire(256, 48, 192, 192),
                                new Fire(384, 48, 192, 192),
                                new Fire(384, 64, 256, 256),
                                new nn.MaxPool2d(kernel_size: 3, stride: 2),
                                new Fire(512, 64, 256, 256)
                            );
                        }
                        else
                        {
                            if(version == "1_1")
                            {
                                this.features = new nn.Sequential(
                                    new nn.Conv2d(3, 64, kernel_size: 3, stride: 2),
                                    new nn.ReLU(),
                                    new nn.MaxPool2d(kernel_size: 3, stride: 2),
                                    new Fire(64, 16, 64, 64),
                                    new Fire(128, 16, 64, 64),
                                    new nn.MaxPool2d(kernel_size: 3, stride: 2),
                                    new Fire(128, 32, 128, 128),
                                    new Fire(256, 32, 128, 128),
                                    new nn.MaxPool2d(kernel_size: 3, stride: 2),
                                    new Fire(256, 48, 192, 192),
                                    new Fire(384, 48, 192, 192),
                                    new Fire(384, 64, 256, 256),
                                    new Fire(512, 64, 256, 256)
                                );
                            }
                            else
                            {
                                throw new torch.TorchException(string.Format("TorchException: Unsupported SqueezeNet version {0}: 1_0 or 1_1 expected.", version));
                            }
                        }
                        var final_conv = new nn.Conv2d(512, this.num_classes, kernel_size: 1);
                        this.classifier = new nn.Sequential(
                            new nn.Dropout(p: 0.5),
                            final_conv,
                            new nn.ReLU(),
                            new nn.AvgPool2d(13, 13)
                        );
                    }

                    public torch.Tensor forward(torch.Tensor x)
                    {
                        if((x.shape[1] != 3) || (x.shape[2] != 224) || (x.shape[3] != 224))
                        {
                            throw new ArgumentException("Unsupported image size: should be bx3x224x224.");
                        }
                        x = this.features.forward(x) as torch.Tensor;
                        x = this.classifier.forward(x) as torch.Tensor;
                        return torch.flatten(x, 1);
                    }

                }

                public static SqueezeNet squeezenet1_0(bool pretrained = false, int num_classes = 1000)
                {
                    var m = new SqueezeNet("1_0");
                    if(pretrained)
                    {
                        m.load_state_dict(
                          __load_model("",
                                       "squeezenet1_0.thn",
                                       "https://github.com/ColorfulSoft/System.AI/raw/master/Implementation/src/torchvision/models/thn/squeezenet1_0.thn")
                        );
                    }
                    return m;
                }

                public static SqueezeNet squeezenet1_1(bool pretrained = false, int num_classes = 1000)
                {
                    var m = new SqueezeNet("1_1");
                    if(pretrained)
                    {
                        m.load_state_dict(
                          __load_model("",
                                       "squeezenet1_1.thn",
                                       "https://github.com/ColorfulSoft/System.AI/raw/master/Implementation/src/torchvision/models/thn/squeezenet1_1.thn")
                        );
                    }
                    return m;
                }

            }

        }

    }

}