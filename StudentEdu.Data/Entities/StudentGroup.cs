using System;

namespace StudentEdu.Data

{
    public class Group
    {
       
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreaDate { get; set; }
    }

}
