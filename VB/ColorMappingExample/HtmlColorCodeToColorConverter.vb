Imports System
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace ColorMappingExample
    #Region "#HtmlColorCodeToHexConverter"
    Friend Class HtmlColorCodeToHexConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If (value.GetType() Is GetType(String)) AndAlso value.ToString().StartsWith("#") Then
                Return String.Concat("0x", value.ToString().Remove(0,1))
            Else
                Return value
            End If
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            If (value.GetType() Is GetType(String)) AndAlso value.ToString().StartsWith("0x") Then
                Return String.Concat("#", value.ToString().Remove(0, 2))
            Else
                Return value
            End If
        End Function
        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
    #End Region ' #HtmlColorCodeToHexConverter
End Namespace
