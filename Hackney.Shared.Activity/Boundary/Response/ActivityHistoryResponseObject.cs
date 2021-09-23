using Hackney.Shared.Activity.Domain;
using System;
using System.Collections.Generic;

namespace Hackney.Shared.Activity.Boundary.Response
{
    public class ActivityHistoryResponseObject
    {
        public Guid Id { get; set; }
        public Guid TargetId { get; set; }
        public ActivityType Type { get; set; }
        public TargetType TargetType { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TimetoLiveForRecord { get; set; }
        public Dictionary<string, object> OldData { get; set; }
        public Dictionary<string, object> NewData { get; set; }
        public AuthorDetails AuthorDetails { get; set; }
        public string SourceDomain { get; set; }
    }
}
