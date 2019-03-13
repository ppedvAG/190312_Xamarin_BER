using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMitMasterDetail
{

    public class PageMenuItem
    {
        public PageMenuItem(Type TargetType,bool WithNavigation = false)
        {
            this.TargetType = TargetType;
            this.WithNavigation = WithNavigation;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
        public bool WithNavigation { get; private set; }
    }
}