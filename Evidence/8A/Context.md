# Context — CS110 Study Task Hub

## Selected Route
Operations Hub — a C# WPF utility for organizing study tasks.

## Intended User and Situation
An, a CS110 student, uses the app on a Windows computer at the beginning of a study session.

## Problem
Study tasks are scattered across notes and browser tabs. The student needs one clear place to list the work and decide what to do next.

## User Story
As a CS110 student, I want to organize my tasks, time a study interval, and export a report so I can keep track of my study session.

## Useful Result
The completed Week 8 app will let the user:
- Add and remove study tasks.
- Start, pause, and reset a focus timer.
- Export and reopen a plain-text study report.

## First Working Action — 8A
The user enters "Finish CS110 whiteboard" and clicks Add.
The task appears in the list, the entry box clears, and a status message confirms the addition.

## Assumptions to Test
- A new user can find the task entry box and Add button without coaching.
- The status message is visible and understandable.
- Selecting an item before removing it is clear to the user.

These assumptions have not been verified yet.

## Failure and Recovery
Blank or spaces-only input should not create a task.
The app should ask the user to enter a task, then allow another attempt.
Removing with no selection should show a message asking the user to select an item.

## Limits
This is a Windows desktop utility for one local study session.
It does not connect to Canvas or automatically track deadlines.
Tasks are stored in memory and are lost when the app closes.
The planned Reopen text action restores report text, not the task list or timer.

## Privacy Boundary
Use fictional or non-sensitive study tasks in screenshots and tests.
Do not enter passwords, student IDs, grades, or private classmate information.
The app does not require an online account.

## Attention First — SEEK and AAA
SEEK gives the app a specific story: a student turning scattered tasks into a focused study session.

Application: try adding a task and safely test blank input.
Action: explain the XAML event, C# method, validation, and collection update.
Amplification: reuse the pattern for Remove and later extend the app with a timer and report.

Keep the first action clearly labelled, show visible feedback, and provide a recovery message.

## Planned Tests
- Add a valid task.
- Add a second task.
- Try empty and spaces-only input.
- Remove a selected task.
- Try Remove with no selection.
- Ask a peer to perform the first action without coaching.

Record actual results and peer observations after testing.