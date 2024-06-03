using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
{
    /// <summary>
    /// Логика взаимодействия для UserShopingCart.xaml
    /// </summary>
    public partial class UserShopingCart : UserControl
    {
        public int MaxValue { get; set; }
        public event RoutedEventHandler ValueChanged;

        public int Value
        {
            get { return (int)GetValue(ValuepertyProperty); }
            set { SetValue(ValuepertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Valueperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValuepertyProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(UserShopingCart), new PropertyMetadata(0));

        public UserShopingCart()
        {
            InitializeComponent();
            Value = 0;
            productsCountTextBox.Text = Value.ToString();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.ValueChanged != null)
                this.ValueChanged(this, e);
            if (Value != MaxValue)
            {
                Value++;
                productsCountTextBox.Text = Value.ToString();
            }
            else
                plusButton.IsEnabled = false;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.ValueChanged != null)
                this.ValueChanged(this, e);
            if (Value != 0)
            {
                Value--;
                productsCountTextBox.Text = Value.ToString();
            }
            else
                minusButton.IsEnabled = false;
        }
    }
}
