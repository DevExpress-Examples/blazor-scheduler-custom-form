Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Services.Interfaces

    Public Interface IAppointmentService(Of TAppointment)

        Public Function GetAppointmentsAsync() As Task(Of IList(Of TAppointment))

        Public Function InsertAppointmentAsync(ByVal apt As TAppointment) As Task(Of Object)

        Public Function UpdateAppointmentAsync(ByVal apt As TAppointment) As Task(Of Object)

        Public Function DeleteAppointmentAsync(ByVal aptId As Object) As Task(Of Object)

    End Interface
End Namespace
