using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comunidade
{
    class CalculosNaGrid
    {
        public void PreencherColunaDosSaldos(DataGridView dgvMovimentos, ListBox lstClientes)
        {
            //preencher a coluna saldo
            Conecta obj = new Conecta();
            string sc = obj.GetStringConnection();
            
            double saldo = 0;
            double valorDebito = 0;
            double valorCredito = 0;


            //ir buscar à tabela o valor de credito e debito da 1º linha do cliente selecionado

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
                saldo = valorCredito - valorDebito;
                dgvMovimentos.CurrentRow.Cells["saldo"].Value = Convert.ToDouble(saldo);
            }
            catch (Exception)
            {
                saldo = 0;
            }
            
            //string ssql3 = "Select valorCredito from movimentos where idCliente='" + lstClientes.SelectedValue + "' ";
            //DataTable dt = new DataTable();

            //try
            //{
            //    dt = obj.BuscaDados(sc, ssql3);
            //    valorCredito = Convert.ToDouble(dt.Rows[0][0]);
            //}
            //catch (Exception)
            //{
            //    valorCredito = 0;

            //}

            //string ssql4 = "Select valorDebito from movimentos where idCliente='" + lstClientes.SelectedValue + "' ";

            //try
            //{
            //    dt = obj.BuscaDados(sc, ssql4);
            //    valorDebito = Convert.ToDouble(dt.Rows[0][0]);
            //}
            //catch (Exception)
            //{
            //    valorDebito = 0;

            //}

            //try
            //{
            //    saldo = valorCredito - valorDebito;
            //    dgvMovimentos.Rows[0].Cells["saldo"].Value = saldo;
            //}
            //catch (Exception)
            //{

            //}


            //calculos na grid a partir da linha 1
            for (int i = 1; i < dgvMovimentos.Rows.Count - 1; i++)
            {
                try
                {
                    valorDebito = Convert.ToDouble(dgvMovimentos.Rows[i].Cells["valorDebito"].Value);
                }
                catch (Exception)
                {
                    valorDebito = 0;
                }

                try
                {
                    valorCredito = Convert.ToDouble(dgvMovimentos.Rows[i].Cells["valorCredito"].Value);
                }
                catch (Exception)
                {
                    valorCredito = 0;

                }

                try
                {

                    saldo = Convert.ToDouble(dgvMovimentos.Rows[i - 1].Cells["saldo"].Value) + (valorCredito + (-valorDebito));
                    dgvMovimentos.Rows[i].Cells["saldo"].Value = saldo;
                }
                catch (Exception)
                {


                }

            }


        }

        public void PreencherTextBoxTotal(DataGridView dgvMovimentos, TextBox txtAcumuladoDebito, TextBox txtAcumuladoCredito)
        {
            //preencher acumulados do débito e do crédito nas textboxs
            double valorDebito = 0;
            double somaValorDebito = 0;

            for (int i = 0; i < dgvMovimentos.Rows.Count - 1; i++)
            {
                try
                {
                    valorDebito = Convert.ToDouble(dgvMovimentos.Rows[i].Cells["valorDebito"].Value);
                }
                catch (Exception)
                {

                    valorDebito = 0;
                }


                somaValorDebito = somaValorDebito + valorDebito;

            }

            txtAcumuladoDebito.Text = Convert.ToString(somaValorDebito) + " €";

            double valorCredito = 0;
            double somaValorCredito = 0;

            for (int i = 0; i < dgvMovimentos.Rows.Count - 1; i++)
            {
                try
                {
                    valorCredito = Convert.ToDouble(dgvMovimentos.Rows[i].Cells["valorCredito"].Value);
                }
                catch (Exception)
                {

                    valorCredito = 0;
                }


                somaValorCredito = somaValorCredito + valorCredito;

            }

            txtAcumuladoCredito.Text = Convert.ToString(somaValorCredito) + " €";


        }

    }
}
