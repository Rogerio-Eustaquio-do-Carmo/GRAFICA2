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
    public partial class PADRAO : Form
    {
        public PADRAO()
        {
            InitializeComponent();
        }

        private void PADRAO_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
            label50.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            label62.Visible = false;

            TXBCEP.Visible = false;
            TXBNOME.Visible = false;
            TXBRAZAOSOCIAL.Visible = false;
            TXBRUA.Visible = false;
            TXBNUMERO.Visible = false;
            TXBCOMPLEMENTO.Visible = false;
            TXBBAIRRO.Visible = false;
            TXBCIDADE.Visible = false;
            TXBESTADO.Visible = false;
            TXBCNPJ.Visible = false;
            TXBINSCEST.Visible = false;
            TXBINSCMUN.Visible = false;
            TXBDDD1.Visible = false;
            TXBDDD2.Visible = false;
            TXBDDD3.Visible = false;
            TXBDDD4.Visible = false;
            TXBDDD5.Visible = false;
            TXBDDD6.Visible = false;
            TXBDDD7.Visible = false;
            TXBDDD8.Visible = false;
            TXBTELEFONE1.Visible = false;
            TXBTELEFONE2.Visible = false;
            TXBTELEFONE3.Visible = false;
            TXBTELEFONE4.Visible = false;
            TXBTELEFONE5.Visible = false;
            TXBTELEFONE6.Visible = false;
            TXBTELEFONE7.Visible = false;
            TXBTELEFONE8.Visible = false;
            TXBCONTATO1.Visible = false;
            TXBCONTATO2.Visible = false;
            TXBCONTATO3.Visible = false;
            TXBCONTATO4.Visible = false;
            TXBCONTATO5.Visible = false;
            TXBCONTATO6.Visible = false;
            TXBCONTATO7.Visible = false;
            TXBCONTATO8.Visible = false;
            TXBEMAIL1.Visible = false;
            TXBEMAIL2.Visible = false;
            TXBEMAIL3.Visible = false;
            TXBEMAIL4.Visible = false;
            TXBEMAIL5.Visible = false;
            TXBEMAIL6.Visible = false;
            TXBEMAIL7.Visible = false;
            TXBEMAIL8.Visible = false;

            CBBNOME.Visible = false;
            CBBTIPO1.Visible = false;
            CBBTIPO2.Visible = false;
            CBBTIPO3.Visible = false;
            CBBTIPO4.Visible = false;
            CBBTIPO5.Visible = false;
            CBBTIPO6.Visible = false;
            CBBTIPO7.Visible = false;
            CBBTIPO8.Visible = false;
            CBBSEXO1.Visible = false;
            CBBSEXO2.Visible = false;
            CBBSEXO3.Visible = false;
            CBBSEXO4.Visible = false;
            CBBSEXO5.Visible = false;
            CBBSEXO6.Visible = false;
            CBBSEXO7.Visible = false;
            CBBSEXO8.Visible = false;

            BTNINSERIR.Visible = false;
            BTNCADAUTEXC.Visible = false;
            BTNCANCELA.Visible = false;

            menuStrip1.Visible = true;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;

            label1.Location = new Point(660, 450);

        }

        private void SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CADCLIENTE_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

            label2.Visible = true;
            label2.Text = "CADASTRAR CLIENTE";
            label2.ForeColor = Color.Blue;

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
            label50.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            label62.Visible = false;

            TXBCEP.Visible = true;
            TXBCEP.Enabled = true;

            TXBNOME.Visible = true;
            TXBNOME.Enabled = true;

            TXBRAZAOSOCIAL.Visible = true;
            TXBRAZAOSOCIAL.Enabled = true;

            TXBRUA.Visible = true;
            TXBRUA.Enabled = false;

            TXBNUMERO.Visible = true;
            TXBNUMERO.Enabled = false;

            TXBCOMPLEMENTO.Visible = true;
            TXBCOMPLEMENTO.Enabled = false;

            TXBBAIRRO.Visible = true;
           TXBBAIRRO.Enabled = false;

            TXBCIDADE.Visible = true;
            TXBCIDADE.Enabled = false;

            TXBESTADO.Visible = true;
            TXBESTADO.Enabled = false;

            TXBCNPJ.Visible = true;
            TXBCNPJ.Enabled = true;

            TXBINSCEST.Visible = true;
            TXBINSCEST.Enabled = true;

            TXBINSCMUN.Visible = true;
            TXBINSCMUN.Enabled = true;

            TXBDDD1.Visible = true;
            TXBDDD1.Enabled = true;

            TXBDDD2.Visible = false;
            TXBDDD3.Visible = false;
            TXBDDD4.Visible = false;
            TXBDDD5.Visible = false;
            TXBDDD6.Visible = false;
            TXBDDD7.Visible = false;
            TXBDDD8.Visible = false;

            TXBTELEFONE1.Visible = true;
            TXBTELEFONE1.Enabled = true;

            TXBTELEFONE2.Visible = false;
            TXBTELEFONE3.Visible = false;
            TXBTELEFONE4.Visible = false;
            TXBTELEFONE5.Visible = false;
            TXBTELEFONE6.Visible = false;
            TXBTELEFONE7.Visible = false;
            TXBTELEFONE8.Visible = false;

            TXBCONTATO1.Visible = true;
            TXBCONTATO1.Enabled = true;

            TXBCONTATO2.Visible = false;
            TXBCONTATO3.Visible = false;
            TXBCONTATO4.Visible = false;
            TXBCONTATO5.Visible = false;
            TXBCONTATO6.Visible = false;
            TXBCONTATO7.Visible = false;
            TXBCONTATO8.Visible = false;

            TXBEMAIL1.Visible = true;
            TXBEMAIL1.Enabled = true;

            TXBEMAIL2.Visible = false;
            TXBEMAIL3.Visible = false;
            TXBEMAIL4.Visible = false;
            TXBEMAIL5.Visible = false;
            TXBEMAIL6.Visible = false;
            TXBEMAIL7.Visible = false;
            TXBEMAIL8.Visible = false;

            CBBNOME.Visible = false;

            CBBTIPO1.Visible = true;
            CBBTIPO1.Enabled = true;

            CBBTIPO2.Visible = false;
            CBBTIPO3.Visible = false;
            CBBTIPO4.Visible = false;
            CBBTIPO5.Visible = false;
            CBBTIPO6.Visible = false;
            CBBTIPO7.Visible = false;
            CBBTIPO8.Visible = false;

            CBBSEXO1.Visible = true;
            CBBSEXO1.Enabled = true;

            CBBSEXO2.Visible = false;
            CBBSEXO3.Visible = false;
            CBBSEXO4.Visible = false;
            CBBSEXO5.Visible = false;
            CBBSEXO6.Visible = false;
            CBBSEXO7.Visible = false;
            CBBSEXO8.Visible = false;

            BTNINSERIR.Visible = true;
            BTNINSERIR.Location = new Point(411, 504);

            BTNCADAUTEXC.Visible = true;
            BTNCADAUTEXC.Text = "CADASTRAR";
            BTNCADAUTEXC.ForeColor = Color.Blue;
            BTNCADAUTEXC.Location = new Point(411, 544);

            BTNCANCELA.Visible = true;
            BTNCANCELA.Text = "CANCELAR";
            BTNCANCELA.ForeColor = Color.Black;
            BTNCANCELA.Location = new Point(1066,544);

            menuStrip1.Visible = false;
            menuStrip2.Visible = true;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;

            TXBCEP.Focus();
        }

        private void BTNINSERIR_Click(object sender, EventArgs e)
        {
            if (TXBCONTATO1.Text != "")
            {
                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 544);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 584);

                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 584);

                TXBDDD2.Visible = true;
                TXBTELEFONE2.Visible = true;
                TXBCONTATO2.Visible = true;
                TXBEMAIL2.Visible = true;
                CBBTIPO2.Visible = true;
                CBBSEXO2.Visible = true;

                CBBTIPO2.Focus();
            }
            if (TXBCONTATO2.Text != "")
            {
                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 584);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 624);

                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 624);

                TXBDDD3.Visible = true;
                TXBTELEFONE3.Visible = true;
                TXBCONTATO3.Visible = true;
                TXBEMAIL3.Visible = true;
                CBBTIPO3.Visible = true;
                CBBSEXO3.Visible = true;

                CBBTIPO3.Focus();
            }
            if (TXBCONTATO3.Text != "")
            {
                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 624);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 664);

                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 664);

                TXBDDD4.Visible = true;
                TXBTELEFONE4.Visible = true;
                TXBCONTATO4.Visible = true;
                TXBEMAIL4.Visible = true;
                CBBTIPO4.Visible = true;
                CBBSEXO4.Visible = true;

                CBBTIPO4.Focus();
            }
            if (TXBCONTATO4.Text != "")
            {
                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 664);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 704);

                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 704);

                TXBDDD5.Visible = true;
                TXBTELEFONE5.Visible = true;
                TXBCONTATO5.Visible = true;
                TXBEMAIL5.Visible = true;
                CBBTIPO5.Visible = true;
                CBBSEXO5.Visible = true;

                CBBTIPO5.Focus();
            }
            if (TXBCONTATO5.Text != "")
            {
                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 704);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 744);

                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 744);

                TXBDDD6.Visible = true;
                TXBTELEFONE6.Visible = true;
                TXBCONTATO6.Visible = true;
                TXBEMAIL6.Visible = true;
                CBBTIPO6.Visible = true;
                CBBSEXO6.Visible = true;

                CBBTIPO6.Focus();
            }
            if (TXBCONTATO6.Text != "")
            {
                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 744);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 784);

                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 784);

                TXBDDD7.Visible = true;
                TXBTELEFONE7.Visible = true;
                TXBCONTATO7.Visible = true;
                TXBEMAIL7.Visible = true;
                CBBTIPO7.Visible = true;
                CBBSEXO7.Visible = true;

                CBBTIPO7.Focus();
            }
            if (TXBCONTATO7.Text != "")
            {
                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 784);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 824);

                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 824);

                TXBDDD8.Visible = true;
                TXBTELEFONE8.Visible = true;
                TXBCONTATO8.Visible = true;
                TXBEMAIL8.Visible = true;
                CBBTIPO8.Visible = true;
                CBBSEXO8.Visible = true;

                CBBTIPO8.Focus();
            }
        }
        private void BTNCANCELA_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE" && label2.Text == "ATUALIZAR CLIENTE")
            {
                TXBCEP.Clear();
                TXBNOME.Clear();
                TXBRAZAOSOCIAL.Clear();
                TXBRUA.Clear();
                TXBNUMERO.Clear();
                TXBCOMPLEMENTO.Clear();
                TXBBAIRRO.Clear();
                TXBCIDADE.Clear();
                TXBESTADO.Clear();
                TXBCNPJ.Clear();
                TXBINSCEST.Clear();
                TXBINSCMUN.Clear();
                TXBDDD1.Clear();
                TXBDDD2.Clear();
                TXBDDD3.Clear();
                TXBDDD4.Clear();
                TXBDDD5.Clear();
                TXBDDD6.Clear();
                TXBDDD7.Clear();
                TXBDDD8.Clear();
                TXBTELEFONE1.Clear();
                TXBTELEFONE2.Clear();
                TXBTELEFONE3.Clear();
                TXBTELEFONE4.Clear();
                TXBTELEFONE5.Clear();
                TXBTELEFONE6.Clear();
                TXBTELEFONE7.Clear();
                TXBTELEFONE8.Clear();
                TXBCONTATO1.Clear();
                TXBCONTATO2.Clear();
                TXBCONTATO3.Clear();
                TXBCONTATO4.Clear();
                TXBCONTATO5.Clear();
                TXBCONTATO6.Clear();
                TXBCONTATO7.Clear();
                TXBCONTATO8.Clear();
                TXBEMAIL1.Clear();
                TXBEMAIL2.Clear();
                TXBEMAIL3.Clear();
                TXBEMAIL4.Clear();
                TXBEMAIL5.Clear();
                TXBEMAIL6.Clear();
                TXBEMAIL7.Clear();
                TXBEMAIL8.Clear();

                CBBTIPO1.Text = "";
                CBBTIPO2.Text = "";
                CBBTIPO3.Text = "";
                CBBTIPO4.Text = "";
                CBBTIPO5.Text = "";
                CBBTIPO6.Text = "";
                CBBTIPO7.Text = "";
                CBBTIPO8.Text = "";
                CBBSEXO1.Text = "";
                CBBSEXO2.Text = "";
                CBBSEXO3.Text = "";
                CBBSEXO4.Text = "";
                CBBSEXO5.Text = "";
                CBBSEXO6.Text = "";
                CBBSEXO7.Text = "";
                CBBSEXO8.Text = "";

                TXBCEP.Focus();
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                TXBCEP.Clear();
                TXBNOME.Clear();
                TXBRAZAOSOCIAL.Clear();
                TXBRUA.Clear();
                TXBNUMERO.Clear();
                TXBCOMPLEMENTO.Clear();
                TXBBAIRRO.Clear();
                TXBCIDADE.Clear();
                TXBESTADO.Clear();
                TXBCNPJ.Clear();
                TXBINSCEST.Clear();
                TXBINSCMUN.Clear();
                TXBDDD1.Clear();
                TXBDDD2.Clear();
                TXBDDD3.Clear();
                TXBDDD4.Clear();
                TXBDDD5.Clear();
                TXBDDD6.Clear();
                TXBDDD7.Clear();
                TXBDDD8.Clear();
                TXBTELEFONE1.Clear();
                TXBTELEFONE2.Clear();
                TXBTELEFONE3.Clear();
                TXBTELEFONE4.Clear();
                TXBTELEFONE5.Clear();
                TXBTELEFONE6.Clear();
                TXBTELEFONE7.Clear();
                TXBTELEFONE8.Clear();
                TXBCONTATO1.Clear();
                TXBCONTATO2.Clear();
                TXBCONTATO3.Clear();
                TXBCONTATO4.Clear();
                TXBCONTATO5.Clear();
                TXBCONTATO6.Clear();
                TXBCONTATO7.Clear();
                TXBCONTATO8.Clear();
                TXBEMAIL1.Clear();
                TXBEMAIL2.Clear();
                TXBEMAIL3.Clear();
                TXBEMAIL4.Clear();
                TXBEMAIL5.Clear();
                TXBEMAIL6.Clear();
                TXBEMAIL7.Clear();
                TXBEMAIL8.Clear();

                CBBNOME.Text = "";
                CBBTIPO1.Text = "";
                CBBTIPO2.Text = "";
                CBBTIPO3.Text = "";
                CBBTIPO4.Text = "";
                CBBTIPO5.Text = "";
                CBBTIPO6.Text = "";
                CBBTIPO7.Text = "";
                CBBTIPO8.Text = "";
                CBBSEXO1.Text = "";
                CBBSEXO2.Text = "";
                CBBSEXO3.Text = "";
                CBBSEXO4.Text = "";
                CBBSEXO5.Text = "";
                CBBSEXO6.Text = "";
                CBBSEXO7.Text = "";
                CBBSEXO8.Text = "";

                CBBNOME.Focus();
            }
        }
        private void ATUCLIENTE_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

            label2.Visible = true;
            label2.Text = "ATUALIZAR CLIENTE";
            label2.ForeColor = Color.Green;

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
            label50.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            label62.Visible = false;

            TXBCEP.Visible = true;
            TXBCEP.Enabled = true;

            TXBNOME.Visible = false;
            TXBNOME.Enabled = false;

            CBBNOME.Visible = true;
            CBBNOME.Enabled = true;

            TXBRAZAOSOCIAL.Visible = true;
            TXBRAZAOSOCIAL.Enabled = false;

            TXBRUA.Visible = true;
            TXBRUA.Enabled = false;

            TXBNUMERO.Visible = true;
            TXBNUMERO.Enabled = false;

            TXBCOMPLEMENTO.Visible = true;
            TXBCOMPLEMENTO.Enabled = false;

            TXBBAIRRO.Visible = true;
            TXBBAIRRO.Enabled = false;

            TXBCIDADE.Visible = true;
            TXBCIDADE.Enabled = false;

            TXBESTADO.Visible = true;
            TXBESTADO.Enabled = false;

            TXBCNPJ.Visible = true;
            TXBCNPJ.Enabled = false;

            TXBINSCEST.Visible = true;
            TXBINSCEST.Enabled = true;

            TXBINSCMUN.Visible = true;
            TXBINSCMUN.Enabled = true;

            TXBDDD1.Visible = true;
            TXBDDD1.Enabled = true;

            TXBDDD2.Visible = false;
            TXBDDD3.Visible = false;
            TXBDDD4.Visible = false;
            TXBDDD5.Visible = false;
            TXBDDD6.Visible = false;
            TXBDDD7.Visible = false;
            TXBDDD8.Visible = false;

            TXBTELEFONE1.Visible = true;
            TXBTELEFONE1.Enabled = true;

            TXBTELEFONE2.Visible = false;
            TXBTELEFONE3.Visible = false;
            TXBTELEFONE4.Visible = false;
            TXBTELEFONE5.Visible = false;
            TXBTELEFONE6.Visible = false;
            TXBTELEFONE7.Visible = false;
            TXBTELEFONE8.Visible = false;

            TXBCONTATO1.Visible = true;
            TXBCONTATO1.Enabled = true;

            TXBCONTATO2.Visible = false;
            TXBCONTATO3.Visible = false;
            TXBCONTATO4.Visible = false;
            TXBCONTATO5.Visible = false;
            TXBCONTATO6.Visible = false;
            TXBCONTATO7.Visible = false;
            TXBCONTATO8.Visible = false;

            TXBEMAIL1.Visible = true;
            TXBEMAIL1.Enabled = true;

            TXBEMAIL2.Visible = false;
            TXBEMAIL3.Visible = false;
            TXBEMAIL4.Visible = false;
            TXBEMAIL5.Visible = false;
            TXBEMAIL6.Visible = false;
            TXBEMAIL7.Visible = false;
            TXBEMAIL8.Visible = false;

            CBBTIPO1.Visible = true;
            CBBTIPO1.Enabled = true;

            CBBTIPO2.Visible = false;
            CBBTIPO3.Visible = false;
            CBBTIPO4.Visible = false;
            CBBTIPO5.Visible = false;
            CBBTIPO6.Visible = false;
            CBBTIPO7.Visible = false;
            CBBTIPO8.Visible = false;

            CBBSEXO1.Visible = true;
            CBBSEXO1.Enabled = true;

            CBBSEXO2.Visible = false;
            CBBSEXO3.Visible = false;
            CBBSEXO4.Visible = false;
            CBBSEXO5.Visible = false;
            CBBSEXO6.Visible = false;
            CBBSEXO7.Visible = false;
            CBBSEXO8.Visible = false;

            BTNINSERIR.Visible = true;
            BTNINSERIR.Location = new Point(411, 504);

            BTNCADAUTEXC.Visible = true;
            BTNCADAUTEXC.Text = "ATUALIZAR";
            BTNCADAUTEXC.ForeColor = Color.Green;
            BTNCADAUTEXC.Location = new Point(411, 544);

            BTNCANCELA.Visible = true;
            BTNCANCELA.Text = "CANCELAR";
            BTNCANCELA.ForeColor = Color.Black;
            BTNCANCELA.Location = new Point(1066, 544);

            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
            menuStrip3.Visible = true;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;

            TXBCEP.Focus();
        }

        private void EXCCLIENTE_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

            label2.Visible = true;
            label2.Text = "EXCLUIR CLIENTE";
            label2.ForeColor = Color.Red;

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            label47.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
            label50.Visible = false;
            label51.Visible = false;
            label52.Visible = false;
            label53.Visible = false;
            label54.Visible = false;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label60.Visible = false;
            label61.Visible = false;
            label62.Visible = false;

            TXBCEP.Visible = true;
            TXBCEP.Enabled = false;

            TXBNOME.Visible = false;
            TXBNOME.Enabled = false;

            CBBNOME.Visible = true;
            CBBNOME.Enabled = true;

            TXBRAZAOSOCIAL.Visible = true;
            TXBRAZAOSOCIAL.Enabled = false;

            TXBRUA.Visible = true;
            TXBRUA.Enabled = false;

            TXBNUMERO.Visible = true;
            TXBNUMERO.Enabled = false;

            TXBCOMPLEMENTO.Visible = true;
            TXBCOMPLEMENTO.Enabled = false;

            TXBBAIRRO.Visible = true;
            TXBBAIRRO.Enabled = false;

            TXBCIDADE.Visible = true;
            TXBCIDADE.Enabled = false;

            TXBESTADO.Visible = true;
            TXBESTADO.Enabled = false;

            TXBCNPJ.Visible = true;
            TXBCNPJ.Enabled = false;

            TXBINSCEST.Visible = true;
            TXBINSCEST.Enabled = false;

            TXBINSCMUN.Visible = true;
            TXBINSCMUN.Enabled = false;

            TXBDDD1.Visible = true;
            TXBDDD1.Enabled = false;

            TXBDDD2.Visible = false;
            TXBDDD3.Visible = false;
            TXBDDD4.Visible = false;
            TXBDDD5.Visible = false;
            TXBDDD6.Visible = false;
            TXBDDD7.Visible = false;
            TXBDDD8.Visible = false;

            TXBTELEFONE1.Visible = true;
            TXBTELEFONE1.Enabled = false;

            TXBTELEFONE2.Visible = false;
            TXBTELEFONE3.Visible = false;
            TXBTELEFONE4.Visible = false;
            TXBTELEFONE5.Visible = false;
            TXBTELEFONE6.Visible = false;
            TXBTELEFONE7.Visible = false;
            TXBTELEFONE8.Visible = false;

            TXBCONTATO1.Visible = true;
            TXBCONTATO1.Enabled = false;

            TXBCONTATO2.Visible = false;
            TXBCONTATO3.Visible = false;
            TXBCONTATO4.Visible = false;
            TXBCONTATO5.Visible = false;
            TXBCONTATO6.Visible = false;
            TXBCONTATO7.Visible = false;
            TXBCONTATO8.Visible = false;

            TXBEMAIL1.Visible = true;
            TXBEMAIL1.Enabled = false;

            TXBEMAIL2.Visible = false;
            TXBEMAIL3.Visible = false;
            TXBEMAIL4.Visible = false;
            TXBEMAIL5.Visible = false;
            TXBEMAIL6.Visible = false;
            TXBEMAIL7.Visible = false;
            TXBEMAIL8.Visible = false;

            CBBTIPO1.Visible = true;
            CBBTIPO1.Enabled = false;

            CBBTIPO2.Visible = false;
            CBBTIPO3.Visible = false;
            CBBTIPO4.Visible = false;
            CBBTIPO5.Visible = false;
            CBBTIPO6.Visible = false;
            CBBTIPO7.Visible = false;
            CBBTIPO8.Visible = false;

            CBBSEXO1.Visible = true;
            CBBSEXO1.Enabled = false;

            CBBSEXO2.Visible = false;
            CBBSEXO3.Visible = false;
            CBBSEXO4.Visible = false;
            CBBSEXO5.Visible = false;
            CBBSEXO6.Visible = false;
            CBBSEXO7.Visible = false;
            CBBSEXO8.Visible = false;

            BTNINSERIR.Visible = false;
            BTNINSERIR.Location = new Point(411, 504);

            BTNCADAUTEXC.Visible = true;
            BTNCADAUTEXC.Text = "EXCLUIR";
            BTNCADAUTEXC.ForeColor = Color.Red;
            BTNCADAUTEXC.Location = new Point(411, 504);

            BTNCANCELA.Visible = true;
            BTNCANCELA.Text = "CANCELAR";
            BTNCANCELA.ForeColor = Color.Black;
            BTNCANCELA.Location = new Point(1066, 504);

            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = true;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;

            CBBNOME.Focus();
        }

        private void BTNCADAUTEXC_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {

            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {

            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {

            }
        }
    }
    
}
