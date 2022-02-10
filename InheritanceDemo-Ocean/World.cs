using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_Ocean
{
    class World
    {
        List<Entity> Creatures = new List<Entity>() 
        
        { 
        
        new Mammal(){Name="" },
        new Fish()
        
        };

        public void Start()
        {
            foreach (Entity e in Creatures)
            {
                if (e is Fish)
                {

                }

            }
        }

        public string ShowAllCreatures()
        {
            return "";
        }
    }
}
