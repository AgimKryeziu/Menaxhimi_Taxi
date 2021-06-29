using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Shoferi
{
    public partial class ShoferiList : Form
    {
        public ShoferiList()
        {
            InitializeComponent();
        }

        public static DataTable lista;
        public static int shoferiId;
        ShoferiBLL shoferiBLL;
        bool albFlag = LogInForms.albFlag;
        private void ShoferiList_Load(object sender, EventArgs e)
        {
            PopulateShoferiList();
        }

        public void PopulateShoferiList()
        {
            shoferiBLL = new ShoferiBLL();
            lista = shoferiBLL.ShowShoferat();
            dgvShoferiList.DataSource = lista;
            dgvShoferiList.Columns["ShoferiId"].Visible = false;

            DataGridViewButtonColumn editButtton = new DataGridViewButtonColumn();
            editButtton.Name = "Edit";
            editButtton.HeaderText = "Edit";
            editButtton.Text = "Edit";
            editButtton.UseColumnTextForButtonValue = true;

            editButtton.Width = 60;
            dgvShoferiList.Columns.Add(editButtton);


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            deleteButton.Width = 60;
            dgvShoferiList.Columns.Add(deleteButton);
        }

        private void dgvShoferiList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            shoferiBLL = new ShoferiBLL();

            if (e.ColumnIndex == 0)
            {
                ShtoShofer addShofer = new ShtoShofer();
                ShtoShofer.isShto = false;
                shoferiId = Convert.ToInt32(dgvShoferiList.Rows[e.RowIndex].Cells[2].Value.ToString());
                addShofer.LoadData(shoferiId);
                addShofer.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                int shoferiId = Convert.ToInt32(dgvShoferiList.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (DialogResult.OK == MessageBox.Show("A jeni i sigurt qe deshironi te fshini kete item"))
                {
                    bool deleted = shoferiBLL.DeleteShofer(shoferiId);
                    if (deleted)
                    {
                        MessageBox.Show("Te dhenat jane fshir me sukses");
                        PopulateShoferiList();
                    }
                    else
                    {
                        MessageBox.Show("Fshirja e te dhenave deshtoi! provoni me vone");
                    }
                }
            }
        }


        private void btnShtoShofer_Click(object sender, EventArgs e)
        {
            ShtoShofer shtoShofer = new ShtoShofer();
            ShtoShofer.isShto = true;

            var changeLang = new ChangeLang();
            if (albFlag)
            {
                changeLang.UpdateConfig("language", "sq");
                shtoShofer.ShowDialog(); ;
            }
            else
            {
                changeLang.UpdateConfig("language", "en");
                shtoShofer.ShowDialog();
            }
            
        }

        private void btnEksportoExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application excelFile = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = excelFile.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                excelFile.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Shoferet";

                try
                {
                    for (int i = 0; i < dgvShoferiList.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvShoferiList.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dgvShoferiList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvShoferiList.Columns.Count; j++)
                        {
                            if (dgvShoferiList.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvShoferiList.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    excelFile.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(btm, 0, 0);
        }

        //Bitmap btm;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            //btm = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(btm);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Raporti per Shoferin";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date + "\n");
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.Footer = "Riinvest";
            printer.PrintDataGridView(dgvShoferiList);
        }
        private void btnHelpDriver_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"E:\Agim_Kryeziu\Semestri 4\TI1\Projekti_TI1\Faza 4\Manual\Shoferet.htm");

        }
    }
}
