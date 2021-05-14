using Amazon.CDK;
using Amazon.CDK.AWS.SQS;
namespace AwsTest
{
    public class AwsTestStack : Stack
    {
        internal AwsTestStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            // The code that defines your stack goes herevis

            var queue = new Queue(this, "MyFirstQueue", new QueueProps
            { 
            VisibilityTimeout = Duration.Seconds(10)
            });

            
        }
    }
}
