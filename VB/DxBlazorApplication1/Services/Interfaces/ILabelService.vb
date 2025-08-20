Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DxBlazorApplication1.Services.Interfaces

    Public Interface ILabelService(Of TLabel)

        Public Function GetLabelsAsync() As Task(Of IList(Of TLabel))

    End Interface
End Namespace
