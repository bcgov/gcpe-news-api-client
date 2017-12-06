

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System;
    using System.Threading.Tasks;


    /// <summary>
    /// Additional Extension methods for FacebookPostOperationExtensions.
    /// </summary>
    public static partial class FacebookPageOperationExtensions
    {
        public static FacebookPage Get(this IFacebookPageOperations operations, string key)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IFacebookPageOperations)s).GetAsync(key), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// </param>
        public static async System.Threading.Tasks.Task<FacebookPage> GetAsync(this IFacebookPageOperations operations, string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetOneWithHttpMessagesAsync(key, ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
