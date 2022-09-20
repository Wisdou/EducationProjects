using MetrologyHometask;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetrologyApp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void RefreshStatParameters()
        {
            this.ListData.Items.Clear();
            foreach (var c in Program.data)
            {
                this.ListData.Items.Add(c);
            }
            try
            {
                this.statParameters.Text = Analyser.GetReport(Program.data);
            }
            catch (ArgumentException e)
            {
                this.statParameters.Text = "Empty data.";
            }
        }
        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            if (TXTFileOpener.ShowDialog() == DialogResult.Cancel)
                return;
            var readData = DataReader.ReadTXTFile(TXTFileOpener.FileName, '\t').ToList();
            if (readData.Count() > 0)
            {
                Program.data = readData;
            }
            else
            {
                MessageBox.Show("Файл имеет неверный формат.");
            }
            RefreshStatParameters();
        }

        private void MenuFileSaver_Click(object sender, EventArgs e)
        {
            if (this.saveData.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveData.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, String.Join("\t", Program.data));
            MessageBox.Show("Файл сохранен");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ind = this.ListData.SelectedIndex;
            if (ind != -1)
            {
                Program.data.RemoveAt(ind);
            }
            RefreshStatParameters();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdder newadder = new FormAdder(this);
            newadder.Show();
        }

        private void MenuAnalysCombinatoricalCriteria_Click(object sender, EventArgs e)
        {
            CriteriaForm criteriaF = new CriteriaForm(new CombinatoricalCriteria());
            criteriaF.Show();
        }

        private void MenuAnalysAbbeCriteria_Click(object sender, EventArgs e)
        {
            CriteriaForm criteriaF = new CriteriaForm(new AbbeCriteria());
            criteriaF.Show();
        }

        private void MenuHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpf = new HelpForm(this);
            helpf.Show();
        }
    }
}
