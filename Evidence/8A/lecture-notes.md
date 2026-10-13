# Action 8A — Learning Notes

## User and purpose
CS110 Study Task Hub helps a student organize study tasks.
The prototype and whiteboard planned the first Add action
before implementation.

## XAML and C#
XAML defines the interface and connects a button's Click
event to a C# handler. Add_Click calls AddItem, which checks
the input and changes the task collection.

## Class, object and scope
MainWindow is a class. The running window is an object.
The items field belongs to the window and remains available
between clicks. The entry variable is local to a method.
InitializeComponent creates the controls before we use them.

## Collection and binding
ObservableCollection<string> stores task text.
lstItems.ItemsSource = items connects the list to the collection.
Adding or removing an item updates the visible list.

## Validation and recovery
Trim removes spaces at the beginning and end.
IsNullOrWhiteSpace rejects empty or spaces-only input.
The status explains the problem so the user can correct
the input and try again. Remove checks for a selected task.

## Git and GitHub
A commit records a local checkpoint. Push sends it to GitHub.
The raw starter and the working 8A behavior have separate
checkpoints. Git uses my GitHub noreply email.

## Button recap
Add button in XAML → Click → Add_Click → AddItem
→ items.Add(entry) → updated list, cleared input and status.

## Next
Complete the focus timer and export/reopen text workflow in 8B.