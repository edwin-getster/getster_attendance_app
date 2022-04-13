using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Models
{
    public class userapp_work_shift_timings_master_data
    {
     
       public int user_id { get; set; }
       public int shift_time_id { get; set; }
       public string shift_name { get; set; }
       public int work_schedule_category_id { get; set; }
       public string  weekday { get; set; }
       public string start_time { get; set; }
       public int shift_time_duration_minutes { get; set; }
    }
}
