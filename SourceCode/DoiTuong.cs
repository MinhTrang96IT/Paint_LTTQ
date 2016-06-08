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

        public Color mauBut; //Màu của hình vẽ
        public int doDamButVe; //Kích thước nét vẽ
        public Point diemBatDau; //Điểm khi nhấn xuống
        public Point diemKetThuc; //Điểm khi kéo chuột
                                  //Hai điểm để vẽ ra hình chữ nhật làm khung vẽ các hình bên trong
        protected Point diemHienHanh; //Lưu lại vị trí của điểm nhấn và điểm thả chuột
        protected int soDiemDieuKhien; //Số điểm để thay đổi kích thước quanh mỗi hình
        protected GraphicsPath congCuVe; //???
        protected Region khuVucVe; //???
        protected TextBox hopChu;
        protected string chuoi;
        protected int viTriChuotVaHinhVe; //Vị trí khi nhấn chuột
                                          //>0 id của điểm điều khiển
                                          //=0 nhấn chuột trong hình
                                          //<0 nhấn chuột vào khung vẽ
        public bool kiemTraDiChuyen; //=true nếu cho phép di chuyển hình
                                     //=false nếu không được phép di chuyển hình
        public bool kiemTraThayDoiKichThuoc; //=true nếu được phép thay đổi kích thước hình
                                             //=false nếu không được phép thay đổi kích thước hình

        #endregion

        #region Khởi tạo

        public DoiTuong()
        {
            
        }

        public DoiTuong(Color mauVe, int kichThuocButVe)
        {
            mauBut = mauVe;
            doDamButVe = kichThuocButVe;
        }

        #endregion

        #region - Phương thức -

        //Vẽ
        public virtual void Ve(Graphics g)
        {

        }

        //Tạo điểm điều khiển
        protected virtual Point TaoDiemDieuKhien(int viTriDiemDieuKhien)
        {
            return new Point(0, 0);
        }

        public virtual void AnTextBox()
        {
            try
            {
                chuoi = hopChu.Text;
                if (chuoi != null)
                    hopChu.Visible = false;
            }
            catch (Exception)
            { }
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
        public virtual bool kiemTraDiemTrongDoiTuong(Point diem)
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
