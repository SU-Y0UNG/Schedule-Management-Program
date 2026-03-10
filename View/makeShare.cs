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
using ZstdSharp.Unsafe;

namespace Project_Maver.View
{
    public partial class makeShare : Form
    {
        public makeShare()
        {
            InitializeComponent();
        }
        private string _mode;
        public makeShare(string mode)
        {
            InitializeComponent();
            this._mode = mode; // 개인 또는 공용 선택 저장
        }
        private void btnSharePlus_Click(object sender, EventArgs e)
        {
            if (_mode == "공용" && lvShareUser.Items.Count == 0)
            {
                MessageBox.Show("공유할 유저를 최소 한 명 이상 선택해주세요");
                return;
            }

            string calName = txtCalName.Text;
            if (string.IsNullOrEmpty(calName))
            {
                MessageBox.Show("캘린더 이름을 입력해주세요");
                return;
            }
            string color = ColorTranslator.ToHtml(rbColor.BackColor);
            string currentUserId = UserSession.UserId;

            string groupSql = "INSERT INTO share_group(share_name, color) VALUES (@name, @color); SELECT LAST_INSERT_ID();";
            var groupParam = new Dictionary<string, object> {
                { "@name", calName },
                {"@color", color }
            };

            DataTable dtGroup = DbManager.select_Query(groupSql, groupParam);
            if (dtGroup == null || dtGroup.Rows.Count == 0) return;

            int newShareId = Convert.ToInt32(dtGroup.Rows[0][0]);

            string memberSql = "INSERT INTO share_member(share_id, user_id, role) VALUES (@sid, @id, @role)";

            var ownerParam = new Dictionary<string, object>
            {
                {"@sid", newShareId },
                { "@id", currentUserId },
                {"@role", 0 }
            };
            DbManager.void_query(memberSql, ownerParam);

            if(_mode == "공용")
            {
                foreach (ListViewItem item in lvShareUser.Items)
                {
                   string targetUserId = item.Tag.ToString();

                    var mParam = new Dictionary<string, object>
                {
                    { "@sid", newShareId },
                    {"@id", targetUserId },
                    {"@role", 1 }
                };
                    DbManager.void_query(memberSql, mParam);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void makeShare_Load(object sender, EventArgs e)
        {
            cbCalendarSelect.SelectedItem = _mode;
            UpdateLayoutByMode();
        }
        private void UpdateLayoutByMode()
        {
            if (_mode == "개인")
            {
                lbShareUser.Visible = false;
                txtShareUser.Visible = false;
                btnUserPlus.Visible = false;
                lvShareUser.Visible = false;
            }
            else
            {
                lbShareUser.Visible = true;
                txtShareUser.Visible = true;
                btnUserPlus.Visible = true;
                lvShareUser.Visible = true;
            }
        }

        private void btnUserPlus_Click(object sender, EventArgs e)
        {
            string targetId = txtShareUser.Text.Trim();
            if (string.IsNullOrEmpty(targetId)) return;

            if (targetId == UserSession.UserId)
            {
                MessageBox.Show("본인은 추가할 수 없습니다.");
                return;
            }

            string checkSql = "SELECT id, name FROM user WHERE id = @id";
            var param = new Dictionary<string, object> { { "@id", targetId } };
            DataTable dtCheck = DbManager.select_Query(checkSql, param); ////변수명 중복 방지

            if (dtCheck != null && dtCheck.Rows.Count > 0)
            {
                string userName = dtCheck.Rows[0]["name"].ToString();
                string userId = dtCheck.Rows[0]["id"].ToString();

                foreach (ListViewItem existingItem in lvShareUser.Items)
                {
                    if (existingItem.Tag != null && existingItem.Tag.ToString() == userId)
                    {
                        MessageBox.Show("이미 추가된 유저입니다.");
                        return;
                    }
                }

                ListViewItem item = new ListViewItem(userName);
                item.Tag = userId;

                lvShareUser.Items.Add(item);
                txtShareUser.Clear();
            }
            else
            {
                MessageBox.Show("존재하지 않는 유저입니다.");
            }

           
        }

        private void rbColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                rbColor.BackColor = cd.Color;
            }
        }


    }
}
