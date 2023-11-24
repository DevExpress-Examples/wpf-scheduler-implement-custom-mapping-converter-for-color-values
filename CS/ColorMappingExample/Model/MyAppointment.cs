using System;

namespace ColorMappingExample.Model {
    public class MyAppointment {
        public MyAppointment(DateTime startTime, DateTime endTime, string subject, Priority priorityId) {
            StartTime = startTime;
            EndTime = endTime;
            Subject = subject;
            PriorityId = priorityId;
        }

        protected MyAppointment() { }
        public virtual int Id { get; set; }
        public virtual bool AllDay { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual string Subject { get; set; }
        public virtual int StatusId { get; set; }
        public virtual Priority PriorityId { get; set; }
        public virtual int Type { get; set; }
        public virtual string Location { get; set; }
        public virtual string RecurrenceInfo { get; set; }
        public virtual string ReminderInfo { get; set; }
    }
}
