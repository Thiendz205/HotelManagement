using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ServiceET
    {
        public ServiceET()
        {
           
        }
        
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
