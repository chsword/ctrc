using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRC
{
    public class CTRCHelper
    {
        public static EnumFlunt<T> GetEmnum<T>() where T :Enum{
            return new EnumFlunt<T>();
        }
    }
}
