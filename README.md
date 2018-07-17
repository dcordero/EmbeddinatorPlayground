# EmbeddinatorPlayground

Version: 
`Embeddinator-4000 v0.1 (0.4: 7664197)`

Logs:
```
~/.nuget/packages/embeddinator-4000/0.4.0/tools/objcgen EmbeddinatorPlayground/bin/Debug/netstandard2.0/EmbeddinatorPlayground.dll --target=framework --platform=iOS --outdir=output -c --debug
Symbol file /Users/dcordero/.nuget/packages/embeddinator-4000/0.4.0/tools/IKVM.Reflection.pdb doesn't match image /Users/dcordero/.nuget/packages/embeddinator-4000/0.4.0/tools/IKVM.Reflection.dll
Parsing assemblies...
	Parsed 'EmbeddinatorPlayground/bin/Debug/netstandard2.0/EmbeddinatorPlayground.dll'
Processing assemblies...
	1 types found
Generating binding code...
error EM0009: The feature `Converting type System.Net.Http.HttpClient to mono code` is not currently supported by the tool
Debug Log:
Processing: 1 assemblies
Processing Assembly: EmbeddinatorPlayground
Processing Type: EmbeddinatorPlayground_MyDummyClass
TypeMapper Register: System.Void .ctor(System.Net.Http.HttpClient) initWithClient:
TypeMapper Register: System.Void FetchData() fetchData
Begin Generator
Generating Assembly: EmbeddinatorPlayground
Generating Type: EmbeddinatorPlayground_MyDummyClass
```
