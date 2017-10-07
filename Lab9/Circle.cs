using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        
        public double radius;






        public double Radius

        { 
            set { radius = value; }

            get { return radius; }

        }

        public double Circumferance ()
        {
            
            return (Math.PI * 2 * radius);
        }

        public  double GetArea ()

        {

            return (Math.PI * Math.Pow(radius, 2));
            

        }


      
    }
}
