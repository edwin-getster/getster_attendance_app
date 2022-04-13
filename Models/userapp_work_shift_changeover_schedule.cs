using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Models
{
    public class userapp_work_shift_changeover_schedule
    {
        public int user_id { get; set; }
        public int work_schedule_category_id { get; set; }
        public string effective_from_utc_timestamp { get; set; }
        public string changeover_frequency { get; set; }
        public int changeover_during_shift_time_id { get; set; }
        public int changeover_with_work_group_of_shift_time_id { get; set; }
    }
}
