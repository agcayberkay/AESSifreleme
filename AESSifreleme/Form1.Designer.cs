
namespace AESSifreleme
{
    partial class Form1
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
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.txtSifrele = new DevExpress.XtraEditors.TextEdit();
            this.btnCoz = new DevExpress.XtraEditors.SimpleButton();
            this.btnSifrele = new DevExpress.XtraEditors.SimpleButton();
            this.txtCoz = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifrele.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoz.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifrele
            // 
            this.txtSifrele.Location = new System.Drawing.Point(12, 12);
            this.txtSifrele.Name = "txtSifrele";
            this.txtSifrele.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifrele.Properties.Appearance.Options.UseFont = true;
            this.txtSifrele.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSifrele.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtSifrele.Properties.AutoHeight = false;
            this.txtSifrele.Size = new System.Drawing.Size(313, 244);
            this.txtSifrele.TabIndex = 0;
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(498, 262);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(75, 23);
            this.btnCoz.TabIndex = 1;
            this.btnCoz.Text = "Çöz";
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(116, 262);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(75, 23);
            this.btnSifrele.TabIndex = 1;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // txtCoz
            // 
            this.txtCoz.Location = new System.Drawing.Point(386, 12);
            this.txtCoz.Name = "txtCoz";
            this.txtCoz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCoz.Properties.Appearance.Options.UseFont = true;
            this.txtCoz.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCoz.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCoz.Properties.AutoHeight = false;
            this.txtCoz.Size = new System.Drawing.Size(313, 244);
            this.txtCoz.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 296);
            this.Controls.Add(this.txtCoz);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.btnCoz);
            this.Controls.Add(this.txtSifrele);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES Şifreleme";
            ((System.ComponentModel.ISupportInitialize)(this.txtSifrele.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoz.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.TextEdit txtSifrele;
        private DevExpress.XtraEditors.SimpleButton btnCoz;
        private DevExpress.XtraEditors.SimpleButton btnSifrele;
        private DevExpress.XtraEditors.TextEdit txtCoz;
    }
}

