Pricing Calculation Test
========================

Create a console application that can display price information for a list of tour departures in a particular selling currency.

The console application should accept a single argument representing the currency code that prices should be calculated in.  It should then perform the following actions:

1. Get a list of all tour departures
2. Call an implementation of *ITourDeparturePricingService* to calculate the selling price for each tour departure in the selected selling currency
3. Display a list of the tour departure descriptions and selling prices

Each tour departure has an Id, Description, and a Local Cost.  To calculate the selling price for a tour departure, the following calculations need to be applied to the local cost:

1. Convert the local cost into a cost for the selling currency.  This can be done by finding the appropriate *ExchangeRate* and calling its **Convert** method.
2. Mark up the selling currency cost using the appropriate markup rate.  This can be done by finding the appropriate *MarkupRate* and calling its **Markup** method.  

 