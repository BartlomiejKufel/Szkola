using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutDemo
{
    public class AppFlyoutPageFlyoutMenuItem
    {
        public AppFlyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(AppFlyoutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public string Icon { get; set; }
    }
}