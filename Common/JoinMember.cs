using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Maver.Common
{
    internal class JoinMember
    {
        //회원가입 폼
            public static bool InsertUser(string id, string pw, string name, string email, string birth, string phone)
            {


          
                string sql = @"INSERT INTO maverdb.user 
                              (id, name, email, pw, birth, phone)
                              VALUES
                              (@id, @name, @email, @pw, @birth, @phone)";

                Dictionary<string, object> param = new Dictionary<string,object>()
                {
                    {"id", id},
                    {"pw", pw},
                    {"name", name},
                    {"email", email},
                    {"birth", birth},
                    {"phone", phone}
                };

                int result = DbManager.void_query(sql, param);

                return result > 0;

            }

        //로그인 로직
        public static bool LoginCheck(string id, string pw)
        {
            // DB에서 해당 아이디와 비밀번호가 일치하는 행이 있는지 개수를 셉니다.
            string sql = "SELECT COUNT(*) FROM user WHERE id = @id AND pw = @pw";

            Dictionary<string, object> param = new Dictionary<string, object>()
    {
        {"@id", id},
        {"@pw", pw}
    };

            // select_Query를 사용하여 결과를 가져옵니다.
            DataTable dt = DbManager.select_Query(sql, param);

            if (dt != null && dt.Rows.Count > 0)
            {
                // COUNT(*) 결과값이 0보다 크면 일치하는 회원이 있는 것임
                return Convert.ToInt32(dt.Rows[0][0]) > 0;
            }

            return false;
        }

    }
}
