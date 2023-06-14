using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GRAFICA2.CLASSES;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace GRAFICA2
{
    public partial class PADRAO : Form
    {
        public PADRAO()
        {
            InitializeComponent();
        }
        private void ATUALIZACBB()  // ATUALIZA O COMBOBOX NOME NO FORMULARIO ATUALIZAR E EXCLUIR CLIENTE
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
        public void CBBEMBRANCO()
        {
            if (CBBNOME.Text == "" || TXBNOME.Text == "")
            {
                return;
            }
        }
        private void SAIR_Click(object sender, EventArgs e)  // SAIR DO APLICATIVO
        {
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA SAIR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }
        public void MENUSTRIP1()
        {
            menuStrip1.Visible = true;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;
            menuStrip7.Visible = false;
        }
        public void MENUSTRIP2()
        {
            menuStrip1.Visible = false;
            menuStrip2.Visible = true;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;
            menuStrip7.Visible = false;
        }
        public void MENUSTRIP3()
        {
            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
            menuStrip3.Visible = true;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;
            menuStrip7.Visible = false;
        }
        public void MENUSTRIP4()
        {
            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = true;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;
            menuStrip7.Visible = false;
        }
        public void MENUSTRIP5()
        {
            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = true;
            menuStrip6.Visible = false;
            menuStrip7.Visible = false;
        }
        public void MENUSTRIP6()
        {
            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = true;
            menuStrip7.Visible = false;
        }
        public void MENUSTRIP7()
        {
            menuStrip1.Visible = false;
            menuStrip2.Visible = false;
            menuStrip3.Visible = false;
            menuStrip4.Visible = false;
            menuStrip5.Visible = false;
            menuStrip6.Visible = false;
            menuStrip7.Visible = true;
        }
        public void TXBCEP_TextChanged(object sender, EventArgs e)  // PESQUISA O ENDEREÇO PELO CEP E PREENCHE OS CAMPOS
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (TXBCEP.Text == "")
                {

                    TXBCEP.Focus();

                    return;
                }
                if (TXBCEP.Text == "")
                {
                    MessageBox.Show("CEP EM BRANCO");

                    TXBCEP.Focus();

                    return;
                }
                if (TXBCEP.Text.Length != 8)
                {
                    MessageBox.Show("CEP COM TAMANHO ERRADO");

                    TXBCEP.Focus();

                    return;
                }
            }
            BUSCAENDERECO();
        }
        public void BUSCAENDERECO()
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
                    TXBRUA.Text = "NÃO ENCONTRADO - VERIFIQUE A CONEXÃO OU O CEP INFORMADO.";
                }
            }
        }

        public void LIMPARTXBCBB() // LIMPA TODOS TEXTBOX E COMBOBOX
        {
            TXBRUA.Clear();
            TXBNUMERO.Clear();
            TXBCOMPLEMENTO.Clear();
            TXBBAIRRO.Clear();
            TXBCIDADE.Clear();
            TXBESTADO.Clear();
            TXBCNPJ.Clear();
            TXBINSCREST.Clear();
            TXBINSCRMUN.Clear();
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
        public void DDDFALSE() // DDD OCULTO
        {
            TXBDDD1.Visible = false;
            TXBDDD2.Visible = false;
            TXBDDD3.Visible = false;
            TXBDDD4.Visible = false;
            TXBDDD5.Visible = false;
            TXBDDD6.Visible = false;
            TXBDDD7.Visible = false;
            TXBDDD8.Visible = false;
        }
        public void TELEFONEFALSE() // TELEFONE OCULTO
        {
            TXBTELEFONE1.Visible = false;
            TXBTELEFONE2.Visible = false;
            TXBTELEFONE3.Visible = false;
            TXBTELEFONE4.Visible = false;
            TXBTELEFONE5.Visible = false;
            TXBTELEFONE6.Visible = false;
            TXBTELEFONE7.Visible = false;
            TXBTELEFONE8.Visible = false;
        }
        public void CONTATOFALSE() // CONTATO OCULTO
        {
            TXBCONTATO1.Visible = false;
            TXBCONTATO2.Visible = false;
            TXBCONTATO3.Visible = false;
            TXBCONTATO4.Visible = false;
            TXBCONTATO5.Visible = false;
            TXBCONTATO6.Visible = false;
            TXBCONTATO7.Visible = false;
            TXBCONTATO8.Visible = false;
        }
        public void EMAILFALSE() // EMAIL OCULTO
        {
            TXBEMAIL1.Visible = false;
            TXBEMAIL2.Visible = false;
            TXBEMAIL3.Visible = false;
            TXBEMAIL4.Visible = false;
            TXBEMAIL5.Visible = false;
            TXBEMAIL6.Visible = false;
            TXBEMAIL7.Visible = false;
            TXBEMAIL8.Visible = false;
        }
        public void TIPOFALSE() // TIPO OCULTO
        {
            CBBTIPO1.Visible = false;
            CBBTIPO2.Visible = false;
            CBBTIPO3.Visible = false;
            CBBTIPO4.Visible = false;
            CBBTIPO5.Visible = false;
            CBBTIPO6.Visible = false;
            CBBTIPO7.Visible = false;
            CBBTIPO8.Visible = false;
        }
        public void SEXOFALSE() // SEXO OCULTO
        {
            CBBSEXO1.Visible = false;
            CBBSEXO2.Visible = false;
            CBBSEXO3.Visible = false;
            CBBSEXO4.Visible = false;
            CBBSEXO5.Visible = false;
            CBBSEXO6.Visible = false;
            CBBSEXO7.Visible = false;
            CBBSEXO8.Visible = false;
        }
        public void DadosDoClienteParaCadastro() // CAMPOS DO FORMULÁRIO CADASTRAR
        {
            TXBCODIGO.Visible = false;
            TXBCODIGO.Enabled = false;
            TXBCODIGO.Location = new Point(411, 300);
            TXBCODIGO.Size = new Size(68, 20);

            TXBCEP.Visible = true;
            TXBCEP.Enabled = true;
            TXBCEP.Location = new Point(411, 300);
            TXBCEP.Size = new Size(128, 20);

            TXBNOME.Visible = true;
            TXBNOME.Enabled = true;
            TXBNOME.Location = new Point(545, 300);
            TXBNOME.Size = new Size(283, 20);

            CBBNOME.Visible = false;
            CBBNOME.Location = new Point(545, 300);
            CBBNOME.Size = new Size(283, 20);

            TXBRAZAOSOCIAL.Visible = true;
            TXBRAZAOSOCIAL.Enabled = true;
            TXBRAZAOSOCIAL.Location = new Point(834, 300);
            TXBRAZAOSOCIAL.Size = new Size(676, 20);

            TXBRUA.Visible = true;
            TXBRUA.Enabled = false;
            TXBRUA.Location = new Point(411, 345);
            TXBRUA.Size = new Size(725, 20);

            TXBNUMERO.Visible = true;
            TXBNUMERO.Enabled = true;
            TXBNUMERO.Location = new Point(1144, 345);
            TXBNUMERO.Size = new Size(103, 20);

            TXBCOMPLEMENTO.Visible = true;
            TXBCOMPLEMENTO.Enabled = true;
            TXBCOMPLEMENTO.Location = new Point(1254, 345);
            TXBCOMPLEMENTO.Size = new Size(255, 20);

            TXBBAIRRO.Visible = true;
            TXBBAIRRO.Enabled = false;
            TXBBAIRRO.Location = new Point(411, 390);
            TXBBAIRRO.Size = new Size(519, 20);

            TXBCIDADE.Visible = true;
            TXBCIDADE.Enabled = false;
            TXBCIDADE.Location = new Point(939, 390);
            TXBCIDADE.Size = new Size(513, 20);

            TXBESTADO.Visible = true;
            TXBESTADO.Enabled = false;
            TXBESTADO.Location = new Point(1461, 390);
            TXBESTADO.Size = new Size(49, 20);

            TXBCNPJ.Visible = true;
            TXBCNPJ.Enabled = true;
            TXBCNPJ.Location = new Point(411, 435);
            TXBCNPJ.Size = new Size(364, 20);

            TXBINSCREST.Visible = true;
            TXBINSCREST.Enabled = true;
            TXBINSCREST.Location = new Point(783, 435);
            TXBINSCREST.Size = new Size(358, 20);

            TXBINSCRMUN.Visible = true;
            TXBINSCRMUN.Enabled = true;
            TXBINSCRMUN.Location = new Point(1149, 435);
            TXBINSCRMUN.Size = new Size(360, 20);
        }
        public void DadosDoClienteParaCadastroFalse() // CAMPOS DO FORMULÁRIO CADASTRAR
        {
            TXBCODIGO.Visible = false;
            TXBCEP.Visible = false;
            TXBNOME.Visible = false;
            CBBNOME.Visible = false;
            TXBRAZAOSOCIAL.Visible = false;
            TXBRUA.Visible = false;
            TXBNUMERO.Visible = false;
            TXBCOMPLEMENTO.Visible = false;
            TXBBAIRRO.Visible = false;
            TXBCIDADE.Visible = false;
            TXBESTADO.Visible = false;
            TXBCNPJ.Visible = false;
            TXBINSCREST.Visible = false;
            TXBINSCRMUN.Visible = false;
        }
        public void DadosDoClienteParaAtualizareExcluir() // CAMPOS DO FORMULÁRIO ATUALIZAR/EXCLUIR
        {
            TXBCODIGO.Visible = false;
            TXBCODIGO.Enabled = false;
            TXBCODIGO.Location = new Point(411, 300);
            TXBCODIGO.Size = new Size(68, 20);

            TXBCEP.Visible = true;
            TXBCEP.Enabled = false;
            TXBCEP.Location = new Point(411, 300);
            TXBCEP.Size = new Size(128, 20);

            TXBNOME.Visible = false;
            TXBNOME.Enabled = false;
            TXBNOME.Location = new Point(545, 300);
            TXBNOME.Size = new Size(283, 20);

            CBBNOME.Visible = true;
            CBBNOME.Enabled = true;
            CBBNOME.Location = new Point(545, 300);
            CBBNOME.Size = new Size(283, 20);

            TXBRAZAOSOCIAL.Visible = true;
            TXBRAZAOSOCIAL.Enabled = false;
            TXBRAZAOSOCIAL.Location = new Point(834, 300);
            TXBRAZAOSOCIAL.Size = new Size(676, 20);

            TXBRUA.Visible = true;
            TXBRUA.Enabled = false;
            TXBRUA.Location = new Point(411, 345);
            TXBRUA.Size = new Size(725, 20);

            TXBNUMERO.Visible = true;
            TXBNUMERO.Enabled = false;
            TXBNUMERO.Location = new Point(1144, 345);
            TXBNUMERO.Size = new Size(103, 20);

            TXBCOMPLEMENTO.Visible = true;
            TXBCOMPLEMENTO.Enabled = false;
            TXBCOMPLEMENTO.Location = new Point(1254, 345);
            TXBCOMPLEMENTO.Size = new Size(255, 20);

            TXBBAIRRO.Visible = true;
            TXBBAIRRO.Enabled = false;
            TXBBAIRRO.Location = new Point(411, 390);
            TXBBAIRRO.Size = new Size(519, 20);

            TXBCIDADE.Visible = true;
            TXBCIDADE.Enabled = false;
            TXBCIDADE.Location = new Point(939, 390);
            TXBCIDADE.Size = new Size(513, 20);

            TXBESTADO.Visible = true;
            TXBESTADO.Enabled = false;
            TXBESTADO.Location = new Point(1461, 390);
            TXBESTADO.Size = new Size(49, 20);

            TXBCNPJ.Visible = true;
            TXBCNPJ.Enabled = false;
            TXBCNPJ.Location = new Point(411, 435);
            TXBCNPJ.Size = new Size(364, 20);

            TXBINSCREST.Visible = true;
            TXBINSCREST.Enabled = false;
            TXBINSCREST.Location = new Point(783, 435);
            TXBINSCREST.Size = new Size(358, 20);

            TXBINSCRMUN.Visible = true;
            TXBINSCRMUN.Enabled = false;
            TXBINSCRMUN.Location = new Point(1149, 435);
            TXBINSCRMUN.Size = new Size(360, 20);
        }
        public void Asteriscos() // LABELS VISÍVEIS - ASTERISCOS
        {
            label64.Visible = true;
            label64.Location = new Point(-7, 1018);
            label65.Visible = true;
            label65.Location = new Point(686, 270);
            label66.Visible = true;
            label66.Location = new Point(910, 270);
            label67.Visible = true;
            label67.Location = new Point(1190, 314);
            label68.Visible = true;
            label68.Location = new Point(436, 405);
            label69.Visible = true;
            label69.Location = new Point(430, 270);
            label70.Visible = false;
        }
        public void AsteriscosFalse() // LABELS OCULTOS - ASTERISCOS
        {
            label65.Visible = false;
            label65.Location = new Point(574, 270);
            label66.Visible = false;
            label66.Location = new Point(910, 270);
            label67.Visible = false;
            label67.Location = new Point(1190, 314);
            label68.Visible = false;
            label68.Location = new Point(436, 405);
            label69.Visible = false;
            label69.Location = new Point(430, 270);
        }
        public void LabelsDadosDoClienteParaCadastrarAtualizarExcluir()  // LABELS VISÍVEIS NOS FORMULÁRIOS
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE" || label2.Text == "EXCLUIR CLIENTE")
            {
                label3.Text = "CEP";
                label3.Visible = true;
                label3.Location = new Point(411, 282);
                label4.Text = "NOME FANTASIA / APELIDO";
                label4.Visible = true;
                label4.Location = new Point(545, 282);
                label5.Text = "RAZÃO SOCIAL";
                label5.Visible = true;
                label5.Location = new Point(834, 282);
                label6.Text = "RUA";
                label6.Visible = true;
                label6.Location = new Point(411, 327);
                label7.Text = "NÚMERO";
                label7.Visible = true;
                label7.Location = new Point(1146, 327);
                label8.Text = "COMPLEMENTO";
                label8.Visible = true;
                label8.Location = new Point(1255, 327);
                label9.Text = "BAIRRO";
                label9.Visible = true;
                label9.Location = new Point(411, 372);
                label10.Text = "CIDADE";
                label10.Visible = true;
                label10.Location = new Point(942, 372);
                label11.Text = "ESTADO";
                label11.Visible = true;
                label11.Location = new Point(1458, 372);
                label12.Text = "CNPJ";
                label12.Visible = true;
                label12.Location = new Point(411, 417);
                label13.Text = "INSCRIÇÃO ESTADUAL";
                label13.Visible = true;
                label13.Location = new Point(782, 417);
                label14.Text = "INSCRIÇÃO MUNICIPAL";
                label14.Visible = true;
                label14.Location = new Point(1144, 417);
            }
        }
        public void LabelsDadosDoClienteParaCadastrarAtualizarExcluirFalse()  // LABELS OCULTOS NOS FORMULÁRIOS
        {
            if (label2.Text == "CADASTRAR PAPEIS")
            {
                label3.Visible = false;
                label4.Visible = false;
                label10.Visible = false;
            }
        }
        public void BotoesInicialCadastroAtualizarExcluir() // BOTÕES NO INÍCIO DOS FORMULÁRIOS
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 521);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 521);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 476);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 521);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 521);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 476);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 476);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 476);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
                BTNINSERIR.Location = new Point(411, 476);
                BTNINSERIR.Size = new Size(1099, 25);
            }
        }
        public void LabelsContato() // EXIBE AS LABELS CONTATO
        {
            label15.Text = "TIPO";
            label15.Visible = true;
            label15.Location = new Point(411, 465);
            label16.Text = "DDD";
            label16.Visible = true;
            label16.Location = new Point(497, 465);
            label17.Text = "TELEFONE";
            label17.Visible = true;
            label17.Location = new Point(583, 465);
            label18.Text = "CONTATO";
            label18.Visible = true;
            label18.Location = new Point(727, 465);
            label19.Text = "SEXO";
            label19.Visible = true;
            label19.Location = new Point(1077, 465);
            label20.Text = "EMAIL";
            label20.Visible = true;
            label20.Location = new Point(1136, 465);
        }
        public void LabelsContatoFalse() // OCULTA AS LABELS CONTATO
        {
            label15.Text = "TIPO";
            label15.Visible = false;
            label16.Text = "DDD";
            label16.Visible = false;
            label17.Text = "TELEFONE";
            label17.Visible = false;
            label18.Text = "CONTATO";
            label18.Visible = false;
            label19.Text = "SEXO";
            label19.Visible = false;
            label20.Text = "EMAIL";
            label20.Visible = false;
        }
        public void BotaoCadastroAtualizarContato1() // POSIÇÃO DOS BOTÕES NO CONTATO1
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 566);
                BTNCANCELA.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 521);
                BTNINSERIR.Size = new Size(1099, 25);

            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 566);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 566);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 521);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 521);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        public void BotaoCadastroAtualizarContato2() // POSIÇÃO DOS BOTÕES NO CONTATO2
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 611);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 611);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 566);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 611);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 611);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 566);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 566);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        public void BotaoCadastroAtualizarContato3() // POSIÇÃO DOS BOTÕES NO CONTATO3
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 656);
                BTNCANCELA.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 611);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 656);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 656);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 611);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 611);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        public void BotaoCadastroAtualizarContato4() // POSIÇÃO DOS BOTÕES NO CONTATO4
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 701);
                BTNCANCELA.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 656);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 701);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 701);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 656);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 656);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        public void BotaoCadastroAtualizarContato5() // POSIÇÃO DOS BOTÕES NO CONTATO5
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 746);
                BTNCANCELA.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 701);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 746);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 746);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 701);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 701);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        public void BotaoCadastroAtualizarContato6() // POSIÇÃO DOS BOTÕES NO CONTATO6
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 791);
                BTNCANCELA.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 746);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 791);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 791);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 746);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 746);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        public void BotaoCadastroAtualizarContato7() // POSIÇÃO DOS BOTÕES NO CONTATO7
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 836);
                BTNCANCELA.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 791);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 836);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 836);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 791);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 791);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        public void BotaoCadastroAtualizarContato8() // POSIÇÃO DOS BOTÕES NO CONTATO8
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 881);
                BTNCANCELA.Size = new Size(445, 54);

                BTNINSERIR.Visible = true;
                BTNINSERIR.Location = new Point(411, 836);
                BTNINSERIR.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "CADASTRAR";
                BTNCADAUTEXC.ForeColor = Color.Blue;
                BTNCADAUTEXC.Location = new Point(411, 881);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "ATUALIZAR";
                BTNCADAUTEXC.ForeColor = Color.Green;
                BTNCADAUTEXC.Location = new Point(411, 881);
                BTNCADAUTEXC.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELA.Visible = true;
                BTNCANCELA.Text = "CANCELAR";
                BTNCANCELA.ForeColor = Color.Black;
                BTNCANCELA.Location = new Point(1066, 836);
                BTNCANCELA.Size = new Size(445, 54);

                BTNCADAUTEXC.Visible = true;
                BTNCADAUTEXC.Text = "EXCLUIR";
                BTNCADAUTEXC.ForeColor = Color.Red;
                BTNCADAUTEXC.Location = new Point(411, 836);
                BTNCADAUTEXC.Size = new Size(445, 54);

                BTNINSERIR.Visible = false;
            }
        }
        private void PADRAO_Load(object sender, EventArgs e) // CHAMA O FORMULÁRIO LOGOTIPO
        {
            LOGOTIPO();
        }
        public void LOGOTIPO() // CRIA O FORMULÁRIO LOGOTIPO
        {
            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();

            DGV1OCULTO();

            label1.Visible = true;
            label1.Location = new Point(660, 450);
            label1.Size = new Size(612, 136);
            label1.Font = new Font("arial black", 72);

            TXBDDD1.Visible = false;
            TXBTELEFONE1.Visible = false;
            TXBCONTATO1.Visible = false;
            TXBEMAIL1.Visible = false;
            CBBNOME.Visible = false;
            CBBTIPO1.Visible = false;
            CBBTIPO1.Items.Add("CEL");
            CBBTIPO1.Items.Add("COM");
            CBBTIPO1.Items.Add("RES");
            CBBSEXO1.Visible = false;
            CBBSEXO1.Items.Add("F");
            CBBSEXO1.Items.Add("M");

            TXBCODIGO.Visible = false;
            TXBCEP.Visible = false;
            TXBNOME.Visible = false;
            CBBNOME.Visible = false;
            TXBRAZAOSOCIAL.Visible = false;
            TXBRUA.Visible = false;
            TXBNUMERO.Visible = false;
            TXBCOMPLEMENTO.Visible = false;
            TXBBAIRRO.Visible = false;
            TXBCIDADE.Visible = false;
            TXBESTADO.Visible = false;
            TXBCNPJ.Visible = false;
            TXBINSCREST.Visible = false;
            TXBINSCRMUN.Visible = false;

            TXBMATPRIMA.Visible = false;
            TXBQUANTFOLHAS.Visible = false;
            TXBESTOQMINIMO.Visible = false;
            TXBVALOR.Visible = false;
            TXBVALORFOLHA.Visible = false;
            TXBQUANTATUAL.Visible = false;
            CBBMATPRIMA.Visible = false;

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
            BTNENTRADA.Visible = false;
            BTNSAIDA.Visible = false;

            MENUSTRIP1();
        }
        public void FORMCADCLIENTE() // FORMULÁRIO DE CADASTRO
        {
            CADPAPELINVISIVEL();

            DGV1OCULTO();

            label1.Visible = false;

            label63.Visible = true;

            label2.Visible = true;
            label2.Text = "CADASTRAR CLIENTE";
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 100);
            label2.Font = new Font("arial black", 48);

            DadosDoClienteParaCadastro();
            LabelsDadosDoClienteParaCadastrarAtualizarExcluir();
            BotoesInicialCadastroAtualizarExcluir();
            Asteriscos();

            LIMPARTXBCBB();

            BTNPESQUISAR.Visible = false;

            MENUSTRIP2();

            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();

            TXBCEP.Focus();
        }


        public void FORMATUCLIENTE() // FORMULÁRIO ATUALIZAR
        {
            BUSCAENDERECO();

            CADPAPELINVISIVEL();

            DGV1OCULTO();

            label1.Visible = false;

            label63.Visible = false;
            label64.Visible = false;

            label2.Visible = true;
            label2.Text = "ATUALIZAR CLIENTE";
            label2.ForeColor = Color.Green;
            label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 100);
            label2.Font = new Font("arial black", 48);

            DadosDoClienteParaAtualizareExcluir();
            LabelsDadosDoClienteParaCadastrarAtualizarExcluir();
            BotoesInicialCadastroAtualizarExcluir();
            AsteriscosFalse();


            ATUALIZACBB();

            LIMPARTXBCBB();

            BTNPESQUISAR.Visible = true;

            MENUSTRIP3();

            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();

            CBBNOME.Focus();
        }
        public void FORMEXCCLIENTE() // FORMULÁRIO EXCLUIR
        {
            CADPAPELINVISIVEL();

            DGV1OCULTO();

            label1.Visible = false;

            label63.Visible = false;
            label64.Visible = false;

            label2.Visible = true;
            label2.Text = "EXCLUIR CLIENTE";
            label2.ForeColor = Color.Red;
            label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 100);
            label2.Font = new Font("arial black", 48);

            DadosDoClienteParaAtualizareExcluir();
            LabelsDadosDoClienteParaCadastrarAtualizarExcluir();
            BotoesInicialCadastroAtualizarExcluir();
            AsteriscosFalse();

            ATUALIZACBB();

            LIMPARTXBCBB();

            BTNPESQUISAR.Visible = true;

            BTNINSERIR.Visible = false;

            MENUSTRIP7();

            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();

            CBBNOME.Focus();
        }
        private void CADCLIENTE_Click(object sender, EventArgs e)  // CHAMA O FORMULÁRIO DE CADASTRO E OCULTA AS LABELS CONTATO
        {
            FORMCADCLIENTE();
            LabelsContatoFalse();
        }

        private void ATUCLIENTE_Click(object sender, EventArgs e)  // CHAMA O FORMULÁRIO DE ATUALIZAÇÃO E OCULTA AS LABELS CONTATO
        {
            FORMATUCLIENTE();
            LabelsContatoFalse();
        }
        private void EXCCLIENTE_Click(object sender, EventArgs e)  // CHAMA O FORMULÁRIO DE EXCLUSÃO E OCULTA AS LABELS CONTATO
        {
            FORMEXCCLIENTE();
            LabelsContatoFalse();
        }
        public void TamanhoePosicaoContato1() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO1
        {
            CBBTIPO1.Visible = true;
            CBBTIPO1.Enabled = true;
            CBBTIPO1.Location = new Point(411, 480);
            CBBTIPO1.Size = new Size(78, 20);
            TXBDDD1.Visible = true;
            TXBDDD1.Enabled = true;
            TXBDDD1.Location = new Point(497, 480);
            TXBDDD1.Size = new Size(78, 20);
            TXBTELEFONE1.Visible = true;
            TXBTELEFONE1.Enabled = true;
            TXBTELEFONE1.Location = new Point(583, 480);
            TXBTELEFONE1.Size = new Size(136, 20);
            TXBCONTATO1.Visible = true;
            TXBCONTATO1.Enabled = true;
            TXBCONTATO1.Location = new Point(727, 480);
            TXBCONTATO1.Size = new Size(342, 20);
            CBBSEXO1.Visible = true;
            CBBSEXO1.Enabled = true;
            CBBSEXO1.Location = new Point(1077, 480);
            CBBSEXO1.Size = new Size(50, 20);
            TXBEMAIL1.Visible = true;
            TXBEMAIL1.Enabled = true;
            TXBEMAIL1.Location = new Point(1136, 480);
            TXBEMAIL1.Size = new Size(373, 20);

            CBBTIPO1.Focus();
        }
        public void TamanhoePosicaoContato2() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO2
        {
            CBBTIPO2.Visible = true;
            CBBTIPO2.Enabled = true;
            CBBTIPO2.Location = new Point(411, 525);
            CBBTIPO2.Size = new Size(78, 20);
            TXBDDD2.Visible = true;
            TXBDDD2.Enabled = true;
            TXBDDD2.Location = new Point(497, 525);
            TXBDDD2.Size = new Size(78, 20);
            TXBTELEFONE2.Visible = true;
            TXBTELEFONE2.Enabled = true;
            TXBTELEFONE2.Location = new Point(583, 525);
            TXBTELEFONE2.Size = new Size(136, 20);
            TXBCONTATO2.Visible = true;
            TXBCONTATO2.Enabled = true;
            TXBCONTATO2.Location = new Point(727, 525);
            TXBCONTATO2.Size = new Size(342, 20);
            CBBSEXO2.Visible = true;
            CBBSEXO2.Enabled = true;
            CBBSEXO2.Location = new Point(1077, 525);
            CBBSEXO2.Size = new Size(50, 20);
            TXBEMAIL2.Visible = true;
            TXBEMAIL2.Enabled = true;
            TXBEMAIL2.Location = new Point(1136, 525);
            TXBEMAIL2.Size = new Size(373, 20);

            CBBTIPO2.Focus();
        }
        public void TamanhoePosicaoContato3() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO3
        {
            CBBTIPO3.Visible = true;
            CBBTIPO3.Enabled = true;
            CBBTIPO3.Location = new Point(411, 570);
            CBBTIPO3.Size = new Size(78, 20);
            TXBDDD3.Visible = true;
            TXBDDD3.Enabled = true;
            TXBDDD3.Location = new Point(497, 570);
            TXBDDD3.Size = new Size(78, 20);
            TXBTELEFONE3.Visible = true;
            TXBTELEFONE3.Enabled = true;
            TXBTELEFONE3.Location = new Point(583, 570);
            TXBTELEFONE3.Size = new Size(136, 20);
            TXBCONTATO3.Visible = true;
            TXBCONTATO3.Enabled = true;
            TXBCONTATO3.Location = new Point(727, 570);
            TXBCONTATO3.Size = new Size(342, 20);
            CBBSEXO3.Visible = true;
            CBBSEXO3.Enabled = true;
            CBBSEXO3.Location = new Point(1077, 570);
            CBBSEXO3.Size = new Size(50, 20);
            TXBEMAIL3.Visible = true;
            TXBEMAIL3.Enabled = true;
            TXBEMAIL3.Location = new Point(1136, 570);
            TXBEMAIL3.Size = new Size(373, 20);

            CBBTIPO3.Focus();
        }
        public void TamanhoePosicaoContato4() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO4
        {
            CBBTIPO4.Visible = true;
            CBBTIPO4.Enabled = true;
            CBBTIPO4.Location = new Point(411, 615);
            CBBTIPO4.Size = new Size(78, 20);
            TXBDDD4.Visible = true;
            TXBDDD4.Enabled = true;
            TXBDDD4.Location = new Point(497, 615);
            TXBDDD4.Size = new Size(78, 20);
            TXBTELEFONE4.Visible = true;
            TXBTELEFONE4.Enabled = true;
            TXBTELEFONE4.Location = new Point(583, 615);
            TXBTELEFONE4.Size = new Size(136, 20);
            TXBCONTATO4.Visible = true;
            TXBCONTATO4.Enabled = true;
            TXBCONTATO4.Location = new Point(727, 615);
            TXBCONTATO4.Size = new Size(342, 20);
            CBBSEXO4.Visible = true;
            CBBSEXO4.Enabled = true;
            CBBSEXO4.Location = new Point(1077, 615);
            CBBSEXO4.Size = new Size(50, 20);
            TXBEMAIL4.Visible = true;
            TXBEMAIL4.Enabled = true;
            TXBEMAIL4.Location = new Point(1136, 615);
            TXBEMAIL4.Size = new Size(373, 20);

            CBBTIPO4.Focus();
        }
        public void TamanhoePosicaoContato5() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO5
        {
            CBBTIPO5.Visible = true;
            CBBTIPO5.Enabled = true;
            CBBTIPO5.Location = new Point(411, 660);
            CBBTIPO5.Size = new Size(78, 20);
            TXBDDD5.Visible = true;
            TXBDDD5.Enabled = true;
            TXBDDD5.Location = new Point(497, 660);
            TXBDDD5.Size = new Size(78, 20);
            TXBTELEFONE5.Visible = true;
            TXBTELEFONE5.Enabled = true;
            TXBTELEFONE5.Location = new Point(583, 660);
            TXBTELEFONE5.Size = new Size(136, 20);
            TXBCONTATO5.Visible = true;
            TXBCONTATO5.Enabled = true;
            TXBCONTATO5.Location = new Point(727, 660);
            TXBCONTATO5.Size = new Size(342, 20);
            CBBSEXO5.Visible = true;
            CBBSEXO5.Enabled = true;
            CBBSEXO5.Location = new Point(1077, 660);
            CBBSEXO5.Size = new Size(50, 20);
            TXBEMAIL5.Visible = true;
            TXBEMAIL5.Enabled = true;
            TXBEMAIL5.Location = new Point(1136, 660);
            TXBEMAIL5.Size = new Size(373, 20);

            CBBTIPO5.Focus();
        }
        public void TamanhoePosicaoContato6() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO6
        {
            CBBTIPO6.Visible = true;
            CBBTIPO6.Enabled = true;
            CBBTIPO6.Location = new Point(411, 705);
            CBBTIPO6.Size = new Size(78, 20);
            TXBDDD6.Visible = true;
            TXBDDD6.Enabled = true;
            TXBDDD6.Location = new Point(497, 705);
            TXBDDD6.Size = new Size(78, 20);
            TXBTELEFONE6.Visible = true;
            TXBTELEFONE6.Enabled = true;
            TXBTELEFONE6.Location = new Point(583, 705);
            TXBTELEFONE6.Size = new Size(136, 20);
            TXBCONTATO6.Visible = true;
            TXBCONTATO6.Enabled = true;
            TXBCONTATO6.Location = new Point(727, 705);
            TXBCONTATO6.Size = new Size(342, 20);
            CBBSEXO6.Visible = true;
            CBBSEXO6.Enabled = true;
            CBBSEXO6.Location = new Point(1077, 705);
            CBBSEXO6.Size = new Size(50, 20);
            TXBEMAIL6.Visible = true;
            TXBEMAIL6.Enabled = true;
            TXBEMAIL6.Location = new Point(1136, 705);
            TXBEMAIL6.Size = new Size(373, 20);

            CBBTIPO6.Focus();
        }
        public void TamanhoePosicaoContato7() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO7
        {

            CBBTIPO7.Visible = true;
            CBBTIPO7.Enabled = true;
            CBBTIPO7.Location = new Point(411, 750);
            CBBTIPO7.Size = new Size(78, 20);
            TXBDDD7.Visible = true;
            TXBDDD7.Enabled = true;
            TXBDDD7.Location = new Point(497, 750);
            TXBDDD7.Size = new Size(78, 20);
            TXBTELEFONE7.Visible = true;
            TXBTELEFONE7.Enabled = true;
            TXBTELEFONE7.Location = new Point(583, 750);
            TXBTELEFONE7.Size = new Size(136, 20);
            TXBCONTATO7.Visible = true;
            TXBCONTATO7.Enabled = true;
            TXBCONTATO7.Location = new Point(727, 750);
            TXBCONTATO7.Size = new Size(342, 20);
            CBBSEXO7.Visible = true;
            CBBSEXO7.Enabled = true;
            CBBSEXO7.Location = new Point(1077, 750);
            CBBSEXO7.Size = new Size(50, 20);
            TXBEMAIL7.Visible = true;
            TXBEMAIL7.Enabled = true;
            TXBEMAIL7.Location = new Point(1136, 750);
            TXBEMAIL7.Size = new Size(373, 20);

            CBBTIPO7.Focus();
        }
        public void TamanhoePosicaoContato8() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO8
        {
            CBBTIPO8.Visible = true;
            CBBTIPO8.Enabled = true;
            CBBTIPO8.Location = new Point(411, 795);
            CBBTIPO8.Size = new Size(78, 20);
            TXBDDD8.Visible = true;
            TXBDDD8.Enabled = true;
            TXBDDD8.Location = new Point(497, 795);
            TXBDDD8.Size = new Size(78, 20);
            TXBTELEFONE8.Visible = true;
            TXBTELEFONE8.Enabled = true;
            TXBTELEFONE8.Location = new Point(583, 795);
            TXBTELEFONE8.Size = new Size(136, 20);
            TXBCONTATO8.Visible = true;
            TXBCONTATO8.Enabled = true;
            TXBCONTATO8.Location = new Point(727, 795);
            TXBCONTATO8.Size = new Size(342, 20);
            CBBSEXO8.Visible = true;
            CBBSEXO8.Enabled = true;
            CBBSEXO8.Location = new Point(1077, 795);
            CBBSEXO8.Size = new Size(50, 20);
            TXBEMAIL8.Visible = true;
            TXBEMAIL8.Enabled = true;
            TXBEMAIL8.Location = new Point(1136, 795);
            TXBEMAIL8.Size = new Size(373, 20);

            CBBTIPO8.Focus();
        }
        public void TamanhoePosicaoContato1False() // DESABILITA CAMPOS CONTATO1
        {
            CBBTIPO1.Visible = true;
            CBBTIPO1.Enabled = false;
            CBBTIPO1.Location = new Point(411, 480);
            CBBTIPO1.Size = new Size(78, 20);
            TXBDDD1.Visible = true;
            TXBDDD1.Enabled = false;
            TXBDDD1.Location = new Point(497, 480);
            TXBDDD1.Size = new Size(78, 20);
            TXBTELEFONE1.Visible = true;
            TXBTELEFONE1.Enabled = false;
            TXBTELEFONE1.Location = new Point(583, 480);
            TXBTELEFONE1.Size = new Size(136, 20);
            TXBCONTATO1.Visible = true;
            TXBCONTATO1.Enabled = false;
            TXBCONTATO1.Location = new Point(727, 480);
            TXBCONTATO1.Size = new Size(342, 20);
            CBBSEXO1.Visible = true;
            CBBSEXO1.Enabled = false;
            CBBSEXO1.Location = new Point(1077, 480);
            CBBSEXO1.Size = new Size(50, 20);
            TXBEMAIL1.Visible = true;
            TXBEMAIL1.Enabled = false;
            TXBEMAIL1.Location = new Point(1136, 480);
            TXBEMAIL1.Size = new Size(373, 20);

            CBBTIPO1.Focus();
        }
        public void TamanhoePosicaoContato2False() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO2
        {
            CBBTIPO2.Visible = true;
            CBBTIPO2.Enabled = false;
            CBBTIPO2.Location = new Point(411, 525);
            CBBTIPO2.Size = new Size(78, 20);
            TXBDDD2.Visible = true;
            TXBDDD2.Enabled = false;
            TXBDDD2.Location = new Point(497, 525);
            TXBDDD2.Size = new Size(78, 20);
            TXBTELEFONE2.Visible = true;
            TXBTELEFONE2.Enabled = false;
            TXBTELEFONE2.Location = new Point(583, 525);
            TXBTELEFONE2.Size = new Size(136, 20);
            TXBCONTATO2.Visible = true;
            TXBCONTATO2.Enabled = false;
            TXBCONTATO2.Location = new Point(727, 525);
            TXBCONTATO2.Size = new Size(342, 20);
            CBBSEXO2.Visible = true;
            CBBSEXO2.Enabled = false;
            CBBSEXO2.Location = new Point(1077, 525);
            CBBSEXO2.Size = new Size(50, 20);
            TXBEMAIL2.Visible = true;
            TXBEMAIL2.Enabled = false;
            TXBEMAIL2.Location = new Point(1136, 525);
            TXBEMAIL2.Size = new Size(373, 20);

            CBBTIPO2.Focus();
        }
        public void TamanhoePosicaoContato3False() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO3
        {
            CBBTIPO3.Visible = true;
            CBBTIPO3.Enabled = false;
            CBBTIPO3.Location = new Point(411, 570);
            CBBTIPO3.Size = new Size(78, 20);
            TXBDDD3.Visible = true;
            TXBDDD3.Enabled = false;
            TXBDDD3.Location = new Point(497, 570);
            TXBDDD3.Size = new Size(78, 20);
            TXBTELEFONE3.Visible = true;
            TXBTELEFONE3.Enabled = false;
            TXBTELEFONE3.Location = new Point(583, 570);
            TXBTELEFONE3.Size = new Size(136, 20);
            TXBCONTATO3.Visible = true;
            TXBCONTATO3.Enabled = false;
            TXBCONTATO3.Location = new Point(727, 570);
            TXBCONTATO3.Size = new Size(342, 20);
            CBBSEXO3.Visible = true;
            CBBSEXO3.Enabled = false;
            CBBSEXO3.Location = new Point(1077, 570);
            CBBSEXO3.Size = new Size(50, 20);
            TXBEMAIL3.Visible = true;
            TXBEMAIL3.Enabled = false;
            TXBEMAIL3.Location = new Point(1136, 570);
            TXBEMAIL3.Size = new Size(373, 20);

            CBBTIPO3.Focus();
        }
        public void TamanhoePosicaoContato4False() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO4
        {
            CBBTIPO4.Visible = true;
            CBBTIPO4.Enabled = false;
            CBBTIPO4.Location = new Point(411, 615);
            CBBTIPO4.Size = new Size(78, 20);
            TXBDDD4.Visible = true;
            TXBDDD4.Enabled = false;
            TXBDDD4.Location = new Point(497, 615);
            TXBDDD4.Size = new Size(78, 20);
            TXBTELEFONE4.Visible = true;
            TXBTELEFONE4.Enabled = false;
            TXBTELEFONE4.Location = new Point(583, 615);
            TXBTELEFONE4.Size = new Size(136, 20);
            TXBCONTATO4.Visible = true;
            TXBCONTATO4.Enabled = false;
            TXBCONTATO4.Location = new Point(727, 615);
            TXBCONTATO4.Size = new Size(342, 20);
            CBBSEXO4.Visible = true;
            CBBSEXO4.Enabled = false;
            CBBSEXO4.Location = new Point(1077, 615);
            CBBSEXO4.Size = new Size(50, 20);
            TXBEMAIL4.Visible = true;
            TXBEMAIL4.Enabled = false;
            TXBEMAIL4.Location = new Point(1136, 615);
            TXBEMAIL4.Size = new Size(373, 20);

            CBBTIPO4.Focus();
        }
        public void TamanhoePosicaoContato5False() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO5
        {
            CBBTIPO5.Visible = true;
            CBBTIPO5.Enabled = false;
            CBBTIPO5.Location = new Point(411, 660);
            CBBTIPO5.Size = new Size(78, 20);
            TXBDDD5.Visible = true;
            TXBDDD5.Enabled = false;
            TXBDDD5.Location = new Point(497, 660);
            TXBDDD5.Size = new Size(78, 20);
            TXBTELEFONE5.Visible = true;
            TXBTELEFONE5.Enabled = false;
            TXBTELEFONE5.Location = new Point(583, 660);
            TXBTELEFONE5.Size = new Size(136, 20);
            TXBCONTATO5.Visible = true;
            TXBCONTATO5.Enabled = false;
            TXBCONTATO5.Location = new Point(727, 660);
            TXBCONTATO5.Size = new Size(342, 20);
            CBBSEXO5.Visible = true;
            CBBSEXO5.Enabled = false;
            CBBSEXO5.Location = new Point(1077, 660);
            CBBSEXO5.Size = new Size(50, 20);
            TXBEMAIL5.Visible = true;
            TXBEMAIL5.Enabled = false;
            TXBEMAIL5.Location = new Point(1136, 660);
            TXBEMAIL5.Size = new Size(373, 20);

            CBBTIPO5.Focus();
        }
        public void TamanhoePosicaoContato6False() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO6
        {
            CBBTIPO6.Visible = true;
            CBBTIPO6.Enabled = false;
            CBBTIPO6.Location = new Point(411, 705);
            CBBTIPO6.Size = new Size(78, 20);
            TXBDDD6.Visible = true;
            TXBDDD6.Enabled = false;
            TXBDDD6.Location = new Point(497, 705);
            TXBDDD6.Size = new Size(78, 20);
            TXBTELEFONE6.Visible = true;
            TXBTELEFONE6.Enabled = false;
            TXBTELEFONE6.Location = new Point(583, 705);
            TXBTELEFONE6.Size = new Size(136, 20);
            TXBCONTATO6.Visible = true;
            TXBCONTATO6.Enabled = false;
            TXBCONTATO6.Location = new Point(727, 705);
            TXBCONTATO6.Size = new Size(342, 20);
            CBBSEXO6.Visible = true;
            CBBSEXO6.Enabled = false;
            CBBSEXO6.Location = new Point(1077, 705);
            CBBSEXO6.Size = new Size(50, 20);
            TXBEMAIL6.Visible = true;
            TXBEMAIL6.Enabled = false;
            TXBEMAIL6.Location = new Point(1136, 705);
            TXBEMAIL6.Size = new Size(373, 20);

            CBBTIPO6.Focus();
        }
        public void TamanhoePosicaoContato7False() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO7
        {
            CBBTIPO7.Visible = true;
            CBBTIPO7.Enabled = false;
            CBBTIPO7.Location = new Point(411, 750);
            CBBTIPO7.Size = new Size(78, 20);
            TXBDDD7.Visible = true;
            TXBDDD7.Enabled = false;
            TXBDDD7.Location = new Point(497, 750);
            TXBDDD7.Size = new Size(78, 20);
            TXBTELEFONE7.Visible = true;
            TXBTELEFONE7.Enabled = false;
            TXBTELEFONE7.Location = new Point(583, 750);
            TXBTELEFONE7.Size = new Size(136, 20);
            TXBCONTATO7.Visible = true;
            TXBCONTATO7.Enabled = false;
            TXBCONTATO7.Location = new Point(727, 750);
            TXBCONTATO7.Size = new Size(342, 20);
            CBBSEXO7.Visible = true;
            CBBSEXO7.Enabled = false;
            CBBSEXO7.Location = new Point(1077, 750);
            CBBSEXO7.Size = new Size(50, 20);
            TXBEMAIL7.Visible = true;
            TXBEMAIL7.Enabled = false;
            TXBEMAIL7.Location = new Point(1136, 750);
            TXBEMAIL7.Size = new Size(373, 20);

            CBBTIPO7.Focus();
        }
        public void TamanhoePosicaoContato8False() // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO8
        {
            CBBTIPO8.Visible = true;
            CBBTIPO8.Enabled = false;
            CBBTIPO8.Location = new Point(411, 795);
            CBBTIPO8.Size = new Size(78, 20);
            TXBDDD8.Visible = true;
            TXBDDD8.Enabled = false;
            TXBDDD8.Location = new Point(497, 795);
            TXBDDD8.Size = new Size(78, 20);
            TXBTELEFONE8.Visible = true;
            TXBTELEFONE8.Enabled = false;
            TXBTELEFONE8.Location = new Point(583, 795);
            TXBTELEFONE8.Size = new Size(136, 20);
            TXBCONTATO8.Visible = true;
            TXBCONTATO8.Enabled = false;
            TXBCONTATO8.Location = new Point(727, 795);
            TXBCONTATO8.Size = new Size(342, 20);
            CBBSEXO8.Visible = true;
            CBBSEXO8.Enabled = false;
            CBBSEXO8.Location = new Point(1077, 795);
            CBBSEXO8.Size = new Size(50, 20);
            TXBEMAIL8.Visible = true;
            TXBEMAIL8.Enabled = false;
            TXBEMAIL8.Location = new Point(1136, 795);
            TXBEMAIL8.Size = new Size(373, 20);

            CBBTIPO8.Focus();
        }
        private void BTNINSERIR_Click(object sender, EventArgs e) // BOTÃO INSERIR CADASTRAR/ATUALIZAR
        {
            if (TXBNOME.Text != "" || CBBNOME.Text != "")
            {
                LabelsContato();
                TamanhoePosicaoContato1();
                BotaoCadastroAtualizarContato1();


                if (TXBCONTATO1.Text != "")
                {
                    TamanhoePosicaoContato2();
                    BotaoCadastroAtualizarContato2();
                }
                if (TXBCONTATO2.Text != "")
                {
                    TamanhoePosicaoContato3();
                    BotaoCadastroAtualizarContato3();
                }
                if (TXBCONTATO3.Text != "")
                {
                    TamanhoePosicaoContato4();
                    BotaoCadastroAtualizarContato4();
                }
                if (TXBCONTATO4.Text != "")
                {
                    TamanhoePosicaoContato5();
                    BotaoCadastroAtualizarContato5();
                }
                if (TXBCONTATO5.Text != "")
                {
                    TamanhoePosicaoContato6();
                    BotaoCadastroAtualizarContato6();
                }
                if (TXBCONTATO6.Text != "")
                {
                    TamanhoePosicaoContato7();
                    BotaoCadastroAtualizarContato7();
                }
                if (TXBCONTATO7.Text != "")
                {
                    TamanhoePosicaoContato8();
                    BotaoCadastroAtualizarContato8();
                }
            }
        }
        private void BTNCANCELA_Click(object sender, EventArgs e) // POSIÇÃO BOTÃO CANCELAR - CADASTRAR/ATUALIZAR/EXCLUIR
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                CBBEMBRANCO();
                LIMPARTXBCBB();
                BotoesInicialCadastroAtualizarExcluir();
                LabelsContatoFalse();
                DDDFALSE();
                TELEFONEFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                TIPOFALSE();
                SEXOFALSE();
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                CBBEMBRANCO();
                LIMPARTXBCBB();
                BotoesInicialCadastroAtualizarExcluir();
                LabelsContatoFalse();
                DDDFALSE();
                TELEFONEFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                TIPOFALSE();
                SEXOFALSE();

                TXBCEP.Visible = true;
                TXBCEP.Enabled = false;

                CBBNOME.Visible = true;
                CBBNOME.Enabled = true;
                CBBNOME.Focus();
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                CBBEMBRANCO();
                LIMPARTXBCBB();
                BotoesInicialCadastroAtualizarExcluir();
                LabelsContatoFalse();
                DDDFALSE();
                TELEFONEFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                TIPOFALSE();
                SEXOFALSE();

                TXBCEP.Visible = true;
                TXBCEP.Enabled = false;

                CBBNOME.Visible = true;
                CBBNOME.Enabled = true;
                CBBNOME.Focus();
            }
        }
        public void BTNCADAUTEXC_Click(object sender, EventArgs e) // BOTÃO CADASTRAR/ATUALIZAR/EXCLUIR
        {
            CLIENTES NOME, RAZAOSOCIAL;
            NOME = new CLIENTES();
            RAZAOSOCIAL = new CLIENTES();

            ENDERECO RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP;
            RUA = new ENDERECO();
            NUMERO = new ENDERECO();
            COMPLEMENTO = new ENDERECO();
            BAIRRO = new ENDERECO();
            CIDADE = new ENDERECO();
            ESTADO = new ENDERECO();
            CEP = new ENDERECO();

            FISCAIS CNPJ, INSCREST, INSCRMUN;
            CNPJ = new FISCAIS();
            INSCREST = new FISCAIS();
            INSCRMUN = new FISCAIS();

            CONTATO CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3, CONTATO4, SEXO4, EMAIL4, CONTATO5, SEXO5, EMAIL5, CONTATO6, SEXO6, EMAIL6, CONTATO7, SEXO7, EMAIL7, CONTATO8, SEXO8, EMAIL8;
            CONTATO1 = new CONTATO();
            SEXO1 = new CONTATO();
            EMAIL1 = new CONTATO();
            CONTATO2 = new CONTATO();
            SEXO2 = new CONTATO();
            EMAIL2 = new CONTATO();
            CONTATO3 = new CONTATO();
            SEXO3 = new CONTATO();
            EMAIL3 = new CONTATO();
            CONTATO4 = new CONTATO();
            SEXO4 = new CONTATO();
            EMAIL4 = new CONTATO();
            CONTATO5 = new CONTATO();
            SEXO5 = new CONTATO();
            EMAIL5 = new CONTATO();
            CONTATO6 = new CONTATO();
            SEXO6 = new CONTATO();
            EMAIL6 = new CONTATO();
            CONTATO7 = new CONTATO();
            SEXO7 = new CONTATO();
            EMAIL7 = new CONTATO();
            CONTATO8 = new CONTATO();
            SEXO8 = new CONTATO();
            EMAIL8 = new CONTATO();

            TELEFONE TIPO1, DDD1, TELEFONE1, TIPO2, DDD2, TELEFONE2, TIPO3, DDD3, TELEFONE3, TIPO4, DDD4, TELEFONE4, TIPO5, DDD5, TELEFONE5, TIPO6, DDD6, TELEFONE6, TIPO7, DDD7, TELEFONE7, TIPO8, DDD8, TELEFONE8;
            TIPO1 = new TELEFONE();
            DDD1 = new TELEFONE();
            TELEFONE1 = new TELEFONE();
            TIPO2 = new TELEFONE();
            DDD2 = new TELEFONE();
            TELEFONE2 = new TELEFONE();
            TIPO3 = new TELEFONE();
            DDD3 = new TELEFONE();
            TELEFONE3 = new TELEFONE();
            TIPO4 = new TELEFONE();
            DDD4 = new TELEFONE();
            TELEFONE4 = new TELEFONE();
            TIPO5 = new TELEFONE();
            DDD5 = new TELEFONE();
            TELEFONE5 = new TELEFONE();
            TIPO6 = new TELEFONE();
            DDD6 = new TELEFONE();
            TELEFONE6 = new TELEFONE();
            TIPO7 = new TELEFONE();
            DDD7 = new TELEFONE();
            TELEFONE7 = new TELEFONE();
            TIPO8 = new TELEFONE();
            DDD8 = new TELEFONE();
            TELEFONE8 = new TELEFONE();

            if (BTNCADAUTEXC.Text == "CADASTRAR") // CADASTRO - BOTÃO CADASTRAR
            {
                try
                {
                    MySqlConnection CONEXAOCADASTRARCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARCLIENTE.Open();
                    MySqlCommand COMANDOCADASTRARCLIENTE = new MySqlCommand("insert into CLIENTE(NOME, RAZAOSOCIAL) values(?,?)", CONEXAOCADASTRARCLIENTE);
                    COMANDOCADASTRARCLIENTE.Parameters.Add(NOME.NOME, MySqlDbType.VarChar, 50).Value = TXBNOME.Text;
                    COMANDOCADASTRARCLIENTE.Parameters.Add(RAZAOSOCIAL.RAZAOSOCIAL, MySqlDbType.VarChar, 100).Value = TXBRAZAOSOCIAL.Text;
                    COMANDOCADASTRARCLIENTE.ExecuteNonQuery();
                    CONEXAOCADASTRARCLIENTE.Close();

                    //GRAFICA2
                    MySqlConnection CONEXAOCADASTRARCLIENTE2 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");
                    CONEXAOCADASTRARCLIENTE2.Open();
                    MySqlCommand COMANDOCADASTRARCLIENTE2 = new MySqlCommand("insert into CLIENTE(NOME, RAZAOSOCIAL) values(?,?)", CONEXAOCADASTRARCLIENTE2);
                    COMANDOCADASTRARCLIENTE2.Parameters.Add(NOME.NOME, MySqlDbType.VarChar, 50).Value = TXBNOME.Text;
                    COMANDOCADASTRARCLIENTE2.Parameters.Add(RAZAOSOCIAL.RAZAOSOCIAL, MySqlDbType.VarChar, 100).Value = TXBRAZAOSOCIAL.Text;
                    COMANDOCADASTRARCLIENTE2.ExecuteNonQuery();
                    CONEXAOCADASTRARCLIENTE2.Close();

                    MySqlConnection CONEXAOCADASTRARFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARFISCAIS.Open();
                    MySqlCommand COMANDOCADASTRARFISCAIS = new MySqlCommand("insert into FISCAIS(CNPJ, INSCREST, INSCRMUN) values(?,?,?)", CONEXAOCADASTRARFISCAIS);
                    COMANDOCADASTRARFISCAIS.Parameters.Add(CNPJ.CNPJ, MySqlDbType.VarChar, 18).Value = TXBCNPJ.Text;
                    COMANDOCADASTRARFISCAIS.Parameters.Add(INSCREST.INSCREST, MySqlDbType.VarChar, 30).Value = TXBINSCREST.Text;
                    COMANDOCADASTRARFISCAIS.Parameters.Add(INSCRMUN.INSCRMUN, MySqlDbType.VarChar, 30).Value = TXBINSCRMUN.Text;
                    COMANDOCADASTRARFISCAIS.ExecuteNonQuery();
                    CONEXAOCADASTRARFISCAIS.Close();

                    //GRAFICA2
                    MySqlConnection CONEXAOCADASTRARFISCAIS2 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");
                    CONEXAOCADASTRARFISCAIS2.Open();
                    MySqlCommand COMANDOCADASTRARFISCAIS2 = new MySqlCommand("insert into FISCAIS(CNPJ) values(?)", CONEXAOCADASTRARFISCAIS2);
                    COMANDOCADASTRARFISCAIS2.Parameters.Add(CNPJ.CNPJ, MySqlDbType.VarChar, 18).Value = TXBCNPJ.Text;
                    COMANDOCADASTRARFISCAIS2.ExecuteNonQuery();
                    CONEXAOCADASTRARFISCAIS2.Close();

                    MySqlConnection CONEXAOCADASTRARENDERECO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARENDERECO.Open();
                    MySqlCommand COMANDOCADASTRARENDERECO = new MySqlCommand("insert into ENDERECO(RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP) values(?,?,?,?,?,?,?)", CONEXAOCADASTRARENDERECO);
                    COMANDOCADASTRARENDERECO.Parameters.Add(RUA.RUA, MySqlDbType.VarChar, 150).Value = TXBRUA.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add(NUMERO.NUMERO, MySqlDbType.VarChar, 10).Value = TXBNUMERO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add(COMPLEMENTO.COMPLEMENTO, MySqlDbType.VarChar, 50).Value = TXBCOMPLEMENTO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add(BAIRRO.BAIRRO, MySqlDbType.VarChar, 50).Value = TXBBAIRRO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add(CIDADE.CIDADE, MySqlDbType.VarChar, 50).Value = TXBCIDADE.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add(ESTADO.ESTADO, MySqlDbType.VarChar, 2).Value = TXBESTADO.Text;
                    COMANDOCADASTRARENDERECO.Parameters.Add(CEP.CEP, MySqlDbType.VarChar, 9).Value = TXBCEP.Text;
                    COMANDOCADASTRARENDERECO.ExecuteNonQuery();
                    CONEXAOCADASTRARENDERECO.Close();

                    MySqlConnection CONEXAOCADASTRARCONTATO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARCONTATO.Open();
                    MySqlCommand COMANDOCADASTRARCONTATO = new MySqlCommand("insert into CONTATO(CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3, CONTATO4, SEXO4, EMAIL4, CONTATO5, SEXO5, EMAIL5, CONTATO6, SEXO6, EMAIL6, CONTATO7, SEXO7, EMAIL7, CONTATO8, SEXO8, EMAIL8) values( ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", CONEXAOCADASTRARCONTATO);
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO1.CONTATO1, MySqlDbType.VarChar, 100).Value = TXBCONTATO1.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO1.SEXO1, MySqlDbType.VarChar, 1).Value = CBBSEXO1.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL1.EMAIL1, MySqlDbType.VarChar, 100).Value = TXBEMAIL1.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO2.CONTATO2, MySqlDbType.VarChar, 100).Value = TXBCONTATO2.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO2.SEXO2, MySqlDbType.VarChar, 1).Value = CBBSEXO2.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL2.EMAIL2, MySqlDbType.VarChar, 100).Value = TXBEMAIL2.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO3.CONTATO3, MySqlDbType.VarChar, 100).Value = TXBCONTATO3.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO3.SEXO3, MySqlDbType.VarChar, 1).Value = CBBSEXO3.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL3.EMAIL3, MySqlDbType.VarChar, 100).Value = TXBEMAIL3.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO4.CONTATO4, MySqlDbType.VarChar, 100).Value = TXBCONTATO4.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO4.SEXO4, MySqlDbType.VarChar, 1).Value = CBBSEXO4.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL4.EMAIL4, MySqlDbType.VarChar, 100).Value = TXBEMAIL4.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO5.CONTATO5, MySqlDbType.VarChar, 100).Value = TXBCONTATO5.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO5.SEXO5, MySqlDbType.VarChar, 1).Value = CBBSEXO5.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL5.EMAIL5, MySqlDbType.VarChar, 100).Value = TXBEMAIL5.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO6.CONTATO6, MySqlDbType.VarChar, 100).Value = TXBCONTATO6.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO6.SEXO6, MySqlDbType.VarChar, 1).Value = CBBSEXO6.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL6.EMAIL6, MySqlDbType.VarChar, 100).Value = TXBEMAIL6.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO7.CONTATO7, MySqlDbType.VarChar, 100).Value = TXBCONTATO7.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO7.SEXO7, MySqlDbType.VarChar, 1).Value = CBBSEXO7.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL7.EMAIL7, MySqlDbType.VarChar, 100).Value = TXBEMAIL7.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(CONTATO8.CONTATO8, MySqlDbType.VarChar, 100).Value = TXBCONTATO8.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(SEXO8.SEXO8, MySqlDbType.VarChar, 1).Value = CBBSEXO8.Text;
                    COMANDOCADASTRARCONTATO.Parameters.Add(EMAIL8.EMAIL8, MySqlDbType.VarChar, 100).Value = TXBEMAIL8.Text;
                    COMANDOCADASTRARCONTATO.ExecuteNonQuery();
                    CONEXAOCADASTRARCONTATO.Close();

                    MySqlConnection CONEXAOCADASTRARTELEFONE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARTELEFONE.Open();
                    MySqlCommand COMANDOCADASTRARTELEFONE = new MySqlCommand("insert into TELEFONE(TIPO1, DDD1, TELEFONE1, TIPO2, DDD2, TELEFONE2, TIPO3, DDD3, TELEFONE3, TIPO4, DDD4, TELEFONE4, TIPO5, DDD5, TELEFONE5, TIPO6, DDD6, TELEFONE6, TIPO7, DDD7, TELEFONE7,TIPO8, DDD8, TELEFONE8) values(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", CONEXAOCADASTRARTELEFONE);
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO1.TIPO1, MySqlDbType.VarChar, 6).Value = CBBTIPO1.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD1.DDD1, MySqlDbType.VarChar, 4).Value = TXBDDD1.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE1.TELEFONE1, MySqlDbType.VarChar, 10).Value = TXBTELEFONE1.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO2.TIPO2, MySqlDbType.VarChar, 6).Value = CBBTIPO2.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD2.DDD2, MySqlDbType.VarChar, 4).Value = TXBDDD2.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE2.TELEFONE2, MySqlDbType.VarChar, 10).Value = TXBTELEFONE2.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO3.TIPO3, MySqlDbType.VarChar, 6).Value = CBBTIPO3.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD3.DDD3, MySqlDbType.VarChar, 4).Value = TXBDDD3.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE3.TELEFONE3, MySqlDbType.VarChar, 10).Value = TXBTELEFONE3.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO4.TIPO4, MySqlDbType.VarChar, 6).Value = CBBTIPO4.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD4.DDD4, MySqlDbType.VarChar, 4).Value = TXBDDD4.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE4.TELEFONE4, MySqlDbType.VarChar, 10).Value = TXBTELEFONE4.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO5.TIPO5, MySqlDbType.VarChar, 6).Value = CBBTIPO5.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD5.DDD5, MySqlDbType.VarChar, 4).Value = TXBDDD5.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE5.TELEFONE5, MySqlDbType.VarChar, 10).Value = TXBTELEFONE5.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO6.TIPO6, MySqlDbType.VarChar, 6).Value = CBBTIPO6.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD6.DDD6, MySqlDbType.VarChar, 4).Value = TXBDDD6.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE6.TELEFONE6, MySqlDbType.VarChar, 10).Value = TXBTELEFONE6.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO7.TIPO7, MySqlDbType.VarChar, 6).Value = CBBTIPO7.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD7.DDD7, MySqlDbType.VarChar, 4).Value = TXBDDD7.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE7.TELEFONE7, MySqlDbType.VarChar, 10).Value = TXBTELEFONE7.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TIPO8.TIPO8, MySqlDbType.VarChar, 6).Value = CBBTIPO8.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(DDD8.DDD8, MySqlDbType.VarChar, 4).Value = TXBDDD8.Text;
                    COMANDOCADASTRARTELEFONE.Parameters.Add(TELEFONE8.TELEFONE8, MySqlDbType.VarChar, 10).Value = TXBTELEFONE8.Text;
                    COMANDOCADASTRARTELEFONE.ExecuteNonQuery();
                    CONEXAOCADASTRARTELEFONE.Close();

                    BotoesInicialCadastroAtualizarExcluir();

                    LabelsContatoFalse();

                    DDDFALSE();
                    TELEFONEFALSE();
                    CONTATOFALSE();
                    EMAILFALSE();
                    TIPOFALSE();
                    SEXOFALSE();

                    LIMPARTXBCBB();

                    TXBCEP.Focus();
                }
                catch
                {

                }
            }
            if (BTNCADAUTEXC.Text == "ATUALIZAR") // ATUALIZAR - BOTÃO ATUALIZAR
            {
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("ATUALIZAR CLIENTE?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        MySqlConnection CONEXAOATUALIZARFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOATUALIZARFISCAIS.Open();
                        MySqlCommand COMANDOATUALIZARFISCAIS = new MySqlCommand("update FISCAIS SET INSCREST = ?,INSCRMUN = ? WHERE IDFISCAIS = ?", CONEXAOATUALIZARFISCAIS);
                        COMANDOATUALIZARFISCAIS.Parameters.Add(INSCREST.INSCREST, MySqlDbType.VarChar).Value = TXBINSCREST.Text;
                        COMANDOATUALIZARFISCAIS.Parameters.Add(INSCRMUN.INSCRMUN, MySqlDbType.VarChar).Value = TXBINSCRMUN.Text;
                        COMANDOATUALIZARFISCAIS.Parameters.Add("@IDFISCAIS", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                        COMANDOATUALIZARFISCAIS.ExecuteNonQuery();
                        CONEXAOATUALIZARFISCAIS.Close();

                        MySqlConnection CONEXAOATUALIZARENDERECO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOATUALIZARENDERECO.Open();
                        MySqlCommand COMANDOATUALIZARENDERECO = new MySqlCommand("update ENDERECO SET RUA = ?,NUMERO = ?,COMPLEMENTO = ?,BAIRRO = ?,CIDADE = ?,ESTADO = ?,CEP = ? WHERE IDENDERECO = ?", CONEXAOATUALIZARENDERECO);
                        COMANDOATUALIZARENDERECO.Parameters.Add(RUA.RUA, MySqlDbType.VarChar).Value = TXBRUA.Text;
                        COMANDOATUALIZARENDERECO.Parameters.Add(NUMERO.NUMERO, MySqlDbType.VarChar).Value = TXBNUMERO.Text;
                        COMANDOATUALIZARENDERECO.Parameters.Add(COMPLEMENTO.COMPLEMENTO, MySqlDbType.VarChar).Value = TXBCOMPLEMENTO.Text;
                        COMANDOATUALIZARENDERECO.Parameters.Add(BAIRRO.BAIRRO, MySqlDbType.VarChar).Value = TXBBAIRRO.Text;
                        COMANDOATUALIZARENDERECO.Parameters.Add(CIDADE.CIDADE, MySqlDbType.VarChar).Value = TXBCIDADE.Text;
                        COMANDOATUALIZARENDERECO.Parameters.Add(ESTADO.ESTADO, MySqlDbType.VarChar).Value = TXBESTADO.Text;
                        COMANDOATUALIZARENDERECO.Parameters.Add(CEP.CEP, MySqlDbType.VarChar).Value = TXBCEP.Text;
                        COMANDOATUALIZARENDERECO.Parameters.Add("@IDENDERECO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                        COMANDOATUALIZARENDERECO.ExecuteNonQuery();
                        CONEXAOATUALIZARENDERECO.Close();

                        MySqlConnection CONEXAOATUALIZARCONTATO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOATUALIZARCONTATO.Open();
                        MySqlCommand COMANDOATUALIZARCONTATO = new MySqlCommand("update CONTATO SET CONTATO1 = ?,SEXO1 = ?,EMAIL1 = ?,CONTATO2 = ?,SEXO2 = ?,EMAIL2 = ?,CONTATO3 = ?,SEXO3 = ?,EMAIL3 = ?,CONTATO4 = ?,SEXO4 = ?,EMAIL4 = ?,CONTATO5 = ?,SEXO5 = ?,EMAIL5 = ?,CONTATO6 = ?,SEXO6 = ?,EMAIL6 = ?,CONTATO7 = ?,SEXO7 = ?,EMAIL7 = ?,CONTATO8 = ?,SEXO8 = ?,EMAIL8 = ? where IDCONTATO = ?", CONEXAOATUALIZARCONTATO);
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO1.CONTATO1, MySqlDbType.VarChar).Value = TXBCONTATO1.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO1.SEXO1, MySqlDbType.VarChar).Value = CBBSEXO1.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL1.EMAIL1, MySqlDbType.VarChar).Value = TXBEMAIL1.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO2.CONTATO2, MySqlDbType.VarChar).Value = TXBCONTATO2.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO2.SEXO2, MySqlDbType.VarChar).Value = CBBSEXO2.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL2.EMAIL2, MySqlDbType.VarChar).Value = TXBEMAIL2.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO3.CONTATO3, MySqlDbType.VarChar).Value = TXBCONTATO3.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO3.SEXO3, MySqlDbType.VarChar).Value = CBBSEXO3.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL3.EMAIL3, MySqlDbType.VarChar).Value = TXBEMAIL3.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO4.CONTATO4, MySqlDbType.VarChar).Value = TXBCONTATO4.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO4.SEXO4, MySqlDbType.VarChar).Value = CBBSEXO4.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL4.EMAIL4, MySqlDbType.VarChar).Value = TXBEMAIL4.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO5.CONTATO5, MySqlDbType.VarChar).Value = TXBCONTATO5.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO5.SEXO5, MySqlDbType.VarChar).Value = CBBSEXO5.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL5.EMAIL5, MySqlDbType.VarChar).Value = TXBEMAIL5.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO6.CONTATO6, MySqlDbType.VarChar).Value = TXBCONTATO6.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO6.SEXO6, MySqlDbType.VarChar).Value = CBBSEXO6.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL6.EMAIL6, MySqlDbType.VarChar).Value = TXBEMAIL6.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO7.CONTATO7, MySqlDbType.VarChar).Value = TXBCONTATO7.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO7.SEXO7, MySqlDbType.VarChar).Value = CBBSEXO7.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL7.EMAIL7, MySqlDbType.VarChar).Value = TXBEMAIL7.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(CONTATO8.CONTATO8, MySqlDbType.VarChar).Value = TXBCONTATO8.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(SEXO8.SEXO8, MySqlDbType.VarChar).Value = CBBSEXO8.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add(EMAIL8.EMAIL8, MySqlDbType.VarChar).Value = TXBEMAIL8.Text;
                        COMANDOATUALIZARCONTATO.Parameters.Add("@IDCONTATO", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                        COMANDOATUALIZARCONTATO.ExecuteNonQuery();
                        CONEXAOATUALIZARCONTATO.Close();

                        MySqlConnection CONEXAOATUALIZARTELEFONE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOATUALIZARTELEFONE.Open();
                        MySqlCommand COMANDOATUALIZARTELEFONE = new MySqlCommand("Update TELEFONE SET TIPO1 = ?, DDD1 = ?, TELEFONE1 = ?, TIPO2 = ?, DDD2 = ?, TELEFONE2 = ?, TIPO3 = ?, DDD3 = ?, TELEFONE3 = ?, TIPO4 = ?, DDD4 = ?, TELEFONE4 = ?, TIPO5 = ?, DDD5 = ?, TELEFONE5 = ?, TIPO6 = ?, DDD6 = ?, TELEFONE6 = ?, TIPO7 = ?, DDD7 = ?, TELEFONE7 = ?,TIPO8 = ?, DDD8 = ?, TELEFONE8 = ? where IDTELEFONE = ?", CONEXAOATUALIZARTELEFONE);
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO1.TIPO1, MySqlDbType.VarChar).Value = CBBTIPO1.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD1.DDD1, MySqlDbType.VarChar).Value = TXBDDD1.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE1.TELEFONE1, MySqlDbType.VarChar).Value = TXBTELEFONE1.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO2.TIPO2, MySqlDbType.VarChar).Value = CBBTIPO2.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD2.DDD2, MySqlDbType.VarChar).Value = TXBDDD2.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE2.TELEFONE2, MySqlDbType.VarChar).Value = TXBTELEFONE2.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO3.TIPO3, MySqlDbType.VarChar).Value = CBBTIPO3.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD3.DDD3, MySqlDbType.VarChar).Value = TXBDDD3.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE3.TELEFONE3, MySqlDbType.VarChar).Value = TXBTELEFONE3.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO4.TIPO4, MySqlDbType.VarChar).Value = CBBTIPO4.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD4.DDD4, MySqlDbType.VarChar).Value = TXBDDD4.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE4.TELEFONE4, MySqlDbType.VarChar).Value = TXBTELEFONE4.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO5.TIPO5, MySqlDbType.VarChar).Value = CBBTIPO5.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD5.DDD5, MySqlDbType.VarChar).Value = TXBDDD5.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE5.TELEFONE5, MySqlDbType.VarChar).Value = TXBTELEFONE5.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO6.TIPO6, MySqlDbType.VarChar).Value = CBBTIPO6.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD6.DDD6, MySqlDbType.VarChar).Value = TXBDDD6.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE6.TELEFONE6, MySqlDbType.VarChar).Value = TXBTELEFONE6.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO7.TIPO7, MySqlDbType.VarChar).Value = CBBTIPO7.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD7.DDD7, MySqlDbType.VarChar).Value = TXBDDD7.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE7.TELEFONE7, MySqlDbType.VarChar).Value = TXBTELEFONE7.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TIPO8.TIPO8, MySqlDbType.VarChar).Value = CBBTIPO8.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(DDD8.DDD8, MySqlDbType.VarChar).Value = TXBDDD8.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add(TELEFONE8.TELEFONE8, MySqlDbType.VarChar).Value = TXBTELEFONE8.Text;
                        COMANDOATUALIZARTELEFONE.Parameters.Add("@IDTELEFONE", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                        COMANDOATUALIZARTELEFONE.ExecuteNonQuery();
                        CONEXAOATUALIZARTELEFONE.Close();

                        BotoesInicialCadastroAtualizarExcluir();

                        TXBNUMERO.Visible = true;
                        TXBNUMERO.Enabled = false;
                        TXBCOMPLEMENTO.Visible = true;
                        TXBCOMPLEMENTO.Enabled = false;
                        TXBINSCREST.Visible = true;
                        TXBINSCREST.Enabled = false;
                        TXBINSCRMUN.Visible = true;
                        TXBINSCRMUN.Enabled = false;

                        DDDFALSE();
                        TELEFONEFALSE();
                        CONTATOFALSE();
                        EMAILFALSE();
                        TIPOFALSE();
                        SEXOFALSE();

                        ATUALIZACBB();

                        LIMPARTXBCBB();

                        TXBCEP.Visible = true;
                        TXBCEP.Enabled = false;

                        CBBNOME.Visible = true;
                        CBBNOME.Enabled = true;
                        CBBNOME.Focus();
                    }
                }
                catch
                {

                }
            }
            if (BTNCADAUTEXC.Text == "EXCLUIR")
            {
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        MySqlConnection CONEXAOEXCLUIRCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOEXCLUIRCLIENTE.Open();
                        MySqlCommand COMANDOEXCLUIRCLIENTE = new MySqlCommand("delete FROM CLIENTE where IDCLIENTE = ?", CONEXAOEXCLUIRCLIENTE);
                        COMANDOEXCLUIRCLIENTE.Parameters.Add("@IDCLIENTE", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                        COMANDOEXCLUIRCLIENTE.ExecuteNonQuery();
                        CONEXAOEXCLUIRCLIENTE.Close();

                        //GRAFICA2
                        MySqlConnection CONEXAOEXCLUIRCLIENTE2 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");
                        CONEXAOEXCLUIRCLIENTE2.Open();
                        MySqlCommand COMANDOEXCLUIRCLIENTE2 = new MySqlCommand("delete FROM CLIENTE where RAZAOSOCIAL = ?", CONEXAOEXCLUIRCLIENTE2);
                        COMANDOEXCLUIRCLIENTE2.Parameters.Add(RAZAOSOCIAL.RAZAOSOCIAL, MySqlDbType.VarChar).Value = TXBRAZAOSOCIAL.Text;
                        COMANDOEXCLUIRCLIENTE2.ExecuteNonQuery();
                        CONEXAOEXCLUIRCLIENTE2.Close();

                        MySqlConnection CONEXAOEXCLUIRFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOEXCLUIRFISCAIS.Open();
                        MySqlCommand COMANDOEXCLUIRFISCAIS = new MySqlCommand("delete FROM FISCAIS where IDFISCAIS = ?", CONEXAOEXCLUIRFISCAIS);
                        COMANDOEXCLUIRFISCAIS.Parameters.Add("@IDFISCAIS", MySqlDbType.VarChar).Value = TXBCODIGO.Text;
                        COMANDOEXCLUIRFISCAIS.ExecuteNonQuery();
                        CONEXAOEXCLUIRFISCAIS.Close();

                        //GRAFICA2
                        MySqlConnection CONEXAOEXCLUIRFISCAIS2 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica2;password=1234");
                        CONEXAOEXCLUIRFISCAIS2.Open();
                        MySqlCommand COMANDOEXCLUIRFISCAIS2 = new MySqlCommand("delete FROM FISCAIS where CNPJ = ?", CONEXAOEXCLUIRFISCAIS2);
                        COMANDOEXCLUIRFISCAIS2.Parameters.Add(CNPJ.CNPJ, MySqlDbType.VarChar).Value = TXBCNPJ.Text;
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

                        BotoesInicialCadastroAtualizarExcluir();

                        LabelsContatoFalse();

                        DDDFALSE();
                        TELEFONEFALSE();
                        CONTATOFALSE();
                        EMAILFALSE();
                        TIPOFALSE();
                        SEXOFALSE();

                        ATUALIZACBB();

                        LIMPARTXBCBB();

                        CBBNOME.Focus();
                    }
                }
                catch
                {

                }
            }
        }
        private void TXBNUMERO_TextChanged(object sender, EventArgs e) //NUMERO EM BRANCO NO CADASTRO
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
        private void TXBNOME_TextChanged(object sender, EventArgs e) //NOME EM BRANCO NO CADASTRO
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
        private void TXBRAZAOSOCIAL_TextChanged(object sender, EventArgs e) //RAZÃO SOCIAL EM BRANCO NO CADASTRO
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (TXBRAZAOSOCIAL.Text == "")
                {
                    MessageBox.Show("RAZÃO SOCIAL EM BRANCO");

                    TXBRAZAOSOCIAL.Focus();
                }
            }
        }
        private void TXBCNPJ_TextChanged(object sender, EventArgs e) //CNPJ EM BRANCO NO CADASTRO
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (TXBCNPJ.Text == "")
                {
                    MessageBox.Show("CNPJ EM BRANCO");

                    TXBCNPJ.Focus();
                }
            }
        }
        public void pesquisarcliente() // PESQUISAR CLIENTE
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
        public void pesquisarendereco() // PESQUISAR ENDEREÇO
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
        public void pesquisarfiscais() // PESQUISAR FISCAIS
        {
            MySqlConnection CONEXAOFISCAIS = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAOFISCAIS.Open();

            MySqlCommand COMANDOFISCAIS = new MySqlCommand("SELECT CNPJ, INSCREST, INSCRMUN FROM FISCAIS WHERE IDFISCAIS = ?", CONEXAOFISCAIS);
            COMANDOFISCAIS.Parameters.Clear();
            COMANDOFISCAIS.Parameters.Add("@IDFISCAIS", MySqlDbType.VarChar).Value = TXBCODIGO.Text;

            COMANDOFISCAIS.CommandType = CommandType.Text;

            MySqlDataReader DRFISCAIS;
            DRFISCAIS = COMANDOFISCAIS.ExecuteReader();
            DRFISCAIS.Read();

            TXBCNPJ.Text = DRFISCAIS.GetString(0);
            TXBINSCREST.Text = DRFISCAIS.GetString(1);
            TXBINSCRMUN.Text = DRFISCAIS.GetString(2);

            CONEXAOFISCAIS.Close();
        }
        public void pesquisarcontato() // PESQUISAR CONTATO
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
        public void pesquisartelefone() // PESQUISAR TELEFONE
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
        private void BTNPESQUISAR_Click(object sender, EventArgs e) // BOTÃO PESQUISAR ATUALIZAR/EXCLUIR
        {

            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                try
                {
                    CBBEMBRANCO();

                    TXBNUMERO.Visible = true;
                    TXBNUMERO.Enabled = true;
                    TXBCOMPLEMENTO.Visible = true;
                    TXBCOMPLEMENTO.Enabled = true;
                    TXBINSCREST.Visible = true;
                    TXBINSCREST.Enabled = true;
                    TXBINSCRMUN.Visible = true;
                    TXBINSCRMUN.Enabled = true;

                    TXBCEP.Enabled = true;
                    CBBNOME.Enabled = false;

                    pesquisarcliente();

                    pesquisarendereco();

                    pesquisarfiscais();

                    pesquisarcontato();

                    pesquisartelefone();

                    if (TXBCONTATO1.Text != "")
                    {
                        BotaoCadastroAtualizarContato1();
                        TamanhoePosicaoContato1();
                    }
                    if (TXBCONTATO2.Text != "")
                    {
                        BotaoCadastroAtualizarContato2();
                        TamanhoePosicaoContato2();
                    }
                    if (TXBCONTATO3.Text != "")
                    {
                        BotaoCadastroAtualizarContato3();
                        TamanhoePosicaoContato3();
                    }
                    if (TXBCONTATO4.Text != "")
                    {
                        BotaoCadastroAtualizarContato4();
                        TamanhoePosicaoContato4();
                    }
                    if (TXBCONTATO5.Text != "")
                    {
                        BotaoCadastroAtualizarContato5();
                        TamanhoePosicaoContato5();
                    }
                    if (TXBCONTATO6.Text != "")
                    {
                        BotaoCadastroAtualizarContato6();
                        TamanhoePosicaoContato6();
                    }
                    if (TXBCONTATO7.Text != "")
                    {
                        BotaoCadastroAtualizarContato7();
                        TamanhoePosicaoContato7();
                    }
                    if (TXBCONTATO8.Text != "")
                    {
                        BotaoCadastroAtualizarContato8();
                        TamanhoePosicaoContato8();
                    }
                    TXBCEP.Focus();
                }
                catch
                {

                }
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                try
                {
                    CBBEMBRANCO();

                    pesquisarcliente();

                    pesquisarendereco();

                    pesquisarfiscais();

                    pesquisarcontato();

                    pesquisartelefone();

                    if (TXBCONTATO1.Text != "")
                    {
                        BotaoCadastroAtualizarContato1();
                        TamanhoePosicaoContato1False();
                    }
                    if (TXBCONTATO2.Text != "")
                    {
                        BotaoCadastroAtualizarContato2();
                        TamanhoePosicaoContato2False();
                    }
                    if (TXBCONTATO3.Text != "")
                    {
                        BotaoCadastroAtualizarContato3();
                        TamanhoePosicaoContato3False();
                    }
                    if (TXBCONTATO4.Text != "")
                    {
                        BotaoCadastroAtualizarContato4();
                        TamanhoePosicaoContato4False();
                    }
                    if (TXBCONTATO5.Text != "")
                    {
                        BotaoCadastroAtualizarContato5();
                        TamanhoePosicaoContato5False();
                    }
                    if (TXBCONTATO6.Text != "")
                    {
                        BotaoCadastroAtualizarContato6();
                        TamanhoePosicaoContato6False();
                    }
                    if (TXBCONTATO7.Text != "")
                    {
                        BotaoCadastroAtualizarContato7();
                        TamanhoePosicaoContato7False();
                    }
                    if (TXBCONTATO8.Text != "")
                    {
                        BotaoCadastroAtualizarContato8();
                        TamanhoePosicaoContato8False();
                    }
                    CBBNOME.Focus();
                }

                catch
                {

                }
            }
        }
        public void DGVBUSCAPAPEIS()
        {
            try
            {
                MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAO.Open();
                // string CLIENTE = "SELECT NOME, RAZAOSOCIAL, RUA, NUMERO, BAIRRO, CIDADE, ESTADO, CEP, CNPJ, INSCREST, INSCRMUN, CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3 FROM CLIENTE, ENDERECO, FISCAIS, CONTATO ORDER BY nome";
                string CLIENTE = "SELECT * FROM CLIENTE, ENDERECO, FISCAIS, CONTATO, TELEFONE ORDER BY NOME";
                MySqlCommand COMANDO = new MySqlCommand(CLIENTE, CONEXAO);
                MySqlDataReader dados = COMANDO.ExecuteReader();


                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    DGV1.DataSource = dt;
                    DGV1.Rows.Clear();
                }
                CONEXAO.Close();
            }

            catch
            {
            }
        }
        public void DGV1OCULTO()
        {
            DGV1.Visible = false;
        }
        public void DGV1VISIVEL()
        {
            DGV1.Visible = true;
            DGV1.Size = new Size(1760, 620);
            DGV1.Location = new Point(80, 410);
        }
        private void TXBVALOR_TextChanged(object sender, EventArgs e)
        {
            if (TXBMATPRIMA.Text != "" || CBBMATPRIMA.Text != "")
            {
                double A, B, C;

                A = double.Parse(TXBQUANTFOLHAS.Text);
                B = double.Parse(TXBVALOR.Text);

                C = B / A;

                TXBVALOR.Text = Convert.ToDouble(TXBVALOR.Text).ToString("C");

                TXBVALORFOLHA.Text = (C.ToString());

                TXBVALORFOLHA.Text = Convert.ToDouble(TXBVALORFOLHA.Text).ToString("C");
            }
        }
        private void TXBQUANTFOLHAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TXBESTOQMINIMO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void FORMCADPAPEL_Click(object sender, EventArgs e)
        {
            MENUSTRIP5();

            CADPAPELVISIVEL();

            DGV1VISIVEL();

            AsteriscosFalse();
            LabelsContatoFalse();
            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();

            DGVBUSCAPAPEIS();

            LabelsDadosDoClienteParaCadastrarAtualizarExcluirFalse();
            DadosDoClienteParaCadastroFalse();
        }
        public void LABELSCADASTROATUALIZAREXCLUIRPAPEL()
        {
            label70.Visible = true;
            label70.Text = "MATÉRIA PRIMA";
            label5.Visible = true;
            label5.Text = "QUANT. FOLHAS";
            label5.Location = new Point(918, 281);
            label6.Visible = true;
            label6.Text = "VALOR";
            label6.Location = new Point(1039, 281);
            label7.Visible = true;
            label7.Text = "ESTOQUE MÍNIMO";
            label7.Location = new Point(1158, 281);
            label8.Visible = true;
            label8.Text = "VALOR FOLHAS";
            label8.Location = new Point(1278, 281);
            label9.Visible = true;
            label9.Text = "QUANT. ATUAL";
            label9.Location = new Point(1398, 281);
        }
        public void CADPAPELVISIVEL()
        {
            CBBMATPRIMA.Visible = false;

            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "CADASTRAR PAPEIS";
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 100);
            label2.Font = new Font("arial black", 48);

            LABELSCADASTROATUALIZAREXCLUIRPAPEL();

            TXBMATPRIMA.Visible = true;
            TXBMATPRIMA.Size = new Size(500, 20);
            TXBMATPRIMA.Location = new Point(411, 299);
            TXBQUANTFOLHAS.Visible = true;
            TXBQUANTFOLHAS.Size = new Size(111, 20);
            TXBQUANTFOLHAS.Location = new Point(919, 299);
            TXBVALOR.Visible = true;
            TXBVALOR.Size = new Size(111, 20);
            TXBVALOR.Location = new Point(1039, 299);
            TXBESTOQMINIMO.Visible = true;
            TXBESTOQMINIMO.Size = new Size(111, 20);
            TXBESTOQMINIMO.Location = new Point(1158, 299);
            TXBVALORFOLHA.Visible = true;
            TXBVALORFOLHA.Enabled = false;
            TXBVALORFOLHA.Size = new Size(111, 20);
            TXBVALORFOLHA.Location = new Point(1278, 299);
            TXBQUANTATUAL.Visible = true;  // TXB QUANT. ATUAL
            TXBQUANTATUAL.Enabled = false;
            TXBQUANTATUAL.Size = new Size(111, 20);
            TXBQUANTATUAL.Location = new Point(1398, 299);

            BTNPESQUISAR.Visible = false;
            BTNENTRADA.Visible = false;
            BTNSAIDA.Visible = false;

            BTNCADAUTEXC.Visible = true;
            BTNCADAUTEXC.Text = "CADASTRAR";
            BTNCADAUTEXC.ForeColor = Color.Blue;
            BTNCADAUTEXC.Location = new Point(411, 337);
            BTNCADAUTEXC.Size = new Size(500, 54);

            BTNCANCELA.Visible = true;
            BTNCANCELA.Text = "CANCELAR";
            BTNCANCELA.ForeColor = Color.Black;
            BTNCANCELA.Location = new Point(1011, 337);
            BTNCANCELA.Size = new Size(500, 54);

            TXBMATPRIMA.Focus();
        }
        public void CADPAPELINVISIVEL()
        {
            CBBMATPRIMA.Visible = false;

            label1.Visible = false;
            label2.Visible = false;

            label70.Visible = false;
            TXBMATPRIMA.Visible = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            TXBQUANTFOLHAS.Visible = false;
            TXBVALOR.Visible = false;
            TXBESTOQMINIMO.Visible = false;
            TXBVALORFOLHA.Visible = false;
            TXBVALORFOLHA.Enabled = false;
            TXBQUANTATUAL.Visible = false;
            TXBQUANTATUAL.Enabled = false;

            BTNPESQUISAR.Visible = false;
            BTNENTRADA.Visible = false;
            BTNSAIDA.Visible = false;

            BTNCADAUTEXC.Visible = false;


            BTNCANCELA.Visible = false;


            TXBMATPRIMA.Focus();
        }
        //  private void ATUPAPEL_Click(object sender, EventArgs e)
        //  {
        //  MENUSTRIP6();
        /*  label1.Visible = false;
          label2.Visible = true;
          label2.Text = "ATUALIZAR PAPEIS";
          label2.ForeColor = Color.Green;
        label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 100);
            label2.Font = new Font("arial black", 48);

          TXBMATPRIMA.Visible = false;

          CBBMATPRIMA.Size = new Size(500, 20);
          CBBMATPRIMA.Location = new Point(411, 299);
          CBBMATPRIMA.Visible = true;
          CBBMATPRIMA.Enabled = true;

          BTNENTRADA.Visible = true;
          BTNENTRADA.Text = "ENTRADA";
          BTNENTRADA.ForeColor = Color.Blue;
          BTNENTRADA.Size = new Size(444, 27);
          BTNENTRADA.Location = new Point(411, 340);

          BTNSAIDA.Visible = true;
          BTNSAIDA.Text = "SAIDA";
          BTNSAIDA.ForeColor = Color.Red;
          BTNSAIDA.Size = new Size(444, 27);
          BTNSAIDA.Location = new Point(1066, 340);

           LABELSCADASTROATUALIZAREXCLUIRPAPEL();

          TXBQUANTFOLHAS.Visible = true;
          TXBQUANTFOLHAS.Size = new Size(111, 20);
          TXBQUANTFOLHAS.Location = new Point(919, 299);
          TXBVALOR.Visible = true;
          TXBVALOR.Size = new Size(111, 20);
          TXBVALOR.Location = new Point(1039, 299);
          TXBESTOQMINIMO.Visible = true;
          TXBESTOQMINIMO.Size = new Size(111, 20);
          TXBESTOQMINIMO.Location = new Point(1158, 299);
          TXBVALORFOLHA.Visible = true;
          TXBVALORFOLHA.Enabled = false;
          TXBVALORFOLHA.Size = new Size(111, 20);
          TXBVALORFOLHA.Location = new Point(1278, 299);
          TXBQUANTATUAL.Visible = true;  // TXB QUANT. ATUAL
          TXBQUANTATUAL.Enabled = false;
          TXBQUANTATUAL.Size = new Size(111, 20);
          TXBQUANTATUAL.Location = new Point(1398, 299);

          BTNCADAUTEXC.Visible = true;
          BTNCADAUTEXC.Text = "ATUALIZAR";
          BTNCADAUTEXC.ForeColor = Color.Green;
          BTNCADAUTEXC.Location = new Point(411, 390);

          BTNCANCELA.Visible = true;
          BTNCANCELA.Text = "CANCELAR";
          BTNCANCELA.ForeColor = Color.Black;
          BTNCANCELA.Location = new Point(1066, 390);

          BTNPESQUISAR.Visible = true;

          CBBMATPRIMA.Focus();   */
        //   }

        //  private void EXCPAPEL_Click(object sender, EventArgs e)
        //  {
        //   MENUSTRIP4();
        /*  label1.Visible = false;
          label2.Visible = true;
          label2.Text = "EXCLUIR PAPEIS";
          label2.ForeColor = Color.Red;
        label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 100);
            label2.Font = new Font("arial black", 48);

         LABELSCADASTROATUALIZAREXCLUIRPAPEL();

          BTNCADAUTEXC.Visible = true;
          BTNCADAUTEXC.Text = "EXCLUIR";
          BTNCADAUTEXC.ForeColor = Color.Red;
          BTNCADAUTEXC.Location = new Point(411, 544);

          BTNCANCELA.Visible = true;
          BTNCANCELA.Text = "CANCELAR";
          BTNCANCELA.ForeColor = Color.Black;
          BTNCANCELA.Location = new Point(1066, 544);

          BTNPESQUISAR.Visible = true;  */
        //  }
        //  public void VALORFOLHA()
        // {
        /*  int vl1, vl2, res;

          vl1 = int.Parse(TXBTELEFONE1.Text);//vl1 recebe  VALOR 
          vl2 = int.Parse(TXBRAZAOSOCIAL.Text);//vl2 recebe  QUANT. FOLHAS

          res = vl1 / vl2;
          TXBTELEFONE3.Text = (res.ToString()); // RESULTADO  



          //  EXIBINDO O VALOR EM UMA TEXTBOX
          TXBTELEFONE3.Text = Convert.ToDouble(TXBTELEFONE3.Text).ToString("C");  */
        // }

        // private void BTNCANCELA_Click(object sender, EventArgs e)
        // {
        //  BTNCADASTRARATUEXC();
        // }
    }
}








