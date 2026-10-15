# Action 8B — Grading Guide

Project: CS110 Study Task Hub
Route: Operations Hub
Student: An Nguyen

Please review this folder for the Action 8B implementation,
validation, recovery and collaboration evidence.

## Evidence guide

| Requirement | Evidence |
| --- | --- |
| Updated event plan and recovery routes | [Whiteboard](whiteboard.jpg) |
| Completed interface | [Interface](completed-interface.png) |
| Timer reset to 25 minutes | [Reset test](timer-reset.png) |
| Timer stops at zero and requires reset | [Zero test](timer-zero.png) |
| Exported text with notes and tasks | [Report file](study-report.txt), [screenshot](exported-report.png) |
| Reopened report in the app | [Reopen test](reopened-report.png) |
| Cancel preserves current text | [Save cancellation](save-cancel.png) |
| Artwork loading | [Artwork test](artwork-loaded.png) |
| Invalid-image handling and recovery | [Error](invalid-image.png), [recovery](image-recovery.png) |
| Peer feedback, revision and retest | [Revision](peer-revision.png), [Discord](peer-discord.png) |
| Learning notes | [lecture-notes.md](lecture-notes.md) |
| AI prediction, test and decision | [AI-Test.md](AI-Test.md) |
| Test inputs, predictions, observations and next tests | [TestNotes.md](TestNotes.md) |

## Source code
- [MainWindow.xaml](../../OperationsHub/MainWindow.xaml)
- [MainWindow.xaml.cs](../../OperationsHub/MainWindow.xaml.cs)

## Core functions
- Add and remove study tasks.
- Start, pause, resume and reset a focus timer.
- Export and reopen a plain-text study report.

## Validation and recovery
Blank task input and removal without selection show feedback.
The timer stops at zero and requires Reset before restarting.
Cancel preserves current data.
File operations and image loading use try/catch to show errors.

## Unknown resolved from 8A
Could an exported report be reopened with the same text?
The exported file contained notes and two tasks, and Reopen
displayed that report text in the app.

## Peer revision
My classmate tested the required workflows and asked what
the timer was for. I added an explanation of the 25-minute
focus session and short break. They reviewed it and understood.

## Method recap
Save_Click calls BuildReport, which returns report text.
SaveText receives that text and writes it to the selected file.
Open_Click reads the file and displays it in txtDocument.

## Limits
Reopen restores text, not the task collection or timer state.
Duplicate task names are allowed.
There is no break timer.
Artwork selection is not saved in the text report.

## Git checkpoints
Repository history records separate checkpoints for the timer,
export/reopen, artwork and interface, and peer revision.