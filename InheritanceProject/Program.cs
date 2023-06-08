using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animal = new List<Animal>() { new Dog(), new Dog(), new Dog(),  new Cat(), new Cat() , new Cat() );

            foreach(var item in Animal)
            {
                item.Eat();
                item.Sleep();

                Dog dog = item as Dog;
                if (dog != null)
                {
                    dog.Bark();
                }


                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }
                else if (item is Cat) {
                    ((Cat)item).Meow();
                }
                
                
            }
        }
    } 
}
