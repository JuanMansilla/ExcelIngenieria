﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CapaNegocio;

namespace Prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = NDispUtil.FechIniFIn(Convert.ToDateTime(this.dateTimePicker1.Text), Convert.ToDateTime( this.dateTimePicker2.Text));
        }
    }
}
