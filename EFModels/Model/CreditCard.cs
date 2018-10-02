using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFModels.Model
{
    public class CreditCard
    {
        public string CardNumber { get; set; }

        public DateTime ExpirationDate { get; set; }
        public string CardHolderName { get; set; }


        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }


    }
}
