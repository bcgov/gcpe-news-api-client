

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System.Threading.Tasks;


    /// <summary>
    /// Additional Extension methods for Newsroom
    /// </summary>
    public static partial class NewsroomOperationExtensions
    {

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Newsroom Get(this INewsroomOperations operations)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((INewsroomOperations)s).GetAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Newsroom> GetAsync(this INewsroomOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetMethodWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
