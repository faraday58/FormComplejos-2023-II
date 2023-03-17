using System;
using System.CodeDom;
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
        private float real;
        private float imaginaria;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if( txtbRealC1.Text==""   )
                {
                    string error = "Este campo debe ser llenado";
                    errorProvider1.SetError(txtbRealC1, error);
                    throw new ApplicationException(error);
                }
                real = float.Parse(txtbRealC1.Text);

                imaginaria = float.Parse(txtbImC1.Text);
                Complejo c1 = new Complejo(real, imaginaria);
                real = float.Parse(txtbRealC2.Text);
                imaginaria = float.Parse(txtbImC2.Text);

                Complejo c2 = new Complejo(real, imaginaria);

                Complejo c3 = c1 + c2;

                lbResultado.Text = c3.ToString();

            }
            catch (ApplicationException error)
            {

            }
            catch (FormatException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            catch
            {
                MessageBox.Show("Hubo un error");
            }
            





        }
    }
}
