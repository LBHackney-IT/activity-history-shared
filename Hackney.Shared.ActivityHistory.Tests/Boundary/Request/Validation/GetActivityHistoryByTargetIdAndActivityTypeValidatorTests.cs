using Hackney.Shared.ActivityHistory.Boundary.Request;
using Hackney.Shared.ActivityHistory.Boundary.Request.Validation;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Hackney.Shared.ActivityHistory.Tests.Boundary.Request.Validation
{
    public class GetActivityHistoryByTargetIdAndActivityTypeValidatorTests
    {
        private readonly GetActivityHistoryByTargetIdAndActivityTypeValidator _classUnderTest;

        public GetActivityHistoryByTargetIdAndActivityTypeValidatorTests()
        {
            _classUnderTest = new GetActivityHistoryByTargetIdAndActivityTypeValidator();
        }

        [Fact]
        public void QueryShouldNotErrorWithNoActivityType()
        {
            var query = new GetActivityHistoryByTargetIdAndActivityTypeQuery() { ActivityType = null };
            var result = _classUnderTest.TestValidate(query);
            result.ShouldNotHaveValidationErrorFor(x => x.ActivityType);
        }
    }
}
