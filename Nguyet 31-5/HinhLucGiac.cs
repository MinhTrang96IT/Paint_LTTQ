using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint
{
    class HinhLucGiac : HinhEllipse
    {
        #region - Thuộc tính -
        #endregion

        #region - Khởi tạo -

        public HinhLucGiac()
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

        public HinhLucGiac(Color mauVe, int kichThuocButVe)
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

            Point A = new Point(diemBatDau.X, diemBatDau.Y + (diemKetThuc.Y - diemBatDau.Y) / 4);
            Point B = new Point(diemKetThuc.X, diemBatDau.Y + (diemKetThuc.Y - diemBatDau.Y) / 4);
            Point C = new Point(diemBatDau.X, diemBatDau.Y + (diemKetThuc.Y - diemBatDau.Y) / 4 * 3);
            Point D = new Point(diemKetThuc.X, diemBatDau.Y + (diemKetThuc.Y - diemBatDau.Y) / 4 * 3);

            g.DrawLine(but, TaoDiemDieuKhien(2), B);
            g.DrawLine(but, B, D);
            g.DrawLine(but, D, TaoDiemDieuKhien(7));
            g.DrawLine(but, TaoDiemDieuKhien(7), C);
            g.DrawLine(but, C, A);
            g.DrawLine(but, A, TaoDiemDieuKhien(2));
            but.Dispose();
        }

        #endregion
    }
}
