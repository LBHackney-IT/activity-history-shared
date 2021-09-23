using Microsoft.AspNetCore.Mvc;
using System;

namespace Hackney.Shared.Activity.Boundary.Request
{
    public class GetActivityHistoryByTargetIdQuery
    {
        [FromQuery]
        public Guid TargetId { get; set; }

        [FromQuery]
        public string PaginationToken { get; set; }

        [FromQuery]
        public int? PageSize { get; set; }
    }
}
