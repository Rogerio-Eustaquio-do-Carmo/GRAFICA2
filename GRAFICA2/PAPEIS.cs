using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRAFICA2
{
    public partial class PAPEIS : Form
    {
        public PAPEIS()
        {
            InitializeComponent();
        }

        private void SAIR1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA SAIR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }

    }
}
