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

namespace SumTwoNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        

     
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt files(*.txt) | *.txt | All files (*.*) | *.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                propertyGrid1.Refresh();
            }
        }
    }
}
