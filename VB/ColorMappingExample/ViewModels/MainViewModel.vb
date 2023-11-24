Imports ColorMappingExample.Model
Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace ColorMappingExample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Appointments As ObservableCollection(Of MyAppointment)

        Public Sub New()
            Appointments = CreateAppointments()
        End Sub

        Private Function CreateAppointments() As ObservableCollection(Of MyAppointment)
            Dim result As ObservableCollection(Of MyAppointment) = New ObservableCollection(Of MyAppointment) From {New MyAppointment(Date.Today.AddHours(10), Date.Today.AddHours(11), "TEST", Priority.Normal)}
            Return result
        End Function
    End Class
End Namespace
