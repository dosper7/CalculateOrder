# # Simple Order Calculator
This is a simple program that given a .csv file with the product catalog in stock information calculates the total amount given the following format:

 - Path_to_catalog Product1 Quantity_P1 [Product2 Quantity_P2, ....]

The catalog format is the following [ProductID],[Stock],[Price].

**Example:**
p4,10,250.00
P10,5,175.00
P12,5,1000.00

To use the program follow the steps:

 1. Install .NET Core SDK - https://www.microsoft.com/net/download
 2. Clone this repository
 3. Execute the command **dotnet run** with the info you want.
	    **Example: dotnet run** C://catalog.csv p1 5 p2 4 p12 8
