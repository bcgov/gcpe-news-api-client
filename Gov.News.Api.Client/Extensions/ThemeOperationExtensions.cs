

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System.Threading.Tasks;


    /// <summary>
    /// Additional Extension methods for ResourceLinkOperationExtensions.
    /// </summary>
    public static partial class ThemeOperationExtensions
    {
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static System.Collections.Generic.IList<Category> GetThemes(this ITheme operations)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((ITheme)s).GetThemesAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<Category>> GetThemesAsync(this ITheme operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetAllWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
