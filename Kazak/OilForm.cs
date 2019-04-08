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
    public partial class OilForm : Form
    {
        public OilForm()
        {
            InitializeComponent();
        }

        private void OilForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.oil". При необходимости она может быть перемещена или удалена.
            this.oilTableAdapter.Fill(this.mainDataSet.oil);

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            MainDB main = new MainDB();
            main.AddOil(textBox1.Text);
            this.oilTableAdapter.Fill(this.mainDataSet.oil);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length>0)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;

        }

        private void OilForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Owner = null;
        }
    }
}
