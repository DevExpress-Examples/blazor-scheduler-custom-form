Imports DxBlazorApplication1.Models
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.Json
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Services.DataHelpers

    Public Class StatusDataHelper

        Public Shared Function GetStatuses() As List(Of LectureStatus)
            Return lectureStatuses
        End Function

        Private Shared ReadOnly lectureStatuses As List(Of LectureStatus) = New List(Of LectureStatus)() From {New(_, _) With {.Id = 1, .Name = "Scheduled", .Color = Color.MistyRose, .CssClass = "status-1"}, New(_, _) With {.Id = 2, .Name = "Ongoing", .Color = Color.LightYellow, .CssClass = "status-2"}, New(_, _) With {.Id = 3, .Name = "Canceled", .Color = Color.Red, .CssClass = "status-3"}, New(_, _) With {.Id = 4, .Name = "Complete", .Color = Color.LimeGreen, .CssClass = "status-4"}}
    End Class
End Namespace
