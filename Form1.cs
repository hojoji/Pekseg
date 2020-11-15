using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pekseg
{
    public partial class Form1 : Form
    {

           public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void PeksegName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Felveszbtn_Click(object sender, EventArgs e)
        {
            if (input_nev.Text != "" && Convert.ToInt32(input_ar.Text) != 0)
            {
                Pekaru suti = new Pekaru(input_nev.Text, Convert.ToInt32(input_ar.Value), (mentes.Checked) ? true : false);
                lbPekaru.Items.Add(suti);
            }
        }

        private void PeksegFelvesz_Click(object sender, EventArgs e)
        {

            if (input_nev.Text != "")
            {
                Pekseg bolt = new Pekseg(peksegName.Text);
                lbPekseg.Items.Add(bolt);
                peksegek.Items.Add(bolt);
            }

        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            if (lbPekseg.SelectedItem != null && lbPekaru.SelectedItem != null)
            {

                peksegArui.Items.Add(lbPekaru.SelectedItem);
                Pekseg bolt = new Pekseg(Convert.ToString(lbPekseg.SelectedItem));
            //   Pekaru suti = new Pekaru();
             //  bolt.Termekek.Add(suti);
            }

        }

        private void Torol_Click(object sender, EventArgs e)
        {
            lbPekaru.Items.Remove(lbPekaru.SelectedItems);
        }


    }
}
