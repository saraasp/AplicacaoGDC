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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carregar a lstClientes e a dgvMovimentos
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();

            string ssql2 = "Select * from clientes";
            lstClientes.ValueMember = "id";
            lstClientes.DisplayMember = "nomeCliente";
            lstClientes.DataSource = obj.BuscaDados(sc, ssql2);
            
            //index da listbox selecionado no terceiro nome
            try
            {
                lstClientes.SelectedIndex = 2;
            }
            catch (Exception)
            {

            }
            string ssql = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "';";
            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql);
            
            //adicionar a coluna saldo
            dgvMovimentos.Columns.Add("saldo", "Saldo");

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);

            //Formatar a grid
            FormataGrid formataGrid = new FormataGrid();
            formataGrid.DefinirLarguras(dgvMovimentos);
            formataGrid.DefinirHeaders(dgvMovimentos);
            formataGrid.DefinirCores(dgvMovimentos);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            //Filtrar os movimentos na grid pela textbox
            Conecta obj = new Conecta();

            string sc = obj.GetStringConnection();

            try
            {
                string ssql2 = "SELECT * FROM clientes WHERE nomeCliente LIKE '%" + txtFiltro.Text + "%'";
                lstClientes.DataSource = obj.BuscaDados(sc, ssql2);
            }
            catch (Exception)
            {
            }
            try
            {
                string ssql = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "';";
                dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql);
            }
            catch (Exception)
            {
            }
            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstClientesAoClicar(object sender, EventArgs e)
        {
            //ao selecionar na listbox enviar para a grid os movimentos apenas desse cliente
            Conecta obj = new Conecta();
            
            string ssql = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "';";


            string sc = obj.GetStringConnection();
            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ir para o form2

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnInserirMovimento_Click(object sender, EventArgs e)
        {
            //Inserir movimento

            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "';";

            if (txtDebito.Text != "" && txtCredito.Text != "")
            {
                MessageBox.Show("Imposivel inserir! os campos valor débito e crédito estão ambos preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDebito.Text = "";
                txtCredito.Text = "";
            }
            else if (txtDebito.Text == "" && txtCredito.Text == "")
            {
                MessageBox.Show("Imposivel inserir! os campos valor débito ou crédito não estão preenchidos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "\nCliente:" + lstClientes.GetItemText(lstClientes.SelectedItem) + "\n Valor a Débito:" + txtDebito.Text + "\n Valor a Crédito:" + txtCredito.Text + "\n\n\n Confirma?", "Verifique os dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    string ssql = "Insert into movimentos (data, descricao, valorDebito, valorCredito, idCliente) values ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txtDescricao.Text + "', '" + txtDebito.Text + "','" + txtCredito.Text + "','" + lstClientes.SelectedValue.ToString() + "');";

                    obj.BuscaDados(sc, ssql);
                }
            }

            //carregar a grid
            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //apagar 
            txtDescricao.Text = "";
            txtDebito.Text = "";
            txtCredito.Text = "";

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);
            
        }

        private void bntRefreshClientes_Click(object sender, EventArgs e)
        {
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            string ssql2 = "Select * from clientes";
            lstClientes.ValueMember = "id";
            lstClientes.DisplayMember = "nomeCliente";
            lstClientes.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);
        }

        private void recolonizarMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Recolonizar tabela Movimentos
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();

            Colonias colonia = new Colonias();
            colonia.RecolonizarTabelaDeMovimentos();

            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "';";
            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);
        }

        private void txtAcumuladoDebito_TextChanged(object sender, EventArgs e)
        {

        }

        private void eliminarEntreDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //eliminar movimento
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "'; ";
            string ssql = "";

            try
            {
                int id = Convert.ToInt32(dgvMovimentos.CurrentRow.Cells["id"].Value);

                DataGridViewCellCollection cells = dgvMovimentos.CurrentRow.Cells;
                string data = Convert.ToDateTime(cells["data"].Value).ToString("yyyy-MM-dd");

                string descricao = dgvMovimentos.CurrentRow.Cells["descricao"].Value.ToString();
                string valorDebito = dgvMovimentos.CurrentRow.Cells["valorDebito"].Value.ToString();
                string valorCredito = dgvMovimentos.CurrentRow.Cells["valorCredito"].Value.ToString();
                string idCliente = dgvMovimentos.CurrentRow.Cells["idCliente"].Value.ToString();

                DialogResult confirm = MessageBox.Show("Deseja mesmo eliminar?\n" +
                "Movimento:" + id + "\n Data:" + data + "\n Descrição:" + descricao + "\n Valor Débito:" + valorDebito + "\n " +
                " Valor Crédito:" + valorCredito + "", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    ssql = "Delete from movimentos where id='" + id + "';";
                    obj.BuscaDados(sc, ssql);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor selecione uma linha da grid");
            }
            
            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);

        }

        private void eliminarEntreDatasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //eliminar movimentos entre datas
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "'; ";
            string ssql3 = "";
            
            //guardar os valores do datetimepicker
            string datainicio = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string datafim = dateTimePicker3.Value.ToString("yyyy-MM-dd");

            //Fazer a contagem dos movimentos entre datas
            string ssql = "Select count(*) from movimentos where idCliente= '"+ lstClientes.SelectedValue.ToString() + "' and data between'" + datainicio + "' and '"+datafim+"'";
            DataTable dt= obj.BuscaDados(sc, ssql);
            string contagem = Convert.ToString(dt.Rows[0][0]);

            DialogResult confirm=MessageBox.Show("Deseja mesmo eliminar entre datas?\n Nº de movimentos:"+contagem+"\n Data Inicio:"+datainicio+"\n" +
                "Data fim:"+datafim+"", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirm== DialogResult.Yes)
            {
                ssql3 = "Delete from movimentos where idCliente= '" + lstClientes.SelectedValue.ToString() + "' and data between'" + datainicio + "' and '" + datafim + "'";
                obj.BuscaDados(sc, ssql3);
            }

            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);
        }

        private void modificarMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Modificar movimento no menu
            //Não está a funcionar 
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "'; ";
            string ssql3 = "";

            int id = Convert.ToInt32(dgvMovimentos.CurrentRow.Cells["id"].Value);
            string data = dgvMovimentos.CurrentRow.Cells["data"].Value.ToString();
            string descricao = dgvMovimentos.CurrentRow.Cells["descricao"].Value.ToString();
            string verificacao = dgvMovimentos.CurrentRow.Cells["verificacao"].Value.ToString();
            double valorDebito = 0;
            double valorCredito = 0;

            try
            {
                valorDebito = Convert.ToDouble(dgvMovimentos.CurrentRow.Cells["valorDebito"].Value);
               
            }
            catch (Exception)
            {
                valorDebito = 0;
            }
            try
            {
                valorCredito = Convert.ToDouble(dgvMovimentos.CurrentRow.Cells["valorCredito"].Value);
            }
            catch (Exception)
            {
                valorCredito = 0;
            }

            try
            {
                ssql3 = "Update movimentos set descricao='" + descricao + "', verificacao='" + verificacao + "', valorDebito='" + Convert.ToDouble(valorDebito) + "'," +
                        " valorCredito='" + Convert.ToDouble(valorCredito) + "' where id='" + id + "' ;";
                obj.BuscaDados(sc, ssql3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);


        }

        private void btnAtualizarMovimento_Click(object sender, EventArgs e)
        {
            //Modificar movimento no botão
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "'; ";
            string ssql3 = "";
            int id = 0;
            string data = "";
            string descricao="";
            string verificacao="";
            try
            {
                id = Convert.ToInt32(dgvMovimentos.CurrentRow.Cells["id"].Value);

                DataGridViewCellCollection cells = dgvMovimentos.CurrentRow.Cells;
                data = Convert.ToDateTime(cells["data"].Value).ToString("yyyy-MM-dd");

                descricao = dgvMovimentos.CurrentRow.Cells["descricao"].Value.ToString();
                verificacao = dgvMovimentos.CurrentRow.Cells["verificacao"].Value.ToString();
            }
            catch (Exception)
            {
                
            }
            
            double valorDebito = 0;
            double valorCredito = 0;

            try
            {
                valorDebito = Convert.ToDouble(dgvMovimentos.CurrentRow.Cells["valorDebito"].Value);

            }
            catch (Exception)
            {
                valorDebito = 0;
            }
            try
            {
                valorCredito = Convert.ToDouble(dgvMovimentos.CurrentRow.Cells["valorCredito"].Value);
            }
            catch (Exception)
            {
                valorCredito = 0;
            }

            try
            {
                ssql3 = "Update movimentos set data='"+data+"', descricao='" + descricao + "', verificacao='" + verificacao + "', valorDebito='" + Convert.ToDouble(valorDebito) + "'," +
                        " valorCredito='" + Convert.ToDouble(valorCredito) + "' where id='" + id + "' ;";
                obj.BuscaDados(sc, ssql3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);
        }

        private void btnListarDatas_Click(object sender, EventArgs e)
        {
            //Listar Cliente entre datas

            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();

            //guardar os valores do datetimepicker
            string datainicio = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string datafim = dateTimePicker3.Value.ToString("yyyy-MM-dd");

            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "'and data between'" + datainicio + "' and '" + datafim + "'; ";

            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);

        }

        private void btnListarMesCorrente_Click(object sender, EventArgs e)
        {
            //Listar Mês Corrente

            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();

            //Mês Corrente
            DateTime data = DateTime.Today;
            int mesCorrente = data.Month;

            string ssql2 = "Select * from movimentos where idCliente='" + lstClientes.SelectedValue.ToString() + "'and month(data)='" + mesCorrente + "';";

            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);

        }

        private void btnListarEntreDatas_Click(object sender, EventArgs e)
        {
           
        }

        private void balanceteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Balancete todos os clientes mês corrente

            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();

            //Mês Corrente
            DateTime data = DateTime.Today;
            int mesCorrente = data.Month;

            string ssql2 = "Select * from movimentos where month(data)='" + mesCorrente + "';";

            dgvMovimentos.DataSource = obj.BuscaDados(sc, ssql2);

            //metodo preencher coluna do saldo
            CalculosNaGrid calculosNaGrid = new CalculosNaGrid();
            calculosNaGrid.PreencherColunaDosSaldos(dgvMovimentos, lstClientes);

            //preencher acumulados do débito e do crédito nas textboxs
            calculosNaGrid.PreencherTextBoxTotal(dgvMovimentos, txtAcumuladoDebito, txtAcumuladoCredito);
        }

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
