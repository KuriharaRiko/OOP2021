using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202123DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personlDataGridView.Columns[0].Visible = false;
            personlDataGridView.Columns[1].HeaderText = "名前";
            personlDataGridView.Columns[2].HeaderText = "誕生日";
            personlDataGridView.Columns[3].HeaderText = "電話番号";
            personlDataGridView.Columns[4].HeaderText = "備考";
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202123DataSet.Personl' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.personlTableAdapter.Fill(this.infosys202123DataSet.Personl);
        }

        private void btNameFilter_Click(object sender, EventArgs e)
        {
            this.personlTableAdapter.FillByName(this.infosys202123DataSet.Personl, tbNameSearch.Text);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            personlDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            personlDataGridView.CurrentRow.Cells[2].Value = dtpDate.Value;
            personlDataGridView.CurrentRow.Cells[3].Value = tbTelephone.Text;
            personlDataGridView.CurrentRow.Cells[4].Value = tbMemo.Text;

            this.Validate();
            this.personlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202123DataSet);
        }

        private void personlDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // ０件なら処理をしない
            if (personlDataGridView.Rows.Count != 0)
            {
                tbName.Text = personlDataGridView.CurrentRow.Cells[1].Value.ToString();
                dtpDate.Value = (DateTime)personlDataGridView.CurrentRow.Cells[2].Value;
                tbTelephone.Text = personlDataGridView.CurrentRow.Cells[3].Value.ToString();
                tbMemo.Text = personlDataGridView.CurrentRow.Cells[4].Value.ToString();
            }    
        }

        private void btBirthdayFilter_Click(object sender, EventArgs e)
        {
            this.personlTableAdapter.FillByBithday(this.infosys202123DataSet.Personl, dtpBithdaySearch.Text);
        }
    }
}
