using Pricing.Core.Models;
using Pricing.Core.Queries;
using System.Collections.Generic;

namespace Pricing.Core.QueryHandlers
{
    /// <summary>
    /// Executes a query for fetching a markup rate
    /// </summary>
    public class GetMarkupRateQueryHandler : IQueryHandler<GetMarkupRateQuery, MarkupRate>
    {
        private readonly IEnumerable<MarkupRate> _markupRates;

        public GetMarkupRateQueryHandler(IEnumerable<MarkupRate> markupRates)
        {
            _markupRates = markupRates;
        }

        /// <summary>
        /// Executes the query and returns the results
        /// </summary>
        /// <param name="query">The query to execute</param>
        /// <returns>The markup rate if found, or a null reference if there was no match</returns>
        public MarkupRate Handle(GetMarkupRateQuery query)
        {
            throw new System.NotImplementedException();
        }
    }
}