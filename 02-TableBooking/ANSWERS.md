# Part 02 - TableBooking

Student name: Ziad Mohamed Elmaghraby


## Original runs

Customer-37 booked a table. Left=-3
Customer-40 booked a table. Left=-3
Customer-35 booked a table. Left=-3
Customer-34 booked a table. Left=-3
Customer-36 booked a table. Left=-3
Customer-33 booked a table. Left=-3
Customer-38 booked a table. Left=-3
Customer-39 booked a table. Left=-3
Booked=8, TablesLeft=-3

Customer-40 booked a table. Left=-2
Customer-35 booked a table. Left=-2
Customer-38 booked a table. Left=-7
Customer-31 booked a table. Left=-5
Customer-34 booked a table. Left=-8
Booked=17, TablesLeft=-11

## Problems and causes

The code suffers from a Race Condition. Multiple threads evaluate the `if (TablesLeft <= 0)` condition simultaneously. Because context switching happens, many threads pass this check while `TablesLeft` is still greater than 0, enter the `Thread.Sleep(20)` phase together, and then all decrement the counter, causing negative available tables and overbooking.

## Changes and reasoning

Introduced a private `readonly Lock _lock = new Lock();` (using the high-performance modern lock mechanism available in .NET 9+) and wrapped the critical section (the condition check, the sleep, and the state updates) inside a `lock (_lock) { ... }` statement. This ensures mutual exclusion and thread safety.

## Runs after the fix

Customer-01 booked a table. Left=4
Customer-02 booked a table. Left=3
Customer-03 booked a table. Left=2
Customer-04 booked a table. Left=1
Customer-05 booked a table. Left=0
Booked=5, TablesLeft=0

## Required discussion

By placing both the condition check (`if (TablesLeft <= 0)`) and the update (`TablesLeft--`, `Booked++`) inside the same `lock` block, they become an atomic operation. This guarantees that no other thread can check the availability of tables while another thread is in the middle of processing a booking.