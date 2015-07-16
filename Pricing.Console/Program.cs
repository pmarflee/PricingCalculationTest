using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pricing.Core.Models;
using Pricing.Core.Queries;
using Pricing.Core.QueryHandlers;
using Pricing.Core.Services;

namespace Pricing.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string currencyCode = null; // TODO: Read currency code from args

            var getTourDeparturesQueryHandler = new GetTourDeparturesQueryHandler();
            var getCurrencyQueryHandler = new GetCurrencyQueryHandler();

            var tourDepartues = getTourDeparturesQueryHandler.Handle(new GetTourDeparturesQuery());
            var currency = getCurrencyQueryHandler.Handle(new GetCurrencyQuery
            {
                Code = currencyCode
            });

            // TODO: Create and use tour departure pricing service to calculate prices for tour departures
            // in the specified selling currency
            // TODO: Display a list of tour departures with their prices to console out
        }
    }
}
