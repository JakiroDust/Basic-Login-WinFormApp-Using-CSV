using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WinFormsApp3.DAO;
namespace WinFormsApp3.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        private static string strFilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\test\userData.csv";
        private static string strFileFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Desktop\test";
        private static DataTable __user;
        public  DataTable _user
        {
            get
            {
                if (__user == null)
                {
                    if (!File.Exists(strFilePath))
                    {
                        System.IO.Directory.CreateDirectory(strFileFolderPath);
                        using (var file = File.Create(strFilePath))
                        {

                        }    ;
                    }
                        __user = DataProvider.Instance.ConvertCSVtoDataTable(strFilePath);
                    
                }
                return __user;
            }
            set => __user = value;
        }
        

        #region method

        #endregion

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }
            private set => instance = value;
        }
        public void logIn(string userName,string passWord)
        {
        for(int i=0;i<_user.Rows.Count;i++)
            {
                if (_user.Rows[i][0].ToString() == userName)
                {
                    if(_user.Rows[i][1].ToString() == passWord)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại.\n Tên tài khoản hoặc mật khẩu sai.");
                        
                    }
                    return;
                }    
            }
            MessageBox.Show("Đăng nhập thất bại.\n Tên tài khoản hoặc mật khẩu sai.");
        }
        public void signUp(string userName,string passWord)
        {
            for (int i = 0; i < _user.Rows.Count; i++)
            {
                if (_user.Rows[i][0].ToString() == userName)
                {
              
                    MessageBox.Show("Đã có tên tài khoản này.\n");
                    return;
                }
            }
            var row = _user.NewRow();
            row[0] = userName;
            row[1] = passWord;
            _user.Rows.Add(row);
            MessageBox.Show("Đăng kí thành công");
            loadBack();
 
        }
        public void loadBack()
        {
            using (var w = new StreamWriter(strFilePath))
            {
                for ( int i=0;i<_user.Rows.Count;i++)
                {
                    var first = _user.Rows[i][0].ToString();
                    var second = _user.Rows[i][1].ToString();
                    var line = string.Format("{0},{1}", first, second);
                    w.WriteLine(line);
                    w.Flush();
                }
            }
        }

    }
}
