

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System;
    using System.Collections.Generic;
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



        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static Post Get(this IPostOperations operations, string reference)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetAsync(reference), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Post> GetAsync(this IPostOperations operations, string reference, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOneWithHttpMessagesAsync(reference, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IEnumerable<Post> GetTopPosts(this IPostOperations operations)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetTopPostsAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IEnumerable<Post>> GetTopPostsAsync(this IPostOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetTopPostsWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IEnumerable<Post> GetFeaturePosts(this IPostOperations operations)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetFeaturePostsAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<IEnumerable<Post>> GetFeaturePostsAsync(this IPostOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetFeaturePostsWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }



        public static Post GetPostByKey(this IPostOperations operations, string key)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPostOperations)s).GetPostByKeyAsync(key), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='key'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Post> GetPostByKeyAsync(this IPostOperations operations, string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOneWithHttpMessagesAsync(key, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
