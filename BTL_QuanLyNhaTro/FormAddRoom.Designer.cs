namespace BTL_QuanLyNhaTro
{
    partial class FormAddRoom
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelRoomCode = new System.Windows.Forms.Label();
            this.textBoxRoomCode = new System.Windows.Forms.TextBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.labelOwnerCode = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxAreaPrice = new System.Windows.Forms.TextBox();
            this.labelFloor = new System.Windows.Forms.Label();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.labelRentPrice = new System.Windows.Forms.Label();
            this.textBoxRentPrice = new System.Windows.Forms.TextBox();
            this.labelStatusCode = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(325, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(162, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thêm Phòng";
            // 
            // labelRoomCode
            // 
            this.labelRoomCode.AutoSize = true;
            this.labelRoomCode.Location = new System.Drawing.Point(60, 81);
            this.labelRoomCode.Name = "labelRoomCode";
            this.labelRoomCode.Size = new System.Drawing.Size(68, 16);
            this.labelRoomCode.TabIndex = 1;
            this.labelRoomCode.Text = "Mã Phòng";
            // 
            // textBoxRoomCode
            // 
            this.textBoxRoomCode.Location = new System.Drawing.Point(150, 78);
            this.textBoxRoomCode.Name = "textBoxRoomCode";
            this.textBoxRoomCode.Size = new System.Drawing.Size(225, 22);
            this.textBoxRoomCode.TabIndex = 2;
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Location = new System.Drawing.Point(60, 128);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(73, 16);
            this.labelRoomName.TabIndex = 3;
            this.labelRoomName.Text = "Tên Phòng";
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Location = new System.Drawing.Point(150, 125);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(225, 22);
            this.textBoxRoomName.TabIndex = 4;
            // 
            // labelOwnerCode
            // 
            this.labelOwnerCode.AutoSize = true;
            this.labelOwnerCode.Location = new System.Drawing.Point(60, 175);
            this.labelOwnerCode.Name = "labelOwnerCode";
            this.labelOwnerCode.Size = new System.Drawing.Size(76, 16);
            this.labelOwnerCode.TabIndex = 5;
            this.labelOwnerCode.Text = "Mã Chủ Trọ";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(60, 222);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(66, 16);
            this.labelRoomNumber.TabIndex = 7;
            this.labelRoomNumber.Text = "Số Phòng";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(150, 219);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(225, 22);
            this.textBoxRoomNumber.TabIndex = 8;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(433, 225);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(64, 16);
            this.labelArea.TabIndex = 9;
            this.labelArea.Text = "Diện Tích";
            // 
            // textBoxAreaPrice
            // 
            this.textBoxAreaPrice.Location = new System.Drawing.Point(551, 222);
            this.textBoxAreaPrice.Name = "textBoxAreaPrice";
            this.textBoxAreaPrice.Size = new System.Drawing.Size(225, 22);
            this.textBoxAreaPrice.TabIndex = 10;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(433, 81);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(39, 16);
            this.labelFloor.TabIndex = 11;
            this.labelFloor.Text = "Tầng";
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(551, 78);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(225, 22);
            this.textBoxFloor.TabIndex = 12;
            this.textBoxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFloor_KeyPress);
            // 
            // labelRentPrice
            // 
            this.labelRentPrice.AutoSize = true;
            this.labelRentPrice.Location = new System.Drawing.Point(433, 128);
            this.labelRentPrice.Name = "labelRentPrice";
            this.labelRentPrice.Size = new System.Drawing.Size(62, 16);
            this.labelRentPrice.TabIndex = 13;
            this.labelRentPrice.Text = "Giá Thuê";
            // 
            // textBoxRentPrice
            // 
            this.textBoxRentPrice.Location = new System.Drawing.Point(551, 125);
            this.textBoxRentPrice.Name = "textBoxRentPrice";
            this.textBoxRentPrice.Size = new System.Drawing.Size(225, 22);
            this.textBoxRentPrice.TabIndex = 14;
            this.textBoxRentPrice.TextChanged += new System.EventHandler(this.textBoxRentPrice_TextChanged);
            // 
            // labelStatusCode
            // 
            this.labelStatusCode.AutoSize = true;
            this.labelStatusCode.Location = new System.Drawing.Point(433, 175);
            this.labelStatusCode.Name = "labelStatusCode";
            this.labelStatusCode.Size = new System.Drawing.Size(95, 16);
            this.labelStatusCode.TabIndex = 15;
            this.labelStatusCode.Text = "Mã Trạng Thái";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(60, 264);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(49, 16);
            this.labelAddress.TabIndex = 17;
            this.labelAddress.Text = "Địa Chỉ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(63, 397);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(164, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(63, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(713, 96);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(551, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 24);
            this.comboBox2.TabIndex = 23;
            // 
            // FormAddRoom
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelRoomCode);
            this.Controls.Add(this.textBoxRoomCode);
            this.Controls.Add(this.labelRoomName);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.labelOwnerCode);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textBoxAreaPrice);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.labelRentPrice);
            this.Controls.Add(this.textBoxRentPrice);
            this.Controls.Add(this.labelStatusCode);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormAddRoom";
            this.Text = "Thêm Phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelRoomCode;
        private System.Windows.Forms.TextBox textBoxRoomCode;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label labelOwnerCode;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxAreaPrice;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.Label labelRentPrice;
        private System.Windows.Forms.TextBox textBoxRentPrice;
        private System.Windows.Forms.Label labelStatusCode;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
