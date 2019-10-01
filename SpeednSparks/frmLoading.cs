using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpeednSparks
{
    public partial class frmLoading : Form
    {
        public delegate void MethodPointer();
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)//1
        {
            Thread t = new Thread(openGamemenu);
            t.Start();
        }

        private void openGamemenu()
        {
            frmGamemenu gm = new frmGamemenu();
            Thread.Sleep(3000);
            this.Invoke(new MethodPointer(formClose));
            gm.ShowDialog();
        }
        private void formClose()
        {
            this.Close();
        }
    }
}
