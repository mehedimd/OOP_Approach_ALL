using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_OOP
{
    public class TypeSpecificAnimal<T> : ITypeSpecificBehavior<T>
    {

        public string GetTypeSpecificBehavior<T>(T data) where T : Animal
        {
            string behavior = string.Empty;
            switch (data.Type)
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
            return behavior;
        }
    }

}
