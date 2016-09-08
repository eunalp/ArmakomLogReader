using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArmakomLogReader
{
    public partial class frmLogDetail : Form
    {
        public frmLogDetail()
        {
            InitializeComponent();
        }

        public DialogResult DisplayLogDetails(LogRecord log)
        {
            txtCallSite.Text    = log.CallSite;
            txtException.Text   = log.Exception;
            txtLevel.Text       = log.Level;
            txtLogger.Text      = log.Logger;
            txtLogTime.Text     = log.LogTime.ToString("dd-MM-yyyy HH:mm:ss");
            txtMessage.Text     = log.Message;
            return this.ShowDialog();
            //Comment written.
        }
    }
}
