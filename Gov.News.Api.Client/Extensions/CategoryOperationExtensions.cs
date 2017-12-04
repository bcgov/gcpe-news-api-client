

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
        public static IDictionary<string, Post> GetCategoryTopPosts(this ICategoryOperations operations, IList<Category> categories)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICategoryOperations)s).GetCategoryTopPostsAsync(categories), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IDictionary<string, Post>> GetCategoryTopPostsAsync(this ICategoryOperations operations, System.Collections.Generic.IList<Category> categories, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetTopPostsWithHttpMessagesAsync( ClientExtensions.currentAPIVersion, categories, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IDictionary<string, Post> GetCategoryFeaturePosts(this ICategoryOperations operations, IList<Category> categories)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICategoryOperations)s).GetCategoryFeaturePostsAsync(categories), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IDictionary<string, Post>> GetCategoryFeaturePostsAsync(this ICategoryOperations operations, IList<Category> categories, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetFeaturePostsWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, categories, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /*

        public static AzureAsset GetCategoryByKey(this ICategoryOperations operations, string key)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IArticleOperations)s).GetCategoryByKeyAsync(key), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        public static async System.Threading.Tasks.Task<Category> GetCategoryByKeyAsync(this ICategoryOperations operations, string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOneWithHttpMessagesAsync(key, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    */
    }
}
