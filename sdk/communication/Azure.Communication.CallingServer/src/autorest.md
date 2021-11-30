# Azure.Communication.CallingServer

When a new version of the swagger needs to be updated:
1. Open Azure.Communication.sln and under sdk\communication, run `dotnet msbuild /t:GenerateCode` to generate code.

2. Upload the Azure.Communication.Call.dll to the [apiview.dev tool](https://apiview.dev/).
If any of the new objects needs to be overwritten, add the required changes to the 'Models' folder.

3. Repeat 2 and 3 until the desided interface is reflected in the apiview.dev.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
public-clients: true
title: Calling server
model-namespace: false
require: 
    - https://raw.githubusercontent.com/navali-msft/azure-rest-api-specs/06826c0bc7bbcabb3b61b7d07eb87bb7d88bb924/specification/communication/data-plane/CallingServer/readme.md
payload-flattening-threshold: 10
clear-output-folder: true
```
