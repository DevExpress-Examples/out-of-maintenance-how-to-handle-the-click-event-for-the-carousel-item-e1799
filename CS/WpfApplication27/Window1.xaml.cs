using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApplication27 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            if (((FrameworkElement)sender).DataContext == ((FrameworkElement)carouselItemsControl.Carousel.ActiveItem).DataContext)
                MessageBox.Show("ActiveItemIsClicked");
            this.Title = ((Button)sender).Content.ToString();
        }
    }
    public class MyList : ObservableCollection<MyObject> {
        public MyList() {
            this.Add(new MyObject() { Field1 = "a1", Field2 = "a2" });
            this.Add(new MyObject() { Field1 = "b1", Field2 = "b2" });
            this.Add(new MyObject() { Field1 = "c1", Field2 = "c2" });
            this.Add(new MyObject() { Field1 = "d1", Field2 = "d2" });
            this.Add(new MyObject() { Field1 = "e1", Field2 = "e2" });
        }
    }
    public class MyObject {
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    }
}
