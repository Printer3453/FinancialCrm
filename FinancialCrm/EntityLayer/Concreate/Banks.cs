using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Entities
{
    public class Banks
    {
        public int BankId { get; set; }
        public string BankTitle { get; set; }
        public decimal BankBalance { get; set; }
        public int BankAccountNumber { get; set; }

    }
}
