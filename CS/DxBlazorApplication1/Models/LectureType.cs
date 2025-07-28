using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Models
{
    public class LectureType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Color Color { get; set; }
        public string? BackgroundCssClass { get; set; }
        public string? TextCssClass { get; set; }
    }
}
