

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
