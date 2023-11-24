Namespace ColorMappingExample.Model

    Public Class MyAppointment

        Public Sub New(ByVal startTime As Date, ByVal endTime As Date, ByVal subject As String, ByVal priorityId As Priority)
            Me.StartTime = startTime
            Me.EndTime = endTime
            Me.Subject = subject
            Me.PriorityId = priorityId
        End Sub

        Protected Sub New()
        End Sub

        Public Overridable Property Id As Integer

        Public Overridable Property AllDay As Boolean

        Public Overridable Property StartTime As Date

        Public Overridable Property EndTime As Date

        Public Overridable Property Subject As String

        Public Overridable Property StatusId As Integer

        Public Overridable Property PriorityId As Priority

        Public Overridable Property Type As Integer

        Public Overridable Property Location As String

        Public Overridable Property RecurrenceInfo As String

        Public Overridable Property ReminderInfo As String
    End Class
End Namespace
