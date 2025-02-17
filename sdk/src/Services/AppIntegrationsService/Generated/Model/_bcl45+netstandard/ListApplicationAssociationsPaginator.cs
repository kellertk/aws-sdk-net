/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Base class for ListApplicationAssociations paginators.
    /// </summary>
    internal sealed partial class ListApplicationAssociationsPaginator : IPaginator<ListApplicationAssociationsResponse>, IListApplicationAssociationsPaginator
    {
        private readonly IAmazonAppIntegrationsService _client;
        private readonly ListApplicationAssociationsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListApplicationAssociationsResponse> Responses => new PaginatedResponse<ListApplicationAssociationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the ApplicationAssociations
        /// </summary>
        public IPaginatedEnumerable<ApplicationAssociationSummary> ApplicationAssociations => 
            new PaginatedResultKeyResponse<ListApplicationAssociationsResponse, ApplicationAssociationSummary>(this, (i) => i.ApplicationAssociations);

        internal ListApplicationAssociationsPaginator(IAmazonAppIntegrationsService client, ListApplicationAssociationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListApplicationAssociationsResponse> IPaginator<ListApplicationAssociationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListApplicationAssociationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListApplicationAssociations(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListApplicationAssociationsResponse> IPaginator<ListApplicationAssociationsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListApplicationAssociationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListApplicationAssociationsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}