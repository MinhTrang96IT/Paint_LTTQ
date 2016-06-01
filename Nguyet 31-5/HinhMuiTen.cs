using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class HinhMuiTen : HinhEllipse
    {
        #region Thuộc tính
        #endregion

        #region - Khởi tạo -

        public HinhMuiTen()
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

        public HinhMuiTen(Color mauVe, int kichThuocButVe)
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
            Point A = new Point(diemBatDau.X + (diemKetThuc.X - diemBatDau.X) / 4, diemBatDau.Y);
            Point B = new Point(diemBatDau.X + (diemKetThuc.X - diemBatDau.X) / 4 * 3, diemBatDau.Y);
            Point C = new Point(diemBatDau.X + (diemKetThuc.X - diemBatDau.X) / 4, (diemBatDau.Y + diemKetThuc.Y) / 2);
            Point D = new Point(diemBatDau.X + (diemKetThuc.X - diemBatDau.X) / 4 * 3, (diemBatDau.Y + diemKetThuc.Y) / 2);

            g.DrawLine(but, A, B);
            g.DrawLine(but, B, D);
            g.DrawLine(but, D, TaoDiemDieuKhien(5));
            g.DrawLine(but, TaoDiemDieuKhien(5), TaoDiemDieuKhien(7));
            g.DrawLine(but, TaoDiemDieuKhien(7), TaoDiemDieuKhien(4));
            g.DrawLine(but, TaoDiemDieuKhien(4), C);
            g.DrawLine(but, C, A);
            but.Dispose();
        }


        #endregion
    }
}
