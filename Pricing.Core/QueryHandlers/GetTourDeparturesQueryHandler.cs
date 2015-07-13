using Pricing.Core.Models;
using Pricing.Core.Queries;
using System;
using System.Collections.Generic;

namespace Pricing.Core.QueryHandlers
{
    public class GetTourDeparturesQueryHandler : IQueryHandler<GetTourDeparturesQuery, IEnumerable<TourDeparture>>
    {
        private static TourDeparture[] _tourDepartures = {
                                                             new TourDeparture(
                                                                 1, 
                                                                 "Agadir - Morocco", 
                                                                 new DateTime(2015, 1, 26), 
                                                                 new Price(500M, Currency.GBP)),
                                                             new TourDeparture(
                                                                 2, 
                                                                 "Agadir - Morocco", 
                                                                 new DateTime(2015, 11, 26), 
                                                                 new Price(500M, Currency.GBP)),
                                                             new TourDeparture(
                                                                 3, 
                                                                 "Algarve - Portugal", 
                                                                 new DateTime(2015, 1, 26), 
                                                                 new Price(550M, Currency.GBP)),
                                                             new TourDeparture(
                                                                 4, 
                                                                 "Algarve - Portugal", 
                                                                 new DateTime(2015, 11, 26), 
                                                                 new Price(550M, Currency.GBP)),
                                                             new TourDeparture(
                                                                 5, 
                                                                 "Corfu - Greek Islands", 
                                                                 new DateTime(2015, 1, 26), 
                                                                 new Price(700M, Currency.GBP)),
                                                             new TourDeparture(
                                                                 6, 
                                                                 "Corfu - Greek Islands", 
                                                                 new DateTime(2015, 11, 26), 
                                                                 new Price(700M, Currency.GBP)),
                                                         };

        public IEnumerable<TourDeparture> Handle(GetTourDeparturesQuery query)
        {
            // TODO: return all tour departures

            throw new NotImplementedException();
        }
    }
}
