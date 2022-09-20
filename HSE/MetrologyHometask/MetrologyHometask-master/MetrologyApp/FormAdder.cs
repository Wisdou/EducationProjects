using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetrologyApp
{
    public partial class FormAdder : Form
    {
        MainWindow parentWindow;
        public FormAdder()
        {
            InitializeComponent();
        }

        public FormAdder(MainWindow res)
        {
            parentWindow = res;
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                double val = Convert.ToDouble(doubleInput.Text);
                Program.data.Add(val);
                parentWindow.RefreshStatParameters();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong input!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
