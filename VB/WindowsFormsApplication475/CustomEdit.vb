Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication475
	<ToolboxItem(True)> _
	Public Class CustomEdit
		Inherits ColorPickEdit

		'The static constructor that calls the registration method 
		Shared Sub New()
			RepositoryItemCustomEdit.RegisterCustomEdit()
		End Sub

		'Initialize the new instance 
		Public Sub New()
			'... 
		End Sub

		'Return the unique name 
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomEdit.CustomEditName
			End Get
		End Property

		'Override the Properties property 
		'Simply type-cast the object to the custom repository item type 
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomEdit)
			End Get
		End Property

	End Class

End Namespace
