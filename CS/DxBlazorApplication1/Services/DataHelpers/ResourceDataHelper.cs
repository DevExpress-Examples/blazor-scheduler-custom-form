using DxBlazorApplication1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Services.DataHelpers {
    public class ResourceDataHelper {
        public static List<Lecturer> GetResources() => lecturers;

        private static readonly List<Lecturer> lecturers = new List<Lecturer> {
            new(){ Id = 1, Name = "Jack Brown", Color = Color.LightPink, BackgroundCssClass = "lecturer-1", TextCssClass = "lecturer-1-text" },
            new(){ Id = 2, Name = "Robert Porter", Color = Color.LightSteelBlue, BackgroundCssClass = "lecturer-2", TextCssClass = "lecturer-2-text" },
            new(){ Id = 3, Name = "Maria Gonzales", Color = Color.LemonChiffon, BackgroundCssClass = "lecturer-3", TextCssClass = "lecturer-3-text" },
            new(){ Id = 4, Name = "Patrick Green", Color = Color.Lavender, BackgroundCssClass = "lecturer-4", TextCssClass = "lecturer-4-text" },
        };
    }
}
