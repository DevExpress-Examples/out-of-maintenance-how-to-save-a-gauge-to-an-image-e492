Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Win.Base
Imports System.IO
Imports System.Drawing.Imaging

Namespace WindowsApplication7
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnGetImageBtnClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim w As Integer = gControl.Width
			Dim h As Integer = gControl.Height
			Dim stream As New MemoryStream()
			gControl.ExportToImage(stream, ImageFormat.Png)
			imgEdit.Image = Image.FromStream(stream)
		End Sub
	End Class
End Namespace