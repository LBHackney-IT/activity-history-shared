using Hackney.Shared.ActivityHistory.Domain;
using Hackney.Shared.ActivityHistory.Factories;
using FluentAssertions;
using Xunit;

namespace Hackney.Shared.ActivityHistory.Tests.Factories
{
    public class ResponseFactoryTest
    {
        [Fact]
        public void CanMapADatabaseEntityToADomainObject()
        {
            var domain = new ActivityHistoryEntity();
            var response = domain.ToResponse();
            response.AuthorDetails.Should().Be(domain.AuthorDetails);
            response.CreatedAt.Should().Be(domain.CreatedAt);
            response.Id.Should().Be(domain.Id);
            response.NewData.Should().BeEquivalentTo(domain.NewData);
            response.OldData.Should().BeEquivalentTo(domain.OldData);
            response.TimetoLiveForRecord.Should().Be(domain.TimetoLiveForRecord);
            response.Type.Should().Be(domain.Type);
            response.SourceDomain.Should().Be(domain.SourceDomain);
        }
    }
}
