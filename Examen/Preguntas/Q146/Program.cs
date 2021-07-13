using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
namespace Q146 // ERRATA Respuesta A con TypeAttributes = TypeAttributes.Public  y C quitando la segunda linea que sobra
{
    class Program
    {
        static void Main(string[] args)
        {
            string gc = new CodeDomGeneration().GenerateCode("Customer", "Add");
            Console.WriteLine(gc);
        }
    }
    public class CodeDomGeneration
    {
        public string GenerateCode(string className, string methodName)
        {
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CodeCompileUnit cu = new CodeCompileUnit();
            CodeNamespace ns = new CodeNamespace("Q146");
            ns.Imports.Add(new CodeNamespaceImport("System"));
            cu.Namespaces.Add(ns);

            var ct = new CodeTypeDeclaration(className)           // Create Class className
            {
                //ct.Attributes = MemberAttributes.Public;        // NO aplica a la clase  
                //Attributes = MemberAttributes.Private,          // No aplica a la clase  
                //TypeAttributes = TypeAttributes.NestedPrivate,  // Aplica para generar una clase privada
                TypeAttributes = TypeAttributes.Public,
                IsClass = true,
                //IsInterface = true,
                //IsStruct = true,
                //IsPartial = true,
            };

            ns.Types.Add(ct);

            /*var ct1 = new CodeTypeDeclaration("subClass");
            //ct1.Attributes = MemberAttributes.Private; // No aplica a la subclase
            ct1.TypeAttributes = TypeAttributes.NestedPrivate;
            ct1.IsClass = true;
            ct.Members.Add(ct1);*/

            var mt = new CodeMemberMethod { Name = methodName }; // Create Method
            var csSystemConsoleType = new CodeTypeReferenceExpression("System.Console");
            var cs1 = new CodeMethodInvokeExpression(csSystemConsoleType, "WriteLine", new CodePrimitiveExpression("Customer Added"));
            mt.Attributes = MemberAttributes.Private;
            mt.Statements.Add(cs1);
            ct.Members.Add(mt);

            String sourceFile;
            if (provider.FileExtension[0] == '.')
                sourceFile = "TestGraph" + provider.FileExtension;
            else
                sourceFile = "TestGraph." + provider.FileExtension;
            // Create an IndentedTextWriter, constructed with a StreamWriter to the source file.
            IndentedTextWriter tw = new IndentedTextWriter(new StreamWriter(sourceFile, false), "    ");
            provider.GenerateCodeFromCompileUnit(cu, tw, new CodeGeneratorOptions());  // Generate source code using the code generator.
            tw.Close();

            string gc = File.ReadAllText(sourceFile);
            return gc;
        }
    }
}
