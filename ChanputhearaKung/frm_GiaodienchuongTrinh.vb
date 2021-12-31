Imports System.ComponentModel
Imports System.Text


Partial Public Class GiaodienChuongTrinh
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    ' hàm hiển thị frm ở trên panel, truyền vào 1 form
    Private Sub OpenForm(childForm As Form)
        'Dim activeForm As Form
        'If activeForm IsNot Nothing Then activeForm.Close()
        'activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.Panel1.Controls.Add(childForm)
        Me.Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btn_diachat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_diachat.ItemClick
        frm_thongtindiachat.ShowDialog()
    End Sub



    Private Sub btn_vatlieucoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_vatlieucoc.ItemClick
        frm_thongtinvatlieu.ShowDialog()
    End Sub

    Private Sub btn_noiluc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_noiluc.ItemClick
        frm_thongtinnoiluc.ShowDialog()
    End Sub

    Private Sub btn_dulieudai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_dulieudai.ItemClick
        frm_thongtindai.ShowDialog()
    End Sub

    Private Sub btn_dulieucoc_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_dulieucoc.ItemClick
        frm_thongtincoc.ShowDialog()
    End Sub

    Private Sub frm_chinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btn_me_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_me.ItemClick

    End Sub





    Private Sub btn_xem_ket_qua_Tinh_Toan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_xem_ket_qua_Tinh_Toan.ItemClick

    End Sub

    Private Sub btn_Tinh_thep_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Tinh_thep.ItemClick
        frm_TinhThep.ShowDialog()

    End Sub

    Private Sub btn_vatlieudai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_vatlieudai.ItemClick
        frm_thongtinvatlieu.ShowDialog()
    End Sub
End Class
