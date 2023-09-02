using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop.Global;
using System.Xml.Linq;
using desktop.Models;
using desktop.Api;

namespace desktop.Forms
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Config.operation == Operation.Add)
            {
                try
                {
                    ApiImoveis apiImovel = new ApiImoveis();
                    Imovel imovel = new Imovel();
                    imovel.cidade = txtCity.Text;
                    imovel.bairro = txtDistrict.Text;
                    imovel.dormitorio = Convert.ToInt32(txtDormitory.Text);
                    imovel.sala = Convert.ToInt32(txtRoom.Text);
                    imovel.banheiro = Convert.ToInt32(txtWc.Text);
                    imovel.vaga = Convert.ToInt32(txtParking.Text);
                    if (rbAluguel.Checked)
                        imovel.tipo = 1;
                    else
                        imovel.tipo = 2;

                    bool response = apiImovel.AddImovel(imovel);

                    if (!response)
                        MessageBox.Show("Erro ao tentar gravar o produto");
                    else
                        this.Close();

                }
                catch (Exception ex)
                { }
            }
            else if (Config.operation == Operation.Edit)
            {
                try
                {
                    DialogResult dialog = MessageBox.Show("Confirma alteração?", "Alterar",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        ApiImoveis apiImovel = new ApiImoveis();
                        Imovel imovel = new Imovel();
                        imovel.cidade = txtCity.Text;
                        imovel.bairro = txtDistrict.Text;
                        imovel.dormitorio = Convert.ToInt32(txtDormitory.Text);
                        imovel.sala = Convert.ToInt32(txtRoom.Text);
                        imovel.banheiro = Convert.ToInt32(txtWc.Text);
                        imovel.vaga = Convert.ToInt32(txtParking.Text);
                        if (rbAluguel.Checked)
                            imovel.tipo = 1;
                        else
                            imovel.tipo = 2;


                        bool response = apiImovel.UpdateImovel(imovel);

                        if (!response)
                            MessageBox.Show("Erro ao tentar alterar");
                        else
                            this.Close();
                    }
                }
                catch (Exception ex)
                { }
            }
        }
    }
}
