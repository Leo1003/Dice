using System;
using System.Windows.Forms;

namespace Dice
{
    public partial class FormMain : Form
    {
        Random r;
        public FormMain()
        {
            InitializeComponent();
            r = new Random((int)DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = r.Next(1, 7).ToString();
        }
    }
}
