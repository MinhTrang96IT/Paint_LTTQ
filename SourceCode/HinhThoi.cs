using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class HinhThoi : HinhEllipse
    {
        #region - Thuộc tính -
        #endregion

        #region - Khởi tạo -

        public HinhThoi()
            : base()
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

        public HinhThoi(Color mauVe, int kichThuocButVe)
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

        //Vẽ
        public override void Ve(Graphics g)
        {
            Pen but = new Pen(mauBut, doDamButVe);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(but, TaoDiemDieuKhien(2), TaoDiemDieuKhien(4));
            g.DrawLine(but, TaoDiemDieuKhien(4), TaoDiemDieuKhien(7));
            g.DrawLine(but, TaoDiemDieuKhien(7), TaoDiemDieuKhien(5));
            g.DrawLine(but, TaoDiemDieuKhien(5), TaoDiemDieuKhien(2));
            but.Dispose();
        }

        #endregion
    }
}
