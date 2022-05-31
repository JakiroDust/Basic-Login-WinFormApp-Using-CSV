using WinFormsApp3.DAO;
namespace WinFormsApp3
{
    public partial class frmLogin : Form
    {
        #region method
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool CheckError()
        {
            string temp = "";
            if (tbUserName.Text == "")
                temp += "Tên người dùng đang trống\n";
            if (tbPassWord.Text == "")
                temp += "Password không được trống";
            if (temp == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(temp);
                return false;
            }
        }
        ~frmLogin()
        {
            UserDAO.Instance.loadBack();
        }
        #endregion
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckError())
            {
                UserDAO.Instance.logIn(tbUserName.Text, tbPassWord.Text);
            }    
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmDangKi();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new frmQuenMatKhaucs();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}