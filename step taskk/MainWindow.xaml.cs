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

namespace step_taskk
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LV.ItemsSource = Database.cars;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            second second = new();
            second.add_uptade_btn.Content = "Add";
            Database._index = LV.SelectedIndex;
            second.Show();

            this.Close();
            LV.ItemsSource = Database.cars;
        }

        private void LV_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            second second = new();
            second.marka_txt.Text = Database.cars[LV.SelectedIndex].Marka.ToString();
            second.model_txt.Text = Database.cars[LV.SelectedIndex].Model.ToString();
            second.price_txt.Text = Database.cars[LV.SelectedIndex].Price.ToString();
            second.add_uptade_btn.Content = "Uptade";
            Database._index = LV.SelectedIndex;
            second.Show();
            second.Show();


            this.Close();
            
            
            LV.ItemsSource = Database.cars;



            // Database.cars[LV.SelectedIndex];
        }
    }

    public class Database
    {
        public static int _index;
        public static List<Car> cars = new List<Car>();
        static Database()
        {
            cars.Add(new Car("Toyota", "Corolla", "30000"));
            cars.Add(new Car("Honda", "Civic", "28000"));
        }
    }

    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }

        public Car()
        {
            this.Marka = string.Empty;
            this.Model = string.Empty;
            this.Price = string.Empty;
        }

        public Car(string _Marka,string _Model,string _Price)
        {
            this.Marka = _Marka;
            this.Model = _Model;
            this.Price = _Price;
        }

        public override string ToString()
        {
            return $" {this.Marka} - {this.Model} - {this.Price}\n";
        }
    }
}