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
    public partial class frmComBoBoxBT48 : Form
    {
        public frmComBoBoxBT48()
        {
            InitializeComponent();
        }

        private void frmComBoBoxBT48_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
            this.cboNgonNgu.DataSource= datas;
        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboNgonNgu.SelectedItem.ToString());
        }
    }
}
