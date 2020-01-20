using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using SLClass;

namespace SLMain
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            UserControl myPage = new SLClass.SilverlightControl1();
            Canvas myC = (Canvas)this.LayoutRoot.FindName("canvas1");
            myC.Children.Add(myPage);
        }
    }
}
