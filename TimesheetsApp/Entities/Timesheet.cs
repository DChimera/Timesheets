using System.ComponentModel.DataAnnotations;

namespace TimesheetsApp.Entities
{
    public class Timesheet
    {
        public int TimesheetId { get; set; }
        [DisplayFormat(DataFormatString = "{mm/DD/yyyy}")]
        [Required(ErrorMessage = "Please enter a date.")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please enter the hours.")]
        [Range(1, 40, ErrorMessage = "Hours must be within 1 and 40.")]
        public int Hours { get; set; }
        [Required(ErrorMessage = "Please enter the project name.")]
        public string? ProjectName { get; set; }
    }       
}
