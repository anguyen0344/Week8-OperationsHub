# Action 8A — AI Assistance and Test Record

## Tool
ChatGPT.

## Request summary
I asked for help connecting the task collection to the WPF
list and implementing the Add and Remove button handlers.

## Response summary
The AI suggested an ObservableCollection<string>, an
ItemsSource connection, an AddItem method with input
validation, and a Remove_Click method that checks selection.

## Changes used
I replaced the starter's placeholder Add and Remove handlers.
The messages refer to study tasks.

## Tests
- Adding a valid task displayed it in the list, cleared the
  input and showed "Task added."
- Empty and spaces-only input showed
  "Enter a study task first." without adding an item.
- A valid task could be added after invalid input.
- Removing without selection showed
  "Select a task to remove."
- Removing a selected task updated the list and showed
  "Task removed."

## Decision
Keep the implementation for the 8A task-list workflow.

## Known limit
Duplicate task names are currently allowed.
Timer and file features still need implementation in 8B.

## Evidence
- [Add](add-task.png)
- [Invalid input](blank-input.png)
- [Remove](remove-task.png)