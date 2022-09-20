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
    public partial class CriteriaForm : Form
    {
        public CriteriaForm()
        {
            InitializeComponent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveCriteria.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveCriteria.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, String.Join("\t", criteriaInfo.Text));
            MessageBox.Show("Файл сохранен");
        }
    }
}
