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
            congCuVe.AddRectangle(new Rectangle(0, 0, 0, 1));
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

        //Xác định lại diemBatDau và diemKetThuc khi Click vào 1 điểm điều khiển
        protected override void ThayDoiDiem(int viTriDiemDieuKhien)
        {
            if (viTriDiemDieuKhien == 1 || viTriDiemDieuKhien == 2 || viTriDiemDieuKhien == 4)
            {
                Point diem = diemBatDau;
                diemBatDau = diemKetThuc;
                diemKetThuc = diem;
            }

            if (viTriDiemDieuKhien == 3)
            {
                diemBatDau = TaoDiemDieuKhien(6);
                diemKetThuc = TaoDiemDieuKhien(3);
            }

            if (viTriDiemDieuKhien == 6)
            {
                diemBatDau = TaoDiemDieuKhien(3);
                diemKetThuc = TaoDiemDieuKhien(6);
            }
        }

        //Thay đổi kích thước đối tượng khi biết 1 điểm điều khiển và điểm đến
        protected override void ThayDoiKichThuocDoiTuong(int viTriDiemDieuKhien, Point diem)
        {
            int deltaX = diem.X - diemHienHanh.X;
            int deltaY = diem.Y - diemHienHanh.Y;
            diemHienHanh = diem;

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

            //if (viTriDiemDieuKhien == 2 || viTriDiemDieuKhien == 7)
            //{
            //    diemKetThuc.Y += deltaY;
            //}
            //else if (viTriDiemDieuKhien == 4 || viTriDiemDieuKhien == 5)
            //{
            //    diemKetThuc.X += deltaX;
            //}
            //else
            //{
            //    diemKetThuc = diem;
            //}
        }

        //Sự kiện chuột
        public override void Mouse_Down(MouseEventArgs e)
        {
            viTriChuotVaHinhVe = kiemTraViTriDiemNhan(e.Location);

            if (viTriChuotVaHinhVe > 0)
            {
                KiemTraThayDoiKichThuoc = true;
                //ThayDoiDiem(viTriChuotVaHinhVe);
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
                diemKetThuc = diemBatDau;
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
            congCuVe.AddRectangle(TaoHinhChuNhat(diemBatDau, diemKetThuc));
            congCuVe.Widen(but);
            khuVucVe = new Region(TaoHinhChuNhat(diemBatDau, diemKetThuc));
            khuVucVe.Union(congCuVe);
            kiemTraDiChuyen = false;
            KiemTraThayDoiKichThuoc = false;
            viTriChuotVaHinhVe = -1;
        }

        #endregion
    }
}
