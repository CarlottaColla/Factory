using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Factory
    {
        public static void FactoryDog(string criteria)
        {
            //L'implementazione di questa factory nel cliente non la vedo
            Dog dog = null;
            if (criteria.Equals("Beagle"))
            {
                //Da fuori non so che sta facendo questo
                var anni = 7 * DateTime.Today.Year;
                dog = new Beagle(anni);
            }
            else if(criteria.Equals("Boxer"))
            {
                dog = new Boxer();
            } 
            else if (criteria.Equals("Yorkshire"))
            {
                dog = new Yorkshire();
            }
            else
            {
                Console.WriteLine("Input sbagliato");
                return;
            }
            dog.Speak();
        }
    }
}
