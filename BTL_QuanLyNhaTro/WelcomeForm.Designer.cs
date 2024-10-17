
namespace BTL_QuanLyNhaTro
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_show = new System.Windows.Forms.CheckBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_phanquyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_show_re = new System.Windows.Forms.CheckBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tb_confirm_pass = new System.Windows.Forms.TextBox();
            this.tb_pass_register = new System.Windows.Forms.TextBox();
            this.tb_name_register = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 302);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_show);
            this.tabPage1.Controls.Add(this.bt_login);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.tb_pass);
            this.tabPage1.Controls.Add(this.tb_name);
            this.tabPage1.Controls.Add(this.Label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đăng Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_show
            // 
            this.cb_show.AutoSize = true;
            this.cb_show.Location = new System.Drawing.Point(193, 155);
            this.cb_show.Name = "cb_show";
            this.cb_show.Size = new System.Drawing.Size(95, 17);
            this.cb_show.TabIndex = 3;
            this.cb_show.Text = "Hiện mật khẩu";
            this.cb_show.UseVisualStyleBackColor = true;
            this.cb_show.CheckedChanged += new System.EventHandler(this.cb_show_CheckedChanged);
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(193, 189);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(203, 34);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(108, 129);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 20);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Mật khẩu:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(78, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 20);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Tên tài khoản:";
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(193, 123);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(203, 26);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(193, 81);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(203, 26);
            this.tb_name.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(88, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(409, 25);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Chào mừng đến ứng dụng quản lý nhà trọ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_phanquyen);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cb_show_re);
            this.tabPage2.Controls.Add(this.btn_register);
            this.tabPage2.Controls.Add(this.Label8);
            this.tabPage2.Controls.Add(this.Label4);
            this.tabPage2.Controls.Add(this.Label6);
            this.tabPage2.Controls.Add(this.tb_confirm_pass);
            this.tabPage2.Controls.Add(this.tb_pass_register);
            this.tabPage2.Controls.Add(this.tb_name_register);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng ký";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_phanquyen
            // 
            this.cb_phanquyen.FormattingEnabled = true;
            this.cb_phanquyen.Items.AddRange(new object[] {
            "Chủ trọ",
            "Người thuê"});
            this.cb_phanquyen.Location = new System.Drawing.Point(198, 179);
            this.cb_phanquyen.Name = "cb_phanquyen";
            this.cb_phanquyen.Size = new System.Drawing.Size(121, 21);
            this.cb_phanquyen.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(134, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bạn là:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Đăng ký tài khoản";
            // 
            // cb_show_re
            // 
            this.cb_show_re.AutoSize = true;
            this.cb_show_re.Location = new System.Drawing.Point(198, 155);
            this.cb_show_re.Name = "cb_show_re";
            this.cb_show_re.Size = new System.Drawing.Size(95, 17);
            this.cb_show_re.TabIndex = 8;
            this.cb_show_re.Text = "Hiện mật khẩu";
            this.cb_show_re.UseVisualStyleBackColor = true;
            this.cb_show_re.CheckedChanged += new System.EventHandler(this.cb_show_CheckedChanged);
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(198, 216);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(203, 34);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "Đăng ký";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.bt_re_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(52, 126);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(140, 20);
            this.Label8.TabIndex = 13;
            this.Label8.Text = "Nhập lại mật khẩu:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(113, 90);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 20);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Mật khẩu:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(83, 58);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(109, 20);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "Tên tài khoản:";
            // 
            // tb_confirm_pass
            // 
            this.tb_confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirm_pass.Location = new System.Drawing.Point(198, 123);
            this.tb_confirm_pass.Name = "tb_confirm_pass";
            this.tb_confirm_pass.Size = new System.Drawing.Size(203, 26);
            this.tb_confirm_pass.TabIndex = 7;
            this.tb_confirm_pass.UseSystemPasswordChar = true;
            // 
            // tb_pass_register
            // 
            this.tb_pass_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass_register.Location = new System.Drawing.Point(198, 87);
            this.tb_pass_register.Name = "tb_pass_register";
            this.tb_pass_register.Size = new System.Drawing.Size(203, 26);
            this.tb_pass_register.TabIndex = 6;
            this.tb_pass_register.UseSystemPasswordChar = true;
            // 
            // tb_name_register
            // 
            this.tb_name_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name_register.Location = new System.Drawing.Point(198, 55);
            this.tb_name_register.Name = "tb_name_register";
            this.tb_name_register.Size = new System.Drawing.Size(203, 26);
            this.tb_name_register.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(602, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thông tin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 321);
            this.Controls.Add(this.tabControl1);
            this.Name = "WelcomeForm";
            this.Text = "Quản lý nhà chọ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox cb_show;
        internal System.Windows.Forms.Button bt_login;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tb_pass;
        internal System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.CheckBox cb_show_re;
        internal System.Windows.Forms.Button btn_register;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tb_confirm_pass;
        internal System.Windows.Forms.TextBox tb_pass_register;
        internal System.Windows.Forms.TextBox tb_name_register;
        private System.Windows.Forms.ComboBox cb_phanquyen;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label5;
    }
}

