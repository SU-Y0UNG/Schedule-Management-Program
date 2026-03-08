using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace maverCalender
{
    public partial class detailPopup : Form
    {
        public detailPopup()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            // 프로젝트 폴더에 넣어둔 'client_secrets.json' 파일을 읽어옵니다.
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                string[] scopes = { CalendarService.Scope.CalendarReadonly };

                // 구글 인증 브라우저를 띄웁니다.
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true));
            }

            MessageBox.Show("로그인 성공!");
        }
        string cityName = "Seoul";
        public async void GetWeather()
        {
            string apiKey = "c7772d91da4472af145add9c179343de";
            string cityName = "Seoul";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric&lang=kr";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // API에 데이터 요청
                    string response = await client.GetStringAsync(url);

                    // JSON 데이터를 클래스 객체로 변환
                    WeatherInfo data = JsonConvert.DeserializeObject<WeatherInfo>(response);

                    // 화면에 표시 (레이블 등)
                    lblCity.Text = data.Name;
                    lblTemp.Text = $"{data.Main.Temp} °C";
                    lblDesc.Text = data.Weather[0].Description;

                    // 아이콘 이미지 불러오기 (이미지 URL 활용)
                    string iconUrl = $"http://openweathermap.org/img/wn/{data.Weather[0].Icon}@2x.png";
                    pictureBoxWeather.Load(iconUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("날씨 정보를 가져오지 못했습니다: " + ex.Message);
                }
            }
        }


        private void detailPopup_Load(object sender, EventArgs e)
        {
            GetWeather();
        }
        private Color selectedColor = Color.SkyBlue;


         
      

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            // 색상 선택창 띄우기
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;

                // 버튼 배경색을 선택한 색으로 바꿔서 사용자가 바로 확인하게 함
                btnSelectColor.BackColor = selectedColor;
            }
        }
    }
}
