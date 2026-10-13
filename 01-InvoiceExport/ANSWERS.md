# Assignment 01 — Answers

Student name: Ziad Mohamed Elmaghraby

## Output before fix 

Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\invoices\invoice-1001.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\invoices\invoice-1002.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\invoices\invoice-1003.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\invoices\invoice-1004.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\invoices\invoice-1005.txt
Export finished in 5.9 s

## Output after fix

Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\bin\Debug\net10.0\invoices\invoice-1001.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\bin\Debug\net10.0\invoices\invoice-1005.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\bin\Debug\net10.0\invoices\invoice-1003.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\bin\Debug\net10.0\invoices\invoice-1004.txt
Wrote C:\Users\20102\source\repos\ZiadMaghraby-Threads-Assignment\01-InvoiceExport\InvoiceExport\bin\Debug\net10.0\invoices\invoice-1002.txt
Export finished in 1.9 s

## Problems with the current design

- It takes a long time to export 5 invoices only (5.9 seconds).
- It uses synchronous execution, meaning the main thread gets blocked while waiting for the database or file operations.
- Using `Thread.Sleep` and synchronous file I/O methods like `File.ReadAllText` freezes the execution completely.

## What you changed

- Replaced `Thread.Sleep` with `await Task.Delay` to prevent thread blocking.
- Converted file operations to asynchronous methods using `File.ReadAllTextAsync` and `File.WriteAllTextAsync`.
- Updated all helper classes (`OrderDatabase`, `CustomerFileStore`, `InvoiceFileWriter`) to use `async/await` and return a `Task`.
- In `InvoiceExportService`, separated the logic into a `ProcessOrderAsync` helper method to handle the full lifecycle of a single order.
- In `ExportAllPendingAsync`, launched all tasks concurrently by adding them to a `List<Task>` in a `foreach` loop, and then awaited them one by one in a separate loop to abide by the assignment rules (without using `Task.WhenAll`).
- Updated `Program.cs` to await the new asynchronous export method.