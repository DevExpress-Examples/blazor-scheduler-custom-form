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
    public class InMemoryLabelService : ILabelService<LectureType> {
        private readonly IList<LectureType> lectureTypes;

        public InMemoryLabelService() {
            lectureTypes = LabelDataHelper.GetLabels();
        }
        public Task<IList<LectureType>> GetLabelsAsync() {
            return Task.FromResult(lectureTypes);
        }
    }
}
