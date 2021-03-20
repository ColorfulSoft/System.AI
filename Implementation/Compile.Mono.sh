cd System.AI/Implementation/
mkdir Release
csc @System.AI.unix.rsp
mv Release/System.AI.dll ../../System.AI.dll
mv Release/System.AI.xml ../../System.AI.xml
cd ../../
