using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class HinhChuNhat : DoiTuong
    {
        #region - Thuộc tính -
        #endregion

        #region - Khởi tạo -

        public HinhChuNhat()
            : base()
        {
            
        }

        public HinhChuNhat(Color mauVe, int kichThuocButVe)
            : base(mauVe, kichThuocButVe)
        {
            soDiemDieuKhien = 8;
            diemBatDau.X = 0;
            diemBatDau.Y = 0;
            diemKetThuc.X = 0;
            diemKetThuc.Y = 1;
            Pen but = new Pen(mauBut, doDamButVe);
            congCuVe = new GraphicsPath();
            congCuVe.AddRectangle(new Rectangle(0, 0, 0, 1)); //Khởi tạo một hình chữ nhật từ điểm bắt đầu và điểm kết thúc
            congCuVe.Widen(but);
            khuVucVe = new Region(new Rectangle(0, 0, 0, 1));
            khuVucVe.Union(congCuVe);
        }

        #endregion

        #region - Phương thức -

        //Tạo hình chữ nhật từ tọa độ 2 điểm
        protected virtual Rectangle TaoHinhChuNhat(int x1, int y1, int x2, int y2)
        {
            if (x1 > x2)
            {
                int tam = x1;
                x1 = x2;
                x2 = tam;
            }

            if (y1 > y2)
            {
                int tam = y1;
                y1 = y2;
                y2 = tam;
            }

            return new Rectangle(x1, y1, x2 - x1, y2 - y1);
        }

        //Tạo hình chữ nhật từ 2 điểm
        protected virtual Rectangle TaoHinhChuNhat(Point pointA, Point pointB)
        {
            return TaoHinhChuNhat(pointA.X, pointA.Y, pointB.X, pointB.Y);
        }

        //Vẽ
        public override void Ve(Graphics g)
        {
            Pen but = new Pen(mauBut, doDamButVe);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawRectangle(but, TaoHinhChuNhat(diemBatDau, diemKetThuc));
            but.Dispose();
        }

        //Tạo điểm điều khiển
        protected override Point TaoDiemDieuKhien(int viTriDiemDieuKhien)
        {
            int x = 0, y = 0;
            int xTrungTam = (diemBatDau.X + diemKetThuc.X) / 2;
            int yTrungTam = (diemBatDau.Y + diemKetThuc.Y) / 2;

            switch (viTriDiemDieuKhien)
            {
                case 1:
                    {
                        x = diemBatDau.X;
                        y = diemBatDau.Y;
                        break;
                    }
                case 2:
                    {
                        x = xTrungTam;
                        y = diemBatDau.Y;
                        break;
                    }
                case 3:
                    {
                        x = diemKetThuc.X;
                        y = diemBatDau.Y;
                        break;
                    }
                case 4:
                    {
                        x = diemBatDau.X;
                        y = yTrungTam;
                        break;
                    }
                case 5:
                    {
                        x = diemKetThuc.X;
                        y = yTrungTam;
                        break;
                    }
                case 6:
                    {
                        x = diemBatDau.X;
                        y = diemKetThuc.Y;
                        break;
                    }
                case 7:
                    {
                        x = xTrungTam;
                        y = diemKetThuc.Y;
                        break;
                    }
                case 8:
                    {
                        x = diemKetThuc.X;
                        y = diemKetThuc.Y;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return new Point(x, y);
        }

        //Thay đổi kích thước đối tượng khi biết 1 điểm điều khiển và điểm đến
        protected override void ThayDoiKichThuocDoiTuong(int viTriDiemDieuKhien, Point diem)
        {
            //Tính khoảng cách giữa điểm hiện tại của chuột và điểm nhấn chuột trước đó 
            int deltaX = diem.X - diemHienHanh.X;
            int deltaY = diem.Y - diemHienHanh.Y;
            diemHienHanh = diem; //Cập nhập điểm hiện hành

            if (viTriDiemDieuKhien == 1)
            {
                diemBatDau.X += deltaX;
                diemBatDau.Y += deltaY;
            }

            else if (viTriDiemDieuKhien == 2)
            {
                diemBatDau.Y += deltaY;
            }

            else if (viTriDiemDieuKhien == 3)
            {
                diemBatDau.Y += deltaY;
                diemKetThuc.X += deltaX;
            }

            else if (viTriDiemDieuKhien == 4)
            {
                diemBatDau.X += deltaX;
            }

            else if (viTriDiemDieuKhien == 5)
            {
                diemKetThuc.X += deltaX;
            }

            else if (viTriDiemDieuKhien == 6)
            {
                diemBatDau.X += deltaX;
                diemKetThuc.Y += deltaY;
            }

            else if (viTriDiemDieuKhien == 7)
            {
                diemKetThuc.Y += deltaY;
            }

            else if (viTriDiemDieuKhien == 8)
            {
                diemKetThuc.X += deltaX;
                diemKetThuc.Y += deltaY;
            }
        }

        //Sự kiện chuột
        public override void Mouse_Down(MouseEventArgs e)
        {
            viTriChuotVaHinhVe = kiemTraViTriDiemNhan(e.Location);

            if (viTriChuotVaHinhVe > 0) //Nhấn chuột vào điểm điều khiển bất kỳ
            {
                kiemTraThayDoiKichThuoc = true; //Cho phép thay đổi kích thước
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
                diemKetThuc = diemBatDau;
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
                diemKetThuc = e.Location; // Cập nhập điểm kết thúc
            }
        }

        public override void Mouse_Up(Object sender)
        {
            congCuVe = new GraphicsPath();
            Pen but = new Pen(mauBut, doDamButVe);
            congCuVe.AddRectangle(TaoHinhChuNhat(diemBatDau, diemKetThuc));
            congCuVe.Widen(but);
            khuVucVe = new Region(TaoHinhChuNhat(diemBatDau, diemKetThuc));
            khuVucVe.Union(congCuVe);
            kiemTraDiChuyen = false;
            kiemTraThayDoiKichThuoc = false;
            viTriChuotVaHinhVe = -1;
        }

        #endregion
    }
}
