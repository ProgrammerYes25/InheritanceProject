using System;

namespace InheritanceProject
{
    internal class Animal
    {

        private void Private() 
        { 
            
        }
        protected void Protected() { 
        
        }
        public void Public() { 
        
        }

        public void testA() {
            Private();
            Protected();
            Public();
        }
  
        public int Age {get; set;}
        public Animal()
        {
            this.Age = 0;
        }


        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }

        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
    }
}