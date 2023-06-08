using System;
using System.Security.Cryptography.X509Certificates;

namespace InheritanceProject
{
    internal class Dog : Animal
    {
        public string Color { get; set; }

        public void testB()
        {
    //        Private();
            Protected();
            Public();
        }


        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }

    }
}