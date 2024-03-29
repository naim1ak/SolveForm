using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolveForm
{
    public partial class SolvePassForm : Form
    {
        public SolvePassForm()
        {
            this.MaximizeBox = false;
            
            
            InitializeComponent();
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() != "") {


                var pass = SifreyiCozAES(txtPass.Text);
                result.Text = pass;
            }

        }

        private static byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");
        private static string sharedSecret = "8F0930A7-ADEF-41CD-B311-572F72E02A49";
        public static string SifreyiCozAES(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");


            RijndaelManaged aesAlg = null;


            string plaintext = null;

            try
            {

                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);


                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {

                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    aesAlg.IV = ReadByteArray(msDecrypt);

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            //uzmanim.net
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {

                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            result.Text = "";
        }
    }
}
