using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
namespace import_export_excel
{
    public partial class Formf : Form,InterfaceStudent
    {
        public Formf()
        {
            InitializeComponent();
        }
        public List<student> dssv { get; set; } = new List<student>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_import_Click(object sender, EventArgs e)
        {
            student t = new student(4);
            dssv.Add(t);
            MessageBox.Show("added student "  );
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\user\\Desktop\\abc.xlsx";
            Excel.Application excel_app = new Excel.Application();
            excel_app.Application.Workbooks.Add(Type.Missing);

            excel_app.Cells[1, 1] = textBox1.Text;
            excel_app.Cells[2, 1] = textBox2.Text;
            excel_app.Columns.AutoFit();
            excel_app.ActiveWorkbook.SaveCopyAs(path);
            excel_app.ActiveWorkbook.Saved = true;


            //Form2 f = new Form2(this);
            //f.ShowDialog();
        }
    }
}
