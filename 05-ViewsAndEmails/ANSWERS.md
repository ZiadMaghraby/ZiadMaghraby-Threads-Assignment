# Part 05 - ViewsAndEmails

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
TODO: Explain both fixes and why thread-safe collections do not automatically protect business rules.

## Recorded original starter runs

Source: https://github.com/SimulationEG/AdvancedCsharp-Assignment-05-ViewsAndEmails

Commit: `2511346f5589594a1806984c4bd47eeb278f023c`

Original source and net9.0 project were unchanged for these runs. This machine has no .NET 9 runtime, so runs used `dotnet --roll-forward Major <original dll>` on .NET 10. The imported project targets net10.0 for normal local execution.

### Run 1 (exit code 3762504530)

```text
Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: koshary-bowl
   at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
   at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
   at ViewsAndEmails.AnalyticsAndEmailJobs.RecordView(String product) in C:\Users\20102\Documents\Codex\2026-10-12\shu\work\starters\05-ViewsAndEmails\ViewsAndEmails\AnalyticsAndEmailJobs.cs:line 15
   at Program.<>c__DisplayClass0_0.<<Main>$>b__0() in C:\Users\20102\Documents\Codex\2026-10-12\shu\work\starters\05-ViewsAndEmails\ViewsAndEmails\Program.cs:line 11
   at System.Threading.Thread.StartCallback()
```

### Run 2 (exit code 0)

```text
Views expected=50000, actual=9639
Email jobs placed=20, unique sent=18, total sends=18
```

### Run 3 (exit code 3762504530)

```text
Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: koshary-bowl
   at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
   at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
   at ViewsAndEmails.AnalyticsAndEmailJobs.RecordView(String product) in C:\Users\20102\Documents\Codex\2026-10-12\shu\work\starters\05-ViewsAndEmails\ViewsAndEmails\AnalyticsAndEmailJobs.cs:line 15
   at Program.<>c__DisplayClass0_0.<<Main>$>b__0() in C:\Users\20102\Documents\Codex\2026-10-12\shu\work\starters\05-ViewsAndEmails\ViewsAndEmails\Program.cs:line 11
   at System.Threading.Thread.StartCallback()
```
