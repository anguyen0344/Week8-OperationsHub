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