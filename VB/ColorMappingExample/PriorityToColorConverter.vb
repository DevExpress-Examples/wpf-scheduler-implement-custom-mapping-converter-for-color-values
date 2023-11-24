Imports System
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Media

Namespace ColorMappingExample

    Friend Class PriorityToColorConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim val As Priority = Nothing
            If CSharpImpl.__Assign(val, TryCast(value, Priority)) IsNot Nothing Then
                Select Case val
                    Case Priority.High
                        Return Colors.Red
                    Case Priority.Normal
                        Return Colors.Yellow
                    Case Priority.Low
                        Return Colors.Green
                    Case Else
                        Return Colors.Black
                End Select
            End If

            Return Colors.Transparent
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
