using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class HinhEllipse : HinhChuNhat
    {
        #region Thuộc tính
        #endregion

        #region - Khởi tạo -

        public HinhEllipse()
            : base()
        {
            
        }

        public HinhEllipse(Color mauVe, int kichThuocButVe)
            : base(mauVe, kichThuocButVe)
        {
            soDiemDieuKhien = 8;
            diemBatDau.X = 0;
            diemBatDau.Y = 0;
            diemKetThuc.X = 0;
            diemKetThuc.Y = 1;
            Pen but = new Pen(mauBut, doDamButVe);
            congCuVe = new GraphicsPath();
            congCuVe.AddRectangle(new Rectangle(0, 0, 0, 1));
            congCuVe.Widen(but);
            khuVucVe = new Region(new Rectangle(0, 0, 0, 1));
            khuVucVe.Union(congCuVe);
        }

        #endregion

        #region - Phương thức -

        public override void Ve(Graphics g)
        {
            Pen but = new Pen(mauBut, doDamButVe);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawEllipse(but, TaoHinhChuNhat(diemBatDau, diemKetThuc));
            but.Dispose();
        }

        //Vẽ điểm điều khiển và khung nét đứt hình chữ nhật điều khiển
        public override void VeDiemDieuKhien(Graphics g)
        {
            Pen but1 = new Pen(Color.BlueViolet, 2);
            SolidBrush brush = new SolidBrush(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 1; i <= soDiemDieuKhien; i++)
            {
                g.DrawRectangle(but1, TaoHVDieuKhien(i));
                g.FillRectangle(brush, TaoHVDieuKhien(i));
            }
            but1.Dispose();
            brush.Dispose();

            Pen but2 = new Pen(Color.BlueViolet, 1);
            but2.DashStyle = DashStyle.DashDot;
            but2.DashOffset = 10;
            g.SmoothingMode = SmoothingMode.None;
            g.DrawRectangle(but2, TaoHinhChuNhat(diemBatDau, diemKetThuc));
            but2.Dispose();
        }

        #endregion
    }
}
