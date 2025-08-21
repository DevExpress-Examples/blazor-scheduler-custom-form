using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Services.Interfaces {
    public interface IStatusService<TStatus> {
        public Task<IList<TStatus>> GetStatusesAsync();
    }
}
