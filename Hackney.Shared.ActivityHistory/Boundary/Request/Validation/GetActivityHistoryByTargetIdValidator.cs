using FluentValidation;
using System;

namespace Hackney.Shared.ActivityHistory.Boundary.Request.Validation
{
    public class GetActivityHistoryByTargetIdValidator : AbstractValidator<GetActivityHistoryByTargetIdQuery>
    {
        public GetActivityHistoryByTargetIdValidator()
        {
            RuleFor(x => x.TargetId).NotNull()
                                    .NotEqual(Guid.Empty);
            RuleFor(x => x.PageSize).GreaterThan(0)
                                    .When(y => y.PageSize.HasValue);
        }
    }
}
