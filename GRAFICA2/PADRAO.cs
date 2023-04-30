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
            LOGOTIPO();
        }
        public void LOGOTIPO()
        {
            TXBCODIGO.Visible = false;
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

            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();

            TXBDDD1.Visible = false;
            TXBTELEFONE1.Visible = false;
            TXBCONTATO1.Visible = false;
            TXBEMAIL1.Visible = false;
            CBBNOME.Visible = false;
            CBBTIPO1.Visible = false;
            CBBSEXO1.Visible = false;

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
            label70.Visible = false;

            BTNINSERIR.Visible = false;
            BTNCADAUTEXC.Visible = false;
            BTNCANCELA.Visible = false;
            BTNPESQUISAR.Visible = false;

            menuStrip1.Visible = true;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;

            CBBTIPO1.Items.Add("CEL");
            CBBTIPO1.Items.Add("COM");
            CBBTIPO1.Items.Add("RES");

            CBBSEXO1.Items.Add("F");
            CBBSEXO1.Items.Add("M");

            label1.Location = new Point(660, 450);
        }
        private void SAIR_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA SAIR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }
        private void ATUALIZACBB()
        {
            MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAO.Open();

            string CLIENTE = "SELECT nome FROM CLIENTE ORDER BY nome";
            MySqlCommand COMANDO = new MySqlCommand(CLIENTE, CONEXAO);

            DataSet ds = new DataSet();

            MySqlDataAdapter da = new MySqlDataAdapter(COMANDO);
            da.Fill(ds);

            CBBNOME.DataSource = ds.Tables[0];
            CBBNOME.DisplayMember = "nome";
            CBBNOME.ValueMember = "";

            CONEXAO.Close();
        }
        public void LIMPARTXBCBB()
        {
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

            TXBNOME.Clear();
            TXBRAZAOSOCIAL.Clear();
            TXBCEP.Clear();
            TXBCODIGO.Clear();
        }
        private void CADCLIENTE_Click(object sender, EventArgs e)
        {
            LIMPARTXBCBB();

            label1.Visible = false;

            label2.Visible = true;
            label2.Text = "CADASTRAR CLIENTE";
            label2.ForeColor = Color.Blue;

            if (label2.Text == "CADASTRAR CLIENTE")
            {
                TXBCEP.Visible = true;
                TXBCEP.Enabled = true;
                TXBCEP.Location = new Point(411, 299);

                TXBNOME.Visible = true;
                TXBNOME.Enabled = true;
                TXBNOME.Location = new Point(542, 299);

                TXBRAZAOSOCIAL.Visible = true;
                TXBRAZAOSOCIAL.Enabled = true;
                TXBRAZAOSOCIAL.Location = new Point(833, 299);
                TXBRAZAOSOCIAL.Size = new Size(676, 676);

                TXBCODIGO.Visible = false;
                TXBCODIGO.Enabled = false;

                label3.Visible = true;
                label3.Location = new Point(411, 280);
                label4.Visible = true;
                label4.Location = new Point(545, 280);
                label5.Visible = true;
                label5.Location = new Point(834, 280);
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
                label65.Location = new Point(574, 268);
                label66.Visible = true;
                label66.Location = new Point(910, 268);
                label67.Visible = true;
                label68.Visible = true;
                label69.Visible = true;
                label69.Location = new Point(430, 268);
                label70.Visible = false;

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

                TXBTELEFONE1.Visible = true;
                TXBTELEFONE1.Enabled = true;

                TXBCONTATO1.Visible = true;
                TXBCONTATO1.Enabled = true;

                TXBEMAIL1.Visible = true;
                TXBEMAIL1.Enabled = true;

                CBBNOME.Visible = false;

                CBBTIPO1.Visible = true;
                CBBTIPO1.Enabled = true;

                CBBSEXO1.Visible = true;
                CBBSEXO1.Enabled = true;

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

                BTNPESQUISAR.Visible = false;

                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
                menuStrip3.Visible = false;
                menuStrip4.Visible = false;
                menuStrip5.Visible = false;
                menuStrip6.Visible = false;

                DDDFALSE();
                TELEFONEFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                TIPOFALSE();
                SEXOFALSE();
            }
            TXBCEP.Focus();
        }

        private void ATUCLIENTE_Click(object sender, EventArgs e)
        {
            ATUALIZACBB();

            LIMPARTXBCBB();

            label1.Visible = false;

            label2.Visible = true;
            label2.Text = "ATUALIZAR CLIENTE";
            label2.ForeColor = Color.Green;

            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                label3.Visible = true;
                label3.Location = new Point(484, 280);
                label4.Visible = true;
                label4.Location = new Point(617, 280);
                label5.Visible = true;
                label5.Location = new Point(907, 280);
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
                label65.Location = new Point(647, 268);
                label66.Visible = false;
                label66.Location = new Point(983, 268);
                label67.Visible = false;
                label68.Visible = false;
                label69.Visible = false;
                label70.Visible = true;

                TXBCEP.Visible = true;
                TXBCEP.Enabled = false;
                TXBCEP.Location = new Point(485, 299);
                TXBCEP.Clear();

                TXBNOME.Visible = false;
                TXBNOME.Enabled = false;

                TXBRAZAOSOCIAL.Enabled = false;
                TXBRAZAOSOCIAL.Visible = true;
                TXBRAZAOSOCIAL.Location = new Point(909, 299);
                TXBRAZAOSOCIAL.Size = new Size(600, 600);
                TXBRAZAOSOCIAL.Clear();

                TXBCODIGO.Enabled = false;
                TXBCODIGO.Visible = true;
                TXBCODIGO.Location = new Point(411, 299);
                TXBCODIGO.Clear();

                CBBNOME.Visible = true;
                CBBNOME.Enabled = true;
                CBBNOME.Location = new Point(617, 299);

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

                DDDFALSE();

                TXBTELEFONE1.Visible = true;
                TXBTELEFONE1.Enabled = false;

                TELEFONEFALSE();

                TXBCONTATO1.Visible = true;
                TXBCONTATO1.Enabled = false;

                CONTATOFALSE();

                TXBEMAIL1.Visible = true;
                TXBEMAIL1.Enabled = false;

                EMAILFALSE();

                CBBTIPO1.Visible = true;
                CBBTIPO1.Enabled = false;

                TIPOFALSE();

                CBBSEXO1.Visible = true;
                CBBSEXO1.Enabled = false;

                SEXOFALSE();

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

                BTNPESQUISAR.Visible = true;

                menuStrip1.Visible = false;
                menuStrip2.Visible = false;
                menuStrip3.Visible = true;
                menuStrip4.Visible = false;
                menuStrip5.Visible = false;
                menuStrip6.Visible = false;
            }
            TXBCEP.Focus();
        }
        private void EXCCLIENTE_Click(object sender, EventArgs e)
        {
            ATUALIZACBB();

            LIMPARTXBCBB();

            TXBNOME.Enabled = false;
            TXBNOME.Visible = false;
            TXBNOME.Location = new Point(617, 299);

            TXBRAZAOSOCIAL.Enabled = false;
            TXBRAZAOSOCIAL.Visible = true;
            TXBRAZAOSOCIAL.Location = new Point(909, 299);
            TXBRAZAOSOCIAL.Size = new Size(600, 600);

            TXBCODIGO.Enabled = false;
            TXBCODIGO.Visible = true;
            TXBCODIGO.Location = new Point(411, 299);

            TXBNUMERO.Enabled = false;
            TXBNUMERO.Visible = true;

            TXBCNPJ.Enabled = false;
            TXBCNPJ.Visible = true;

            label1.Visible = false;

            label2.Visible = true;
            label2.Text = "EXCLUIR CLIENTE";
            label2.ForeColor = Color.Red;

            if (label2.Text == "EXCLUIR CLIENTE")
            {
                TXBCEP.Enabled = false;
                TXBCEP.Visible = true;
                TXBCEP.Location = new Point(485, 299);

                label3.Visible = true;
                label3.Location = new Point(484, 280);
                label4.Visible = true;
                label4.Location = new Point(617, 280);
                label5.Visible = true;
                label5.Location = new Point(907, 280);
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
                label70.Visible = true;

                CBBNOME.Visible = true;
                CBBNOME.Enabled = true;

                TXBRUA.Enabled = false;
                TXBRUA.Visible = true;

                TXBCOMPLEMENTO.Enabled = false;
                TXBCOMPLEMENTO.Visible = true;

                TXBBAIRRO.Enabled = false;
                TXBBAIRRO.Visible = true;

                TXBCIDADE.Enabled = false;
                TXBCIDADE.Visible = true;

                TXBESTADO.Enabled = false;
                TXBESTADO.Visible = true;

                TXBINSCEST.Enabled = false;
                TXBINSCEST.Visible = true;

                TXBINSCMUN.Enabled = false;
                TXBINSCMUN.Visible = true;

                TXBDDD1.Enabled = false;
                TXBDDD1.Visible = true;

                DDDFALSE();

                TXBTELEFONE1.Visible = true;
                TXBTELEFONE1.Enabled = false;

                TELEFONEFALSE();

                TXBCONTATO1.Visible = true;
                TXBCONTATO1.Enabled = false;

                CONTATOFALSE();

                TXBEMAIL1.Visible = true;
                TXBEMAIL1.Enabled = false;

                EMAILFALSE();

                CBBTIPO1.Visible = true;
                CBBTIPO1.Enabled = false;

                CBBTIPO2.Visible = false;
                CBBTIPO3.Visible = false;
                CBBTIPO4.Visible = false;
                CBBTIPO5.Visible = false;
                CBBTIPO6.Visible = false;
                CBBTIPO7.Visible = false;
                CBBTIPO8.Visible = false;
                CBBTIPO8.Enabled = true;

                CBBSEXO1.Visible = true;
                CBBSEXO1.Enabled = false;

                CBBSEXO2.Visible = false;
                CBBSEXO3.Visible = false;
                CBBSEXO4.Visible = false;
                CBBSEXO5.Visible = false;
                CBBSEXO6.Visible = false;
                CBBSEXO7.Visible = false;
                CBBSEXO8.Visible = false;
                CBBSEXO8.Enabled = true;

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

                BTNPESQUISAR.Visible = true;

                menuStrip1.Visible = false;
                menuStrip2.Visible = false;
                menuStrip3.Visible = false;
                menuStrip4.Visible = true;
                menuStrip5.Visible = false;
                menuStrip6.Visible = false;
            }
            CBBNOME.Focus();
        }
        public void inserircadastrar1()
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
        }
        public void inserircadastrar2()
        {
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
        }
        public void inserircadastrar3()
        {
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
        }
        public void inserircadastrar4()
        {
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
        }
        public void inserircadastrar5()
        {
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
        }
        public void inserircadastrar6()
        {
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
        }
        public void inserircadastrar7()
        {
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
        public void inseriratualizar1()
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
        }
        public void inseriratualizar2()
        {
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
        }
        public void inseriratualizar3()
        {
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
        }
        public void inseriratualizar4()
        {
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
        }
        public void inseriratualizar5()
        {
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
        }
        public void inseriratualizar6()
        {
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
        }
        public void inseriratualizar7()
        {
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
        private void BTNINSERIR_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                inserircadastrar1();

                inserircadastrar2();

                inserircadastrar3();

                inserircadastrar4();

                inserircadastrar5();

                inserircadastrar6();

                inserircadastrar7();
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                inseriratualizar1();

                inseriratualizar2();

                inseriratualizar3();

                inseriratualizar4();

                inseriratualizar5();

                inseriratualizar6();

                inseriratualizar7();
            }
        }
        private void BTNCANCELA_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                LIMPARTXBCBB();

                DDDFALSE();
                TELEFONEFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                TIPOFALSE();
                SEXOFALSE();

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
                if (DialogResult.Yes == MessageBox.Show("CANCELAR ATUALIZAÇÃO?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    LIMPARTXBCBB();

                    DDDFALSE();
                    TELEFONEFALSE();
                    CONTATOFALSE();
                    EMAILFALSE();
                    TIPOFALSE();
                    SEXOFALSE();

                    TXBRAZAOSOCIAL.Clear();
                    TXBCEP.Clear();
                    TXBCODIGO.Clear();

                    TXBCEP.Visible = true;
                    TXBCEP.Enabled = false;
                    TXBNUMERO.Visible = true;
                    TXBNUMERO.Enabled = false;
                    TXBCOMPLEMENTO.Visible = true;
                    TXBCOMPLEMENTO.Enabled = false;
                    TXBINSCEST.Visible = true;
                    TXBINSCEST.Enabled = false;
                    TXBINSCMUN.Visible = true;
                    TXBINSCMUN.Enabled = false;
                    CBBTIPO1.Visible = true;
                    CBBTIPO1.Enabled = false;
                    TXBDDD1.Visible = true;
                    TXBDDD1.Enabled = false;
                    TXBTELEFONE1.Visible = true;
                    TXBTELEFONE1.Enabled = false;
                    TXBCONTATO1.Visible = true;
                    TXBCONTATO1.Enabled = false;
                    CBBSEXO1.Visible = true;
                    CBBSEXO1.Enabled = false;
                    TXBEMAIL1.Visible = true;
                    TXBEMAIL1.Enabled = false;

                    CBBNOME.Visible = true;
                    CBBNOME.Enabled = true;

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

                    CBBNOME.Focus();
                }
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                if (DialogResult.Yes == MessageBox.Show("CANCELAR EXCLUSÃO?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    LIMPARTXBCBB();

                    CBBNOME.Focus();
                }
            }
        }
        private void BTNCADAUTEXC_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                MySqlConnection CONEXAOCADASTRARCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAOCADASTRARCLIENTE.Open();
                MySqlCommand COMANDOCADASTRARCLIENTE = new MySqlCommand("insert into CLIENTE(NOME, RAZAOSOCIAL, IDCLIENTE) values(?,?,null)", CONEXAOCADASTRARCLIENTE);
                COMANDOCADASTRARCLIENTE.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = TXBNOME.Text;
                COMANDOCADASTRARCLIENTE.Parameters.Add("@RAZAOSOCIAL", MySqlDbType.VarChar, 100).Value = TXBRAZAOSOCIAL.Text;
                COMANDOCADASTRARCLIENTE.ExecuteNonQuery();
                CONEXAOCADASTRARCLIENTE.Close();

                MySqlConnection CONEXAOCADASTRARFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAOCADASTRARFISCAIS.Open();
                MySqlCommand COMANDOCADASTRARFISCAIS = new MySqlCommand("insert into FISCAIS(CNPJ, INSCEST, INSCMUN) values(?,?,?)", CONEXAOCADASTRARFISCAIS);
                COMANDOCADASTRARFISCAIS.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 18).Value = TXBCNPJ.Text;
                COMANDOCADASTRARFISCAIS.Parameters.Add("@INSCEST", MySqlDbType.VarChar, 30).Value = TXBINSCEST.Text;
                COMANDOCADASTRARFISCAIS.Parameters.Add("@INSCMUN", MySqlDbType.VarChar, 30).Value = TXBINSCMUN.Text;
                COMANDOCADASTRARFISCAIS.ExecuteNonQuery();
                CONEXAOCADASTRARFISCAIS.Close();

                MySqlConnection CONEXAOCADASTRARENDERECO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAOCADASTRARENDERECO.Open();
                MySqlCommand COMANDOCADASTRARENDERECO = new MySqlCommand("insert into ENDERECO(RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP) values(?,?,?,?,?,?,?)", CONEXAOCADASTRARENDERECO);
                COMANDOCADASTRARENDERECO.Parameters.Add("@RUA", MySqlDbType.VarChar, 150).Value = TXBRUA.Text;
                COMANDOCADASTRARENDERECO.Parameters.Add("@NUMERO", MySqlDbType.VarChar, 10).Value = TXBNUMERO.Text;
                COMANDOCADASTRARENDERECO.Parameters.Add("@COMPLEMENTO", MySqlDbType.VarChar, 50).Value = TXBCOMPLEMENTO.Text;
                COMANDOCADASTRARENDERECO.Parameters.Add("@BAIRRO", MySqlDbType.VarChar, 50).Value = TXBBAIRRO.Text;
                COMANDOCADASTRARENDERECO.Parameters.Add("@CIDADE", MySqlDbType.VarChar, 50).Value = TXBCIDADE.Text;
                COMANDOCADASTRARENDERECO.Parameters.Add("@ESTADO", MySqlDbType.VarChar, 2).Value = TXBESTADO.Text;
                COMANDOCADASTRARENDERECO.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = TXBCEP.Text;
                COMANDOCADASTRARENDERECO.ExecuteNonQuery();
                CONEXAOCADASTRARENDERECO.Close();

                MySqlConnection CONEXAOCADASTRARCONTATO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAOCADASTRARCONTATO.Open();
                MySqlCommand COMANDOCADASTRARCONTATO = new MySqlCommand("insert into CONTATO(CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3, CONTATO4, SEXO4, EMAIL4, CONTATO5, SEXO5, EMAIL5, CONTATO6, SEXO6, EMAIL6, CONTATO7, SEXO7, EMAIL7, CONTATO8, SEXO8, EMAIL8) values( ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", CONEXAOCADASTRARCONTATO);
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO1", MySqlDbType.VarChar, 100).Value = TXBCONTATO1.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO1", MySqlDbType.VarChar, 1).Value = CBBSEXO1.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL1", MySqlDbType.VarChar, 100).Value = TXBEMAIL1.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO2", MySqlDbType.VarChar, 100).Value = TXBCONTATO2.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO2", MySqlDbType.VarChar, 1).Value = CBBSEXO2.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL2", MySqlDbType.VarChar, 100).Value = TXBEMAIL2.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO3", MySqlDbType.VarChar, 100).Value = TXBCONTATO3.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO3", MySqlDbType.VarChar, 1).Value = CBBSEXO3.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL3", MySqlDbType.VarChar, 100).Value = TXBEMAIL3.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO4", MySqlDbType.VarChar, 100).Value = TXBCONTATO4.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO4", MySqlDbType.VarChar, 1).Value = CBBSEXO4.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL4", MySqlDbType.VarChar, 100).Value = TXBEMAIL4.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO5", MySqlDbType.VarChar, 100).Value = TXBCONTATO5.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO5", MySqlDbType.VarChar, 1).Value = CBBSEXO5.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL5", MySqlDbType.VarChar, 100).Value = TXBEMAIL5.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO6", MySqlDbType.VarChar, 100).Value = TXBCONTATO6.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO6", MySqlDbType.VarChar, 1).Value = CBBSEXO6.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL6", MySqlDbType.VarChar, 100).Value = TXBEMAIL6.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO7", MySqlDbType.VarChar, 100).Value = TXBCONTATO7.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO7", MySqlDbType.VarChar, 1).Value = CBBSEXO7.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL7", MySqlDbType.VarChar, 100).Value = TXBEMAIL7.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO8", MySqlDbType.VarChar, 100).Value = TXBCONTATO8.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO8", MySqlDbType.VarChar, 1).Value = CBBSEXO8.Text;
                COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL8", MySqlDbType.VarChar, 100).Value = TXBEMAIL8.Text;
                COMANDOCADASTRARCONTATO.ExecuteNonQuery();
                CONEXAOCADASTRARCONTATO.Close();

                MySqlConnection CONEXAOCADASTRARTELEFONE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAOCADASTRARTELEFONE.Open();
                MySqlCommand COMANDOCADASTRARTELEFONE = new MySqlCommand("insert into TELEFONE(TIPO1, DDD1, TELEFONE1, TIPO2, DDD2, TELEFONE2, TIPO3, DDD3, TELEFONE3, TIPO4, DDD4, TELEFONE4, TIPO5, DDD5, TELEFONE5, TIPO6, DDD6, TELEFONE6, TIPO7, DDD7, TELEFONE7,TIPO8, DDD8, TELEFONE8) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", CONEXAOCADASTRARTELEFONE);
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO1", MySqlDbType.VarChar, 6).Value = CBBTIPO1.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD1", MySqlDbType.VarChar, 4).Value = TXBDDD1.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE1", MySqlDbType.VarChar, 10).Value = TXBTELEFONE1.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO2", MySqlDbType.VarChar, 6).Value = CBBTIPO2.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD2", MySqlDbType.VarChar, 4).Value = TXBDDD2.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE2", MySqlDbType.VarChar, 10).Value = TXBTELEFONE2.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO3", MySqlDbType.VarChar, 6).Value = CBBTIPO3.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD3", MySqlDbType.VarChar, 4).Value = TXBDDD3.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE3", MySqlDbType.VarChar, 10).Value = TXBTELEFONE3.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO4", MySqlDbType.VarChar, 6).Value = CBBTIPO4.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD4", MySqlDbType.VarChar, 4).Value = TXBDDD4.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE4", MySqlDbType.VarChar, 10).Value = TXBTELEFONE4.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO5", MySqlDbType.VarChar, 6).Value = CBBTIPO5.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD5", MySqlDbType.VarChar, 4).Value = TXBDDD5.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE5", MySqlDbType.VarChar, 10).Value = TXBTELEFONE5.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO6", MySqlDbType.VarChar, 6).Value = CBBTIPO6.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD6", MySqlDbType.VarChar, 4).Value = TXBDDD6.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE6", MySqlDbType.VarChar, 10).Value = TXBTELEFONE6.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO7", MySqlDbType.VarChar, 6).Value = CBBTIPO7.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD7", MySqlDbType.VarChar, 4).Value = TXBDDD7.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE7", MySqlDbType.VarChar, 10).Value = TXBTELEFONE7.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO8", MySqlDbType.VarChar, 6).Value = CBBTIPO8.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD8", MySqlDbType.VarChar, 4).Value = TXBDDD8.Text;
                COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE8", MySqlDbType.VarChar, 10).Value = TXBTELEFONE8.Text;
                COMANDOCADASTRARTELEFONE.ExecuteNonQuery();
                CONEXAOCADASTRARTELEFONE.Close();

                LIMPARTXBCBB();

                TXBCEP.Focus();
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                if (DialogResult.Yes == MessageBox.Show("ATUALIZAR CLIENTE?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    MySqlConnection CONEXAOATUALIZARFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOATUALIZARFISCAIS.Open();
                    MySqlCommand COMANDOATUALIZARFISCAIS = new MySqlCommand("update FISCAIS SET INSCEST = ?,INSCMUN = ? where IDFISCAIS = ? ", CONEXAOATUALIZARFISCAIS);
                    COMANDOATUALIZARFISCAIS.Parameters.Add("@INSCEST", MySqlDbType.VarChar).Value = TXBINSCEST.Text;
                    COMANDOATUALIZARFISCAIS.Parameters.Add("@INSCMUN", MySqlDbType.VarChar).Value = TXBINSCMUN.Text;
                    COMANDOATUALIZARFISCAIS.Parameters.Add("@IDFISCAIS", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOATUALIZARFISCAIS.ExecuteNonQuery();
                    CONEXAOATUALIZARFISCAIS.Close();

                    MySqlConnection CONEXAOCADASTRARENDERECO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARENDERECO.Open();
                    MySqlCommand COMANDOCADASTRARENDERECO = new MySqlCommand("update ENDERECO SET RUA = ?,NUMERO = ?,COMPLEMENTO = ?,BAIRRO = ?,CIDADE = ?,ESTADO = ?,CEP = ? where IDENDERECO = ? ", CONEXAOCADASTRARENDERECO);
                    COMANDOCADASTRARENDERECO.Parameters.Add("@RUA", MySqlDbType.VarChar).Value = TXBRUA.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add("@NUMERO", MySqlDbType.VarChar).Value = TXBNUMERO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add("@COMPLEMENTO", MySqlDbType.VarChar).Value = TXBCOMPLEMENTO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add("@BAIRRO", MySqlDbType.VarChar).Value = TXBBAIRRO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add("@CIDADE", MySqlDbType.VarChar).Value = TXBCIDADE.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = TXBESTADO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add("@CEP", MySqlDbType.VarChar).Value = TXBCEP.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add("@IDENDERECO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOCADASTRARENDERECO.ExecuteNonQuery();
                    CONEXAOCADASTRARENDERECO.Close();

                    MySqlConnection CONEXAOCADASTRARCONTATO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARCONTATO.Open();
                    MySqlCommand COMANDOCADASTRARCONTATO = new MySqlCommand("update CONTATO SET CONTATO1 = ?,SEXO1 = ?,EMAIL1 = ?,CONTATO2 = ?,SEXO2 = ?,EMAIL2 = ?,CONTATO3 = ?,SEXO3 = ?,EMAIL3 = ?,CONTATO4 = ?,SEXO4 = ?,EMAIL4 = ?,CONTATO5 = ?,SEXO5 = ?,EMAIL5 = ?,CONTATO6 = ?,SEXO6 = ?,EMAIL6 = ?,CONTATO7 = ?,SEXO7 = ?,EMAIL7 = ?,CONTATO8 = ?,SEXO8 = ?,EMAIL8 = ? where IDCONTATO = ?", CONEXAOCADASTRARCONTATO);
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO1", MySqlDbType.VarChar).Value = TXBCONTATO1.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO1", MySqlDbType.VarChar).Value = CBBSEXO1.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL1", MySqlDbType.VarChar).Value = TXBEMAIL1.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO2", MySqlDbType.VarChar).Value = TXBCONTATO2.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO2", MySqlDbType.VarChar).Value = CBBSEXO2.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL2", MySqlDbType.VarChar).Value = TXBEMAIL2.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO3", MySqlDbType.VarChar).Value = TXBCONTATO3.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO3", MySqlDbType.VarChar).Value = CBBSEXO3.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL3", MySqlDbType.VarChar).Value = TXBEMAIL3.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO4", MySqlDbType.VarChar).Value = TXBCONTATO4.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO4", MySqlDbType.VarChar).Value = CBBSEXO4.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL4", MySqlDbType.VarChar).Value = TXBEMAIL4.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO5", MySqlDbType.VarChar).Value = TXBCONTATO5.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO5", MySqlDbType.VarChar).Value = CBBSEXO5.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL5", MySqlDbType.VarChar).Value = TXBEMAIL5.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO6", MySqlDbType.VarChar).Value = TXBCONTATO6.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO6", MySqlDbType.VarChar).Value = CBBSEXO6.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL6", MySqlDbType.VarChar).Value = TXBEMAIL6.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO7", MySqlDbType.VarChar).Value = TXBCONTATO7.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO7", MySqlDbType.VarChar).Value = CBBSEXO7.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL7", MySqlDbType.VarChar).Value = TXBEMAIL7.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@CONTATO8", MySqlDbType.VarChar).Value = TXBCONTATO8.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@SEXO8", MySqlDbType.VarChar).Value = CBBSEXO8.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@EMAIL8", MySqlDbType.VarChar).Value = TXBEMAIL8.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add("@IDCONTATO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOCADASTRARCONTATO.ExecuteNonQuery();
                    CONEXAOCADASTRARCONTATO.Close();

                    MySqlConnection CONEXAOCADASTRARTELEFONE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARTELEFONE.Open();
                    MySqlCommand COMANDOCADASTRARTELEFONE = new MySqlCommand("Update TELEFONE SET TIPO1 = ?, DDD1 = ?, TELEFONE1 = ?, TIPO2 = ?, DDD2 = ?, TELEFONE2 = ?, TIPO3 = ?, DDD3 = ?, TELEFONE3 = ?, TIPO4 = ?, DDD4 = ?, TELEFONE4 = ?, TIPO5 = ?, DDD5 = ?, TELEFONE5 = ?, TIPO6 = ?, DDD6 = ?, TELEFONE6 = ?, TIPO7 = ?, DDD7 = ?, TELEFONE7 = ?,TIPO8 = ?, DDD8 = ?, TELEFONE8 = ? where IDTELEFONE = ?", CONEXAOCADASTRARTELEFONE);
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO1", MySqlDbType.VarChar).Value = CBBTIPO1.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD1", MySqlDbType.VarChar).Value = TXBDDD1.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE1", MySqlDbType.VarChar).Value = TXBTELEFONE1.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO2", MySqlDbType.VarChar).Value = CBBTIPO2.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD2", MySqlDbType.VarChar).Value = TXBDDD2.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE2", MySqlDbType.VarChar).Value = TXBTELEFONE2.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO3", MySqlDbType.VarChar).Value = CBBTIPO3.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD3", MySqlDbType.VarChar).Value = TXBDDD3.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE3", MySqlDbType.VarChar).Value = TXBTELEFONE3.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO4", MySqlDbType.VarChar).Value = CBBTIPO4.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD4", MySqlDbType.VarChar).Value = TXBDDD4.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE4", MySqlDbType.VarChar).Value = TXBTELEFONE4.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO5", MySqlDbType.VarChar).Value = CBBTIPO5.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD5", MySqlDbType.VarChar).Value = TXBDDD5.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE5", MySqlDbType.VarChar).Value = TXBTELEFONE5.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO6", MySqlDbType.VarChar).Value = CBBTIPO6.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD6", MySqlDbType.VarChar).Value = TXBDDD6.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE6", MySqlDbType.VarChar).Value = TXBTELEFONE6.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO7", MySqlDbType.VarChar).Value = CBBTIPO7.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD7", MySqlDbType.VarChar).Value = TXBDDD7.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE7", MySqlDbType.VarChar).Value = TXBTELEFONE7.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TIPO8", MySqlDbType.VarChar).Value = CBBTIPO8.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@DDD8", MySqlDbType.VarChar).Value = TXBDDD8.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@TELEFONE8", MySqlDbType.VarChar).Value = TXBTELEFONE8.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add("@IDTELEFONE", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOCADASTRARTELEFONE.ExecuteNonQuery();
                    CONEXAOCADASTRARTELEFONE.Close();

                    LIMPARTXBCBB();

                    TXBCEP.Visible = true;
                    TXBCEP.Enabled = false;
                    TXBNUMERO.Visible = true;
                    TXBNUMERO.Enabled = false;
                    TXBCOMPLEMENTO.Visible = true;
                    TXBCOMPLEMENTO.Enabled = false;
                    TXBINSCEST.Visible = true;
                    TXBINSCEST.Enabled = false;
                    TXBINSCMUN.Visible = true;
                    TXBINSCMUN.Enabled = false;
                    CBBTIPO1.Visible = true;
                    CBBTIPO1.Enabled = false;
                    TXBDDD1.Visible = true;
                    TXBDDD1.Enabled = false;
                    TXBTELEFONE1.Visible = true;
                    TXBTELEFONE1.Enabled = false;
                    TXBCONTATO1.Visible = true;
                    TXBCONTATO1.Enabled = false;
                    CBBSEXO1.Visible = true;
                    CBBSEXO1.Enabled = false;
                    TXBEMAIL1.Visible = true;
                    TXBEMAIL1.Enabled = false;

                    CBBNOME.Visible = true;
                    CBBNOME.Enabled = true;

                    CBBNOME.Focus();
                }
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    MySqlConnection CONEXAOEXCLUIRCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOEXCLUIRCLIENTE.Open();
                    MySqlCommand COMANDOEXCLUIRCLIENTE = new MySqlCommand("delete FROM CLIENTE where IDCLIENTE = ?", CONEXAOEXCLUIRCLIENTE);
                    COMANDOEXCLUIRCLIENTE.Parameters.Add("@IDCLIENTE", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOEXCLUIRCLIENTE.ExecuteNonQuery();
                    CONEXAOEXCLUIRCLIENTE.Close();

                    MySqlConnection CONEXAOEXCLUIRCLIENTE2 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");
                    CONEXAOEXCLUIRCLIENTE2.Open();
                    MySqlCommand COMANDOEXCLUIRCLIENTE2 = new MySqlCommand("delete FROM CLIENTE where RAZAOSOCIAL = ?", CONEXAOEXCLUIRCLIENTE2);
                    COMANDOEXCLUIRCLIENTE2.Parameters.Add("@RAZAOSOCIAL", MySqlDbType.VarChar).Value = TXBRAZAOSOCIAL.Text;
                    COMANDOEXCLUIRCLIENTE2.ExecuteNonQuery();
                    CONEXAOEXCLUIRCLIENTE2.Close();

                    MySqlConnection CONEXAOEXCLUIRFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOEXCLUIRFISCAIS.Open();
                    MySqlCommand COMANDOEXCLUIRFISCAIS = new MySqlCommand("delete FROM FISCAIS where IDFISCAIS = ?", CONEXAOEXCLUIRFISCAIS);
                    COMANDOEXCLUIRFISCAIS.Parameters.Add("@IDFISCAIS", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOEXCLUIRFISCAIS.ExecuteNonQuery();
                    CONEXAOEXCLUIRFISCAIS.Close();

                    MySqlConnection CONEXAOEXCLUIRFISCAIS2 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");
                    CONEXAOEXCLUIRFISCAIS2.Open();
                    MySqlCommand COMANDOEXCLUIRFISCAIS2 = new MySqlCommand("delete FROM FISCAIS where CNPJ = ?", CONEXAOEXCLUIRFISCAIS2);
                    COMANDOEXCLUIRFISCAIS2.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = TXBCNPJ.Text;
                    COMANDOEXCLUIRFISCAIS2.ExecuteNonQuery();
                    CONEXAOEXCLUIRFISCAIS2.Close();

                    MySqlConnection CONEXAOEXCLUIRENDERECO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOEXCLUIRENDERECO.Open();
                    MySqlCommand COMANDOEXCLUIRENDERECO = new MySqlCommand("delete FROM ENDERECO where IDENDERECO = ? ", CONEXAOEXCLUIRENDERECO);
                    COMANDOEXCLUIRENDERECO.Parameters.Add("@IDENDERECO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOEXCLUIRENDERECO.ExecuteNonQuery();
                    CONEXAOEXCLUIRENDERECO.Close();

                    MySqlConnection CONEXAOEXCLUIRCONTATO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOEXCLUIRCONTATO.Open();
                    MySqlCommand COMANDOEXCLUIRCONTATO = new MySqlCommand("delete FROM CONTATO where IDCONTATO = ?", CONEXAOEXCLUIRCONTATO);
                    COMANDOEXCLUIRCONTATO.Parameters.Add("@IDCONTATO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOEXCLUIRCONTATO.ExecuteNonQuery();
                    CONEXAOEXCLUIRCONTATO.Close();

                    MySqlConnection CONEXAOEXCLUIRTELEFONE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOEXCLUIRTELEFONE.Open();
                    MySqlCommand COMANDOEXCLUIRTELEFONE = new MySqlCommand("delete FROM TELEFONE where IDTELEFONE = ?", CONEXAOEXCLUIRTELEFONE);
                    COMANDOEXCLUIRTELEFONE.Parameters.Add("@IDTELEFONE", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                    COMANDOEXCLUIRTELEFONE.ExecuteNonQuery();
                    CONEXAOEXCLUIRTELEFONE.Close();

                    ATUALIZACBB();

                    LIMPARTXBCBB();

                    CBBNOME.Focus();
                }
            }
        }
        public void DDDFALSE()
        {
            TXBDDD2.Visible = false;
            TXBDDD3.Visible = false;
            TXBDDD4.Visible = false;
            TXBDDD5.Visible = false;
            TXBDDD6.Visible = false;
            TXBDDD7.Visible = false;
            TXBDDD8.Visible = false;
        }
        public void TELEFONEFALSE()
        {
            TXBTELEFONE2.Visible = false;
            TXBTELEFONE3.Visible = false;
            TXBTELEFONE4.Visible = false;
            TXBTELEFONE5.Visible = false;
            TXBTELEFONE6.Visible = false;
            TXBTELEFONE7.Visible = false;
            TXBTELEFONE8.Visible = false;
        }
        public void CONTATOFALSE()
        {
            TXBCONTATO2.Visible = false;
            TXBCONTATO3.Visible = false;
            TXBCONTATO4.Visible = false;
            TXBCONTATO5.Visible = false;
            TXBCONTATO6.Visible = false;
            TXBCONTATO7.Visible = false;
            TXBCONTATO8.Visible = false;
        }
        public void EMAILFALSE()
        {
            TXBEMAIL2.Visible = false;
            TXBEMAIL3.Visible = false;
            TXBEMAIL4.Visible = false;
            TXBEMAIL5.Visible = false;
            TXBEMAIL6.Visible = false;
            TXBEMAIL7.Visible = false;
            TXBEMAIL8.Visible = false;
        }
        public void TIPOFALSE()
        {
            CBBTIPO2.Visible = false;
            CBBTIPO3.Visible = false;
            CBBTIPO4.Visible = false;
            CBBTIPO5.Visible = false;
            CBBTIPO6.Visible = false;
            CBBTIPO7.Visible = false;
            CBBTIPO8.Visible = false;
        }
        public void SEXOFALSE()
        {
            CBBSEXO2.Visible = false;
            CBBSEXO3.Visible = false;
            CBBSEXO4.Visible = false;
            CBBSEXO5.Visible = false;
            CBBSEXO6.Visible = false;
            CBBSEXO7.Visible = false;
            CBBSEXO8.Visible = false;
        }
        private void TXBCEP_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (TXBCEP.Text == "")
                {
                    MessageBox.Show("CEP EM BRANCO");

                    TXBCEP.Focus();
                }

            }
        }
        private void TXBNOME_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (TXBNOME.Text == "")
                {
                    MessageBox.Show("NOME EM BRANCO");

                    TXBNOME.Focus();
                }
            }
        }
        private void TXBNUMERO_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (TXBNUMERO.Text == "")
                {
                    MessageBox.Show("NUMERO EM BRANCO");

                    TXBNUMERO.Focus();
                }
            }
        }
        private void TXBRAZAOSOCIAL_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
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

                    MySqlCommand COMANDO3 = new MySqlCommand("insert into CLIENTE(RAZAOSOCIAL) values(?)", CONEXAO);
                    COMANDO3.Parameters.Add("@RAZAOSOCIAL", MySqlDbType.VarChar, 18).Value = TXBRAZAOSOCIAL.Text;

                    COMANDO3.ExecuteNonQuery();

                    CONEXAO.Close();

                }
                catch
                {
                    MessageBox.Show("RAZÃO SOCIAL EXISTENTE");

                    TXBRAZAOSOCIAL.Focus();
                }
            }
        }
        private void TXBCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
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

                    CONEXAO.Close();
                }
                catch
                {
                    MessageBox.Show("CNPJ EXISTENTE");

                    TXBCNPJ.Focus();
                }
            }
        }
        public void pesquisarcliente()
        {
            MySqlConnection CONEXAOCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAOCLIENTE.Open();

            MySqlCommand COMANDOCLIENTE = new MySqlCommand("SELECT IDCLIENTE, NOME, RAZAOSOCIAL FROM CLIENTE WHERE NOME = ?", CONEXAOCLIENTE);
            COMANDOCLIENTE.Parameters.Clear();
            COMANDOCLIENTE.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = CBBNOME.Text;

            COMANDOCLIENTE.CommandType = CommandType.Text;

            MySqlDataReader DRCLIENTE;
            DRCLIENTE = COMANDOCLIENTE.ExecuteReader();
            DRCLIENTE.Read();

            TXBCODIGO.Text = DRCLIENTE.GetString(0);
            TXBRAZAOSOCIAL.Text = DRCLIENTE.GetString(2);

            CONEXAOCLIENTE.Close();
        }
        public void pesquisarendereco()
        {
            MySqlConnection CONEXAOENDERECO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAOENDERECO.Open();

            MySqlCommand COMANDOENDERECO = new MySqlCommand("SELECT RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP FROM ENDERECO WHERE IDENDERECO = ?", CONEXAOENDERECO);
            COMANDOENDERECO.Parameters.Clear();
            COMANDOENDERECO.Parameters.Add("@IDENDERECO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;

            COMANDOENDERECO.CommandType = CommandType.Text;

            MySqlDataReader DRENDERECO;
            DRENDERECO = COMANDOENDERECO.ExecuteReader();
            DRENDERECO.Read();

            TXBRUA.Text = DRENDERECO.GetString(0);
            TXBNUMERO.Text = DRENDERECO.GetString(1);
            TXBCOMPLEMENTO.Text = DRENDERECO.GetString(2);
            TXBBAIRRO.Text = DRENDERECO.GetString(3);
            TXBCIDADE.Text = DRENDERECO.GetString(4);
            TXBESTADO.Text = DRENDERECO.GetString(5);
            TXBCEP.Text = DRENDERECO.GetString(6);

            CONEXAOENDERECO.Close();
        }
        public void pesquisarfiscais()
        {
            MySqlConnection CONEXAOFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAOFISCAIS.Open();

            MySqlCommand COMANDOFISCAIS = new MySqlCommand("SELECT CNPJ, INSCEST, INSCMUN FROM FISCAIS WHERE IDFISCAIS = ?", CONEXAOFISCAIS);
            COMANDOFISCAIS.Parameters.Clear();
            COMANDOFISCAIS.Parameters.Add("@IDFISCAIS", MySqlDbType.VarChar).Value = TXBCODIGO.Text;

            COMANDOFISCAIS.CommandType = CommandType.Text;

            MySqlDataReader DRFISCAIS;
            DRFISCAIS = COMANDOFISCAIS.ExecuteReader();
            DRFISCAIS.Read();

            TXBCNPJ.Text = DRFISCAIS.GetString(0);
            TXBINSCEST.Text = DRFISCAIS.GetString(1);
            TXBINSCMUN.Text = DRFISCAIS.GetString(2);

            CONEXAOFISCAIS.Close();
        }
        public void pesquisarcontato()
        {
            MySqlConnection CONEXAOCONTATO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAOCONTATO.Open();

            MySqlCommand COMANDOCONTATO = new MySqlCommand("SELECT IDCONTATO, CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3, CONTATO4, SEXO4, EMAIL4, CONTATO5, SEXO5, EMAIL5, CONTATO6, SEXO6, EMAIL6, CONTATO7, SEXO7, EMAIL7, CONTATO8, SEXO8, EMAIL8 FROM CONTATO WHERE IDCONTATO = ?", CONEXAOCONTATO);

            COMANDOCONTATO.Parameters.Clear();
            COMANDOCONTATO.Parameters.Add("@IDCONTATO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;

            COMANDOCONTATO.CommandType = CommandType.Text;

            MySqlDataReader DRCONTATO;
            DRCONTATO = COMANDOCONTATO.ExecuteReader();
            DRCONTATO.Read();

            TXBCONTATO1.Text = DRCONTATO.GetString(1);
            CBBSEXO1.Text = DRCONTATO.GetString(2);
            TXBEMAIL1.Text = DRCONTATO.GetString(3);

            TXBCONTATO2.Text = DRCONTATO.GetString(4);
            CBBSEXO2.Text = DRCONTATO.GetString(5);
            TXBEMAIL2.Text = DRCONTATO.GetString(6);

            TXBCONTATO3.Text = DRCONTATO.GetString(7);
            CBBSEXO3.Text = DRCONTATO.GetString(8);
            TXBEMAIL3.Text = DRCONTATO.GetString(9);

            TXBCONTATO4.Text = DRCONTATO.GetString(10);
            CBBSEXO4.Text = DRCONTATO.GetString(11);
            TXBEMAIL4.Text = DRCONTATO.GetString(12);

            TXBCONTATO5.Text = DRCONTATO.GetString(13);
            CBBSEXO5.Text = DRCONTATO.GetString(14);
            TXBEMAIL5.Text = DRCONTATO.GetString(15);

            TXBCONTATO6.Text = DRCONTATO.GetString(16);
            CBBSEXO6.Text = DRCONTATO.GetString(17);
            TXBEMAIL6.Text = DRCONTATO.GetString(18);

            TXBCONTATO7.Text = DRCONTATO.GetString(19);
            CBBSEXO7.Text = DRCONTATO.GetString(20);
            TXBEMAIL7.Text = DRCONTATO.GetString(21);

            TXBCONTATO8.Text = DRCONTATO.GetString(22);
            CBBSEXO8.Text = DRCONTATO.GetString(23);
            TXBEMAIL8.Text = DRCONTATO.GetString(24);

            CONEXAOCONTATO.Close();
        }
        public void pesquisartelefone()
        {
            MySqlConnection CONEXAOTELEFONE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAOTELEFONE.Open();

            MySqlCommand COMANDOTELEFONE = new MySqlCommand("SELECT IDTELEFONE, TIPO1, DDD1, TELEFONE1, TIPO2, DDD2, TELEFONE2, TIPO3, DDD3, TELEFONE3, TIPO4, DDD4, TELEFONE4, TIPO5, DDD5, TELEFONE5, TIPO6, DDD6, TELEFONE6, TIPO7, DDD7, TELEFONE7, TIPO8, DDD8, TELEFONE8 FROM TELEFONE WHERE IDTELEFONE = ?", CONEXAOTELEFONE);

            COMANDOTELEFONE.Parameters.Clear();
            COMANDOTELEFONE.Parameters.Add("@IDTELEFONE", MySqlDbType.VarChar).Value = TXBCODIGO.Text;

            COMANDOTELEFONE.CommandType = CommandType.Text;

            MySqlDataReader DRTELEFONE;
            DRTELEFONE = COMANDOTELEFONE.ExecuteReader();
            DRTELEFONE.Read();

            CBBTIPO1.Text = DRTELEFONE.GetString(1);
            TXBDDD1.Text = DRTELEFONE.GetString(2);
            TXBTELEFONE1.Text = DRTELEFONE.GetString(3);

            CBBTIPO2.Text = DRTELEFONE.GetString(4);
            TXBDDD2.Text = DRTELEFONE.GetString(5);
            TXBTELEFONE2.Text = DRTELEFONE.GetString(6);

            CBBTIPO3.Text = DRTELEFONE.GetString(7);
            TXBDDD3.Text = DRTELEFONE.GetString(8);
            TXBTELEFONE3.Text = DRTELEFONE.GetString(9);

            CBBTIPO4.Text = DRTELEFONE.GetString(10);
            TXBDDD4.Text = DRTELEFONE.GetString(11);
            TXBTELEFONE4.Text = DRTELEFONE.GetString(12);

            CBBTIPO5.Text = DRTELEFONE.GetString(13);
            TXBDDD5.Text = DRTELEFONE.GetString(14);
            TXBTELEFONE5.Text = DRTELEFONE.GetString(15);

            CBBTIPO6.Text = DRTELEFONE.GetString(16);
            TXBDDD6.Text = DRTELEFONE.GetString(17);
            TXBTELEFONE6.Text = DRTELEFONE.GetString(18);

            CBBTIPO7.Text = DRTELEFONE.GetString(18);
            TXBDDD7.Text = DRTELEFONE.GetString(20);
            TXBTELEFONE7.Text = DRTELEFONE.GetString(21);

            CBBTIPO8.Text = DRTELEFONE.GetString(22);
            TXBDDD8.Text = DRTELEFONE.GetString(23);
            TXBTELEFONE8.Text = DRTELEFONE.GetString(24);

            CONEXAOTELEFONE.Close();
        }
        public void pesquisaexcluircliente()
        {
            if (TXBCONTATO2.Text != "")
            {
                CBBTIPO2.Visible = true;
                CBBTIPO2.Enabled = false;

                TXBDDD2.Visible = true;
                TXBDDD2.Enabled = false;

                TXBTELEFONE2.Visible = true;
                TXBTELEFONE2.Enabled = false;

                TXBCONTATO2.Visible = true;
                TXBCONTATO2.Enabled = false;

                CBBSEXO2.Visible = true;
                CBBSEXO2.Enabled = false;

                TXBEMAIL2.Visible = true;
                TXBEMAIL2.Enabled = false;

                TXBDDD3.Visible = false;
                TXBDDD4.Visible = false;
                TXBDDD5.Visible = false;
                TXBDDD6.Visible = false;
                TXBDDD7.Visible = false;
                TXBDDD8.Visible = false;

                TXBTELEFONE3.Visible = false;
                TXBTELEFONE4.Visible = false;
                TXBTELEFONE5.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBTELEFONE8.Visible = false;

                TXBCONTATO3.Visible = false;
                TXBCONTATO4.Visible = false;
                TXBCONTATO5.Visible = false;
                TXBCONTATO6.Visible = false;
                TXBCONTATO7.Visible = false;
                TXBCONTATO8.Visible = false;

                TXBEMAIL3.Visible = false;
                TXBEMAIL4.Visible = false;
                TXBEMAIL5.Visible = false;
                TXBEMAIL6.Visible = false;
                TXBEMAIL7.Visible = false;
                TXBEMAIL8.Visible = false;

                CBBTIPO3.Visible = false;
                CBBTIPO4.Visible = false;
                CBBTIPO5.Visible = false;
                CBBTIPO6.Visible = false;
                CBBTIPO7.Visible = false;
                CBBTIPO8.Visible = false;

                CBBSEXO3.Visible = false;
                CBBSEXO4.Visible = false;
                CBBSEXO5.Visible = false;
                CBBSEXO6.Visible = false;
                CBBSEXO7.Visible = false;
                CBBSEXO8.Visible = false;

                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 544);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 544);
            }
            if (TXBCONTATO3.Text != "")
            {
                CBBTIPO3.Visible = true;
                CBBTIPO3.Enabled = false;

                TXBDDD3.Visible = true;
                TXBDDD3.Enabled = false;

                TXBTELEFONE3.Visible = true;
                TXBTELEFONE3.Enabled = false;

                TXBCONTATO3.Visible = true;
                TXBCONTATO3.Enabled = false;

                CBBSEXO3.Visible = true;
                CBBSEXO3.Enabled = false;

                TXBEMAIL3.Visible = true;
                TXBEMAIL3.Enabled = false;

                BTNCANCELA.Location = new Point(1066, 584);
                BTNCADAUTEXC.Location = new Point(411, 584);
            }
            if (TXBCONTATO4.Text != "")
            {
                CBBTIPO4.Visible = true;
                CBBTIPO4.Enabled = false;

                TXBDDD4.Visible = true;
                TXBDDD4.Enabled = false;

                TXBTELEFONE4.Visible = true;
                TXBTELEFONE4.Enabled = false;

                TXBCONTATO4.Visible = true;
                TXBCONTATO4.Enabled = false;

                CBBSEXO4.Visible = true;
                CBBSEXO4.Enabled = false;

                TXBEMAIL4.Visible = true;
                TXBEMAIL4.Enabled = false;

                BTNCANCELA.Location = new Point(1066, 624);
                BTNCADAUTEXC.Location = new Point(411, 624);
            }
            if (TXBCONTATO5.Text != "")
            {
                CBBTIPO5.Visible = true;
                CBBTIPO5.Enabled = false;

                TXBDDD5.Visible = true;
                TXBDDD5.Enabled = false;

                TXBTELEFONE5.Visible = true;
                TXBTELEFONE5.Enabled = false;

                TXBCONTATO5.Visible = true;
                TXBCONTATO5.Enabled = false;

                CBBSEXO5.Visible = true;
                CBBSEXO5.Enabled = false;

                TXBEMAIL5.Visible = true;
                TXBEMAIL5.Enabled = false;

                BTNCANCELA.Location = new Point(1066, 664);
                BTNCADAUTEXC.Location = new Point(411, 664);
            }
            if (TXBCONTATO6.Text != "")
            {
                CBBTIPO6.Visible = true;
                CBBTIPO6.Enabled = false;

                TXBDDD6.Visible = true;
                TXBDDD6.Enabled = false;

                TXBTELEFONE6.Visible = true;
                TXBTELEFONE6.Enabled = false;

                TXBCONTATO6.Visible = true;
                TXBCONTATO6.Enabled = false;

                CBBSEXO6.Visible = true;
                CBBSEXO6.Enabled = false;

                TXBEMAIL6.Visible = true;
                TXBEMAIL6.Enabled = false;

                BTNCANCELA.Location = new Point(1066, 704);
                BTNCADAUTEXC.Location = new Point(411, 704);
            }
            if (TXBCONTATO7.Text != "")
            {
                CBBTIPO7.Visible = true;
                CBBTIPO7.Enabled = false;

                TXBDDD7.Visible = true;
                TXBDDD7.Enabled = false;

                TXBTELEFONE7.Visible = true;
                TXBTELEFONE7.Enabled = false;

                TXBCONTATO7.Visible = true;
                TXBCONTATO7.Enabled = false;

                CBBSEXO7.Visible = true;
                CBBSEXO7.Enabled = false;

                TXBEMAIL7.Visible = true;
                TXBEMAIL7.Enabled = false;

                BTNCANCELA.Location = new Point(1066, 744);
                BTNCADAUTEXC.Location = new Point(411, 744);
            }
            if (TXBCONTATO8.Text != "")
            {
                CBBTIPO8.Visible = true;
                CBBTIPO8.Enabled = false;

                TXBDDD8.Visible = true;
                TXBDDD8.Enabled = false;

                TXBTELEFONE8.Visible = true;
                TXBTELEFONE8.Enabled = false;

                TXBCONTATO8.Visible = true;
                TXBCONTATO8.Enabled = false;

                CBBSEXO8.Visible = true;
                CBBSEXO8.Enabled = false;

                TXBEMAIL8.Visible = true;
                TXBEMAIL8.Enabled = false;

                BTNCANCELA.Location = new Point(1066, 784);
                BTNCADAUTEXC.Location = new Point(411, 784);
            }
            if (TXBCONTATO2.Text == "")
            {
                TXBDDD2.Visible = false;
                TXBDDD3.Visible = false;
                TXBDDD4.Visible = false;
                TXBDDD5.Visible = false;
                TXBDDD6.Visible = false;
                TXBDDD7.Visible = false;
                TXBDDD8.Visible = false;

                TXBTELEFONE2.Visible = false;
                TXBTELEFONE3.Visible = false;
                TXBTELEFONE4.Visible = false;
                TXBTELEFONE5.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBTELEFONE8.Visible = false;

                TXBCONTATO2.Visible = false;
                TXBCONTATO3.Visible = false;
                TXBCONTATO4.Visible = false;
                TXBCONTATO5.Visible = false;
                TXBCONTATO6.Visible = false;
                TXBCONTATO7.Visible = false;
                TXBCONTATO8.Visible = false;

                TXBEMAIL2.Visible = false;
                TXBEMAIL3.Visible = false;
                TXBEMAIL4.Visible = false;
                TXBEMAIL5.Visible = false;
                TXBEMAIL6.Visible = false;
                TXBEMAIL7.Visible = false;
                TXBEMAIL8.Visible = false;

                CBBTIPO2.Visible = false;
                CBBTIPO3.Visible = false;
                CBBTIPO4.Visible = false;
                CBBTIPO5.Visible = false;
                CBBTIPO6.Visible = false;
                CBBTIPO7.Visible = false;
                CBBTIPO8.Visible = false;

                CBBSEXO2.Visible = false;
                CBBSEXO3.Visible = false;
                CBBSEXO4.Visible = false;
                CBBSEXO5.Visible = false;
                CBBSEXO6.Visible = false;
                CBBSEXO7.Visible = false;
                CBBSEXO8.Visible = false;

                BTNCANCELA.Location = new Point(1066, 504);
                BTNCADAUTEXC.Location = new Point(411, 504);
            }
        }
        public void pesquisaratualizarcliente()
        {
            if (TXBCONTATO1.Text != "")
            {
                CBBTIPO1.Visible = true;
                CBBTIPO1.Enabled = true;

                TXBDDD1.Visible = true;
                TXBDDD1.Enabled = true;

                TXBTELEFONE1.Visible = true;
                TXBTELEFONE1.Enabled = true;

                TXBCONTATO1.Visible = true;
                TXBCONTATO1.Enabled = true;

                CBBSEXO1.Visible = true;
                CBBSEXO1.Enabled = true;

                TXBEMAIL1.Visible = true;
                TXBEMAIL1.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 504);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 544);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 544);
            }
            if (TXBCONTATO1.Text == "")
            {
                CBBTIPO1.Visible = true;
                TXBDDD1.Visible = true;
                TXBTELEFONE1.Visible = true;
                TXBCONTATO1.Visible = true;
                CBBSEXO1.Visible = true;
                TXBEMAIL1.Visible = true;

                CBBTIPO2.Visible = false;
                TXBDDD2.Visible = false;
                TXBTELEFONE2.Visible = false;
                TXBCONTATO2.Visible = false;
                CBBSEXO2.Visible = false;
                TXBEMAIL2.Visible = false;

                CBBTIPO3.Visible = false;
                TXBDDD3.Visible = false;
                TXBTELEFONE3.Visible = false;
                TXBCONTATO3.Visible = false;
                CBBSEXO3.Visible = false;
                TXBEMAIL3.Visible = false;

                CBBTIPO4.Visible = false;
                TXBDDD4.Visible = false;
                TXBTELEFONE4.Visible = false;
                TXBCONTATO4.Visible = false;
                CBBSEXO4.Visible = false;
                TXBEMAIL4.Visible = false;

                CBBTIPO5.Visible = false;
                TXBDDD5.Visible = false;
                TXBTELEFONE5.Visible = false;
                TXBCONTATO5.Visible = false;
                CBBSEXO5.Visible = false;
                TXBEMAIL5.Visible = false;

                CBBTIPO6.Visible = false;
                TXBDDD6.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBCONTATO6.Visible = false;
                CBBSEXO6.Visible = false;
                TXBEMAIL6.Visible = false;

                CBBTIPO7.Visible = false;
                TXBDDD7.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBCONTATO7.Visible = false;
                CBBSEXO7.Visible = false;
                TXBEMAIL7.Visible = false;

                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 504);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 544);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 544);
            }
            if (TXBCONTATO2.Text != "")
            {
                CBBTIPO2.Visible = true;
                CBBTIPO2.Enabled = true;

                TXBDDD2.Visible = true;
                TXBDDD2.Enabled = true;

                TXBTELEFONE2.Visible = true;
                TXBTELEFONE2.Enabled = true;

                TXBCONTATO2.Visible = true;
                TXBCONTATO2.Enabled = true;

                CBBSEXO2.Visible = true;
                CBBSEXO2.Enabled = true;

                TXBEMAIL2.Visible = true;
                TXBEMAIL2.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 544);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 584);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 584);
            }
            if (TXBCONTATO2.Text == "")
            {
                CBBTIPO2.Visible = false;
                TXBDDD2.Visible = false;
                TXBTELEFONE2.Visible = false;
                TXBCONTATO2.Visible = false;
                CBBSEXO2.Visible = false;
                TXBEMAIL2.Visible = false;

                CBBTIPO3.Visible = false;
                TXBDDD3.Visible = false;
                TXBTELEFONE3.Visible = false;
                TXBCONTATO3.Visible = false;
                CBBSEXO3.Visible = false;
                TXBEMAIL3.Visible = false;

                CBBTIPO4.Visible = false;
                TXBDDD4.Visible = false;
                TXBTELEFONE4.Visible = false;
                TXBCONTATO4.Visible = false;
                CBBSEXO4.Visible = false;
                TXBEMAIL4.Visible = false;

                CBBTIPO5.Visible = false;
                TXBDDD5.Visible = false;
                TXBTELEFONE5.Visible = false;
                TXBCONTATO5.Visible = false;
                CBBSEXO5.Visible = false;
                TXBEMAIL5.Visible = false;

                CBBTIPO6.Visible = false;
                TXBDDD6.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBCONTATO6.Visible = false;
                CBBSEXO6.Visible = false;
                TXBEMAIL6.Visible = false;

                CBBTIPO7.Visible = false;
                TXBDDD7.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBCONTATO7.Visible = false;
                CBBSEXO7.Visible = false;
                TXBEMAIL7.Visible = false;

                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 504);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 544);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 544);
            }
            if (TXBCONTATO3.Text != "")
            {
                CBBTIPO3.Visible = true;
                CBBTIPO3.Enabled = true;

                TXBDDD3.Visible = true;
                TXBDDD3.Enabled = true;

                TXBTELEFONE3.Visible = true;
                TXBTELEFONE3.Enabled = true;

                TXBCONTATO3.Visible = true;
                TXBCONTATO3.Enabled = true;

                CBBSEXO3.Visible = true;
                CBBSEXO3.Enabled = true;

                TXBEMAIL3.Visible = true;
                TXBEMAIL3.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 584);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 624);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 624);
            }
            if (TXBCONTATO3.Text == "" && TXBCONTATO2.Text != "")
            {
                CBBTIPO3.Visible = false;
                TXBDDD3.Visible = false;
                TXBTELEFONE3.Visible = false;
                TXBCONTATO3.Visible = false;
                CBBSEXO3.Visible = false;
                TXBEMAIL3.Visible = false;

                CBBTIPO4.Visible = false;
                TXBDDD4.Visible = false;
                TXBTELEFONE4.Visible = false;
                TXBCONTATO4.Visible = false;
                CBBSEXO4.Visible = false;
                TXBEMAIL4.Visible = false;

                CBBTIPO5.Visible = false;
                TXBDDD5.Visible = false;
                TXBTELEFONE5.Visible = false;
                TXBCONTATO5.Visible = false;
                CBBSEXO5.Visible = false;
                TXBEMAIL5.Visible = false;

                CBBTIPO6.Visible = false;
                TXBDDD6.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBCONTATO6.Visible = false;
                CBBSEXO6.Visible = false;
                TXBEMAIL6.Visible = false;

                CBBTIPO7.Visible = false;
                TXBDDD7.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBCONTATO7.Visible = false;
                CBBSEXO7.Visible = false;
                TXBEMAIL7.Visible = false;

                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 544);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 584);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 584);
            }
            if (TXBCONTATO4.Text != "")
            {
                CBBTIPO4.Visible = true;
                CBBTIPO4.Enabled = true;

                TXBDDD4.Visible = true;
                TXBDDD4.Enabled = true;

                TXBTELEFONE4.Visible = true;
                TXBTELEFONE4.Enabled = true;

                TXBCONTATO4.Visible = true;
                TXBCONTATO4.Enabled = true;

                CBBSEXO4.Visible = true;
                CBBSEXO4.Enabled = true;

                TXBEMAIL4.Visible = true;
                TXBEMAIL4.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 624);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 664);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 664);
            }
            if (TXBCONTATO4.Text == "" && TXBCONTATO3.Text != "")
            {
                CBBTIPO4.Visible = false;
                TXBDDD4.Visible = false;
                TXBTELEFONE4.Visible = false;
                TXBCONTATO4.Visible = false;
                CBBSEXO4.Visible = false;
                TXBEMAIL4.Visible = false;

                CBBTIPO5.Visible = false;
                TXBDDD5.Visible = false;
                TXBTELEFONE5.Visible = false;
                TXBCONTATO5.Visible = false;
                CBBSEXO5.Visible = false;
                TXBEMAIL5.Visible = false;

                CBBTIPO6.Visible = false;
                TXBDDD6.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBCONTATO6.Visible = false;
                CBBSEXO6.Visible = false;
                TXBEMAIL6.Visible = false;

                CBBTIPO7.Visible = false;
                TXBDDD7.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBCONTATO7.Visible = false;
                CBBSEXO7.Visible = false;
                TXBEMAIL7.Visible = false;

                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 584);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 624);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 624);
            }
            if (TXBCONTATO5.Text != "")
            {
                CBBTIPO5.Visible = true;
                CBBTIPO5.Enabled = true;

                TXBDDD5.Visible = true;
                TXBDDD5.Enabled = true;

                TXBTELEFONE5.Visible = true;
                TXBTELEFONE5.Enabled = true;

                TXBCONTATO5.Visible = true;
                TXBCONTATO5.Enabled = true;

                CBBSEXO5.Visible = true;
                CBBSEXO5.Enabled = true;

                TXBEMAIL5.Visible = true;
                TXBEMAIL5.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 664);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 704);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 704);
            }
            if (TXBCONTATO5.Text == "" && TXBCONTATO4.Text != "")
            {
                CBBTIPO5.Visible = false;
                TXBDDD5.Visible = false;
                TXBTELEFONE5.Visible = false;
                TXBCONTATO5.Visible = false;
                CBBSEXO5.Visible = false;
                TXBEMAIL5.Visible = false;

                CBBTIPO6.Visible = false;
                TXBDDD6.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBCONTATO6.Visible = false;
                CBBSEXO6.Visible = false;
                TXBEMAIL6.Visible = false;

                CBBTIPO7.Visible = false;
                TXBDDD7.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBCONTATO7.Visible = false;
                CBBSEXO7.Visible = false;
                TXBEMAIL7.Visible = false;

                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 624);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 664);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 664);
            }
            if (TXBCONTATO6.Text != "")
            {
                CBBTIPO6.Visible = true;
                CBBTIPO6.Enabled = true;

                TXBDDD6.Visible = true;
                TXBDDD6.Enabled = true;

                TXBTELEFONE6.Visible = true;
                TXBTELEFONE6.Enabled = true;

                TXBCONTATO6.Visible = true;
                TXBCONTATO6.Enabled = true;

                CBBSEXO6.Visible = true;
                CBBSEXO6.Enabled = true;

                TXBEMAIL6.Visible = true;
                TXBEMAIL6.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 704);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 744);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 744);
            }
            if (TXBCONTATO6.Text == "" && TXBCONTATO5.Text != "")
            {
                CBBTIPO6.Visible = false;
                TXBDDD6.Visible = false;
                TXBTELEFONE6.Visible = false;
                TXBCONTATO6.Visible = false;
                CBBSEXO6.Visible = false;
                TXBEMAIL6.Visible = false;

                CBBTIPO7.Visible = false;
                TXBDDD7.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBCONTATO7.Visible = false;
                CBBSEXO7.Visible = false;
                TXBEMAIL7.Visible = false;

                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 664);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 704);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 704);
            }
            if (TXBCONTATO7.Text != "")
            {
                CBBTIPO7.Visible = true;
                CBBTIPO7.Enabled = true;

                TXBDDD7.Visible = true;
                TXBDDD7.Enabled = true;

                TXBTELEFONE7.Visible = true;
                TXBTELEFONE7.Enabled = true;

                TXBCONTATO7.Visible = true;
                TXBCONTATO7.Enabled = true;

                CBBSEXO7.Visible = true;
                CBBSEXO7.Enabled = true;

                TXBEMAIL7.Visible = true;
                TXBEMAIL7.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 744);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 784);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 784);
            }
            if (TXBCONTATO7.Text == "" && TXBCONTATO6.Text != "")
            {
                CBBTIPO7.Visible = false;
                TXBDDD7.Visible = false;
                TXBTELEFONE7.Visible = false;
                TXBCONTATO7.Visible = false;
                CBBSEXO7.Visible = false;
                TXBEMAIL7.Visible = false;

                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 704);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 744);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 744);
            }
            if (TXBCONTATO8.Text != "")
            {
                CBBTIPO8.Visible = true;
                CBBTIPO8.Enabled = true;

                TXBDDD8.Visible = true;
                TXBDDD8.Enabled = true;

                TXBTELEFONE8.Visible = true;
                TXBTELEFONE8.Enabled = true;

                TXBCONTATO8.Visible = true;
                TXBCONTATO8.Enabled = true;

                CBBSEXO8.Visible = true;
                CBBSEXO8.Enabled = true;

                TXBEMAIL8.Visible = true;
                TXBEMAIL8.Enabled = true;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 784);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 824);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 824);
            }
            if (TXBCONTATO8.Text == "" && TXBCONTATO7.Text != "")
            {
                CBBTIPO8.Visible = false;
                TXBDDD8.Visible = false;
                TXBTELEFONE8.Visible = false;
                TXBCONTATO8.Visible = false;
                CBBSEXO8.Visible = false;
                TXBEMAIL8.Visible = false;

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 744);
                BTNCANCELA.Visible = true;
                BTNCANCELA.Location = new Point(1066, 784);
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Location = new Point(411, 784);
            }
        }
        private void BTNPESQUISAR_Click(object sender, EventArgs e)
        {
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                try
                {
                    pesquisarcliente();

                    pesquisarendereco();

                    pesquisarfiscais();

                    pesquisarcontato();

                    pesquisartelefone();
                }
                catch
                {

                }
                pesquisaexcluircliente();
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                try
                {
                    TXBCEP.Visible = true;
                    TXBCEP.Enabled = true;
                    TXBNUMERO.Visible = true;
                    TXBNUMERO.Enabled = true;
                    TXBCOMPLEMENTO.Visible = true;
                    TXBCOMPLEMENTO.Enabled = true;
                    TXBINSCEST.Visible = true;
                    TXBINSCEST.Enabled = true;
                    TXBINSCMUN.Visible = true;
                    TXBINSCMUN.Enabled = true;
                    CBBTIPO1.Visible = true;
                    CBBTIPO1.Enabled = true;
                    TXBDDD1.Visible = true;
                    TXBDDD1.Enabled = true;
                    TXBTELEFONE1.Visible = true;
                    TXBTELEFONE1.Enabled = true;
                    TXBCONTATO1.Visible = true;
                    TXBCONTATO1.Enabled = true;
                    CBBSEXO1.Visible = true;
                    CBBSEXO1.Enabled = true;
                    TXBEMAIL1.Visible = true;
                    TXBEMAIL1.Enabled = true;

                    CBBNOME.Visible = true;
                    CBBNOME.Enabled = false;

                    TXBCEP.Focus();



                    pesquisarcliente();

                    pesquisarendereco();

                    pesquisarfiscais();

                    pesquisarcontato();

                    pesquisartelefone();
                }
                catch
                {

                }
                pesquisaratualizarcliente();
            }
        }

        private void TXBCEP_TextChanged_1(object sender, EventArgs e)
        {
            using (var ws = new CORREIOS.AtendeClienteClient())
            {
                try
                {
                    var ENDERECO = ws.consultaCEP(TXBCEP.Text.Trim());
                    TXBRUA.Text = ENDERECO.end.ToUpper();
                    TXBBAIRRO.Text = ENDERECO.bairro.ToUpper();
                    TXBCIDADE.Text = ENDERECO.cidade.ToUpper();
                    TXBESTADO.Text = ENDERECO.uf.ToUpper();
                }
                catch
                {

                }
            }
        }

        private void CADPAPEL_Click(object sender, EventArgs e)
        {
            this.Hide();
            PAPEIS novoFormulario = new PAPEIS();
            novoFormulario.Show();
        }
    }
}







