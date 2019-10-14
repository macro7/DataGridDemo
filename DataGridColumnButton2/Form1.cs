using DevExpress.XtraBars.Alerter;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string xmlData = "<?xml version=\"1.0\"  encoding=\"utf-8\"?> <XMLDATA> <HEAD> <IP>192.168.0.1</IP> <MAC>53223B4A72</MAC> <BZXX/> </HEAD> <MAIN> <YQBM></YQBM> <PSMXBH></PSMXBH> </MAIN> </XMLDATA>";
            string sSign = SHA1(xmlData, Encoding.UTF8);
            //String result = stub.sendRecv("QXZZ42503212000", "mcipltvvxr", "42503212000", "1.0.0.0", "YY003", shaStr, str)
            ServiceReference1.YsxtMainServiceClient client = new ServiceReference1.YsxtMainServiceClient();
            var result = client.sendRecv(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text, "1.0.0.0", "YY003", sSign, xmlData);
            MessageBox.Show(result);
        }
        /// <summary>  
        /// SHA1 加密，返回大写字符串  
        /// </summary>  
        /// <param name="content">需要加密字符串</param>  
        /// <param name="encode">指定加密编码</param>  
        /// <returns>返回40位大写字符串</returns>  
        public string SHA1(string content, Encoding encode)
        {
            try
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                byte[] bytes_in = encode.GetBytes(content);
                byte[] bytes_out = sha1.ComputeHash(bytes_in);
                sha1.Dispose();
                string result = BitConverter.ToString(bytes_out);
                result = result.Replace("-", "");
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("SHA1加密出错：" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlertControl alertControl = new AlertControl();
        }
    }
}
