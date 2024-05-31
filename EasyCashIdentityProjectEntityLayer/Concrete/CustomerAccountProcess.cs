using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        //id, islem türü, tutar , tarih ,a1,a2
        public int CustomerAccountProcessID { get; set; }
        public int ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }

    }
}
