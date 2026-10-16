# CS110 Week 8 — Study Task Hub

Student: An Nguyen
Selected route: Operations Hub
Built with C# and WPF.

## User and purpose
This app helps me organize my CS110 study tasks, focus on
one task for 25 minutes, and save a readable study report.

Planning, assumptions, limits and privacy:
[Context](Evidence/8A/Context.md).

## How to run
1. Download or clone this repository on Windows.
2. Open OperationsHub/OperationsHub.csproj in Visual Studio
   with the .NET desktop development workload and .NET 8 SDK.
3. Build and run the project.

## Controls
- Add task: enter a task and add it to the list.
- Remove selected: select a task before removing it.
- Start / Pause: start or pause the focus timer.
- Reset: stop the timer and restore 25:00.
- Choose artwork: select a local PNG or JPG image.
- Export report: save the notes and task list as a text file.
- Reopen text: display a saved text report in the notes box.

The focus timer supports one 25-minute study session.
When it finishes, the user can take a short break.

## Event flow
The Add button calls Add_Click, which calls AddItem.
AddItem trims the input and rejects blank text.
Valid text is added to an ObservableCollection.
The list updates, the input clears and status confirms
the result.

The timer uses DispatcherTimer to update the countdown
without blocking the window.

## Validation and recovery
- Blank or spaces-only tasks are rejected.
- Removing a task requires a selection.
- The completed timer must be reset before restarting.
- Canceling a file dialog keeps the current data.
- Invalid images show an error without closing the app.
- File operations use error handling and visible feedback.

## Tests and peer revision
Testing covered task actions, timer controls and completion,
export/reopen, cancellation and image error recovery.

A classmate tested the app and asked what the timer was for.
I added a short explanation. The classmate reviewed the
change and understood its purpose.

Detailed results:
[Test notes](Evidence/8B/TestNotes.md).

## Class records and evidence
Please review both class folders for the planning,
whiteboards, lecture notes, collaboration, Discord records,
AI assistance and screenshots.

- [Action 8A grading guide](Evidence/8A/README.md)
- [Action 8B grading guide](Evidence/8B/README.md)
- [8A AI record](Evidence/8A/AI-Test.md)
- [8B AI record](Evidence/8B/AI-Test.md)
- [Exported study report](Evidence/8B/study-report.txt)
- [Image source information](Evidence/8B/image-sources.md)

Git checkpoints are available in the repository history.

## Source
- [Interface](OperationsHub/MainWindow.xaml)
- [Event handlers and methods](OperationsHub/MainWindow.xaml.cs)
- [Project file](OperationsHub/OperationsHub.csproj)

## Known limits and next improvement
Reopening a report displays its text. It does not restore
the task collection or timer state.
Duplicate task names are allowed.
There is no automatic break timer.
Selected artwork is not saved in the text report.
My next improvement would be restoring saved tasks
into the task list.