using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjWFFerramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // LoadGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var ferramenta = getFerramenta();
            if (Crud().Insert(ferramenta))
            {
                MessageBox.Show("Inserido com sucesso!");
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            dGVDados.DataSource = Crud().GetAll();
        }

        private Ferramentas getFerramenta()
        {
            return new Ferramentas
            {

                Descricao = txtDescricao.Text,
                Tipo = txtTipo.Text,
                Marca = txtMarca.Text,
                Preco = txtPreco.Text
            };
        }

        private IFerramentaDB Crud()
        {
            return new FerramentaDB();
        }

        private void btnGerarTxt_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo;
            var ferramenta = getFerramenta();
            string output = "";

            string diretorio = "C:\\Users\\mdsto\\Desktop\\.Net\\ProjWFAula1";
            arquivo = File.CreateText(diretorio);

            foreach (var item in Crud().GetAll())
                output += item.ToString();

            arquivo.WriteLine(output);

            arquivo.Close();
            MessageBox.Show("Arquivo gerado no diretório:\n" + diretorio);
        }
    }
}