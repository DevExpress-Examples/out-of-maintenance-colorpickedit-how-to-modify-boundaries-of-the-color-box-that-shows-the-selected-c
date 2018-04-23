Imports Microsoft.VisualBasic
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication475
	Partial Public Class Form1
		Inherits Form
		Private edit As RepositoryItemCustomEdit
		Public Sub New()
			InitializeComponent()
			edit = New RepositoryItemCustomEdit()
			Dim lst As New List(Of Employee)()
			For i As Integer = 0 To 9
				lst.Add(New Employee() With {.ID = i, .FirstName = "Name " & i, .BirthDate = DateTime.Now, .AtVacation = i Mod 2 = 0, .FavoriteColor = Color.Red})
			Next i
			gridControl1.DataSource = lst
			gridView1.Columns("FavoriteColor").ColumnEdit = edit
		End Sub
	End Class


	Public Class Employee
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateFirstName As String
		Public Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateAtVacation As Boolean
		Public Property AtVacation() As Boolean
			Get
				Return privateAtVacation
			End Get
			Set(ByVal value As Boolean)
				privateAtVacation = value
			End Set
		End Property
		Private privateBirthDate As DateTime
		Public Property BirthDate() As DateTime
			Get
				Return privateBirthDate
			End Get
			Set(ByVal value As DateTime)
				privateBirthDate = value
			End Set
		End Property
		Private privateFavoriteColor As Color
		Public Property FavoriteColor() As Color
			Get
				Return privateFavoriteColor
			End Get
			Set(ByVal value As Color)
				privateFavoriteColor = value
			End Set
		End Property
	End Class

End Namespace
