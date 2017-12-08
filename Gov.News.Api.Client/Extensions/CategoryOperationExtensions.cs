

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;


    /// <summary>
    /// Additional Extension methods for EditionOperationExtensions.
    /// </summary>
    public static partial class CategoryOperationExtensions
    {

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>



        public static IDictionary<string, Post> GetTopPosts(this ICategoryOperations operations, string kind, IList<string> categories)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICategoryOperations)s).GetTopPostsAsync(kind, categories), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IDictionary<string, Post>> GetTopPostsAsync(this ICategoryOperations operations, string kind, System.Collections.Generic.IList<string> categories, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetTopPostsWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, kind, categories, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IDictionary<string, Post> GetFeaturePosts(this ICategoryOperations operations, string kind, IList<string> categories)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICategoryOperations)s).GetFeaturePostsAsync(kind, categories), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IDictionary<string, Post>> GetFeaturePostsAsync(this ICategoryOperations operations, string kind, IList<string> categories, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetFeaturePostsWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, kind, categories, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
