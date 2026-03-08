using Project_Maver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maver_켈린더
{
    public partial class JoinMembership : Form
    {

        public JoinMembership()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        // 생년월일 설정

        private void InitializeComboBoxes()
        {
            cbYear.Items.Clear();
            cbMonth.Items.Clear();
            cbDay.Items.Clear();

            //1. 연도 설정
            for (int year = 1940; year <= 2020; year++)
            {
                cbYear.Items.Add(year);
            }

            //2. 월 설정 : 1월~12월
            for (int month = 1; month <= 12; month++)
            {
                cbMonth.Items.Add(month);
            }

            ////3.일 설정 : 1일부터 31일 까지
            //for (int day = 1; day <= 31; day++)
            //{
            //    cbDay.Items.Add(day);
            //}

        }

        private void UpdateDays()
        {
            // 연도와 월이 모두 선택되었는지 확인
            if (cbYear.SelectedItem == null || cbMonth.SelectedItem == null)
                return;

            int year = (int)cbYear.SelectedItem;
            int month = (int)cbMonth.SelectedItem;

            // 현재 선택되어 있는 '일'을 기억해둡니다 (나중에 다시 선택해주기 위함)
            int? currentSelectedDay = (int?)cbDay.SelectedItem;

            cbDay.Items.Clear();

            // 해당 연도와 월의 마지막 날짜를 계산 (예: 2024년 2월 -> 29)
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                cbDay.Items.Add(day);
            }

            // 이전에 선택했던 날이 여전히 유효하다면 다시 선택해주고, 
            // 아니라면 첫 번째 항목(1일)을 선택합니다.
            if (currentSelectedDay.HasValue && currentSelectedDay <= daysInMonth)
            {
                cbDay.SelectedItem = currentSelectedDay;
            }
            else
            {
                cbDay.SelectedIndex = 0;
            }
        }


        public class UserUnfo
        {
            public string Id { get; set; }
            public string PassWord { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Birth { get; set; }
            public string Phone { get; set; }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            //1.텍스트 박스 입력 확인
            if (string.IsNullOrEmpty(txtId.Text) ||
                string.IsNullOrEmpty(txtPassWord.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text))

            {
                MessageBox.Show("모든 정보를 입력해주세요.");
                return;
            }

            //2. 비밀번호 일치 여부 확인
            if (txtPassWord.Text != txtPwCheck.Text)
            {
                MessageBox.Show("비밀번호와 비밀번호 확인이 일치하지 않습니다.");
                return;
            }

            //3. 생년월일 확인
            if (cbYear.SelectedItem == null || cbMonth.SelectedItem == null || cbDay.SelectedItem == null)
            {
                MessageBox.Show("생년월일을 모두 선택해주세요");
                return;
            }

            //4.약관 동의 확인
            if (!chkInfo.Checked)
            {
                MessageBox.Show("이용약관 및 개인정보 수집에 동의해야 가입이 가능합니다.");
                return;
            }

            //모든 검증이 완료되면
            // 여기서 부터는 입력한 모든 정보를 다음 폼으로 전달하는 코드다. 

            //  5. 다음 폼으로 이동 (가상의 ResultForm이라고 가정)

            string birth = $"{cbYear.SelectedItem}-{cbMonth.SelectedItem}-{cbDay.SelectedItem}";

            // JoinMember 로직 클래스 호출

            bool result = JoinMember.InsertUser( // DBtest를 project_Maver로 바꿔야 한다. 
                txtId.Text,
                txtPassWord.Text,
                txtName.Text,
                txtEmail.Text,
                birth,
                txtPhone.Text);

            if (result)
            {
                MessageBox.Show("회원가입 완료");
                this.Close();
            }
            else
            {
                MessageBox.Show("회원가입 실패");
            }

        }

        // 연도를 바꿀 때마다 실행됨
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays(); // 연도가 바뀌면 (윤년일 수 있으니) 일수를 다시 계산
        }

        // 월을 바꿀 때마다 실행됨
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays(); // 월이 바뀌면 (28, 30, 31일 중 하나로) 일수를 다시 계산
        }

       
    }
}
