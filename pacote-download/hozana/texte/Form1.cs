using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texte
{
    public partial class HOZANA : Form
    {
        public HOZANA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection("Data Source=ZOLA\\SQLEXPRESS;Initial Catalog=TB_HOSANA;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select * from tb_login where Usuario='" + TXTUSUARIO.Text + "' and Password='" + TXTSENHA.Text + "' ", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbitemvalue = cbcargos.SelectedItem.ToString();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["Nivel_usuario"].ToString() == cmbitemvalue)
                        {
                            MessageBox.Show("Login feito com sucesso como " + dt.Rows[i][3]);
                            if (cbcargos.SelectedIndex == 0)
                            {
                                 CLASSES f = new CLASSES();
                                f.Show();
                                this.Hide();
                            }
                            else if (cbcargos.SelectedIndex == 1)
                            {
                                CADASTRAMENTO ff = new CADASTRAMENTO();
                                ff.Show();
                                this.Hide();
                            }
                            else
                            {
                                //ESSA É PARA CONTABILIDADE
                                CADASTRAMENTO ff = new CADASTRAMENTO();
                                ff.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("voce nao é " + cmbitemvalue);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Username and Password don't match");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTUSUARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTSENHA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

