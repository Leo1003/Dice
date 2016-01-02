using System;
using System.Windows.Forms;

namespace Dice
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random(Convert.ToInt32(DateTime.Now.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds % int.MaxValue));
            textBox1.Text = r.Next(1, 7).ToString();
        }
    }
}
