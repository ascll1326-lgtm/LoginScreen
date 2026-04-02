namespace LoginScreen
{
    public partial class MyLoginScreen : Form
    {
        public MyLoginScreen()
        {
            InitializeComponent();
        }

        string MyID = "admin";
        string MyPW = "superman";

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "비밀번호")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.Text = "비밀번호";
                txtPW.ForeColor = Color.Silver;
                txtPW.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == MyID && txtPW.Text == MyPW)
            {
                MessageBox.Show("로그인 성공!", "", MessageBoxButtons.OK);
                lblErrorMessage.Visible = false;
            }
            else
            {
               // MessageBox.Show("로그인 실패~", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMessage.Visible = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true; 
                txtPW.Focus();
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                e.SuppressKeyPress = true; 
                btnLogin.PerformClick();
            }
        }
    }
}
