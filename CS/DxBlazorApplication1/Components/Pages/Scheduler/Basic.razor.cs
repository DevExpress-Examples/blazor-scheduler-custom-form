using DevExpress.Blazor;
using DxBlazorApplication1.Models;
using DxBlazorApplication1.Services;
using DxBlazorApplication1.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace DxBlazorApplication1.Components.Pages.Scheduler
{
    public partial class Basic : ComponentBase
    {
        #region Dependencies
        [Inject]
        private IAppointmentService<UniversityClass> AptService { get; set; }
        [Inject]
        private IResourceService<Lecturer> ResService { get; set; }
        [Inject]
        private ILabelService<LectureType> LblService { get; set; }
        [Inject]
        private IStatusService<LectureStatus> StsService { get; set; }
        #endregion

        #region Properties
        private DateTime StartDate { get; set; } = new DateTime(2025, 6, 1);
        private TimeZoneInfo SelectedTimeZone { get; set; } = TimeZoneInfo.Utc;

        private DxSchedulerDataStorage Storage { get; set; } = new DxSchedulerDataStorage()
        {
            AppointmentMappings = new DxSchedulerAppointmentMappings()
            {
                Id = "Id",
                Type = "EventType",
                Start = "StartTime",
                End = "EndTime",
                Subject = "Subject",
                AllDay = "AllDay",
                Location = "Location",
                Description = "Description",
                LabelId = "Label",
                StatusId = "Status",
                RecurrenceInfo = "RecurrenceInfo",
                ResourceId = "LecturerIds",
                TimeZoneId = "TimeZoneId"
            },
            ResourceMappings = new DxSchedulerResourceMappings()
            {
                Id = "Id",
                Caption = "Name",
                Color = "Color",
                BackgroundCssClass = "BackgroundCssClass",
                TextCssClass = "TextCssClass"
            },
            AppointmentLabelMappings = new DxSchedulerAppointmentLabelMappings()
            {
                Id = "Id",
                Caption = "Name",
                Color = "Color",
                TextCssClass = "TextCssClass",
                BackgroundCssClass = "BackgroundCssClass"
            },
            AppointmentStatusMappings = new DxSchedulerAppointmentStatusMappings()
            {
                Id = "Id",
                Caption = "Name",
                Color = "Color",
                CssClass = "CssClass",
            },
            EnableMultipleResources = true,
        };
        #endregion

        #region Life-cycle Methods
        protected override async Task OnInitializedAsync()
        {
            Storage.TimeZone = SelectedTimeZone;
            Storage.AppointmentsSource = await AptService.GetAppointmentsAsync();
            Storage.ResourcesSource = await ResService.GetResourcesAsync();
            Storage.AppointmentLabelsSource = await LblService.GetLabelsAsync();
            Storage.AppointmentStatusSource = await StsService.GetStatusesAsync();
        }
        #endregion

        #region Event Handlers
        private async Task OnAppointmentInserted(DxSchedulerAppointmentItem e)
        {
            if (e.SourceObject is UniversityClass uc)
            {
                await AptService.InsertAppointmentAsync(uc);
                Storage.RefreshData();
            }
        }

        private async Task OnAppointmentUpdated(DxSchedulerAppointmentItem e)
        {
            if (e.SourceObject is UniversityClass uc)
            {
                await AptService.UpdateAppointmentAsync(uc);
                Storage.RefreshData();
            }
        }

        private async Task OnAppointmentRemoved(DxSchedulerAppointmentItem e)
        {
            await AptService.DeleteAppointmentAsync((int)e.Id);
            Storage.RefreshData();
        }
        #endregion
    }
}
