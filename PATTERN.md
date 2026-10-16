# Reusable Pattern — Validate Before Adding

## Purpose
Check user input before changing the task collection.
Invalid input receives clear feedback, and the user
can correct it and try again.

## Where it is used
OperationsHub/MainWindow.xaml.cs:
- Add_Click handles the button click.
- AddItem validates and adds the task.

## How it works
1. Read the text and trim surrounding spaces.
2. Check whether the result is blank.
3. If blank, show feedback and return.
4. Otherwise, add it to the ObservableCollection.
5. Clear the input and show confirmation.

## Example from the app
```csharp
string entry = txtEntry.Text.Trim();

if (string.IsNullOrWhiteSpace(entry))
{
    txtStatus.Text = "Enter a study task first.";
    return;
}

items.Add(entry);
txtEntry.Clear();
txtStatus.Text = "Task added.";
```

## Why it is useful
The early return prevents invalid data from reaching
the collection. Keeping the logic in AddItem also
keeps the button event handler short.

## How to reuse it
Use the same steps for a shopping list, inventory
list or reminder app. Change the input control,
validation rules, collection and feedback messages.

## Test and recovery
- Empty text: rejected with feedback.
- Spaces only: rejected with feedback.
- Valid task: added to the list.
- Valid task after rejection: added successfully.

Detailed results: [TestNotes](Evidence/8B/TestNotes.md).

