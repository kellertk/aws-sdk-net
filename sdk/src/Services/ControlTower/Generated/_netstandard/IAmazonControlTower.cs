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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ControlTower.Model;

namespace Amazon.ControlTower
{
    /// <summary>
    /// <para>Interface for accessing ControlTower</para>
    ///
    /// These interfaces allow you to apply the Amazon Web Services library of pre-defined
    /// <i>controls</i> to your organizational units, programmatically. In Amazon Web Services
    /// Control Tower, the terms "control" and "guardrail" are synonyms.
    /// 
    ///  
    /// <para>
    /// To call these APIs, you'll need to know:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// the <c>controlIdentifier</c> for the control--or guardrail--you are targeting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// the ARN associated with the target organizational unit (OU), which we call the <c>targetIdentifier</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// the ARN associated with a resource that you wish to tag or untag.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>To get the <c>controlIdentifier</c> for your Amazon Web Services Control Tower
    /// control:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>controlIdentifier</c> is an ARN that is specified for each control. You can
    /// view the <c>controlIdentifier</c> in the console on the <b>Control details</b> page,
    /// as well as in the documentation.
    /// </para>
    ///  
    /// <para>
    /// The <c>controlIdentifier</c> is unique in each Amazon Web Services Region for each
    /// control. You can find the <c>controlIdentifier</c> for each Region and control in
    /// the <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-metadata-tables.html">Tables
    /// of control metadata</a> in the <i>Amazon Web Services Control Tower User Guide.</i>
    /// 
    /// </para>
    ///  
    /// <para>
    /// A quick-reference list of control identifers for the Amazon Web Services Control Tower
    /// legacy <i>Strongly recommended</i> and <i>Elective</i> controls is given in <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html.html">Resource
    /// identifiers for APIs and controls</a> in the <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html">Controls
    /// reference guide section</a> of the <i>Amazon Web Services Control Tower User Guide</i>.
    /// Remember that <i>Mandatory</i> controls cannot be added or removed.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>ARN format:</b> <c>arn:aws:controltower:{REGION}::control/{CONTROL_NAME}</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:aws:controltower:us-west-2::control/AWS-GR_AUTOSCALING_LAUNCH_CONFIG_PUBLIC_IP_DISABLED</c>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>To get the <c>targetIdentifier</c>:</b> 
    /// </para>
    ///  
    /// <para>
    /// The <c>targetIdentifier</c> is the ARN for an OU.
    /// </para>
    ///  
    /// <para>
    /// In the Amazon Web Services Organizations console, you can find the ARN for the OU
    /// on the <b>Organizational unit details</b> page associated with that OU.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>OU ARN format:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:${Partition}:organizations::${MasterAccountId}:ou/o-${OrganizationId}/ou-${OrganizationalUnitId}</c>
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Details and examples</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">Control
    /// API input and output examples with CLI</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/enable-controls.html">Enable
    /// controls with CloudFormation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-metadata-tables.html">Control
    /// metadata tables</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-identifiers.html">List
    /// of identifiers for legacy controls</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/controls.html">Controls
    /// reference guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/controls-reference.html">Controls
    /// library groupings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controltower/latest/userguide/creating-resources-with-cloudformation.html">Creating
    /// Amazon Web Services Control Tower resources with Amazon Web Services CloudFormation</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To view the open source resource repository on GitHub, see <a href="https://github.com/aws-cloudformation/aws-cloudformation-resource-providers-controltower">aws-cloudformation/aws-cloudformation-resource-providers-controltower</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Control Tower supports Amazon Web Services CloudTrail, a service
    /// that records Amazon Web Services API calls for your Amazon Web Services account and
    /// delivers log files to an Amazon S3 bucket. By using information collected by CloudTrail,
    /// you can determine which requests the Amazon Web Services Control Tower service received,
    /// who made the request and when, and so on. For more about Amazon Web Services Control
    /// Tower and its support for CloudTrail, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/logging-using-cloudtrail.html">Logging
    /// Amazon Web Services Control Tower Actions with Amazon Web Services CloudTrail</a>
    /// in the Amazon Web Services Control Tower User Guide. To learn more about CloudTrail,
    /// including how to turn it on and find your log files, see the Amazon Web Services CloudTrail
    /// User Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonControlTower : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IControlTowerPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateLandingZone



