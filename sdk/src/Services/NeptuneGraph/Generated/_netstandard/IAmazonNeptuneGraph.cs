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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NeptuneGraph.Model;

namespace Amazon.NeptuneGraph
{
    /// <summary>
    /// <para>Interface for accessing NeptuneGraph</para>
    ///
    /// Neptune Analytics is a serverless in-memory graph database service for analytics that
    /// delivers high-performance analytics and real-time queries for any graph type. It complements
    /// the Amazon Neptune Database, an industry-leading managed graph database.
    /// </summary>
    public partial interface IAmazonNeptuneGraph : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INeptuneGraphPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelImportTask



        /// <summary>
        /// Deletes the specified import task
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGraph



        /// <summary>
        /// Creates a new Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        Task<CreateGraphResponse> CreateGraphAsync(CreateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGraphSnapshot



        /// <summary>
        /// Creates a snapshot of the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphSnapshot">REST API Reference for CreateGraphSnapshot Operation</seealso>
        Task<CreateGraphSnapshotResponse> CreateGraphSnapshotAsync(CreateGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGraphUsingImportTask



        /// <summary>
        /// Creates a new Neptune Analytics graph and imports data into it, either from Amazon
        /// Simple Storage Service (S3) or from a Neptune database or a Neptune database snapshot.
        /// 
        ///  
        /// <para>
        /// The data can be loaded from files in S3 that in either the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
        /// CSV format</a> or the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
        /// load format</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphUsingImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraphUsingImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphUsingImportTask">REST API Reference for CreateGraphUsingImportTask Operation</seealso>
        Task<CreateGraphUsingImportTaskResponse> CreateGraphUsingImportTaskAsync(CreateGraphUsingImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePrivateGraphEndpoint



        /// <summary>
        /// Create a private graph endpoint to allow private access from to the graph from within
        /// a VPC. You can attach security groups to the private graph endpoint. VPC endpoint
        /// charges apply.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreatePrivateGraphEndpoint">REST API Reference for CreatePrivateGraphEndpoint Operation</seealso>
        Task<CreatePrivateGraphEndpointResponse> CreatePrivateGraphEndpointAsync(CreatePrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGraph



        /// <summary>
        /// Deletes the specified graph. Graphs cannot be deleted if delete-protection is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        Task<DeleteGraphResponse> DeleteGraphAsync(DeleteGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGraphSnapshot



        /// <summary>
        /// Deletes the specifed graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraphSnapshot">REST API Reference for DeleteGraphSnapshot Operation</seealso>
        Task<DeleteGraphSnapshotResponse> DeleteGraphSnapshotAsync(DeleteGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePrivateGraphEndpoint



        /// <summary>
        /// Deletes a private graph endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeletePrivateGraphEndpoint">REST API Reference for DeletePrivateGraphEndpoint Operation</seealso>
        Task<DeletePrivateGraphEndpointResponse> DeletePrivateGraphEndpointAsync(DeletePrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGraph



        /// <summary>
        /// Gets information about a specified graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraph">REST API Reference for GetGraph Operation</seealso>
        Task<GetGraphResponse> GetGraphAsync(GetGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGraphSnapshot



        /// <summary>
        /// Retrieves a specified graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSnapshot">REST API Reference for GetGraphSnapshot Operation</seealso>
        Task<GetGraphSnapshotResponse> GetGraphSnapshotAsync(GetGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImportTask



        /// <summary>
        /// Retrieves a specified import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetImportTask">REST API Reference for GetImportTask Operation</seealso>
        Task<GetImportTaskResponse> GetImportTaskAsync(GetImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPrivateGraphEndpoint



        /// <summary>
        /// Retrieves information about a specified private endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetPrivateGraphEndpoint">REST API Reference for GetPrivateGraphEndpoint Operation</seealso>
        Task<GetPrivateGraphEndpointResponse> GetPrivateGraphEndpointAsync(GetPrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGraphs



        /// <summary>
        /// Lists available Neptune Analytics graphs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphs service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        Task<ListGraphsResponse> ListGraphsAsync(ListGraphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGraphSnapshots



        /// <summary>
        /// Lists available snapshots of a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphSnapshots service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphSnapshots">REST API Reference for ListGraphSnapshots Operation</seealso>
        Task<ListGraphSnapshotsResponse> ListGraphSnapshotsAsync(ListGraphSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImportTasks



        /// <summary>
        /// Lists import tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportTasks service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListImportTasks">REST API Reference for ListImportTasks Operation</seealso>
        Task<ListImportTasksResponse> ListImportTasksAsync(ListImportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPrivateGraphEndpoints



        /// <summary>
        /// Lists private endpoints for a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateGraphEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivateGraphEndpoints service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListPrivateGraphEndpoints">REST API Reference for ListPrivateGraphEndpoints Operation</seealso>
        Task<ListPrivateGraphEndpointsResponse> ListPrivateGraphEndpointsAsync(ListPrivateGraphEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetGraph



        /// <summary>
        /// Empties the data from a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ResetGraph">REST API Reference for ResetGraph Operation</seealso>
        Task<ResetGraphResponse> ResetGraphAsync(ResetGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreGraphFromSnapshot



        /// <summary>
        /// Restores a graph from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreGraphFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreGraphFromSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/RestoreGraphFromSnapshot">REST API Reference for RestoreGraphFromSnapshot Operation</seealso>
        Task<RestoreGraphFromSnapshotResponse> RestoreGraphFromSnapshotAsync(RestoreGraphFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGraph



        /// <summary>
        /// Updates the configuration of a specified Neptune Analytics graph
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UpdateGraph">REST API Reference for UpdateGraph Operation</seealso>
        Task<UpdateGraphResponse> UpdateGraphAsync(UpdateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}