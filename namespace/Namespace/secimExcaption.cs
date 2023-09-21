using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecimExcaptions
{
    public class secimExcaption:ArgumentException
    {
        public override string Message => "Ele secim yoxdur";
    }
}
