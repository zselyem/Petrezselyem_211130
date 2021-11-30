using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrezselyem_211130
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errormesseages = "";
            int tbAValue;
            int tbCValue;

            try
            {
                if (!int.TryParse(tbA.Text, out tbAValue) && !string.IsNullOrWhiteSpace(tbA.Text)) errormesseages += "Az \"A\" kategória értékkerete nem szám. \n";
                if (string.IsNullOrWhiteSpace(tbA.Text)) errormesseages += "Az \"A\" kategória értékkerete üresen maradt. \n";
                if (tbAValue < 0) errormesseages += "Az \"A\" kategória értékkerete nem lehet negatív! \n";

                if (!int.TryParse(tbC.Text, out tbCValue) && !string.IsNullOrWhiteSpace(tbC.Text)) errormesseages += "A \"C\" kategória értékkerete nem szám. \n";
                if (string.IsNullOrWhiteSpace(tbC.Text)) errormesseages += "A \"C\" kategória értékkerete üresen maradt. \n";
                if (tbCValue < 0) errormesseages += "A \"C\" kategória értékkerete nem lehet negatív! \n";


             
            }

            catch()
            {
                MessageBox.Show(errormesseages);
            }
            finally
            {
                // Connection.Close();
            }
        }
    }
}
