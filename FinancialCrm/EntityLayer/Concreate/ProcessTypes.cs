using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Entities
{
    public class ProcessTypes
    {
        public int ProcessTypeId { get; set; }
        public string ProcessTypeName { get; set; } // "Para Yatırma" veya "Para Çekme"
    }
}
