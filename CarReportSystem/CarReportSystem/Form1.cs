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
                return;

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

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    // 日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;    // 記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  // メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   // 車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    // レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);  // 画像

            // データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202123DataSet);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202123DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202123DataSet.CarReport);

        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            carReportDataGridView.Columns[0].Visible = false;
            carReportDataGridView.Columns[1].HeaderText = "日付";
            carReportDataGridView.Columns[2].HeaderText = "記録者";
            carReportDataGridView.Columns[3].HeaderText = "メーカー";
            carReportDataGridView.Columns[4].HeaderText = "車名";
            carReportDataGridView.Columns[5].HeaderText = "レポート";
            carReportDataGridView.Columns[6].HeaderText = "画像";
            ssErrorLavel.Text = "";
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null) return;
            try
            {
                ssErrorLavel.Text = "";

                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;  // 日付
                cbAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();   // 記録者
                setMakerRadioButton((CarReport.Makergroup)Enum.Parse(typeof(CarReport.Makergroup),
                    carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));   // メーカー(文字列→列挙型)
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();  // 車名
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();   // レポート
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);   // 画像

                // メーカー（文字列→列挙型）
                var mk = (CarReport.Makergroup)Enum.Parse(typeof(CarReport.Makergroup), carReportDataGridView.CurrentRow.Cells[3].Value.ToString());
                setMakerRadioButton(mk);

                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);    // 画像
            }
            catch (InvalidCastException)
            {
                pbPicture.Image = null;
            }         
            catch(Exception ex)
            {
                // MessageBox.Show(ex.Message);
                ssErrorLavel.Text = ex.Message; // ステータスエリアに表示する
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {
            Image img = null;
            if (b.Length > 0)
            {
                ImageConverter imgconv = new ImageConverter();
                img = (Image)imgconv.ConvertFrom(b);
            }
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        // データグリットビューのエラー対応（暫定）
        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (carReportDataGridView.CurrentRow == null)
            {
                
            }            
        }

        // 新規ボタン押下
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            setMakerRadioButton(CarReport.Makergroup.その他);
            pbPicture.Image = null;
        }
    }
}
