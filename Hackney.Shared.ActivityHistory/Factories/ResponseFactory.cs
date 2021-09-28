using System.Collections.Generic;
using System.Linq;
using Hackney.Shared.ActivityHistory.Boundary.Response;
using Hackney.Shared.ActivityHistory.Domain;

namespace Hackney.Shared.ActivityHistory.Factories
{
    public static class ResponseFactory
    {
        public static ActivityHistoryResponseObject ToResponse(this ActivityHistoryEntity domain)
        {
            return new ActivityHistoryResponseObject
            {
                Id = domain.Id,
                TargetId = domain.TargetId,
                AuthorDetails = domain.AuthorDetails,
                NewData = domain.NewData,
                TargetType = domain.TargetType,
                TimetoLiveForRecord = domain.TimetoLiveForRecord,
                OldData = domain.OldData,
                Type = domain.Type,
                CreatedAt = domain.CreatedAt,
                SourceDomain = domain.SourceDomain
            };
        }

        public static List<ActivityHistoryResponseObject> ToResponse(this IEnumerable<ActivityHistoryEntity> domainList)
        {
            if (null == domainList) return new List<ActivityHistoryResponseObject>();

            return domainList.Select(domain => domain.ToResponse()).ToList();
        }
    }
}
