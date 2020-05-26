        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        public string cyphertext;
        private void btnET_Click(object sender, EventArgs e)
        {

            UnicodeEncoding encoding = new UnicodeEncoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            byte[] plaintext;
            byte[] cyphertext;
            var Etext = text1.Text;
            if (!string.IsNullOrEmpty(Etext))
            {
                plaintext = encoding.GetBytes(Etext);
                var rsaparam = rsa.ExportParameters(false);
                cyphertext = RsaEnc.Encrypt(plaintext, rsa.ExportParameters(false), false);
                var encryptedtext = encoding.GetString(cyphertext);
                txtbET.Text = encryptedtext;

            }
            else
            {
                MessageBox.Show("!!!!  FILL THE REQUIRED FIELD  !!!!");

            }
        }
