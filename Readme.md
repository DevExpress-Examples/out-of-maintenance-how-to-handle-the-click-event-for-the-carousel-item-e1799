<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1799)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/WpfApplication27/Window1.xaml) (VB: [Window1.xaml](./VB/WpfApplication27/Window1.xaml))
* [Window1.xaml.cs](./CS/WpfApplication27/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/WpfApplication27/Window1.xaml.vb))
<!-- default file list end -->
# How to handle the Click event for the carousel item


<p>Specify our own template for the ItemsControl.ItemTemplate property and handle the PreviewMouseDown event for the control in the ItemTemplate. In the PreviewMouseDown event handler, to make sure that the user clicks an active item, compare the DataContext property of the ActiveItem and sender; if they equal each other, the active item is clicked.</p>

<br/>


