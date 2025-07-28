using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DxBlazorApplication1.Models
{
    public class UniversityClass
    {
        public int Id { get; set; }
        public int? LecturerId { get; set; }
        public string? LecturerIds { get; set; }
        public int Status { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public int Label { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string? RecurrenceInfo { get; set; }
        public string? ReminderInfo { get; set; }
        public string? TimeZoneId { get; set; }
        public string? Grade { get; set; }
    }
}
