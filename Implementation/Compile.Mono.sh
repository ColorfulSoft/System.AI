#!/usr/bin/env bash

cd "$(dirname "$0")"
mkdir Release
csc @System.AI.unix.rsp
for extension in dll xml
do
  mv "Release/System.AI.$extension" "../../System.AI.$extension"
done
