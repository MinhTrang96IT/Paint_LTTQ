using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using System.Drawing;
using DevExpress.XtraBars;

namespace Paint
{
    public partial class MainPaint : RibbonForm
    {
        #region - Thuộc tính -

        private Color mauVe; //Màu vẽ khung hình
        private Color mauTay; //Màu cục tẩy
        private int kichThuocButVe; //Kích thước nét vẽ khung hình
        private DanhSachDoiTuong danhSachDoiTuong; //Danh sách các hình đã vẽ
        private DoiTuong hinh; //Hình đang được chọn
        private int idHinhHienTai; //Chỉ số của hình được chọn để vẽ
        private DoMau doMau; //Tô màu cho hình vẽ
        private Bitmap hinhNenChim; //Hình nền hiển thị
        private Bitmap hinhNenNoi; //Hình nền giữ đối tượng đang vẽ
        private Font phongChu; //Loại phông chữ của văn bản
        private bool kiemTraDiChuyenSauKhiVe; //= true nếu trong trạng thái có thể di chuyển hình
        private bool LuaChonHienThi; //= true: btnHienThiMau1, = false: btnHienThiMau2
        private int kiemTraNutNhan; //= 1: Phóng to
                                    //= 2: Thu nhỏ
                                    //= 3: Xóa
        private int chiSoHinh;
        private bool kiemTraLinkLuu; //=true: nếu hình đã được lưu trước đó
                                     //=false: chọn lại nơi lưu hình
        private Bitmap tam;
        private bool kiemTraDan;

        #endregion

        #region - Khởi tạo -

        public MainPaint()
        {
            InitializeComponent();

            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            KhoiTao();
        }

        //Khởi tạo các thuộc tính
        public void KhoiTao()
        {
            mauVe = Color.Black; //Mặc định bút vẽ màu đen
            mauTay = Color.White; //Mặc định tẩy màu trắng
            kichThuocButVe = 1; 
            danhSachDoiTuong = new DanhSachDoiTuong();
            idHinhHienTai = 1; //Hình ban đầu là con trỏ chuột
            kiemTraDiChuyenSauKhiVe = false;
            phongChu = new Font("Times New Roman", 10);
            LuaChonHienThi = true;//Mặc định thay đổi màu của khung hình
            kiemTraNutNhan = 0;
            chiSoHinh = -1;
            kiemTraLinkLuu = false;
            tam = null;
            kiemTraDan = false;

            hinhNenChim = new Bitmap(pictureBox1.Width, pictureBox1.Height, pictureBox1.CreateGraphics()); //Khởi tạo một hình vẽ có kích thước bằng kích thước của PictureBox
            Graphics g = Graphics.FromImage(hinhNenChim); //Lấy hình từ hinhNenChim
            g.Clear(Color.White);

            hinhNenNoi = new Bitmap(pictureBox1.Width, pictureBox1.Height, pictureBox1.CreateGraphics());
            g = Graphics.FromImage(hinhNenNoi);
            g.Clear(Color.White);           
        }

        #endregion

        #region - Chọn màu -

        //Sự kiện click vào các button màu
        private void ChonMau_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarButtonItem bItem = e.Item as BarButtonItem;

            if(LuaChonHienThi)
                btnHienThiMau1.ItemAppearance.Normal.BackColor = bItem.ItemAppearance.Normal.BackColor;
            else
                btnHienThiMau2.ItemAppearance.Normal.BackColor = bItem.ItemAppearance.Normal.BackColor;

            mauVe = btnHienThiMau1.ItemAppearance.Normal.BackColor;
            mauTay = btnHienThiMau2.ItemAppearance.Normal.BackColor;
        }

