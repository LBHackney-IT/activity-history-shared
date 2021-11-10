using System.Text.Json.Serialization;

namespace Hackney.Shared.ActivityHistory.Domain
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TargetType
    {
        person,
        asset,
        tenure,
        contactDetails,
        tenureActivity,
        tenurePerson,
        personEqualityInformation,
        housingApplication,
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
