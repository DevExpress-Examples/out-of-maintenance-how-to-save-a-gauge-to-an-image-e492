Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication7
	Partial Public Class Form1
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
			Me.gControl = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.imgEdit = New DevExpress.XtraEditors.PictureEdit()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imgEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gControl.Gauges.AddRange(New DevExpress.XtraGauges.Win.Base.GaugeBase() { Me.circularGauge1})
			Me.gControl.Location = New System.Drawing.Point(12, 12)
			Me.gControl.Name = "gaugeControl1"
			Me.gControl.Size = New System.Drawing.Size(260, 260)
			Me.gControl.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 248)
			Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() { Me.arcScaleEffectLayerComponent1})
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1})
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 60F
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_2
			Me.arcScaleComponent1.MajorTickmark.TextOffset = 22F
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 100F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style7_1
			Me.arcScaleComponent1.Name = "arcScaleComponent3"
			Me.arcScaleComponent1.RadiusX = 83F
			Me.arcScaleComponent1.RadiusY = 83F
			Me.arcScaleComponent1.StartAngle = -240F
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent3"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style7
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = -25F
			Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent3"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style7
			Me.arcScaleNeedleComponent1.StartOffset = -21F
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' arcScaleEffectLayerComponent1
			' 
			Me.arcScaleEffectLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent2"
			Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1.06F)
			Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Style7
			Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(235F, 110F)
			Me.arcScaleEffectLayerComponent1.ZOrder = -1000
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(288, 120)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(32, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = ">>"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnGetImageBtnClick);
			' 
			' pictureEdit1
			' 
			Me.imgEdit.Location = New System.Drawing.Point(337, 12)
			Me.imgEdit.Name = "pictureEdit1"
			Me.imgEdit.Size = New System.Drawing.Size(260, 260)
			Me.imgEdit.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(612, 284)
			Me.Controls.Add(Me.imgEdit)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.gControl)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imgEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gControl As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private imgEdit As DevExpress.XtraEditors.PictureEdit

	End Class
End Namespace

