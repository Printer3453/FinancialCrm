using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Entities
{
    public class Bills
    {
        public int BillId { get; set; }
        public string BillTitle { get; set; }
        public decimal BillAmount { get; set; }
        public int BillPeriodId { get; set; }
        public int BankId { get; set; }
        public bool IsPaid { get; set; }
        public int UserId { get; set; }


    }
}
