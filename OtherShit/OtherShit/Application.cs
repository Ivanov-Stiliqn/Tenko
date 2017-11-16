using System;

namespace OtherShit
{
    class Application
    {
        static void Main(string[] args)
        {
            var student = new Student("Pesho", "Petrov", "Petrov", "IT", 5.40m);
          
            Console.WriteLine(student.ToString());
        }
    }
}
