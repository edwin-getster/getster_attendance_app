using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getster_attendance_app.Models
{
    public class userapp_work_schedule_categories_master
    {
  
        public int user_id { get; set; }
        public int work_schedule_category_id { get; set; }
        public string category_name { get; set; }
        public string time_zone { get; set; }
    }
}
