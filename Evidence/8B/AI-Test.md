# Action 8B — AI Assistance and Test Record

## Tool
ChatGPT.

## Focused question
How can I stop the focus timer at zero and let the user
recover safely without freezing the window?

## AI response
Use DispatcherTimer with a one-second interval.
Stop the timer when remainingSeconds reaches zero.
Show a reset message if the user presses Start at zero.
Reset stops the timer and restores 25 minutes.

## Prediction
With a temporary five-second starting value:
- The timer should stop at 00:00.
- Start at zero should ask the user to reset.
- Reset should restore 25:00 and leave the timer stopped.
- Start should work again after Reset.

## Test and observed result
I temporarily set the starting field to five seconds.
The timer stopped at 00:00 and showed completion feedback.
Pressing Start at zero showed the reset message.
Reset restored 25:00, and Start worked again.

I also tested Start, Pause and Resume.
Pause stopped the countdown. Resume continued from the
remaining time.

## Decision
Keep the timer implementation.
I restored the starting field to 25 * 60 before committing.

## Other AI assistance and tests

### Report export and reopen
AI helped implement BuildReport, SaveText, Save_Click
and Open_Click.

The exported study-report.txt contained my notes and
both study tasks. Reopen displayed the report in the app.
Cancel kept the current text.

### Artwork and recovery
AI helped implement Image_Click using BitmapImage.
A valid image appeared in the artwork area and button.
An invalid image showed an error without closing the app.
Selecting a valid image afterward worked.

### Peer feedback and revision
My classmate tested the task, timer, report and cancellation
workflows successfully but did not understand the timer's
purpose.

I added an explanation telling the user to focus on one
study task for 25 minutes, then take a short break.
My classmate reviewed the explanation and understood it.

## Evidence
- [Timer reset](timer-reset.png)
- [Timer at zero and reset message](timer-zero.png)
- [Exported report](exported-report.png)
- [Reopened report](reopened-report.png)
- [Save cancellation](save-cancel.png)
- [Artwork loaded](artwork-loaded.png)
- [Invalid-image error](invalid-image.png)
- [Image recovery](image-recovery.png)
- [Peer revision](peer-revision.png)
- [Peer and Discord record](peer-discord.png)

## Known limits
Reopen restores report text, not the task list or timer state.
Duplicate task names are allowed.
The app does not include a break timer.
Selected artwork is not saved in the text report.