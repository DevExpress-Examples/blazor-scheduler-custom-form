Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Services.Interfaces

    Public Interface IResourceService(Of TResource)

        Public Function GetResourcesAsync() As Task(Of IList(Of TResource))

    End Interface
End Namespace
