using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro.Services
{
    public class CompanySettings
    {
        public int Id { get; set; }
        public double Exact { get; set; }
        public double Amount { get; set; }
        public bool PriceWithDDS { get; set; }
        public bool NegativeAmount { get; set; }
        public int PaymentMethods { get; set; }
        public bool AutomaticProduction { get; set; }
        public bool ZDDS { get; set; }
        public bool MinimalOptimalAmount { get; set; }
        public string DbPlace { get; set; }
    }
}
