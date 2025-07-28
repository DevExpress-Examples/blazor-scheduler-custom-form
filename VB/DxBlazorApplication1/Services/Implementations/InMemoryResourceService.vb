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

    Public Class InMemoryResourceService
        Implements IResourceService(Of Lecturer)

        Private ReadOnly resources As IList(Of Lecturer)

        Public Sub New()
            resources = ResourceDataHelper.GetResources()
        End Sub

        Public Function GetResourcesAsync() As Task(Of IList(Of Lecturer)) Implements IResourceService(Of Lecturer).GetResourcesAsync
            Return Task.FromResult(resources)
        End Function
    End Class
End Namespace
