namespace GRAFICA2.CLASSES
{
    class ENDERECO
    {
        public string RUA;
        public string NUMERO;
        public string COMPLEMENTO;
        public string BAIRRO;
        public string CIDADE;
        public string ESTADO;
        public string CEP;

        public string rua { get => RUA; set => RUA = value; }
        public string numero { get => NUMERO; set => NUMERO = value; }
        public string complemento { get => COMPLEMENTO; set => COMPLEMENTO = value; }
        public string bairro { get => BAIRRO; set => BAIRRO = value; }
        public string cidade { get => CIDADE; set => CIDADE = value; }
        public string estado { get => ESTADO; set => ESTADO = value; }
        public string cep { get => CEP; set => CEP = value; }
    }
}
