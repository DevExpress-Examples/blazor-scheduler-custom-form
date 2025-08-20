Imports DxBlazorApplication1.Models
Imports DxBlazorApplication1.Services.DataHelpers
Imports DxBlazorApplication1.Services.Interfaces

Namespace ServiceLayer.Implementations.InMemory

    Public Class InMemoryAppointmentService
        Implements IAppointmentService(Of UniversityClass)

        Protected appointments As IList(Of UniversityClass)

        Public Sub New()
            appointments = AppointmentDataHelper.GetAppointmentsWithResources()
            appointments = appointments.Concat(AppointmentDataHelper.GetRecurrentAppointments()).ToList()
        End Sub

        Public Async Function DeleteAppointmentAsync(ByVal aptId As Object) As Task(Of Object) Implements IAppointmentService(Of UniversityClass).DeleteAppointmentAsync
            Dim aptToDelete = appointments.[Single](Function(a) a.Id Is CInt(aptId))
            appointments.Remove(aptToDelete)
            Return aptId
        End Function

        Public Async Function GetAppointmentsAsync() As Task(Of IList(Of UniversityClass)) Implements IAppointmentService(Of UniversityClass).GetAppointmentsAsync
            Return Await Task.FromResult(appointments.ToList())
        End Function

        Public Async Function InsertAppointmentAsync(ByVal apt As UniversityClass) As Task(Of Object) Implements IAppointmentService(Of UniversityClass).InsertAppointmentAsync
            Dim lastApt = appointments.OrderBy(Function(x) x.Id).LastOrDefault()
            apt.Id = If(lastApt Is Nothing, 0, lastApt.Id + 1)
            appointments.Add(apt)
            Return apt.Id
        End Function

        Public Async Function UpdateAppointmentAsync(ByVal apt As UniversityClass) As Task(Of Object) Implements IAppointmentService(Of UniversityClass).UpdateAppointmentAsync
            Dim aptToUpdate = appointments.Single(Function(a) a.Id Is apt.Id)
            aptToUpdate.Subject = apt.Subject
            aptToUpdate.Status = apt.Status
            aptToUpdate.LecturerIds = apt.LecturerIds
            aptToUpdate.LecturerId = apt.LecturerId
            aptToUpdate.RecurrenceInfo = apt.RecurrenceInfo
            aptToUpdate.AllDay = apt.AllDay
            aptToUpdate.Label = apt.Label
            aptToUpdate.Description = apt.Description
            aptToUpdate.StartTime = apt.StartTime
            aptToUpdate.EndTime = apt.EndTime
            aptToUpdate.EventType = apt.EventType
            aptToUpdate.Location = apt.Location
            aptToUpdate.ReminderInfo = apt.ReminderInfo
            aptToUpdate.TimeZoneId = apt.TimeZoneId
            Return apt.Id
        End Function
    End Class
End Namespace
