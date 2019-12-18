using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt file (*.txt)|*.txt|All files(*.*)|*.*"
           saveFileDialog.RestoreDirctor = true;
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                PropertyGrid.Refresh();
            }
        }
    }
}
