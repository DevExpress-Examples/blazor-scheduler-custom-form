Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports System.Text
Imports System.Text.Json.Serialization
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Models

    Public Class UniversityClass

        Public Property Id As Integer

        Public Property LecturerId As Integer?

        Public Property LecturerIds As String?

        Public Property Status As Integer

        Public Property Subject As String?

        Public Property Description As String?

        Public Property Label As Integer

        Public Property StartTime As DateTime

        Public Property EndTime As DateTime

        Public Property Location As String?

        Public Property AllDay As Boolean

        Public Property EventType As Integer

        Public Property RecurrenceInfo As String?

        Public Property ReminderInfo As String?

        Public Property TimeZoneId As String?

        Public Property Grade As String?
    End Class
End Namespace
