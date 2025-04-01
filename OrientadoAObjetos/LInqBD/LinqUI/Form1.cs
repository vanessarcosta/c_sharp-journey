using LInqBD;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LinqUI
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ListView  *******
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Titulo");
            listView1.Columns.Add("Categoria");

            //carregar os filmes

            var lista = from Filme in dc.Filmes select Filme;

            foreach (Filme filme in lista)
            {
                ListViewItem item;
                item = listView1.Items.Add(filme.ID.ToString());
                item.SubItems.Add(filme.Titulo);
                item.SubItems.Add(filme.Categoria);
            }

            for (int i = 0; i <= 2; i++)
            {
                listView1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize); //organiza as colunas 
            }

            //TreeView *****

            var outraLista = from Categoria in dc.Categorias select Categoria;

            foreach (Categoria categoria in outraLista)
            {
                treeView1.Nodes.Add(categoria.Sigla);
            }

            //Segundo nível da árvore (Filmes)
            var listaFilmes = from Filme in dc.Filmes
                              orderby Filme.Titulo                                //distribuir os filmes pelo nos
                              select Filme;

            string catFilme;
                                                                //dectaectar o no e depois colocar o filme
           foreach (Filme filme in listaFilmes)
           {
                catFilme = filme.Categoria;

                foreach (TreeNode node in treeView1.Nodes)
                {
                    if (node.Text == catFilme)
                    {
                        node.Nodes.Add(filme.Titulo);
                    }
                }
           }

            //GridView ******

            dataGridView1.Columns.Add("colId", "ID");
            dataGridView1.Columns.Add("colTitulo", "Titulo");
            dataGridView1.Columns.Add("colCategoria", "Categoria");

            var outraListaDeFilmes = from Filme in dc.Filmes select Filme;

            int linha = 0;

            DataGridViewCellStyle estilo = new DataGridViewCellStyle();
            estilo.ForeColor = Color.Red;

            foreach (Filme filme in outraListaDeFilmes)
            {
                DataGridViewRow registro = new DataGridViewRow();            //defini a linha do dataGrid
                dataGridView1.Rows.Add(registro);                            //atribui linha nova dentro do dataGrid   

                //carregar os dados a cada coluna
                dataGridView1.Rows[linha].Cells[0].Value = filme.ID;
                dataGridView1.Rows[linha].Cells[1].Value = filme.Titulo;
                dataGridView1.Rows[linha].Cells[2].Value = filme.Categoria;

                if ((string)dataGridView1.Rows[linha].Cells[2].Value == "FA")
                {
                    dataGridView1.Rows[linha].DefaultCellStyle = estilo;   ///aplicar o estilo 
                }

                linha++;

            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
