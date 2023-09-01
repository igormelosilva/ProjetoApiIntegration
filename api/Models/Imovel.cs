namespace api.Models
{
    public class Imovel
    {
        public int id { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public int dormitorio { get; set; }
        public int sala { get; set; }
        public int banheiro { get; set; }
        public int vaga { get; set; }
        public int tipo { get; set; }
    }
}
