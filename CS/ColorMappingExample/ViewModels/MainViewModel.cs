using ColorMappingExample.Model;
using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace ColorMappingExample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<MyAppointment> Appointments { get; set; }

        public MainViewModel() {
            Appointments = CreateAppointments();
        }

        private ObservableCollection<MyAppointment> CreateAppointments() {
            ObservableCollection<MyAppointment> result = new ObservableCollection<MyAppointment> {
                new MyAppointment(DateTime.Today.AddHours(10), DateTime.Today.AddHours(11), "TEST", Priority.Normal)
            };
            return result;
        }
    }
}
