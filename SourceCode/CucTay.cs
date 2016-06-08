using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    //Giống hình tự do. Màu bút mặc định màu trắng
    class CucTay : HinhTuDo
    {
        #region - Thuộc tính -
        #endregion

        #region - Khởi tạo -

        public CucTay()
            : base()
        {
            
        }

        public CucTay(Color mauVe, int kichThuocButVe)
            : base(mauVe, kichThuocButVe)
        {
            danhSachDiem = new List<Point>(2) { new Point(0, 0), new Point(0, 1) };
            congCuVe = new GraphicsPath();
            Pen but = new Pen(mauBut, doDamButVe);
            congCuVe.AddCurve(danhSachDiem.ToArray());
            congCuVe.Widen(but);
            khuVucVe = new Region(congCuVe);
            danhSachDiem.Clear();
        }

        #endregion

        #region - Phương thức -

        // Vẽ
        public override void Ve(Graphics g)
        {
            try
            {
                Pen pen = new Pen(mauBut, doDamButVe);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawCurve(pen, danhSachDiem.ToArray());
                pen.Dispose();
            }
            catch(Exception)
            {

            }
        }

        #endregion
    }
}
