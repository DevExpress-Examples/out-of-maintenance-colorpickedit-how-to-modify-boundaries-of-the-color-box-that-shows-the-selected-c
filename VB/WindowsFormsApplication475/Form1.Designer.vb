Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication475
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
			Me.colorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
			Me.customEdit1 = New WindowsFormsApplication475.CustomEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.colorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colorPickEdit1
			' 
			Me.colorPickEdit1.EditValue = System.Drawing.Color.Empty
			Me.colorPickEdit1.Location = New System.Drawing.Point(24, 12)
			Me.colorPickEdit1.Name = "colorPickEdit1"
			Me.colorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorPickEdit1.Size = New System.Drawing.Size(100, 20)
			Me.colorPickEdit1.TabIndex = 0
			' 
			' customEdit1
			' 
			Me.customEdit1.EditValue = System.Drawing.Color.Empty
			Me.customEdit1.Location = New System.Drawing.Point(24, 52)
			Me.customEdit1.Name = "customEdit1"
			Me.customEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.customEdit1.Properties.UseDefaultMode = True
			Me.customEdit1.Size = New System.Drawing.Size(100, 20)
			Me.customEdit1.TabIndex = 1
			' 
			' gridControl1
			' 
			Me.gridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.gridControl1.Location = New System.Drawing.Point(57, 110)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(640, 245)
			Me.gridControl1.TabIndex = 2
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(786, 413)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.customEdit1)
			Me.Controls.Add(Me.colorPickEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.colorPickEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private colorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit
		Private customEdit1 As CustomEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace

