using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Models
{
    public class userapp_approval_of_over_time
    {
        public int user_id { get; set; }
        public int for_user_id { get; set; }
        public string  work_schedule_start_utc_timestamp { get; set; }
        public string attendance_clock_in_utc_timestamp { get; set; }
        public string work_schedule_end_utc_timestamp { get; set; }
        public string attendance_clock_out_utc_timestamp { get; set; }
        public int overtime_computation_in_minutes { get; set; }
        public bool status_pending_approved_denied { get; set; }
        public int approved_denied_by_user_id { get; set; }
        public string approved_denied_utc_timestamp { get; set; }
    }
}


