using DevExpress.Mvvm.POCO;

namespace ColorMappingExample.Model {
    public class Category {
        object _colorData;

        protected Category(int id, string caption, object color) {
            Id = id;
            Caption = caption;
            ColorData = color;
        }
        public static Category Create(int id, string caption, object color) {
            return ViewModelSource.Create(() => new Category(id, caption, color));
        }

        protected Category() { }

        public virtual int Id { get; set; }
        public virtual string Caption { get; set; }
        public virtual object ColorData {
            get {
                return _colorData;
            }
            set {
                _colorData = value;
                ColorDataInfo = "Saved as " + value.GetType().ToString() + " value= " + value.ToString();
            }
        }
        public virtual string ColorDataInfo { get; set; }
    }
}
