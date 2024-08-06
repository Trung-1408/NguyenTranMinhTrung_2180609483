using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class LopListview
    {
        public int MaLop { get; set; }
        public string TenLop { get; set; }

        public override string ToString()
        {
            return TenLop;
        }
    }
}
