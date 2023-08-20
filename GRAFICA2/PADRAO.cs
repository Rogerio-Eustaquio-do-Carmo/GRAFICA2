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

        // ATUALIZA O COMBOBOX NOME NO FORMULARIO ATUALIZAR E EXCLUIR CLIENTE
        private void ATUALIZACBBNOME()
        {
            MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAO.Open();

            string CLIENTE = "SELECT NOME FROM CLIENTE ORDER BY NOME";
            MySqlCommand COMANDO = new MySqlCommand(CLIENTE, CONEXAO);

            DataSet ds = new DataSet();

            MySqlDataAdapter da = new MySqlDataAdapter(COMANDO);

            da.Fill(ds);
            CBB2.DataSource = ds.Tables[0];
            CBB2.DisplayMember = "nome";
            CBB2.ValueMember = "";//CBBNOME

            CONEXAO.Close();
        }

        // ATUALIZA O COMBOBOX PAPEIS
        public void ATUALIZACBBPAPEIS()
        {
            MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAO.Open();

            string PAPEIS = "SELECT MATPRIMA FROM PAPEISCADASTRO ORDER BY MATPRIMA";
            MySqlCommand COMANDO = new MySqlCommand(PAPEIS, CONEXAO);

            DataSet ds = new DataSet();

            MySqlDataAdapter da = new MySqlDataAdapter(COMANDO);

            da.Fill(ds);
            CBB2.DataSource = ds.Tables[0];
            CBB2.DisplayMember = "matprima";
            CBB2.ValueMember = "";

            CONEXAO.Close();
        }

        // SAIR DO APLICATIVO
        private void SAIR_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA SAIR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }

        // COMBOBOX NOME NO FORMULÁRIO CLIENTE EM BRANCO
        public void CBBEMBRANCO()
        {
            if (CBB2.Text == "" || TXB3.Text == "")//CBBNOME //TXBNOME
            {
                return;
            }
        }
        // BOTÃO CADASTRAR/ATUALIZAR/EXCLUIR NOS FORMULÁRIOS
        public void BTNCADATUEXC()
        {
            BTN3.Visible = true;
            BTN3.Size = new Size(445, 54);
        }

        // BOTÃO CANCELAR
        public void BTNCANCELAR()
        {
            BTN4.Visible = true;
            BTN4.Text = "CANCELAR";
            BTN4.ForeColor = Color.Black;
        }

        // BOTÃO INSERIR VISIVEL
        public void INSERIRVISIVEL()
        {
            if (label2.Text == "CLIENTE" || label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN1.Visible = true;
                BTN1.Location = new Point(411, 476);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CENTRO DE CUSTO")         // INSERIR CENTRO DE CUSTO
            {
                BTN1.Text = "INSERIR CENTRO DE CUSTO";
                BTN1.Visible = true;
                BTN1.Location = new Point(521, 310);
                BTN1.Size = new Size(300, 25);
            }
        }

        // BOTÃO INSERIR OCULT0
        public void INSERIROCULTO()
        {
            BTN1.Visible = false;
        }

        // BOTÃO PESQUISAR VISIVEL
        public void PESQUISARVISIVEL()
        {
            if (label2.Text == "ATUALIZAR CLIENTE" || label2.Text == "EXCLUIR CLIENTE")
            {
                BTN2.Text = "PESQUISAR";
                BTN2.Visible = true;
                BTN2.Location = new Point(620, 242);
                BTN2.Size = new Size(94, 23);
            }
            if (label2.Text == "CENTRO DE CUSTO")         // EXCLUIR CENTRO DE CUSTO
            {
                BTN2.Text = "EXCLUIR CENTRO DE CUSTO";
                BTN2.Visible = true;
                BTN2.Location = new Point(1141, 310);
                BTN2.Size = new Size(300, 25);
            }
        }


        // BOTÃO PESQUISAR OCULTO
        public void PESQUISAROCULTO()
        {
            BTN2.Visible = false;
        }

        // PESQUISA O ENDEREÇO PELO CEP E PREENCHE OS CAMPOS
        public void BUSCAENDERECO()
        {
            using (var ws = new CORREIOS.AtendeClienteClient())
            {
                if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
                {
                    try
                    {
                        if (CBB1.Text == "CADASTRAR" || CBB1.Text == "ATUALIZAR")//CBBCLIENTE
                        {
                            var ENDERECO = ws.consultaCEP(TXB2.Text.Trim());//TXBCEP
                            TXB5.Text = ENDERECO.end.ToUpper();//TXBRUA
                            TXB8.Text = ENDERECO.bairro.ToUpper();//TXBBAIRRO
                            TXB9.Text = ENDERECO.cidade.ToUpper();//TXBCIDADE
                            TXB10.Text = ENDERECO.uf.ToUpper();//TXBESTADO
                        }
                    }
                    catch
                    {
                        TXB5.Text = "NÃO ENCONTRADO - VERIFIQUE A CONEXÃO OU O CEP INFORMADO.";//TXBRUA
                    }

                }
                if (label2.Text == "CADASTRAR FUNCIONÁRIO")
                {
                    try
                    {
                        var ENDERECO = ws.consultaCEP(TXBCEPFUN.Text.Trim());
                        TXBENDFUN.Text = ENDERECO.end.ToUpper();
                        TXBBAIRROFUN.Text = ENDERECO.bairro.ToUpper();
                        TXBCIDADEFUN.Text = ENDERECO.cidade.ToUpper();
                        TXBUFFUN.Text = ENDERECO.uf.ToUpper();
                    }
                    catch
                    {
                        TXBENDFUN.Text = "NÃO ENCONTRADO - VERIFIQUE A CONEXÃO OU O CEP INFORMADO.";
                    }
                }
            }
        }

        // BUSCAR ENDEREÇO, CEP EM BRANCO OU COM MAIS DE 8 CARACTERES
        public void TXBCEP_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (CBB1.Text == "CADASTRAR")//CBBCLIENTE
                {
                    if (TXB2.Text == "")//TXBCEP
                    {
                        MessageBox.Show("CEP EM BRANCO");

                        TXB2.Focus();//TXBCEP

                        return;
                    }
                    if (TXB2.Text.Length != 8)//TXBCEP
                    {
                        MessageBox.Show("CEP COM TAMANHO ERRADO");

                        TXB2.Focus();//TXBCEP

                        return;
                    }
                }
            }
            if (label2.Text == "CADASTRAR FUNCIONÁRIO")
            {
                if (TXBCEPFUN.Text == "")
                {
                    MessageBox.Show("CEP EM BRANCO");

                    TXBCEPFUN.Focus();

                    return;
                }
                if (TXBCEPFUN.Text.Length != 8)
                {
                    MessageBox.Show("CEP COM TAMANHO ERRADO");

                    TXBCEPFUN.Focus();

                    return;
                }
            }
            BUSCAENDERECO();
        }

        // SOMENTE NUMEROS NO CEP
        private void TXBCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // NUMERO EM BRANCO NO CADASTRO
        private void TXBNUMERO_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                if (TXB6.Text == "")//TXBNUMERO
                {
                    MessageBox.Show("NUMERO EM BRANCO");
                    TXB6.Focus();//TXBNUMERO
                }
            }
        }

        // NOME EM BRANCO OU EXISTENTE NO CADASTRO
        private void TXBNOME_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                try
                {
                    // PARA NOME EM BRANCO
                    if (TXB3.Text == "")//TXBNOME
                    {
                        MessageBox.Show("NOME EM BRANCO");
                        TXB3.Focus();//TXBNOME
                        return;
                    }

                    // PARA NOME EXISTENTE
                    MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAO.Open();
                    MySqlCommand COMANDO = new MySqlCommand("select count(NOME) from CLIENTE WHERE NOME = ?", CONEXAO);
                    COMANDO.Parameters.Clear();
                    COMANDO.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = TXB3.Text;//TXBNOME
                    MySqlDataReader DRCLIENTE;
                    DRCLIENTE = COMANDO.ExecuteReader();
                    DRCLIENTE.Read();
                    int RESULTADO = int.Parse(DRCLIENTE.GetString(0));
                    while (RESULTADO > 0)
                    {
                        MessageBox.Show("NOME EXISTENTE");
                        TXB3.Focus();//TXBNOME
                        return;
                    }

                    CONEXAO.Close();
                }
                catch
                {
                }
            }
        }

        // RAZÃO SOCIAL EM BRANCO NO CADASTRO
        private void TXBRAZAOSOCIAL_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                try
                {
                    // PARA RAZÃO SOCIAL EM BRANCO
                    if (TXB4.Text == "")//TXBRAZAOSOCIAL
                    {
                        MessageBox.Show("RAZÃO SOCIAL EM BRANCO");
                        TXB4.Focus();//TXBRAZAOSOCIAL
                        return;
                    }

                    // PARA RAZÃO SOCIAL EXISTENTE
                    MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAO.Open();
                    MySqlCommand COMANDO = new MySqlCommand("select count(RAZAOSOCIAL) from CLIENTE WHERE RAZAOSOCIAL = ?", CONEXAO);
                    COMANDO.Parameters.Clear();
                    COMANDO.Parameters.Add("@RAZAOSOCIAL", MySqlDbType.VarChar).Value = TXB4.Text;//TXBRAZAOSOCIAL
                    MySqlDataReader DRCLIENTE;
                    DRCLIENTE = COMANDO.ExecuteReader();
                    DRCLIENTE.Read();
                    int RESULTADO = int.Parse(DRCLIENTE.GetString(0));
                    while (RESULTADO > 0)
                    {
                        MessageBox.Show("RAZÃO SOCIAL EXISTENTE");
                        TXB4.Focus();//TXBRAZAOSOCIAL
                        return;
                    }

                    CONEXAO.Close();
                }
                catch
                {
                }
            }
        }

        // CNPJ EM BRANCO NO CADASTRO
        private void TXBCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                try
                {
                    // PARA CNPJ EM BRANCO
                    if (TXB11.Text == "")//TXBCNPJ
                    {
                        MessageBox.Show("CNPJ EM BRANCO");
                        TXB11.Focus();//TXBCNPJ
                        return;
                    }

                    // PARA CNPJ EXISTENTE
                    MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAO.Open();
                    MySqlCommand COMANDO = new MySqlCommand("select count(CNPJ) from CLIENTE WHERE CNPJ = ?", CONEXAO);
                    COMANDO.Parameters.Clear();
                    COMANDO.Parameters.Add("@CNPJ", MySqlDbType.VarChar).Value = TXB11.Text;//TXBCNPJ
                    MySqlDataReader DRCLIENTE;
                    DRCLIENTE = COMANDO.ExecuteReader();
                    DRCLIENTE.Read();
                    int RESULTADO = int.Parse(DRCLIENTE.GetString(0));
                    while (RESULTADO > 0)
                    {
                        MessageBox.Show("CNPJ EXISTENTE");
                        TXB11.Focus();//TXBCNPJ
                        return;
                    }

                    CONEXAO.Close();
                }
                catch
                {
                }
            }
        }

        // SOMENTE NUMEROS NO CNPJ
        private void TXBCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // LIMPA TODOS TEXTBOX E COMBOBOX CLIENTES
        public void LIMPARTXBCBB()
        {

            TXB1.Clear();//TXBCODIGO
            TXB2.Clear();//TXBCEP
            TXB3.Clear();//TXBNOME
            TXB4.Clear();//TXBRAZAOSOCIAL
            TXB5.Clear();//TXBRUA
            TXB6.Clear();//TXBNUMERO
            TXB7.Clear();//TXBCOMPLEMENTO
            TXB8.Clear();//TXBBAIRRO
            TXB9.Clear();//TXBCIDADE
            TXB10.Clear();//TXBESTADO
            TXB11.Clear();//TXBCNPJ
            TXB12.Clear();//TXBINSCREST
            TXB13.Clear();//TXBINSCRMUN
            TXB14.Clear();//TXBDDD1
            TXB15.Clear();//TXBTELEFONE1
            TXB16.Clear();//TXBCONTATO1
            TXB17.Clear();//TXBEMAIL1
            TXB18.Clear();//TXBDDD2
            TXB19.Clear();//TXBTELEFONE2
            TXB20.Clear();//TXBCONTATO2
            TXB21.Clear();//TXBEMAIL2
            TXB22.Clear();//TXBDDD3
            TXB23.Clear();//TXBTELEFONE3
            TXB24.Clear();//TXBCONTATO3
            TXB25.Clear();//TXBEMAIL3
            TXB26.Clear();//TXBDDD4
            TXB27.Clear();//TXBTELEFONE4
            TXB28.Clear();//TXBCONTATO4
            TXB29.Clear();//TXBEMAIL4
            TXB30.Clear();//TXBDDD5
            TXB31.Clear();//TXBTELEFONE5
            TXB32.Clear();//TXBCONTATO5
            TXB33.Clear();//TXBEMAIL5
            TXB34.Clear();//TXBDDD6
            TXB35.Clear();//TXBTELEFONE6
            TXB36.Clear();//TXBCONTATO6
            TXB37.Clear();//TXBEMAIL6
            TXB38.Clear();//TXBDDD7
            TXB39.Clear();//TXBTELEFONE7
            TXB40.Clear();//TXBCONTATO7
            TXB41.Clear();//TXBEMAIL7
            TXB42.Clear();//TXBDDD8
            TXB43.Clear();//TXBTELEFONE8
            TXB44.Clear();//TXBCONTATO8
            TXB45.Clear();//TXBEMAIL8

            CBB2.Text = "";//CBBNOME
            CBB3.Text = "";//CBBTIPO1
            CBB4.Text = "";//CBBSEXO1
            CBB5.Text = "";//CBBTIPO2
            CBB6.Text = "";//CBBSEXO2
            CBB7.Text = "";//CBBTIPO3
            CBB8.Text = "";//CBBSEXO3
            CBB9.Text = "";//CBBTIPO4
            CBB10.Text = "";//CBBSEXO4
            CBB11.Text = "";//CBBTIPO5
            CBB12.Text = "";//CBBSEXO5
            CBB13.Text = "";//CBBTIPO6
            CBB14.Text = "";//CBBSEXO6
            CBB15.Text = "";//CBBTIPO7
            CBB16.Text = "";//CBBSEXO7
            CBB17.Text = "";//CBBTIPO8
            CBB18.Text = "";//CBBSEXO8
        }

        // DDD OCULTO
        public void DDDFALSE()
        {
            TXB14.Visible = false;//TXBDDD1
            TXB18.Visible = false;//TXBDDD2
            TXB22.Visible = false;//TXBDDD3
            TXB26.Visible = false;//TXBDDD4
            TXB30.Visible = false;//TXBDDD5
            TXB34.Visible = false;//TXBDDD6
            TXB38.Visible = false;//TXBDDD7
            TXB42.Visible = false;//TXBDDD8
        }

        // TELEFONE OCULTO
        public void TELEFONEFALSE()
        {
            TXB15.Visible = false;//TXBTELEFONE1
            TXB19.Visible = false;//TXBTELEFONE2
            TXB23.Visible = false;//TXBTELEFONE3
            TXB27.Visible = false;//TXBTELEFONE4
            TXB31.Visible = false;//TXBTELEFONE5
            TXB35.Visible = false;//TXBTELEFONE6
            TXB39.Visible = false;//TXBTELEFONE7
            TXB43.Visible = false;//TXBTELEFONE8
        }

        // CONTATO OCULTO
        public void CONTATOFALSE()
        {
            TXB16.Visible = false;//TXBCONTATO1
            TXB20.Visible = false;//TXBCONTATO2
            TXB24.Visible = false;//TXBCONTATO3
            TXB28.Visible = false;//TXBCONTATO4
            TXB32.Visible = false;//TXBCONTATO5
            TXB36.Visible = false;//TXBCONTATO6
            TXB40.Visible = false;//TXBCONTATO7
            TXB44.Visible = false;//TXBCONTATO8
        }

        // EMAIL OCULTO
        public void EMAILFALSE()
        {
            TXB17.Visible = false;//TXBEMAIL1
            TXB21.Visible = false;//TXBEMAIL2
            TXB25.Visible = false;//TXBEMAIL3
            TXB29.Visible = false;//TXBEMAIL4
            TXB33.Visible = false;//TXBEMAIL5
            TXB37.Visible = false;//TXBEMAIL6
            TXB41.Visible = false;//TXBEMAIL7
            TXB45.Visible = false;//TXBEMAIL8
        }

        // TIPO OCULTO
        public void TIPOFALSE()
        {
            CBB3.Visible = false;//CBBTIPO1
            CBB5.Visible = false;//CBBTIPO2
            CBB7.Visible = false;//CBBTIPO3
            CBB9.Visible = false;//CBBTIPO4
            CBB11.Visible = false;//CBBTIPO5
            CBB13.Visible = false;//CBBTIPO6
            CBB15.Visible = false;//CBBTIPO7
            CBB17.Visible = false;//CBBTIPO8
        }

        // SEXO OCULTO
        public void SEXOFALSE()
        {
            CBB4.Visible = false;//CBBSEXO1
            CBB6.Visible = false;//CBBSEXO2
            CBB8.Visible = false;//CBBSEXO3
            CBB10.Visible = false;//CBBSEXO4
            CBB12.Visible = false;//CBBSEXO5
            CBB14.Visible = false;//CBBSEXO6
            CBB16.Visible = false;//CBBSEXO7
            CBB18.Visible = false;//CBBSEXO8
        }

        // CAMPO HORA DO FORMULÁRIO CLIENTE
        public void DATACLIENTE()
        {
            LBLDATA.Visible = true;
            LBLDATA.Enabled = true;
            LBLDATA.Location = new Point(1380, 285);
            LBLDATA.Size = new Size(130, 20);
        }

        // CAMPO HORA DO FORMULÁRIO PAPEIS
        public void DATAPAPEIS()
        {
            LBLDATA.Visible = true;
            LBLDATA.Enabled = true;
            LBLDATA.Location = new Point(780, 282);
            LBLDATA.Size = new Size(130, 20);
        }
        // CAMPOS DOS FORMULÁRIOS VISIVEIS
        public void TXBVISIVEIS()
        {
            if (label2.Text == "CLIENTE")
            {
                DATACLIENTE();

                TXB1.Visible = false;//TXBCODIGO
                TXB2.Visible = true;
                TXB2.Enabled = false;//TXBCEP
                TXB2.Location = new Point(411, 300);
                TXB2.Size = new Size(128, 20);
                TXB3.Visible = true;
                TXB3.Enabled = false;//TXBNOME
                TXB3.Location = new Point(545, 300);
                TXB3.Size = new Size(283, 20);
                CBB2.Visible = false;//CBBNOME
                TXB4.Visible = true;
                TXB4.Enabled = false;//TXBRAZAOSOCIAL
                TXB4.Location = new Point(834, 300);
                TXB4.Size = new Size(676, 20);
                TXB5.Visible = true;
                TXB5.Enabled = false;//TXBRUA
                TXB5.Location = new Point(411, 345);
                TXB5.Size = new Size(725, 20);
                TXB6.Visible = true;
                TXB6.Enabled = false;//TXBNUMERO
                TXB6.Location = new Point(1144, 345);
                TXB6.Size = new Size(103, 20);
                TXB7.Visible = true;
                TXB7.Enabled = false;//TXBCOMPLEMENTO
                TXB7.Location = new Point(1254, 345);
                TXB7.Size = new Size(255, 20);
                TXB8.Visible = true;
                TXB8.Enabled = false;//TXBBAIRRO
                TXB8.Location = new Point(411, 390);
                TXB8.Size = new Size(519, 20);
                TXB9.Visible = true;
                TXB9.Enabled = false;//TXBCIDADE
                TXB9.Location = new Point(939, 390);
                TXB9.Size = new Size(513, 20);
                TXB10.Visible = true;
                TXB10.Enabled = false;//TXBESTADO
                TXB10.Location = new Point(1461, 390);
                TXB10.Size = new Size(49, 20);
                TXB11.Visible = true;
                TXB11.Enabled = false;//TXBCNPJ
                TXB11.Location = new Point(411, 435);
                TXB11.Size = new Size(364, 20);
                TXB12.Visible = true;
                TXB12.Enabled = false;//TXBINSCREST
                TXB12.Location = new Point(783, 435);
                TXB12.Size = new Size(358, 20);
                TXB13.Visible = true;
                TXB13.Enabled = false;//INSCRMUN
                TXB13.Location = new Point(1149, 435);
                TXB13.Size = new Size(360, 20);
            }
            if (CBB1.Text == "CADASTRAR")//CBBCLIENTE
            {
                label1.Visible = false;

                label25.Visible = true;

                label2.Visible = true;
                label2.Text = "CADASTRAR CLIENTE";
                label2.ForeColor = Color.Blue;
                label2.Location = new Point(500, 50);
                label2.Size = new Size(900, 100);
                label2.Font = new Font("arial black", 48);

                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;

                TXB1.Visible = false;//TXBCODIGO
                TXB2.Visible = true;
                TXB2.Enabled = true;//TXBCEP
                TXB2.Location = new Point(411, 300);
                TXB2.Size = new Size(128, 20);
                TXB3.Visible = true;
                TXB3.Enabled = true;//TXBNOME
                TXB3.Location = new Point(545, 300);
                TXB3.Size = new Size(283, 20);
                CBB2.Visible = false;//CBBNOME
                TXB4.Visible = true;
                TXB4.Enabled = true;//TXBRAZAOSOCIAL
                TXB4.Location = new Point(834, 300);
                TXB4.Size = new Size(676, 20);
                TXB5.Visible = true;
                TXB5.Enabled = false;//TXBRUA
                TXB5.Location = new Point(411, 345);
                TXB5.Size = new Size(725, 20);
                TXB6.Visible = true;
                TXB6.Enabled = true;//TXBNUMERO
                TXB6.Location = new Point(1144, 345);
                TXB6.Size = new Size(103, 20);
                TXB7.Visible = true;
                TXB7.Enabled = true;//TXBCOMPLEMENTO
                TXB7.Location = new Point(1254, 345);
                TXB7.Size = new Size(255, 20);
                TXB8.Visible = true;
                TXB8.Enabled = false;//TXBBAIRRO
                TXB8.Location = new Point(411, 390);
                TXB8.Size = new Size(519, 20);
                TXB9.Visible = true;
                TXB9.Enabled = false;//TXBCIDADE
                TXB9.Location = new Point(939, 390);
                TXB9.Size = new Size(513, 20);
                TXB10.Visible = true;
                TXB10.Enabled = false;//TXBESTADO
                TXB10.Location = new Point(1461, 390);
                TXB10.Size = new Size(49, 20);
                TXB11.Visible = true;
                TXB11.Enabled = true;//TXBCNPJ
                TXB11.Location = new Point(411, 435);
                TXB11.Size = new Size(364, 20);
                TXB12.Visible = true;
                TXB12.Enabled = true;//TXBINSCREST
                TXB12.Location = new Point(783, 435);
                TXB12.Size = new Size(358, 20);
                TXB13.Visible = true;
                TXB13.Enabled = true;//INSCRMUN
                TXB13.Location = new Point(1149, 435);
                TXB13.Size = new Size(360, 20);

                LIMPARTXBCBB();
                DATACLIENTE();
                DATAHORA();
                DDDFALSE();
                TELEFONEFALSE();
                TIPOFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                SEXOFALSE();
                BotoesInicialCadastroAtualizarExcluir();
                PESQUISAROCULTO();
                CENTRODECUSTOOCULTO();


                TXB2.Focus();//TXBCEP
            }
            if (CBB1.Text == "ATUALIZAR")//CBBCLIENTE
            {
                label1.Visible = false;

                label25.Visible = true;

                label2.Visible = true;
                label2.Text = "ATUALIZAR CLIENTE";
                label2.ForeColor = Color.Green;
                label2.Location = new Point(500, 50);
                label2.Size = new Size(900, 100);
                label2.Font = new Font("arial black", 48);

                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;

                TXB1.Visible = false;//TXBCODIGO
                TXB2.Visible = true;
                TXB2.Enabled = false;//TXBCEP
                TXB2.Location = new Point(411, 300);
                TXB2.Size = new Size(128, 20);
                TXB3.Visible = false;
                TXB3.Enabled = false;//TXBNOME
                TXB3.Location = new Point(545, 300);
                TXB3.Size = new Size(283, 20);
                CBB2.Visible = true;//CBBNOME
                CBB2.Enabled = true;
                CBB2.Location = new Point(545, 300);
                CBB2.Size = new Size(283, 20);
                TXB4.Visible = true;
                TXB4.Enabled = false;//TXBRAZAOSOCIAL
                TXB4.Location = new Point(834, 300);
                TXB4.Size = new Size(676, 20);
                TXB5.Visible = true;
                TXB5.Enabled = false;//TXBRUA
                TXB5.Location = new Point(411, 345);
                TXB5.Size = new Size(725, 20);
                TXB6.Visible = true;
                TXB6.Enabled = false;//TXBNUMERO
                TXB6.Location = new Point(1144, 345);
                TXB6.Size = new Size(103, 20);
                TXB7.Visible = true;
                TXB7.Enabled = false;//TXBCOMPLEMENTO
                TXB7.Location = new Point(1254, 345);
                TXB7.Size = new Size(255, 20);
                TXB8.Visible = true;
                TXB8.Enabled = false;//TXBBAIRRO
                TXB8.Location = new Point(411, 390);
                TXB8.Size = new Size(519, 20);
                TXB9.Visible = true;
                TXB9.Enabled = false;//TXBCIDADE
                TXB9.Location = new Point(939, 390);
                TXB9.Size = new Size(513, 20);
                TXB10.Visible = true;
                TXB10.Enabled = false;//TXBESTADO
                TXB10.Location = new Point(1461, 390);
                TXB10.Size = new Size(49, 20);
                TXB11.Visible = true;
                TXB11.Enabled = false;//TXBCNPJ
                TXB11.Location = new Point(411, 435);
                TXB11.Size = new Size(364, 20);
                TXB12.Visible = true;
                TXB12.Enabled = false;//TXBINSCREST
                TXB12.Location = new Point(783, 435);
                TXB12.Size = new Size(358, 20);
                TXB13.Visible = true;
                TXB13.Enabled = false;//INSCRMUN
                TXB13.Location = new Point(1149, 435);
                TXB13.Size = new Size(360, 20);

                PESQUISARVISIVEL();
                DATACLIENTE();
                DATAHORA();
                LIMPARTXBCBB();
                ATUALIZACBBNOME();
                AsteriscosFalse();
                DDDFALSE();
                TELEFONEFALSE();
                TIPOFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                SEXOFALSE();
                BotoesInicialCadastroAtualizarExcluir();
                CENTRODECUSTOOCULTO();

                CBB2.Focus();//CBBNOME
            }
            if (CBB1.Text == "EXCLUIR")//CBBCLIENTE
            {
                label1.Visible = false;

                label25.Visible = true;

                label2.Visible = true;
                label2.Text = "EXCLUIR CLIENTE";
                label2.ForeColor = Color.Red;
                label2.Location = new Point(500, 50);
                label2.Size = new Size(900, 100);
                label2.Font = new Font("arial black", 48);

                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;

                TXB1.Visible = false;//TXBCODIGO
                TXB2.Visible = true;
                TXB2.Enabled = false;//TXBCEP
                TXB2.Location = new Point(411, 300);
                TXB2.Size = new Size(128, 20);
                TXB3.Visible = false;
                TXB3.Enabled = false;//TXBNOME
                TXB3.Location = new Point(545, 300);
                TXB3.Size = new Size(283, 20);
                CBB2.Visible = true;
                CBB2.Enabled = true;//CBBNOME
                CBB2.Location = new Point(545, 300);
                CBB2.Size = new Size(283, 20);
                TXB4.Visible = true;
                TXB4.Enabled = false;//TXBRAZAOSOCIAL
                TXB4.Location = new Point(834, 300);
                TXB4.Size = new Size(676, 20);
                TXB5.Visible = true;
                TXB5.Enabled = false;//TXBRUA
                TXB5.Location = new Point(411, 345);
                TXB5.Size = new Size(725, 20);
                TXB6.Visible = true;
                TXB6.Enabled = false;//TXBNUMERO
                TXB6.Location = new Point(1144, 345);
                TXB6.Size = new Size(103, 20);
                TXB7.Visible = true;
                TXB7.Enabled = false;//TXBCOMPLEMENTO
                TXB7.Location = new Point(1254, 345);
                TXB7.Size = new Size(255, 20);
                TXB8.Visible = true;
                TXB8.Enabled = false;//TXBBAIRRO
                TXB8.Location = new Point(411, 390);
                TXB8.Size = new Size(519, 20);
                TXB9.Visible = true;
                TXB9.Enabled = false;//TXBCIDADE
                TXB9.Location = new Point(939, 390);
                TXB9.Size = new Size(513, 20);
                TXB10.Visible = true;
                TXB10.Enabled = false;//TXBESTADO
                TXB10.Location = new Point(1461, 390);
                TXB10.Size = new Size(49, 20);
                TXB11.Visible = true;
                TXB11.Enabled = false;//TXBCNPJ
                TXB11.Location = new Point(411, 435);
                TXB11.Size = new Size(364, 20);
                TXB12.Visible = true;
                TXB12.Enabled = false;//TXBINSCREST
                TXB12.Location = new Point(783, 435);
                TXB12.Size = new Size(358, 20);
                TXB13.Visible = true;
                TXB13.Enabled = false;//INSCRMUN
                TXB13.Location = new Point(1149, 435);
                TXB13.Size = new Size(360, 20);

                PESQUISARVISIVEL();
                DATACLIENTE();
                DATAHORA();
                LIMPARTXBCBB();
                ATUALIZACBBNOME();
                AsteriscosFalse();
                DDDFALSE();
                TELEFONEFALSE();
                TIPOFALSE();
                CONTATOFALSE();
                EMAILFALSE();
                SEXOFALSE();
                BotoesInicialCadastroAtualizarExcluir();
                INSERIROCULTO();
                CENTRODECUSTOOCULTO();

                CBB2.Focus();//CBBNOME
            }
        }

        // CAMPOS DO FORMULÁRIO CADASTRAR OCULTOS
        public void DadosDoClienteParaCadastroFalse()
        {
            TXB1.Visible = false;//TXBCODIGO
            TXB2.Visible = false;//TXBCEP
            TXB3.Visible = false;//TXBNOME
            CBB2.Visible = false;//CBBNOME
            TXB4.Visible = false;//TXBRAZAOSOCIAL
            TXB5.Visible = false;//TXBRUA
            TXB6.Visible = false;//TXBNUMERO
            TXB7.Visible = false;//TXBCOMPLEMENTO
            TXB8.Visible = false;//TXBBAIRRO
            TXB9.Visible = false;//TXBCIDADE
            TXB10.Visible = false;//TXBESTADO
            TXB11.Visible = false;//TXBCNPJ
            TXB12.Visible = false;//TXBINSCREST
            TXB13.Visible = false;//INSCRMUN
        }
        // LABELS VISÍVEIS - ASTERISCOS
        public void Asteriscos()
        {
            label25.Visible = true;
            label25.Location = new Point(30, 1033);
            label26.Visible = true;
            label26.Location = new Point(-7, 1018);
            label27.Visible = true;
            label27.Location = new Point(686, 270);
            label28.Visible = true;
            label28.Location = new Point(910, 270);
            label29.Visible = true;
            label29.Location = new Point(1190, 314);
            label30.Visible = true;
            label30.Location = new Point(436, 405);
            label31.Visible = true;
            label31.Location = new Point(430, 270);
        }

        // LABELS OCULTOS - ASTERISCOS
        public void AsteriscosFalse()
        {
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
        }

        // LABELS VISÍVEIS NOS FORMULÁRIOS
        public void LABELFORMULARIOSVISIVEIS()
        {
            if (label2.Text == "CLIENTE" || label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE" || label2.Text == "EXCLUIR CLIENTE")
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
                label15.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
            }
            if (label2.Text == "PAPEIS" || label2.Text == "CADASTRAR PAPEIS" || label2.Text == "ENTRADA PAPEIS" || label2.Text == "SAÍDA PAPEIS")
            {
                label3.Visible = true;
                label3.Text = "MATÉRIA PRIMA";
                label3.Location = new Point(411, 281);
                label4.Visible = true;
                label4.Text = "QUANT. FOLHAS";
                label4.Location = new Point(918, 281);
                label5.Visible = true;
                label5.Text = "VALOR";
                label5.Location = new Point(1039, 281);
                label6.Visible = true;
                label6.Text = "ESTOQUE MÍNIMO";
                label6.Location = new Point(1158, 281);
                label7.Visible = true;
                label7.Text = "VALOR FOLHAS";
                label7.Location = new Point(1278, 281);
                label8.Visible = true;
                label8.Text = "QUANT. ATUAL";
                label8.Location = new Point(1398, 281);
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

            }
            if (label2.Text == "FUNCIONÁRIOS" || label2.Text == "CADASTRAR FUNCIONÁRIO")
            {
                label3.Visible = true;
                label3.Text = "ADMISSÃO";
                label3.Location = new Point(411, 281);
                label4.Visible = true;
                label4.Text = "NOME";
                label4.Location = new Point(497, 281);
                label5.Visible = true;
                label5.Text = "CARGO";
                label5.Location = new Point(1054, 281);
                label6.Visible = true;
                label6.Text = "SALÁRIO";
                label6.Location = new Point(1325, 281);
                label7.Visible = true;
                label7.Text = "ENCARGOS";
                label7.Location = new Point(1441, 281);
                label8.Visible = true;
                label8.Text = "CPF";
                label8.Location = new Point(411, 326);
                label9.Visible = true;
                label9.Text = "RG";
                label9.Location = new Point(528, 326);
                label10.Visible = true;
                label10.Text = "CNH";
                label10.Location = new Point(645, 326);
                label11.Visible = true;
                label11.Text = "CERT. RESERVISTA";
                label11.Location = new Point(761, 326);
                label12.Visible = true;
                label12.Text = "CEP";
                label12.Location = new Point(878, 326);
                label13.Visible = true;
                label13.Text = "RUA";
                label13.Location = new Point(995, 326);
                label14.Visible = true;
                label14.Text = "BAIRRO";
                label14.Location = new Point(411, 371);
                label15.Visible = true;
                label15.Text = "CIDADE";
                label15.Location = new Point(609, 371);
                label16.Visible = true;
                label16.Text = "UF";
                label16.Location = new Point(774, 371);
                label17.Visible = true;
                label17.Text = "NÚMERO";
                label17.Location = new Point(830, 371);
                label18.Visible = true;
                label18.Text = "COMPLEMENTO";
                label18.Location = new Point(905, 371);
                label19.Visible = true;
                label19.Text = "CENTRO DE CUSTO";
                label19.Location = new Point(1070, 371);
                label20.Visible = true;
                label20.Text = "BONIFICAÇÃO";
                label20.Location = new Point(1325, 371);
                label21.Visible = true;
                label21.Text = "TOTAL";
                label21.Location = new Point(1420, 371);
                label22.Visible = true;
                label22.Text = "TEMPO";
                label22.Location = new Point(1400, 500);
                label23.Visible = true;
                label23.Text = "DEMISSÃO";
                label23.Location = new Point(1315, 500);
            }
            if (label2.Text == "CENTRO DE CUSTO" || label2.Text == "CADASTRAR CENTRO DE CUSTO")
            {
                label3.Text = "DESCRIÇÃO";
                label3.Visible = true;
                label3.Location = new Point(521, 234);
                label4.Text = "TIPO";
                label4.Visible = true;
                label4.Location = new Point(885, 234);
                label5.Text = "NHP";
                label5.Visible = true;
                label5.Location = new Point(1012, 234);
                label6.Text = "SUBSIDIAR";
                label6.Visible = true;
                label6.Location = new Point(1078, 234);
                label7.Text = "TURNO";
                label7.Visible = true;
                label7.Location = new Point(1184, 234);
                label8.Text = "TIPO DE HORA";
                label8.Visible = true;
                label8.Location = new Point(1240, 234);
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

            }
        }

        // LABELS OCULTOS NOS FORMULÁRIOS
        public void LabelsDadosDoClienteParaCadastrarAtualizarExcluirFalse()
        {
            if (label2.Text == "PAPEIS" || label2.Text == "CADASTRAR PAPEIS" || label2.Text == "ATUALIZAR PAPEIS" || label2.Text == "EXCLUIR PAPEIS")
            {
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
            }
        }

        // BOTÕES NO INÍCIO DOS FORMULÁRIOS CLIENTE
        public void BotoesInicialCadastroAtualizarExcluir()
        {
            if (label2.Text == "CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 521);
                BTN4.Size = new Size(445, 54);

                BTNCADATUEXC();
                BTN3.Text = "FORMULÁRIO";
                BTN3.ForeColor = Color.Black;
                BTN3.Location = new Point(411, 521);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 521);
                BTN4.Size = new Size(445, 54);

                BTNCADATUEXC();
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 521);

                INSERIRVISIVEL();
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 521);
                BTN4.Size = new Size(445, 54);

                BTNCADATUEXC();
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 521);

                INSERIRVISIVEL();
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 476);
                BTN4.Size = new Size(445, 54);

                BTNCADATUEXC();
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 476);
            }
        }

        // EXIBE AS LABELS CONTATO
        public void LabelsContato()
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

        // OCULTA AS LABELS CONTATO
        public void LabelsContatoFalse()
        {
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO1
        public void BotaoCadastroAtualizarContato1()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 566);
                BTN4.Size = new Size(445, 54);

                BTN1.Visible = true;
                BTN1.Location = new Point(411, 521);
                BTN1.Size = new Size(1099, 25);

            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 566);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 566);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 521);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 521);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO2
        public void BotaoCadastroAtualizarContato2()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 611);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 611);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = true;
                BTN1.Location = new Point(411, 566);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 611);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 611);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 566);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 566);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO3
        public void BotaoCadastroAtualizarContato3()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 656);
                BTN4.Size = new Size(445, 54);

                BTN1.Visible = true;
                BTN1.Location = new Point(411, 611);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 656);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 656);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 611);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 611);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO4
        public void BotaoCadastroAtualizarContato4()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 701);
                BTN4.Size = new Size(445, 54);

                BTN1.Visible = true;
                BTN1.Location = new Point(411, 656);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 701);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 701);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 656);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 656);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO5
        public void BotaoCadastroAtualizarContato5()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 746);
                BTN4.Size = new Size(445, 54);

                BTN1.Visible = true;
                BTN1.Location = new Point(411, 701);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 746);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 746);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 701);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 701);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO6
        public void BotaoCadastroAtualizarContato6()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 791);
                BTN4.Size = new Size(445, 54);

                BTN1.Visible = true;
                BTN1.Location = new Point(411, 746);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 791);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 791);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 746);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 746);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO7
        public void BotaoCadastroAtualizarContato7()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 836);
                BTN4.Size = new Size(445, 54);

                BTN1.Visible = true;
                BTN1.Location = new Point(411, 791);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 836);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 836);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 791);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 791);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }

        // POSIÇÃO DOS BOTÕES NO CONTATO8
        public void BotaoCadastroAtualizarContato8()
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 836);
                BTN4.Size = new Size(445, 54);

                BTN1.Visible = false;
                BTN1.Location = new Point(411, 836);
                BTN1.Size = new Size(1099, 25);
            }
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 836);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                BTN3.Visible = true;
                BTN3.Text = "ATUALIZAR";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 836);
                BTN3.Size = new Size(445, 54);
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                BTNCANCELAR();
                BTN4.Location = new Point(1066, 836);
                BTN4.Size = new Size(445, 54);

                BTN3.Visible = true;
                BTN3.Text = "EXCLUIR";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 836);
                BTN3.Size = new Size(445, 54);

                BTN1.Visible = false;
            }
        }
        // EXIBE A HORA E DATA NO LABEL
        public void DATAHORA()
        {
            DateTime DATA;
            DATA = DateTime.Now;
            LBLDATA.Text = DATA.ToString();
        }

        // CHAMA O FORMULÁRIO LOGOTIPO
        private void PADRAO_Load(object sender, EventArgs e)
        {
            LOGOTIPO();
        }

        // CRIA O FORMULÁRIO LOGOTIPO
        public void LOGOTIPO()
        {
            label1.Visible = true;
            label1.Text = "LOGOTIPO";
            label1.Location = new Point(660, 450);
            label1.Size = new Size(612, 136);
            label1.Font = new Font("arial black", 72);

            CBBOX2FALSE();

            DGV1OCULTO();

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
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;

            BTN1.Visible = false;
            BTN3.Visible = false;
            BTN4.Visible = false;

            PESQUISAROCULTO();

            MNS1();
        }

        // EXECUTA QUANDO O CBBCLIENTE E SELECIONADO
        /*   public void CADASTRARATUALIZAREXCLUIR()
           {

               if (CBBCLIENTE.Text == "CADASTRAR")
               {


                   PESQUISAROCULTO();
                   LIMPARTXBCBB();
                   TXBVISIVEIS();
                   DDDFALSE();
                   TELEFONEFALSE();
                   SEXOFALSE();
                   CONTATOFALSE();
                   TIPOFALSE();
                   EMAILFALSE();
                   Asteriscos();
                   BotoesInicialCadastroAtualizarExcluir();

                   TXBCEP.Focus();
               }

               if (CBBCLIENTE.Text == "ATUALIZAR")
               {


                   TXBVISIVEIS();
                   PESQUISARVISIVEL();
                   INSERIRVISIVEL();
                   ATUALIZACBB();
                   LIMPARTXBCBB();
                  // DadosDoClienteParaExcluir();
                   AsteriscosFalse();
                   DDDFALSE();
                   TELEFONEFALSE();
                   SEXOFALSE();
                   CONTATOFALSE();
                   TIPOFALSE();
                   EMAILFALSE();
                   BotoesInicialCadastroAtualizarExcluir();

                   CBBNOME.Focus();
               }
               if (CBBCLIENTE.Text == "EXCLUIR")
               {


                   PESQUISARVISIVEL();
                   ATUALIZACBB();
                   LIMPARTXBCBB();
                  // DadosDoClienteParaExcluir();
                   AsteriscosFalse();
                   INSERIROCULTO();
                   BotoesInicialCadastroAtualizarExcluir();
                   BotaoCadastroAtualizarContato1();
                   BotaoCadastroAtualizarContato2();
                   BotaoCadastroAtualizarContato3();
                   BotaoCadastroAtualizarContato4();
                   BotaoCadastroAtualizarContato5();
                   BotaoCadastroAtualizarContato6();
                   BotaoCadastroAtualizarContato7();
                   BotaoCadastroAtualizarContato8();
                   DDDFALSE();
                   TELEFONEFALSE();
                   SEXOFALSE();
                   CONTATOFALSE();
                   TIPOFALSE();
                   EMAILFALSE();
                   BotoesInicialCadastroAtualizarExcluir();

                   CBBNOME.Focus();
               }
           } */

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO1
        public void TamanhoePosicaoContato1()
        {
            CBB3.Visible = true;
            CBB3.Enabled = true;//CBBTIPO1
            CBB3.Location = new Point(411, 480);
            CBB3.Size = new Size(78, 20);
            TXB14.Visible = true;
            TXB14.Enabled = true;//TXBDDD1
            TXB14.Location = new Point(497, 480);
            TXB14.Size = new Size(78, 20);
            TXB15.Visible = true;
            TXB15.Enabled = true;//TXBTELEFONE1
            TXB15.Location = new Point(583, 480);
            TXB15.Size = new Size(136, 20);
            TXB16.Visible = true;
            TXB16.Enabled = true;//TXBCONTATO1
            TXB16.Location = new Point(727, 480);
            TXB16.Size = new Size(342, 20);
            CBB4.Visible = true;
            CBB4.Enabled = true;//CBBSEXO1
            CBB4.Location = new Point(1077, 480);
            CBB4.Size = new Size(50, 20);
            TXB17.Visible = true;
            TXB17.Enabled = true;//EMAIL1
            TXB17.Location = new Point(1136, 480);
            TXB17.Size = new Size(373, 20);

            CBB3.Focus();//CBBTIPO1
        }

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO2
        public void TamanhoePosicaoContato2()
        {
            CBB5.Visible = true;
            CBB5.Enabled = true;//CBBTIPO2
            CBB5.Location = new Point(411, 525);
            CBB5.Size = new Size(78, 20);
            TXB18.Visible = true;
            TXB18.Enabled = true;//TXBDDD2
            TXB18.Location = new Point(497, 525);
            TXB18.Size = new Size(78, 20);
            TXB19.Visible = true;
            TXB19.Enabled = true;//TELEFONE2
            TXB19.Location = new Point(583, 525);
            TXB19.Size = new Size(136, 20);
            TXB20.Visible = true;
            TXB20.Enabled = true;//TXBCONTATO2
            TXB20.Location = new Point(727, 525);
            TXB20.Size = new Size(342, 20);
            CBB6.Visible = true;
            CBB6.Enabled = true;//CBBSEXO2
            CBB6.Location = new Point(1077, 525);
            CBB6.Size = new Size(50, 20);
            TXB21.Visible = true;
            TXB21.Enabled = true;//TXBEMAIL2
            TXB21.Location = new Point(1136, 525);
            TXB21.Size = new Size(373, 20);

            CBB5.Focus();//CBBTIPO2
        }

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO3
        public void TamanhoePosicaoContato3()
        {
            CBB7.Visible = true;
            CBB7.Enabled = true;//CBBTIPO3
            CBB7.Location = new Point(411, 570);
            CBB7.Size = new Size(78, 20);
            TXB22.Visible = true;
            TXB22.Enabled = true;//TXBDDD3
            TXB22.Location = new Point(497, 570);
            TXB22.Size = new Size(78, 20);
            TXB23.Visible = true;
            TXB23.Enabled = true;//TXBTELEFONE3
            TXB23.Location = new Point(583, 570);
            TXB23.Size = new Size(136, 20);
            TXB24.Visible = true;
            TXB24.Enabled = true;//TXBCONTATO3
            TXB24.Location = new Point(727, 570);
            TXB24.Size = new Size(342, 20);
            CBB8.Visible = true;
            CBB8.Enabled = true;//CBBSEXO3
            CBB8.Location = new Point(1077, 570);
            CBB8.Size = new Size(50, 20);
            TXB25.Visible = true;
            TXB25.Enabled = true;//TXBEMAIL3
            TXB25.Location = new Point(1136, 570);
            TXB25.Size = new Size(373, 20);

            CBB7.Focus();//CBBTIPO3
        }

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO4
        public void TamanhoePosicaoContato4()
        {
            CBB9.Visible = true;
            CBB9.Enabled = true;//CBBTIPO4
            CBB9.Location = new Point(411, 615);
            CBB9.Size = new Size(78, 20);
            TXB26.Visible = true;
            TXB26.Enabled = true;//TXBDDD4
            TXB26.Location = new Point(497, 615);
            TXB26.Size = new Size(78, 20);
            TXB27.Visible = true;
            TXB27.Enabled = true;//TXBTELEFONE4
            TXB27.Location = new Point(583, 615);
            TXB27.Size = new Size(136, 20);
            TXB28.Visible = true;
            TXB28.Enabled = true;//TXBCONTATO4
            TXB28.Location = new Point(727, 615);
            TXB28.Size = new Size(342, 20);
            CBB10.Visible = true;
            CBB10.Enabled = true;//CBBSEXO4
            CBB10.Location = new Point(1077, 615);
            CBB10.Size = new Size(50, 20);
            TXB29.Visible = true;
            TXB29.Enabled = true;//TXBEMAIL4
            TXB29.Location = new Point(1136, 615);
            TXB29.Size = new Size(373, 20);

            CBB9.Focus();//CBBTIPO4
        }

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO5
        public void TamanhoePosicaoContato5()
        {
            CBB11.Visible = true;
            CBB11.Enabled = true;//CBBTIPO5
            CBB11.Location = new Point(411, 660);
            CBB11.Size = new Size(78, 20);
            TXB30.Visible = true;
            TXB30.Enabled = true;//TXBDDD5
            TXB30.Location = new Point(497, 660);
            TXB30.Size = new Size(78, 20);
            TXB31.Visible = true;
            TXB31.Enabled = true;//TXBTELEFONE5
            TXB31.Location = new Point(583, 660);
            TXB31.Size = new Size(136, 20);
            TXB32.Visible = true;
            TXB32.Enabled = true;//TXBCONTATO5
            TXB32.Location = new Point(727, 660);
            TXB32.Size = new Size(342, 20);
            CBB12.Visible = true;
            CBB12.Enabled = true;//CBBSEXO5
            CBB12.Location = new Point(1077, 660);
            CBB12.Size = new Size(50, 20);
            TXB33.Visible = true;
            TXB33.Enabled = true;//TXBEMAIL5
            TXB33.Location = new Point(1136, 660);
            TXB33.Size = new Size(373, 20);

            CBB11.Focus();//CBBTIPO5
        }

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO6
        public void TamanhoePosicaoContato6()
        {
            CBB13.Visible = true;
            CBB13.Enabled = true;//CBBTIPO6
            CBB13.Location = new Point(411, 705);
            CBB13.Size = new Size(78, 20);
            TXB34.Visible = true;
            TXB34.Enabled = true;//TXBDDD6
            TXB34.Location = new Point(497, 705);
            TXB34.Size = new Size(78, 20);
            TXB35.Visible = true;
            TXB35.Enabled = true;//TXBTELEFONE6
            TXB35.Location = new Point(583, 705);
            TXB35.Size = new Size(136, 20);
            TXB36.Visible = true;
            TXB36.Enabled = true;//TXBCONTATO6
            TXB36.Location = new Point(727, 705);
            TXB36.Size = new Size(342, 20);
            CBB14.Visible = true;
            CBB14.Enabled = true;//CBBSEXO6
            CBB14.Location = new Point(1077, 705);
            CBB14.Size = new Size(50, 20);
            TXB37.Visible = true;
            TXB37.Enabled = true;//TXBEMAIL6
            TXB37.Location = new Point(1136, 705);
            TXB37.Size = new Size(373, 20);

            CBB13.Focus();//CBBTIPO6
        }

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO7
        public void TamanhoePosicaoContato7()
        {

            CBB15.Visible = true;
            CBB15.Enabled = true;//CBBTIPO7
            CBB15.Location = new Point(411, 750);
            CBB15.Size = new Size(78, 20);
            TXB38.Visible = true;
            TXB38.Enabled = true;//TXBDDD7
            TXB38.Location = new Point(497, 750);
            TXB38.Size = new Size(78, 20);
            TXB39.Visible = true;
            TXB39.Enabled = true;//TXBTELEFONE7
            TXB39.Location = new Point(583, 750);
            TXB39.Size = new Size(136, 20);
            TXB40.Visible = true;
            TXB40.Enabled = true;//TXBCONTATO7
            TXB40.Location = new Point(727, 750);
            TXB40.Size = new Size(342, 20);
            CBB16.Visible = true;
            CBB16.Enabled = true;//CBBSEXO7
            CBB16.Location = new Point(1077, 750);
            CBB16.Size = new Size(50, 20);
            TXB41.Visible = true;
            TXB41.Enabled = true;//TXBEMAIL7
            TXB41.Location = new Point(1136, 750);
            TXB41.Size = new Size(373, 20);

            CBB15.Focus();//CBBTIPO7
        }

        // TAMANHO E POSIÇÃO DOS CAMPOS CONTATO8
        public void TamanhoePosicaoContato8()
        {
            CBB17.Visible = true;
            CBB17.Enabled = true;//CBBTIPO8
            CBB17.Location = new Point(411, 795);
            CBB17.Size = new Size(78, 20);
            TXB42.Visible = true;
            TXB42.Enabled = true;//TXBDDD8
            TXB42.Location = new Point(497, 795);
            TXB42.Size = new Size(78, 20);
            TXB43.Visible = true;
            TXB43.Enabled = true;//TXBTELEFONE8
            TXB43.Location = new Point(583, 795);
            TXB43.Size = new Size(136, 20);
            TXB44.Visible = true;
            TXB44.Enabled = true;//TXBCONTATO8
            TXB44.Location = new Point(727, 795);
            TXB44.Size = new Size(342, 20);
            CBB18.Visible = true;
            CBB18.Enabled = true;//CBBSEXO8
            CBB18.Location = new Point(1077, 795);
            CBB18.Size = new Size(50, 20);
            TXB45.Visible = true;
            TXB45.Enabled = true;//TXBEMAIL8
            TXB45.Location = new Point(1136, 795);
            TXB45.Size = new Size(373, 20);

            CBB17.Focus();//CBBTIPO8
        }

        // DESABILITA CAMPOS CONTATO1
        public void TamanhoePosicaoContato1False()
        {
            CBB3.Visible = true;
            CBB3.Enabled = false;//CBBTIPO1
            CBB3.Location = new Point(411, 480);
            CBB3.Size = new Size(78, 20);
            TXB14.Visible = true;
            TXB14.Enabled = false;//TXBDDD1
            TXB14.Location = new Point(497, 480);
            TXB14.Size = new Size(78, 20);
            TXB15.Visible = true;
            TXB15.Enabled = false;//TXBTELEFONE1
            TXB15.Location = new Point(583, 480);
            TXB15.Size = new Size(136, 20);
            TXB16.Visible = true;
            TXB16.Enabled = false;//TXBCONTATO1
            TXB16.Location = new Point(727, 480);
            TXB16.Size = new Size(342, 20);
            CBB4.Visible = true;
            CBB4.Enabled = false;//CBBSEXO1
            CBB4.Location = new Point(1077, 480);
            CBB4.Size = new Size(50, 20);
            TXB17.Visible = true;
            TXB17.Enabled = false;//EMAIL1
            TXB17.Location = new Point(1136, 480);
            TXB17.Size = new Size(373, 20);

            CBB3.Focus();//CBBTIPO1
        }

        // DESABILITA CAMPOS CONTATO2
        public void TamanhoePosicaoContato2False()
        {
            CBB5.Visible = true;
            CBB5.Enabled = false; //CBBTIPO2
            CBB5.Location = new Point(411, 525);
            CBB5.Size = new Size(78, 20);
            TXB18.Visible = true;
            TXB18.Enabled = false;//TXBDDD2
            TXB18.Location = new Point(497, 525);
            TXB18.Size = new Size(78, 20);
            TXB19.Visible = true;
            TXB19.Enabled = false;//TXBTELEFONE2
            TXB19.Location = new Point(583, 525);
            TXB19.Size = new Size(136, 20);
            TXB20.Visible = true;
            TXB20.Enabled = false;//TXBCONTATO2
            TXB20.Location = new Point(727, 525);
            TXB20.Size = new Size(342, 20);
            CBB6.Visible = true;
            CBB6.Enabled = false;//CBBSEXO2
            CBB6.Location = new Point(1077, 525);
            CBB6.Size = new Size(50, 20);
            TXB21.Visible = true;
            TXB21.Enabled = false;//TXBEMAIL2
            TXB21.Location = new Point(1136, 525);
            TXB21.Size = new Size(373, 20);

            CBB5.Focus();//CBBTIPO2
        }

        // DESABILITA CAMPOS CONTATO3
        public void TamanhoePosicaoContato3False()
        {
            CBB7.Visible = true;
            CBB7.Enabled = false;//CBBTIPO3
            CBB7.Location = new Point(411, 570);
            CBB7.Size = new Size(78, 20);
            TXB22.Visible = true;
            TXB22.Enabled = false;//TXBDDD3
            TXB22.Location = new Point(497, 570);
            TXB22.Size = new Size(78, 20);
            TXB23.Visible = true;
            TXB23.Enabled = false;//TXBTELEFONE3
            TXB23.Location = new Point(583, 570);
            TXB23.Size = new Size(136, 20);
            TXB24.Visible = true;
            TXB24.Enabled = false;//TXBCONTATO3
            TXB24.Location = new Point(727, 570);
            TXB24.Size = new Size(342, 20);
            CBB8.Visible = true;
            CBB8.Enabled = false;//CBBSEXO3
            CBB8.Location = new Point(1077, 570);
            CBB8.Size = new Size(50, 20);
            TXB25.Visible = true;
            TXB25.Enabled = false;//TXBEMAIL3
            TXB25.Location = new Point(1136, 570);
            TXB25.Size = new Size(373, 20);

            CBB7.Focus();//CBBTIPO3
        }

        // DESABILITA CAMPOS CONTATO4
        public void TamanhoePosicaoContato4False()
        {
            CBB9.Visible = true;
            CBB9.Enabled = false;//CBBTIPO4
            CBB9.Location = new Point(411, 615);
            CBB9.Size = new Size(78, 20);
            TXB26.Visible = true;
            TXB26.Enabled = false;//TXBDDD4
            TXB26.Location = new Point(497, 615);
            TXB26.Size = new Size(78, 20);
            TXB27.Visible = true;
            TXB27.Enabled = false;//TXBTELEFONE4
            TXB27.Location = new Point(583, 615);
            TXB27.Size = new Size(136, 20);
            TXB28.Visible = true;
            TXB28.Enabled = false;//TXBCONTATO4
            TXB28.Location = new Point(727, 615);
            TXB28.Size = new Size(342, 20);
            CBB10.Visible = true;
            CBB10.Enabled = false;//CBBSEXO4
            CBB10.Location = new Point(1077, 615);
            CBB10.Size = new Size(50, 20);
            TXB29.Visible = true;
            TXB29.Enabled = false;//TXBEMAIL4
            TXB29.Location = new Point(1136, 615);
            TXB29.Size = new Size(373, 20);

            CBB9.Focus();//CBBTIPO4
        }

        // DESABILITA CAMPOS CONTATO5
        public void TamanhoePosicaoContato5False()
        {
            CBB11.Visible = true;
            CBB11.Enabled = false;//CBBTIPO5
            CBB11.Location = new Point(411, 660);
            CBB11.Size = new Size(78, 20);
            TXB30.Visible = true;
            TXB30.Enabled = false;//TXBDDD5
            TXB30.Location = new Point(497, 660);
            TXB30.Size = new Size(78, 20);
            TXB31.Visible = true;
            TXB31.Enabled = false;//TXBTELEFONE5
            TXB31.Location = new Point(583, 660);
            TXB31.Size = new Size(136, 20);
            TXB32.Visible = true;
            TXB32.Enabled = false;//TXBCONTATO5
            TXB32.Location = new Point(727, 660);
            TXB32.Size = new Size(342, 20);
            CBB12.Visible = true;
            CBB12.Enabled = false;//CBBSEXO5
            CBB12.Location = new Point(1077, 660);
            CBB12.Size = new Size(50, 20);
            TXB33.Visible = true;
            TXB33.Enabled = false;//TXBEMAIL5
            TXB33.Location = new Point(1136, 660);
            TXB33.Size = new Size(373, 20);

            CBB11.Focus();//CBBTIPO5
        }

        // DESABILITA CAMPOS CONTATO6
        public void TamanhoePosicaoContato6False()
        {
            CBB13.Visible = true;
            CBB13.Enabled = false;//CBBTIPO6
            CBB13.Location = new Point(411, 705);
            CBB13.Size = new Size(78, 20);
            TXB34.Visible = true;
            TXB34.Enabled = false;//TXBDDD6
            TXB34.Location = new Point(497, 705);
            TXB34.Size = new Size(78, 20);
            TXB35.Visible = true;
            TXB35.Enabled = false;//TXBTELEFONE6
            TXB35.Location = new Point(583, 705);
            TXB35.Size = new Size(136, 20);
            TXB36.Visible = true;
            TXB36.Enabled = false;//TXBCONTATO6
            TXB36.Location = new Point(727, 705);
            TXB36.Size = new Size(342, 20);
            CBB14.Visible = true;
            CBB14.Enabled = false;//CBBSEXO6
            CBB14.Location = new Point(1077, 705);
            CBB14.Size = new Size(50, 20);
            TXB37.Visible = true;
            TXB37.Enabled = false;//TXBEMAIL6
            TXB37.Location = new Point(1136, 705);
            TXB37.Size = new Size(373, 20);

            CBB13.Focus();//CBBTIPO6
        }

        // DESABILITA CAMPOS CONTATO7
        public void TamanhoePosicaoContato7False()
        {
            CBB15.Visible = true;
            CBB15.Enabled = false;//CBBTIPO7
            CBB15.Location = new Point(411, 750);
            CBB15.Size = new Size(78, 20);
            TXB38.Visible = true;
            TXB38.Enabled = false;//TXBDDD7
            TXB38.Location = new Point(497, 750);
            TXB38.Size = new Size(78, 20);
            TXB39.Visible = true;
            TXB39.Enabled = false;//TXBTELEFONE7
            TXB39.Location = new Point(583, 750);
            TXB39.Size = new Size(136, 20);
            TXB40.Visible = true;
            TXB40.Enabled = false;//TXBCONTATO7
            TXB40.Location = new Point(727, 750);
            TXB40.Size = new Size(342, 20);
            CBB16.Visible = true;
            CBB16.Enabled = false;//CBBSEXO7
            CBB16.Location = new Point(1077, 750);
            CBB16.Size = new Size(50, 20);
            TXB41.Visible = true;
            TXB41.Enabled = false;//TXBEMAIL7
            TXB41.Location = new Point(1136, 750);
            TXB41.Size = new Size(373, 20);

            CBB15.Focus();//CBBTIPO7
        }

        // DESABILITA CAMPOS CONTATO8
        public void TamanhoePosicaoContato8False()
        {
            CBB17.Visible = true;
            CBB17.Enabled = false;//CBBTIPO8
            CBB17.Location = new Point(411, 795);
            CBB17.Size = new Size(78, 20);
            TXB42.Visible = true;
            TXB42.Enabled = false;//TXBDDD8
            TXB42.Location = new Point(497, 795);
            TXB42.Size = new Size(78, 20);
            TXB43.Visible = true;
            TXB43.Enabled = false;//TXBTELEFONE8
            TXB43.Location = new Point(583, 795);
            TXB43.Size = new Size(136, 20);
            TXB44.Visible = true;
            TXB44.Enabled = false;//TXBCONTATO8
            TXB44.Location = new Point(727, 795);
            TXB44.Size = new Size(342, 20);
            CBB18.Visible = true;
            CBB18.Enabled = false;//CBBSEXO8
            CBB18.Location = new Point(1077, 795);
            CBB18.Size = new Size(50, 20);
            TXB45.Visible = true;
            TXB45.Enabled = false;//TXBEMAIL8
            TXB45.Location = new Point(1136, 795);
            TXB45.Size = new Size(373, 20);

            CBB17.Focus();//CBBTIPO8
        }

        // BOTÃO INSERIR CADASTRAR/ATUALIZAR CLIENTE
        private void BTNINSERIR_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE" || label2.Text == "ATUALIZAR CLIENTE")
            {
                if (TXB3.Text != "" || CBB2.Text != "")//TXBNOME //CBBNOME
                {
                    try
                    {
                        TamanhoePosicaoContato1();
                        BotaoCadastroAtualizarContato1();

                        if (TXB16.Text != "")//TXBCONTATO1
                        {
                            TamanhoePosicaoContato2();
                            BotaoCadastroAtualizarContato2();
                        }
                        if (TXB20.Text != "")//TXBCONTATO2
                        {
                            TamanhoePosicaoContato3();
                            BotaoCadastroAtualizarContato3();
                        }
                        if (TXB24.Text != "")//TXBCONTATO3
                        {
                            TamanhoePosicaoContato4();
                            BotaoCadastroAtualizarContato4();
                        }
                        if (TXB28.Text != "")//TXBCONTATO4
                        {
                            TamanhoePosicaoContato5();
                            BotaoCadastroAtualizarContato5();
                        }
                        if (TXB32.Text != "")//TXBCONTATO5
                        {
                            TamanhoePosicaoContato6();
                            BotaoCadastroAtualizarContato6();
                        }
                        if (TXB36.Text != "")//TXBCONTATO6
                        {
                            TamanhoePosicaoContato7();
                            BotaoCadastroAtualizarContato7();
                        }
                        if (TXB40.Text != "")//TXBCONTATO7
                        {
                            TamanhoePosicaoContato8();
                            BotaoCadastroAtualizarContato8();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        // POSIÇÃO BOTÃO CANCELAR - CADASTRAR/ATUALIZAR/EXCLUIR
        private void BTNCANCELA_Click(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR CLIENTE")
            {
                DATAHORA();
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

                CBB1.Focus();//CBBCLIENTE
            }
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                DATAHORA();
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
                CONTATOSATUALIZAR();

                TXB2.Enabled = false;//TXBCEP
                TXB6.Enabled = false;//TXBNUMERO
                TXB7.Enabled = false;//TXBCOMPLEMENTO
                TXB12.Enabled = false;//TXBINSCREST
                TXB13.Enabled = false;//INSCRMUN

                CBB2.Visible = true;
                CBB2.Enabled = false;//CBBNOME
                CBB1.Focus();//CBBCLIENTE
            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                DATAHORA();
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
                CONTATOSEXCLUIR();

                TXB2.Visible = true;
                TXB2.Enabled = false;//TXBCEP

                CBB2.Visible = true;
                CBB2.Enabled = false;//CBBNOME
                CBB1.Focus();//CBBCLIENTE
            }
            if (CBB1.Text == "CADASTRAR" || CBB1.Text == "ENTRADA" || CBB1.Text == "SAÍDA")
            {
                LIMPACAMPOSCADASTRARPAPEIS();
                TXBCADASTROPAPELDESABILITADO();
                CBB2.Visible = false;
            }

        }

        // BOTÃO CADASTRAR/ATUALIZAR/EXCLUIR
        public void BTNCADAUTEXC_Click(object sender, EventArgs e)
        {
            // CADASTRO - BOTÃO CADASTRAR
            if (BTN3.Text == "CADASTRAR")
            {
                try
                {
                    DATAHORA();

                    MySqlConnection CONEXAOCADASTRARCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAOCADASTRARCLIENTE.Open();
                    MySqlCommand COMANDOCADASTRARCLIENTE = new MySqlCommand("insert into CLIENTE(NOME, RAZAOSOCIAL, DIAHORA, CNPJ, INSCREST, INSCRMUN, RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP, CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3, CONTATO4, SEXO4, EMAIL4, CONTATO5, SEXO5, EMAIL5, CONTATO6, SEXO6, EMAIL6, CONTATO7, SEXO7, EMAIL7, CONTATO8, SEXO8, EMAIL8, TIPO1, DDD1, TELEFONE1, TIPO2, DDD2, TELEFONE2, TIPO3, DDD3, TELEFONE3, TIPO4, DDD4, TELEFONE4, TIPO5, DDD5, TELEFONE5, TIPO6, DDD6, TELEFONE6, TIPO7, DDD7, TELEFONE7, TIPO8, DDD8, TELEFONE8) values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", CONEXAOCADASTRARCLIENTE);
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@NOME", MySqlDbType.VarChar, 50).Value = TXB3.Text;//TXBNOME
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@RAZAOSOCIAL", MySqlDbType.VarChar, 100).Value = TXB4.Text;//TXBRAZAOSOCIAL
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DIAHORA", MySqlDbType.VarChar, 50).Value = LBLDATA.Text;
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CNPJ", MySqlDbType.VarChar, 18).Value = TXB11.Text;//TXBCNPJ
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@INSCREST", MySqlDbType.VarChar, 30).Value = TXB12.Text;//TXBINSCREST
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@INSCRMUN", MySqlDbType.VarChar, 30).Value = TXB13.Text;//TXBINSCRMUN
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@RUA", MySqlDbType.VarChar, 150).Value = TXB5.Text;//TXBRUA
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@NUMERO", MySqlDbType.VarChar, 10).Value = TXB6.Text;//TXBNUMERO
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@COMPLEMENTO", MySqlDbType.VarChar, 50).Value = TXB7.Text;//TXBCOMPLEMENTO
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@BAIRRO", MySqlDbType.VarChar, 50).Value = TXB8.Text;//TXBBAIRRO
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CIDADE", MySqlDbType.VarChar, 50).Value = TXB9.Text;//TXBCIDADE
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@ESTADO", MySqlDbType.VarChar, 2).Value = TXB10.Text;//TXBESTADO
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = TXB2.Text;//TXBCEP
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO1", MySqlDbType.VarChar, 100).Value = TXB16.Text;//TXBCONTATO1
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO1", MySqlDbType.VarChar, 1).Value = CBB4.Text;//CBBSEXO1
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL1", MySqlDbType.VarChar, 100).Value = TXB17.Text;//TXBEMAIL1
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO2", MySqlDbType.VarChar, 100).Value = TXB20.Text;//TXBCONTATO2
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO2", MySqlDbType.VarChar, 1).Value = CBB6.Text;//CBBSEXO2
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL2", MySqlDbType.VarChar, 100).Value = TXB21.Text;//TXBEMAIL2
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO3", MySqlDbType.VarChar, 100).Value = TXB24.Text;//TXBCONTATO3
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO3", MySqlDbType.VarChar, 1).Value = CBB8.Text;//CBBSEXO3
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL3", MySqlDbType.VarChar, 100).Value = TXB25.Text;//TXBEMAIL3
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO4", MySqlDbType.VarChar, 100).Value = TXB28.Text;//TXBCONTATO4
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO4", MySqlDbType.VarChar, 1).Value = CBB10.Text;//CBBSEXO4
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL4", MySqlDbType.VarChar, 100).Value = TXB29.Text;//TXBEMAIL4
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO5", MySqlDbType.VarChar, 100).Value = TXB32.Text;//TXBCONTATO5
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO5", MySqlDbType.VarChar, 1).Value = CBB12.Text;//CBBSEXO5
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL5", MySqlDbType.VarChar, 100).Value = TXB33.Text;//TXBEMAIL5
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO6", MySqlDbType.VarChar, 100).Value = TXB36.Text;//TXBCONTATO6
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO6", MySqlDbType.VarChar, 1).Value = CBB14.Text;//CBBSEXO6
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL6", MySqlDbType.VarChar, 100).Value = TXB37.Text;//TXBEMAIL6
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO7", MySqlDbType.VarChar, 100).Value = TXB40.Text;//TXBCONTATO7
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO7", MySqlDbType.VarChar, 1).Value = CBB16.Text;//CBBSEXO7
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL7", MySqlDbType.VarChar, 100).Value = TXB41.Text;//TXBEMAIL7
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@CONTATO8", MySqlDbType.VarChar, 100).Value = TXB44.Text;//TXBCONTATO8
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@SEXO8", MySqlDbType.VarChar, 1).Value = CBB18.Text;//CBBSEXO8
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@EMAIL8", MySqlDbType.VarChar, 100).Value = TXB45.Text;//TXBEMAIL8
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO1", MySqlDbType.VarChar, 6).Value = CBB3.Text;//CBBTIPO1
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD1", MySqlDbType.VarChar, 4).Value = TXB14.Text;//TXBDDD1
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE1", MySqlDbType.VarChar, 10).Value = TXB15.Text;//TXBTELEFONE1
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO2", MySqlDbType.VarChar, 6).Value = CBB5.Text;//CBBTIPO2
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD2", MySqlDbType.VarChar, 4).Value = TXB18.Text;//TXBDDD2
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE2", MySqlDbType.VarChar, 10).Value = TXB19.Text;//TXBTELEFONE2
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO3", MySqlDbType.VarChar, 6).Value = CBB7.Text;//CBBTIPO3
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD3", MySqlDbType.VarChar, 4).Value = TXB22.Text;//TXBDDD3
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE3", MySqlDbType.VarChar, 10).Value = TXB23.Text;//TXBTELEFONE3
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO4", MySqlDbType.VarChar, 6).Value = CBB9.Text;//CBBTIPO4
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD4", MySqlDbType.VarChar, 4).Value = TXB26.Text;//TXBDDD4
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE4", MySqlDbType.VarChar, 10).Value = TXB27.Text;//TXBTELEFONE4
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO5", MySqlDbType.VarChar, 6).Value = CBB11.Text;//CBBTIPO5
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD5", MySqlDbType.VarChar, 4).Value = TXB30.Text;//TXBDDD5
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE5", MySqlDbType.VarChar, 10).Value = TXB31.Text;//TXBTELEFONE5
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO6", MySqlDbType.VarChar, 6).Value = CBB13.Text;//CBBTIPO6
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD6", MySqlDbType.VarChar, 4).Value = TXB34.Text;//TXBDDD6
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE6", MySqlDbType.VarChar, 10).Value = TXB35.Text;//TXBTELEFONE6
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO7", MySqlDbType.VarChar, 6).Value = CBB15.Text;//CBBTIPO7
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD7", MySqlDbType.VarChar, 4).Value = TXB38.Text;//TXBDDD7
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE7", MySqlDbType.VarChar, 10).Value = TXB39.Text;//TXBTELEFONE7
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TIPO8", MySqlDbType.VarChar, 6).Value = CBB17.Text;//CBBTIPO8
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@DDD8", MySqlDbType.VarChar, 4).Value = TXB42.Text;//TXBDDD8
                    COMANDOCADASTRARCLIENTE.Parameters.Add("@TELEFONE8", MySqlDbType.VarChar, 10).Value = TXB43.Text;//TXBTELEFONE8

                    COMANDOCADASTRARCLIENTE.ExecuteNonQuery();
                    CONEXAOCADASTRARCLIENTE.Close();

                    BotoesInicialCadastroAtualizarExcluir();

                    LabelsContatoFalse();

                    DDDFALSE();
                    TELEFONEFALSE();
                    CONTATOFALSE();
                    EMAILFALSE();
                    TIPOFALSE();
                    SEXOFALSE();

                    LIMPARTXBCBB();
                }
                catch
                {

                }

            }

            // ATUALIZAR - BOTÃO ATUALIZAR
            if (BTN3.Text == "ATUALIZAR")
            {
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("ATUALIZAR CLIENTE?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        DATAHORA();

                        MySqlConnection CONEXAOATUALIZARCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOATUALIZARCLIENTE.Open();
                        MySqlCommand COMANDOATUALIZARCLIENTE = new MySqlCommand("update CLIENTE SET INSCREST = ?,INSCRMUN = ?, RUA = ?,NUMERO = ?,COMPLEMENTO = ?,BAIRRO = ?,CIDADE = ?,ESTADO = ?,CEP = ?, CONTATO1 = ?,SEXO1 = ?,EMAIL1 = ?,CONTATO2 = ?,SEXO2 = ?,EMAIL2 = ?,CONTATO3 = ?,SEXO3 = ?,EMAIL3 = ?,CONTATO4 = ?,SEXO4 = ?,EMAIL4 = ?,CONTATO5 = ?,SEXO5 = ?,EMAIL5 = ?,CONTATO6 = ?,SEXO6 = ?,EMAIL6 = ?,CONTATO7 = ?,SEXO7 = ?,EMAIL7 = ?,CONTATO8 = ?,SEXO8 = ?,EMAIL8 = ?, TIPO1 = ?, DDD1 = ?, TELEFONE1 = ?, TIPO2 = ?, DDD2 = ?, TELEFONE2 = ?, TIPO3 = ?, DDD3 = ?, TELEFONE3 = ?, TIPO4 = ?, DDD4 = ?, TELEFONE4 = ?, TIPO5 = ?, DDD5 = ?, TELEFONE5 = ?, TIPO6 = ?, DDD6 = ?, TELEFONE6 = ?, TIPO7 = ?, DDD7 = ?, TELEFONE7 = ?,TIPO8 = ?, DDD8 = ?, TELEFONE8 = ? WHERE IDCLIENTE = ?", CONEXAOATUALIZARCLIENTE);
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@INSCREST", MySqlDbType.VarChar).Value = TXB12.Text;//TXBINSCREST
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@INSCRMUN", MySqlDbType.VarChar).Value = TXB13.Text;//TXBINSCRMUN
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@RUA", MySqlDbType.VarChar).Value = TXB5.Text;//TXBRUA
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@NUMERO", MySqlDbType.VarChar).Value = TXB6.Text;//TXBNUMERO
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@COMPLEMENTO", MySqlDbType.VarChar).Value = TXB7.Text;//TXBCOMPLEMENTO
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@BAIRRO", MySqlDbType.VarChar).Value = TXB8.Text;//TXBBAIRRO
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CIDADE", MySqlDbType.VarChar).Value = TXB9.Text;//TXBCIDADE
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = TXB10.Text;//TXBESTADO
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CEP", MySqlDbType.VarChar).Value = TXB2.Text;//TXBCEP
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO1", MySqlDbType.VarChar).Value = TXB16.Text;//TXBCONTATO1
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO1", MySqlDbType.VarChar).Value = CBB4.Text;//CBBSEXO1
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL1", MySqlDbType.VarChar).Value = TXB17.Text;//TXBEMAIL1
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO2", MySqlDbType.VarChar).Value = TXB20.Text;//TXBCONTATO2
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO2", MySqlDbType.VarChar).Value = CBB6.Text;//CBBSEXO2
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL2", MySqlDbType.VarChar).Value = TXB21.Text;//TXBEMAIL2
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO3", MySqlDbType.VarChar).Value = TXB24.Text;//TXBCONTATO3
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO3", MySqlDbType.VarChar).Value = CBB8.Text;//CBBSEXO3
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL3", MySqlDbType.VarChar).Value = TXB25.Text;//TXBEMAIL3
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO4", MySqlDbType.VarChar).Value = TXB28.Text;//TXBCONTATO4
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO4", MySqlDbType.VarChar).Value = CBB10.Text;//CBBSEXO4
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL4", MySqlDbType.VarChar).Value = TXB29.Text;//TXBEMAIL4
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO5", MySqlDbType.VarChar).Value = TXB32.Text;//TXBCONTATO5
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO5", MySqlDbType.VarChar).Value = CBB12.Text;//CBBSEXO5
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL5", MySqlDbType.VarChar).Value = TXB33.Text;//TXBEMAIL5
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO6", MySqlDbType.VarChar).Value = TXB36.Text;//TXBCONTATO6
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO6", MySqlDbType.VarChar).Value = CBB14.Text;//CBBSEXO6
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL6", MySqlDbType.VarChar).Value = TXB37.Text;//TXBEMAIL6
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO7", MySqlDbType.VarChar).Value = TXB40.Text;//TXBCONTATO7
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO7", MySqlDbType.VarChar).Value = CBB16.Text;//CBBSEXO7
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL7", MySqlDbType.VarChar).Value = TXB41.Text;//TXBEMAIL7
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@CONTATO8", MySqlDbType.VarChar).Value = TXB44.Text;//TXBCONTATO8
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@SEXO8", MySqlDbType.VarChar).Value = CBB18.Text;//CBBSEXO8
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@EMAIL8", MySqlDbType.VarChar).Value = TXB45.Text;//TXBEMAIL8
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO1", MySqlDbType.VarChar).Value = CBB3.Text;//CBBTIPO1
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD1", MySqlDbType.VarChar).Value = TXB14.Text;//TXBDDD1
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE1", MySqlDbType.VarChar).Value = TXB15.Text;//TXBTELEFONE1
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO2", MySqlDbType.VarChar).Value = CBB5.Text;//CBBTIPO2
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD2", MySqlDbType.VarChar).Value = TXB18.Text;//TXBDDD2
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE2", MySqlDbType.VarChar).Value = TXB19.Text;//TXBTELEFONE2
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO3", MySqlDbType.VarChar).Value = CBB7.Text;//CBBTIPO3
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD3", MySqlDbType.VarChar).Value = TXB22.Text;//TXBDDD3
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE3", MySqlDbType.VarChar).Value = TXB23.Text;//TXBTELEFONE3
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO4", MySqlDbType.VarChar).Value = CBB9.Text;//CBBTIPO4
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD4", MySqlDbType.VarChar).Value = TXB26.Text;//TXBDDD4
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE4", MySqlDbType.VarChar).Value = TXB27.Text;//TXBTELEFONE4
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO5", MySqlDbType.VarChar).Value = CBB11.Text;//CBBTIPO5
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD5", MySqlDbType.VarChar).Value = TXB30.Text;//TXBDDD5
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE5", MySqlDbType.VarChar).Value = TXB31.Text;//TXBTELEFONE5
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO6", MySqlDbType.VarChar).Value = CBB13.Text;//CBBTIPO6
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD6", MySqlDbType.VarChar).Value = TXB34.Text;//TXBDDD6
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE6", MySqlDbType.VarChar).Value = TXB35.Text;//TXBTELEFONE6
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO7", MySqlDbType.VarChar).Value = CBB15.Text;//CBBTIPO7
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD7", MySqlDbType.VarChar).Value = TXB38.Text;//TXBDDD7
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE7", MySqlDbType.VarChar).Value = TXB39.Text;//TXBTELEFONE7
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TIPO8", MySqlDbType.VarChar).Value = CBB17.Text;//CBBTIPO8
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@DDD8", MySqlDbType.VarChar).Value = TXB42.Text;//TXBDDD8
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@TELEFONE8", MySqlDbType.VarChar).Value = TXB43.Text;//TXBTELEFONE8
                        COMANDOATUALIZARCLIENTE.Parameters.Add("@IDCLIENTE", MySqlDbType.VarChar).Value = TXB1.Text;//TXBCODIGO
                        COMANDOATUALIZARCLIENTE.ExecuteNonQuery();
                        CONEXAOATUALIZARCLIENTE.Close();

                        BotoesInicialCadastroAtualizarExcluir();

                        TXB6.Visible = true;
                        TXB6.Enabled = false;//TXBNUMERO
                        TXB7.Visible = true;
                        TXB7.Enabled = false;//TXBCOMPLEMENTO
                        TXB12.Visible = true;
                        TXB12.Enabled = false;//TXBINSCREST
                        TXB13.Visible = true;
                        TXB13.Enabled = false;//INSCRMUN

                        DDDFALSE();
                        TELEFONEFALSE();
                        CONTATOFALSE();
                        EMAILFALSE();
                        TIPOFALSE();
                        SEXOFALSE();

                        ATUALIZACBBNOME();

                        LIMPARTXBCBB();

                        LabelsContatoFalse();

                        TXB2.Visible = true;
                        TXB2.Enabled = false;//TXBCEP

                        CBB2.Visible = true;
                        CBB2.Enabled = true;
                        CBB2.Focus();//CBBNOME
                    }
                }
                catch
                {

                }
            }

            // EXCLUSÃO - BOTÃO EXCLUIR
            if (BTN3.Text == "EXCLUIR")
            {
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        DATAHORA();

                        MySqlConnection CONEXAOEXCLUIRCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOEXCLUIRCLIENTE.Open();
                        MySqlCommand COMANDOEXCLUIRCLIENTE = new MySqlCommand("delete FROM CLIENTE where IDCLIENTE = ?", CONEXAOEXCLUIRCLIENTE);
                        COMANDOEXCLUIRCLIENTE.Parameters.Add("@IDCLIENTE", MySqlDbType.VarChar).Value = TXB1.Text;//TXBCODIGO
                        COMANDOEXCLUIRCLIENTE.ExecuteNonQuery();
                        CONEXAOEXCLUIRCLIENTE.Close();

                        BotoesInicialCadastroAtualizarExcluir();

                        LabelsContatoFalse();

                        DDDFALSE();
                        TELEFONEFALSE();
                        CONTATOFALSE();
                        EMAILFALSE();
                        TIPOFALSE();
                        SEXOFALSE();

                        ATUALIZACBBNOME();

                        LIMPARTXBCBB();

                        CBB2.Focus();//CBBNOME
                    }
                }
                catch
                {

                }
            }
            if (label2.Text == "CADASTRAR PAPEIS")
            {
                try
                {
                    if (CBB1.Text == "CADASTRAR")
                    {
                        DATAHORA();

                        MySqlConnection CONEXAOCADASTRARPAPEL = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOCADASTRARPAPEL.Open();
                        MySqlCommand COMANDOCADASTRARPAPEL = new MySqlCommand("insert into PAPEISCADASTRO(MATPRIMA, QUANTFOLHA, ESTOQMINIMO, VALOR, VALORFOLHA, QUANTATUAL, MOTIVO, DIAHORA) values(?,?,?,?,?,?,?,?)", CONEXAOCADASTRARPAPEL);
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MATPRIMA", MySqlDbType.VarChar, 100).Value = TXB1.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MQUANTFOLHA", MySqlDbType.VarChar, 20).Value = TXB2.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@ESTOQMINIMO", MySqlDbType.VarChar, 50).Value = TXB4.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@VALOR", MySqlDbType.VarChar, 10).Value = TXB3.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@VALORFOLHA", MySqlDbType.VarChar).Value = TXB5.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@QUANTATUAL", MySqlDbType.VarChar, 20).Value = TXB6.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MOTIVO", MySqlDbType.VarChar, 20).Value = CBB1.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@DIAHORA", MySqlDbType.VarChar, 50).Value = LBLDATA.Text;
                        COMANDOCADASTRARPAPEL.ExecuteNonQuery();

                        CONEXAOCADASTRARPAPEL.Close();

                        LIMPACAMPOSCADASTRARPAPEIS();

                        TXBCADASTROPAPELDESABILITADO();
                    }
                    if (CBB1.Text == "ENTRADA")
                    {
                        DATAHORA();

                        MySqlConnection CONEXAOCADASTRARPAPEL = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOCADASTRARPAPEL.Open();
                        MySqlCommand COMANDOCADASTRARPAPEL = new MySqlCommand("insert into PAPEISESTOQUEENTRADA(MATPRIMAE, QUANTFOLHAE, ESTOQMINIMOE, VALORE, VALORFOLHAE, QUANTATUALE, MOTIVOE) values(?,?,?,?,?,?,?)", CONEXAOCADASTRARPAPEL);
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MATPRIMAE", MySqlDbType.VarChar, 100).Value = CBB2.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MQUANTFOLHAE", MySqlDbType.VarChar, 20).Value = TXB2.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@ESTOQMINIMOE", MySqlDbType.VarChar, 50).Value = TXB4.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@VALORE", MySqlDbType.VarChar, 10).Value = TXB3.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@VALORFOLHAE", MySqlDbType.VarChar).Value = TXB5.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@QUANTATUALE", MySqlDbType.VarChar, 20).Value = TXB6.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MOTIVOE", MySqlDbType.VarChar, 20).Value = CBB1.Text;
                        COMANDOCADASTRARPAPEL.ExecuteNonQuery();

                        CONEXAOCADASTRARPAPEL.Close();

                        LIMPACAMPOSCADASTRARPAPEIS();

                        TXBCADASTROPAPELDESABILITADO();

                        CBB2.Visible = false;
                    }
                    if (CBB1.Text == "SAÍDA")
                    {
                        DATAHORA();

                        MySqlConnection CONEXAOCADASTRARPAPEL = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAOCADASTRARPAPEL.Open();
                        MySqlCommand COMANDOCADASTRARPAPEL = new MySqlCommand("insert into PAPEISESTOQUESAIDA(MATPRIMAS, QUANTFOLHAS, ESTOQMINIMOS, VALORS, VALORFOLHAS, QUANTATUALS, MOTIVOS) values(?,?,?,?,?,?,?)", CONEXAOCADASTRARPAPEL);
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MATPRIMAS", MySqlDbType.VarChar, 100).Value = CBB2.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MQUANTFOLHAS", MySqlDbType.VarChar, 20).Value = TXB2.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@ESTOQMINIMOS", MySqlDbType.VarChar, 50).Value = TXB4.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@VALORS", MySqlDbType.VarChar, 10).Value = TXB3.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@VALORFOLHAS", MySqlDbType.VarChar).Value = TXB5.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@QUANTATUALS", MySqlDbType.VarChar, 20).Value = TXB6.Text;
                        COMANDOCADASTRARPAPEL.Parameters.Add("@MOTIVOS", MySqlDbType.VarChar, 20).Value = CBB1.Text;
                        COMANDOCADASTRARPAPEL.ExecuteNonQuery();

                        CONEXAOCADASTRARPAPEL.Close();

                        LIMPACAMPOSCADASTRARPAPEIS();

                        TXBCADASTROPAPELDESABILITADO();

                        CBB2.Visible = false;
                    }
                }

                catch
                {

                }
            }

        }

        // CHAMA O ESTOQUE MÍNIMO
        public void ESTOQUEMINIMO()
        {
            MySqlConnection CONEXAOCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
            CONEXAOCLIENTE.Open();
            MySqlCommand COMANDOCLIENTE = new MySqlCommand("SELECT ESTOQMINIMO FROM PAPEISCADASTRO WHERE MATPRIMA = ?", CONEXAOCLIENTE);
            COMANDOCLIENTE.Parameters.Clear();
            COMANDOCLIENTE.Parameters.Add("@MATPRIMA", MySqlDbType.VarChar).Value = CBB2.Text;
            COMANDOCLIENTE.CommandType = CommandType.Text;
            MySqlDataReader DRCLIENTE;
            DRCLIENTE = COMANDOCLIENTE.ExecuteReader();
            DRCLIENTE.Read();

            TXB4.Text = DRCLIENTE.GetString(0);

            CONEXAOCLIENTE.Close();
        }

        // SOMA A COLUNA QUANTFOLHA NA TABELA CADASTRO
        public void QUANTFOLHACADASTRO()
        {
            MySqlConnection CONEXAOPAPEL1 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
            CONEXAOPAPEL1.Open();
            MySqlCommand COMANDOPAPEL1 = new MySqlCommand("SELECT SUM(QUANTFOLHA) FROM PAPEISCADASTRO WHERE MATPRIMA = ?", CONEXAOPAPEL1);
            COMANDOPAPEL1.Parameters.Clear();
            COMANDOPAPEL1.Parameters.Add("@MATPRIMA", MySqlDbType.VarChar).Value = CBB2.Text;
            COMANDOPAPEL1.CommandType = CommandType.Text;
            MySqlDataReader DRPAPEL1;
            DRPAPEL1 = COMANDOPAPEL1.ExecuteReader();
            DRPAPEL1.Read();

            LBLCODIGO.Text = DRPAPEL1.GetString(0);

            CONEXAOPAPEL1.Close();
        }

        // SOMA A COLUNA QUANTFOLHA NA TABELA ENTRADA
        public void QUANTFOLHAENTRADA()
        {
            MySqlConnection CONEXAOPAPEL1 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
            CONEXAOPAPEL1.Open();
            MySqlCommand COMANDOPAPEL1 = new MySqlCommand("SELECT SUM(QUANTFOLHAE) FROM PAPEISESTOQUEENTRADA WHERE MATPRIMAE = ?", CONEXAOPAPEL1);
            COMANDOPAPEL1.Parameters.Clear();
            COMANDOPAPEL1.Parameters.Add("@MATPRIMAE", MySqlDbType.VarChar).Value = CBB2.Text;
            COMANDOPAPEL1.CommandType = CommandType.Text;
            MySqlDataReader DRPAPEL1;
            DRPAPEL1 = COMANDOPAPEL1.ExecuteReader();
            DRPAPEL1.Read();

            LBLCODIGO1.Text = DRPAPEL1.GetString(0);

            CONEXAOPAPEL1.Close();
        }

        // SOMA A COLUNA QUANTFOLHA NA TABELA SAÍDA
        public void QUANTFOLHASAIDA()
        {
            MySqlConnection CONEXAOPAPEL3 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
            CONEXAOPAPEL3.Open();
            MySqlCommand COMANDOPAPEL3 = new MySqlCommand("SELECT SUM(QUANTFOLHAS) FROM PAPEISESTOQUESAIDA WHERE MATPRIMAS = ?", CONEXAOPAPEL3);
            COMANDOPAPEL3.Parameters.Clear();
            COMANDOPAPEL3.Parameters.Add("@MATPRIMAS", MySqlDbType.VarChar).Value = CBB2.Text;
            COMANDOPAPEL3.CommandType = CommandType.Text;
            MySqlDataReader DRPAPEL3;
            DRPAPEL3 = COMANDOPAPEL3.ExecuteReader();
            DRPAPEL3.Read();

            LBLCODIGO2.Text = DRPAPEL3.GetString(0);

            CONEXAOPAPEL3.Close();
        }

        // CALCULA A QUANTIDADE ATUAL
        private void TXB6_TextChanged(object sender, EventArgs e)
        {
            // MOSTRA A QUANTIDADE ATUAL DO CADASTRO
            if (CBB1.Text == "CADASTRO")
            {
                TXB6.Text = TXB2.Text;

                //   LBLCODIGO.Text = TXBQUANTFOLHAS.Text;
            }

            // MOSTRA A QUANTIDADE ATUAL, SOMANDO A QUANTIDADE DO CADASTRO COM A ENTRADA E SUBTRAINDO A SAÍDA, MOSTRA O ESTOQUE MÍNIMO CADASTRADO
            if (CBB1.Text == "ENTRADA")
            {
                // FAZ A PESQUISA NA TABELA DE ENTRADA
                MySqlConnection CONEXAO1 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAO1.Open();
                MySqlCommand COMANDO1 = new MySqlCommand("select count(MATPRIMAE) from PAPEISESTOQUEENTRADA WHERE MATPRIMAE = ?", CONEXAO1);
                COMANDO1.Parameters.Clear();
                COMANDO1.Parameters.Add("@MATPRIMAE", MySqlDbType.VarChar).Value = CBB2.Text;
                MySqlDataReader DRPAPEL4;
                DRPAPEL4 = COMANDO1.ExecuteReader();
                DRPAPEL4.Read();
                int RESULTADO1 = int.Parse(DRPAPEL4.GetString(0));
                CONEXAO1.Close();
                // SE O RESULTADO DA PESQUISA ENTRADA FOR > 0 EXECUTA  
                if (RESULTADO1 > 0)
                {
                    // FAZ A PESQUISA NA TABELA DE SAÍDA
                    MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAO.Open();
                    MySqlCommand COMANDO = new MySqlCommand("select count(MATPRIMAS) from PAPEISESTOQUESAIDA WHERE MATPRIMAS = ?", CONEXAO);
                    COMANDO.Parameters.Clear();
                    COMANDO.Parameters.Add("@MATPRIMAS", MySqlDbType.VarChar).Value = CBB2.Text;
                    MySqlDataReader DRPAPEL;
                    DRPAPEL = COMANDO.ExecuteReader();
                    DRPAPEL.Read();
                    int RESULTADO = int.Parse(DRPAPEL.GetString(0));
                    CONEXAO.Close();
                    // ENTRADA > E SAÍDA >
                    // SE O RESULTADO DA PESQUISA SAÍDA FOR > 0 EXECUTA
                    if (RESULTADO > 0)
                    {
                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();
                        QUANTFOLHAENTRADA();
                        QUANTFOLHASAIDA();

                        int A, B, C, D;

                        A = int.Parse(LBLCODIGO.Text);
                        B = int.Parse(LBLCODIGO1.Text);
                        C = int.Parse(LBLCODIGO2.Text);

                        D = (A + B) - C;

                        TXB6.Text = D.ToString();
                    }
                    // ENTRADA > E SAÍDA <
                    // SE O RESULTADO DA PESQUISA SAÍDA FOR < 0 EXECUTA
                    if (RESULTADO <= 0)
                    {
                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();
                        QUANTFOLHAENTRADA();

                        int A, B, D;

                        A = int.Parse(LBLCODIGO.Text);
                        B = int.Parse(LBLCODIGO1.Text);

                        D = A + B;

                        TXB6.Text = D.ToString();
                    }
                }
                if (RESULTADO1 <= 0)
                {
                    // FAZ A PESQUISA NA TABELA DE SAÍDA
                    MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAO.Open();
                    MySqlCommand COMANDO = new MySqlCommand("select count(MATPRIMAS) from PAPEISESTOQUESAIDA WHERE MATPRIMAS = ?", CONEXAO);
                    COMANDO.Parameters.Clear();
                    COMANDO.Parameters.Add("@MATPRIMAS", MySqlDbType.VarChar).Value = CBB2.Text;
                    MySqlDataReader DRPAPEL;
                    DRPAPEL = COMANDO.ExecuteReader();
                    DRPAPEL.Read();
                    int RESULTADO = int.Parse(DRPAPEL.GetString(0));
                    CONEXAO.Close();
                    // ENTRADA < E SAÍDA >
                    // SE O RESULTADO DA PESQUISA SAÍDA FOR > 0 EXECUTA
                    if (RESULTADO > 0)
                    {
                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();
                        QUANTFOLHASAIDA();

                        int A, C, D;

                        A = int.Parse(LBLCODIGO.Text);
                        C = int.Parse(LBLCODIGO2.Text);

                        D = A - C;

                        TXB6.Text = D.ToString();

                    }
                    // ENTRADA < E SAÍDA <
                    // SE O RESULTADO DA PESQUISA SAÍDA FOR < 0 EXECUTA
                    if (RESULTADO <= 0)
                    {
                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();

                        int A, D;

                        A = int.Parse(LBLCODIGO.Text);


                        D = A;

                        TXB6.Text = D.ToString();
                    }
                }
            }

            // MOSTRA A QUANTIDADE ATUAL, SOMANDO A QUANTIDADE DO CADASTRO COM A ENTRADA E SUBTRAINDO A QUANTIDADE DE SAÍDA, MOSTRA O ESTOQUE MÍNIMO CADASTRADO
            if (CBB1.Text == "SAÍDA")
            {
                // FAZ A PESQUISA NA TABELA DE SAÍDA
                MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAO.Open();
                MySqlCommand COMANDO = new MySqlCommand("select count(MATPRIMAS) from PAPEISESTOQUESAIDA WHERE MATPRIMAS = ?", CONEXAO);
                COMANDO.Parameters.Clear();
                COMANDO.Parameters.Add("@MATPRIMAS", MySqlDbType.VarChar).Value = CBB2.Text;
                MySqlDataReader DRPAPEL;
                DRPAPEL = COMANDO.ExecuteReader();
                DRPAPEL.Read();
                int RESULTADO = int.Parse(DRPAPEL.GetString(0));
                CONEXAO.Close();
                if (RESULTADO > 0)
                {
                    // FAZ A PESQUISA NA TABELA DE ENTRADA
                    MySqlConnection CONEXAO1 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAO1.Open();
                    MySqlCommand COMANDO1 = new MySqlCommand("select count(MATPRIMAE) from PAPEISESTOQUEENTRADA WHERE MATPRIMAE = ?", CONEXAO1);
                    COMANDO1.Parameters.Clear();
                    COMANDO1.Parameters.Add("@MATPRIMAE", MySqlDbType.VarChar).Value = CBB2.Text;
                    MySqlDataReader DRPAPEL4;
                    DRPAPEL4 = COMANDO1.ExecuteReader();
                    DRPAPEL4.Read();
                    int RESULTADO1 = int.Parse(DRPAPEL4.GetString(0));
                    CONEXAO1.Close();
                    // SE O RESULTADO DA PESQUISA FOR > 0 EXECUTA  
                    if (RESULTADO1 > 0)
                    {

                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();
                        QUANTFOLHAENTRADA();
                        QUANTFOLHASAIDA();

                        int A, B, C, D;

                        A = int.Parse(LBLCODIGO.Text);
                        B = int.Parse(LBLCODIGO1.Text);
                        C = int.Parse(LBLCODIGO2.Text);

                        D = (A + B) - C;

                        TXB6.Text = D.ToString();
                    }
                    if (RESULTADO1 <= 0)
                    {

                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();
                        QUANTFOLHASAIDA();

                        int A, C, D;

                        A = int.Parse(LBLCODIGO.Text);
                        C = int.Parse(LBLCODIGO2.Text);

                        D = A - C;

                        TXB6.Text = D.ToString();
                    }
                }

                if (RESULTADO <= 0)
                {
                    // FAZ A PESQUISA NA TABELA DE ENTRADA
                    MySqlConnection CONEXAO1 = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                    CONEXAO1.Open();
                    MySqlCommand COMANDO1 = new MySqlCommand("select count(MATPRIMAE) from PAPEISESTOQUEENTRADA WHERE MATPRIMAE = ?", CONEXAO1);
                    COMANDO1.Parameters.Clear();
                    COMANDO1.Parameters.Add("@MATPRIMAE", MySqlDbType.VarChar).Value = CBB2.Text;
                    MySqlDataReader DRPAPEL4;
                    DRPAPEL4 = COMANDO1.ExecuteReader();
                    DRPAPEL4.Read();
                    int RESULTADO1 = int.Parse(DRPAPEL4.GetString(0));
                    CONEXAO1.Close();
                    // SE O RESULTADO DA PESQUISA FOR > 0 EXECUTA  
                    if (RESULTADO1 > 0)
                    {
                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();
                        QUANTFOLHAENTRADA();

                        int A, B, D;

                        A = int.Parse(LBLCODIGO.Text);
                        B = int.Parse(LBLCODIGO1.Text);

                        D = A + B;

                        TXB6.Text = D.ToString();
                    }
                    if (RESULTADO1 <= 0)
                    {
                        ESTOQUEMINIMO();
                        QUANTFOLHACADASTRO();

                        int A, D;

                        A = int.Parse(LBLCODIGO.Text);


                        D = A;

                        TXB6.Text = D.ToString();
                    }
                }
            }
        }
        // PESQUISAR CLIENTE
        public void pesquisarcliente()
        {
            MySqlConnection CONEXAOCLIENTE = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");

            CONEXAOCLIENTE.Open();

            MySqlCommand COMANDOCLIENTE = new MySqlCommand("SELECT IDCLIENTE, NOME, RAZAOSOCIAL, RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP, CNPJ, INSCREST, INSCRMUN, CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3, CONTATO4, SEXO4, EMAIL4, CONTATO5, SEXO5, EMAIL5, CONTATO6, SEXO6, EMAIL6, CONTATO7, SEXO7, EMAIL7, CONTATO8, SEXO8, EMAIL8, TIPO1, DDD1, TELEFONE1, TIPO2, DDD2, TELEFONE2, TIPO3, DDD3, TELEFONE3, TIPO4, DDD4, TELEFONE4, TIPO5, DDD5, TELEFONE5, TIPO6, DDD6, TELEFONE6, TIPO7, DDD7, TELEFONE7, TIPO8, DDD8, TELEFONE8 FROM CLIENTE WHERE NOME = ?", CONEXAOCLIENTE);
            COMANDOCLIENTE.Parameters.Clear();
            COMANDOCLIENTE.Parameters.Add("@NOME", MySqlDbType.VarChar).Value = CBB2.Text;//CBBNOME

            COMANDOCLIENTE.CommandType = CommandType.Text;

            MySqlDataReader DRCLIENTE;
            DRCLIENTE = COMANDOCLIENTE.ExecuteReader();
            DRCLIENTE.Read();

            TXB1.Text = DRCLIENTE.GetString(0);//TXBCODIGO
            TXB4.Text = DRCLIENTE.GetString(2);//TXBRAZAOSOCIAL
            TXB5.Text = DRCLIENTE.GetString(3);//TXBRUA
            TXB6.Text = DRCLIENTE.GetString(4);//TXBNUMERO
            TXB7.Text = DRCLIENTE.GetString(5);//TXBCOMPLEMENTO
            TXB8.Text = DRCLIENTE.GetString(6);//TXBBAIRRO
            TXB9.Text = DRCLIENTE.GetString(7);//TXBCIDADE
            TXB10.Text = DRCLIENTE.GetString(8);//TXBESTADO
            TXB2.Text = DRCLIENTE.GetString(9);//TXBCEP
            TXB11.Text = DRCLIENTE.GetString(10);//TXBCNPJ
            TXB12.Text = DRCLIENTE.GetString(11);//TXBINSCREST
            TXB13.Text = DRCLIENTE.GetString(12);//TXBINSCRMUN
            TXB16.Text = DRCLIENTE.GetString(13);//TXBCONTATO1
            CBB4.Text = DRCLIENTE.GetString(14);//CBBSEXO1
            TXB17.Text = DRCLIENTE.GetString(15);//TXBEMAIL1
            TXB20.Text = DRCLIENTE.GetString(16);//TXBCONTATO2
            CBB6.Text = DRCLIENTE.GetString(17);//CBBSEXO2
            TXB21.Text = DRCLIENTE.GetString(18);//TXBEMAIL2
            TXB24.Text = DRCLIENTE.GetString(19);//TXBCONTATO3
            CBB8.Text = DRCLIENTE.GetString(20);//CBBSEXO3
            TXB25.Text = DRCLIENTE.GetString(21);//TXBEMAIL3
            TXB28.Text = DRCLIENTE.GetString(22);//TXBCONTATO4
            CBB10.Text = DRCLIENTE.GetString(23);//CBBSEXO4
            TXB29.Text = DRCLIENTE.GetString(24);//TXBEMAIL4
            TXB32.Text = DRCLIENTE.GetString(25);//TXBCONTATO5
            CBB12.Text = DRCLIENTE.GetString(26);//CBBSEXO5
            TXB33.Text = DRCLIENTE.GetString(27);//TXBEMAIL5
            TXB36.Text = DRCLIENTE.GetString(28);//TXBCONTATO6
            CBB14.Text = DRCLIENTE.GetString(29);//CBBSEXO6
            TXB37.Text = DRCLIENTE.GetString(30);//TXBEMAIL6
            TXB40.Text = DRCLIENTE.GetString(31);//TXBCONTATO7
            CBB16.Text = DRCLIENTE.GetString(32);//CBBSEXO7
            TXB41.Text = DRCLIENTE.GetString(33);//TXBEMAIL7
            TXB44.Text = DRCLIENTE.GetString(34);//TXBCONTATO8
            CBB18.Text = DRCLIENTE.GetString(35);//CBBSEXO8
            TXB45.Text = DRCLIENTE.GetString(36);//TXBEMAIL8
            CBB3.Text = DRCLIENTE.GetString(37);//CBBTIPO1
            TXB14.Text = DRCLIENTE.GetString(38);//TXBDDD1
            TXB15.Text = DRCLIENTE.GetString(39);//TXBTELEFONE1
            CBB5.Text = DRCLIENTE.GetString(40);//CBBTIPO2
            TXB18.Text = DRCLIENTE.GetString(41);//TXBDDD2
            TXB19.Text = DRCLIENTE.GetString(42);//TXBTELEFONE2
            CBB7.Text = DRCLIENTE.GetString(43);//CBBTIPO3
            TXB22.Text = DRCLIENTE.GetString(44);//TXBDDD3
            TXB23.Text = DRCLIENTE.GetString(45);//TXBTELEFONE3
            CBB9.Text = DRCLIENTE.GetString(46);//CBBTIPO4
            TXB26.Text = DRCLIENTE.GetString(47);//TXBDDD4
            TXB27.Text = DRCLIENTE.GetString(48);//TXBTELEFONE4
            CBB11.Text = DRCLIENTE.GetString(49);//CBBTIPO5
            TXB30.Text = DRCLIENTE.GetString(50);//TXBDDD5
            TXB31.Text = DRCLIENTE.GetString(51);//TXBTELEFONE5
            CBB13.Text = DRCLIENTE.GetString(52);//CBBTIPO6
            TXB34.Text = DRCLIENTE.GetString(53);//TXBDDD6
            TXB35.Text = DRCLIENTE.GetString(54);//TXBTELEFONE6
            CBB15.Text = DRCLIENTE.GetString(55);//CBBTIPO7
            TXB38.Text = DRCLIENTE.GetString(56);//TXBDDD7
            TXB39.Text = DRCLIENTE.GetString(57);//TXBTELEFONE7
            CBB17.Text = DRCLIENTE.GetString(58);//CBBTIPO8
            TXB42.Text = DRCLIENTE.GetString(59);//TXBDDD8
            TXB43.Text = DRCLIENTE.GetString(60);//TXBTELEFONE8

            CONEXAOCLIENTE.Close();
        }

        // LOCALIZAR CONTATOS ATUALIZAR
        public void CONTATOSATUALIZAR()
        {
            if (TXB16.Text != "")//TXBCONTATO1
            {
                BotaoCadastroAtualizarContato1();
                TamanhoePosicaoContato1();
            }
            if (TXB20.Text != "")//TXBCONTATO2
            {
                BotaoCadastroAtualizarContato2();
                TamanhoePosicaoContato2();
            }
            if (TXB24.Text != "")//TXBCONTATO3
            {
                BotaoCadastroAtualizarContato3();
                TamanhoePosicaoContato3();
            }
            if (TXB28.Text != "")//TXBCONTATO4
            {
                BotaoCadastroAtualizarContato4();
                TamanhoePosicaoContato4();
            }
            if (TXB32.Text != "")//TXBCONTATO5
            {
                BotaoCadastroAtualizarContato5();
                TamanhoePosicaoContato5();
            }
            if (TXB36.Text != "")//TXBCONTATO6
            {
                BotaoCadastroAtualizarContato6();
                TamanhoePosicaoContato6();
            }
            if (TXB40.Text != "")//TXBCONTATO7
            {
                BotaoCadastroAtualizarContato7();
                TamanhoePosicaoContato7();
            }
            if (TXB44.Text != "")//TXBCONTATO8
            {
                BotaoCadastroAtualizarContato8();
                TamanhoePosicaoContato8();
            }
        }
        // LOCALIZAR CONTATOS EXCLUIR
        public void CONTATOSEXCLUIR()
        {
            if (TXB16.Text != "")//TXBCONTATO1
            {
                BotaoCadastroAtualizarContato1();
                TamanhoePosicaoContato1False();
            }
            if (TXB20.Text != "")//TXBCONTATO2
            {
                BotaoCadastroAtualizarContato2();
                TamanhoePosicaoContato2False();
            }
            if (TXB24.Text != "")//TXBCONTATO3
            {
                BotaoCadastroAtualizarContato3();
                TamanhoePosicaoContato3False();
            }
            if (TXB28.Text != "")//TXBCONTATO4
            {
                BotaoCadastroAtualizarContato4();
                TamanhoePosicaoContato4False();
            }
            if (TXB32.Text != "")//TXBCONTATO5
            {
                BotaoCadastroAtualizarContato5();
                TamanhoePosicaoContato5False();
            }
            if (TXB36.Text != "")//TXBCONTATO6
            {
                BotaoCadastroAtualizarContato6();
                TamanhoePosicaoContato6False();
            }
            if (TXB40.Text != "")//TXBCONTATO7
            {
                BotaoCadastroAtualizarContato7();
                TamanhoePosicaoContato7False();
            }
            if (TXB44.Text != "")//TXBCONTATO8
            {
                BotaoCadastroAtualizarContato8();
                TamanhoePosicaoContato8False();
            }
        }

        // BOTÃO PESQUISAR ATUALIZAR/EXCLUIR
        private void BTNPESQUISAR_Click(object sender, EventArgs e)
        {
            if (label2.Text == "ATUALIZAR CLIENTE")
            {
                try
                {
                    TXB6.Visible = true;
                    TXB6.Enabled = true;//TXBNUMERO
                    TXB7.Visible = true;
                    TXB7.Enabled = true;//TXBCOMPLEMENTO
                    TXB12.Visible = true;
                    TXB12.Enabled = true;//TXBINSCREST
                    TXB13.Visible = true;
                    TXB13.Enabled = true;//INSCRMUN
                    TXB2.Enabled = true;//TXBCEP
                    CBB2.Enabled = false;//CBBNOME

                    LabelsContato();
                    DATAHORA();
                    CBBEMBRANCO();
                    pesquisarcliente();
                    CONTATOSATUALIZAR();
                    TXB2.Focus();//TXBCEP
                }
                catch
                {

                }

            }
            if (label2.Text == "EXCLUIR CLIENTE")
            {
                try
                {
                    DATAHORA();
                    CBBEMBRANCO();
                    CBB2.Enabled = false;//CBBNOME
                    CBB1.Focus();//CBBCLIENTE
                    pesquisarcliente();
                    CONTATOSEXCLUIR();
                }
                catch
                {

                }
            }
        }

        // PREENCHENDO UM DATAGRIDVIEW
        public void DGVBUSCAPAPEIS()
        {
            try
            {
                MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                CONEXAO.Open();
                // string CLIENTE = "SELECT NOME, RAZAOSOCIAL, RUA, NUMERO, BAIRRO, CIDADE, ESTADO, CEP, CNPJ, INSCREST, INSCRMUN, CONTATO1, SEXO1, EMAIL1, CONTATO2, SEXO2, EMAIL2, CONTATO3, SEXO3, EMAIL3 FROM CLIENTE, ENDERECO, FISCAIS, CONTATO ORDER BY nome";
                // string CLIENTE = "SELECT * FROM CLIENTE, ENDERECO, FISCAIS, CONTATO, TELEFONE ORDER BY NOME";
                string PAPEIS = "SELECT * FROM PAPEIS ORDER BY MATPRIMA";
                MySqlCommand COMANDO = new MySqlCommand(PAPEIS, CONEXAO);
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

        // DATAGRIDVIEW OCULTO
        public void DGV1OCULTO()
        {
            DGV1.Visible = false;
        }

        // DATAGRIDVIEW VISIVEL
        public void DGV1VISIVEL()
        {
            DGV1.Visible = true;
            DGV1.Size = new Size(1100, 620);
            DGV1.Location = new Point(411, 410);


            // DGV1.Columns.Add("MATÉRIA PRIMA", "MATPRIMA");

            // DEFINE O NOME DA COLUNA/CÉLULA DO DATAGRIDVIEW
            /*      DGV1.Columns[0].HeaderText = "ID";
                  // DEFINE O AJUSTE AUTOMÁTICO DE TAMANHO DA COLUNA/CÉLULA
                  DGV1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                  // CENTRALIZA O TEXTO NO DATAGRIDVIEW
                  DGV1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                  // DEFINE O TAMANHO DE UM DATAGRIDVIEW - TAMANHO FIXO
                  DGV1.Columns[1].HeaderText = "MATÉRIA PRIMA";
                  DGV1.Columns[1].Width = 300;
                  DGV1.Columns[2].HeaderText = "QUANTIDADE FOLHA";
                  DGV1.Columns[2].Width = 85;
                  DGV1.Columns[3].HeaderText = "VALOR";
                  DGV1.Columns[3].Width = 65;
                  DGV1.Columns[4].HeaderText = "ESTOQUE MÍNIMO";
                  DGV1.Columns[4].Width = 85;
                  DGV1.Columns[5].HeaderText = "VALOR FOLHA";
                  DGV1.Columns[5].Width = 85;
                  DGV1.Columns[6].HeaderText = "QUANTIDADE ATUAL";
                  DGV1.Columns[6].Width = 85;
                  // CENTRALIZA O TEXTO NO DATAGRIDVIEW
                  DGV1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                  DGV1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                  DGV1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                  DGV1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                  DGV1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                  DGV1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;    */
        }

        // CALCULA O VALOR DA FOLHA DE PAPEL E TRANSFORMA O RESULTADO EM VALOR R$
        private void TXB3_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "CADASTRAR PAPEIS")
            {
                try
                {
                    // USA O TXB COMO ENTRADA
                    if (TXB1.Text != "")
                    {
                        double A, B, C;

                        A = double.Parse(TXB2.Text);
                        B = double.Parse(TXB3.Text);

                        C = B / A;

                        TXB3.Text = Convert.ToDouble(TXB3.Text).ToString("C");

                        TXB5.Text = (C.ToString());

                        TXB5.Text = Convert.ToDouble(TXB5.Text).ToString("F4");
                    }
                }
                catch
                {

                }
            }
            if (label2.Text == "CADASTRAR PAPEIS")
            {
                try
                {
                    // USA O CBB COMO ENTRADA
                    if (CBB2.Text != "")
                    {
                        double A, B, C;

                        A = double.Parse(TXB2.Text);
                        B = double.Parse(TXB3.Text);

                        C = B / A;

                        TXB3.Text = Convert.ToDouble(TXB3.Text).ToString("C");

                        TXB5.Text = (C.ToString());

                        TXB5.Text = Convert.ToDouble(TXB5.Text).ToString("F4");
                    }
                }
                catch
                {

                }
            }
        }

        // PARA ENTRADA DE SOMENTE NUMEROS
        private void TXB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // PARA ENTRADA DE SOMENTE NUMEROS
        private void TXB4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        // EXIBE O FORMULÁRIO DE CADASTRO DE PAPEL
        private void FORMCADPAPEL_Click(object sender, EventArgs e)
        {


            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "PAPEIS";
            label2.ForeColor = Color.Black;
            label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 100);
            label2.Font = new Font("arial black", 48);
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;

            TXBCADASTROPAPELDESABILITADO();
            CBBCADASTROCLIENTEOCULTO();
            DGV1OCULTO();
            INSERIROCULTO();
            AsteriscosFalse();
            LabelsContatoFalse();
            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();
            CBBOX2FALSE();
            TXBCADASTROFUNCIONARIOSOCULTO();

            CBB2.Visible = false;

            BTNFORMPAPEIS();
            DATAHORA();
            DATAPAPEIS();
            CBBOX1();
            MNS3();
            LABELFORMULARIOSVISIVEIS();
            LIMPACAMPOSCADASTRARPAPEIS();
            PESQUISARVISIVEL();

            CBB1.Focus();
        }

        // LIMPA OS CBB E TXB DO CADASTRO DE PAPEIS
        public void LIMPACAMPOSCADASTRARPAPEIS()
        {
            CBB1.Text = "";
            CBB1.Text = "Selecione";
            CBB2.Text = "";
            TXB1.Clear();
            TXB2.Clear();
            TXB3.Clear();
            TXB4.Clear();
            TXB5.Clear();
            TXB6.Clear();
        }

        // EXIBE E HABILITA OS TEXTBOX PARA CADASTRO DE PAPEIS
        /*    public void TXBCADASTROPAPEL()
            {
                TXBMATPRIMA.Visible = true;
                TXBMATPRIMA.Enabled = true;
                TXBMATPRIMA.Size = new Size(500, 20);
                TXBMATPRIMA.Location = new Point(411, 299);
                TXBQUANTFOLHAS.Visible = true;
                TXBQUANTFOLHAS.Size = new Size(111, 20);
                TXBQUANTFOLHAS.Enabled = true;
                TXBQUANTFOLHAS.Location = new Point(919, 299);
                TXBVALOR.Visible = true;
                TXBVALOR.Size = new Size(111, 20);
                TXBVALOR.Enabled = true;
                TXBVALOR.Location = new Point(1039, 299);
                TXBESTOQMINIMO.Visible = true;
                TXBESTOQMINIMO.Size = new Size(111, 20);
                TXBESTOQMINIMO.Enabled = true;
                TXBESTOQMINIMO.Location = new Point(1158, 299);
                TXBVALORFOLHA.Visible = true;
                TXBVALORFOLHA.Enabled = false;
                TXBVALORFOLHA.Size = new Size(111, 20);
                TXBVALORFOLHA.Location = new Point(1278, 299);
                TXBQUANTATUAL.Visible = true;
                TXBQUANTATUAL.Enabled = false;
                TXBQUANTATUAL.Size = new Size(111, 20);
                TXBQUANTATUAL.Location = new Point(1398, 299);
            }   */

        // DESABILITA OS TEXTBOX PARA CADASTRO/ATUALIZAR PAPEIS
        public void TXBCADASTROPAPELDESABILITADO()
        {
            TXB1.Visible = true;
            TXB1.Enabled = false;
            TXB1.Size = new Size(500, 20);
            TXB1.Location = new Point(411, 299);
            TXB2.Visible = true;
            TXB2.Size = new Size(111, 20);
            TXB2.Enabled = false;
            TXB2.Location = new Point(919, 299);
            TXB3.Visible = true;
            TXB3.Size = new Size(111, 20);
            TXB3.Enabled = false;
            TXB3.Location = new Point(1039, 299);
            TXB4.Visible = true;
            TXB4.Size = new Size(111, 20);
            TXB4.Enabled = false;
            TXB4.Location = new Point(1158, 299);
            TXB5.Visible = true;
            TXB5.Enabled = false;
            TXB5.Size = new Size(111, 20);
            TXB5.Location = new Point(1278, 299);
            TXB6.Visible = true;
            TXB6.Enabled = false;
            TXB6.Size = new Size(111, 20);
            TXB6.Location = new Point(1398, 299);
        }

        // CADASTRO DE PAPEL OCULTO
        public void CADPAPELINVISIVEL()
        {
            CBB2.Visible = false;

            label1.Visible = false;

            TXB1.Visible = false;

            TXB2.Visible = false;
            TXB3.Visible = false;
            TXB4.Visible = false;
            TXB5.Visible = false;
            TXB5.Enabled = false;
            TXB6.Visible = false;
            TXB6.Enabled = false;

            TXB1.Focus();
        }

        // EXECUTA QUANDO É SELECIONADO CADASTRAR, ENTRADA OU SAÍDA NO COMBOBOX CBB1 - CBBCLIENTE
        public void ENTRADA_SAÍDA()
        {
            if (CBB1.Text == "CADASTRAR")
            {
                label1.Visible = false;
                label2.Visible = true;
                label2.Text = "CADASTRAR PAPEIS";
                label2.ForeColor = Color.Blue;
                label2.Location = new Point(500, 50);
                label2.Size = new Size(900, 100);
                label2.Font = new Font("arial black", 48);

                BTNFORMPAPEIS();

                CBBCADASTROCLIENTEOCULTO();

                BTN2.Visible = false;

                TXB2.Enabled = true;
                TXB2.Clear();
                TXB3.Enabled = true;
                TXB3.Clear();
                TXB4.Enabled = true;
                TXB4.Clear();
                TXB5.Clear();
                CBB2.Text = "";
                CBB2.Visible = false;
                CBB2.Size = new Size(500, 20);
                CBB2.Location = new Point(411, 299);
                CBB2.Enabled = false;
                TXB1.Visible = true;
                TXB1.Enabled = true;

                TXB1.Focus();
            }
            if (CBB1.Text == "ENTRADA")
            {
                label1.Visible = false;
                label2.Visible = true;
                label2.Text = "ENTRADA PAPEIS";
                label2.ForeColor = Color.Green;
                label2.Location = new Point(500, 50);
                label2.Size = new Size(900, 100);
                label2.Font = new Font("arial black", 48);

                ATUALIZACBBPAPEIS();
                PESQUISARVISIVEL();
                BTNFORMPAPEIS();

                TXB2.Enabled = true;
                TXB2.Clear();
                TXB3.Enabled = true;
                TXB3.Clear();
                TXB4.Enabled = false;
                TXB4.Clear();
                TXB5.Clear();
                CBB2.Visible = true;
                CBB2.Size = new Size(500, 20);
                CBB2.Location = new Point(411, 299);
                CBB2.Enabled = true;
                CBB2.Text = "";
                TXB1.Visible = false;
                TXB1.Clear();
                CBB2.Focus();
            }
            if (CBB1.Text == "SAÍDA")
            {
                label1.Visible = false;
                label2.Visible = true;
                label2.Text = "SAÍDA PAPEIS";
                label2.ForeColor = Color.Red;
                label2.Location = new Point(500, 50);
                label2.Size = new Size(900, 100);
                label2.Font = new Font("arial black", 48);

                ATUALIZACBBPAPEIS();
                PESQUISARVISIVEL();
                BTNFORMPAPEIS();

                TXB2.Enabled = true;
                TXB2.Clear();
                TXB3.Enabled = false;
                TXB3.Clear();
                TXB4.Enabled = false;
                TXB4.Clear();
                TXB5.Clear();
                CBB2.Text = "";
                CBB2.Visible = true;
                CBB2.Size = new Size(500, 20);
                CBB2.Location = new Point(411, 299);
                CBB2.Enabled = true;
                TXB1.Visible = false;
                CBB2.Focus();
            }
        }
        // BOTÕES FORMULÁRIO FUNCIONÁRIOS
        public void BTNFORMFUN()
        {
            BTN3.Visible = true;
            BTN3.Text = "CADASTRAR";
            BTN3.ForeColor = Color.Blue;
            BTN3.Location = new Point(411, 430);
            BTN3.Size = new Size(500, 54);

            BTNCANCELAR();
            BTN4.Location = new Point(1011, 430);
            BTN4.Size = new Size(500, 54);
        }

        // BOTÕES NO FORMULÁRIO PAPEIS
        public void BTNFORMPAPEIS()
        {
            if (label2.Text == "PAPEIS")
            {
                BTN3.Visible = true;
                BTN3.Text = "FORMULÁRIO";
                BTN3.ForeColor = Color.Black;
                BTN3.Location = new Point(411, 337);
                BTN3.Size = new Size(500, 54);

                BTNCANCELAR();
                BTN4.Location = new Point(1011, 337);
                BTN4.Size = new Size(500, 54);
            }
            if (label2.Text == "CADASTRAR PAPEIS")
            {
                BTN3.Visible = true;
                BTN3.Text = "CADASTRAR";
                BTN3.ForeColor = Color.Blue;
                BTN3.Location = new Point(411, 337);
                BTN3.Size = new Size(500, 54);

                BTNCANCELAR();
                BTN4.Location = new Point(1011, 337);
                BTN4.Size = new Size(500, 54);
            }
            if (label2.Text == "ENTRADA PAPEIS")
            {
                BTN3.Visible = true;
                BTN3.Text = "ENTRADA";
                BTN3.ForeColor = Color.Green;
                BTN3.Location = new Point(411, 337);
                BTN3.Size = new Size(500, 54);

                BTNCANCELAR();
                BTN4.Location = new Point(1011, 337);
                BTN4.Size = new Size(500, 54);
            }
            if (label2.Text == "SAÍDA PAPEIS")
            {
                BTN3.Visible = true;
                BTN3.Text = "SAÍDA";
                BTN3.ForeColor = Color.Red;
                BTN3.Location = new Point(411, 337);
                BTN3.Size = new Size(500, 54);

                BTNCANCELAR();
                BTN4.Location = new Point(1011, 337);
                BTN4.Size = new Size(500, 54);
            }
        }

        // TAMANHO E LOCALIZAÇÃO DO COMBOBOX CADASTRO DO CLIENTE
        public void CBBCADASTROCLIENTE()
        {
            CBB1.Visible = true;
            CBB1.Text = "Selecione";//CBBCLIENTE
            CBB1.Location = new Point(411, 243);
            CBB1.Size = new Size(94, 21);
        }
        // COMBOBOX CADASTRO DO CLIENTE OCULTO
        public void CBBCADASTROCLIENTEOCULTO()
        {
            CBB1.Visible = false;//CBBCLIENTE

        }

        // TAMANHO E LOCALIZAÇÃO DO COMBOBOX FUNCIONÁRIOS
        public void CBBOX2()
        {
            CBBFUNCIONARIOS.Visible = true;
            CBBFUNCIONARIOS.Location = new Point(411, 243);
            CBBFUNCIONARIOS.Size = new Size(94, 21);
        }

        // TAMANHO E LOCALIZAÇÃO DO COMBOBOX PAPEIS
        public void CBBOX1()
        {
            CBB1.Visible = true;
            CBB1.Location = new Point(411, 243);
            CBB1.Size = new Size(94, 21);
        }

        // COMBOBOX PAPEIS OCULTO
        public void CBBOX1FALSE()
        {
            CBB1.Visible = false;
        }

        // COMBOBOX FUNCIONÁRIOS OCULTO
        public void CBBOX2FALSE()
        {
            CBBFUNCIONARIOS.Visible = false;
        }

        // EXIBE MATERIA PRIMA EM BRANCO OU EXISTENTE
        private void TXB1_TextChanged(object sender, EventArgs e)
        {
            if (CBB1.Text == "CADASTRO")
            {
                try
                {
                    // PARA MATÉRIA PRIMA EM BRANCO
                    if (TXB1.Text == "")
                    {
                        MessageBox.Show("NOME DO PAPEL EM BRANCO");
                        LIMPACAMPOSCADASTRARPAPEIS();
                        TXBCADASTROPAPELDESABILITADO();
                        CBB1.Focus();
                        return;
                    }

                    // PARA MATÉRIA PRIMA EXISTENTE
                    if (TXB1.Text != "")
                    {
                        MySqlConnection CONEXAO = new MySqlConnection("server=localhost;port=3306;user id=root;database=grafica;password=1234");
                        CONEXAO.Open();
                        MySqlCommand COMANDO = new MySqlCommand("select count(MATPRIMA) from PAPEISCADASTRO WHERE MATPRIMA = ?", CONEXAO);
                        COMANDO.Parameters.Clear();
                        COMANDO.Parameters.Add("@MATPRIMA", MySqlDbType.VarChar).Value = TXB1.Text;
                        MySqlDataReader DRCLIENTE;
                        DRCLIENTE = COMANDO.ExecuteReader();
                        DRCLIENTE.Read();
                        int RESULTADO = int.Parse(DRCLIENTE.GetString(0));
                        while (RESULTADO > 0)
                        {
                            MessageBox.Show("PAPEL EXISTENTE");
                            LIMPACAMPOSCADASTRARPAPEIS();
                            TXBCADASTROPAPELDESABILITADO();
                            TXB1.Focus();
                            return;
                        }


                        CONEXAO.Close();
                    }
                }
                catch
                {
                }
            }
        }

        // EXIBE O FORMULÁRIO FUNCIONÁRIO
        private void FUNCIONARIO_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "CADASTRAR FUNCIONÁRIO";
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(230, 50);
            label2.Size = new Size(1500, 100);
            label2.Font = new Font("arial black", 48);

            CBB2.Visible = false;

            LABELFORMULARIOSVISIVEIS();
            DadosDoClienteParaCadastroFalse();
            AsteriscosFalse();
            LabelsContatoFalse();
            DDDFALSE();
            TELEFONEFALSE();
            CONTATOFALSE();
            EMAILFALSE();
            TIPOFALSE();
            SEXOFALSE();
            CADPAPELINVISIVEL();
            MNS4();
            DGV1OCULTO();
            INSERIROCULTO();
            BTNFORMFUN();
            TXBCADASTROFUNCIONARIOS();
            CBBOX2();

            TXBDATAFUN.Focus();
        }

        // OCULTA AS LABELS DO CADASTRO FUNCIONÁRIOS
        public void LABELSCADASTROFUNCIONARIOSOCULTO()
        {
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

        }
        // EXIBE E HABILITA OS TEXTBOX PARA CADASTRO DE FUNCIONÁRIOS
        public void TXBCADASTROFUNCIONARIOS()
        {
            TXBDATAFUN.Visible = true;
            TXBDATAFUN.Size = new Size(80, 20);
            TXBDATAFUN.Enabled = true;
            TXBDATAFUN.Location = new Point(411, 299);
            TXBNOMEFUN.Visible = true;
            TXBNOMEFUN.Size = new Size(551, 20);
            TXBNOMEFUN.Enabled = true;
            TXBNOMEFUN.Location = new Point(497, 299);
            TXBCARGOFUN.Visible = true;
            TXBCARGOFUN.Size = new Size(265, 20);
            TXBCARGOFUN.Enabled = true;
            TXBCARGOFUN.Location = new Point(1054, 299);
            TXBSALARIOFUN.Visible = true;
            TXBSALARIOFUN.Enabled = true;
            TXBSALARIOFUN.Size = new Size(111, 20);
            TXBSALARIOFUN.Location = new Point(1325, 299);
            TXBENCARGOSFUN.Visible = true;
            TXBENCARGOSFUN.Enabled = true;
            TXBENCARGOSFUN.Size = new Size(69, 20);
            TXBENCARGOSFUN.Location = new Point(1441, 299);
            TXBCPFFUN.Visible = true;
            TXBCPFFUN.Enabled = true;
            TXBCPFFUN.Size = new Size(111, 20);
            TXBCPFFUN.Location = new Point(411, 344);
            TXBRGFUN.Visible = true;
            TXBRGFUN.Enabled = true;
            TXBRGFUN.Size = new Size(111, 20);
            TXBRGFUN.Location = new Point(528, 344);
            TXBCNHFUN.Visible = true;
            TXBCNHFUN.Enabled = true;
            TXBCNHFUN.Size = new Size(111, 20);
            TXBCNHFUN.Location = new Point(645, 344);
            TXBCERTRESFUN.Visible = true;
            TXBCERTRESFUN.Enabled = true;
            TXBCERTRESFUN.Size = new Size(111, 20);
            TXBCERTRESFUN.Location = new Point(761, 344);
            TXBCEPFUN.Visible = true;
            TXBCEPFUN.Enabled = true;
            TXBCEPFUN.Size = new Size(111, 20);
            TXBCEPFUN.Location = new Point(878, 344);
            TXBENDFUN.Visible = true;
            TXBENDFUN.Enabled = false;
            TXBENDFUN.Size = new Size(515, 20);
            TXBENDFUN.Location = new Point(995, 344);
            TXBBAIRROFUN.Visible = true;
            TXBBAIRROFUN.Enabled = false;
            TXBBAIRROFUN.Size = new Size(191, 20);
            TXBBAIRROFUN.Location = new Point(411, 389);
            TXBCIDADEFUN.Visible = true;
            TXBCIDADEFUN.Enabled = false;
            TXBCIDADEFUN.Size = new Size(159, 20);
            TXBCIDADEFUN.Location = new Point(609, 389);
            TXBUFFUN.Visible = true;
            TXBUFFUN.Enabled = false;
            TXBUFFUN.Size = new Size(50, 20);
            TXBUFFUN.Location = new Point(774, 389);
            TXBNUMEROFUN.Visible = true;
            TXBNUMEROFUN.Enabled = true;
            TXBNUMEROFUN.Size = new Size(70, 20);
            TXBNUMEROFUN.Location = new Point(830, 389);
            TXBCOMPFUN.Visible = true;
            TXBCOMPFUN.Enabled = true;
            TXBCOMPFUN.Size = new Size(160, 20);
            TXBCOMPFUN.Location = new Point(905, 389);
            CBBDESCRICAO.Visible = true;
            CBBDESCRICAO.Enabled = true;
            CBBDESCRICAO.Size = new Size(250, 20);
            CBBDESCRICAO.Location = new Point(1070, 389);
            TXBBONIFIFUN.Visible = true;
            TXBBONIFIFUN.Enabled = true;
            TXBBONIFIFUN.Size = new Size(90, 20);
            TXBBONIFIFUN.Location = new Point(1325, 389);
            TXBTOTALFUN.Visible = true;
            TXBTOTALFUN.Enabled = true;
            TXBTOTALFUN.Size = new Size(90, 20);
            TXBTOTALFUN.Location = new Point(1420, 389);
            TXBDATADEMISSAO.Visible = true;
            TXBDATADEMISSAO.Enabled = true;
            TXBDATADEMISSAO.Size = new Size(80, 20);
            TXBDATADEMISSAO.Location = new Point(1315, 520);
            TXBTEMPO.Visible = true;
            TXBTEMPO.Enabled = true;
            TXBTEMPO.Size = new Size(111, 20);
            TXBTEMPO.Location = new Point(1400, 520);
        }

        // OCULTA OS TEXTBOX PARA CADASTRO DE FUNCIONÁRIOS
        public void TXBCADASTROFUNCIONARIOSOCULTO()
        {
            TXBDATAFUN.Visible = false;
            TXBNOMEFUN.Visible = false;
            TXBCARGOFUN.Visible = false;
            TXBSALARIOFUN.Visible = false;
            TXBENCARGOSFUN.Visible = false;
            TXBCPFFUN.Visible = false;
            TXBRGFUN.Visible = false;
            TXBCNHFUN.Visible = false;
            TXBCERTRESFUN.Visible = false;
            TXBCEPFUN.Visible = false;
            TXBENDFUN.Visible = false;
            TXBBAIRROFUN.Visible = false;
            TXBCIDADEFUN.Visible = false;
            TXBUFFUN.Visible = false;
            TXBNUMEROFUN.Visible = false;
            TXBCOMPFUN.Visible = false;
            CBBDESCRICAO.Visible = false;
            TXBBONIFIFUN.Visible = false;
            TXBTOTALFUN.Visible = false;
            TXBDATADEMISSAO.Visible = false;
            TXBTEMPO.Visible = false;
        }

        // FORMULÁRIO CENTRO DE CUSTO
        private void CENTRODECUSTO_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "CENTRO DE CUSTO";
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(230, 50);
            label2.Size = new Size(1500, 100);
            label2.Font = new Font("arial black", 48);

            MNS5();
            LABELFORMULARIOSVISIVEIS();
            INSERIRVISIVEL();
            PESQUISARVISIVEL();
            AsteriscosFalse();

            TXBCADASTROCENTRODECUSTO();
            CADPAPELINVISIVEL();
            TXBCADASTROFUNCIONARIOSOCULTO();

            CBB2.Visible = false;

            DadosDoClienteParaCadastroFalse();

            RB1.Focus();
        }

        // EXIBE E HABILITA OS TEXTBOX PARA CADASTRO DE CENTRO DE CUSTO
        public void TXBCADASTROCENTRODECUSTO()
        {
            TXBDESCRICAO.Visible = true;
            TXBDESCRICAO.Size = new Size(358, 20);
            TXBDESCRICAO.Enabled = true;
            TXBDESCRICAO.Location = new Point(521, 250);
            CBBDESCRICAO.Visible = false;
            CBBDESCRICAO.Size = new Size(358, 20);
            CBBDESCRICAO.Enabled = true;
            CBBDESCRICAO.Location = new Point(521, 250);
            CBBTIPO.Visible = true;
            CBBTIPO.Size = new Size(121, 20);
            CBBTIPO.Enabled = true;
            CBBTIPO.Location = new Point(885, 250);
            TXBNHP.Visible = true;
            TXBNHP.Size = new Size(60, 20);
            TXBNHP.Enabled = true;
            TXBNHP.Location = new Point(1012, 250);
            TXBSUBSIDIAR.Visible = true;
            TXBSUBSIDIAR.Size = new Size(100, 20);
            TXBSUBSIDIAR.Enabled = true;
            TXBSUBSIDIAR.Location = new Point(1078, 250);
            CBBTURNO.Visible = true;
            CBBTURNO.Size = new Size(50, 20);
            CBBTURNO.Enabled = true;
            CBBTURNO.Location = new Point(1184, 250);
            CBBTIPOHORA.Visible = true;
            CBBTIPOHORA.Size = new Size(200, 20);
            CBBTIPOHORA.Enabled = true;
            CBBTIPOHORA.Location = new Point(1240, 250);

            RB1.Text = "INSERIR";
            RB1.Visible = true;
            RB1.Size = new Size(14, 13);
            RB1.Location = new Point(650, 290);
            RB2.Text = "EXCLUIR";
            RB2.Visible = true;
            RB2.Size = new Size(14, 13);
            RB2.Location = new Point(1260, 290);
        }

        // OCULTA FORMULÁRIO CENTRO DE CUSTO
        public void CENTRODECUSTOOCULTO()
        {
            TXBDESCRICAO.Visible = false;
            CBBDESCRICAO.Visible = false;
            CBBTIPO.Visible = false;
            TXBNHP.Visible = false;
            TXBSUBSIDIAR.Visible = false;
            CBBTURNO.Visible = false;
            CBBTIPOHORA.Visible = false;

            RB1.Visible = false;
            RB2.Visible = false;
        }

        // RB1 EXIBE AS TXB DO FORMULÁRIO CENTRO DE CUSTO
        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            TXBDESCRICAO.Visible = true;
            CBBDESCRICAO.Visible = false;
            CBBTIPO.Enabled = true;
            TXBNHP.Enabled = true;
            TXBSUBSIDIAR.Enabled = true;
            CBBTURNO.Enabled = true;
            CBBTIPOHORA.Enabled = true;

            TXBDESCRICAO.Focus();
        }

        // RB2 OCULTA AS TXB DO FORMULÁRIO CENTRO DE CUSTO
        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            TXBDESCRICAO.Visible = false;
            CBBDESCRICAO.Visible = true;
            CBBTIPO.Enabled = false;
            TXBNHP.Enabled = false;
            TXBSUBSIDIAR.Enabled = false;
            CBBTURNO.Enabled = false;
            CBBTIPOHORA.Enabled = false;

            CBBDESCRICAO.Focus();
        }
        // MENUSTRIPS
        public void MNS1()
        {
            MS1.Visible = true;
            MS1.MaximumSize = new Size(1904, 24);
            MS2.Visible = false;
            MS3.Visible = false;
            MS4.Visible = false;
            MS5.Visible = false;
            MS6.Visible = false;
            MS7.Visible = false;
        }

        public void MNS2()
        {
            MS1.Visible = false;
            MS2.Visible = true;
            MS2.MaximumSize = new Size(1904, 24);
            MS3.Visible = false;
            MS4.Visible = false;
            MS5.Visible = false;
            MS6.Visible = false;
            MS7.Visible = false;
        }

        public void MNS3()
        {
            MS1.Visible = false;
            MS2.Visible = false;
            MS3.Visible = true;
            MS3.MaximumSize = new Size(1904, 24);
            MS4.Visible = false;
            MS5.Visible = false;
            MS6.Visible = false;
            MS7.Visible = false;
        }

        public void MNS4()
        {
            MS1.Visible = false;
            MS2.Visible = false;
            MS3.Visible = false;
            MS4.Visible = true;
            MS4.MaximumSize = new Size(1904, 24);
            MS5.Visible = false;
            MS6.Visible = false;
            MS7.Visible = false;
        }

        public void MNS5()
        {
            MS1.Visible = false;
            MS2.Visible = false;
            MS3.Visible = false;
            MS4.Visible = false;
            MS5.Visible = true;
            MS5.MaximumSize = new Size(1904, 24);
            MS6.Visible = false;
            MS7.Visible = false;
        }

        public void MNS6()
        {
            MS1.Visible = false;
            MS2.Visible = false;
            MS3.Visible = false;
            MS4.Visible = false;
            MS5.Visible = false;
            MS6.Visible = true;
            MS6.MaximumSize = new Size(1904, 24);
            MS7.Visible = false;
        }

        public void MNS7()
        {
            MS1.Visible = false;
            MS2.Visible = false;
            MS3.Visible = false;
            MS4.Visible = false;
            MS5.Visible = false;
            MS6.Visible = false;
            MS7.Visible = true;
            MS7.MaximumSize = new Size(1904, 24);
        }

        // FORMULÁRIO CLIENTE
        private void CLIENTE()
        {
            label1.Visible = false;
            label2.Visible = true;
            label2.Text = "CLIENTE";
            label2.ForeColor = Color.Black;
            label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 75);
            label2.Font = new Font("arial black", 48);
            label25.Visible = false;

           /* label1.Visible = false;
            label2.Visible = true;
            label2.Text = "CLIENTE";
            label2.ForeColor = Color.Black;
            label2.Location = new Point(500, 50);
            label2.Size = new Size(900, 75);
            label2.Font = new Font("arial black", 48);
            label25.Visible = false; */

            BotoesInicialCadastroAtualizarExcluir();
            DATACLIENTE();
            DATAHORA();
            LABELFORMULARIOSVISIVEIS();
            TXBVISIVEIS();
            CBBCADASTROCLIENTE();
            INSERIRVISIVEL();
            MNS2();
            Asteriscos();
            LIMPARTXBCBB();
            TXBCADASTROFUNCIONARIOSOCULTO();
            CBB1.Focus();//CBBCLIENTE
        }

        // CHAMA O FORMULÁRIO CLIENTE E OCULTA AS LABELS CONTATO
        private void CLIENTE_Click(object sender, EventArgs e)
        {
            CLIENTE();
        }

        // COMBOBOX PARA ESCOLHER CADASTRO, ATUALIZAR E EXCLUIR CLIENTE
        private void CBBCLIENTE_Leave(object sender, EventArgs e)
        {
            // CADASTRARATUALIZAREXCLUIR();
            TXBVISIVEIS();
        }

        // COMBOBOX USADO PARA SELECIONAR CADASTRAR, ENTRADA OU SAÍDA - EXECUTA QUANDO PERDE O FOCO
        private void CBB1_Leave(object sender, EventArgs e) //CBBCLIENTE
        {
            ENTRADA_SAÍDA();
        }
    }
}










