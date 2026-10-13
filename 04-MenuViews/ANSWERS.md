# Part 04 - MenuViews

Student name: Ziad Mohamed Elmaghraby
Group / ID: TODO

## Original runs
TODO: Paste actual console output and measurements before editing.

## Problems and causes
TODO: Explain in your own words.

## Changes and reasoning
TODO

## Runs after the fix
TODO: Paste actual output from repeated runs.

## Required discussion
TODO: Explain the counter race, your chosen tool, and when another form of protection is needed.

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
