using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorMappingExample.Model {
    public class MyAppointment {
        public static MyAppointment Create() {
            return ViewModelSource.Create(() => new MyAppointment());
        }
        internal static MyAppointment Create(DateTime startTime, DateTime endTime, string subject, int categoryId) {
            MyAppointment apt = MyAppointment.Create();
            apt.StartTime = startTime;
            apt.EndTime = endTime;
            apt.Subject = subject;
            apt.CategoryId = categoryId;
            return apt;
        }

        protected MyAppointment() { }
        public virtual int Id { get; set; }
        public virtual bool AllDay { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual string Subject { get; set; }
        public virtual int StatusId { get; set; }
        public virtual int CategoryId { get; set; }
        public virtual int Type { get; set; }
        public virtual string Location { get; set; }
        public virtual string RecurrenceInfo { get; set; }
        public virtual string ReminderInfo { get; set; }
    }
}
