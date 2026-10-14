# Action 8B — Learning Notes

## Timer and state
DispatcherTimer raises a Tick event every second.
Timer_Tick decreases remainingSeconds and calls UpdateTimer.
The timer stops at zero. Start/Pause checks whether it is
running. Reset stops it and restores 25 minutes.
A blocking while loop would prevent the window responding.

## Parameters and return values
SaveText(string text) receives the text to save.
BuildReport() returns a string containing notes and tasks.
Save_Click passes that result to SaveText.

## Text files and recovery
WriteAllText exports the report. ReadAllText loads it into
txtDocument. Reopening restores text, not the task collection
or timer state.
Cancel keeps current data. try/catch reports file errors
without closing the app.

## Images
BitmapImage loads the selected PNG/JPG.
CacheOption.OnLoad loads the image data during initialization.
The same image appears in imgArtwork and imgButton.
An invalid image shows an error, and a valid image can be
selected afterward.

## Peer review and revision
My classmate tested the task, timer, report and cancellation
workflows. They asked what the focus timer was for.
I added an explanation: focus on one task for 25 minutes,
then take a short break. They reviewed it and understood.

## Unknown carried from 8A
Could an exported report be reopened with the same text?
The saved report included notes and both tasks.
Reopen displayed the report text in the app.

## Reusable pattern
A control raises an event. Its handler calls a focused
method, which changes data or saves a file and shows status.