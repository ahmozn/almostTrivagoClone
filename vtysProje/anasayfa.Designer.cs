
namespace vtysProje
{
    partial class anasayfa
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
            this.lbl_girisTur = new System.Windows.Forms.Label();
            this.btn_musteriyim = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_girisTur
            // 
            this.lbl_girisTur.AutoSize = true;
            this.lbl_girisTur.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_girisTur.Location = new System.Drawing.Point(344, 136);
            this.lbl_girisTur.Name = "lbl_girisTur";
            this.lbl_girisTur.Size = new System.Drawing.Size(93, 28);
            this.lbl_girisTur.TabIndex = 0;
            this.lbl_girisTur.Text = "Kimsiniz?";
            // 
            // btn_musteriyim
            // 
            this.btn_musteriyim.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_musteriyim.Location = new System.Drawing.Point(246, 213);
            this.btn_musteriyim.Name = "btn_musteriyim";
            this.btn_musteriyim.Size = new System.Drawing.Size(104, 79);
            this.btn_musteriyim.TabIndex = 1;
            this.btn_musteriyim.Text = "Müşteri";
            this.btn_musteriyim.UseVisualStyleBackColor = true;
            this.btn_musteriyim.Click += new System.EventHandler(this.btn_musteriyim_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_admin.Location = new System.Drawing.Point(413, 213);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(104, 79);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_malSahibi_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_musteriyim);
            this.Controls.Add(this.lbl_girisTur);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_girisTur;
        private System.Windows.Forms.Button btn_musteriyim;
        private System.Windows.Forms.Button btn_admin;
    }
}