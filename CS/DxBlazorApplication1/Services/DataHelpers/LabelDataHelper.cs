using DxBlazorApplication1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Services.DataHelpers {
    public class LabelDataHelper {
        public static List<LectureType> GetLabels() => lectureTypes;

        private static readonly List<LectureType> lectureTypes = new List<LectureType>() {
            new(){ Id = 1, Name = "Lecture", Color = Color.Coral, BackgroundCssClass = "label-1", TextCssClass = "label-1" },
            new(){ Id = 2, Name = "Seminar", Color = Color.ForestGreen, BackgroundCssClass = "label-2", TextCssClass = "label-2" },
            new(){ Id = 3, Name = "Laboratory", Color = Color.LightSkyBlue, BackgroundCssClass = "label-3", TextCssClass = "label-3" },
        };
    }
}
