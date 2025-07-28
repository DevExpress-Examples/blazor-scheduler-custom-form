Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Services.Interfaces

    Public Interface IStatusService(Of TStatus)

        Public Function GetStatusesAsync() As Task(Of IList(Of TStatus))

    End Interface
End Namespace
