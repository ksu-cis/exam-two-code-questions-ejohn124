using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
            IceCreamYes.IsEnabled = false;
            IceCreamNo.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = (Cobbler)DataContext;
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "CherryButton":
                    cobbler.Fruit = FruitFilling.Cherry;
                    break;
                case "PeachButton":
                    cobbler.Fruit = FruitFilling.Peach;
                    break;
                case "BlueberryButton":
                    cobbler.Fruit = FruitFilling.Blueberry;
                    break;

                case "IceCreamYes":
                    cobbler.WithIceCream = true;
                    IceCreamYes.IsEnabled = false;
                    IceCreamNo.IsEnabled = true;
                    break;
                case "IceCreamNo":
                    cobbler.WithIceCream = false;
                    IceCreamNo.IsEnabled = false;
                    IceCreamYes.IsEnabled = true;
                    break;
            }
        }

        private void IceCreamYes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
