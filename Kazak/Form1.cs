﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainDB db = new MainDB();
            switch (db.authUser(textBox1.Text,textBox2.Text))
            {
                case 0:

                    break;
                case 1:
                    MainForm main = new MainForm();
                    main.Owner = this;
                    main.Show();
                    this.Hide();
                    break;

                case -1:

                    break;
            }
        }
    }
}
