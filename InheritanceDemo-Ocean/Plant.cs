using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo_Ocean
{
    class Plant: Entity
   {

        public override void Consume()
        {
            //photosysnthiss occurs
            base.Consume();
        }
    }
}
