# (C) ColorfulSoft corp., 2021. All Rights reserved
# PyTorch to Torch.NET checkpoint converter

import torch;
import sys;
import numpy;
import struct;

def main(argv: [str]) -> None:
    if(len(argv) != 2):
        print("Expected pytorch file name");
    with open(argv[1] + ".thn", 'wb') as ckpt:
        header = struct.Struct('= B 10s i B');
        integer = struct.Struct('= i');
        byte = struct.Struct('= B');
        ckpt.write(header.pack(10, "Torch.NET>".encode('ASCII'), 0, 1));
        m = torch.load(argv[1], map_location = 'cpu');
        for p in m:
            bin = bytearray((' ' + str(p)).encode('ASCII'));
            bin[0] = len(str(p));
            ckpt.write(bin);
            size = torch.tensor(m[p].shape).int();
            ckpt.write(integer.pack(len(m[p].shape)));
            ckpt.write(size.numpy().tobytes());
            if(m[p].dtype == torch.float16):
                bin = byte.pack(0);
                break;
            elif(m[p].dtype == torch.float32):
                bin = byte.pack(1);
            elif(m[p].dtype == torch.float64):
                bin = byte.pack(2);
            elif(m[p].dtype == torch.uint8):
                bin = byte.pack(3);
            elif(m[p].dtype == torch.int8):
                bin = byte.pack(4);
            elif(m[p].dtype == torch.int16):
                bin = byte.pack(5);
            elif(m[p].dtype == torch.int32):
                bin = byte.pack(6);
            elif(m[p].dtype == torch.int64):
                bin = byte.pack(7);
            elif(m[p].dtype == torch.bool):
                bin = byte.pack(8);
            else:
                raise "Unsupported tensor type.";
            ckpt.write(bin);
            ckpt.write(m[p].numpy().tobytes());

if __name__ == "__main__":
    main(sys.argv);
