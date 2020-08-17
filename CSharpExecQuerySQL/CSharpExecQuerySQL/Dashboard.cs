using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExecQuerySQL
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            dateTimePicker2.Value = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, DateTime.DaysInMonth(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month) );

            //Initialize the listbox
            UpdateBinding();
        }

        //Refreshing the DataGridView
        private void UpdateBinding()
        {
            dataGridView.DataSource = sqlDataSet;
            dataGridView.AutoGenerateColumns = true;
        }

        //Button
        private void searchButton_Click(object sender, EventArgs e)
        {
            //string queryStr = "SELECT ARCKOD FROM dbo.ARACKART";
            //int caseNum = 1; //Placeholder for possibly choosing what to do after connecting when the form first boots.

            DataAccesss db = new DataAccesss();

            string theDate1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string theDate2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
 
            //sqlDataSet = db.GetData(FirstDateTextBoxDay.Text, LastDateTextBoxDay.Text, FirstDateTextBoxMonth.Text, LastDateTextBoxMonth.Text, FirstDateTextBoxYear.Text, LastDateTextBoxYear.Text);
            sqlDataSet = db.GetData(theDate1, theDate2);
            UpdateBinding();
            dataGridView.DataMember = "Table1";
        }

        private void exportExcelButton_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Check if the excel is properly installed
            if (app == null)
            {
                MessageBox.Show("Excel bilgisayarınızda yüklü değil veya eski bir versiyonu yüklü.");
            }
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;  
            // get the default and store its reference to worksheet  
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }

            try
            {
                // save the application  
                workbook.Save();
                MessageBox.Show("Excel dosyanız belgelerim klasörüne kaydedildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kaydederken sorun oluştu! Excel'i kullanarak kaydediniz. Bu sorun belgelerim dizininde aynı isimde bir dosya olduğundan kaynaklanıyor olabilir.");
            }
            finally
            {
                // Exit from the application  
                app.Quit();
            }
        }
    }
}
