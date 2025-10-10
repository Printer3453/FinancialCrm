using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Entities
{
    public class BankProcesses
    {
        public int BankProcessId { get; set; }
        public int BankId { get; set; }
        public DateTime ProcessDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool ProcessTypeId { get; set; } // true: para yatırma, false: para çekme
        public int UserId { get; set; }
    }
}
