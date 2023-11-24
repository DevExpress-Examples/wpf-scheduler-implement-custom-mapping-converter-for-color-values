Imports ColorMappingExample.Model
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel
Imports System.Windows.Media

Namespace ColorMappingExample.ViewModels

    <POCOViewModel>
    Public Class MainViewModel

        Public Overridable Property Appointments As ObservableCollection(Of MyAppointment)

        Public Overridable Property Categories As ObservableCollection(Of Category)

        Public Overridable Property ColorSavingType As DevExpress.Xpf.Scheduling.DXColorSavingType

        Protected Sub New()
            Appointments = CreateAppointments()
            Categories = CreateCategories()
        End Sub

        Private Function CreateAppointments() As ObservableCollection(Of MyAppointment)
            Dim result As ObservableCollection(Of MyAppointment) = New ObservableCollection(Of MyAppointment)()
            result.Add(MyAppointment.Create(Date.Today.AddHours(10), Date.Today.AddHours(11), "TEST", 1))
            Return result
        End Function

#Region "#CreateCategories"
        Private Function CreateCategories() As ObservableCollection(Of Category)
            Dim result As ObservableCollection(Of Category) = New ObservableCollection(Of Category)()
            result.Add(Category.Create(0, "Blank category", "0xFFFFFFFF"))
            ' Set the AppointmentLabelMappings.ColorSavingType to ColorString
            ' and use the HtmlColorCodeToHexConverter.
            ' Otherwise color values assigned as follows will be translated incorrectly.
            result.Add(Category.Create(1, "Color category", Colors.Orange.ToString()))
            result.Add(Category.Create(2, "Red category", "Red"))
            ''' Set the AppointmentLabelMappings.ColorSavingType to ColorInstance.
            ''' Otherwise color values assigned as follows will be translated incorrectly.
            'result.Add(Category.Create(1, "Color category", Colors.Orange));
            'result.Add(Category.Create(3, "Red category", Colors.Red));
            Return result
        End Function
#End Region  ' #CreateCategories
    End Class
End Namespace
