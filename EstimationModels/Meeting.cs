using System;
using System.ComponentModel.DataAnnotations;

namespace EstimationModels
{
    public class Meeting
    {
        [Key]
        public string MeetingId { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(30)]
        public string Creator { get; set; }
    }
}
