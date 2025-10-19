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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void deleteStation_Click(object sender, EventArgs e)
        {
            usun usunWindow = new usun();
            usunWindow.Show();
        }
        private void deleteBike_Click(object sender, EventArgs e) 
        {
            usun usunWindow = new usun();
            usunWindow.Show();
        }
        private void deleteAccounts_Click(object sender, EventArgs e)
        {
            usun usunWindow = new usun();
            usunWindow.Show();
        }
        private void addAccounts_Click(object sender, EventArgs e)
        {
            daneUżytkownicy daneUżytkownik = new daneUżytkownicy();
            daneUżytkownik.Show();
        }
        private void addBike_Click(object sender, EventArgs e)
        {
            daneRowery daneRowerow = new daneRowery();
            daneRowerow.Show();
        }
        private void addStation_Click(object sender, EventArgs e)
        {
            daneStacja daneStacji = new daneStacja();
            daneStacji.Show();
        }
    }
}
