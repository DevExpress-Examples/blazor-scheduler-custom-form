Imports DevExpress.Blazor
Imports DxBlazorApplication1.Models
Imports DxBlazorApplication1.Models.UIModels
Imports DxBlazorApplication1.Services.Interfaces
Imports Microsoft.AspNetCore.Components
Imports System.Diagnostics

Namespace DxBlazorApplication1.Components.Pages.Scheduler

    Public Partial Class CustomForm
        Inherits ComponentBase

#Region "Dependencies"
        <Inject>
        Private Property AptService As IAppointmentService(Of UniversityClass)

        <Inject>
        Private Property ResService As IResourceService(Of Lecturer)

        <Inject>
        Private Property LblService As ILabelService(Of LectureType)

        <Inject>
        Private Property StsService As IStatusService(Of LectureStatus)

#End Region
#Region "Properties"
        Private Property Scheduler As DxScheduler

        Private Property StartDate As DateTime = New DateTime(2025, 6, 1)

        Private Property SelectedTimeZone As TimeZoneInfo = TimeZoneInfo.Utc

        Private Property Storage As DxSchedulerDataStorage = New DxSchedulerDataStorage() With {.AppointmentMappings = New DxSchedulerAppointmentMappings() With {.Id = "Id", .Type = "EventType", .Start = "StartTime", .[End] = "EndTime", .Subject = "Subject", .AllDay = "AllDay", .Location = "Location", .Description = "Description", .LabelId = "Label", .StatusId = "Status", .RecurrenceInfo = "RecurrenceInfo", .ResourceId = "LecturerIds", .TimeZoneId = "TimeZoneId", .CustomFieldMappings = New List(Of DxSchedulerCustomFieldMapping) From {New DxSchedulerCustomFieldMapping With {.Name = "Grade", .Mapping = "Grade"}}}, .ResourceMappings = New DxSchedulerResourceMappings() With {.Id = "Id", .Caption = "Name", .Color = "Color", .BackgroundCssClass = "BackgroundCssClass", .TextCssClass = "TextCssClass"}, .AppointmentLabelMappings = New DxSchedulerAppointmentLabelMappings() With {.Id = "Id", .Caption = "Name", .Color = "Color", .TextCssClass = "TextCssClass", .BackgroundCssClass = "BackgroundCssClass"}, .AppointmentStatusMappings = New DxSchedulerAppointmentStatusMappings() With {.Id = "Id", .Caption = "Name", .Color = "Color", .CssClass = "CssClass"}, .EnableMultipleResources = True}

#End Region
#Region "Life-cycle Methods"
        Protected Overrides Async Function OnInitializedAsync() As Task
            Storage.TimeZone = SelectedTimeZone
            Storage.AppointmentsSource = Await AptService.GetAppointmentsAsync()
            Storage.ResourcesSource = Await ResService.GetResourcesAsync()
            Storage.AppointmentLabelsSource = Await LblService.GetLabelsAsync()
            Storage.AppointmentStatusSource = Await StsService.GetStatusesAsync()
        End Function

#End Region
#Region "Event Handlers"
        Private Sub OnAppointmentFormShowing(ByVal args As SchedulerAppointmentFormEventArgs)
            args.FormInfo = New CustomAppointmentFormInfo(args.Appointment, Storage, Scheduler)
        End Sub

        Private Async Function OnAppointmentInserted(ByVal e As DxSchedulerAppointmentItem) As Task
            Dim uc As UniversityClass = Nothing
            If CSharpImpl.__Assign(uc, TryCast(e.SourceObject, UniversityClass)) IsNot Nothing Then
                Await AptService.InsertAppointmentAsync(uc)
                Storage.RefreshData()
            End If
        End Function

        Private Async Function OnAppointmentUpdated(ByVal e As DxSchedulerAppointmentItem) As Task
            Dim uc As UniversityClass = Nothing
            If CSharpImpl.__Assign(uc, TryCast(e.SourceObject, UniversityClass)) IsNot Nothing Then
                Await AptService.UpdateAppointmentAsync(uc)
                Storage.RefreshData()
            End If
        End Function

        Private Async Function OnAppointmentRemoved(ByVal e As DxSchedulerAppointmentItem) As Task
            Await AptService.DeleteAppointmentAsync(CInt(e.Id))
            Storage.RefreshData()
        End Function

        Private Class CSharpImpl

            <System.Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
#End Region
    End Class
End Namespace