        /// <summary>
        /// Creates a new landing zone. This API call starts an asynchronous operation that creates
        /// and configures a landing zone, based on the parameters specified in the manifest JSON
        /// file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/CreateLandingZone">REST API Reference for CreateLandingZone Operation</seealso>
        Task<CreateLandingZoneResponse> CreateLandingZoneAsync(CreateLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLandingZone



        /// <summary>
        /// Decommissions a landing zone. This API call starts an asynchronous operation that
        /// deletes Amazon Web Services Control Tower resources deployed in accounts managed by
        /// Amazon Web Services Control Tower.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DeleteLandingZone">REST API Reference for DeleteLandingZone Operation</seealso>
        Task<DeleteLandingZoneResponse> DeleteLandingZoneAsync(DeleteLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableControl



        /// <summary>
        /// This API call turns off a control. It starts an asynchronous operation that deletes
        /// Amazon Web Services resources on the specified organizational unit and the accounts
        /// it contains. The resources will vary according to the control that you specify. For
        /// usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/DisableControl">REST API Reference for DisableControl Operation</seealso>
        Task<DisableControlResponse> DisableControlAsync(DisableControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableControl



        /// <summary>
        /// This API call activates a control. It starts an asynchronous operation that creates
        /// Amazon Web Services resources on the specified organizational unit and the accounts
        /// it contains. The resources created will vary according to the control that you specify.
        /// For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/EnableControl">REST API Reference for EnableControl Operation</seealso>
        Task<EnableControlResponse> EnableControlAsync(EnableControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetControlOperation



        /// <summary>
        /// Returns the status of a particular <c>EnableControl</c> or <c>DisableControl</c> operation.
        /// Displays a message in case of error. Details for an operation are available for 90
        /// days. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetControlOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetControlOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetControlOperation">REST API Reference for GetControlOperation Operation</seealso>
        Task<GetControlOperationResponse> GetControlOperationAsync(GetControlOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnabledControl



        /// <summary>
        /// Retrieves details about an enabled control. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetEnabledControl">REST API Reference for GetEnabledControl Operation</seealso>
        Task<GetEnabledControlResponse> GetEnabledControlAsync(GetEnabledControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLandingZone



        /// <summary>
        /// Returns details about the landing zone. Displays a message in case of error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZone">REST API Reference for GetLandingZone Operation</seealso>
        Task<GetLandingZoneResponse> GetLandingZoneAsync(GetLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLandingZoneOperation



        /// <summary>
        /// Returns the status of the specified landing zone operation. Details for an operation
        /// are available for 60 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLandingZoneOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLandingZoneOperation service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/GetLandingZoneOperation">REST API Reference for GetLandingZoneOperation Operation</seealso>
        Task<GetLandingZoneOperationResponse> GetLandingZoneOperationAsync(GetLandingZoneOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnabledControls



        /// <summary>
        /// Lists the controls enabled by Amazon Web Services Control Tower on the specified organizational
        /// unit and the accounts it contains. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnabledControls service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListEnabledControls">REST API Reference for ListEnabledControls Operation</seealso>
        Task<ListEnabledControlsResponse> ListEnabledControlsAsync(ListEnabledControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLandingZones



        /// <summary>
        /// Returns the landing zone ARN for the landing zone deployed in your managed account.
        /// This API also creates an ARN for existing accounts that do not yet have a landing
        /// zone ARN. 
        /// 
        ///  
        /// <para>
        /// Returns one landing zone ARN.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLandingZones service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLandingZones service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListLandingZones">REST API Reference for ListLandingZones Operation</seealso>
        Task<ListLandingZonesResponse> ListLandingZonesAsync(ListLandingZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags associated with the resource. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetLandingZone



        /// <summary>
        /// This API call resets a landing zone. It starts an asynchronous operation that resets
        /// the landing zone to the parameters specified in its original configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/ResetLandingZone">REST API Reference for ResetLandingZone Operation</seealso>
        Task<ResetLandingZoneResponse> ResetLandingZoneAsync(ResetLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies tags to a resource. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a resource. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEnabledControl



        /// <summary>
        /// Updates the configuration of an already enabled control.
        /// 
        ///  
        /// <para>
        /// If the enabled control shows an <c>EnablementStatus</c> of SUCCEEDED, supply parameters
        /// that are different from the currently configured parameters. Otherwise, Amazon Web
        /// Services Control Tower will not accept the request.
        /// </para>
        ///  
        /// <para>
        /// If the enabled control shows an <c>EnablementStatus</c> of FAILED, Amazon Web Services
        /// Control Tower will update the control to match any valid parameters that you supply.
        /// </para>
        ///  
        /// <para>
        /// If the <c>DriftSummary</c> status for the control shows as DRIFTED, you cannot call
        /// this API. Instead, you can update the control by calling <c>DisableControl</c> and
        /// again calling <c>EnableControl</c>, or you can run an extending governance operation.
        /// For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/control-api-examples-short.html">
        /// <i>the Amazon Web Services Control Tower User Guide</i> </a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnabledControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnabledControl service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded. The limit is 10 concurrent
        /// operations.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateEnabledControl">REST API Reference for UpdateEnabledControl Operation</seealso>
        Task<UpdateEnabledControlResponse> UpdateEnabledControlAsync(UpdateEnabledControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLandingZone



        /// <summary>
        /// This API call updates the landing zone. It starts an asynchronous operation that updates
        /// the landing zone based on the new landing zone version, or on the changed parameters
        /// specified in the updated manifest file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLandingZone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLandingZone service method, as returned by ControlTower.</returns>
        /// <exception cref="Amazon.ControlTower.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.InternalServerException">
        /// An unexpected error occurred during processing of a request.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlTower.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controltower-2018-05-10/UpdateLandingZone">REST API Reference for UpdateLandingZone Operation</seealso>
        Task<UpdateLandingZoneResponse> UpdateLandingZoneAsync(UpdateLandingZoneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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