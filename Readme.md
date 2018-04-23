# How to handle the Click event for the carousel item


<p>Specify our own template for the ItemsControl.ItemTemplate property and handle the PreviewMouseDown event for the control in the ItemTemplate. In the PreviewMouseDown event handler, to make sure that the user clicks an active item, compare the DataContext property of the ActiveItem and sender; if they equal each other, the active item is clicked.</p>

<br/>


