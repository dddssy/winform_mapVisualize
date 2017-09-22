using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mapVisualize
{
    public partial class Form1 : Form
    {
        public static double lon;
        public static double lat;

        public Form1()
        {
            InitializeComponent();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser1.Document.InvokeScript("setlocation", new object[] { sdx, sdy });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath,"map.html"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text.ToString();
            string s2 = textBox2.Text.ToString();
            object[] objarray = new object[2];
            objarray[0] = s1;
            objarray[1] = s2;
            //lon = Convert.ToDouble(textBox1.Text);
            //lat = Convert.ToDouble(textBox2.Text);

            webBrowser1.Document.InvokeScript("theLocation", objarray);
           
        }
    }
}
