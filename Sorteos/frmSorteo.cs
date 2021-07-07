using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteos
{
    public partial class frmSorteo : Form
    {
        List<int> numeros = new List<int>();

        public frmSorteo()
        {
            InitializeComponent();
        }

        private void btnSorteo_Click(object sender, EventArgs e)
        {
            txtDesde.Focus();

            if (txtDesde.Text != "" && txtHasta.Text != "")
            {
                if (Convert.ToInt32(txtDesde.Text) < Convert.ToInt32(txtHasta.Text))
                {
                    bool band = true;

                    if (numeros.Count != (Convert.ToInt32(txtHasta.Text) - Convert.ToInt32(txtDesde.Text) + 1))
                    {
                        while (band)
                        {
                            int numeroAleatorio = new Random().Next(Convert.ToInt32(txtDesde.Text), Convert.ToInt32(txtHasta.Text) + 1);

                            if (numeros.Contains(numeroAleatorio))
                            {
                                band = true;
                            }
                            else
                            {
                                band = false;
                                numeros.Add(numeroAleatorio);
                                lstNumSorteados.Items.Add(numeroAleatorio);
                                lblNumGanador.Text = numeroAleatorio.ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos los números fueron sorteados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSorteo.Enabled = false;
                        lstNumSorteados.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El número 'Desde' debe ser MENOR que el número 'Hasta'", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese números en los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            btnSorteo.Enabled = true;
            lstNumSorteados.Items.Clear();
            lblNumGanador.Text = "";
            txtDesde.Text = "";
            txtHasta.Text = "";
            txtDesde.Focus();
            numeros.Clear();
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
        }

        private void SoloNumerosTxt(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
