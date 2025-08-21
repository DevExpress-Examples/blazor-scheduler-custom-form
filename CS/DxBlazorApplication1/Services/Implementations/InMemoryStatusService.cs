using DxBlazorApplication1.Models;
using DxBlazorApplication1.Services.DataHelpers;
using DxBlazorApplication1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Implementations.InMemory {
    public class InMemoryStatusService : IStatusService<LectureStatus> {
        private readonly IList<LectureStatus> statuses;

        public InMemoryStatusService() {
            statuses = StatusDataHelper.GetStatuses();
        }
        public Task<IList<LectureStatus>> GetStatusesAsync() {
            return Task.FromResult(statuses);
        }
    }
}
