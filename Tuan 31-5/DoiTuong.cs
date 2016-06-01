using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class DoiTuong
    {
        #region - Thuộc tính -

        public Color mauBut;
        public int doDamButVe;
        public Point diemBatDau;
        public Point diemKetThuc;
        protected Point diemHienHanh;
        protected int soDiemDieuKhien;
        protected GraphicsPath congCuVe;
        protected Region khuVucVe;
        protected int viTriChuotVaHinhVe;
        public bool kiemTraDiChuyen;
        public bool KiemTraThayDoiKichThuoc;

        #endregion

        #region Khởi tạo

        public DoiTuong()
        {
            mauBut = Color.Black;
            doDamButVe = 1;
        }

        public DoiTuong(Color mauVe, int kichThuocButVe)
        {
            mauBut = mauVe;
            doDamButVe = kichThuocButVe;
        }

        #endregion

        #region - Phương thức -

        public bool KiemTra(int x, int y)
        {
            int xMax = diemKetThuc.X > diemBatDau.X ? diemKetThuc.X : diemBatDau.X;
            int xMin = diemKetThuc.X > diemBatDau.X ? diemBatDau.X : diemKetThuc.X;
            int yMax = diemKetThuc.Y > diemBatDau.Y ? diemKetThuc.Y : diemBatDau.Y;
            int yMin = diemKetThuc.Y > diemBatDau.Y ? diemBatDau.Y : diemKetThuc.Y;
            if (x >= xMin && x <= xMax && y >= yMin && y <= yMax)
                return true;
            return false;
        }

        //Hoán vị điểm đầu cuối
        public virtual void ThayDoi()
        {
            if (diemBatDau.X > diemKetThuc.X && diemBatDau.Y > diemKetThuc.Y)
            {
                int tam = diemKetThuc.X;
                diemKetThuc.X = diemBatDau.X;
                diemBatDau.X = tam;
            }
            if (diemBatDau.X < diemKetThuc.X && diemBatDau.Y > diemKetThuc.Y)
            {
                int tam = diemKetThuc.Y;
                diemKetThuc.Y = diemBatDau.Y;
                diemBatDau.Y = tam;
            }
        }

        //Vẽ
        public virtual void Ve(Graphics g)
        {

        }

        //Tạo điểm điều khiển
        protected virtual Point TaoDiemDieuKhien(int viTriDiemDieuKhien)
        {
            return new Point(0, 0);
        }

        //Tạo HCN quanh điểm điều khiển
        protected virtual Rectangle TaoHVDieuKhien(int viTriDiemDieuKhien)
        {
            Point point = TaoDiemDieuKhien(viTriDiemDieuKhien);
            return new Rectangle(point.X - 1, point.Y - 1, 3, 3);
        }

        //Vẽ điểm điều khiển
        public virtual void VeDiemDieuKhien(Graphics g)
        {
            Pen but = new Pen(Color.BlueViolet, 2);
            SolidBrush brush = new SolidBrush(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 1; i <= soDiemDieuKhien; i++)
            {
                g.DrawRectangle(but, TaoHVDieuKhien(i));
                g.FillRectangle(brush, TaoHVDieuKhien(i));
            }

            but.Dispose();
            brush.Dispose();
        }

        //Kiểm tra xem điểm có thuộc đối tượng hay không
        protected virtual bool kiemTraDiemTrongDoiTuong(Point diem)
        {
            if (khuVucVe.IsVisible(diem) == true)
                return true;

            return false;
        }

        //Kiểm tra vị trí tương đối của 1 điểm và 1 đối tượng
        //- 1 : Nằm ngoài đối tượng
        //0   : Trong đối tượng
        //> 1 : Điểm điều khiển 
        public virtual int kiemTraViTriDiemNhan(Point diem)
        {
            for (int i = 1; i <= soDiemDieuKhien; i++)
            {
                if (TaoHVDieuKhien(i).Contains(diem) == true)
                    return i;
            }

            if (kiemTraDiemTrongDoiTuong(diem) == true)
                return 0;

            return -1;
        }

        //Xác định lại diemBatDau và diemKetThuc khi Click vào 1 điểm điều khiển
        protected virtual void ThayDoiDiem(int viTriDiemDieuKhien)
        {

        }

        //Di chuyển đối tượng khi kiemTraDiChuyen = true
        protected virtual void DiChuyen(int deltaX, int deltaY)
        {
            diemBatDau.X += deltaX;
            diemBatDau.Y += deltaY;
            diemKetThuc.X += deltaX;
            diemKetThuc.Y += deltaY;
        }

        //Thay đổi kích thước đối tượng khi biết điểm điều khiển và điển đến, kiemtraThayDoiKichThuoc = true
        protected virtual void ThayDoiKichThuocDoiTuong(int viTriDiemDieuKhien, Point diem)
        {

        }

        //Sự kiện chuột
        public virtual void Mouse_Down(MouseEventArgs e)
        {

        }

        public virtual void Mouse_Move(MouseEventArgs e)
        {

        }

        public virtual void Mouse_Up(Object sender)
        {

        }

        #endregion
    }
}
