using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaCorporation
{
    public partial class FormMain : Form
    {
        public FormMain( )
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome, " + DataStorage.employeeName ;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FormProfile().Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Hide();
        }

        private void btnMutation_Click(object sender, EventArgs e)
        {
            new FormMutation().Show();
            Hide();
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            new FormPromotion().Show();
            Hide() ;
        }
    }
}
