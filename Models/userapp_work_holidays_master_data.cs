using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Models
{
    public class userapp_work_holidays_master_data
    {


        public int user_id { get; set; }
        public int holiday_id { get; set; }
        public string holiday_name { get; set; }
        public int work_schedule_category_id { get; set; }
        public string holiday_start_utc_timestamp { get; set; }
        public int holiday_duration_minutes { get; set; }

    }
}
