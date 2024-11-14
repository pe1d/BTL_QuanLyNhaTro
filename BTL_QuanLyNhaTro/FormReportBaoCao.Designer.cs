
namespace BTL_QuanLyNhaTro
{
    partial class FormReportBaoCao
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
            this.cRV_baoCao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cRV_baoCao
            // 
            this.cRV_baoCao.ActiveViewIndex = -1;
            this.cRV_baoCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRV_baoCao.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRV_baoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRV_baoCao.Location = new System.Drawing.Point(0, 0);
            this.cRV_baoCao.Name = "cRV_baoCao";
            this.cRV_baoCao.Size = new System.Drawing.Size(1341, 576);
            this.cRV_baoCao.TabIndex = 0;
            // 
            // FormReportBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 576);
            this.Controls.Add(this.cRV_baoCao);
            this.Name = "FormReportBaoCao";
            this.Text = "FormReportBaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRV_baoCao;
    }
}