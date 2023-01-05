using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace comunidade
{
    class FormataGrid
    {
        public void DefinirLarguras(DataGridView dgvMovimentos)
        {
            dgvMovimentos.Columns["verificacao"].Width = 40;
            dgvMovimentos.Columns["data"].Width = 70;
            dgvMovimentos.Columns["descricao"].Width = 100;
            dgvMovimentos.Columns["valorDebito"].Width = 100;
            dgvMovimentos.Columns["valorCredito"].Width = 110;
            dgvMovimentos.Columns["Saldo"].Width = 100;

        }

        public void DefinirCores(DataGridView dgvMovimentos)
        {
            dgvMovimentos.Columns["Saldo"].DefaultCellStyle.BackColor = Color.Lavender;

        }

        public void DefinirHeaders(DataGridView dgvMovimentos)
        {
            dgvMovimentos.Columns["id"].Visible = false;
            dgvMovimentos.Columns["idCliente"].Visible = false;

            dgvMovimentos.Columns["verificacao"].HeaderText = "V";
            dgvMovimentos.Columns["data"].HeaderText = "Data";
            dgvMovimentos.Columns["descricao"].HeaderText = "Descrição";
            dgvMovimentos.Columns["valorDebito"].HeaderText = "Valor Débito";
            dgvMovimentos.Columns["valorCredito"].HeaderText = "Valor Crédito";

            foreach (DataGridViewColumn col in dgvMovimentos.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);//incluir o System.Drawing;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

        }
        public void FormatarMoney()
        {


        }
        
    }
}
