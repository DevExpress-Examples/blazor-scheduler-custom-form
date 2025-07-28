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

    Public Class InMemoryLabelService
        Implements ILabelService(Of LectureType)

        Private ReadOnly lectureTypes As IList(Of LectureType)

        Public Sub New()
            lectureTypes = LabelDataHelper.GetLabels()
        End Sub

        Public Function GetLabelsAsync() As Task(Of IList(Of LectureType)) Implements ILabelService(Of LectureType).GetLabelsAsync
            Return Task.FromResult(lectureTypes)
        End Function
    End Class
End Namespace
