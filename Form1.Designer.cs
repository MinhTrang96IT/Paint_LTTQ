using System;
using System.Windows.Forms;

namespace Paint
{
    partial class MainPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPaint));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup4 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.MenuFile = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.rbcMainPaint = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnChonKhuVuc = new DevExpress.XtraBars.BarSubItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.btnRectangularSelection = new DevExpress.XtraBars.BarButtonItem();
            this.btnFreeformSelection = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.btnSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnInvertSelection = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransparentSelection = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeTuDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoMau = new DevExpress.XtraBars.BarButtonItem();
            this.btnText = new DevExpress.XtraBars.BarButtonItem();
            this.btnEraser = new DevExpress.XtraBars.BarButtonItem();
            this.btnChinhSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnMagnifier = new DevExpress.XtraBars.BarButtonItem();
            this.btnCatKhung = new DevExpress.XtraBars.BarButtonItem();
            this.btnThayDoiKichThuoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnRotateRight90 = new DevExpress.XtraBars.BarButtonItem();
            this.btnRotateLeft90 = new DevExpress.XtraBars.BarButtonItem();
            this.btnOutline = new DevExpress.XtraBars.BarSubItem();
            this.btnOutline_NoOutline = new DevExpress.XtraBars.BarButtonItem();
            this.btnOutline_SolidColor = new DevExpress.XtraBars.BarButtonItem();
            this.btnOutline_Crayon = new DevExpress.XtraBars.BarButtonItem();
            this.btnOutline_Marker = new DevExpress.XtraBars.BarButtonItem();
            this.btnOutline_Oil = new DevExpress.XtraBars.BarButtonItem();
            this.btnOutline_NaturalPencil = new DevExpress.XtraBars.BarButtonItem();
            this.btnOutline_Watercolor = new DevExpress.XtraBars.BarButtonItem();
            this.btnFill = new DevExpress.XtraBars.BarSubItem();
            this.btnFill_NoFill = new DevExpress.XtraBars.BarButtonItem();
            this.btnFill_SolidColor = new DevExpress.XtraBars.BarButtonItem();
            this.btnFill_Crayon = new DevExpress.XtraBars.BarButtonItem();
            this.btnFill_Marker = new DevExpress.XtraBars.BarButtonItem();
            this.btnFill_Oil = new DevExpress.XtraBars.BarButtonItem();
            this.btnFill_NaturalPencil = new DevExpress.XtraBars.BarButtonItem();
            this.btnWatercolor2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnFill_Watercolor = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem9 = new DevExpress.XtraBars.BarSubItem();
            this.btnSize_1px = new DevExpress.XtraBars.BarButtonItem();
            this.btnSize_3px = new DevExpress.XtraBars.BarButtonItem();
            this.btnSize_5px = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditColors = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongTo = new DevExpress.XtraBars.BarButtonItem();
            this.btnThuNho = new DevExpress.XtraBars.BarButtonItem();
            this.btnZoom100 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnFullScreen = new DevExpress.XtraBars.BarButtonItem();
            this.btnThumbnail = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem49 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem50 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem51 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem52 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem53 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem54 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSize_8px = new DevExpress.XtraBars.BarButtonItem();
            this.btnCucTay = new DevExpress.XtraBars.BarButtonItem();
            this.btnBrushes = new DevExpress.XtraBars.BarSubItem();
            this.btnBrush = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalligraphybrush1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalligraphybrush2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAirbrush = new DevExpress.XtraBars.BarButtonItem();
            this.btnOilbrush = new DevExpress.XtraBars.BarButtonItem();
            this.btnCrayonBrush = new DevExpress.XtraBars.BarButtonItem();
            this.btnNaturalPencilBrush = new DevExpress.XtraBars.BarButtonItem();
            this.btnWaterColorBrush = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonGalleryBarItem2 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnSize = new DevExpress.XtraBars.BarSubItem();
            this.btnSize1px = new DevExpress.XtraBars.BarButtonItem();
            this.btnSize3px = new DevExpress.XtraBars.BarButtonItem();
            this.btnSize5px = new DevExpress.XtraBars.BarButtonItem();
            this.btnSize8px = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHienThiMau1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHienThiMau2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor10 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor11 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor12 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor13 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor14 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor15 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor16 = new DevExpress.XtraBars.BarButtonItem();
            this.btnColor17 = new DevExpress.XtraBars.BarButtonItem();
            this.checkRulers = new DevExpress.XtraBars.BarCheckItem();
            this.checkGridline = new DevExpress.XtraBars.BarCheckItem();
            this.checkStatusBar = new DevExpress.XtraBars.BarCheckItem();
            this.Zoom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnVeDuongThang = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeHinhEllipse = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeHinhChuNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeHinhLucGiac = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeTamGiac = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeDuongCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeHinhThoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeHinhMuiTen = new DevExpress.XtraBars.BarButtonItem();
            this.btnVeHinhTraiTim = new DevExpress.XtraBars.BarButtonItem();
            this.btnPasteText = new DevExpress.XtraBars.BarButtonItem();
            this.btnCutText = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemFontEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.btnFont = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemFontEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.btnFacebook = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRotate = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaste = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCut = new DevExpress.XtraBars.BarButtonItem();
            this.Home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgImage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgTools = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgBrushes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgShapes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgSize = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgColors = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.View = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgZoom = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pgShowOrHide = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDisplay = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.repositoryItemPopupGalleryEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.repositoryItemColorPickEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckedComboBoxEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemPopupGalleryEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.repositoryItemCheckEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemColorPickEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.repositoryItemPopupGalleryEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repositoryItemPopupGalleryEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.repositoryItemCheckEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.repositoryItemRangeTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.repositoryItemPopupGalleryEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.repositoryItemFontEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.popupMenu6 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu7 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown2 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.galleryDropDown3 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.MenuFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbcMainPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRangeTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuFile
            // 
            this.MenuFile.ItemLinks.Add(this.btnNew);
            this.MenuFile.ItemLinks.Add(this.btnOpen);
            this.MenuFile.ItemLinks.Add(this.btnSave);
            this.MenuFile.ItemLinks.Add(this.btnSaveAs);
            this.MenuFile.ItemLinks.Add(this.btnAbout);
            this.MenuFile.ItemLinks.Add(this.btnExit);
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Ribbon = this.rbcMainPaint;
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNew.Glyph")));
            this.btnNew.Id = 113;
            this.btnNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNew.LargeGlyph")));
            this.btnNew.Name = "btnNew";
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.New_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "Open";
            this.btnOpen.Id = 114;
            this.btnOpen.LargeGlyph = global::Paint.Properties.Resources.open;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Open_Click);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 115;
            this.btnSave.LargeGlyph = global::Paint.Properties.Resources.save;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Caption = "Save as";
            this.btnSaveAs.Id = 116;
            this.btnSaveAs.LargeGlyph = global::Paint.Properties.Resources.save_as;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveAs_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Id = 118;
            this.btnAbout.LargeGlyph = global::Paint.Properties.Resources.about;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 117;
            this.btnExit.LargeGlyph = global::Paint.Properties.Resources.exit;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Exit_Click);
            // 
            // rbcMainPaint
            // 
            this.rbcMainPaint.AllowCustomization = true;
            this.rbcMainPaint.ApplicationButtonDropDownControl = this.MenuFile;
            this.rbcMainPaint.ApplicationButtonText = "File";
            this.rbcMainPaint.BackColor = System.Drawing.SystemColors.Control;
            this.rbcMainPaint.ExpandCollapseItem.Id = 0;
            this.rbcMainPaint.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcMainPaint.ExpandCollapseItem,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnChonKhuVuc,
            this.btnRectangularSelection,
            this.btnFreeformSelection,
            this.barHeaderItem1,
            this.btnSelectAll,
            this.btnInvertSelection,
            this.btnDelete,
            this.btnTransparentSelection,
            this.barHeaderItem2,
            this.btnVeTuDo,
            this.btnDoMau,
            this.btnText,
            this.btnEraser,
            this.btnChinhSua,
            this.btnMagnifier,
            this.btnCatKhung,
            this.btnThayDoiKichThuoc,
            this.btnRotateRight90,
            this.btnRotateLeft90,
            this.btnOutline,
            this.btnOutline_NoOutline,
            this.btnOutline_SolidColor,
            this.btnOutline_Crayon,
            this.btnOutline_Marker,
            this.btnOutline_Oil,
            this.btnOutline_NaturalPencil,
            this.btnOutline_Watercolor,
            this.btnFill,
            this.btnFill_NoFill,
            this.btnFill_SolidColor,
            this.btnFill_Crayon,
            this.btnFill_Marker,
            this.btnFill_Oil,
            this.btnFill_NaturalPencil,
            this.btnFill_Watercolor,
            this.barSubItem9,
            this.btnSize_1px,
            this.btnSize_3px,
            this.btnSize_5px,
            this.btnEditColors,
            this.btnPhongTo,
            this.btnThuNho,
            this.btnZoom100,
            this.barEditItem2,
            this.btnFullScreen,
            this.btnThumbnail,
            this.barButtonItem49,
            this.barButtonItem50,
            this.barButtonItem51,
            this.barButtonItem52,
            this.barButtonItem53,
            this.barButtonItem54,
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.btnExit,
            this.btnAbout,
            this.btnSize_8px,
            this.btnCucTay,
            this.btnBrushes,
            this.btnBrush,
            this.btnCalligraphybrush1,
            this.btnCalligraphybrush2,
            this.btnAirbrush,
            this.btnOilbrush,
            this.btnCrayonBrush,
            this.btnNaturalPencilBrush,
            this.btnWaterColorBrush,
            this.ribbonGalleryBarItem1,
            this.ribbonGalleryBarItem2,
            this.btnSize,
            this.btnSize1px,
            this.btnSize3px,
            this.btnSize5px,
            this.btnSize8px,
            this.barButtonItem1,
            this.btnWatercolor2,
            this.btnHienThiMau1,
            this.btnHienThiMau2,
            this.btnColor3,
            this.btnColor5,
            this.btnColor6,
            this.btnColor4,
            this.btnColor7,
            this.btnColor8,
            this.btnColor9,
            this.btnColor10,
            this.btnColor11,
            this.btnColor12,
            this.btnColor13,
            this.btnColor14,
            this.btnColor15,
            this.btnColor16,
            this.btnColor17,
            this.checkRulers,
            this.checkGridline,
            this.checkStatusBar,
            this.Zoom,
            this.barStaticItem1,
            this.btnVeDuongThang,
            this.btnVeHinhEllipse,
            this.btnVeHinhChuNhat,
            this.btnVeHinhLucGiac,
            this.btnVeTamGiac,
            this.btnVeDuongCong,
            this.btnVeHinhThoi,
            this.btnVeHinhMuiTen,
            this.btnVeHinhTraiTim,
            this.btnPasteText,
            this.btnCutText,
            this.barButtonItem6,
            this.barEditItem1,
            this.barButtonItem5,
            this.barButtonItem7,
            this.barButtonItem8,
            this.btnFont,
            this.barEditItem3,
            this.barButtonItem9,
            this.barEditItem4,
            this.btnFacebook,
            this.btnUndo,
            this.btnRedo,
            this.btnRotate,
            this.btnPaste,
            this.barButtonItem12,
            this.btnCut});
            this.rbcMainPaint.Location = new System.Drawing.Point(0, 0);
            this.rbcMainPaint.MaxItemId = 219;
            this.rbcMainPaint.Name = "rbcMainPaint";
            this.rbcMainPaint.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Home,
            this.View});
            this.rbcMainPaint.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorPickEdit1,
            this.repositoryItemPopupGalleryEdit1,
            this.repositoryItemColorPickEdit2,
            this.repositoryItemSearchControl1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckedComboBoxEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4,
            this.repositoryItemCheckEdit5,
            this.repositoryItemPopupGalleryEdit2,
            this.repositoryItemCheckEdit6,
            this.repositoryItemColorPickEdit3,
            this.repositoryItemPopupGalleryEdit3,
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemPopupGalleryEdit4,
            this.repositoryItemCheckEdit7,
            this.repositoryItemTrackBar1,
            this.repositoryItemRangeTrackBar1,
            this.repositoryItemZoomTrackBar1,
            this.repositoryItemToggleSwitch1,
            this.repositoryItemPopupGalleryEdit5,
            this.repositoryItemFontEdit1,
            this.repositoryItemFontEdit2,
            this.repositoryItemFontEdit3,
            this.repositoryItemTextEdit1,
            this.repositoryItemRichTextEdit1,
            this.repositoryItemColorEdit1,
            this.repositoryItemFontEdit4});
            this.rbcMainPaint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.rbcMainPaint.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.rbcMainPaint.ShowItemCaptionsInPageHeader = true;
            this.rbcMainPaint.ShowItemCaptionsInQAT = true;
            this.rbcMainPaint.Size = new System.Drawing.Size(1090, 143);
            this.rbcMainPaint.StatusBar = this.ribbonStatusBar1;
            this.rbcMainPaint.Toolbar.ItemLinks.Add(this.btnUndo);
            this.rbcMainPaint.Toolbar.ItemLinks.Add(this.btnRedo);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Paste";
            this.barButtonItem2.Glyph = global::Paint.Properties.Resources.paste_16;
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Paste &Form";
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Paste from";
            this.barButtonItem4.Glyph = global::Paint.Properties.Resources.past_from;
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnChonKhuVuc
            // 
            this.btnChonKhuVuc.Caption = "Select";
            this.btnChonKhuVuc.Id = 17;
            this.btnChonKhuVuc.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent;
            this.btnChonKhuVuc.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnChonKhuVuc.LargeGlyph = global::Paint.Properties.Resources.RectangularSelection_48;
            this.btnChonKhuVuc.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRectangularSelection),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFreeformSelection),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSelectAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInvertSelection),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTransparentSelection)});
            this.btnChonKhuVuc.Name = "btnChonKhuVuc";
            this.btnChonKhuVuc.Tag = "";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "Selection shapes";
            this.barHeaderItem2.Id = 26;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // btnRectangularSelection
            // 
            this.btnRectangularSelection.Caption = "Rectangular selection";
            this.btnRectangularSelection.Glyph = global::Paint.Properties.Resources.RectangularSelection_16;
            this.btnRectangularSelection.Id = 18;
            this.btnRectangularSelection.Name = "btnRectangularSelection";
            this.btnRectangularSelection.Tag = "1";
            this.btnRectangularSelection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnFreeformSelection
            // 
            this.btnFreeformSelection.Caption = "Free-form selection";
            this.btnFreeformSelection.Glyph = global::Paint.Properties.Resources.free_form_selection;
            this.btnFreeformSelection.Id = 19;
            this.btnFreeformSelection.Name = "btnFreeformSelection";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Selection options";
            this.barHeaderItem1.Id = 21;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Caption = "Select all";
            this.btnSelectAll.Glyph = global::Paint.Properties.Resources.select_all;
            this.btnSelectAll.Id = 22;
            this.btnSelectAll.Name = "btnSelectAll";
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.Caption = "Invert selection";
            this.btnInvertSelection.Glyph = global::Paint.Properties.Resources.invert_selection;
            this.btnInvertSelection.Id = 23;
            this.btnInvertSelection.Name = "btnInvertSelection";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Glyph = global::Paint.Properties.Resources.delete;
            this.btnDelete.Id = 24;
            this.btnDelete.Name = "btnDelete";
            // 
            // btnTransparentSelection
            // 
            this.btnTransparentSelection.Caption = "Transparent selection";
            this.btnTransparentSelection.Id = 25;
            this.btnTransparentSelection.Name = "btnTransparentSelection";
            // 
            // btnVeTuDo
            // 
            this.btnVeTuDo.Glyph = global::Paint.Properties.Resources.pencil_16;
            this.btnVeTuDo.Id = 27;
            this.btnVeTuDo.Name = "btnVeTuDo";
            this.btnVeTuDo.Tag = "6";
            this.btnVeTuDo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnDoMau
            // 
            this.btnDoMau.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDoMau.Glyph")));
            this.btnDoMau.Id = 28;
            this.btnDoMau.Name = "btnDoMau";
            this.btnDoMau.Tag = "20";
            this.btnDoMau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnText
            // 
            this.btnText.Glyph = ((System.Drawing.Image)(resources.GetObject("btnText.Glyph")));
            this.btnText.Id = 29;
            this.btnText.Name = "btnText";
            this.btnText.Tag = "15";
            this.btnText.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Glyph = global::Paint.Properties.Resources.eraser_16;
            this.btnEraser.Id = 30;
            this.btnEraser.Name = "btnEraser";
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.Glyph")));
            this.btnChinhSua.Id = 31;
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Tag = "2";
            this.btnChinhSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnMagnifier
            // 
            this.btnMagnifier.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMagnifier.Glyph")));
            this.btnMagnifier.Id = 32;
            this.btnMagnifier.Name = "btnMagnifier";
            this.btnMagnifier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_Click);
            // 
            // btnCatKhung
            // 
            this.btnCatKhung.Caption = "Crop";
            this.btnCatKhung.Glyph = global::Paint.Properties.Resources.crop_16;
            this.btnCatKhung.Id = 33;
            this.btnCatKhung.Name = "btnCatKhung";
            this.btnCatKhung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCatKhung_Click);
            // 
            // btnThayDoiKichThuoc
            // 
            this.btnThayDoiKichThuoc.Caption = "Resize";
            this.btnThayDoiKichThuoc.Glyph = global::Paint.Properties.Resources.resize;
            this.btnThayDoiKichThuoc.Id = 34;
            this.btnThayDoiKichThuoc.Name = "btnThayDoiKichThuoc";
            this.btnThayDoiKichThuoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThayDoiKichThuoc_Click);
            // 
            // btnRotateRight90
            // 
            this.btnRotateRight90.Caption = "btnRotateRight";
            this.btnRotateRight90.Glyph = global::Paint.Properties.Resources.rotate_right1;
            this.btnRotateRight90.Id = 38;
            this.btnRotateRight90.Name = "btnRotateRight90";
            // 
            // btnRotateLeft90
            // 
            this.btnRotateLeft90.Caption = "Rotate left 90";
            this.btnRotateLeft90.Glyph = global::Paint.Properties.Resources.rotate_left;
            this.btnRotateLeft90.Id = 39;
            this.btnRotateLeft90.Name = "btnRotateLeft90";
            // 
            // btnOutline
            // 
            this.btnOutline.Caption = "Outline";
            this.btnOutline.Glyph = global::Paint.Properties.Resources.outline1;
            this.btnOutline.Id = 54;
            this.btnOutline.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOutline_NoOutline),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOutline_SolidColor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOutline_Crayon),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOutline_Marker),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOutline_Oil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOutline_NaturalPencil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOutline_Watercolor)});
            this.btnOutline.Name = "btnOutline";
            // 
            // btnOutline_NoOutline
            // 
            this.btnOutline_NoOutline.Caption = "No outline";
            this.btnOutline_NoOutline.Glyph = global::Paint.Properties.Resources.nooutline;
            this.btnOutline_NoOutline.Id = 55;
            this.btnOutline_NoOutline.Name = "btnOutline_NoOutline";
            // 
            // btnOutline_SolidColor
            // 
            this.btnOutline_SolidColor.Caption = "Solid color";
            this.btnOutline_SolidColor.Glyph = global::Paint.Properties.Resources.solid_color;
            this.btnOutline_SolidColor.Id = 56;
            this.btnOutline_SolidColor.Name = "btnOutline_SolidColor";
            // 
            // btnOutline_Crayon
            // 
            this.btnOutline_Crayon.Caption = "Crayon";
            this.btnOutline_Crayon.Glyph = global::Paint.Properties.Resources.carayon1;
            this.btnOutline_Crayon.Id = 57;
            this.btnOutline_Crayon.Name = "btnOutline_Crayon";
            // 
            // btnOutline_Marker
            // 
            this.btnOutline_Marker.Caption = "Marker";
            this.btnOutline_Marker.Glyph = global::Paint.Properties.Resources.market_16;
            this.btnOutline_Marker.Id = 58;
            this.btnOutline_Marker.Name = "btnOutline_Marker";
            // 
            // btnOutline_Oil
            // 
            this.btnOutline_Oil.Caption = "Oil";
            this.btnOutline_Oil.Glyph = global::Paint.Properties.Resources.oil1;
            this.btnOutline_Oil.Id = 59;
            this.btnOutline_Oil.Name = "btnOutline_Oil";
            // 
            // btnOutline_NaturalPencil
            // 
            this.btnOutline_NaturalPencil.Caption = "Natural pencil";
            this.btnOutline_NaturalPencil.Glyph = global::Paint.Properties.Resources.natural_pencil_16;
            this.btnOutline_NaturalPencil.Id = 60;
            this.btnOutline_NaturalPencil.Name = "btnOutline_NaturalPencil";
            // 
            // btnOutline_Watercolor
            // 
            this.btnOutline_Watercolor.Caption = "Watercolor";
            this.btnOutline_Watercolor.Glyph = global::Paint.Properties.Resources.watercolor;
            this.btnOutline_Watercolor.Id = 61;
            this.btnOutline_Watercolor.Name = "btnOutline_Watercolor";
            // 
            // btnFill
            // 
            this.btnFill.Caption = "Fill";
            this.btnFill.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFill.Glyph")));
            this.btnFill.Id = 62;
            this.btnFill.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFill_NoFill),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFill_SolidColor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFill_Crayon),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFill_Marker),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFill_Oil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFill_NaturalPencil),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWatercolor2)});
            this.btnFill.Name = "btnFill";
            // 
            // btnFill_NoFill
            // 
            this.btnFill_NoFill.Caption = "No fill";
            this.btnFill_NoFill.Glyph = global::Paint.Properties.Resources.nooutline1;
            this.btnFill_NoFill.Id = 63;
            this.btnFill_NoFill.Name = "btnFill_NoFill";
            // 
            // btnFill_SolidColor
            // 
            this.btnFill_SolidColor.Caption = "Solid color";
            this.btnFill_SolidColor.Glyph = global::Paint.Properties.Resources.solid_color;
            this.btnFill_SolidColor.Id = 64;
            this.btnFill_SolidColor.Name = "btnFill_SolidColor";
            // 
            // btnFill_Crayon
            // 
            this.btnFill_Crayon.Caption = "Crayon";
            this.btnFill_Crayon.Glyph = global::Paint.Properties.Resources.carayon1;
            this.btnFill_Crayon.Id = 65;
            this.btnFill_Crayon.Name = "btnFill_Crayon";
            // 
            // btnFill_Marker
            // 
            this.btnFill_Marker.Caption = "Marker";
            this.btnFill_Marker.Glyph = global::Paint.Properties.Resources.market_16;
            this.btnFill_Marker.Id = 66;
            this.btnFill_Marker.Name = "btnFill_Marker";
            // 
            // btnFill_Oil
            // 
            this.btnFill_Oil.Caption = "Oil";
            this.btnFill_Oil.Glyph = global::Paint.Properties.Resources.oil;
            this.btnFill_Oil.Id = 67;
            this.btnFill_Oil.Name = "btnFill_Oil";
            // 
            // btnFill_NaturalPencil
            // 
            this.btnFill_NaturalPencil.Caption = "Natural pencil";
            this.btnFill_NaturalPencil.Glyph = global::Paint.Properties.Resources.natural_pencil_161;
            this.btnFill_NaturalPencil.Id = 68;
            this.btnFill_NaturalPencil.Name = "btnFill_NaturalPencil";
            // 
            // btnWatercolor2
            // 
            this.btnWatercolor2.Caption = "Watercolor";
            this.btnWatercolor2.Glyph = global::Paint.Properties.Resources.watercolor;
            this.btnWatercolor2.Id = 150;
            this.btnWatercolor2.Name = "btnWatercolor2";
            // 
            // btnFill_Watercolor
            // 
            this.btnFill_Watercolor.Caption = "Watercolor";
            this.btnFill_Watercolor.Id = 69;
            this.btnFill_Watercolor.Name = "btnFill_Watercolor";
            // 
            // barSubItem9
            // 
            this.barSubItem9.Caption = "barSubItem9";
            this.barSubItem9.Id = 70;
            this.barSubItem9.Name = "barSubItem9";
            // 
            // btnSize_1px
            // 
            this.btnSize_1px.Id = 73;
            this.btnSize_1px.Name = "btnSize_1px";
            // 
            // btnSize_3px
            // 
            this.btnSize_3px.Id = 74;
            this.btnSize_3px.Name = "btnSize_3px";
            // 
            // btnSize_5px
            // 
            this.btnSize_5px.Id = 75;
            this.btnSize_5px.Name = "btnSize_5px";
            // 
            // btnEditColors
            // 
            this.btnEditColors.Caption = "Edit colors";
            this.btnEditColors.Id = 84;
            this.btnEditColors.LargeGlyph = global::Paint.Properties.Resources.edit_color;
            this.btnEditColors.Name = "btnEditColors";
            this.btnEditColors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuaChonMau_Click);
            // 
            // btnPhongTo
            // 
            this.btnPhongTo.Caption = "Zoom in";
            this.btnPhongTo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhongTo.Glyph")));
            this.btnPhongTo.Id = 85;
            this.btnPhongTo.LargeGlyph = global::Paint.Properties.Resources.zoom_in_48;
            this.btnPhongTo.Name = "btnPhongTo";
            this.btnPhongTo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongTo_Click);
            // 
            // btnThuNho
            // 
            this.btnThuNho.Caption = "Zoom out";
            this.btnThuNho.Id = 86;
            this.btnThuNho.LargeGlyph = global::Paint.Properties.Resources.zoom_out_48;
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThuNho_Click);
            // 
            // btnZoom100
            // 
            this.btnZoom100.Caption = "100%";
            this.btnZoom100.Id = 87;
            this.btnZoom100.LargeGlyph = global::Paint.Properties.Resources._100_1;
            this.btnZoom100.Name = "btnZoom100";
            // 
            // barEditItem2
            // 
            this.barEditItem2.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.False;
            this.barEditItem2.Caption = "Gridlines";
            this.barEditItem2.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.barEditItem2.Edit = this.repositoryItemCheckEdit3;
            this.barEditItem2.Id = 94;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Caption = "";
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Caption = "Full screen";
            this.btnFullScreen.Id = 99;
            this.btnFullScreen.LargeGlyph = global::Paint.Properties.Resources.Full_Screen;
            this.btnFullScreen.Name = "btnFullScreen";
            // 
            // btnThumbnail
            // 
            this.btnThumbnail.Caption = "Thumbnail";
            this.btnThumbnail.Id = 100;
            this.btnThumbnail.LargeGlyph = global::Paint.Properties.Resources.thumbnail;
            this.btnThumbnail.Name = "btnThumbnail";
            // 
            // barButtonItem49
            // 
            this.barButtonItem49.Caption = "Restore";
            this.barButtonItem49.Id = 103;
            this.barButtonItem49.Name = "barButtonItem49";
            // 
            // barButtonItem50
            // 
            this.barButtonItem50.Caption = "Move";
            this.barButtonItem50.Id = 104;
            this.barButtonItem50.Name = "barButtonItem50";
            // 
            // barButtonItem51
            // 
            this.barButtonItem51.Caption = "Size";
            this.barButtonItem51.Id = 105;
            this.barButtonItem51.Name = "barButtonItem51";
            // 
            // barButtonItem52
            // 
            this.barButtonItem52.Caption = "Minimize";
            this.barButtonItem52.Id = 106;
            this.barButtonItem52.Name = "barButtonItem52";
            // 
            // barButtonItem53
            // 
            this.barButtonItem53.Caption = "Maximize";
            this.barButtonItem53.Id = 107;
            this.barButtonItem53.Name = "barButtonItem53";
            // 
            // barButtonItem54
            // 
            this.barButtonItem54.Caption = "Close                     Alt+F4";
            this.barButtonItem54.Id = 108;
            this.barButtonItem54.Name = "barButtonItem54";
            // 
            // btnSize_8px
            // 
            this.btnSize_8px.Id = 119;
            this.btnSize_8px.Name = "btnSize_8px";
            // 
            // btnCucTay
            // 
            this.btnCucTay.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCucTay.Glyph")));
            this.btnCucTay.Id = 122;
            this.btnCucTay.Name = "btnCucTay";
            this.btnCucTay.Tag = "14";
            this.btnCucTay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnBrushes
            // 
            this.btnBrushes.Caption = "Brushes";
            this.btnBrushes.Glyph = global::Paint.Properties.Resources.brushes;
            this.btnBrushes.Id = 131;
            this.btnBrushes.LargeGlyph = global::Paint.Properties.Resources.brushes;
            this.btnBrushes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBrush),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCalligraphybrush1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCalligraphybrush2),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAirbrush),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOilbrush),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCrayonBrush),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNaturalPencilBrush),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWaterColorBrush)});
            this.btnBrushes.Name = "btnBrushes";
            // 
            // btnBrush
            // 
            this.btnBrush.Caption = "Brush";
            this.btnBrush.Glyph = global::Paint.Properties.Resources.brushes;
            this.btnBrush.Id = 132;
            this.btnBrush.Name = "btnBrush";
            // 
            // btnCalligraphybrush1
            // 
            this.btnCalligraphybrush1.Caption = "Calligraphy brush 1";
            this.btnCalligraphybrush1.Glyph = global::Paint.Properties.Resources.calligraphy_brush_1;
            this.btnCalligraphybrush1.Id = 133;
            this.btnCalligraphybrush1.Name = "btnCalligraphybrush1";
            // 
            // btnCalligraphybrush2
            // 
            this.btnCalligraphybrush2.Caption = "Calligraphy brush 2";
            this.btnCalligraphybrush2.Glyph = global::Paint.Properties.Resources.calligraphy_brush_2;
            this.btnCalligraphybrush2.Id = 134;
            this.btnCalligraphybrush2.Name = "btnCalligraphybrush2";
            // 
            // btnAirbrush
            // 
            this.btnAirbrush.Caption = "Airbrush";
            this.btnAirbrush.Glyph = global::Paint.Properties.Resources.airbrush;
            this.btnAirbrush.Id = 135;
            this.btnAirbrush.Name = "btnAirbrush";
            // 
            // btnOilbrush
            // 
            this.btnOilbrush.Caption = "Oil brush";
            this.btnOilbrush.Glyph = global::Paint.Properties.Resources.oil_brush;
            this.btnOilbrush.Id = 136;
            this.btnOilbrush.Name = "btnOilbrush";
            // 
            // btnCrayonBrush
            // 
            this.btnCrayonBrush.Caption = "Crayon";
            this.btnCrayonBrush.Glyph = global::Paint.Properties.Resources.carayon;
            this.btnCrayonBrush.Id = 137;
            this.btnCrayonBrush.Name = "btnCrayonBrush";
            // 
            // btnNaturalPencilBrush
            // 
            this.btnNaturalPencilBrush.Caption = "Natural Pencil";
            this.btnNaturalPencilBrush.Glyph = global::Paint.Properties.Resources.natural_pencil;
            this.btnNaturalPencilBrush.Id = 139;
            this.btnNaturalPencilBrush.Name = "btnNaturalPencilBrush";
            // 
            // btnWaterColorBrush
            // 
            this.btnWaterColorBrush.Caption = "WaterColorBrush";
            this.btnWaterColorBrush.Glyph = global::Paint.Properties.Resources.watercolor_brush;
            this.btnWaterColorBrush.Id = 140;
            this.btnWaterColorBrush.Name = "btnWaterColorBrush";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "InplaceGallery1";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Group3";
            galleryItem1.Caption = "Item2";
            galleryItem1.Image = global::Paint.Properties.Resources.line;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1});
            this.ribbonGalleryBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.ribbonGalleryBarItem1.Id = 141;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // ribbonGalleryBarItem2
            // 
            this.ribbonGalleryBarItem2.Caption = "InplaceGallery1";
            // 
            // 
            // 
            galleryItemGroup2.Caption = "Group4";
            this.ribbonGalleryBarItem2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.ribbonGalleryBarItem2.Id = 142;
            this.ribbonGalleryBarItem2.Name = "ribbonGalleryBarItem2";
            // 
            // btnSize
            // 
            this.btnSize.Caption = "Size";
            this.btnSize.Glyph = global::Paint.Properties.Resources.Capture;
            this.btnSize.Id = 144;
            this.btnSize.LargeGlyph = global::Paint.Properties.Resources.Capture;
            this.btnSize.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSize1px),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSize3px),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSize5px),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSize8px)});
            this.btnSize.Name = "btnSize";
            // 
            // btnSize1px
            // 
            this.btnSize1px.Caption = "1px";
            this.btnSize1px.Glyph = global::Paint.Properties.Resources._1;
            this.btnSize1px.Id = 145;
            this.btnSize1px.LargeGlyph = global::Paint.Properties.Resources._1;
            this.btnSize1px.Name = "btnSize1px";
            this.btnSize1px.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSize1px_ItemClick);
            // 
            // btnSize3px
            // 
            this.btnSize3px.Caption = "3px";
            this.btnSize3px.Glyph = global::Paint.Properties.Resources._3;
            this.btnSize3px.Id = 146;
            this.btnSize3px.Name = "btnSize3px";
            this.btnSize3px.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSize3px_ItemClick);
            // 
            // btnSize5px
            // 
            this.btnSize5px.Caption = "5px";
            this.btnSize5px.Glyph = global::Paint.Properties.Resources._5;
            this.btnSize5px.Id = 147;
            this.btnSize5px.Name = "btnSize5px";
            this.btnSize5px.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSize5px_ItemClick);
            // 
            // btnSize8px
            // 
            this.btnSize8px.Caption = "8px";
            this.btnSize8px.Glyph = global::Paint.Properties.Resources._7;
            this.btnSize8px.Id = 148;
            this.btnSize8px.Name = "btnSize8px";
            this.btnSize8px.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSize8px_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 149;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnHienThiMau1
            // 
            this.btnHienThiMau1.Id = 151;
            this.btnHienThiMau1.ItemAppearance.Normal.BackColor = System.Drawing.Color.Black;
            this.btnHienThiMau1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiMau1.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnHienThiMau1.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHienThiMau1.LargeWidth = 70;
            this.btnHienThiMau1.Name = "btnHienThiMau1";
            this.btnHienThiMau1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHienThiMau1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHienThiMau1_Click);
            // 
            // btnHienThiMau2
            // 
            this.btnHienThiMau2.Id = 152;
            this.btnHienThiMau2.ItemAppearance.Normal.BackColor = System.Drawing.Color.White;
            this.btnHienThiMau2.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnHienThiMau2.LargeWidth = 70;
            this.btnHienThiMau2.Name = "btnHienThiMau2";
            this.btnHienThiMau2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHienThiMau2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHienThiMau2_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.Id = 155;
            this.btnColor3.ItemAppearance.Normal.BackColor = System.Drawing.Color.Red;
            this.btnColor3.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor5
            // 
            this.btnColor5.Id = 157;
            this.btnColor5.ItemAppearance.Normal.BackColor = System.Drawing.Color.Yellow;
            this.btnColor5.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor5.ItemInMenuAppearance.Disabled.BackColor = System.Drawing.SystemColors.Control;
            this.btnColor5.ItemInMenuAppearance.Disabled.Options.UseBackColor = true;
            this.btnColor5.ItemInMenuAppearance.Normal.BackColor = System.Drawing.Color.Yellow;
            this.btnColor5.ItemInMenuAppearance.Normal.Options.UseBackColor = true;
            this.btnColor5.Name = "btnColor5";
            this.btnColor5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor6
            // 
            this.btnColor6.Id = 158;
            this.btnColor6.ItemAppearance.Normal.BackColor = System.Drawing.Color.Lime;
            this.btnColor6.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor6.Name = "btnColor6";
            this.btnColor6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor4
            // 
            this.btnColor4.Id = 159;
            this.btnColor4.ItemAppearance.Normal.BackColor = System.Drawing.Color.Aqua;
            this.btnColor4.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor4.Name = "btnColor4";
            this.btnColor4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor7
            // 
            this.btnColor7.Id = 160;
            this.btnColor7.ItemAppearance.Normal.BackColor = System.Drawing.Color.Blue;
            this.btnColor7.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor7.Name = "btnColor7";
            this.btnColor7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor8
            // 
            this.btnColor8.Id = 161;
            this.btnColor8.ItemAppearance.Normal.BackColor = System.Drawing.Color.Fuchsia;
            this.btnColor8.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor8.Name = "btnColor8";
            this.btnColor8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor9
            // 
            this.btnColor9.Id = 162;
            this.btnColor9.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnColor9.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor9.Name = "btnColor9";
            this.btnColor9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor10
            // 
            this.btnColor10.Id = 163;
            this.btnColor10.ItemAppearance.Normal.BackColor = System.Drawing.Color.Silver;
            this.btnColor10.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor10.Name = "btnColor10";
            this.btnColor10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor11
            // 
            this.btnColor11.Id = 164;
            this.btnColor11.ItemAppearance.Normal.BackColor = System.Drawing.Color.Purple;
            this.btnColor11.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor11.Name = "btnColor11";
            this.btnColor11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor12
            // 
            this.btnColor12.Id = 165;
            this.btnColor12.ItemAppearance.Normal.BackColor = System.Drawing.Color.Green;
            this.btnColor12.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor12.Name = "btnColor12";
            this.btnColor12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor13
            // 
            this.btnColor13.Id = 166;
            this.btnColor13.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColor13.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor13.Name = "btnColor13";
            this.btnColor13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor14
            // 
            this.btnColor14.Id = 167;
            this.btnColor14.ItemAppearance.Normal.BackColor = System.Drawing.Color.Maroon;
            this.btnColor14.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor14.Name = "btnColor14";
            this.btnColor14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor15
            // 
            this.btnColor15.Id = 168;
            this.btnColor15.ItemAppearance.Normal.BackColor = System.Drawing.Color.White;
            this.btnColor15.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor15.Name = "btnColor15";
            this.btnColor15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor16
            // 
            this.btnColor16.Id = 169;
            this.btnColor16.ItemAppearance.Normal.BackColor = System.Drawing.Color.Black;
            this.btnColor16.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor16.Name = "btnColor16";
            this.btnColor16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // btnColor17
            // 
            this.btnColor17.Id = 170;
            this.btnColor17.ItemAppearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnColor17.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnColor17.ItemInMenuAppearance.Normal.BackColor = System.Drawing.SystemColors.Control;
            this.btnColor17.ItemInMenuAppearance.Normal.Options.UseBackColor = true;
            this.btnColor17.Name = "btnColor17";
            this.btnColor17.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonMau_Click);
            // 
            // checkRulers
            // 
            this.checkRulers.Caption = "Rulers";
            this.checkRulers.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.checkRulers.Id = 173;
            this.checkRulers.Name = "checkRulers";
            // 
            // checkGridline
            // 
            this.checkGridline.Caption = "Gridline";
            this.checkGridline.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.checkGridline.Id = 174;
            this.checkGridline.Name = "checkGridline";
            // 
            // checkStatusBar
            // 
            this.checkStatusBar.Caption = "Status bar";
            this.checkStatusBar.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.checkStatusBar.Id = 175;
            this.checkStatusBar.Name = "checkStatusBar";
            // 
            // Zoom
            // 
            this.Zoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.Zoom.Caption = "100%";
            this.Zoom.Edit = this.repositoryItemZoomTrackBar1;
            this.Zoom.EditWidth = 140;
            this.Zoom.Id = 178;
            this.Zoom.Name = "Zoom";
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Tọa độ";
            this.barStaticItem1.Id = 180;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnVeDuongThang
            // 
            this.btnVeDuongThang.Glyph = global::Paint.Properties.Resources.line2;
            this.btnVeDuongThang.Id = 182;
            this.btnVeDuongThang.Name = "btnVeDuongThang";
            this.btnVeDuongThang.Tag = "5";
            this.btnVeDuongThang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeHinhEllipse
            // 
            this.btnVeHinhEllipse.Glyph = global::Paint.Properties.Resources.oval1;
            this.btnVeHinhEllipse.Id = 183;
            this.btnVeHinhEllipse.Name = "btnVeHinhEllipse";
            this.btnVeHinhEllipse.Tag = "4";
            this.btnVeHinhEllipse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeHinhChuNhat
            // 
            this.btnVeHinhChuNhat.Glyph = global::Paint.Properties.Resources.rectangle1;
            this.btnVeHinhChuNhat.Id = 184;
            this.btnVeHinhChuNhat.Name = "btnVeHinhChuNhat";
            this.btnVeHinhChuNhat.Tag = "3";
            this.btnVeHinhChuNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeHinhLucGiac
            // 
            this.btnVeHinhLucGiac.Glyph = global::Paint.Properties.Resources.hexagon;
            this.btnVeHinhLucGiac.Id = 185;
            this.btnVeHinhLucGiac.Name = "btnVeHinhLucGiac";
            this.btnVeHinhLucGiac.Tag = "11";
            this.btnVeHinhLucGiac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeTamGiac
            // 
            this.btnVeTamGiac.Glyph = global::Paint.Properties.Resources.triangle;
            this.btnVeTamGiac.Id = 186;
            this.btnVeTamGiac.Name = "btnVeTamGiac";
            this.btnVeTamGiac.Tag = "9";
            this.btnVeTamGiac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeDuongCong
            // 
            this.btnVeDuongCong.Glyph = global::Paint.Properties.Resources.curve;
            this.btnVeDuongCong.Id = 187;
            this.btnVeDuongCong.Name = "btnVeDuongCong";
            this.btnVeDuongCong.Tag = "13";
            this.btnVeDuongCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeHinhThoi
            // 
            this.btnVeHinhThoi.Glyph = global::Paint.Properties.Resources.diamond1;
            this.btnVeHinhThoi.Id = 188;
            this.btnVeHinhThoi.Name = "btnVeHinhThoi";
            this.btnVeHinhThoi.Tag = "10";
            this.btnVeHinhThoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeHinhMuiTen
            // 
            this.btnVeHinhMuiTen.Glyph = global::Paint.Properties.Resources.down_arrow1;
            this.btnVeHinhMuiTen.Id = 189;
            this.btnVeHinhMuiTen.Name = "btnVeHinhMuiTen";
            this.btnVeHinhMuiTen.Tag = "8";
            this.btnVeHinhMuiTen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnVeHinhTraiTim
            // 
            this.btnVeHinhTraiTim.Glyph = global::Paint.Properties.Resources.heart1;
            this.btnVeHinhTraiTim.Id = 190;
            this.btnVeHinhTraiTim.Name = "btnVeHinhTraiTim";
            this.btnVeHinhTraiTim.Tag = "7";
            this.btnVeHinhTraiTim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiTuong_Click);
            // 
            // btnPasteText
            // 
            this.btnPasteText.Caption = "Paste";
            this.btnPasteText.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPasteText.Glyph")));
            this.btnPasteText.Id = 192;
            this.btnPasteText.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPasteText.LargeGlyph")));
            this.btnPasteText.Name = "btnPasteText";
            // 
            // btnCutText
            // 
            this.btnCutText.Caption = "Cut";
            this.btnCutText.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCutText.Glyph")));
            this.btnCutText.Id = 193;
            this.btnCutText.Name = "btnCutText";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Copy";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 194;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Font";
            this.barEditItem1.Edit = this.repositoryItemFontEdit2;
            this.barEditItem1.Id = 197;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemFontEdit2
            // 
            this.repositoryItemFontEdit2.AutoHeight = false;
            this.repositoryItemFontEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit2.Name = "repositoryItemFontEdit2";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Paste";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 198;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Cut";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 199;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Copy";
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 200;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // btnFont
            // 
            this.btnFont.Caption = "Font";
            this.btnFont.Edit = this.repositoryItemFontEdit3;
            this.btnFont.EditWidth = 150;
            this.btnFont.Id = 201;
            this.btnFont.Name = "btnFont";
            // 
            // repositoryItemFontEdit3
            // 
            this.repositoryItemFontEdit3.AutoHeight = false;
            this.repositoryItemFontEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit3.MaxLength = 10;
            this.repositoryItemFontEdit3.Name = "repositoryItemFontEdit3";
            this.repositoryItemFontEdit3.PopupFormSize = new System.Drawing.Size(10, 0);
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "Size";
            this.barEditItem3.Edit = this.repositoryItemTextEdit1;
            this.barEditItem3.Id = 202;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "B";
            this.barButtonItem9.Id = 204;
            this.barButtonItem9.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "Color";
            this.barEditItem4.Edit = this.repositoryItemColorEdit1;
            this.barEditItem4.Id = 210;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // btnFacebook
            // 
            this.btnFacebook.Caption = "Status";
            this.btnFacebook.Id = 211;
            this.btnFacebook.LargeGlyph = global::Paint.Properties.Resources.fb;
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFacebook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFacebook_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 212;
            this.btnUndo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.LargeGlyph")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRedo.Glyph")));
            this.btnRedo.Id = 213;
            this.btnRedo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRedo.LargeGlyph")));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
            // 
            // btnRotate
            // 
            this.btnRotate.Caption = "Rotate";
            this.btnRotate.Glyph = global::Paint.Properties.Resources.rotate_right;
            this.btnRotate.Id = 215;
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRotate_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Caption = "Paste";
            this.btnPaste.Id = 216;
            this.btnPaste.LargeGlyph = global::Paint.Properties.Resources.Paste_48;
            this.btnPaste.Name = "btnPaste";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Copy";
            this.barButtonItem12.Glyph = global::Paint.Properties.Resources.copy_24;
            this.barButtonItem12.Id = 217;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // btnCut
            // 
            this.btnCut.Caption = "Cut";
            this.btnCut.Glyph = global::Paint.Properties.Resources.cut_16;
            this.btnCut.Id = 218;
            this.btnCut.Name = "btnCut";
            // 
            // Home
            // 
            this.Home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.pgImage,
            this.pgTools,
            this.pgBrushes,
            this.pgShapes,
            this.pgSize,
            this.pgColors});
            this.Home.Name = "Home";
            this.Home.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPaste);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem12);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCut);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Clipboard";
            // 
            // pgImage
            // 
            this.pgImage.Glyph = global::Paint.Properties.Resources.RectangularSelection_48;
            this.pgImage.ItemLinks.Add(this.btnChonKhuVuc);
            this.pgImage.ItemLinks.Add(this.btnCatKhung);
            this.pgImage.ItemLinks.Add(this.btnThayDoiKichThuoc);
            this.pgImage.ItemLinks.Add(this.btnRotate);
            this.pgImage.Name = "pgImage";
            this.pgImage.Text = "Image";
            // 
            // pgTools
            // 
            this.pgTools.Glyph = global::Paint.Properties.Resources.color_48;
            this.pgTools.ItemLinks.Add(this.btnVeTuDo);
            this.pgTools.ItemLinks.Add(this.btnDoMau);
            this.pgTools.ItemLinks.Add(this.btnText);
            this.pgTools.ItemLinks.Add(this.btnChinhSua);
            this.pgTools.ItemLinks.Add(this.btnMagnifier);
            this.pgTools.ItemLinks.Add(this.btnCucTay);
            this.pgTools.ItemLinks.Add(this.btnFacebook);
            this.pgTools.Name = "pgTools";
            this.pgTools.Text = "Tools";
            // 
            // pgBrushes
            // 
            this.pgBrushes.ItemLinks.Add(this.btnBrushes);
            this.pgBrushes.Name = "pgBrushes";
            // 
            // pgShapes
            // 
            this.pgShapes.Glyph = ((System.Drawing.Image)(resources.GetObject("pgShapes.Glyph")));
            this.pgShapes.ItemLinks.Add(this.btnVeDuongThang, true);
            this.pgShapes.ItemLinks.Add(this.btnVeHinhChuNhat);
            this.pgShapes.ItemLinks.Add(this.btnVeHinhLucGiac);
            this.pgShapes.ItemLinks.Add(this.btnVeDuongCong);
            this.pgShapes.ItemLinks.Add(this.btnVeTamGiac);
            this.pgShapes.ItemLinks.Add(this.btnVeHinhThoi);
            this.pgShapes.ItemLinks.Add(this.btnVeHinhEllipse);
            this.pgShapes.ItemLinks.Add(this.btnVeHinhMuiTen);
            this.pgShapes.ItemLinks.Add(this.btnVeHinhTraiTim);
            this.pgShapes.ItemLinks.Add(this.btnOutline);
            this.pgShapes.ItemLinks.Add(this.btnFill);
            this.pgShapes.Name = "pgShapes";
            this.pgShapes.Text = "Shapes";
            // 
            // pgSize
            // 
            this.pgSize.ItemLinks.Add(this.btnSize);
            this.pgSize.Name = "pgSize";
            // 
            // pgColors
            // 
            this.pgColors.ItemLinks.Add(this.btnHienThiMau1);
            this.pgColors.ItemLinks.Add(this.btnHienThiMau2);
            this.pgColors.ItemLinks.Add(this.btnColor5);
            this.pgColors.ItemLinks.Add(this.btnColor4);
            this.pgColors.ItemLinks.Add(this.btnColor10);
            this.pgColors.ItemLinks.Add(this.btnColor11);
            this.pgColors.ItemLinks.Add(this.btnColor15);
            this.pgColors.ItemLinks.Add(this.btnColor12);
            this.pgColors.ItemLinks.Add(this.btnColor8);
            this.pgColors.ItemLinks.Add(this.btnColor7);
            this.pgColors.ItemLinks.Add(this.btnColor16);
            this.pgColors.ItemLinks.Add(this.btnColor9);
            this.pgColors.ItemLinks.Add(this.btnColor3);
            this.pgColors.ItemLinks.Add(this.btnColor6);
            this.pgColors.ItemLinks.Add(this.btnColor17);
            this.pgColors.ItemLinks.Add(this.btnColor13);
            this.pgColors.ItemLinks.Add(this.btnColor14);
            this.pgColors.ItemLinks.Add(this.btnEditColors);
            this.pgColors.Name = "pgColors";
            this.pgColors.Text = "Colors";
            // 
            // View
            // 
            this.View.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgZoom,
            this.pgShowOrHide,
            this.btnDisplay});
            this.View.Name = "View";
            this.View.Text = "View";
            // 
            // pgZoom
            // 
            this.pgZoom.ItemLinks.Add(this.btnPhongTo);
            this.pgZoom.ItemLinks.Add(this.btnThuNho);
            this.pgZoom.ItemLinks.Add(this.btnZoom100);
            this.pgZoom.Name = "pgZoom";
            this.pgZoom.Text = "Zoom";
            // 
            // pgShowOrHide
            // 
            this.pgShowOrHide.ItemLinks.Add(this.checkRulers);
            this.pgShowOrHide.ItemLinks.Add(this.checkGridline);
            this.pgShowOrHide.ItemLinks.Add(this.checkStatusBar);
            this.pgShowOrHide.Name = "pgShowOrHide";
            this.pgShowOrHide.Text = "Show or hide";
            // 
            // btnDisplay
            // 
            this.btnDisplay.ItemLinks.Add(this.btnFullScreen);
            this.btnDisplay.ItemLinks.Add(this.btnThumbnail);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Text = "Display";
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // repositoryItemPopupGalleryEdit1
            // 
            this.repositoryItemPopupGalleryEdit1.AutoHeight = false;
            this.repositoryItemPopupGalleryEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1";
            // 
            // repositoryItemColorPickEdit2
            // 
            this.repositoryItemColorPickEdit2.AutoHeight = false;
            this.repositoryItemColorPickEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit2.Name = "repositoryItemColorPickEdit2";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckedComboBoxEdit1
            // 
            this.repositoryItemCheckedComboBoxEdit1.AutoHeight = false;
            this.repositoryItemCheckedComboBoxEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCheckedComboBoxEdit1.Name = "repositoryItemCheckedComboBoxEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "";
            this.repositoryItemCheckEdit2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Caption = "";
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // repositoryItemCheckEdit5
            // 
            this.repositoryItemCheckEdit5.AutoHeight = false;
            this.repositoryItemCheckEdit5.Caption = "";
            this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            // 
            // repositoryItemPopupGalleryEdit2
            // 
            this.repositoryItemPopupGalleryEdit2.AutoHeight = false;
            this.repositoryItemPopupGalleryEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupGalleryEdit2.Name = "repositoryItemPopupGalleryEdit2";
            // 
            // repositoryItemCheckEdit6
            // 
            this.repositoryItemCheckEdit6.AutoHeight = false;
            this.repositoryItemCheckEdit6.Name = "repositoryItemCheckEdit6";
            // 
            // repositoryItemColorPickEdit3
            // 
            this.repositoryItemColorPickEdit3.AutoHeight = false;
            this.repositoryItemColorPickEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit3.Name = "repositoryItemColorPickEdit3";
            // 
            // repositoryItemPopupGalleryEdit3
            // 
            this.repositoryItemPopupGalleryEdit3.AutoHeight = false;
            this.repositoryItemPopupGalleryEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupGalleryEdit3.Name = "repositoryItemPopupGalleryEdit3";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // repositoryItemImageComboBox2
            // 
            this.repositoryItemImageComboBox2.AutoHeight = false;
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            // 
            // repositoryItemImageComboBox3
            // 
            this.repositoryItemImageComboBox3.AutoHeight = false;
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // repositoryItemPopupGalleryEdit4
            // 
            this.repositoryItemPopupGalleryEdit4.AutoHeight = false;
            this.repositoryItemPopupGalleryEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupGalleryEdit4.Name = "repositoryItemPopupGalleryEdit4";
            // 
            // repositoryItemCheckEdit7
            // 
            this.repositoryItemCheckEdit7.AutoHeight = false;
            this.repositoryItemCheckEdit7.Name = "repositoryItemCheckEdit7";
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            // 
            // repositoryItemRangeTrackBar1
            // 
            this.repositoryItemRangeTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemRangeTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemRangeTrackBar1.Name = "repositoryItemRangeTrackBar1";
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Off";
            this.repositoryItemToggleSwitch1.OnText = "On";
            // 
            // repositoryItemPopupGalleryEdit5
            // 
            this.repositoryItemPopupGalleryEdit5.AutoHeight = false;
            this.repositoryItemPopupGalleryEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupGalleryEdit5.Name = "repositoryItemPopupGalleryEdit5";
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // repositoryItemFontEdit4
            // 
            this.repositoryItemFontEdit4.AutoHeight = false;
            this.repositoryItemFontEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit4.Name = "repositoryItemFontEdit4";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.Zoom, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.rbcMainPaint;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1090, 31);
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "Outline";
            this.barSubItem6.Id = 54;
            this.barSubItem6.Name = "barSubItem6";
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "Outline";
            this.barSubItem7.Id = 54;
            this.barSubItem7.Name = "barSubItem7";
            // 
            // popupMenu6
            // 
            this.popupMenu6.Name = "popupMenu6";
            this.popupMenu6.Ribbon = this.rbcMainPaint;
            // 
            // popupMenu7
            // 
            this.popupMenu7.Name = "popupMenu7";
            this.popupMenu7.Ribbon = this.rbcMainPaint;
            // 
            // galleryDropDown1
            // 
            // 
            // 
            // 
            galleryItemGroup3.Caption = "Group5";
            this.galleryDropDown1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup3});
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.rbcMainPaint;
            // 
            // galleryDropDown2
            // 
            // 
            // 
            // 
            galleryItemGroup4.Caption = "Group6";
            this.galleryDropDown2.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup4});
            this.galleryDropDown2.Name = "galleryDropDown2";
            this.galleryDropDown2.Ribbon = this.rbcMainPaint;
            // 
            // galleryDropDown3
            // 
            this.galleryDropDown3.Name = "galleryDropDown3";
            this.galleryDropDown3.Ribbon = this.rbcMainPaint;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1090, 425);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.Picture_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Picture_Mouse_Down);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_Mouse_Move);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Picture_Mouse_Up);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "B";
            this.barButtonItem10.Id = 204;
            this.barButtonItem10.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem10.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "B";
            this.barButtonItem11.Id = 204;
            this.barButtonItem11.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem11.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "U";
            this.barButtonItem13.Id = 207;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // MainPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.rbcMainPaint);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPaint";
            this.Ribbon = this.rbcMainPaint;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Chương trình Paint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MenuFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbcMainPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckedComboBoxEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRangeTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupGalleryEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarSubItem barSubItem7;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu MenuFile;
        private DevExpress.XtraBars.PopupMenu popupMenu6;
        private DevExpress.XtraBars.PopupMenu popupMenu7;
        private DevExpress.XtraBars.Ribbon.RibbonControl rbcMainPaint;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarSubItem btnChonKhuVuc;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarButtonItem btnRectangularSelection;
        private DevExpress.XtraBars.BarButtonItem btnFreeformSelection;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem btnSelectAll;
        private DevExpress.XtraBars.BarButtonItem btnInvertSelection;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnTransparentSelection;
        private DevExpress.XtraBars.BarButtonItem btnVeTuDo;
        private DevExpress.XtraBars.BarButtonItem btnDoMau;
        private DevExpress.XtraBars.BarButtonItem btnText;
        private DevExpress.XtraBars.BarButtonItem btnEraser;
        private DevExpress.XtraBars.BarButtonItem btnChinhSua;
        private DevExpress.XtraBars.BarButtonItem btnMagnifier;
        private DevExpress.XtraBars.BarButtonItem btnCatKhung;
        private DevExpress.XtraBars.BarButtonItem btnThayDoiKichThuoc;
        private DevExpress.XtraBars.BarButtonItem btnRotateRight90;
        private DevExpress.XtraBars.BarButtonItem btnRotateLeft90;
        private DevExpress.XtraBars.BarSubItem btnOutline;
        private DevExpress.XtraBars.BarButtonItem btnOutline_NoOutline;
        private DevExpress.XtraBars.BarButtonItem btnOutline_SolidColor;
        private DevExpress.XtraBars.BarButtonItem btnOutline_Crayon;
        private DevExpress.XtraBars.BarButtonItem btnOutline_Marker;
        private DevExpress.XtraBars.BarButtonItem btnOutline_Oil;
        private DevExpress.XtraBars.BarButtonItem btnOutline_NaturalPencil;
        private DevExpress.XtraBars.BarButtonItem btnOutline_Watercolor;
        private DevExpress.XtraBars.BarSubItem btnFill;
        private DevExpress.XtraBars.BarButtonItem btnFill_NoFill;
        private DevExpress.XtraBars.BarButtonItem btnFill_SolidColor;
        private DevExpress.XtraBars.BarButtonItem btnFill_Crayon;
        private DevExpress.XtraBars.BarButtonItem btnFill_Marker;
        private DevExpress.XtraBars.BarButtonItem btnFill_Oil;
        private DevExpress.XtraBars.BarButtonItem btnFill_NaturalPencil;
        private DevExpress.XtraBars.BarButtonItem btnFill_Watercolor;
        private DevExpress.XtraBars.BarSubItem barSubItem9;
        private DevExpress.XtraBars.BarButtonItem btnSize_1px;
        private DevExpress.XtraBars.BarButtonItem btnSize_3px;
        private DevExpress.XtraBars.BarButtonItem btnSize_5px;
        private DevExpress.XtraBars.BarButtonItem btnSize_8px;
        private DevExpress.XtraBars.BarButtonItem btnEditColors;
        private DevExpress.XtraBars.BarButtonItem btnPhongTo;
        private DevExpress.XtraBars.BarButtonItem btnThuNho;
        private DevExpress.XtraBars.BarButtonItem btnZoom100;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
        private DevExpress.XtraBars.BarButtonItem btnFullScreen;
        private DevExpress.XtraBars.BarButtonItem btnThumbnail;
        private DevExpress.XtraBars.BarButtonItem barButtonItem49;
        private DevExpress.XtraBars.BarButtonItem barButtonItem50;
        private DevExpress.XtraBars.BarButtonItem barButtonItem51;
        private DevExpress.XtraBars.BarButtonItem barButtonItem52;
        private DevExpress.XtraBars.BarButtonItem barButtonItem53;
        private DevExpress.XtraBars.BarButtonItem barButtonItem54;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnOpen;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnSaveAs;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit6;
        private DevExpress.XtraBars.BarButtonItem btnCucTay;
        private DevExpress.XtraBars.Ribbon.RibbonPage Home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgImage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgTools;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgBrushes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgShapes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgSize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgColors;
        private DevExpress.XtraBars.Ribbon.RibbonPage View;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgZoom;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgShowOrHide;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnDisplay;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit repositoryItemCheckedComboBoxEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraBars.BarSubItem btnBrushes;
        private DevExpress.XtraBars.BarButtonItem btnBrush;
        private DevExpress.XtraBars.BarButtonItem btnCalligraphybrush1;
        private DevExpress.XtraBars.BarButtonItem btnCalligraphybrush2;
        private DevExpress.XtraBars.BarButtonItem btnAirbrush;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit4;
        private DevExpress.XtraBars.BarButtonItem btnOilbrush;
        private DevExpress.XtraBars.BarButtonItem btnCrayonBrush;
        private DevExpress.XtraBars.BarButtonItem btnNaturalPencilBrush;
        private DevExpress.XtraBars.BarButtonItem btnWaterColorBrush;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown3;
        private DevExpress.XtraBars.BarSubItem btnSize;
        private DevExpress.XtraBars.BarButtonItem btnSize1px;
        private DevExpress.XtraBars.BarButtonItem btnSize3px;
        private DevExpress.XtraBars.BarButtonItem btnSize5px;
        private DevExpress.XtraBars.BarButtonItem btnSize8px;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnWatercolor2;
        private DevExpress.XtraBars.BarButtonItem btnHienThiMau1;
        private DevExpress.XtraBars.BarButtonItem btnHienThiMau2;
        private DevExpress.XtraBars.BarButtonItem btnColor3;
        private DevExpress.XtraBars.BarButtonItem btnColor5;
        private DevExpress.XtraBars.BarButtonItem btnColor6;
        private DevExpress.XtraBars.BarButtonItem btnColor4;
        private DevExpress.XtraBars.BarButtonItem btnColor7;
        private DevExpress.XtraBars.BarButtonItem btnColor8;
        private DevExpress.XtraBars.BarButtonItem btnColor9;
        private DevExpress.XtraBars.BarButtonItem btnColor10;
        private DevExpress.XtraBars.BarButtonItem btnColor11;
        private DevExpress.XtraBars.BarButtonItem btnColor12;
        private DevExpress.XtraBars.BarButtonItem btnColor13;
        private DevExpress.XtraBars.BarButtonItem btnColor14;
        private DevExpress.XtraBars.BarButtonItem btnColor15;
        private DevExpress.XtraBars.BarButtonItem btnColor16;
        private DevExpress.XtraBars.BarButtonItem btnColor17;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit7;
        private DevExpress.XtraBars.BarCheckItem checkRulers;
        private DevExpress.XtraBars.BarCheckItem checkGridline;
        private DevExpress.XtraBars.BarCheckItem checkStatusBar;
        private DevExpress.XtraBars.BarEditItem Zoom;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar repositoryItemRangeTrackBar1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
        private DevExpress.XtraBars.BarButtonItem btnVeDuongThang;
        private DevExpress.XtraBars.BarButtonItem btnVeHinhEllipse;
        private DevExpress.XtraBars.BarButtonItem btnVeHinhChuNhat;
        private DevExpress.XtraBars.BarButtonItem btnVeHinhLucGiac;
        private DevExpress.XtraBars.BarButtonItem btnVeTamGiac;
        private DevExpress.XtraBars.BarButtonItem btnVeDuongCong;
        private DevExpress.XtraBars.BarButtonItem btnVeHinhThoi;
        private DevExpress.XtraBars.BarButtonItem btnVeHinhMuiTen;
        private DevExpress.XtraBars.BarButtonItem btnVeHinhTraiTim;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.BarButtonItem btnPasteText;
        private DevExpress.XtraBars.BarButtonItem btnCutText;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit repositoryItemPopupGalleryEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarEditItem btnFont;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit3;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private DevExpress.XtraBars.BarButtonItem btnFacebook;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit4;
        private DevExpress.XtraBars.BarButtonItem btnRotate;
        private DevExpress.XtraBars.BarButtonItem btnPaste;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem btnCut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

