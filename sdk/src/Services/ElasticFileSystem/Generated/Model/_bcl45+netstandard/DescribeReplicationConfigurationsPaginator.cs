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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Base class for DescribeReplicationConfigurations paginators.
    /// </summary>
    internal sealed partial class DescribeReplicationConfigurationsPaginator : IPaginator<DescribeReplicationConfigurationsResponse>, IDescribeReplicationConfigurationsPaginator
    {
        private readonly IAmazonElasticFileSystem _client;
        private readonly DescribeReplicationConfigurationsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeReplicationConfigurationsResponse> Responses => new PaginatedResponse<DescribeReplicationConfigurationsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Replications
        /// </summary>
        public IPaginatedEnumerable<ReplicationConfigurationDescription> Replications => 
            new PaginatedResultKeyResponse<DescribeReplicationConfigurationsResponse, ReplicationConfigurationDescription>(this, (i) => i.Replications);

        internal DescribeReplicationConfigurationsPaginator(IAmazonElasticFileSystem client, DescribeReplicationConfigurationsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<DescribeReplicationConfigurationsResponse> IPaginator<DescribeReplicationConfigurationsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeReplicationConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.DescribeReplicationConfigurations(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeReplicationConfigurationsResponse> IPaginator<DescribeReplicationConfigurationsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            DescribeReplicationConfigurationsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.DescribeReplicationConfigurationsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}