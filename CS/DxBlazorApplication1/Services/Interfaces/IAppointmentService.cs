using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Services.Interfaces {
    public interface IAppointmentService<TAppointment> {
        public Task<IList<TAppointment>> GetAppointmentsAsync();
        public Task<object> InsertAppointmentAsync(TAppointment apt);
        public Task<object> UpdateAppointmentAsync(TAppointment apt);
        public Task<object> DeleteAppointmentAsync(object aptId);
    }
}
