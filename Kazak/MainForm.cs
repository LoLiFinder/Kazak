using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kazak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OilForm oilForm = new OilForm();
            oilForm.Owner = this;
            oilForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VodForm vodForm = new VodForm();
            vodForm.Owner = this;
            vodForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VecForm vecForm = new VecForm();
            vecForm.Owner = this;
            vecForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
