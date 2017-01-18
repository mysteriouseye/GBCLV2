﻿using System.Windows.Controls;

namespace GBCLV2.Controls
{
    /// <summary>
    /// About.xaml 的交互逻辑
    /// </summary>
    public partial class About : Grid
    {
        public About()
        {
            InitializeComponent();
        }

        private void Open_Link(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            e.Handled = true;
            System.Diagnostics.Process.Start((sender as TextBlock).Text);
        }
    }
}
