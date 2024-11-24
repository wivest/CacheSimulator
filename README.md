# Cache Simulator

Simple simulator that allows you to enter hex-prefixed address queries and view cache state.

## Run the project

First, you need to [download .NET](https://dotnet.microsoft.com/en-us/download). Open project repository and run the following command:

```
dotnet run
```

Now enter addresses (in `0x<hex-number>` format). Press enter to query, `Ctrl + C` to end program.

## Parameters

All parameters are located in [Program.cs](/Program.cs):

-   `SETS` is a number of cache sets
-   `ASSOCIATIVITY` is a number of sells located in one set
-   `BITS_PER_CELL` is a cell byte size, represented in bits

## Selector

If you implement [ISelector](/Cache/Selector/ISelector.cs) interface, you can simulate different cache behaviours.
