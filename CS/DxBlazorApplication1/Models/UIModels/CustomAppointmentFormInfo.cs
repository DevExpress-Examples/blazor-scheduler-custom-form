using DevExpress.Blazor;
using System.Diagnostics;

namespace DxBlazorApplication1.Models.UIModels
{
    public class CustomAppointmentFormInfo : SchedulerAppointmentFormInfo {
        public CustomAppointmentFormInfo(DxSchedulerAppointmentItem AppointmentItem,
                DxSchedulerDataStorage DataStorage, DxScheduler scheduler) : base(AppointmentItem, DataStorage, scheduler) { }

        public string? DegreeLevel {
            get { return CustomFields["DegreeLevel"]?.ToString(); }
            set { CustomFields["DegreeLevel"] = value; }
        }
    }
}
