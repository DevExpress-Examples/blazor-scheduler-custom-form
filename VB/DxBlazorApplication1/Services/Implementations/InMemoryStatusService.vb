Imports DxBlazorApplication1.Models
Imports DxBlazorApplication1.Services.DataHelpers
Imports DxBlazorApplication1.Services.Interfaces
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ServiceLayer.Implementations.InMemory

    Public Class InMemoryStatusService
        Implements IStatusService(Of LectureStatus)

        Private ReadOnly statuses As IList(Of LectureStatus)

        Public Sub New()
            statuses = StatusDataHelper.GetStatuses()
        End Sub

        Public Function GetStatusesAsync() As Task(Of IList(Of LectureStatus)) Implements IStatusService(Of LectureStatus).GetStatusesAsync
            Return Task.FromResult(statuses)
        End Function
    End Class
End Namespace
