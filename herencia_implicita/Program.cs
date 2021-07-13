using System;
using System.Reflection;
using static System.Console;
using ExtensionMethods;

namespace herencia_implicita
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().usingReflection();
            //new Program().UsingExtendingList();
            //new Program().UsingCustomException(true);
            new Program().UsingExtensionMethod();

        }

        public void usingReflection()
        {

            Type t = typeof(SimpleClass);
            BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                                 BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
            MemberInfo[] members = t.GetMembers(flags);
            Console.WriteLine($"Type {t.Name} has {members.Length} members: ");
            foreach (var member in members)
            {
                string access = "";
                string stat = "";
                var method = member as MethodBase;
                if (method != null)
                {
                    if (method.IsPublic)
                        access = " Public";
                    else if (method.IsPrivate)
                        access = " Private";
                    else if (method.IsFamily)
                        access = " Protected";
                    else if (method.IsAssembly)
                        access = " Internal";
                    else if (method.IsFamilyOrAssembly)
                        access = " Protected Internal ";
                    if (method.IsStatic)
                        stat = " Static";
                }
                var output = $"{member.Name} ({member.MemberType}): {access}{stat}, Declared by {member.DeclaringType}";
                Console.WriteLine(output);
            }
        }

        public void UsingExtendingList()
        {
            UniqueList<string> listaUnica = new UniqueList<string>();

            listaUnica.Add("jose carlos");
            listaUnica.Add("jose carlos");
            listaUnica.Add("daniel");
            listaUnica.Add("javier");
            listaUnica.Add("sergio");
            listaUnica.Add("daniel");
            listaUnica.Add("daniel");
            listaUnica.Add("daniel");
            listaUnica.Add("carola");


            WriteLine("La primera vez: ");
            foreach (var lista in listaUnica)
            {
                WriteLine(lista);
            }

            WriteLine("\nQuitando duplicados");
            listaUnica.RemoveDuplicate();
            foreach (var lista in listaUnica)
            {
                WriteLine(lista);
            }
        }

        public void UsingCustomException(bool generaException)
        {
            try
            {
                WriteLine("Paso por la linea del try");
                if (generaException)
                {
                    WriteLine("Paso por la linea de genera excepcion");
                    throw new LotaltyCardNotFoundException("nuestro mensaje personalizado del error");
                }
                WriteLine("Paso por la linea 87");
            }
            catch (LotaltyCardNotFoundException ex)
            {
                WriteLine("Paso por la linea de error");
                WriteLine(ex.Message);
            }
            finally
            {
                WriteLine("Paso por la linea de finally");
            }
        }

        public void UsingExtensionMethod()
        {
            WriteLine("Please type some text that contains numbers and then press Enter");
            string text = Console.ReadLine();
            if(text.ContainsNumber())
            {
            Console.WriteLine("Your text contains numbers. Well done!");
            }
            else
            {
            Console.WriteLine("Your text does not contain numbers. Please try again.");
            }
        }
    }

    public class SimpleClass
    {
        SimpleClass() { }
        SimpleClass(string SimpleOtherProperty)
        {
            this.SimpleOtherProperty = SimpleOtherProperty;
        }
        private void SimpleMethod() { }
        private int simpleProperty;
        public int SimpleProperty { get { return SimpleProperty; } set { SimpleProperty = value; } }
        private string simpleOtherProperty;
        public string SimpleOtherProperty { get => SimpleOtherProperty; set => SimpleOtherProperty = value; }
    }
}

