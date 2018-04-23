Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication475
	Public Class MyColorEditViewInfo
		Inherits ColorEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)

		End Sub
Protected Overrides Sub CalcColorBoxRect()
	fColorTextRect = MaskBoxRect
	If Item.ColorAlignment = HorzAlignment.Default Then
		Return
	End If
	fColorBoxRect = Rectangle.Inflate(MaskBoxRect, 0, 0)
	fColorBoxRect.Width = MaskBoxRect.Width
	fColorBoxRect.Height = MaskBoxRect.Height
	If Item.ColorAlignment = HorzAlignment.Far Then
		fColorBoxRect.X = MaskBoxRect.Right - ColorIndent - fColorBoxRect.Width
	End If
	If Item.ColorAlignment = HorzAlignment.Center Then
		fColorBoxRect.X = MaskBoxRect.Left + (MaskBoxRect.Width - fColorBoxRect.Width) / 2
	End If
	'base.CalcColorBoxRect();
End Sub
	End Class

End Namespace
