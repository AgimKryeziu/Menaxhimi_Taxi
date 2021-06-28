using DGVPrinterHelper;
using System;
using System.Data;
using System.Windows.Forms;
using Taxi.BLL;
using Taxi.BO;

namespace Taxi.Automjeti
{
    public partial class Automjeti : Form
    {
        public Automjeti()
        {
            InitializeComponent();
        }

        private void Automjeti_Load(object sender, EventArgs e)
        {
            PopulateAutomjetiList();
        }

        bool albFlag = LogInForms.albFlag;

        public static DataTable lista;
        AutomjetiBLL automjetiBLL;
        public static int automjetiId;

        public void PopulateAutomjetiList()
        {
            automjetiBLL = new AutomjetiBLL();
            lista = automjetiBLL.ShowAllCab();
            dgvAutomjeti.DataSource = lista;
            dgvAutomjeti.Columns["AutomjetiId"].Visible = false;

            DataGridViewButtonColumn editButtton = new DataGridViewButtonColumn();
            editButtton.Name = "Edit";
            editButtton.HeaderText = "Edit";
            editButtton.Text = "Edit";
            editButtton.UseColumnTextForButtonValue = true;

            editButtton.Width = 60;
            dgvAutomjeti.Columns.Add(editButtton);


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();

            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            deleteButton.Width = 60;
            dgvAutomjeti.Columns.Add(deleteButton);
        }

        private void btnShtoAutomjet_Click(object sender, EventArgs e)
        {
            Taxi.Automjeti.ShtoAutomjet shtoAutomjet = new ShtoAutomjet();
            ShtoAutomjet.isShto = true;

            if (albFlag)
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "sq");
                shtoAutomjet.ShowDialog();
            }
            else
            {
                var changeLang = new ChangeLang();
                changeLang.UpdateConfig("language", "en");
                shtoAutomjet.ShowDialog();
            }
        }

        private void dgvAutomjeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            automjetiBLL = new AutomjetiBLL();

            if (e.ColumnIndex == 0)
            {
                ShtoAutomjet addAutomjet = new ShtoAutomjet();
                ShtoAutomjet.isShto = false;
                automjetiId = Convert.ToInt32(dgvAutomjeti.Rows[e.RowIndex].Cells[2].Value.ToString());
                addAutomjet.LoadData(automjetiId);
                addAutomjet.ShowDialog(); 

            }
            if (e.ColumnIndex == 1)
            {
                int automjetiId = Convert.ToInt32(dgvAutomjeti.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (DialogResult.OK == MessageBox.Show("A jeni i sigurt qe deshironi te fshini kete item"))
                {
                    bool deleted = automjetiBLL.DeleteAutomjet(automjetiId);
                    if (deleted)
                    {
                        MessageBox.Show("Te dhenat jane fshir me sukses");
                        PopulateAutomjetiList();
                    }
                    else
                    {
                        MessageBox.Show("Fshirja e te dhenave deshtoi! provoni me vone");
                    }
                }
            }
           

        }

        private void exportToExcel_Click(object sender, EventArgs e)
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
                    for (int i = 0; i < dgvAutomjeti.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvAutomjeti.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dgvAutomjeti.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvAutomjeti.Columns.Count; j++)
                        {
                            if (dgvAutomjeti.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvAutomjeti.Rows[i].Cells[j].Value.ToString();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Raporti per Automjet";
            printer.SubTitle = string.Format("Data: {0}", DateTime.Now.Date + "\n");
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.Footer = "Riinvest";
            printer.PrintDataGridView(dgvAutomjeti);
        }
    }
}
