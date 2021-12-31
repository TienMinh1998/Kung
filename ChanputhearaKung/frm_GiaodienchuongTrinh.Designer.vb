Partial Public Class GiaodienChuongTrinh
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GiaodienChuongTrinh))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btn_diachat = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_vatlieudai = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_vatlieucoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_noiluc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_dulieudai = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_dulieucoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_soluongcoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_kiemtradai = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_tinhthepdai = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_vedai = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_xuatbanvedai = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_kiemtracoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_vecoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_xuatbanvecoc = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_capnhatthuyetminh = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_luuthuyetminh = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_hdsd = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_gioithieu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_thepdai = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_vedaimong = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_xuatbanvedaimong = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_huongdan = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_me = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_xem_ket_qua_Tinh_Toan = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_gioi_thieu = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Tinh_thep = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_banve_coc = New DevExpress.XtraBars.BarButtonItem()
        Me.rb_nhapdulieu = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.btn_diachat, Me.btn_vatlieudai, Me.btn_vatlieucoc, Me.btn_noiluc, Me.btn_dulieudai, Me.btn_dulieucoc, Me.btn_soluongcoc, Me.btn_kiemtradai, Me.btn_tinhthepdai, Me.btn_vedai, Me.btn_xuatbanvedai, Me.btn_kiemtracoc, Me.btn_vecoc, Me.btn_xuatbanvecoc, Me.btn_capnhatthuyetminh, Me.btn_luuthuyetminh, Me.btn_hdsd, Me.btn_gioithieu, Me.BarButtonItem1, Me.BarButtonItem2, Me.btn_thepdai, Me.btn_vedaimong, Me.btn_xuatbanvedaimong, Me.btn_huongdan, Me.btn_me, Me.btn_xem_ket_qua_Tinh_Toan, Me.btn_gioi_thieu, Me.btn_Tinh_thep, Me.BarButtonItem4, Me.btn_banve_coc})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 32
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rb_nhapdulieu})
        Me.ribbonControl1.Size = New System.Drawing.Size(1099, 158)
        '
        'btn_diachat
        '
        Me.btn_diachat.Caption = "1. Nhập Địa Chất."
        Me.btn_diachat.Id = 1
        Me.btn_diachat.ImageOptions.Image = CType(resources.GetObject("btn_diachat.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_diachat.ImageOptions.LargeImage = CType(resources.GetObject("btn_diachat.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_diachat.Name = "btn_diachat"
        Me.btn_diachat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_vatlieudai
        '
        Me.btn_vatlieudai.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_vatlieudai.Caption = "2. Chọn vật liệu."
        Me.btn_vatlieudai.Id = 2
        Me.btn_vatlieudai.ImageOptions.Image = CType(resources.GetObject("btn_vatlieudai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_vatlieudai.ImageOptions.LargeImage = CType(resources.GetObject("btn_vatlieudai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_vatlieudai.Name = "btn_vatlieudai"
        Me.btn_vatlieudai.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_vatlieucoc
        '
        Me.btn_vatlieucoc.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_vatlieucoc.Caption = "Vật Liệu Cọc"
        Me.btn_vatlieucoc.Id = 3
        Me.btn_vatlieucoc.ImageOptions.Image = Global.ChanputhearaKung.My.Resources.Resources.experiment_100px
        Me.btn_vatlieucoc.Name = "btn_vatlieucoc"
        Me.btn_vatlieucoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_noiluc
        '
        Me.btn_noiluc.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_noiluc.Caption = "5. Nhập Nội Lực"
        Me.btn_noiluc.Id = 4
        Me.btn_noiluc.ImageOptions.Image = CType(resources.GetObject("btn_noiluc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_noiluc.ImageOptions.LargeImage = CType(resources.GetObject("btn_noiluc.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_noiluc.Name = "btn_noiluc"
        Me.btn_noiluc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_dulieudai
        '
        Me.btn_dulieudai.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_dulieudai.Caption = "3. Nhập dữ liệu đài."
        Me.btn_dulieudai.Id = 5
        Me.btn_dulieudai.ImageOptions.Image = CType(resources.GetObject("btn_dulieudai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_dulieudai.ImageOptions.LargeImage = CType(resources.GetObject("btn_dulieudai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_dulieudai.Name = "btn_dulieudai"
        Me.btn_dulieudai.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_dulieucoc
        '
        Me.btn_dulieucoc.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_dulieucoc.Caption = "4. Dữ Liệu Cọc."
        Me.btn_dulieucoc.Id = 6
        Me.btn_dulieucoc.ImageOptions.Image = CType(resources.GetObject("btn_dulieucoc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_dulieucoc.ImageOptions.LargeImage = CType(resources.GetObject("btn_dulieucoc.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_dulieucoc.Name = "btn_dulieucoc"
        Me.btn_dulieucoc.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btn_soluongcoc
        '
        Me.btn_soluongcoc.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_soluongcoc.Caption = "Số Lượng Cọc"
        Me.btn_soluongcoc.Id = 7
        Me.btn_soluongcoc.ImageOptions.Image = CType(resources.GetObject("btn_soluongcoc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_soluongcoc.Name = "btn_soluongcoc"
        Me.btn_soluongcoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_kiemtradai
        '
        Me.btn_kiemtradai.Caption = "Kiểm Tra"
        Me.btn_kiemtradai.Id = 8
        Me.btn_kiemtradai.ImageOptions.Image = CType(resources.GetObject("btn_kiemtradai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_kiemtradai.ImageOptions.LargeImage = CType(resources.GetObject("btn_kiemtradai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_kiemtradai.Name = "btn_kiemtradai"
        '
        'btn_tinhthepdai
        '
        Me.btn_tinhthepdai.Caption = "Tính Thép"
        Me.btn_tinhthepdai.Id = 9
        Me.btn_tinhthepdai.ImageOptions.Image = CType(resources.GetObject("btn_tinhthepdai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_tinhthepdai.ImageOptions.LargeImage = CType(resources.GetObject("btn_tinhthepdai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_tinhthepdai.Name = "btn_tinhthepdai"
        '
        'btn_vedai
        '
        Me.btn_vedai.Caption = "Vẽ Đài"
        Me.btn_vedai.Id = 10
        Me.btn_vedai.ImageOptions.Image = CType(resources.GetObject("btn_vedai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_vedai.ImageOptions.LargeImage = CType(resources.GetObject("btn_vedai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_vedai.Name = "btn_vedai"
        '
        'btn_xuatbanvedai
        '
        Me.btn_xuatbanvedai.Caption = "Xuất Bản Vẽ"
        Me.btn_xuatbanvedai.Id = 11
        Me.btn_xuatbanvedai.ImageOptions.Image = CType(resources.GetObject("btn_xuatbanvedai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_xuatbanvedai.Name = "btn_xuatbanvedai"
        Me.btn_xuatbanvedai.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_kiemtracoc
        '
        Me.btn_kiemtracoc.Caption = "Kiểm Tra"
        Me.btn_kiemtracoc.Id = 12
        Me.btn_kiemtracoc.ImageOptions.Image = CType(resources.GetObject("btn_kiemtracoc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_kiemtracoc.ImageOptions.LargeImage = CType(resources.GetObject("btn_kiemtracoc.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_kiemtracoc.Name = "btn_kiemtracoc"
        '
        'btn_vecoc
        '
        Me.btn_vecoc.Caption = "Vẽ Cọc"
        Me.btn_vecoc.Id = 13
        Me.btn_vecoc.ImageOptions.Image = CType(resources.GetObject("btn_vecoc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_vecoc.ImageOptions.LargeImage = CType(resources.GetObject("btn_vecoc.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_vecoc.Name = "btn_vecoc"
        '
        'btn_xuatbanvecoc
        '
        Me.btn_xuatbanvecoc.Caption = "Xuất Bản Vẽ"
        Me.btn_xuatbanvecoc.Id = 14
        Me.btn_xuatbanvecoc.ImageOptions.Image = CType(resources.GetObject("btn_xuatbanvecoc.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_xuatbanvecoc.Name = "btn_xuatbanvecoc"
        Me.btn_xuatbanvecoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_capnhatthuyetminh
        '
        Me.btn_capnhatthuyetminh.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_capnhatthuyetminh.Caption = "Cập Nhật"
        Me.btn_capnhatthuyetminh.Id = 15
        Me.btn_capnhatthuyetminh.ImageOptions.Image = CType(resources.GetObject("btn_capnhatthuyetminh.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_capnhatthuyetminh.ImageOptions.LargeImage = CType(resources.GetObject("btn_capnhatthuyetminh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_capnhatthuyetminh.Name = "btn_capnhatthuyetminh"
        '
        'btn_luuthuyetminh
        '
        Me.btn_luuthuyetminh.Caption = "Lưu"
        Me.btn_luuthuyetminh.Id = 17
        Me.btn_luuthuyetminh.ImageOptions.Image = CType(resources.GetObject("btn_luuthuyetminh.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_luuthuyetminh.ImageOptions.LargeImage = CType(resources.GetObject("btn_luuthuyetminh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_luuthuyetminh.Name = "btn_luuthuyetminh"
        '
        'btn_hdsd
        '
        Me.btn_hdsd.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_hdsd.Caption = "Hướng Dẫn"
        Me.btn_hdsd.Id = 18
        Me.btn_hdsd.ImageOptions.Image = CType(resources.GetObject("btn_hdsd.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_hdsd.ImageOptions.LargeImage = CType(resources.GetObject("btn_hdsd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_hdsd.Name = "btn_hdsd"
        '
        'btn_gioithieu
        '
        Me.btn_gioithieu.Caption = "Giới Thiệu"
        Me.btn_gioithieu.Id = 19
        Me.btn_gioithieu.ImageOptions.SvgImage = CType(resources.GetObject("btn_gioithieu.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_gioithieu.Name = "btn_gioithieu"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarButtonItem1.Caption = "Bố Trí Cọc"
        Me.BarButtonItem1.Id = 20
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Kiểm Tra"
        Me.BarButtonItem2.Id = 21
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'btn_thepdai
        '
        Me.btn_thepdai.Caption = "Tính Thép"
        Me.btn_thepdai.Id = 22
        Me.btn_thepdai.ImageOptions.Image = CType(resources.GetObject("btn_thepdai.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_thepdai.ImageOptions.LargeImage = CType(resources.GetObject("btn_thepdai.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_thepdai.Name = "btn_thepdai"
        '
        'btn_vedaimong
        '
        Me.btn_vedaimong.Caption = "Vẽ Đài"
        Me.btn_vedaimong.Id = 23
        Me.btn_vedaimong.ImageOptions.Image = CType(resources.GetObject("btn_vedaimong.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_vedaimong.ImageOptions.LargeImage = CType(resources.GetObject("btn_vedaimong.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_vedaimong.Name = "btn_vedaimong"
        '
        'btn_xuatbanvedaimong
        '
        Me.btn_xuatbanvedaimong.Caption = "Xuất Bản Vẽ"
        Me.btn_xuatbanvedaimong.Id = 24
        Me.btn_xuatbanvedaimong.ImageOptions.Image = CType(resources.GetObject("btn_xuatbanvedaimong.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_xuatbanvedaimong.Name = "btn_xuatbanvedaimong"
        Me.btn_xuatbanvedaimong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_huongdan
        '
        Me.btn_huongdan.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_huongdan.Caption = "Hướng Dẫn"
        Me.btn_huongdan.Id = 25
        Me.btn_huongdan.ImageOptions.Image = CType(resources.GetObject("btn_huongdan.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_huongdan.ImageOptions.LargeImage = CType(resources.GetObject("btn_huongdan.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_huongdan.Name = "btn_huongdan"
        '
        'btn_me
        '
        Me.btn_me.Caption = "Giới Thiệu"
        Me.btn_me.Id = 26
        Me.btn_me.ImageOptions.SvgImage = CType(resources.GetObject("btn_me.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_me.Name = "btn_me"
        '
        'btn_xem_ket_qua_Tinh_Toan
        '
        Me.btn_xem_ket_qua_Tinh_Toan.Caption = "6.Bố Trí Cọc"
        Me.btn_xem_ket_qua_Tinh_Toan.Id = 27
        Me.btn_xem_ket_qua_Tinh_Toan.ImageOptions.Image = Global.ChanputhearaKung.My.Resources.Resources.Group_11
        Me.btn_xem_ket_qua_Tinh_Toan.Name = "btn_xem_ket_qua_Tinh_Toan"
        Me.btn_xem_ket_qua_Tinh_Toan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_gioi_thieu
        '
        Me.btn_gioi_thieu.Caption = "Xuất báo cáo"
        Me.btn_gioi_thieu.Id = 28
        Me.btn_gioi_thieu.ImageOptions.Image = Global.ChanputhearaKung.My.Resources.Resources._12_121390_new_microsoft_word_icon
        Me.btn_gioi_thieu.Name = "btn_gioi_thieu"
        Me.btn_gioi_thieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_Tinh_thep
        '
        Me.btn_Tinh_thep.Caption = "7.Tính Thép Đài"
        Me.btn_Tinh_thep.Id = 29
        Me.btn_Tinh_thep.ImageOptions.Image = Global.ChanputhearaKung.My.Resources.Resources.cothep
        Me.btn_Tinh_thep.Name = "btn_Tinh_thep"
        Me.btn_Tinh_thep.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Bản Vẽ Đài Cọc."
        Me.BarButtonItem4.Id = 30
        Me.BarButtonItem4.ImageOptions.Image = Global.ChanputhearaKung.My.Resources.Resources.A360_Viewer_11
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btn_banve_coc
        '
        Me.btn_banve_coc.Caption = "Bản Vẽ Cọc"
        Me.btn_banve_coc.Id = 31
        Me.btn_banve_coc.ImageOptions.Image = Global.ChanputhearaKung.My.Resources.Resources.A360_Viewer_1
        Me.btn_banve_coc.Name = "btn_banve_coc"
        Me.btn_banve_coc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'rb_nhapdulieu
        '
        Me.rb_nhapdulieu.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup1})
        Me.rb_nhapdulieu.Name = "rb_nhapdulieu"
        Me.rb_nhapdulieu.Text = "Nhập Dữ Liệu"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_diachat)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_vatlieudai)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_dulieudai)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_dulieucoc)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_noiluc)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_xem_ket_qua_Tinh_Toan)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_Tinh_thep)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btn_gioi_thieu)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Phần nhập liệu và tính toán."
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Phần bản Vẽ"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lb_Label)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 158)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1099, 486)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(14, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(428, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Người thực hiện ChanputhearaKung"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Đề tài : Thiết kế móng cọc ép."
        '
        'lb_Label
        '
        Me.lb_Label.AutoSize = True
        Me.lb_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Label.Location = New System.Drawing.Point(12, 16)
        Me.lb_Label.Name = "lb_Label"
        Me.lb_Label.Size = New System.Drawing.Size(387, 47)
        Me.lb_Label.TabIndex = 1
        Me.lb_Label.Text = "Đồ án tốt nghiệp 2022 "
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.ChanputhearaKung.My.Resources.Resources.AnhNen
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1099, 486)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        Me.BarButtonItem3.Caption = "Nội Lực"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'GiaodienChuongTrinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow
        Me.IconOptions.Icon = CType(resources.GetObject("GiaodienChuongTrinh.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.Image = Global.ChanputhearaKung.My.Resources.Resources.winter_100px
        Me.Name = "GiaodienChuongTrinh"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chương Trình Thiết Kế Móng Cọc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents rb_nhapdulieu As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btn_diachat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_vatlieudai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_vatlieucoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_noiluc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_dulieudai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_dulieucoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_soluongcoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_kiemtradai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_tinhthepdai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_vedai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_xuatbanvedai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_kiemtracoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_vecoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_xuatbanvecoc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_capnhatthuyetminh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_luuthuyetminh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_hdsd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_gioithieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_thepdai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_vedaimong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_xuatbanvedaimong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_huongdan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_me As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_xem_ket_qua_Tinh_Toan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_gioi_thieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Tinh_thep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_banve_coc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_Label As Label
End Class
