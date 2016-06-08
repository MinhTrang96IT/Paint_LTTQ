using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint
{
    class DanhSachDoiTuong
    {
        #region - Thuộc tính -

        public List<DoiTuong> danhSachHinh; //Danh sách chứa các hình đã vẽ

        #endregion

        #region - Khởi tạo -

        public DanhSachDoiTuong()
        {
            danhSachHinh = new List<DoiTuong>();
        }

        #endregion

        #region - Phương thức -

        //Vẽ
        public void Ve(Graphics g)
        {
            foreach (DoiTuong doiTuong in danhSachHinh)
            {
                doiTuong.Ve(g);
            }
        }

        //Xóa phần tử cuối
        public void XoaPhanTuCuoi()
        {
            try
            {
                danhSachHinh.RemoveAt(danhSachHinh.Count - 1);
            }
            catch
            {
                MessageBox.Show("Đã xóa phần tử cuối, không thể xóa tiếp!", "Canh báo");
            }
        }

        //Lấy giá trị vị trí của hình trong mảng danh sách các hình đã vẽ
        public int ChiSoHinhDuocChon(Point diem)
        {
            int i;
            for (i = danhSachHinh.Count - 1; i >= 0; i--)
            {
                DoiTuong h = danhSachHinh[i] as DoiTuong;
                if (h.kiemTraDiemTrongDoiTuong(diem))
                    break;
            }
            return i;
        }

        #endregion
    }
}
