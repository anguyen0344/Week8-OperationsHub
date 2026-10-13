# Action 8A — Grading Guide

Project: CS110 Study Task Hub
Route: Operations Hub
Student: An Nguyen

## Where to find the 8A evidence
Please review this folder for the Action 8A planning,
implementation and collaboration evidence.

| Requirement | Evidence |
| --- | --- |
| User, problem, assumptions, limits and privacy | [Context.md](Context.md) |
| AAA planning | [Week8-AAA-Completed.pdf](Week8-AAA-Completed.pdf) |
| SEEK story planning | [Week8-SEEK-Completed.pdf](Week8-SEEK-Completed.pdf) |
| Interface prototype | [prototype.png](prototype.png) |
| Editable prototype | [Week8-8A-Prototype.pptx](Week8-8A-Prototype.pptx) |
| Event plan, assumption and failure recovery | [whiteboard.jpg](whiteboard.jpg) |
| Adapted interface | [interface-shell.png](interface-shell.png) |
| First working Add event | [add-task.png](add-task.png) |
| Blank-input validation | [blank-input.png](blank-input.png) |
| Remove selected task | [remove-task.png](remove-task.png) |
| Peer observation recorded in Discord | [peer-discord.png](peer-discord.png) |
| Learning notes and button recap | [lecture-notes.md](lecture-notes.md) |

## Implementation
Source: [MainWindow.xaml.cs](../../OperationsHub/MainWindow.xaml.cs)

The Add button calls Add_Click, which calls AddItem.
AddItem trims and validates the input, adds valid task text
to an ObservableCollection, clears the input and shows status.

Remove_Click checks for a selected task before removing it.
The list uses ItemsSource to display changes to the collection.

## Peer check
My classmate opened the app, added a study task without
coaching and noticed the visible feedback.

## Git checkpoints
The repository history includes the raw starter checkpoint
and a separate checkpoint for the working 8A behavior.

## Remaining work
The timer, artwork and export/reopen text features are
planned for 8B. The AI assistance record will be linked
here when completed.