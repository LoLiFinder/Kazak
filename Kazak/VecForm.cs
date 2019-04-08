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
    public partial class VecForm : Form
    {
        public VecForm()
        {
            InitializeComponent();
        }

        private void VecForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.oil". При необходимости она может быть перемещена или удалена.
            this.oilTableAdapter.Fill(this.mainDataSet.oil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.voditel". При необходимости она может быть перемещена или удалена.
            this.voditelTableAdapter.Fill(this.mainDataSet.voditel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet.vecAll". При необходимости она может быть перемещена или удалена.
            this.vecAllTableAdapter.Fill(this.mainDataSet.vecAll);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainDB main = new MainDB();
            main.AddVenicle(textBox1.Text,(int) comboBox1.SelectedValue,(int) comboBox2.SelectedValue,textBox2.Text);
            this.vecAllTableAdapter.Fill(this.mainDataSet.vecAll);
        }
    }
}
