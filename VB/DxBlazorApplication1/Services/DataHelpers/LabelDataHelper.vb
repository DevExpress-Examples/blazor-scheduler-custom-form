Imports DxBlazorApplication1.Models
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.Json
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Services.DataHelpers

    Public Class LabelDataHelper

        Public Shared Function GetLabels() As List(Of LectureType)
            Return lectureTypes
        End Function

        Private Shared ReadOnly lectureTypes As List(Of LectureType) = New List(Of LectureType)() From {New(_, _) With {.Id = 1, .Name = "Lecture", .Color = Color.Coral, .BackgroundCssClass = "label-1", .TextCssClass = "label-1"}, New(_, _) With {.Id = 2, .Name = "Seminar", .Color = Color.ForestGreen, .BackgroundCssClass = "label-2", .TextCssClass = "label-2"}, New(_, _) With {.Id = 3, .Name = "Laboratory", .Color = Color.LightSkyBlue, .BackgroundCssClass = "label-3", .TextCssClass = "label-3"}}
    End Class
End Namespace
