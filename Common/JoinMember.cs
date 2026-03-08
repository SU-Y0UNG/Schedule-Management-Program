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


        //아이디 찾기 로직
        public static string FindUserId(string name, string email, string phone)
        {
            // 입력된 id와 일치하는 행의 pw 컬럼을 조회한다.
            string sql = "SELECT id FROM maverdb.user WHERE name = @name AND email = @email AND phone = @phone";
            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@name", name},
                {"@email", email},
                {"@phone", phone}
            };

            // 조회 결과가 담긴 DataTable을 가져온다.
            DataTable dt = DbManager.select_Query(sql, param);

            // 결과가 존재하면 첫 번째 행의 pw 값을 반환한다.
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["id"].ToString();
            }

            return null; // 일치하는 아이디가 없을 경우
        }

        // 비밀번호 찾기 로직
        public static string FindUserPassword(string id)
        {
            string sql = "SELECT pw FROM maverdb.user WHERE id = @id";

            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@id",id}
            };

            DataTable dt = DbManager.select_Query(sql, param);

            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0]["pw"].ToString();
            }

            return null;
        }

        // 비밀번호 수정 로직
        public static bool UpdatePassword(string id, string newPw)
        {
            // 특정 아이의 비밀번호를 새로운 값으로 변경하는 쿼리
            string sql = "UPDATE maverdb.user SET pw = @pw WHERE id = @id";

            Dictionary<string, object> param = new Dictionary<string, object>()
            {
                {"@pw", newPw},
                {"@id",id}
            };

            // DBManager의 void_query를 사용하여 실행 결과가 1이상(성공)인지 확인
            int result = DbManager.void_query(sql, param);
            return result > 0;
        }
    }
}
