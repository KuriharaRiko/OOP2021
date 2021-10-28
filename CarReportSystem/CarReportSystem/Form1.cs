using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class fmMain : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain()
        {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // アプリケーション終了
        }

        // 画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        // 画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        // 追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e)
        {
            if (cbAuthor.Text == "" || cbCarName.Text == "")
            {
                MessageBox.Show("全ての項目を入力してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CarReport carReport = new CarReport
            {
                Date = dtpDate.Value,
                Auter = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };
            listCarReport.Add(carReport);   // 1レコード追加

            setCbAuter(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }

        // 選択されているメーカーの列挙型を返す
        private CarReport.Makergroup selectedGroup()
        {
            foreach (var rb in gbMaker.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    return (CarReport.Makergroup)int.Parse((string)((RadioButton)rb).Tag);
                }
            }
            return CarReport.Makergroup.その他;
        }
        // コンボボックスに記録者をセットする
        private void setCbAuter(string auter)
        {
            if (cbAuthor.Items.Contains(auter))
            {
                cbAuthor.Items.Add(auter);
            }
        }
        // コンボボックスに車名をセットする
        private void setCbCarName(string carName)
        {
            if (cbCarName.Items.Contains(carName))
            {
                cbCarName.Items.Add(carName);
            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // 選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            // 取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auter;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }

        private void setMakerRadioButton(CarReport.Makergroup mg)
        {
            switch (mg)
            {
                case CarReport.Makergroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.Makergroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.Makergroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.Makergroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.Makergroup.外国車:
                    rbImport.Checked = true;
                    break;
                default:    // その他
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDataDelete_Click(object sender, EventArgs e)
        {
            //listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btDataCorrect_Click(object sender, EventArgs e)
        {
            //listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,cbAuthor.Text,selectedGroup(),cbCarName.Text,tbReport.Text,pbPicture.Image);
            //dgvRegistData.Refresh();    // コントロールの強制再描画
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    // 日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    // 記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  // メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   // 車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    // レポート

            // データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202123DataSet);
#if false
            if (sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                // バイナリ形式でシリアル化
                var bf = new BinaryFormatter();

                using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create))
                {
                    bf.Serialize(fs, listCarReport);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
#endif
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202123DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202123DataSet.CarReport);

#if false
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                // バイナリ形式で逆シリアル化
                var bf = new BinaryFormatter();
                using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                    // 逆シリアル化して読み込む
                    listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                    dgvRegistData.DataSource = null;
                    dgvRegistData.DataSource = listCarReport;
                }
                // 読み込んだデータを各コンボボックスに登録する
                
            }
        }

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202123DataSet);

        }
#endif
        }

        private void fmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
