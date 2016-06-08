using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmThayDoiKichThuoc : Form
    {
        public frmThayDoiKichThuoc()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MainPaint.ChieuDaiKhungVe = int.Parse(txtChieuDai.Text);
            MainPaint.ChieuRongKhungVe = int.Parse(txtChieuRong.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
