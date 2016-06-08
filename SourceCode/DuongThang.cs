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
            congCuVe.AddLine(diemBatDau, diemKetThuc); //Khởi tạo một đường thẳng từ điểm bắt đầu và điểm kết thúc
            congCuVe.Widen(but);
            khuVucVe = new Region(congCuVe);
            khuVucVe.Union(congCuVe);
        }
        #endregion

        #region - Phương thức -

        //Vẽ
        public override void Ve(Graphics g)
        {
            Pen but = new Pen(mauBut, doDamButVe);
            g.SmoothingMode = SmoothingMode.AntiAlias;
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

        //Xác định lại diemBatDau và diemKetThuc khi nhấn vào 1 điểm điều khiển
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

            if (viTriChuotVaHinhVe > 0) //Nhấn chuột vào điểm điều khiển bất kỳ
            {
                kiemTraThayDoiKichThuoc = true; //Cho phép thay đổi kích thước
                ThayDoiDiem(viTriChuotVaHinhVe); //Đổi điểm đầu cuối nếu điểm nhấn là điểm đầu
                diemHienHanh = e.Location; //Cập nhập điểm hiện hành
            }
            else if (viTriChuotVaHinhVe == 0) //Nhấn vào trong hình
            {
                kiemTraDiChuyen = true; //Cho phép di chuyển
                diemHienHanh = e.Location; //Cập nhập điểm hiện hành
            }
            else //Nhấn chuột vào khung vẽ
            {
                //Khởi tạo điểm đầu cuối
                diemBatDau = e.Location;
                diemKetThuc = e.Location;
            }
        }

        public override void Mouse_Move(MouseEventArgs e)
        {
            if (kiemTraThayDoiKichThuoc)
            {
                ThayDoiKichThuocDoiTuong(viTriChuotVaHinhVe, e.Location);
            }
            else if (kiemTraDiChuyen)
            {
                //Tính khoảng cách giữa điểm chuột hiện tại và điểm chuột lúc bắt đầy nhấn
                int deltaX = e.X - diemHienHanh.X; 
                int deltaY = e.Y - diemHienHanh.Y;
                diemHienHanh = e.Location; //Cập nhập điểm hiện hành
                DiChuyen(deltaX, deltaY);
            }
            else
            {
                diemKetThuc = e.Location; //Cập nhập điểm kết thúc
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
            kiemTraThayDoiKichThuoc = false;
            viTriChuotVaHinhVe = -1;
        }

        #endregion
    }
}
