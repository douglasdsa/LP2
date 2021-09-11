using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Fechar a aplicação
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validação (se o texto do txtAltura e txtPeso podem ser valores numéricos)
            if (double.TryParse(txtAltura.Text, out double num1))
            {
                if (double.TryParse(txtPeso.Text, out double num2))
                {
                    //Validação (se o texto do txtAltura é diferente de zero)
                    if (txtAltura.Text != "0")
                    {
                        //Cálculo do IMC
                        double IMC;
                        IMC = Convert.ToDouble(txtPeso.Text) / (Convert.ToDouble(txtAltura.Text) * Convert.ToDouble(txtAltura.Text));
                        
                        if (IMC < 18.5)
                        {
                            MessageBox.Show("MAGREZA");
                        }
                        else 
                        {
                            if (IMC < 24.9)
                            {
                                MessageBox.Show("NORMAL");
                            }
                            else
                            {
                                if (IMC < 29.9)
                                {
                                    MessageBox.Show("SOBREPESO");
                                }
                                else
                                {
                                    if (IMC < 39.9)
                                    {
                                        MessageBox.Show("SOBREPESO");
                                    }
                                    else
                                    {
                                        MessageBox.Show("OBESIDADE GRAVE");
                                    }
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("O campo ALTURA não pode ser zero!");
                    }
                }
                else
                {
                    MessageBox.Show("O campo PESO não é numérico!");
                }
            }
            else
            {
                MessageBox.Show("O campo ALTURA não é numérico!");
            }
        }
    }
}
