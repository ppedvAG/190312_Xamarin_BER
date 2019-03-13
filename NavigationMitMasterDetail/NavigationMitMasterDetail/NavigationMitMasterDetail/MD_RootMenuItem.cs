using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMitMasterDetail
{

    public class MD_RootMenuItem
    {
        public MD_RootMenuItem()
        {
            TargetType = typeof(MD_RootDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}