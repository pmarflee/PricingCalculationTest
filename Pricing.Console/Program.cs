using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricing.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var currencyCode = args[0];

            var getCurrencyQueryHandler = new GetCurrencyQueryHandler();
            var currency = getCurrencyQueryHandler.Handle(new GetCurrencyQuery {
                Code = currencyCode
            });
            
            var getTourDeparturesQueryHandler = new GetTourDeparturesQueryHandler();
            var tourDepartures = getTourDeparturesQueryHandler.Handle(new GetTourDeparturesQuery());

            var getExchangeRatesQueryHandler = new GetExchangeRatesQueryHandler();
            var exchangeRates = getExchangeRatesQueryHandler.Handle(new GetExchangeRatesQuery {
                To = currency
            });

            var getMarkupRateQueryHandler = new GetMarkupRateQueryHandler();

            foreach (var tourDeparture in tourDepartures)
            {
                var exchangeRate = exchangeRates.First(rate => rate.From == tourDeparture.LocalCost.Currency);
                var convertedCost = exchangeRate.Convert(tourDeparture.LocalCost);
                var markupRate = getMarkupRateQueryHandler.Handle(new GetMarkupRateQuery
                {
                    Currency = currency,
                    From = tourDeparture.F
                });
            }
        }
    }
}
