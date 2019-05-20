# Apply=GroupBy Example

This example shows the odd behavior I am seeing using the OData `$apply=groupby()` syntax to attempt to get distinct values out of an endpoint.

The problem is occurring against SQL Server (I'm using 2014 if that makes a difference). To run the sample:

1. Create a new database in SQL Server (mine is called OData). 
2. Create the Locations table by running the `sql/setup.sql` script.
3. Add a few records to it by running the `sql/populate.sql` script.
4. Set up your SQL connection by editing the `DataContextFactory.cs` file.
5. Run the application.

You should be able to access `/odata/locations` without error. Assuming you can do so, attempt to get all of the distinct values for the `PersonResponsible` field by issuing `/odata/locations?$applyto=groupby((PersonResponsible))`. When I do so, I get

> System.NotSupportedException: Comparison operators not supported for type 
> 'System.Collections.Generic.Dictionary`2[System.String,System.Object]'.

at the end of a very long call stack.

In `LocationsController.cs` I have left behind a little in-memory version of the Locations table so you can see that LINQ-to-Objects seems to handle this just fine.