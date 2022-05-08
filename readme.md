# Demo project for [Masstransit](https://masstransit-project.com/getting-started/) research

Based on [Livecoding examples](https://masstransit-project.com/getting-started/live-coding.html) and known domain requirement.

## Points of interest

* Anonymous object values: https://masstransit-project.com/usage/producers.html#message-initializers

    > The anonymous object is loosely typed, the properties are matched by name, and there is an extensive set of type conversions that may occur to obtain match the types defined by the interface

    'MassTransit.Analyzers' nuget can be used to add warnings and fields naming checks.

* [InMemory mediator implementation](https://masstransit-project.com/usage/mediator.html) as transport - to be familiar with messaging logic. Also blazing fast!