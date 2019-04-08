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
    public partial class VodForm : Form
    {
        public VodForm()
        {
            InitializeComponent();
        }

        private void VodForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.voditel". При необходимости она может быть перемещена или удалена.
            this.voditelTableAdapter.Fill(this.mainDataSet.voditel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(String.Format("Добавить водителя\nИмя {0}\nФамилия {1}\nДень рождения {2}\nНомер паспорта {3}",textBox1.Text,textBox2.Text,dateTimePicker1.Value.Date,textBox4.Text),"",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MainDB db = new MainDB();
                db.AddVod(textBox1.Text,textBox2.Text,dateTimePicker1.Value.Date,textBox4.Text);
                this.voditelTableAdapter.Fill(this.mainDataSet.voditel);
            }
        }

        private void VodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Owner = null;
        }
    }
}
