SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319
SET LIBPATH=../io-swagger-client/bin
echo %LIBPATH%
%CSCPATH%\csc /noconfig /reference:%LIBPATH%/Newtonsoft.Json.dll;%LIBPATH%/RestSharp.dll;%LIBPATH%/IO.Swagger.dll;System.ServiceModel.dll /target:library /out:bin/ReadyAPI.TestServer.Client.dll /recurse:.\*.cs

