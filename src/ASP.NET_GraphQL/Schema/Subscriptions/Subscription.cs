using HotChocolate.Execution;
using HotChocolate.Subscriptions;

namespace ASP.NET_GraphQL.Schema.Subscriptions;

public class Subscription
{
    [Subscribe]
    public CourseResult CourseCreated([EventMessage] CourseResult course) => course;

    [Subscribe]
    public  ValueTask<ISourceStream<CourseResult>> CourseUpdated(Guid courseId, [Service] ITopicEventReceiver topicEventReceiver)
    {
        var topicName = $"{courseId}_{nameof(CourseUpdated)}";
        return topicEventReceiver.SubscribeAsync<CourseResult>(topicName);
    }
}