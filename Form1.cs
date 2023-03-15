﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComplejos_2023_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            float real =float.Parse( txtbRealC1.Text);
            float imaginaria = float.Parse(txtbImC1.Text);

            Complejo c1 = new Complejo(real, imaginaria);
            real = float.Parse(txtbRealC2.Text);
            imaginaria = float.Parse(txtbImC2.Text);

            Complejo c2 = new Complejo(real, imaginaria);

            Complejo c3 = c1 + c2;

            lbResultado.Text = c3.ToString();


        }
    }
}
