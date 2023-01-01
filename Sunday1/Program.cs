using System;
using System.Reflection;

namespace Sunday1
{
    class Program
   {
    //    Assembly excutingAssemply = Assembly.GetExecutingAssembly();
    //    Type customerType = excutingAssemply.GetType("Sunday1.nulll"); // null, we dont have class nulll [[late binding]]
    //    object customerInstance = Activator.CreateInstance(customerType);

        public int id { get; set; }

        public string name { get; set; }

        public int age { get; set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("hi");

            Type T = Type.GetType("Sunday1.Program");  
            Console.WriteLine("Name"+ "\t" + T.Name);
            Console.WriteLine("Full Name" + "\t" + T.Namespace);

            PropertyInfo[] properties= T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.Write(property.Name + "\t"+"Type:"+ "\t" );
                Console.WriteLine(property.PropertyType.Name);

            }

           MethodInfo[] methodes = T.GetMethods();
            foreach (MethodInfo methode in methodes)
            {
                Console.WriteLine(methode.ReturnType.Name+" cc" +methode.Name);
                Console.ReadLine();

            }
        }

        public  void MyMethod() { }
    }

}