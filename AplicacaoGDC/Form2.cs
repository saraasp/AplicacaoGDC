using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using comunidade;

namespace gdc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Conecta obj = new Conecta();
            string ssql = "Select * from Clientes";
            string sc = obj.GetStringConnection();
            dgvClientes.DataSource = obj.BuscaDados(sc, ssql);

            //Formatar a grid dos Clientes
            dgvClientes.Columns["nomeCliente"].Width = 150;
            dgvClientes.Columns["id"].Visible = false;

            dgvClientes.Columns["nomeCliente"].HeaderText = "Nome Cliente";
            dgvClientes.Columns["marcador"].HeaderText = "Marcador";
            dgvClientes.Columns["refInterna"].HeaderText = "Ref. Interna";

            foreach (DataGridViewColumn col in dgvClientes.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);//incluir o System.Drawing;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnRecolonizarClientes_Click(object sender, EventArgs e)
        {

            //botao recolonizar tabela Clientes e Movimentos

            Colonias colonia = new Colonias();
            colonia.RecolonizarTabelaDeClientesEMovimentos();
            
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            
            string ssql2 = "Select * from Clientes";
            dgvClientes.DataSource = obj.BuscaDados(sc, ssql2);
        }
        
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            //Remover clientes selecionando a linha a remover na grid
            Conecta obj = new Conecta();
            Form3 f3 = new Form3();

            string sc = obj.GetStringConnection();

            string nomeCliente = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            string ssql3 = "delete movimentos from movimentos inner join clientes on idCliente=Clientes.id where nomeCliente='" + nomeCliente + "'; ";
            string ssql = "Delete from clientes where nomeCliente='" + nomeCliente + "';";
            string ssql2 = "Select * from Clientes";
            string ssql4 = "Select refInterna from Clientes where nomeCliente='" + nomeCliente + "';";

            //recolher a refInterna do Cliente selecionado
            DataTable dt = new DataTable();
            dt = obj.BuscaDados(sc, ssql4);
            string refInterna = dt.Rows[0][0].ToString();


            //MessageBox
            DialogResult confirm = MessageBox.Show("Deseja mesmo ELIMINAR cliente '"+nomeCliente+"' e TODOS os seus movimentos?", "Remover Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm==DialogResult.Yes)
            {
                f3.ShowDialog();
                string valor = f3.Texto;

                if (refInterna == valor)
                {
                    obj.BuscaDados(sc, ssql3);
                    obj.BuscaDados(sc, ssql);
                }
                else
                {
                    MessageBox.Show("Referência Interna não corresponde ao cliente selecionado!", "Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            dgvClientes.DataSource = obj.BuscaDados(sc, ssql2);
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            //Atualizar clientes na linha da grid

            Conecta obj = new Conecta();
            string ssql2 = "Select * from Clientes";
            string sc = obj.GetStringConnection();
            string nomeCliente = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            string marcador = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            string pk = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string refInterna = dgvClientes.CurrentRow.Cells[3].Value.ToString();

            string ssql = "Update Clientes set nomeCliente='" + nomeCliente + "', marcador='" + marcador + "', refInterna='" + refInterna + "' where id='" + pk + "' ;";

            obj.BuscaDados(sc, ssql);
            dgvClientes.DataSource = obj.BuscaDados(sc, ssql2);


        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            //Inserir cliente

            Conecta obj = new Conecta();

            string sc = obj.GetStringConnection();
            string ssql = "Insert into Clientes values ('" + txtNome.Text + "', '" + txtMarcador.Text + "', '" + txtRef.Text + "');";
            string ssql2 = "Select * from Clientes";

            obj.BuscaDados(sc, ssql);
            dgvClientes.DataSource = obj.BuscaDados(sc, ssql2);

            txtNome.Text = string.Empty;
            txtMarcador.Text = string.Empty;
            txtRef.Text= string.Empty;

        }
    }
    
    
}
