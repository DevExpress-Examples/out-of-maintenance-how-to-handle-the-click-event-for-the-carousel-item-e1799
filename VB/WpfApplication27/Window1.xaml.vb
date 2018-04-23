Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports System.Collections.ObjectModel

Namespace WpfApplication27
    Partial Public Class Window1
        Inherits Window
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Button_PreviewMouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
            If (CType(sender, FrameworkElement)).DataContext Is (CType(carouselItemsControl.Carousel.ActiveItem, FrameworkElement)).DataContext Then
                MessageBox.Show("ActiveItemIsClicked")
            End If
            Title = (CType(sender, Button)).Content.ToString()
        End Sub
    End Class

    Public Class MyList
        Inherits ObservableCollection(Of MyObject)
        Public Sub New()
            Add(New MyObject() With {.Field1 = "a1", .Field2 = "a2"})
            Add(New MyObject() With {.Field1 = "b1", .Field2 = "b2"})
            Add(New MyObject() With {.Field1 = "c1", .Field2 = "c2"})
            Add(New MyObject() With {.Field1 = "d1", .Field2 = "d2"})
            Add(New MyObject() With {.Field1 = "e1", .Field2 = "e2"})
        End Sub
    End Class

    Public Class MyObject
        Public Property Field1() As String
        Public Property Field2() As String
    End Class
End Namespace
