This is a reproduction of a bug where Rider is unable to run with attached debugger while it is perfectly valid to do so.

* Debug option is greyed out
* Run without debugging
* Interactive terminal in 'Run' tab shows up)
* Attach debugger to existing process
* Choose .NET Core proccess that ends with `-NoExit -Command Import-Module ./RiderWithDisabledDebuggerForExecutableRun.dll`
* Set breakpoint in file `GetSampleTextCommand` in line `10`
* Type `Get-SampleText` in terminal
* Execution stops on a breakpoint according to expectations
