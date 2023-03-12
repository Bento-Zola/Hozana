using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace texte
{
    public partial class CADASTRAMENTO : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=ZOLA\\SQLEXPRESS;Initial Catalog=TB_HOSANA;Integrated Security=true");
        SqlCommand command;
        string imgloc = "";
        public CADASTRAMENTO()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|ALL Files(*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    picEmp.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void picEmp_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Nome,Sobre_nome,imagem FROM TAB_SAVE_IMAGE WHERE ID = " + txtid.Text + "";
                if (conexao.State != ConnectionState.Open)
                    conexao.Open();
                command = new SqlCommand(sql, conexao);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    txtnome.Text = reader[0].ToString();
                    //txtsobre.Text = reader[1].ToString();
                    byte[] img = (byte[])(reader[2]);
                    if (img == null)
                        picEmp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picEmp.Image = Image.FromStream(ms);
                    }

                }
                else
                {
                    txtid.Text = "";
                    txtnome.Text = "";
                    //txtsobre.Text = "";
                    picEmp.Image = null;

                    MessageBox.Show("Este ID nao existe.");
                }
                conexao.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btngardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexao.State != ConnectionState.Open)
                    conexao.Open();
                command = new SqlCommand("insert into tb_ncasa(n_casa)values('" + txtcasa.Text + "')",conexao);
                command.Parameters.AddWithValue("@n_casa",txtcasa.Text);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command = new SqlCommand("insert into tb_rua(rua,idn_casa)values('" + txtrua.Text + "','"+txtcasa.Text+"')", conexao);
                command.Parameters.AddWithValue("@rua", txtrua.Text);
                command.Parameters.AddWithValue("@idn_casa", txtcasa.Text.ToString());
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "INSERT INTO TAB_SAVE_IMAGE(Nome,Sobre_nome,imagem)VALUES('" + txtnome.Text + "','" +  "',@img)";
                
                command = new SqlCommand(sql, conexao);
                command.Parameters.Add(new SqlParameter("@img", img));
                int x = command.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show(x.ToString() + " Dado(s) salvo.");
                txtnome.Text = "";
                //txtsobre.Text = "";
                picEmp.Image = null;

            }
            catch (Exception ex)
            {
                conexao.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CADASTRAMENTO_Load(object sender, EventArgs e)
        {

        }

        private void txtfilhom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
