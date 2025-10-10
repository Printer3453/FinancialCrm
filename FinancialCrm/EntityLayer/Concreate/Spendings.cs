using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Entities
{
    public class Spendings
    {
        public int SpendingId { get; set; }
        public String SpendingTitle { get; set; }
        public decimal SpendingAmount { get; set; }
        public DateTime SpendingDate { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        public int BankId { get; set; }

    }
}
