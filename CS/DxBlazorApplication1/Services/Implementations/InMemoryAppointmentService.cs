using DxBlazorApplication1.Models;
using DxBlazorApplication1.Services.DataHelpers;
using DxBlazorApplication1.Services.Interfaces;

namespace ServiceLayer.Implementations.InMemory {
    public class InMemoryAppointmentService : IAppointmentService<UniversityClass> {
        protected IList<UniversityClass> appointments;

        public InMemoryAppointmentService() {
            appointments = AppointmentDataHelper.GetAppointmentsWithResources();
            appointments = appointments.Concat(AppointmentDataHelper.GetRecurrentAppointments()).ToList();
        }

        public async Task<object> DeleteAppointmentAsync(object aptId) {
            var aptToDelete = appointments.Single(a => a.Id == (int)aptId);
            appointments.Remove(aptToDelete);
            return aptId;
        }

        public async Task<IList<UniversityClass>> GetAppointmentsAsync() {
            return await Task.FromResult(appointments.ToList());
        }

        public async Task<object> InsertAppointmentAsync(UniversityClass apt) {
            var lastApt = appointments.OrderBy(x => x.Id).LastOrDefault();
            apt.Id = lastApt == null ? 0 : lastApt.Id + 1;
            appointments.Add(apt);
            return apt.Id;
        }

        public async Task<object> UpdateAppointmentAsync(UniversityClass apt) {
            var aptToUpdate = appointments.Single(a => a.Id == apt.Id);
            aptToUpdate.Subject = apt.Subject;
            aptToUpdate.Status = apt.Status;
            aptToUpdate.LecturerIds = apt.LecturerIds;
            aptToUpdate.LecturerId = apt.LecturerId;
            aptToUpdate.RecurrenceInfo = apt.RecurrenceInfo;
            aptToUpdate.AllDay = apt.AllDay;
            aptToUpdate.Label = apt.Label;
            aptToUpdate.Description = apt.Description;
            aptToUpdate.StartTime = apt.StartTime;
            aptToUpdate.EndTime = apt.EndTime;
            aptToUpdate.EventType = apt.EventType;
            aptToUpdate.Location = apt.Location;
            aptToUpdate.ReminderInfo = apt.ReminderInfo;
            aptToUpdate.TimeZoneId = apt.TimeZoneId;
            return apt.Id;
        }
    }
}
