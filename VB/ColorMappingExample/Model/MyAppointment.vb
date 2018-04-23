Imports DevExpress.Mvvm.POCO
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ColorMappingExample.Model
    Public Class MyAppointment
        Public Shared Function Create() As MyAppointment
            Return ViewModelSource.Create(Function() New MyAppointment())
        End Function
        Friend Shared Function Create(ByVal startTime As Date, ByVal endTime As Date, ByVal subject As String, ByVal categoryId As Integer) As MyAppointment
            Dim apt As MyAppointment = MyAppointment.Create()
            apt.StartTime = startTime
            apt.EndTime = endTime
            apt.Subject = subject
            apt.CategoryId = categoryId
            Return apt
        End Function

        Protected Sub New()
        End Sub
        Public Overridable Property Id() As Integer
        Public Overridable Property AllDay() As Boolean
        Public Overridable Property StartTime() As Date
        Public Overridable Property EndTime() As Date
        Public Overridable Property Subject() As String
        Public Overridable Property StatusId() As Integer
        Public Overridable Property CategoryId() As Integer
        Public Overridable Property Type() As Integer
        Public Overridable Property Location() As String
        Public Overridable Property RecurrenceInfo() As String
        Public Overridable Property ReminderInfo() As String
    End Class
End Namespace
