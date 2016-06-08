using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AForge;
using AForge.Imaging.Filters;

namespace Paint
{
    class DoMau
    {
        #region - Thuộc tính -

        private PointedColorFloodFill thungMau; // Công cụ tô màu

        #endregion

        #region - Khởi tạo -

        public DoMau()
        {
            thungMau = new PointedColorFloodFill();
        }

        #endregion

        #region - Phương thức -

        //Tô màu
        public Bitmap ToMau(Bitmap hinhNenChim, Bitmap hinhNenNoi, Color mau, System.Drawing.Point diem)
        {
            hinhNenNoi = hinhNenChim.Clone(new Rectangle(0, 0, hinhNenChim.Width, hinhNenChim.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb); //Sao chép khung hình chìm vào khung hình nổi
            thungMau.FillColor = mau; //Màu tô
            thungMau.Tolerance = hinhNenChim.GetPixel(diem.X, diem.Y); //Tô màu vào các điểm
            thungMau.StartingPoint = new IntPoint(diem.X, diem.Y); //Vị trí điểm bắt đầu tô màu
            return thungMau.Apply(hinhNenNoi); //Áp dụng màu đã tô
        }

        #endregion
    }
}
