using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.DAO;
namespace WinFormsApp3
{
    public partial class frmDangKi : Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }
        bool CheckError()
        {
            if(tbUserName.Text==""||tbPassWord.Text==""||tbRePassWord.Text=="")
            {
                MessageBox.Show("Đang có ô trống");
                return false;

            }
            if(tbPassWord.Text!=tbRePassWord.Text)
            {
                MessageBox.Show("mục 'RePassWord' không giống với 'PassWord'");
                return false;
            }
            return true;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                UserDAO.Instance.signUp(tbUserName.Text, tbPassWord.Text);
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
