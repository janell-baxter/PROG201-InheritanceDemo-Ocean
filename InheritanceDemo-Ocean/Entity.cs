using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_Ocean
{
    class Entity
    {
        public string Name;

        public Entity()
        {

        }
        public Entity(string name)
        {
            Name = name;
        }

        public virtual void Consume()
        {

            //name of the animal eats
        }
    }
}
