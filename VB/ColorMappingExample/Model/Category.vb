Imports DevExpress.Mvvm.POCO

Namespace ColorMappingExample.Model
    Public Class Category
        Private _colorData As Object

        Protected Sub New(ByVal id As Integer, ByVal caption As String, ByVal color As Object)
            Me.Id = id
            Me.Caption = caption
            ColorData = color
        End Sub
        Public Shared Function Create(ByVal id As Integer, ByVal caption As String, ByVal color As Object) As Category
            Return ViewModelSource.Create(Function() New Category(id, caption, color))
        End Function

        Protected Sub New()
        End Sub

        Public Overridable Property Id() As Integer
        Public Overridable Property Caption() As String
        Public Overridable Property ColorData() As Object
            Get
                Return _colorData
            End Get
            Set(ByVal value As Object)
                _colorData = value
                ColorDataInfo = "Saved as " & value.GetType().ToString() & " value= " & value.ToString()
            End Set
        End Property
        Public Overridable Property ColorDataInfo() As String
    End Class
End Namespace
