using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class HopVanBan : HinhChuNhat
    {
        #region - Thuộc tính -

        //public TextBox hopChu;
        //private string chuoi;
        private Font phongChu;

        #endregion

        #region - Khởi tạo -

        public HopVanBan(Color mau, Font phong)
        {
            hopChu = new TextBox();
            hopChu.Validated += new EventHandler(tbValidate);
            hopChu.Multiline = true;
            hopChu.ForeColor = mau;
            hopChu.BackColor = Color.White;
            hopChu.Font = phong;
            mauBut = mau;
            phongChu = phong;
            soDiemDieuKhien = 0;
            diemBatDau.X = 0;
            diemBatDau.Y = 0;
            diemKetThuc.X = 0;
            diemKetThuc.Y = 1;
            Pen but = new Pen(mauBut, 1);
            congCuVe = new GraphicsPath();
            congCuVe.AddRectangle(new Rectangle(0, 0, 0, 1));
            congCuVe.Widen(but);
            khuVucVe = new Region(new Rectangle(0, 0, 0, 1));
            khuVucVe.Union(congCuVe);
        }

        #endregion

        #region - Phương thức -

        protected void tbValidate(Object sender, EventArgs e)
        {
            chuoi = hopChu.Text;
            if (chuoi != null)
                hopChu.Visible = false;
        }

        //Vẽ
        public override void Ve(Graphics g)
        {
            SolidBrush co = new SolidBrush(mauBut);
            g.DrawString(chuoi, phongChu, co, diemBatDau.X, diemBatDau.Y);
            co.Dispose();
        }

        //Sự kiện chuột
        public override void Mouse_Up(Object sender)
        {
            congCuVe = new GraphicsPath();
            Pen pen = new Pen(mauBut, doDamButVe);
            congCuVe.AddRectangle(TaoHinhChuNhat(diemBatDau, diemKetThuc));
            congCuVe.Widen(pen);
            khuVucVe = new Region(TaoHinhChuNhat(diemBatDau, diemKetThuc));
            khuVucVe.Union(congCuVe);
            kiemTraDiChuyen = false;
            kiemTraThayDoiKichThuoc = false;
            PictureBox hinhAnh = ((PictureBox)sender);
            hinhAnh.Parent.Controls.Add(hopChu);
            hopChu.Size = new Size(Math.Abs(diemKetThuc.X - diemBatDau.X), Math.Abs(diemKetThuc.Y - diemBatDau.Y));
            hopChu.Location = new Point(diemBatDau.X + hinhAnh.Location.X, diemBatDau.Y + hinhAnh.Location.Y);
            hopChu.BringToFront();
            hopChu.Show();
            hopChu.Focus();
        }

        #endregion
    }
}
