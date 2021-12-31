using System;
using System.Linq;
using System.Windows.Forms;
// Chỗ này viết code cho FORM nhập liệu Địa chất
// Nhập các thông số của Lớp Đất Để Tính Toán
// NGày 12/8/2021 Hoàn thành phần Giao diện của Phần mềm.

using excel = Microsoft.Office.Interop.Excel; // cái này thêm vào để load được Excel
using Microsoft.VisualBasic.CompilerServices;

namespace TranCongHau_59TH2_422359
{
    public partial class frm_thongtindiachat
    {
        public frm_thongtindiachat()
        {
            InitializeComponent();
        }

        private bool k;

        private void Frm_DiaChat_Load(object sender, EventArgs e)
        {
            k = true;
        }
        /// <summary>
    /// NÚt hoàn thành
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>


        private void btn_nhapexcel_Click(object sender, EventArgs e)
        {
            HamNhapExcel();
        }

        private void btn_xuatexcel_Click(object sender, EventArgs e)
        {
            Hamxuatexcel();
        }
        // nơi khai báo hàm nhập từ excel
        #region Hàm Nhập Excel
        private void HamNhapExcel()
        {
            this.dgv_diachat.Rows.Clear();
            this.OpenFileDialog1.FileName = "";
            this.OpenFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                excel.Application xlApp;
                excel.Workbook xlWorkBook;
                excel.Worksheet xlWorkSheet;
                xlApp = new excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(this.OpenFileDialog1.FileName);
                xlWorkSheet = (excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];
                // Dem so hang
                var sh = default(int);
                for (int i = 2; i <= 300; i++)
                {
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(xlWorkSheet.Cells[(object)i, (object)1].value, null, false)))
                    {
                        sh = i - 1;
                    }
                    else
                    {
                        break;
                    }
                }

                this.dgv_diachat.Rows.Clear();
                for (int i = 2, loopTo = sh + 1; i <= loopTo; i++)
                    this.dgv_diachat.Rows.Add(xlWorkSheet.Cells[(object)i, (object)1].value, xlWorkSheet.Cells[(object)i, (object)2].value, xlWorkSheet.Cells[(object)i, (object)3].value, xlWorkSheet.Cells[(object)i, (object)4].value, xlWorkSheet.Cells[(object)i, (object)5].value, xlWorkSheet.Cells[(object)i, (object)6].value, xlWorkSheet.Cells[(object)i, (object)7].value, xlWorkSheet.Cells[(object)i, (object)8].value, xlWorkSheet.Cells[(object)i, (object)9].value, xlWorkSheet.Cells[(object)i, (object)10].value, xlWorkSheet.Cells[(object)i, (object)11].value, xlWorkSheet.Cells[(object)i, (object)12].value);
                xlWorkBook.Close();
                xlApp.Quit();
            }
        }
        #endregion
        // nơi khai báo hàm xuất excel
        #region hàm Xuất Excel
        private void Hamxuatexcel()
        {
            var SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
            SaveFileDialog1.FilterIndex = 2;
            SaveFileDialog1.RestoreDirectory = true;
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                excel.Application xlApp;
                excel.Workbook xlWorkBook;
                excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlApp = new excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (excel.Worksheet)xlWorkBook.Sheets["Sheet1"];
                for (int i = 0, loopTo = this.dgv_diachat.ColumnCount - 1; i <= loopTo; i++)
                    xlWorkSheet.Cells[(object)1, (object)(i + 1)].value = this.dgv_diachat.Columns[i].HeaderText;
                for (int i = 0, loopTo1 = this.dgv_diachat.RowCount - 1; i <= loopTo1; i++)
                {
                    for (int j = 0, loopTo2 = this.dgv_diachat.ColumnCount - 1; j <= loopTo2; j++)
                        xlWorkSheet.Cells[(object)(i + 2), (object)(j + 1)].value = this.dgv_diachat.Rows[i].Cells[j].Value;
                }

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName);
                xlWorkBook.Close();
                xlApp.Quit();
            }
        }

        private void btn_nhap_excel_Click(object sender, EventArgs e)
        {
            HamNhapExcel();
        }
        #endregion
        // Thêm dữ liệu vào database
        #region Thêm  dữ liệu ở datagriview vào trong chỗ chứa để tính toán
        private void ClickToXacNhan(object sender, EventArgs e)
        {
            TranCongHau_59TH2_422359.model_database.dsDiachat.Clear(); // xóa trắng địa chất
            for (int i = 0, loopTo = this.dgv_diachat.RowCount - 1; i <= loopTo; i++)
            {
                var lopdat = new TranCongHau_59TH2_422359.model_thongsodiachat();
                lopdat.Lop = Convert.ToInt16(this.dgv_diachat.Rows[i].Cells[0].Value);
                lopdat.LoaiDat = Convert.ToString(this.dgv_diachat.Rows[i].Cells[1].Value);
                lopdat.TrangThai = Convert.ToString(this.dgv_diachat.Rows[i].Cells[2].Value);
                lopdat.ChieuDay = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[3].Value);
                lopdat.DungTrong = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[4].Value);
                lopdat.MoDun = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[5].Value);
                lopdat.GocMS = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[6].Value);
                lopdat.DoRoi = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[7].Value);
                lopdat.Qc = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[8].Value);
                lopdat.N30 = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[9].Value);
                lopdat.Hsk = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[10].Value);
                lopdat.Hsa = Convert.ToDouble(this.dgv_diachat.Rows[i].Cells[11].Value);
                TranCongHau_59TH2_422359.model_database.dsDiachat.Add(lopdat); // thêm lớp đất vào danh sách
            }

            if (TranCongHau_59TH2_422359.model_database.dsDiachat.Count == 0)
            {
                TranCongHau_59TH2_422359.MessengerTieuChuan.Error123("Chưa có dữ liệu!");
            }
            else
            {
                TranCongHau_59TH2_422359.MessengerTieuChuan.ThongBaoThemLopDatTHanhCong(); // Thêm xong thì thông báo thành công
                this.Close();
            }
        }

        private void Btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}