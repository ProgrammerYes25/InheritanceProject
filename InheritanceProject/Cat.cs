using InheritanceProject;
using System;
using System.Runtime.CompilerServices;

namespace InheritancePrac31
{
    internal class Cat : Animal
    {

        public void Meow() { Console.WriteLine("냥냥 웁니다."); }

        public void TestB()
        {
            //Private();
            Protected();
            Public();
        }

    }
}