using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESSifreleme
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const string AES_IV = @"!&+QWSDF!123126+";
        public string AES_KEY = @"QQsaw!257()%%ert";

        AesCryptoServiceProvider AESProvider = new AesCryptoServiceProvider();

        public string AESEncrypting (string EncryptingText)
        {
            AESProvider.BlockSize = 128;
            AESProvider.KeySize=128;

            AESProvider.IV =Encoding.UTF8.GetBytes(AES_IV);
            AESProvider.Key = Encoding.UTF8.GetBytes(AES_KEY);
            AESProvider.Mode = CipherMode.CBC;
            AESProvider.Padding = PaddingMode.PKCS7;

            byte[] source = Encoding.Unicode.GetBytes(EncryptingText);

            using (ICryptoTransform Encrypting = AESProvider.CreateEncryptor())
            {
                byte[] target = Encrypting.TransformFinalBlock(source, 0, source.Length);
                return Convert.ToBase64String(target);
            }

        }


        public string AESDencrypting(string DecryptingText)
        {
            AESProvider.BlockSize = 128;
            AESProvider.KeySize = 128;

            AESProvider.IV = Encoding.UTF8.GetBytes(AES_IV);
            AESProvider.Key = Encoding.UTF8.GetBytes(AES_KEY);
            AESProvider.Mode = CipherMode.CBC;
            AESProvider.Padding = PaddingMode.PKCS7;

            byte[] source = System.Convert.FromBase64String(DecryptingText);

            using (ICryptoTransform Decrypting = AESProvider.CreateDecryptor())
            {
                byte[] target = Decrypting.TransformFinalBlock(source, 0, source.Length);
                return Encoding.Unicode.GetString(target);
            }

        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            txtCoz.Text = AESEncrypting(txtSifrele.Text);
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            txtSifrele.Text = AESDencrypting(txtCoz.Text);
        }
    }
}
