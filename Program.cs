using System;
namespace Exercise {
    public class StudentCode {
        public static string GreetMe(string name){
            return "Hello,"+ name;
        }
    }
    class Program{
        static void Main(string[] args ){
            Console.WriteLine(StudentCode.GreetMe("Adam"));
        }
    }
}