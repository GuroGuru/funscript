using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace FunscriptParsingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input funscript file path: ");
            string filePath = Console.ReadLine();

            AntlrFileStream stream = new AntlrFileStream(filePath);
            ITokenSource lexer = new funscriptLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            funscriptParser parser = new funscriptParser(tokens);
            IParseTree tree = parser.script();

            Console.WriteLine(tree.ToStringTree());
        }
    }
}
