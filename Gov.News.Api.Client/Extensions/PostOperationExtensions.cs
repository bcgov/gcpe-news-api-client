

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System;
    using System.Threading.Tasks;
  

    /// <summary>
    /// Additional Extension methods for Client.
    /// </summary>
    public static partial class PostOperationExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Post GetPost(this IPostOperations operations, Guid id)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetPostAsync(id), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Post> GetPostAsync(this IPostOperations operations, Guid id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOne2WithHttpMessagesAsync(id, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Post GetPost(this IPostOperations operations, string collection, string key)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetPostAsync(collection, key), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Post> GetPostAsync(this IPostOperations operations, string collection, string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOne1WithHttpMessagesAsync(collection, key, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /* can't do FeaturePost yet as DataIndex is not in the model
        
        public static Post GetFeaturePost(this IPostOperations operations, DataIndex)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetFeaturePostAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        public static async System.Threading.Tasks.Task<Post> GetFeaturePostAsync(this IPostOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetTopWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        */

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Post GetTopPost(this IPostOperations operations)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetTopPostAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Post> GetTopPostAsync(this IPostOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetTopWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
