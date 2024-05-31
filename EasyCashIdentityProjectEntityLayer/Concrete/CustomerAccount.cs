using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    //Eğer access modifier olarak internal kullanılırsa diğer katmanlarda class'a erişim sağlanmaz
    public  class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set; } //para birimi
        public string CustomerAccountBalance { get; set; } //bakiye
        public string BankBranch { get; set; }

    }
}
