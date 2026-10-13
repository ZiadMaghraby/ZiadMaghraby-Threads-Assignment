# Part 04 - MenuViews

Student name: Ziad Mohamed Elmaghraby
Group / ID: TODO

## Original runs
Expected: 400000
Actual:   92054

Expected: 400000
Actual:   117703



## Problems and causes
app is not thread safe, and the counter is being updated by multiple threads without any synchronization. This leads to a race condition where multiple threads read and write to the counter simultaneously, resulting in lost updates and an incorrect final count.

## Changes and reasoning
replaced the counter variable with an `Interlocked` operation to ensure atomic updates to the counter. This prevents race conditions by ensuring that only one thread can update the counter at a time.

## Runs after the fix
Expected: 400000
Actual:   400000

## Required discussion
the original code had a race condition due to multiple threads updating a shared counter without synchronization. This caused the final count to be less than expected. By using `Interlocked` operations, we ensured that updates to the counter are atomic, preventing lost updates and ensuring the final count is correct.

## Recorded original starter runs

Source: https://github.com/SimulationEG/AdvancedCsharp-Assignment-04-MenuViews

Commit: `c6762066077afb04e23655c68e69ae95a34d99af`

Original source and net9.0 project were unchanged for these runs. This machine has no .NET 9 runtime, so runs used `dotnet --roll-forward Major <original dll>` on .NET 10. The imported project targets net10.0 for normal local execution.

### Run 1 (exit code 0)

```text
Expected: 400000
Actual:   81638
```

### Run 2 (exit code 0)

```text
Expected: 400000
Actual:   92054
```

### Run 3 (exit code 0)

```text
Expected: 400000
Actual:   117703
```
