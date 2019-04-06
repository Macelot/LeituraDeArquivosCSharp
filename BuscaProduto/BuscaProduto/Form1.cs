using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BuscaProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("clnName","Nome");
            
            try
            {
                string[] linhas = System.IO.File.ReadAllLines("..\\..\\produtos.txt");
                Array.Sort(linhas);
                foreach (string l in linhas)
                {
                    dataGridView1.Rows.Add(l);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Falha na abertura do arquivo produtos.txt");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                List<Produto> produtos = new List<Produto>();
                string[] linhas = System.IO.File.ReadAllLines("..\\..\\produtos2.txt");
                Array.Sort(linhas);
                foreach (string l in linhas)
                {

                    string[] np = l.Split(';');
                    Produto p = new Produto(np[0],float.Parse(np[1]));
                    produtos.Add(p);
                    
                }
                dataGridView1.DataSource = produtos;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Falha na abertura do arquivo produtos.txt");
            }
        }
    }
}
