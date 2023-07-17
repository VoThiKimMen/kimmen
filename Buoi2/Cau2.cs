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
    public partial class Cau2 : Form
    {
        public Cau2()
        {
            InitializeComponent();
        }
        void Cau2_ResizeEnd(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + "-" + height.ToString();
        }
        void Cau2_Load(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + "-" + height.ToString();
        }
    }
}
