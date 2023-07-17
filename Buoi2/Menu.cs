using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnCau1_Click(object sender, EventArgs e)
        {
            Cau1 trang1 = new Cau1();
            trang1.Show();
        }
        private void btnCau2_Click(object sender, EventArgs e)
        {
            Cau2 trang2 = new Cau2();
            trang2.Show();
        }
    }
}
