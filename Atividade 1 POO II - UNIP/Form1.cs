using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1_POO_II___UNIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            carregarPaises();


        }

     


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Pais pais = comboBox1.SelectedItem as Pais;
            if(pais != null)
            {
                bandeira.ImageLocation = pais.UrlImagem;
                ouro.Text = pais.Ouros.ToString();
                prata.Text = pais.Pratas.ToString();
                bronze.Text = pais.Bronzes.ToString();
                totalMedalhas.Text = pais.TotalMedalhas().ToString();
            
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bandeira.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bandeira.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ouro.Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            prata.Visible = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            bronze.Visible = checkBox3.Checked;
        }



        private void carregarPaises()
        {
            comboBox1.Items.Add(new Pais("Estados Unidos", 39, 41, 33, "https://s3.static.brasilescola.uol.com.br/be/conteudo/images/estados-unidos.jpg"));
            comboBox1.Items.Add(new Pais("China", 38, 32, 18, "https://www.estudopratico.com.br/wp-content/uploads/2016/02/bandeira-china-1-1200x675.jpg"));
            comboBox1.Items.Add(new Pais("Japao", 27, 14, 17, "https://www.br.emb-japan.go.jp/cultura/bandeira.jpg"));
            comboBox1.Items.Add(new Pais("Gra-Bretanha", 22, 21, 22, "https://t2yn28t0dw-flywheel.netdna-ssl.com/wp-content/uploads/2017/10/Bandeira-do-Reino-Unido.jpg"));
            comboBox1.Items.Add(new Pais("Atletas da Rússia", 20, 28, 23, "https://pubimg.band.uol.com.br/files/e5e17114b9748d23c67d.png"));
            comboBox1.Items.Add(new Pais("Australia", 17, 7, 22, "https://lh3.googleusercontent.com/proxy/H0P-Qj1eYXQrJr2PZLadbFfqzJzWlOb108m7HwIFtIOM5CnxQTyElJBN43E6zis-YjDrnx95duSw_6yn2g9qjRr_qukKCE-VhITnbx_rlKoLOCCJYUbZI7c4fvE"));
            comboBox1.Items.Add(new Pais("Holanda", 10, 12, 14, "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Flag_of_the_Netherlands.svg/255px-Flag_of_the_Netherlands.svg.png"));
            comboBox1.Items.Add(new Pais("França", 10, 12, 11, "https://static.todamateria.com.br/upload/fr/an/frana_a.jpg"));
            comboBox1.Items.Add(new Pais("Alemanha", 10, 11, 16, "https://rasbrindes.com.br/components/com_virtuemart/shop_image/product/Bandeira_da_Alem_52d936bf1a711.jpg"));
            comboBox1.Items.Add(new Pais("Itália", 10, 10, 20, "https://static.significados.com.br/foto/bandeira-italia-0-cke.jpg"));
            comboBox1.Items.Add(new Pais("Canadá", 7, 6, 11, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Flag_of_Canada.svg/800px-Flag_of_Canada.svg.png"));
            comboBox1.Items.Add(new Pais("Brasil", 7, 6, 8, "https://static.todamateria.com.br/upload/ba/nd/bandeiradobrasil-0-cke.jpg"));

        }

    }
}
