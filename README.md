# DEPENDENCIES

[Antlr4](https://www.antlr.org/download.html)
[Antlr4.Runtime.Standard](https://www.nuget.org/packages/Antlr4.Runtime.Standard/4.9.2)

# BUILD

`dotnet new console -o Example/FunscriptParsingTest/`

`java -jar tools/antlr-4.9.2-complete.jar -Dlanguage=CSharp grammar/funscript.g4 -o Example/FunscriptParsingTest/`

`dotnet run --project Example/FunscriptParsingTest/`

# REFERENCE
https://github.com/antlr/antlr4/blob/master/doc/csharp-target.md
https://github.com/antlr/antlr4/tree/master/runtime/CSharp/src
https://www.youtube.com/watch?v=P2ieCglznEI
https://github.com/antlr/antlr4/blob/master/doc/tool-options.md