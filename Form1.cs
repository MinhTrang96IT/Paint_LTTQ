using System;
using System.Windows.Forms;

using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;

using DevExpress.XtraBars.Ribbon.Gallery;


namespace Paint
{
    public partial class MainPaint : RibbonForm
    {
        public MainPaint()
        {
            InitializeComponent();

            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

        }

        private void MainPaint_Load(object sender, EventArgs e)
        {

        }

        private void Shapes(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnShapes_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            
        }

        private void btnDownArrow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


    }
}
