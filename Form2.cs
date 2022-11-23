using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace import_export_excel
{
    public partial class Form2 : Form
    {
        protected InterfaceStudent calling_form;
        public Form2(InterfaceStudent calling_form)
        {
            InitializeComponent();
            this.calling_form = calling_form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int x = calling_form.dssv[0].ID;
            label1.Text = x.ToString();
        }
    }
}
