using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class DuongThang : DoiTuong
    {
        #region - Thuộc tính -
        #endregion

        #region - Khởi tạo -

        public DuongThang()
            : base()
        {
            soDiemDieuKhien = 2;
            diemBatDau.X = 0;
            diemBatDau.Y = 0;
            diemKetThuc.X = 0;
            diemKetThuc.Y = 1;
            Pen but = new Pen(mauBut, doDamButVe);
            congCuVe = new GraphicsPath();
            congCuVe.AddLine(diemBatDau, diemKetThuc);
            congCuVe.Widen(but);
            khuVucVe = new Region(congCuVe);
        }

        public DuongThang(Color mauVe, int kichThuocButVe)
            : base(mauVe, kichThuocButVe)
        {
            soDiemDieuKhien = 2;
            diemBatDau.X = 0;
            diemBatDau.Y = 0;
            diemKetThuc.X = 0;
            diemKetThuc.Y = 1;
            Pen but = new Pen(mauBut, doDamButVe);
            congCuVe = new GraphicsPath();
            congCuVe.AddLine(diemBatDau, diemKetThuc);
            congCuVe.Widen(but);
            khuVucVe = new Region(congCuVe);
        }
        #endregion

        #region - Phương thức -

        //Vẽ
        public override void Ve(Graphics g)
        {
            Pen but = new Pen(mauBut, doDamButVe);
            g.DrawLine(but, diemBatDau, diemKetThuc);
            but.Dispose();
        }

        //Tạo điểm điều khiển
        protected override Point TaoDiemDieuKhien(int viTriDiemDieuKhien)
        {
            if (viTriDiemDieuKhien == 1)
                return diemBatDau;

            return diemKetThuc;
        }

        //Xác định lại diemBatDau và diemKetThuc khi Click vào 1 điểm điều khiển
        protected override void ThayDoiDiem(int viTriDiemDieuKhien)
        {
            if (viTriDiemDieuKhien == 1)
            {
                Point diem = diemBatDau;
                diemBatDau = diemKetThuc;
                diemKetThuc = diem;
            }
        }

        //Thay đổi kích thước đối tượng khi biết 1 điểm điều khiển và điểm đến
        protected override void ThayDoiKichThuocDoiTuong(int viTriDiemDieuKhien, Point diem)
        {
            diemKetThuc = diem;
        }

        //Sự kiện chuột
        public override void Mouse_Down(MouseEventArgs e)
        {
            viTriChuotVaHinhVe = kiemTraViTriDiemNhan(e.Location);

            if (viTriChuotVaHinhVe > 0)
            {
                KiemTraThayDoiKichThuoc = true;
                ThayDoiDiem(viTriChuotVaHinhVe);
                diemHienHanh = e.Location;
            }
            else if (viTriChuotVaHinhVe == 0)
            {
                kiemTraDiChuyen = true;
                diemHienHanh = e.Location;
            }
            else
            {
                diemBatDau = e.Location;
                diemKetThuc.X = e.X;
                diemKetThuc.Y = e.Y - 1;
            }
        }

        public override void Mouse_Move(MouseEventArgs e)
        {
            if (KiemTraThayDoiKichThuoc == true)
            {
                ThayDoiKichThuocDoiTuong(viTriChuotVaHinhVe, e.Location);
            }
            else if (kiemTraDiChuyen == true)
            {
                int deltaX = e.X - diemHienHanh.X;
                int deltaY = e.Y - diemHienHanh.Y;
                diemHienHanh = e.Location;
                DiChuyen(deltaX, deltaY);
            }
            else
            {
                diemKetThuc = e.Location;
            }
        }

        public override void Mouse_Up(Object sender)
        {
            congCuVe = new GraphicsPath();
            Pen but = new Pen(mauBut, doDamButVe);
            congCuVe.AddLine(diemBatDau, diemKetThuc);
            congCuVe.Widen(but);
            khuVucVe = new Region(congCuVe);
            kiemTraDiChuyen = false;
            KiemTraThayDoiKichThuoc = false;
            viTriChuotVaHinhVe = -1;
        }

        #endregion
    }
}
