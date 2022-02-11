using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ovn4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnÖppnaFil_Click_Click(object sender, EventArgs e)
        {
            DialogResult resultat = dlgÖppnaFil.ShowDialog();
            if ( resultat == DialogResult.OK)
            {
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                StreamReader läsare = new StreamReader(inStröm);

                tbxFörnamn.Text = läsare.ReadLine();
                tbxEfternamn.Text = läsare.ReadLine();
                tbxepost.Text = läsare.ReadLine();
                tbxTelefonnummer.Text = läsare.ReadLine();

                läsare.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSparaFil_Click(object sender, EventArgs e)

        {
            DialogResult resultat = dlgSparaFil.ShowDialog();
            if(resultat == DialogResult.OK) 
            {
                FileStream inStröm = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter skrivare = new StreamWriter(inStröm);
                skrivare.WriteLine(tbxFörnamn.Text);
                skrivare.WriteLine(tbxEfternamn.Text);
                skrivare.WriteLine(tbxepost.Text);
                skrivare.WriteLine(tbxTelefonnummer.Text);

                skrivare.Dispose();
            }
        }
    }
}
