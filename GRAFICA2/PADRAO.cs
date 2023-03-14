using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            label63.Visible = false;
            label64.Visible = false;
            label65.Visible = false;
            label66.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label69.Visible = false;

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

            button1.Visible = false;
            button1.Enabled = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;

            CBBTIPO1.Items.Add("CEL");
            CBBTIPO1.Items.Add("COM");
            CBBTIPO1.Items.Add("RES");

            CBBSEXO1.Items.Add("F");
            CBBSEXO1.Items.Add("M");

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
            label63.Visible = true;
            label64.Visible = true;
            label65.Visible = true;
            label66.Visible = true;
            label67.Visible = true;
            label68.Visible = true;
            label69.Visible = true;

            TXBCEP.Visible = true;
            TXBCEP.Enabled = true;

            TXBNOME.Visible = true;
            TXBNOME.Enabled = true;

            TXBRAZAOSOCIAL.Visible = true;
            TXBRAZAOSOCIAL.Enabled = true;

            TXBRUA.Visible = true;
            TXBRUA.Enabled = false;

            TXBNUMERO.Visible = true;
            TXBNUMERO.Enabled = true;

            TXBCOMPLEMENTO.Visible = true;
            TXBCOMPLEMENTO.Enabled = true;

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
            BTNCANCELA.Location = new Point(1066, 544);

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
            if (label2.Text == "CADASTRAR CLIENTE")
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
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                if (TXBCONTATO1.Text != "")
                {
                    BTNINSERIR.Visible = true;
                    BTNINSERIR.Location = new Point(411, 544);

                    BTNCADAUTEXC.Visible = true;
                    BTNCADAUTEXC.Text = "ATUALIZAR";
                    BTNCADAUTEXC.ForeColor = Color.Green;
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
                    BTNCADAUTEXC.Text = "ATUALIZAR";
                    BTNCADAUTEXC.ForeColor = Color.Green;
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
                    BTNCADAUTEXC.Text = "ATUALIZAR";
                    BTNCADAUTEXC.ForeColor = Color.Green;
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
                    BTNCADAUTEXC.Text = "ATUALIZAR";
                    BTNCADAUTEXC.ForeColor = Color.Green;
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
                    BTNCADAUTEXC.Text = "ATUALIZAR";
                    BTNCADAUTEXC.ForeColor = Color.Green;
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
                    BTNCADAUTEXC.Text = "ATUALIZAR";
                    BTNCADAUTEXC.ForeColor = Color.Green;
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
                    BTNCADAUTEXC.Text = "ATUALIZAR";
                    BTNCADAUTEXC.ForeColor = Color.Green;
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
        }
        private void BTNCANCELA_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
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
                TXBDDD2.Visible = false;
                TXBDDD3.Clear();
                TXBDDD3.Visible = false;
                TXBDDD4.Clear();
                TXBDDD4.Visible = false;
                TXBDDD5.Clear();
                TXBDDD5.Visible = false;
                TXBDDD6.Clear();
                TXBDDD6.Visible = false;
                TXBDDD7.Clear();
                TXBDDD7.Visible = false;
                TXBDDD8.Clear();
                TXBDDD8.Visible = false;
                TXBTELEFONE1.Clear();
                TXBTELEFONE2.Clear();
                TXBTELEFONE2.Visible = false;
                TXBTELEFONE3.Clear();
                TXBTELEFONE3.Visible = false;
                TXBTELEFONE4.Clear();
                TXBTELEFONE4.Visible = false;
                TXBTELEFONE5.Clear();
                TXBTELEFONE5.Visible = false;
                TXBTELEFONE6.Clear();
                TXBTELEFONE6.Visible = false;
                TXBTELEFONE7.Clear();
                TXBTELEFONE7.Visible = false;
                TXBTELEFONE8.Clear();
                TXBTELEFONE8.Visible = false;
                TXBCONTATO1.Clear();
                TXBCONTATO2.Clear();
                TXBCONTATO2.Visible = false;
                TXBCONTATO3.Clear();
                TXBCONTATO3.Visible = false;
                TXBCONTATO4.Clear();
                TXBCONTATO4.Visible = false;
                TXBCONTATO5.Clear();
                TXBCONTATO5.Visible = false;
                TXBCONTATO6.Clear();
                TXBCONTATO6.Visible = false;
                TXBCONTATO7.Clear();
                TXBCONTATO7.Visible = false;
                TXBCONTATO8.Clear();
                TXBCONTATO8.Visible = false;
                TXBEMAIL1.Clear();
                TXBEMAIL2.Clear();
                TXBEMAIL2.Visible = false;
                TXBEMAIL3.Clear();
                TXBEMAIL3.Visible = false;
                TXBEMAIL4.Clear();
                TXBEMAIL4.Visible = false;
                TXBEMAIL5.Clear();
                TXBEMAIL5.Visible = false;
                TXBEMAIL6.Clear();
                TXBEMAIL6.Visible = false;
                TXBEMAIL7.Clear();
                TXBEMAIL7.Visible = false;
                TXBEMAIL8.Clear();
                TXBEMAIL8.Visible = false;

                CBBTIPO1.Text = "";
                CBBTIPO2.Text = "";
                CBBTIPO2.Visible = false;
                CBBTIPO3.Text = "";
                CBBTIPO3.Visible = false;
                CBBTIPO4.Text = "";
                CBBTIPO4.Visible = false;
                CBBTIPO5.Text = "";
                CBBTIPO5.Visible = false;
                CBBTIPO6.Text = "";
                CBBTIPO6.Visible = false;
                CBBTIPO7.Text = "";
                CBBTIPO7.Visible = false;
                CBBTIPO8.Text = "";
                CBBTIPO8.Visible = false;
                CBBSEXO1.Text = "";
                CBBSEXO2.Text = "";
                CBBSEXO2.Visible = false;
                CBBSEXO3.Text = "";
                CBBSEXO3.Visible = false;
                CBBSEXO4.Text = "";
                CBBSEXO4.Visible = false;
                CBBSEXO5.Text = "";
                CBBSEXO5.Visible = false;
                CBBSEXO6.Text = "";
                CBBSEXO6.Visible = false;
                CBBSEXO7.Text = "";
                CBBSEXO7.Visible = false;
                CBBSEXO8.Text = "";
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
                BTNCANCELA.Location = new Point(1066, 544);

                TXBCEP.Focus();
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
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
                TXBDDD2.Visible = false;
                TXBDDD3.Clear();
                TXBDDD3.Visible = false;
                TXBDDD4.Clear();
                TXBDDD4.Visible = false;
                TXBDDD5.Clear();
                TXBDDD5.Visible = false;
                TXBDDD6.Clear();
                TXBDDD6.Visible = false;
                TXBDDD7.Clear();
                TXBDDD7.Visible = false;
                TXBDDD8.Clear();
                TXBDDD8.Visible = false;
                TXBTELEFONE1.Clear();
                TXBTELEFONE2.Clear();
                TXBTELEFONE2.Visible = false;
                TXBTELEFONE3.Clear();
                TXBTELEFONE3.Visible = false;
                TXBTELEFONE4.Clear();
                TXBTELEFONE4.Visible = false;
                TXBTELEFONE5.Clear();
                TXBTELEFONE5.Visible = false;
                TXBTELEFONE6.Clear();
                TXBTELEFONE6.Visible = false;
                TXBTELEFONE7.Clear();
                TXBTELEFONE7.Visible = false;
                TXBTELEFONE8.Clear();
                TXBTELEFONE8.Visible = false;
                TXBCONTATO1.Clear();
                TXBCONTATO2.Clear();
                TXBCONTATO2.Visible = false;
                TXBCONTATO3.Clear();
                TXBCONTATO3.Visible = false;
                TXBCONTATO4.Clear();
                TXBCONTATO4.Visible = false;
                TXBCONTATO5.Clear();
                TXBCONTATO5.Visible = false;
                TXBCONTATO6.Clear();
                TXBCONTATO6.Visible = false;
                TXBCONTATO7.Clear();
                TXBCONTATO7.Visible = false;
                TXBCONTATO8.Clear();
                TXBCONTATO8.Visible = false;
                TXBEMAIL1.Clear();
                TXBEMAIL2.Clear();
                TXBEMAIL2.Visible = false;
                TXBEMAIL3.Clear();
                TXBEMAIL3.Visible = false;
                TXBEMAIL4.Clear();
                TXBEMAIL4.Visible = false;
                TXBEMAIL5.Clear();
                TXBEMAIL5.Visible = false;
                TXBEMAIL6.Clear();
                TXBEMAIL6.Visible = false;
                TXBEMAIL7.Clear();
                TXBEMAIL7.Visible = false;
                TXBEMAIL8.Clear();
                TXBEMAIL8.Visible = false;

                CBBTIPO1.Text = "";
                CBBTIPO2.Text = "";
                CBBTIPO2.Visible = false;
                CBBTIPO3.Text = "";
                CBBTIPO3.Visible = false;
                CBBTIPO4.Text = "";
                CBBTIPO4.Visible = false;
                CBBTIPO5.Text = "";
                CBBTIPO5.Visible = false;
                CBBTIPO6.Text = "";
                CBBTIPO6.Visible = false;
                CBBTIPO7.Text = "";
                CBBTIPO7.Visible = false;
                CBBTIPO8.Text = "";
                CBBTIPO8.Visible = false;
                CBBSEXO1.Text = "";
                CBBSEXO2.Text = "";
                CBBSEXO2.Visible = false;
                CBBSEXO3.Text = "";
                CBBSEXO3.Visible = false;
                CBBSEXO4.Text = "";
                CBBSEXO4.Visible = false;
                CBBSEXO5.Text = "";
                CBBSEXO5.Visible = false;
                CBBSEXO6.Text = "";
                CBBSEXO6.Visible = false;
                CBBSEXO7.Text = "";
                CBBSEXO7.Visible = false;
                CBBSEXO8.Text = "";
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
            label63.Visible = false;
            label64.Visible = false;
            label65.Visible = false;
            label66.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label69.Visible = false;

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
            label63.Visible = false;
            label64.Visible = false;
            label65.Visible = false;
            label66.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label69.Visible = false;

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
                MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

                CONEXAO.Open();

                MySqlCommand COMANDO1 = new MySqlCommand("insert into cliente(IDCLIENTE,NOME,RAZAOSOCIAL) values(null,?,?)", CONEXAO);
                COMANDO1.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = TXBNOME.Text;
                COMANDO1.Parameters.Add("@RAZAOSOCIAL", MySqlDbType.VarChar, 100).Value = TXBRAZAOSOCIAL.Text;

                COMANDO1.ExecuteNonQuery();

                MySqlCommand COMANDO2 = new MySqlCommand("insert into endereco(IDENDERECO, RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP) values(null,?,?,?,?,?,?,?)", CONEXAO);
                COMANDO2.Parameters.Add("@RUA", MySqlDbType.VarChar, 150).Value = TXBRUA.Text;
                COMANDO2.Parameters.Add("@NUMERO", MySqlDbType.VarChar, 10).Value = TXBNUMERO.Text;
                COMANDO2.Parameters.Add("@COMPLEMENTO", MySqlDbType.VarChar, 50).Value = TXBCOMPLEMENTO.Text;
                COMANDO2.Parameters.Add("@BAIRRO", MySqlDbType.VarChar, 50).Value = TXBBAIRRO.Text;
                COMANDO2.Parameters.Add("@CIDADE", MySqlDbType.VarChar, 50).Value = TXBCIDADE.Text;
                COMANDO2.Parameters.Add("@ESTADO", MySqlDbType.VarChar, 2).Value = TXBESTADO.Text;
                COMANDO2.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = TXBCEP.Text;

                COMANDO2.ExecuteNonQuery();

                MySqlCommand COMANDO3 = new MySqlCommand("insert into FISCAIS(IDFISCAIS, CNPJ, INSCEST, INSCMUN) values(null,?,?,?)", CONEXAO);
                COMANDO3.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 18).Value = TXBCNPJ.Text;
                COMANDO3.Parameters.Add("@INSCEST", MySqlDbType.VarChar, 30).Value = TXBINSCEST.Text;
                COMANDO3.Parameters.Add("@INSCMUN", MySqlDbType.VarChar, 30).Value = TXBINSCMUN.Text;

                COMANDO3.ExecuteNonQuery();

                MySqlCommand COMANDO4 = new MySqlCommand("insert into contato(IDCONTATO, CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3, CONTATO4, SEXO4, EMAIL4, CONTATO5, SEXO5, EMAIL5, CONTATO6, SEXO6, EMAIL6, CONTATO7, SEXO7, EMAIL7, CONTATO8, SEXO8, EMAIL8) values(null,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", CONEXAO);
                COMANDO4.Parameters.Add("@CONTATO1", MySqlDbType.VarChar, 100).Value = TXBCONTATO1.Text;
                COMANDO4.Parameters.Add("@SEXO1", MySqlDbType.VarChar, 1).Value = CBBSEXO1.Text;
                COMANDO4.Parameters.Add("@EMAIL1", MySqlDbType.VarChar, 100).Value = TXBEMAIL1.Text;
                COMANDO4.Parameters.Add("@CONTATO2", MySqlDbType.VarChar, 100).Value = TXBCONTATO2.Text;
                COMANDO4.Parameters.Add("@SEXO2", MySqlDbType.VarChar, 1).Value = CBBSEXO2.Text;
                COMANDO4.Parameters.Add("@EMAIL2", MySqlDbType.VarChar, 100).Value = TXBEMAIL2.Text;
                COMANDO4.Parameters.Add("@CONTATO3", MySqlDbType.VarChar, 100).Value = TXBCONTATO3.Text;
                COMANDO4.Parameters.Add("@SEXO3", MySqlDbType.VarChar, 1).Value = CBBSEXO3.Text;
                COMANDO4.Parameters.Add("@EMAIL3", MySqlDbType.VarChar, 100).Value = TXBEMAIL3.Text;
                COMANDO4.Parameters.Add("@CONTATO4", MySqlDbType.VarChar, 100).Value = TXBCONTATO4.Text;
                COMANDO4.Parameters.Add("@SEXO4", MySqlDbType.VarChar, 1).Value = CBBSEXO4.Text;
                COMANDO4.Parameters.Add("@EMAIL4", MySqlDbType.VarChar, 100).Value = TXBEMAIL4.Text;
                COMANDO4.Parameters.Add("@CONTATO5", MySqlDbType.VarChar, 100).Value = TXBCONTATO5.Text;
                COMANDO4.Parameters.Add("@SEXO5", MySqlDbType.VarChar, 1).Value = CBBSEXO5.Text;
                COMANDO4.Parameters.Add("@EMAIL5", MySqlDbType.VarChar, 100).Value = TXBEMAIL5.Text;
                COMANDO4.Parameters.Add("@CONTATO6", MySqlDbType.VarChar, 100).Value = TXBCONTATO6.Text;
                COMANDO4.Parameters.Add("@SEXO6", MySqlDbType.VarChar, 1).Value = CBBSEXO6.Text;
                COMANDO4.Parameters.Add("@EMAIL6", MySqlDbType.VarChar, 100).Value = TXBEMAIL6.Text;
                COMANDO4.Parameters.Add("@CONTATO7", MySqlDbType.VarChar, 100).Value = TXBCONTATO7.Text;
                COMANDO4.Parameters.Add("@SEXO7", MySqlDbType.VarChar, 1).Value = CBBSEXO7.Text;
                COMANDO4.Parameters.Add("@EMAIL7", MySqlDbType.VarChar, 100).Value = TXBEMAIL7.Text;
                COMANDO4.Parameters.Add("@CONTATO8", MySqlDbType.VarChar, 100).Value = TXBCONTATO8.Text;
                COMANDO4.Parameters.Add("@SEXO8", MySqlDbType.VarChar, 1).Value = CBBSEXO8.Text;
                COMANDO4.Parameters.Add("@EMAIL8", MySqlDbType.VarChar, 100).Value = TXBEMAIL8.Text;

                COMANDO4.ExecuteNonQuery();

                MySqlCommand COMANDO5 = new MySqlCommand("insert into TELEFONE(IDTELEFONE, TIPO1, DDD1, TELEFONE1, TIPO2, DDD2, TELEFONE2, TIPO3, DDD3, TELEFONE3, TIPO4, DDD4, TELEFONE4, TIPO5, DDD5, TELEFONE5, TIPO6, DDD6, TELEFONE6, TIPO7, DDD7, TELEFONE7, TIPO8, DDD8, TELEFONE8) values(null,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", CONEXAO);
                COMANDO5.Parameters.Add("@TIPO1", MySqlDbType.VarChar, 6).Value = CBBTIPO1.Text;
                COMANDO5.Parameters.Add("@DDD1", MySqlDbType.VarChar, 4).Value = TXBDDD1.Text;
                COMANDO5.Parameters.Add("@TELEFONE1", MySqlDbType.VarChar, 10).Value = TXBTELEFONE1.Text;
                COMANDO5.Parameters.Add("@TIPO2", MySqlDbType.VarChar, 6).Value = CBBTIPO2.Text;
                COMANDO5.Parameters.Add("@DDD2", MySqlDbType.VarChar, 4).Value = TXBDDD2.Text;
                COMANDO5.Parameters.Add("@TELEFONE2", MySqlDbType.VarChar, 10).Value = TXBTELEFONE2.Text;
                COMANDO5.Parameters.Add("@TIPO3", MySqlDbType.VarChar, 6).Value = CBBTIPO3.Text;
                COMANDO5.Parameters.Add("@DDD3", MySqlDbType.VarChar, 4).Value = TXBDDD3.Text;
                COMANDO5.Parameters.Add("@TELEFONE3", MySqlDbType.VarChar, 10).Value = TXBTELEFONE3.Text;
                COMANDO5.Parameters.Add("@TIPO4", MySqlDbType.VarChar, 6).Value = CBBTIPO4.Text;
                COMANDO5.Parameters.Add("@DDD4", MySqlDbType.VarChar, 4).Value = TXBDDD4.Text;
                COMANDO5.Parameters.Add("@TELEFONE4", MySqlDbType.VarChar, 10).Value = TXBTELEFONE4.Text;
                COMANDO5.Parameters.Add("@TIPO5", MySqlDbType.VarChar, 6).Value = CBBTIPO5.Text;
                COMANDO5.Parameters.Add("@DDD5", MySqlDbType.VarChar, 4).Value = TXBDDD5.Text;
                COMANDO5.Parameters.Add("@TELEFONE5", MySqlDbType.VarChar, 10).Value = TXBTELEFONE5.Text;
                COMANDO5.Parameters.Add("@TIPO6", MySqlDbType.VarChar, 6).Value = CBBTIPO6.Text;
                COMANDO5.Parameters.Add("@DDD6", MySqlDbType.VarChar, 4).Value = TXBDDD6.Text;
                COMANDO5.Parameters.Add("@TELEFONE6", MySqlDbType.VarChar, 10).Value = TXBTELEFONE6.Text;
                COMANDO5.Parameters.Add("@TIPO7", MySqlDbType.VarChar, 6).Value = CBBTIPO7.Text;
                COMANDO5.Parameters.Add("@DDD7", MySqlDbType.VarChar, 4).Value = TXBDDD7.Text;
                COMANDO5.Parameters.Add("@TELEFONE7", MySqlDbType.VarChar, 10).Value = TXBTELEFONE7.Text;
                COMANDO5.Parameters.Add("@TIPO8", MySqlDbType.VarChar, 6).Value = CBBTIPO8.Text;
                COMANDO5.Parameters.Add("@DDD8", MySqlDbType.VarChar, 4).Value = TXBDDD8.Text;
                COMANDO5.Parameters.Add("@TELEFONE8", MySqlDbType.VarChar, 10).Value = TXBTELEFONE8.Text;

                COMANDO5.ExecuteNonQuery();

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

                TXBCEP.Focus();

                CONEXAO.Close();







            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {

            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TXBCEP.Text == "")
            {
                MessageBox.Show("CEP EM BRANCO");

                TXBCEP.Focus();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (TXBNOME.Text == "")
            {
                MessageBox.Show("NOME EM BRANCO");

                TXBNOME.Focus();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (TXBRAZAOSOCIAL.Text == "")
            {
                MessageBox.Show("RAZÃO SOCIAL EM BRANCO");

                TXBRAZAOSOCIAL.Focus();
            }
            try
            {
                MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");

                CONEXAO.Open();

                MySqlCommand COMANDO1 = new MySqlCommand("insert into cliente(RAZAOSOCIAL) values(?)", CONEXAO);
                COMANDO1.Parameters.Add("@RAZAOSOCIAL", MySqlDbType.VarChar, 100).Value = TXBRAZAOSOCIAL.Text;

                COMANDO1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("RAZÃO SOCIAL EXISTENTE");

                TXBRAZAOSOCIAL.Focus();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (TXBNUMERO.Text == "")
            {
                MessageBox.Show("NÚMERO EM BRANCO");

                TXBNUMERO.Focus();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (TXBCNPJ.Text == "")
            {
                MessageBox.Show("CNPJ EM BRANCO");

                TXBCNPJ.Focus();
            }
            try
            {

                MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");

                CONEXAO.Open();

                MySqlCommand COMANDO3 = new MySqlCommand("insert into FISCAIS(CNPJ) values(?)", CONEXAO);
                COMANDO3.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 18).Value = TXBCNPJ.Text;


                COMANDO3.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("CNPJ EXISTENTE");

                TXBCNPJ.Focus();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}

