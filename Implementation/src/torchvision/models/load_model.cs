using System;
using System.IO;
using System.Net;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torchvision
        {

            public static partial class models
            {

                static models()
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                }

                internal static Dictionary<string, torch.Tensor> __load_model(string path, string fname, string url, bool print = true)
                {
                    if(File.Exists(path + fname))
                    {
                        return (Dictionary<string, torch.Tensor>)torch.load(path);
                    }
                    else
                    {
                        if(print)
                        {
                            Console.WriteLine("Downloading " + fname + " from " + url);
                        }
                        (new WebClient()).DownloadFile(url, path + fname);
                        return (Dictionary<string, torch.Tensor>)torch.load(path + fname);
                    }
                }

            }

        }

    }

}
