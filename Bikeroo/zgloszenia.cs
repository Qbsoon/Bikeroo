using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikeroo
{
    public partial class zgloszenia : Form
    {
        public zgloszenia()
        {
            InitializeComponent();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            // funkcja wysyłająca zgłoszenie
            this.Close();
        }
    }
}
