using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace ApiTestWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_Loaded_London(object sender, RoutedEventArgs e)
        {
            string l = "London";
            string url =$"https://api.openweathermap.org/data/2.5/weather?q={l}&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);    
            
            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream()); 
            string response = reader.ReadToEnd();
            

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            tb1.Text = weatherResponse.Name;
            tb2.Text = weatherResponse.Main.Temp.ToString();
            tb3.Text = weatherResponse.Main.feels_like.ToString();
        }

        private void TextBox_Loaded_Moscow(object sender, RoutedEventArgs e)
        {
            string m = "Moscow";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={m}&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            tb1.Text = weatherResponse.Name;
            tb2.Text = weatherResponse.Main.Temp.ToString();
            tb3.Text = weatherResponse.Main.feels_like.ToString();
        }
        private void TextBox_Loaded_Kazan(object sender, RoutedEventArgs e)
        {
            string k = "Kazan";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={k}&appid=6d6f583dd6f204ba8a29096a7ba55711&units=metric";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            //ответ от сервера
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            StreamReader reader = new StreamReader(res.GetResponseStream());
            string response = reader.ReadToEnd();
            

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            tb1.Text = weatherResponse.Name;
            tb2.Text = weatherResponse.Main.Temp.ToString();
            tb3.Text = weatherResponse.Main.feels_like.ToString();
        }
    }
}
