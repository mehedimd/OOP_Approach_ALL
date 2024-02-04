using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_OOP
{
    
    public class GenericAnimal<T> : IGenericBehavior<T>
    {
        public string GetGenericBehavior(T obj)
        {
            string behavior = string.Empty;
            if (obj is Animal)
            {
                Animal a = obj as Animal;
                switch (a.Type)
                {
                    case AnimalType.Harvivore:
                        behavior = "Lives on harvs, four footed";
                        break;
                    case AnimalType.Carnivore:
                        behavior = "Have canine, meat eater";
                        break;
                    case AnimalType.Omnivore:
                        behavior = "Diverse eating bahvior, adaptable";
                        break;
                    default:
                        behavior = "Unknown behaviour";
                        break;
                }

            }
            else
            {
                behavior = "Not an animal";
            }
            return behavior;
        }
    }

}
