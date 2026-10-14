# Order Processing System

Status: structure only; phase implementations are TODO.

## Run
Requires .NET 10 SDK. Current scaffold:
`dotnet run --project 06-OrderProcessing/OrderProcessing`

TODO: Implement phase1, phase2, phase3, phase4, all, a numbered menu, and --cancel-after <ms>.
Runtime data will live under Path.Combine(AppContext.BaseDirectory, "Data").

## Structure and class responsibilities
- Shared/Models: domain models and enums.
- Shared/Storage: DataFiles, JsonFileStore, DataSeeder.
- Shared/Logging: thread-safe console logging.
- Shared/Exceptions: required custom exceptions.
- Phase1: repositories, validation, sync comparison, runner.
- Phase2: pricing, stock race demo, invoices, reports, runner.
- Phase3: payments, email retries, checkout, compensation, comparisons, runner.
- Phase4: live progress, dashboard, shipping quotes, fraud scoring, email re-send.

## Storage design
TODO: Document file names, seed data, JSON options, atomic writes, and protected read-modify-write operations.

## Performance measurements
Record real Stopwatch measurements, distinct thread counts and ThreadPool.ThreadCount.

| Experiment | Time | Distinct threads | ThreadPool.ThreadCount |
| --- | --- | --- | --- |
| Phase 1 sync / async | TODO | TODO | TODO |
| Phase 2 sequential / concurrent pricing | TODO | TODO | TODO |
| Phase 2 concurrent processing | TODO | TODO | TODO |
| Phase 3 sync threads / async tasks | TODO | TODO | TODO |
| Phase 4 dashboard | TODO | TODO | TODO |
| Phase 4 shipping quotes | TODO | TODO | TODO |
| Phase 4 sequential / parallel fraud scoring | TODO | TODO | TODO |
| Phase 4 email re-send | TODO | TODO | TODO |

## Questions
TODO: Answer all Phase 1 questions (5), Phase 2 questions (8), Phase 3 comparison questions (4) and fire-and-forget investigation, and Phase 4 questions (6).

## Evidence and sample output
TODO: Save final JSON snapshots in sample-output/phase1 through phase4.
TODO: Add screenshots for each phase, stock race, faulted task, timeout, refund, retries, both fire-and-forget demos, every Phase 4 task, and cancellation.

## Problems encountered and fixes
TODO: Record problems and explain solutions as you implement each phase.
