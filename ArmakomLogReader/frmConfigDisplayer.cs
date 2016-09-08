using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArmakomLogReader
{
    public partial class frmConfigDisplayer : Form
    {
        public frmConfigDisplayer()
        {
            InitializeComponent();
            ShowConfig();
        }

        private void ShowConfig()
        {
            string filePath = Path.Combine(Application.StartupPath, "Nlog.config");
            try
            {
                string fileContent = File.ReadAllText(filePath);
                txtDisplayer.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error while opening config. {0}", ex.ToString()));
            }
        }
    }
}
