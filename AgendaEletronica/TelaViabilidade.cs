using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Bibliotecas inseridas com base no vídeo.
using System.Data.SqlClient;

namespace AgendaEletronica
{
    public partial class TelaViabilidade : Form
    {
        //Variaveis escopo.
        SqlConnection conexao = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\AgendaEletronica\AgendaEletronica\DataBaseContatos.mdf;Integrated Security=True;User Instance=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader LerDados;

        public TelaViabilidade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
            loadlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;

            bt_pesquisar.Visible = false;
            bt_novoContato.Visible = false;
            bt_salve.Visible = true;

            label1.Visible = true;
            id_texto.Visible = true;
            label2.Visible = true;
            nome_txt.Visible = true;
            label3.Visible = true;
            numero_txt.Visible = true;
            label4.Visible = true;
            email_txt.Visible = true;
            label5.Visible = true;
            tipo_txt.Visible = true;

        }

        private void bt_salve_Click(object sender, EventArgs e)
        {            
            if (id_txt.Text != "" && nome_txt.Text != "" && numero_txt.Text != "" && tipo_txt.Text != "")
            {
                conexao.Open();
                comando.CommandText = "insert into Contatos(Id, Nome, Numero, email, Tipo) values('" + id_txt.Text + "','" + nome_txt.Text + "', '" + numero_txt.Text + "', '" + email_txt.Text + "', '" + tipo_txt.Text + "')";
                comando.ExecuteNonQuery();
                comando.Clone();
                MessageBox.Show("Registro Salvo!!", "Informação!", MessageBoxButtons.OK);
                conexao.Close();

                id_txt.Text = "";
                nome_txt.Text = "";
                numero_txt.Text = "";
                email_txt.Text = "";
                tipo_txt.Text = "";


                dateTimePicker1.Visible = false;

                bt_pesquisar.Visible = true;
                bt_novoContato.Visible = true;
                bt_salve.Visible = false;

                label1.Visible = false;
                id_txt.Visible = false;
                label2.Visible = false;
                nome_txt.Visible = false;
                label3.Visible = false;
                numero_txt.Visible = false;
                label4.Visible = false;
                email_txt.Visible = false;
                label5.Visible = false;
                tipo_txt.Visible = false;
                loadlist();
            }
            else
            {
                MessageBox.Show("Digite corretamente os campos", "Atenção", MessageBoxButtons.OK);
            }
        }

        private void loadlist()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();

            conexao.Open();
            comando.CommandText = "select * from contatos";
            LerDados = comando.ExecuteReader();
            if (LerDados.HasRows)
            {
                while (LerDados.Read())
                {
                    listBox1.Items.Add(LerDados[0].ToString());
                    listBox2.Items.Add(LerDados[1].ToString());
                    listBox3.Items.Add(LerDados[2].ToString());
                    listBox4.Items.Add(LerDados[3].ToString());
                    listBox5.Items.Add(LerDados[4].ToString());
                }
            }
            conexao.Close();
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lis = sender as ListBox;
            if (lis.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = lis.SelectedIndex;
                listBox2.SelectedIndex = lis.SelectedIndex;
                listBox3.SelectedIndex = lis.SelectedIndex;
                listBox4.SelectedIndex = lis.SelectedIndex;
                listBox5.SelectedIndex = lis.SelectedIndex;
            }
        }
    }
}