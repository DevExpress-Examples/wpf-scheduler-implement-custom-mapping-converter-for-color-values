using ColorMappingExample.Model;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace ColorMappingExample.ViewModels {
    [POCOViewModel]
    public class MainViewModel {
        public virtual ObservableCollection<MyAppointment> Appointments { get; set; }
        public virtual ObservableCollection<Category> Categories { get; set; }
        public virtual DevExpress.Xpf.Scheduling.DXColorSavingType ColorSavingType { get; set; }

        protected MainViewModel() {
            Appointments = CreateAppointments();
            Categories = CreateCategories();
        }

        private ObservableCollection<MyAppointment> CreateAppointments() {
            ObservableCollection<MyAppointment> result = new ObservableCollection<MyAppointment>();
            result.Add(MyAppointment.Create(DateTime.Today.AddHours(10), DateTime.Today.AddHours(11), "TEST", 1));
            return result;
        }
        #region #CreateCategories
        private ObservableCollection<Category> CreateCategories() {
            ObservableCollection<Category> result = new ObservableCollection<Category>();
            result.Add(Category.Create(0, "Blank category", "0xFFFFFFFF"));
            // Set the AppointmentLabelMappings.ColorSavingType to ColorString
            // and use the HtmlColorCodeToHexConverter.
            // Otherwise color values assigned as follows will be translated incorrectly.
            result.Add(Category.Create(1, "Color category", Colors.Orange.ToString()));
            result.Add(Category.Create(2, "Red category", "Red"));

            //// Set the AppointmentLabelMappings.ColorSavingType to ColorInstance.
            //// Otherwise color values assigned as follows will be translated incorrectly.
            //result.Add(Category.Create(1, "Color category", Colors.Orange));
            //result.Add(Category.Create(3, "Red category", Colors.Red));

            return result;
        }
        #endregion #CreateCategories
    }
}
