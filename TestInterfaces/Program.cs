using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Room restik = new Restaurant();
            restik.GetArea();

            IBathroom bath = restik as IBathroom;
            bath.GetHumidity();
            var room = bath.Room;
            Type type = restik.GetType();
            var asm = type.Assembly;
            Type t = typeof(Restaurant);

        }
    }
}
