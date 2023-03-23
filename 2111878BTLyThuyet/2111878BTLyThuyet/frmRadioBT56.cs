using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2111878BTLyThuyet
{
    public partial class frmRadioBT56 : Form
    {
        public frmRadioBT56()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdNam.Checked)
            {
                MessageBox.Show("Giới tính của bạn là Nam");
            }
            if (this.rdNu.Checked)
            {
                MessageBox.Show("Giới tính của bạn là Nữ");
            }
        }
    }
}
