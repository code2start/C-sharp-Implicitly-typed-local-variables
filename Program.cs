using System;

namespace varlocalvariable
{
    class Program
    {
        static void Main(string[] args)
        {
            char a1 = 'M';
            var a2 = "Mohamed";
            Console.WriteLine("the type of a2 {0}" , a2.GetType().ToString());
            var agree = true;
            Console.WriteLine("the type of aree is "+agree.GetType().ToString());
            var courses = new []{"Android","ASP.net Core","PHP"};
            var s1 = new {Name = "Mohamed Fathy",Age = 38};
            Console.WriteLine(s1.Name);

            //var x;//invalid
        }
    }
}
