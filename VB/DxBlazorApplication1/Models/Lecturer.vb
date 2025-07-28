Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Text.Json.Serialization
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Models

    Public Class Lecturer

        Public Property Id As Integer

        Public Property Name As String?

        Public Property Color As Color

        Public Property BackgroundCssClass As String?

        Public Property TextCssClass As String?
    End Class
End Namespace
