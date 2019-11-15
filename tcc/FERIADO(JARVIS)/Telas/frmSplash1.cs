using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FERIADO_JARVIS_.Telas
{
    public partial class frmSplash1 : Form
    {
        public frmSplash1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            Telas.frmLogin r = new frmLogin();
            r.Show();

            timer1.Stop();
            Hide();
        }
    }
}
