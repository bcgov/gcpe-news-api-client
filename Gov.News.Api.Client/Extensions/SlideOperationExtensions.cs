

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System.Threading.Tasks;
  

    /// <summary>
    /// Additional Extension methods for Client.
    /// </summary>
    public static partial class SlideOperationExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static System.Collections.Generic.IList<Slide> GetSlides(this ISlideOperations operations)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISlideOperations)s).GetSlidesAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<Slide>> GetSlidesAsync(this ISlideOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetAllWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
