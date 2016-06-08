using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class ChonKhuVuc : HinhChuNhat
    {
        #region - Thuộc tính -
        #endregion

        #region - Khởi tạo -

        public ChonKhuVuc()
            : base()
        {
            soDiemDieuKhien = 0;
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

        // Vẽ
        public override void Ve(Graphics g)
        {
            
        }
        
        //Vẽ một khung hình chữ nhật bằng nét đứt
        public override void VeDiemDieuKhien(Graphics g)
        {
            Pen but = new Pen(Color.BlueViolet, 1);
            but.DashStyle = DashStyle.DashDot;
            but.DashOffset = 20;
            g.SmoothingMode = SmoothingMode.None;
            g.DrawRectangle(but, TaoHinhChuNhat(diemBatDau, diemKetThuc));
            but.Dispose();
        }

        #endregion
    }
}
