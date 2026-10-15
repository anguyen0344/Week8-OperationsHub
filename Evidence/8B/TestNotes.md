# Action 8B — Test Notes

Project: CS110 Study Task Hub
Route: Operations Hub

| Input/action | Predicted result | Observed result | Next test |
| --- | --- | --- | --- |
| Add a valid study task | Task appears, input clears, status confirms | Worked as expected | Add a second task |
| Add a second task | Both tasks remain visible | Both tasks appeared | Remove one task |
| Add empty input | Show message without adding a task | Showed "Enter a study task first." | Try spaces only |
| Add spaces only | Reject input without adding a task | Input was rejected | Add valid text after rejection |
| Add valid text after rejection | App accepts the task | Task was added | Test Remove |
| Remove without selection | Show a selection message | Showed "Select a task to remove." | Select a task |
| Remove a selected task | Remove that task and keep the other | Selected task was removed | Test timer |
| Start timer | Countdown begins | Time decreased | Pause timer |
| Pause timer | Countdown stops | Time stopped | Resume timer |
| Resume timer | Continue from remaining time | Countdown continued | Reset timer |
| Reset timer | Stop and restore 25:00 | Returned to 25:00 and stopped | Test completion with five seconds |
| Run with temporary five-second value | Stop at 00:00 with feedback | Stopped at zero and showed completion | Press Start at zero |
| Press Start at zero | Ask user to reset | Showed "Reset the completed timer first." | Reset and start again |
| Reset and start after completion | Countdown works again from 25 minutes | Worked as expected | Restore starting field to 25 * 60 |
| Export two tasks and notes | Save a readable text report | study-report.txt contained notes and both tasks | Reopen the report |
| Reopen study-report.txt | Display saved report text | Report appeared in the document box | Test cancellation |
| Cancel Open dialog | Keep current text and show feedback | Text remained unchanged | Cancel Save dialog |
| Cancel Save dialog | Keep data without writing a new report | Data remained and cancellation feedback appeared | Test artwork |
| Choose a valid PNG/JPG | Display artwork and button image | Both images appeared | Cancel image selection |
| Cancel image selection | Keep current artwork | Artwork remained | Choose an invalid image |
| Choose text saved with a .png extension | Show an error without closing the app | Error appeared and app stayed open | Choose a valid image again |
| Choose a valid image after error | Load image successfully | Image loaded and status confirmed | Run peer test |
| Peer tests task, timer, report and Cancel workflows | Workflows function and feedback is visible | Peer completed the workflows successfully | Ask for usability feedback |
| Peer reviews timer explanation | Understand the timer's purpose | Initial label was unclear; revised explanation was understood | Keep revised wording |

## Peer revision
The peer asked what the focus timer was for.
I added an explanation: focus on one study task for
25 minutes, then take a short break.
The peer reviewed the change and understood its purpose.

## Test setup restored
After the short timer test, I restored the starting field:
private int remainingSeconds = 25 * 60;

## Limits
- Reopen displays report text. It does not restore the
  task collection or timer state.
- Duplicate task names are allowed.
- There is no break timer.
- Selected artwork is not saved in the text report.

## Further tests
- Verify the window remains readable at its minimum size.
- Check keyboard navigation with Tab and button activation.
- Test a file read/write error and retry in an accessible folder.