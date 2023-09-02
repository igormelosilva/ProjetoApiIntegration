using desktop.Models;
using desktop.Api;
using desktop.Forms;
using desktop.Global;

namespace desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadImoveis();
        }
        private void LoadImoveis()
        {
            ApiImoveis apiImoveis = new ApiImoveis();
            dgvImovel.DataSource = apiImoveis.GetAllImoveis();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Config.operation = Operation.Add;

                FrmAdd add = new FrmAdd();
                add.ShowDialog();
            }
            catch (Exception ex)
            { }
        }
    }
}