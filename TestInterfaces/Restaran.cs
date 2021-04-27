using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaces
{
    public class Restaurant : Room, IBathroom, IKitchen
    {
        public Restaurant()
        {
            Room = "thisroom";
        }
        public string Room { get; set; }
        public void GetHumidity()
        {
            
        }
        
    }
}
