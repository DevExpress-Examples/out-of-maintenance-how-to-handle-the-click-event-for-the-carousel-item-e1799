Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel

Namespace WpfApplication27
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Public Partial Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Button_PreviewMouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			If (CType(sender, FrameworkElement)).DataContext Is (CType(carouselItemsControl.Carousel.ActiveItem, FrameworkElement)).DataContext Then
                MessageBox.Show("ActiveItemIsClicked")
            End If
            Me.Title = CType(sender, Button).Content.ToString()
		End Sub
	End Class
	Public Class MyList
		Inherits ObservableCollection(Of MyObject)
		Public Sub New()
            Me.Add(New MyObject() With {.Field1 = "a1", .Field2 = "a2"})
            Me.Add(New MyObject() With {.Field1 = "b1", .Field2 = "b2"})
            Me.Add(New MyObject() With {.Field1 = "c1", .Field2 = "c2"})
            Me.Add(New MyObject() With {.Field1 = "d1", .Field2 = "d2"})
            Me.Add(New MyObject() With {.Field1 = "e1", .Field2 = "e2"})
		End Sub
	End Class
    Public Class MyObject

        Private _field1 As String
        Public Property Field1() As String
            Get
                Return _field1
            End Get
            Set(ByVal value As String)
                _field1 = value
            End Set
        End Property
        Private _field2 As String
        Public Property Field2() As String
            Get
                Return _field2
            End Get
            Set(ByVal value As String)
                _field2 = value
            End Set
        End Property

    End Class
End Namespace

