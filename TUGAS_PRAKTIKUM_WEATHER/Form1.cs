using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

//NAMA    : NADITYA PUTRI LESTARI
//NIM     : 222410103003
//KELAS   : PBO C
//TUGAS   : API WEATHER

namespace TUGAS_PRAKTIKUM_WEATHER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "28f367d6e42f7033b5ea4b114c4c1f74";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", tbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picboxicon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                Console.WriteLine(picboxicon.ImageLocation);

                condition.Text = Info.weather[0].main;
                details.Text = Info.weather[0].description;
                na2.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                na1.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                na3.Text = Info.wind.speed.ToString();
                na4.Text = Info.main.pressure.ToString();

            }
        }
        DateTime convertDateTime(long second)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(second).ToLocalTime();

            return day;
        }

    }
}
