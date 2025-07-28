Imports DevExpress.Blazor
Imports System.Diagnostics

Namespace DxBlazorApplication1.Models.UIModels

    Public Class CustomAppointmentFormInfo
        Inherits SchedulerAppointmentFormInfo

        Public Sub New(ByVal AppointmentItem As DxSchedulerAppointmentItem, ByVal DataStorage As DxSchedulerDataStorage, ByVal scheduler As DxScheduler)
            MyBase.New(AppointmentItem, DataStorage, scheduler)
        End Sub

        Public Property Grade As String?
            Get
                Return CustomFields("Grade")?.ToString()
            End Get

            Set(ByVal value As String?)
                CustomFields("Grade") = value
            End Set
        End Property
    End Class
End Namespace
