#!/usr/bin/env bash
mkdir -p bin;
mcs -sdk:45 -r:../io-swagger-client/bin/Newtonsoft.Json.dll,\
../io-swagger-client/bin/RestSharp.dll,\
../io-swagger-client/bin/IO.Swagger.dll,\
System.Runtime.Serialization.dll, \
System.ServiceModel.dll, \
System.dll, \ 
System.Core.dll \
-target:library \
-out:bin/ReadyAPI.TestServer.Client.dll \
-recurse:'./*.cs' \
-doc:bin/ReadyAPI.TestServer.Client.xml \
-platform:anycpu