        //Sự kiện click vào button colorDialog
        private void btnLuaChonMau_Click(object sender, ItemClickEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (LuaChonHienThi)
                    btnHienThiMau1.ItemAppearance.Normal.BackColor = colorDialog1.Color;
                else
                    btnHienThiMau2.ItemAppearance.Normal.BackColor = colorDialog1.Color;
                
                mauVe = btnHienThiMau1.ItemAppearance.Normal.BackColor;
                mauTay = btnHienThiMau2.ItemAppearance.Normal.BackColor;
            }
        }

        //Sự kiện click vào button hiển thị màu bút
        private void btnHienThiMau1_Click(object sender, ItemClickEventArgs e)
        {
            LuaChonHienThi = true;
        }

        //Sự kiện click vào button hiển thị màu tẩy
        private void btnHienThiMau2_Click(object sender, ItemClickEventArgs e)
        {
            LuaChonHienThi = false;
        }

        #endregion

        #region - Menu -

        private void New_Click(object sender, ItemClickEventArgs e)
        {
            frmUploadFacebook.strFileName = null;

            DialogResult kq = MessageBox.Show("Bạn có muốn lưu hình đã vẽ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                btnSave_Click(sender, e);
            }
            else if (kq == DialogResult.No)
            {
                hinh = null;
                danhSachDoiTuong.danhSachHinh.Clear();
                hinhNenNoi = new Bitmap(1090, 425, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(hinhNenNoi);
                g.Clear(Color.White);
                pictureBox1.Size = hinhNenNoi.Size;
                pictureBox1.Refresh();
            }
            else { } 
        }

        private void Open_Click(object sender, ItemClickEventArgs e)
        {
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "BMP (*.bmp)|*.bmp|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (hinh != null)
                    hinh = null;

                danhSachDoiTuong.danhSachHinh.Clear();
                hinhNenNoi = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Size = hinhNenNoi.Size;
                pictureBox1.Refresh();
            }
        }

        private void btnSave_Click(object sender, ItemClickEventArgs e)
        {
            if (kiemTraLinkLuu)
                hinhNenChim.Save(saveFileDialog1.FileName);
            else
                SaveAs_Click(sender, e);

            frmUploadFacebook.strFileName = saveFileDialog1.FileName;
        }

        private void SaveAs_Click(object sender, ItemClickEventArgs e)
        {
            saveFileDialog1.Title = "Save As";
            saveFileDialog1.Filter = "BMP (*.bmp)|*.bmp|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.OverwritePrompt = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                hinhNenChim.Save(saveFileDialog1.FileName);
                kiemTraLinkLuu = true;
            }
        }

        private void btnAbout_Click(object sender, ItemClickEventArgs e)
        {
            frmThongTin f = new frmThongTin();
            f.Show();
        }

        private void Exit_Click(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
        }

        #endregion

        #region - Thay đổi kích thước nét vẽ và tẩy -

        private void btnSize1px_ItemClick(object sender, ItemClickEventArgs e)
        {
            kichThuocButVe = 1;
        }

        private void btnSize3px_ItemClick(object sender, ItemClickEventArgs e)
        {
            kichThuocButVe = 3;
        }

        private void btnSize5px_ItemClick(object sender, ItemClickEventArgs e)
        {
            kichThuocButVe = 5;
        }

        private void btnSize8px_ItemClick(object sender, ItemClickEventArgs e)
        {
            kichThuocButVe = 8;
        }

        #endregion

        #region - Một số chức năng khác -

        private void btnCatKhung_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (idHinhHienTai == 1)
                {
                    int w = Math.Abs(hinh.diemKetThuc.X - hinh.diemBatDau.X);
                    int h = Math.Abs(hinh.diemKetThuc.Y - hinh.diemBatDau.Y);

                    hinhNenNoi = hinhNenChim.Clone(new Rectangle(hinh.diemBatDau.X, hinh.diemBatDau.Y, w, h), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    pictureBox1.Size = hinhNenChim.Size;
                    hinh = null;
                    danhSachDoiTuong.danhSachHinh.Clear();
                    pictureBox1.Refresh();
                }
                else
                    MessageBox.Show("Chọn trước một vùng!", "Cảnh báo");
                hinh = null;
            }
            catch
            {
                MessageBox.Show("Chọn trước một vùng!", "Cảnh báo");
            }
        }

        private void btnPhongTo_Click(object sender, ItemClickEventArgs e)
        {
            kiemTraNutNhan = 1;
            idHinhHienTai = 0;
        }

        private void btnThuNho_Click(object sender, ItemClickEventArgs e)
        {
            kiemTraNutNhan = 2;
            idHinhHienTai = 0;
        }

        private void btnDelete_Click(object sender, ItemClickEventArgs e)
        {
            kiemTraNutNhan = 3;
            idHinhHienTai = 0;
        }

        #endregion

        #region - Chọn đối tượng -

        //Sự kiện click vào đối tượng hình
        private void btnDoiTuong_Click(object sender, ItemClickEventArgs e)
        {
            BarButtonItem bItem = e.Item as BarButtonItem;
            bItem.ItemAppearance.Pressed.BackColor = Color.Red; //Gán màu khi nhấn button là màu đỏ
            idHinhHienTai = Convert.ToInt16(bItem.Tag); //Lấy giá trị tag của button
            kiemTraNutNhan = 0;
        }

        //Hàm chọn đối tượng muốn vẽ
        private DoiTuong ChonDoiTuong()
        {
            switch (idHinhHienTai)
            {
                case 1:
                    return new ChonKhuVuc();
                case 2:
                    return null;
                case 3:
                    return new HinhChuNhat(mauVe, kichThuocButVe);
                case 4:
                    return new HinhEllipse(mauVe, kichThuocButVe);
                case 5:
                    return new DuongThang(mauVe, kichThuocButVe);
                case 6:
                    return new HinhTuDo(mauVe, kichThuocButVe);
                case 7:
                    return new HinhTraiTim(mauVe, kichThuocButVe);
                case 8:
                    return new HinhMuiTen(mauVe, kichThuocButVe);
                case 9:
                    return new HinhTamGiac(mauVe, kichThuocButVe);
                case 10:
                    return new HinhThoi(mauVe, kichThuocButVe);
                case 11:
                    return new HinhLucGiac(mauVe, kichThuocButVe);
                case 14:
                    return new CucTay(mauTay, kichThuocButVe);
                case 15:
                    return new HopVanBan(mauVe, phongChu);
                default: return new ChonKhuVuc();
            }
            
        }

        #endregion

        #region - Sự kiện Paint -

        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            hinhNenChim = hinhNenNoi.Clone(new Rectangle(0, 0, hinhNenNoi.Width, hinhNenNoi.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(hinhNenChim);

            if (danhSachDoiTuong.danhSachHinh.Count > 0)
                danhSachDoiTuong.Ve(g);

            e.Graphics.DrawImageUnscaled(hinhNenChim, 0, 0);
        }

        #endregion

        #region - Sự kiện chuột -

        private void Picture_Mouse_Down(object sender, MouseEventArgs e)
        {
            if (kiemTraDiChuyenSauKhiVe) //Kích hoạt chế độ di chuyển sau khi vẽ hình
            {
                
            }

            #region - Hình vẽ -

            else //Không kích hoạt chế độ di chuyển sau khi vẽ hình
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (idHinhHienTai == 20) //Đổ màu
                    {
                        hinh = null;
                        doMau = new DoMau();
                        hinhNenNoi = doMau.ToMau(hinhNenChim, hinhNenNoi, mauVe, e.Location); //Đổ màu vào hình vẽ
                        pictureBox1.Refresh();
                    }
                    else if (idHinhHienTai == 14) //Cục tẩy
                    {
                        hinh = null;
                        hinh = ChonDoiTuong();
                        hinh.Mouse_Down(e);
                        danhSachDoiTuong.danhSachHinh.Insert(danhSachDoiTuong.danhSachHinh.Count, hinh); //Thêm thao tác tẩy vào danh sách hình vẽ
                    }
                    else if (idHinhHienTai == 15) //Viết văn bản
                    {
                        hinh = null;
                        hinh = ChonDoiTuong();
                        hinh.Mouse_Down(e);
                        danhSachDoiTuong.danhSachHinh.Insert(danhSachDoiTuong.danhSachHinh.Count, hinh); //Thêm thao tác viết văn bản vào danh sách hình vẽ
                    }
                    else if (idHinhHienTai <= 11 && idHinhHienTai >= 1) //Các hình vẽ
                    {
                        if (hinh == null || hinh.kiemTraViTriDiemNhan(e.Location) == -1)
                            hinh = ChonDoiTuong();

                        if (hinh != null)
                        {
                            hinh.Mouse_Down(e);
                            danhSachDoiTuong.danhSachHinh.Insert(danhSachDoiTuong.danhSachHinh.Count, hinh);
                        }
                    }
                    else
                        hinh = null;
                }
                else
                    hinh = null;
            }

            #endregion

            #region - Một số chức năng khác -

            if (kiemTraNutNhan == 0) //Không làm gì
            { }
            if (kiemTraNutNhan == 1) //Phóng to
            {
                chiSoHinh = danhSachDoiTuong.ChiSoHinhDuocChon(e.Location);
                if (chiSoHinh != -1)//co hinh duoc chon
                {
                    DoiTuong h = danhSachDoiTuong.danhSachHinh[chiSoHinh] as DoiTuong;
                    int xT = (h.diemBatDau.X + h.diemKetThuc.X) / 2;
                    int yT = (h.diemBatDau.Y + h.diemKetThuc.Y) / 2;
                    int rx = (h.diemKetThuc.X - h.diemBatDau.X) / 2;
                    int ry = (h.diemKetThuc.Y - h.diemBatDau.Y) / 2;
                    rx = (int)(rx * 1.1);
                    ry = (int)(ry * 1.1);
                    h.diemBatDau.X = xT - rx;
                    h.diemBatDau.Y = yT - ry;
                    h.diemKetThuc.X = xT + rx;
                    h.diemKetThuc.Y = yT + ry;
                }
                pictureBox1.Invalidate();
                return;
            }
            if (kiemTraNutNhan == 2) //Thu nhỏ
            {
                chiSoHinh = danhSachDoiTuong.ChiSoHinhDuocChon(e.Location);
                if (chiSoHinh != -1)//co hinh duoc chon
                {
                    DoiTuong h = danhSachDoiTuong.danhSachHinh[chiSoHinh] as DoiTuong;
                    int xT = (h.diemBatDau.X + h.diemKetThuc.X) / 2;
                    int yT = (h.diemBatDau.Y + h.diemKetThuc.Y) / 2;
                    int rx = (h.diemKetThuc.X - h.diemBatDau.X) / 2;
                    int ry = (h.diemKetThuc.Y - h.diemBatDau.Y) / 2;
                    rx = (int)(rx / 1.1);
                    ry = (int)(ry / 1.1);
                    h.diemBatDau.X = xT - rx;
                    h.diemBatDau.Y = yT - ry;
                    h.diemKetThuc.X = xT + rx;
                    h.diemKetThuc.Y = yT + ry;
                }
                pictureBox1.Invalidate();
                return;
            }
            if (kiemTraNutNhan == 3) //Xóa
            {
                chiSoHinh = danhSachDoiTuong.ChiSoHinhDuocChon(e.Location);
                if (chiSoHinh != -1)//co hinh duoc chon
                    danhSachDoiTuong.danhSachHinh.RemoveAt(chiSoHinh);
                pictureBox1.Invalidate();
                return;
            }
            if (kiemTraNutNhan == 4)
            {
                chiSoHinh = danhSachDoiTuong.ChiSoHinhDuocChon(e.Location);
                if (chiSoHinh != -1)//co hinh duoc chon
                {
                    DoiTuong h = danhSachDoiTuong.danhSachHinh[chiSoHinh] as DoiTuong;
                    int xT = (h.diemBatDau.X + h.diemKetThuc.X) / 2;
                    int yT = (h.diemBatDau.Y + h.diemKetThuc.Y) / 2;
                    int rx = (h.diemKetThuc.X - h.diemBatDau.X) / 2;
                    int ry = (h.diemKetThuc.Y - h.diemBatDau.Y) / 2;
                    h.diemBatDau.X = xT - ry;
                    h.diemBatDau.Y = yT - rx;
                    h.diemKetThuc.X = xT + ry;
                    h.diemKetThuc.Y = yT + rx;
                }
                pictureBox1.Invalidate();
                return;
            }

            #endregion
        }

        private void Picture_Mouse_Move(object sender, MouseEventArgs e)
        {
            barStaticItem1.Caption = "Tọa độ: " + e.Location.X + " , " + e.Location.Y; //Cập nhập tọa độ

            #region - Di chuyển sau khi vẽ -

            if (idHinhHienTai == 2) //Nút chỉnh sửa được nhấn
            {
                if (kiemTraDiChuyenSauKhiVe == false)
                {
                    for (int i = danhSachDoiTuong.danhSachHinh.ToArray().Length - 1; i >= 0; i--) //Kiểm tra từng hình xem hình nào bị chuột di chuyển trên bề mặt
                    {
                        int vitri = (danhSachDoiTuong.danhSachHinh.ToArray())[i].kiemTraViTriDiemNhan(e.Location); //Vị trí chuột so với hình bị di chuyển trên bề mặt

                        if (vitri == 0) //Chuột di chuyển trong hình
                        {
                            hinh = (danhSachDoiTuong.danhSachHinh.ToArray())[i];

                            if (e.Button == MouseButtons.Left)
                            {
                                Cursor = Cursors.Hand;
                                hinh.kiemTraDiChuyen = true; //Cho phép di chuyển
                                hinh.kiemTraThayDoiKichThuoc = false; //Không cho phép thay đổi kích thước
                                kiemTraDiChuyenSauKhiVe = true; //Bật cờ đang di chuyển

                                idHinhHienTai = 1;
                                hinh.VeDiemDieuKhien(pictureBox1.CreateGraphics());
                                danhSachDoiTuong.danhSachHinh.RemoveAt(i);
                            }
                            else
                            {
                                kiemTraDiChuyenSauKhiVe = false;
                                hinh.kiemTraDiChuyen = false;
                            }

                            Cursor = Cursors.Hand;
                            pictureBox1.Refresh();
                            hinh.VeDiemDieuKhien(pictureBox1.CreateGraphics());                            
                            break;
                        }
                        else if (vitri > 0)
                        {
                            hinh = (danhSachDoiTuong.danhSachHinh.ToArray())[i];
                            if (e.Button == MouseButtons.Left)
                            {
                                hinh.kiemTraThayDoiKichThuoc = true;
                                hinh.kiemTraDiChuyen = false;
                                kiemTraDiChuyenSauKhiVe = true;

                                idHinhHienTai = 1;
                                hinh.VeDiemDieuKhien(pictureBox1.CreateGraphics());
                                danhSachDoiTuong.danhSachHinh.RemoveAt(i);
                            }
                            else
                            {
                                kiemTraDiChuyenSauKhiVe = false;
                                hinh.kiemTraThayDoiKichThuoc = false;
                            }

                            Cursor = Cursors.Cross;
                            pictureBox1.Refresh();
                            hinh.VeDiemDieuKhien(pictureBox1.CreateGraphics());
                            break;
                        }

                        else
                        {
                            Cursor = Cursors.Default;
                        }
                    }
                }
            }

            #endregion

            else
            {
                #region - Thay đổi biểu tượng chuột hiển thị -

                if (hinh != null)
                {
                    if (hinh.kiemTraViTriDiemNhan(e.Location) > 0)
                        Cursor = Cursors.Cross;
                    else if (hinh.kiemTraViTriDiemNhan(e.Location) == 0)
                        Cursor = Cursors.SizeAll;
                    else
                        Cursor = Cursors.Default;
                    if (idHinhHienTai == 14)
                    {
                        Cursor = Cursors.Hand;
                    }
                }

                #endregion

                #region - Hình vẽ -

                if (e.Button == MouseButtons.Left)
                {
                    if (hinh != null)
                    {
                        hinh.Mouse_Move(e);
                        if (hinh.kiemTraThayDoiKichThuoc == true || hinh.kiemTraDiChuyen == true)
                        {
                            hinh.VeDiemDieuKhien(pictureBox1.CreateGraphics());
                        }
                        if (idHinhHienTai == 1)
                        {
                            hinh.VeDiemDieuKhien(pictureBox1.CreateGraphics());
                        }
                        pictureBox1.Refresh();
                    }
                }

                #endregion
            }
        }

        private void Picture_Mouse_Up(object sender, MouseEventArgs e)
        {
            if (hinh != null && hinh.diemKetThuc != hinh.diemBatDau)
            {
                hinh.Mouse_Up(sender);
                hinh.VeDiemDieuKhien(pictureBox1.CreateGraphics());
            }

            if (kiemTraDiChuyenSauKhiVe)
            {
                hinh.Mouse_Up(sender);
                idHinhHienTai = 2;
                kiemTraDiChuyenSauKhiVe = false;
            }
        }

        #endregion
        
        #region - Rác chưa xử lý -

        private void btnThayDoiKichThuoc_Click(object sender, ItemClickEventArgs e)
        {
            frmThayDoiKichThuoc f = new frmThayDoiKichThuoc();
            f.Show();
        }
        
        private void btnRotateLeft90_Click(object sender, ItemClickEventArgs e)
        {
            kiemTraNutNhan = 4;
            idHinhHienTai = 0;
        }

        private void btnCut_Click(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btnCopy_Click(object sender, ItemClickEventArgs e)
        {
            //btnCopy.ItemAppearance.Normal.BackColor = Color.Lavender;

            try
            {
                if (idHinhHienTai == 1)
                {
                    int w = Math.Abs(hinh.diemKetThuc.X - hinh.diemBatDau.X);
                    int h = Math.Abs(hinh.diemKetThuc.Y - hinh.diemBatDau.Y);

                    hinhNenNoi = tam.Clone(new Rectangle(hinh.diemBatDau.X, hinh.diemBatDau.Y, w, h), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    hinh = null;
                    pictureBox1.Refresh();
                    kiemTraDan = true;
                }
                else
                    MessageBox.Show("Chọn trước một vùng!", "Cảnh báo");
                hinh = null;
            }
            catch
            {
                //MessageBox.Show("Chọn trước một vùng!", "Cảnh báo");
            }
        }

        #endregion

        private void btnFacebook_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnSave_Click(sender, e);

            frmUploadFacebook frm = new frmUploadFacebook();
            frm.Show();
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (danhSachDoiTuong.danhSachHinh.Count > 0)
            {
                danhSachDoiTuong.XoaPhanTuCuoi();
            }
            else
            {
                MessageBox.Show("Không thể tiếp tục Undo", "Thông báo!");
            }
            pictureBox1.Refresh();
        }

        private void btnRedo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor cur = new Cursor(Properties.Resources.Pencil.Handle);
            Cursor = cur;
        }
    }
}
