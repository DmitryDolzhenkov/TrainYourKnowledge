using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaces
{
    interface IBathroom
    {
        string Room { get; set; }
        void GetHumidity();
    }
}
