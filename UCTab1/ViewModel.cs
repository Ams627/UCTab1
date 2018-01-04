using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace UCTab1
{
    public class ViewModel
    {
        public List<TabItem> Tabs { get; set; }
        public ViewModel()
        {
            Tabs = new List<TabItem>
            {
                new TabItem { Content= new UserControl1() },
                new TabItem { Content="World" }
            };

        }
    }
}
