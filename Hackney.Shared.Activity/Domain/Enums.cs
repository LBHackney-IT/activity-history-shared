using System.Text.Json.Serialization;

namespace Hackney.Shared.Activity.Domain
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TargetType
    {
        Activity,
        asset,
        tenure,
        contactDetails,
        tenureActivity
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActivityType
    {
        create,
        update,
        delete,
        migrate
    }
}
