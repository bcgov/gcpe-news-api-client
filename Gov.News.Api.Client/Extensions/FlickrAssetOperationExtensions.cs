

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System.Threading.Tasks;


    /// <summary>
    /// Additional Extension methods for FlickrAssetOperationExtensions.
    /// </summary>
    public static partial class FlickrAssetOperationExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static System.Collections.Generic.IList<FlickrAsset> GetFlickrAssets(this IFlickrAssetOperations operations, Post post)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IFlickrAssetOperations)s).GetFlickrAssetsAsync(post), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<FlickrAsset>> GetFlickrAssetsAsync(this IFlickrAssetOperations operations, Post post, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetFromPostWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, post, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        public static FlickrAsset GetFlickrAsset(this IFlickrAssetOperations operations, string key)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IFlickrAssetOperations)s).GetAsync(key), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='key'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<FlickrAsset> GetAsync(this IFlickrAssetOperations operations, string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOneWithHttpMessagesAsync(key, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

   
    }
}
