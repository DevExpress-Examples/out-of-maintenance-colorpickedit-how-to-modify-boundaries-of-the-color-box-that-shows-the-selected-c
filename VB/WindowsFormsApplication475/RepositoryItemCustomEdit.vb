Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text

Namespace WindowsFormsApplication475
	<UserRepositoryItem("RegisterCustomEdit")> _
	Public Class RepositoryItemCustomEdit
		Inherits RepositoryItemColorPickEdit

		'The static constructor that calls the registration method 
		Shared Sub New()
			RegisterCustomEdit()
		End Sub

		'Initialize new properties 
		Public Sub New()
			useDefaultMode_Renamed = True
		End Sub

		'The unique name for the custom editor 
		Public Const CustomEditName As String = "CustomEdit"

		'Return the unique name 
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property

		'Register the editor 
		Public Shared Sub RegisterCustomEdit()
			'Icon representing the editor within a container editor's Designer 
			Dim img As Image = Nothing
			Try
				img = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly(). GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp")), Bitmap)
			Catch
			End Try
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomEdit), GetType(RepositoryItemCustomEdit), GetType(ColorEditViewInfo), New ColorEditPainter(), True, img))
		End Sub

		'A custom property 
		Private useDefaultMode_Renamed As Boolean

		Public Property UseDefaultMode() As Boolean
			Get
				Return useDefaultMode_Renamed
			End Get
			Set(ByVal value As Boolean)
				If useDefaultMode_Renamed <> value Then
					useDefaultMode_Renamed = value
					OnPropertiesChanged()
				End If
			End Set
		End Property

		'Override the Assign method 
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemCustomEdit = TryCast(item, RepositoryItemCustomEdit)
				If source Is Nothing Then
					Return
				End If
				useDefaultMode_Renamed = source.UseDefaultMode
			Finally
				EndUpdate()
			End Try
		End Sub
		Public Overrides Function CreateViewInfo() As BaseEditViewInfo
			Return New MyColorEditViewInfo(Me)
		End Function
	End Class


End Namespace
