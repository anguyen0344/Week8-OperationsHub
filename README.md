# CS110 Week 8 — Study Task Hub

Student: An Nguyen
Selected route: Operations Hub
Built with C# and WPF.

## Week 8 Grading Guide

Please use this guide to review the final app and evidence.
Action 8A and 8B records are kept in their own folders.

| Requirement | Evidence |
| --- | --- |
| R1 — Define the user and utility | [Context](Evidence/8A/Context.md), [AAA](Evidence/8A/Week8-AAA-Completed.pdf), [SEEK](Evidence/8A/Week8-SEEK-Completed.pdf) |
| R2 — Prototype and map events | [Prototype](Evidence/8A/prototype.png), [8A whiteboard](Evidence/8A/Whiteboard8A.jpg), [First working action](Evidence/8A/add-task.png) |
| R3★ — Build the selected utility | [Interface source](OperationsHub/MainWindow.xaml), [C# source](OperationsHub/MainWindow.xaml.cs), [Completed interface](Evidence/8B/completed-interface.png), [Test notes](Evidence/8B/TestNotes.md) |
| R4★ — Validate, recover and save text | [Blank input](Evidence/8A/blank-input.png), [Invalid image](Evidence/8B/invalid-image.png), [Recovery](Evidence/8B/image-recovery.png), [Report file](Evidence/8B/study-report.txt), [Export](Evidence/8B/exported-report.png), [Reopen](Evidence/8B/reopened-report.png), [Save cancellation](Evidence/8B/save-cancel.png) |
| R5 — Keep both class records | [8A guide](Evidence/8A/README.md), [8B guide](Evidence/8B/README.md), [8A AI record](Evidence/8A/AI-Test.md), [8B AI record](Evidence/8B/AI-Test.md) |
| R6 — Document a reusable pattern | This README and [PATTERN.md](PATTERN.md) |
| R7★ — Receipt and tested GitHub link | [Week 8 receipt](Evidence/Final/receipt.html). Instructor access and Canvas submission are checked separately. |

### Three core functions

| Function | Methods and data | Test evidence |
| --- | --- | --- |
| Add and remove tasks | Add_Click, AddItem, Remove_Click; ObservableCollection and ItemsSource | [Add](Evidence/8A/add-task.png), [Remove](Evidence/8A/remove-task.png), [Test notes](Evidence/8B/TestNotes.md) |
| Start, pause and reset timer | Timer_Click, Timer_Tick, UpdateTimer, Reset_Click; DispatcherTimer and remainingSeconds | [Reset](Evidence/8B/timer-reset.png), [Timer completion](Evidence/8B/timer-zero.png), [AI test](Evidence/8B/AI-Test.md) |
| Export and reopen text | Save_Click, BuildReport, SaveText, Open_Click | [Saved report](Evidence/8B/study-report.txt), [Reopened report](Evidence/8B/reopened-report.png) |

### Class and collaboration evidence

- [8A whiteboard](Evidence/8A/Whiteboard8A.jpg)
- [8B whiteboard](Evidence/8B/whiteboard.jpg)
- [Additional 8B whiteboards](Evidence/8B/all-white-board/)
- [8A lecture notes](Evidence/8A/lecture-notes.md)
- [8B lecture notes](Evidence/8B/lecture-notes.md)
- [8A peer and Discord record](Evidence/8A/peer-discord.jpg)
- [8B peer and Discord record](Evidence/8B/peer-discord.png)
- [Whiteboard Discord record](Evidence/8B/discord-all-white-board.jpg)
- [Peer revision](Evidence/8B/peer-revision.png)
- [Image sources](Evidence/8B/image-sources.md)

The peer requested a clearer explanation of the timer.
I added the purpose of the 25-minute focus session.

The peer reviewed the change and understood it.

Git checkpoints are available in the repository history.
Instructor acceptance of 8A and 8B is confirmed separately.
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