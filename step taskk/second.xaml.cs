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
using System.Windows.Shapes;

namespace step_taskk
{
    /// <summary>
    /// Interaction logic for second.xaml
    /// </summary>
    public partial class second : Window
    {
        public second()
        {
            InitializeComponent();
        }

        private void add_uptade_btn_Click(object sender, RoutedEventArgs e)
        {
            if (add_uptade_btn.Content == "Add")
            {
                if (marka_txt.Text != "" && model_txt.Text != "" && price_txt.Text != "")
                {
                    Car new_car=new Car(marka_txt.Text,model_txt.Text,price_txt.Text);
                    Database.cars.Add(new_car);
                }
                
            }
            else if(add_uptade_btn.Content=="Uptade")
            {
                if (marka_txt.Text != "" && model_txt.Text != "" && price_txt.Text != "")
                {
                    Database.cars[Database._index].Marka=marka_txt.Text;
                    Database.cars[Database._index].Model=model_txt.Text;
                    Database.cars[Database._index].Price=price_txt.Text;
                    
                }

            }
            //MessageBox.Show(Database.cars[2].Model.ToString());
            MainWindow mainWindow = new();
            mainWindow.Show();
            this.Close();


        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            this.Close();
        }
    }
}
