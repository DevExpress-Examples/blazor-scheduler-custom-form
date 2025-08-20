using DxBlazorApplication1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Services.DataHelpers {
    public class StatusDataHelper {
        public static List<LectureStatus> GetStatuses() => lectureStatuses;

        private static readonly List<LectureStatus> lectureStatuses = new List<LectureStatus>() {
            new() { Id = 1 , Name = "Scheduled", Color = Color.MistyRose, CssClass = "status-1" },
            new() { Id = 2 , Name = "Ongoing", Color = Color.LightYellow, CssClass = "status-2" },
            new() { Id = 3 , Name = "Canceled", Color = Color.Red, CssClass = "status-3" },
            new() { Id = 4 , Name = "Complete", Color = Color.LimeGreen, CssClass = "status-4" },
        };
    }
}
