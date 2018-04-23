using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace WpfApplication27 {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (((FrameworkElement)sender).DataContext == ((FrameworkElement)carouselItemsControl.Carousel.ActiveItem).DataContext)
                MessageBox.Show("ActiveItemIsClicked");
            Title = ((Button)sender).Content.ToString();
        }
    }
    public class MyList : ObservableCollection<MyObject> {
        public MyList() {
            Add(new MyObject() { Field1 = "a1", Field2 = "a2" });
            Add(new MyObject() { Field1 = "b1", Field2 = "b2" });
            Add(new MyObject() { Field1 = "c1", Field2 = "c2" });
            Add(new MyObject() { Field1 = "d1", Field2 = "d2" });
            Add(new MyObject() { Field1 = "e1", Field2 = "e2" });
        }
    }
    public class MyObject {
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }
}