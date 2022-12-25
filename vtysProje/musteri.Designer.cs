
namespace vtysProje
{
    partial class musteri
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
            this.btn_otelform = new System.Windows.Forms.Button();
            this.btn_aracform = new System.Windows.Forms.Button();
            this.btn_daireform = new System.Windows.Forms.Button();
            this.lbl_soru = new System.Windows.Forms.Label();
            this.btn_anasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_otelform
            // 
            this.btn_otelform.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_otelform.Location = new System.Drawing.Point(207, 236);
            this.btn_otelform.Name = "btn_otelform";
            this.btn_otelform.Size = new System.Drawing.Size(75, 62);
            this.btn_otelform.TabIndex = 0;
            this.btn_otelform.Text = "Otel";
            this.btn_otelform.UseVisualStyleBackColor = true;
            this.btn_otelform.Click += new System.EventHandler(this.btn_otelform_Click);
            // 
            // btn_aracform
            // 
            this.btn_aracform.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_aracform.Location = new System.Drawing.Point(338, 236);
            this.btn_aracform.Name = "btn_aracform";
            this.btn_aracform.Size = new System.Drawing.Size(75, 62);
            this.btn_aracform.TabIndex = 1;
            this.btn_aracform.Text = "Araç";
            this.btn_aracform.UseVisualStyleBackColor = true;
            this.btn_aracform.Click += new System.EventHandler(this.btn_aracform_Click);
            // 
            // btn_daireform
            // 
            this.btn_daireform.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_daireform.Location = new System.Drawing.Point(470, 236);
            this.btn_daireform.Name = "btn_daireform";
            this.btn_daireform.Size = new System.Drawing.Size(75, 62);
            this.btn_daireform.TabIndex = 2;
            this.btn_daireform.Text = "Daire";
            this.btn_daireform.UseVisualStyleBackColor = true;
            this.btn_daireform.Click += new System.EventHandler(this.btn_daireform_Click);
            // 
            // lbl_soru
            // 
            this.lbl_soru.AutoSize = true;
            this.lbl_soru.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soru.Location = new System.Drawing.Point(207, 142);
            this.lbl_soru.Name = "lbl_soru";
            this.lbl_soru.Size = new System.Drawing.Size(338, 25);
            this.lbl_soru.TabIndex = 3;
            this.lbl_soru.Text = "Ne rezervasyonu yapmak istiyorsunuz?";
            // 
            // btn_anasayfa
            // 
            this.btn_anasayfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_anasayfa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_anasayfa.Location = new System.Drawing.Point(681, 405);
            this.btn_anasayfa.Name = "btn_anasayfa";
            this.btn_anasayfa.Size = new System.Drawing.Size(107, 33);
            this.btn_anasayfa.TabIndex = 4;
            this.btn_anasayfa.Text = "Anasayfa";
            this.btn_anasayfa.UseVisualStyleBackColor = false;
            this.btn_anasayfa.Click += new System.EventHandler(this.btn_anasayfa_Click);
            // 
            // musteriform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_anasayfa);
            this.Controls.Add(this.lbl_soru);
            this.Controls.Add(this.btn_daireform);
            this.Controls.Add(this.btn_aracform);
            this.Controls.Add(this.btn_otelform);
            this.Name = "musteriform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_otelform;
        private System.Windows.Forms.Button btn_aracform;
        private System.Windows.Forms.Button btn_daireform;
        private System.Windows.Forms.Label lbl_soru;
        private System.Windows.Forms.Button btn_anasayfa;
    }
}