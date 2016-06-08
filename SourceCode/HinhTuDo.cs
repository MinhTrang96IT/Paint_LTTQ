using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class HinhTuDo : DoiTuong
    {
        #region - Thuộc tính -

        protected List<Point> danhSachDiem; //Danh sách chứa các điểm

        #endregion

        #region - Khởi tạo -

        public HinhTuDo()
            : base()
        {
            
        }

        public HinhTuDo(Color mauVe, int kichThuocButVe)
            : base(mauVe, kichThuocButVe)
        {
            danhSachDiem = new List<Point>(2) { new Point(0, 0), new Point(0, 1) }; // Khởi tạo hai điểm ban đầu
            congCuVe = new GraphicsPath();
            Pen pen = new Pen(mauBut, doDamButVe);
            congCuVe.AddCurve(danhSachDiem.ToArray()); 
            congCuVe.Widen(pen);
            khuVucVe = new Region(congCuVe); ;
            danhSachDiem.Clear();
        }

        #endregion

        #region - Phương thức -

        //Vẽ
        public override void Ve(Graphics g)
        {
            try
            {
                Pen but = new Pen(mauBut, doDamButVe);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawCurve(but, danhSachDiem.ToArray());
                but.Dispose();
            }
            catch (Exception) { }
            
        }

        //Sự kiện chuột
        public override void Mouse_Down(MouseEventArgs e)
        {
            danhSachDiem.Insert(danhSachDiem.Count, e.Location);
        }

        public override void Mouse_Move(MouseEventArgs e)
        {
            danhSachDiem.Insert(danhSachDiem.Count, e.Location);
        }

        #endregion
    }
}
