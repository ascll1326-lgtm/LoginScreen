namespace LoginScreen
{
    partial class MyLoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMessage = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAppName.Font = new Font("맑은 고딕", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(195, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(269, 116);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Cursor = Cursors.IBeam;
            txtID.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(107, 170);
            txtID.Name = "txtID";
            txtID.Size = new Size(414, 71);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Cursor = Cursors.IBeam;
            txtPW.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(107, 276);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(414, 71);
            txtPW.TabIndex = 3;
            txtPW.Text = "비밀번호";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 192);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("맑은 고딕", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(180, 416);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(257, 100);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("맑은 고딕", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(107, 350);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(367, 25);
            lblErrorMessage.TabIndex = 4;
            lblErrorMessage.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMessage.Visible = false;
            // 
            // MyLoginScreen
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 632);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "MyLoginScreen";
            Text = "로그인";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMessage;
    }
}
