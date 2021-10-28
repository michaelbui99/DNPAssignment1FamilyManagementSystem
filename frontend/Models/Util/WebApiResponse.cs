using System.Collections.Generic;

namespace DNPAssignment1FamilyManagementSystem.Models.Util
{
    public class WebApiResponse
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string TraceId { get; set; }
        public  Error Errors { get; set; }
        
    }

    public class Error
    {
        public string[] Password { get; set; }
    }
}