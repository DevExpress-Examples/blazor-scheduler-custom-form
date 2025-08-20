Imports DxBlazorApplication1.Models
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.Json
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Services.DataHelpers

    Public Class ResourceDataHelper

        Public Shared Function GetResources() As List(Of Lecturer)
            Return lecturers
        End Function

        Private Shared ReadOnly lecturers As List(Of Lecturer) = New List(Of Lecturer) From {New(_, _) With {.Id = 1, .Name = "Jack Brown", .Color = Color.LightPink, .BackgroundCssClass = "lecturer-1", .TextCssClass = "lecturer-1-text"}, New(_, _) With {.Id = 2, .Name = "Robert Porter", .Color = Color.LightSteelBlue, .BackgroundCssClass = "lecturer-2", .TextCssClass = "lecturer-2-text"}, New(_, _) With {.Id = 3, .Name = "Maria Gonzales", .Color = Color.LemonChiffon, .BackgroundCssClass = "lecturer-3", .TextCssClass = "lecturer-3-text"}, New(_, _) With {.Id = 4, .Name = "Patrick Green", .Color = Color.Lavender, .BackgroundCssClass = "lecturer-4", .TextCssClass = "lecturer-4-text"}}
    End Class
End Namespace
