using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApplicationService.Dots
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }
        public int PagingSize { get; set; }
    }
}
