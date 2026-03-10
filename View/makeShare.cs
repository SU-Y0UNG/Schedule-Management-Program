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
            string calName = txtCalName.Text;
            string color = "#" + rbColor.BackColor.Name;
            string currentUserId = UserSession.UserId;

            string groupSql = "INSERT INTO  share_group(share_name, color) VALUES (@name, @color);" +
                "SELECT LAST_INSERT_ID();";
            var groupParam = new Dictionary<string, object> { { "@name", calName }, { "@color", color } };

            DataTable dt = DbManager.select_Query(groupSql, groupParam);
            if (dt == null || dt.Rows.Count == 0) return;

            int newShareId = Convert.ToInt32(dt.Rows[0][0]);

            string memberSql = "INSERT INTO  share_member(share_id, user_id, role) VALUES (@sid, @id, @role)";

            List<string> targets = new List<string> { currentUserId };
            if (_mode == "공용")
            {
                foreach (ListViewItem item in lvShareUser.Items)
                {
                    targets.Add(item.Text);
                }
            }

            foreach (string id in targets.Distinct())
            {
                var mParam = new Dictionary<string, object>
                {
                    { "@sid", newShareId },
                    { "@id", id },
                    { "@role", currentUserId }
                };
                DbManager.void_query(memberSql, mParam);
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
            if(_mode == "개인")
            {
                lbShareUser.Visible = false;
                txtShareUser.Visible=false;
                btnUserPlus.Visible=false;
                lvShareUser.Visible=false;
            }
            else
            {
                lbShareUser.Visible = true;
                txtShareUser.Visible = true;
                btnUserPlus.Visible = true;
                lvShareUser.Visible = true;
            }
        }
    }
}
