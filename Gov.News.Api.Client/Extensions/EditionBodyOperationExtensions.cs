

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System;
    using System.Threading.Tasks;


    /// <summary>
    /// Additional Extension methods for EditionOperationExtensions.
    /// </summary>
    public static partial class EditionOperationExtensions
    {


        public static EditionBody Get(this IEditionBodyOperations operations, string key)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEditionBodyOperations)s).GetAsync(key), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='key'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<EditionBody> GetAsync(this IEditionBodyOperations operations, string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOneWithHttpMessagesAsync(key, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


    }
}
