using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class HinhTraiTim : HinhEllipse
    {
        #region - Thuộc tính -
        #endregion

        #region - Khởi tạo -

        public HinhTraiTim()
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

        public HinhTraiTim(Color mauVe, int kichThuocButVe)
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
            int width1 = ((diemBatDau.X + diemKetThuc.X) / 2 - diemBatDau.X);
            int heigh1 = ((diemBatDau.Y + diemKetThuc.Y) / 2 - diemBatDau.Y);
            int width2 = ((diemBatDau.X + diemKetThuc.X) / 2 - diemBatDau.X);
            int heigh2 = ((diemBatDau.Y + diemKetThuc.Y) / 2 - diemBatDau.Y);

            try
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawArc(but, diemBatDau.X, diemBatDau.Y, width1, heigh1, 180, 180);
                g.DrawArc(but, TaoDiemDieuKhien(2).X, TaoDiemDieuKhien(2).Y, width2, heigh2, 180, 180);
                g.DrawLine(but, A, TaoDiemDieuKhien(7));
                g.DrawLine(but, B, TaoDiemDieuKhien(7));
            }
            catch (Exception)
            { }
            

            but.Dispose();
        }

        #endregion
    }
}
