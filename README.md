PRICING CALCULATION TEST
========================

The `Pricing.Tests` project contains a number of unit tests which are currenctly failing because of methods in the Pricing.Core project that are not implemented.  

Complete the implementation of the methods in the `Pricing.Core` project to get the failing unit tests to pass.  No other code in the solution needs to be changed in order to complete the exercise.

Exchange Rates
--------------

### Exchange Rate Conversion Tests
Implement the `Convert` method of the `ExchangeRate` class so that a price in one currency can be converted to its equivalent in another currency.

### Get Exchange Rate Tests
Implement the `Handle` method of the `GetExchangeRateQueryHandler` class so that an exchange rate can be found in a collection of exchange rates based on the given set of criteria.

Markup Rates
------------

### Markup Calculation Tests
Implement the `Markup` method of the `MarkupRate` class so that a price can be marked up by a given percentage rate.  Percentage rates are expressed as a value between 0 and 100.

### Get Markup Rate Tests
Implement the `Handle` method of the `GetMarkupRateQueryHandler` class so that a markup rate can be found in a collection of markup rates based on the given set of criteria.

Tour Departure Price Calculation Tests
--------------------------------------

Use the methods you have implemented thus far to calculate the selling price of a tour departure.

If an currency conversion is required, the appropriate exchange rate should be found and then used to convert the price from the local currency to the selling currency.

To get the selling price for the tour departure, the appropriate markup rate should be found and then applied to the cost price.
