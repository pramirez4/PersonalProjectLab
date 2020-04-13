using System;
namespace PersonalProjectLab
{
    public class TireClass
    {
        public TireClass()
        {

        }
        public decimal tireConverion(decimal oldTire, decimal newTire, decimal shownSpeed)
        {
            //actual speed = new tire/ old tire * shown speed
            decimal actualSpeed = 0.0m;

            actualSpeed = (newTire * shownSpeed) / oldTire ;

            return actualSpeed; 
        }

      
        }
    }
//}
