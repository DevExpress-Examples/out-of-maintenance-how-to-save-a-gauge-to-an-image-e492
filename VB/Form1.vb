Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Win.Base

Namespace WindowsApplication7
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub OnGetImageBtnClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim w As Integer = gControl.Width
			Dim h As Integer = gControl.Height
			imgEdit.Image = (TryCast(gControl, IGaugeContainer)).GetImage(w, h)
		End Sub
	End Class
End Namespace