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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations;
using Amazon.ChimeSDKMessaging.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ChimeSDKMessaging
{
    /// <summary>
    /// Implementation for accessing ChimeSDKMessaging
    ///
    /// The Amazon Chime SDK Messaging APIs in this section allow software developers to send
    /// and receive messages in custom messaging applications. These APIs depend on the frameworks
    /// provided by the Amazon Chime SDK Identity APIs. For more information about the messaging
    /// APIs, see <a href="https://docs.aws.amazon.com/chime/latest/APIReference/API_Operations_Amazon_Chime_SDK_Messaging">Amazon
    /// Chime SDK messaging</a>
    /// </summary>
    public partial class AmazonChimeSDKMessagingClient : AmazonServiceClient, IAmazonChimeSDKMessaging
    {
        private static IServiceMetadata serviceMetadata = new AmazonChimeSDKMessagingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonChimeSDKMessagingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMessagingConfig()) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMessagingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonChimeSDKMessagingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(AmazonChimeSDKMessagingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChimeSDKMessagingClient(AWSCredentials credentials)
            : this(credentials, new AmazonChimeSDKMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMessagingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChimeSDKMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Credentials and an
        /// AmazonChimeSDKMessagingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(AWSCredentials credentials, AmazonChimeSDKMessagingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChimeSDKMessagingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChimeSDKMessagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChimeSDKMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChimeSDKMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChimeSDKMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChimeSDKMessagingClient Configuration Object</param>
        public AmazonChimeSDKMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChimeSDKMessagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IChimeSDKMessagingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChimeSDKMessagingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChimeSDKMessagingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociateChannelFlow

        internal virtual AssociateChannelFlowResponse AssociateChannelFlow(AssociateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<AssociateChannelFlowResponse>(request, options);
        }



        /// <summary>
        /// Associates a channel flow with a channel. Once associated, all messages to that channel
        /// go through channel flow processors. To stop processing, use the <code>DisassociateChannelFlow</code>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        /// Only administrators or channel moderators can associate a channel flow. The <code>x-amz-chime-bearer</code>
        /// request header is mandatory. Use the <code>AppInstanceUserArn</code> of the user that
        /// makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateChannelFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/AssociateChannelFlow">REST API Reference for AssociateChannelFlow Operation</seealso>
        public virtual Task<AssociateChannelFlowResponse> AssociateChannelFlowAsync(AssociateChannelFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateChannelFlowResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateChannelFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchCreateChannelMembership

        internal virtual BatchCreateChannelMembershipResponse BatchCreateChannelMembership(BatchCreateChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<BatchCreateChannelMembershipResponse>(request, options);
        }



        /// <summary>
        /// Adds a specified number of users to a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/BatchCreateChannelMembership">REST API Reference for BatchCreateChannelMembership Operation</seealso>
        public virtual Task<BatchCreateChannelMembershipResponse> BatchCreateChannelMembershipAsync(BatchCreateChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchCreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchCreateChannelMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<BatchCreateChannelMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChannelFlowCallback

        internal virtual ChannelFlowCallbackResponse ChannelFlowCallback(ChannelFlowCallbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChannelFlowCallbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChannelFlowCallbackResponseUnmarshaller.Instance;

            return Invoke<ChannelFlowCallbackResponse>(request, options);
        }



        /// <summary>
        /// Calls back Chime SDK Messaging with a processing response message. This should be
        /// invoked from the processor Lambda. This is a developer API.
        /// 
        ///  
        /// <para>
        /// You can return one of the following processing responses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Update message content or metadata
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deny a message
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Make no changes to the message
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChannelFlowCallback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChannelFlowCallback service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ChannelFlowCallback">REST API Reference for ChannelFlowCallback Operation</seealso>
        public virtual Task<ChannelFlowCallbackResponse> ChannelFlowCallbackAsync(ChannelFlowCallbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChannelFlowCallbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChannelFlowCallbackResponseUnmarshaller.Instance;

            return InvokeAsync<ChannelFlowCallbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannel

        internal virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }



        /// <summary>
        /// Creates a channel to which you can add users and send messages.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannelBan

        internal virtual CreateChannelBanResponse CreateChannelBan(CreateChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelBanResponseUnmarshaller.Instance;

            return Invoke<CreateChannelBanResponse>(request, options);
        }



        /// <summary>
        /// Permanently bans a member from a channel. Moderators can't add banned members to a
        /// channel. To undo a ban, you first have to <code>DeleteChannelBan</code>, and then
        /// <code>CreateChannelMembership</code>. Bans are cleaned up when you delete users or
        /// channels.
        /// 
        ///  
        /// <para>
        /// If you ban a user who is already part of a channel, that user is automatically kicked
        /// from the channel.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelBan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelBan service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelBan">REST API Reference for CreateChannelBan Operation</seealso>
        public virtual Task<CreateChannelBanResponse> CreateChannelBanAsync(CreateChannelBanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelBanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelBanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannelFlow

        internal virtual CreateChannelFlowResponse CreateChannelFlow(CreateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<CreateChannelFlowResponse>(request, options);
        }



        /// <summary>
        /// Creates a channel flow, a container for processors. Processors are AWS Lambda functions
        /// that perform actions on chat messages, such as stripping out profanity. You can associate
        /// channel flows with channels, and the processors in the channel flow then take action
        /// on all messages sent to that channel. This is a developer API.
        /// 
        ///  
        /// <para>
        /// Channel flows process the following items:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// New and updated messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Persistent and non-persistent messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Standard message type
        /// </para>
        ///  </li> </ol> <note> 
        /// <para>
        /// Channel flows don't process Control or System messages. For more information about
        /// the message types provided by Chime SDK Messaging, refer to <a href="https://docs.aws.amazon.com/chime/latest/dg/using-the-messaging-sdk.html#msg-types">Message
        /// types</a> in the <i>Amazon Chime developer guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelFlow">REST API Reference for CreateChannelFlow Operation</seealso>
        public virtual Task<CreateChannelFlowResponse> CreateChannelFlowAsync(CreateChannelFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelFlowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannelMembership

        internal virtual CreateChannelMembershipResponse CreateChannelMembership(CreateChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateChannelMembershipResponse>(request, options);
        }



        /// <summary>
        /// Adds a user to a channel. The <code>InvitedBy</code> response field is derived from
        /// the request header. A channel member can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// List messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Send messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Receive messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Edit their own messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leave the channel
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Privacy settings impact this action as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Public Channels: You do not need to be a member to list messages, but you must be
        /// a member to send messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Private Channels: You must be a member to list or send messages.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelMembership">REST API Reference for CreateChannelMembership Operation</seealso>
        public virtual Task<CreateChannelMembershipResponse> CreateChannelMembershipAsync(CreateChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannelModerator

        internal virtual CreateChannelModeratorResponse CreateChannelModerator(CreateChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<CreateChannelModeratorResponse>(request, options);
        }



        /// <summary>
        /// Creates a new <code>ChannelModerator</code>. A channel moderator can:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Add and remove other members of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove other moderators of the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add and remove user bans for the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redact messages in the channel.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// List messages in the channel.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelModerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelModerator service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/CreateChannelModerator">REST API Reference for CreateChannelModerator Operation</seealso>
        public virtual Task<CreateChannelModeratorResponse> CreateChannelModeratorAsync(CreateChannelModeratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelModeratorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelModeratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel

        internal virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }



        /// <summary>
        /// Immediately makes a channel and its memberships inaccessible and marks them for deletion.
        /// This is an irreversible process.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelBan

        internal virtual DeleteChannelBanResponse DeleteChannelBan(DeleteChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelBanResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelBanResponse>(request, options);
        }



        /// <summary>
        /// Removes a user from a channel's ban list.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelBan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelBan service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelBan">REST API Reference for DeleteChannelBan Operation</seealso>
        public virtual Task<DeleteChannelBanResponse> DeleteChannelBanAsync(DeleteChannelBanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelBanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelBanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelFlow

        internal virtual DeleteChannelFlowResponse DeleteChannelFlow(DeleteChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelFlowResponse>(request, options);
        }



        /// <summary>
        /// Deletes a channel flow, an irreversible process. This is a developer API.
        /// 
        ///  <note> 
        /// <para>
        ///  This API works only when the channel flow is not associated with any channel. To
        /// get a list of all channels that a channel flow is associated with, use the <code>ListChannelsAssociatedWithChannelFlow</code>
        /// API. Use the <code>DisassociateChannelFlow</code> API to disassociate a channel flow
        /// from all channels. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelFlow">REST API Reference for DeleteChannelFlow Operation</seealso>
        public virtual Task<DeleteChannelFlowResponse> DeleteChannelFlowAsync(DeleteChannelFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelMembership

        internal virtual DeleteChannelMembershipResponse DeleteChannelMembership(DeleteChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelMembershipResponse>(request, options);
        }



        /// <summary>
        /// Removes a member from a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMembership">REST API Reference for DeleteChannelMembership Operation</seealso>
        public virtual Task<DeleteChannelMembershipResponse> DeleteChannelMembershipAsync(DeleteChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelMessage

        internal virtual DeleteChannelMessageResponse DeleteChannelMessage(DeleteChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMessageResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelMessageResponse>(request, options);
        }



        /// <summary>
        /// Deletes a channel message. Only admins can perform this action. Deletion makes messages
        /// inaccessible immediately. A background process deletes any revisions created by <code>UpdateChannelMessage</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelMessage">REST API Reference for DeleteChannelMessage Operation</seealso>
        public virtual Task<DeleteChannelMessageResponse> DeleteChannelMessageAsync(DeleteChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelMessageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannelModerator

        internal virtual DeleteChannelModeratorResponse DeleteChannelModerator(DeleteChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelModeratorResponse>(request, options);
        }



        /// <summary>
        /// Deletes a channel moderator.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelModerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannelModerator service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DeleteChannelModerator">REST API Reference for DeleteChannelModerator Operation</seealso>
        public virtual Task<DeleteChannelModeratorResponse> DeleteChannelModeratorAsync(DeleteChannelModeratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelModeratorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelModeratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannel

        internal virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }



        /// <summary>
        /// Returns the full details of a channel in an Amazon Chime <code>AppInstance</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannelBan

        internal virtual DescribeChannelBanResponse DescribeChannelBan(DescribeChannelBanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelBanResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelBanResponse>(request, options);
        }



        /// <summary>
        /// Returns the full details of a channel ban.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelBan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelBan service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelBan">REST API Reference for DescribeChannelBan Operation</seealso>
        public virtual Task<DescribeChannelBanResponse> DescribeChannelBanAsync(DescribeChannelBanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelBanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelBanResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelBanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannelFlow

        internal virtual DescribeChannelFlowResponse DescribeChannelFlow(DescribeChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelFlowResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelFlowResponse>(request, options);
        }



        /// <summary>
        /// Returns the full details of a channel flow in an Amazon Chime <code>AppInstance</code>.
        /// This is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelFlow">REST API Reference for DescribeChannelFlow Operation</seealso>
        public virtual Task<DescribeChannelFlowResponse> DescribeChannelFlowAsync(DescribeChannelFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannelMembership

        internal virtual DescribeChannelMembershipResponse DescribeChannelMembership(DescribeChannelMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelMembershipResponse>(request, options);
        }



        /// <summary>
        /// Returns the full details of a user's channel membership.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelMembership service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembership">REST API Reference for DescribeChannelMembership Operation</seealso>
        public virtual Task<DescribeChannelMembershipResponse> DescribeChannelMembershipAsync(DescribeChannelMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannelMembershipForAppInstanceUser

        internal virtual DescribeChannelMembershipForAppInstanceUserResponse DescribeChannelMembershipForAppInstanceUser(DescribeChannelMembershipForAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipForAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelMembershipForAppInstanceUserResponse>(request, options);
        }



        /// <summary>
        /// Returns the details of a channel based on the membership of the specified <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelMembershipForAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelMembershipForAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelMembershipForAppInstanceUser">REST API Reference for DescribeChannelMembershipForAppInstanceUser Operation</seealso>
        public virtual Task<DescribeChannelMembershipForAppInstanceUserResponse> DescribeChannelMembershipForAppInstanceUserAsync(DescribeChannelMembershipForAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelMembershipForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelMembershipForAppInstanceUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelMembershipForAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannelModeratedByAppInstanceUser

        internal virtual DescribeChannelModeratedByAppInstanceUserResponse DescribeChannelModeratedByAppInstanceUser(DescribeChannelModeratedByAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelModeratedByAppInstanceUserResponse>(request, options);
        }



        /// <summary>
        /// Returns the full details of a channel moderated by the specified <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModeratedByAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelModeratedByAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModeratedByAppInstanceUser">REST API Reference for DescribeChannelModeratedByAppInstanceUser Operation</seealso>
        public virtual Task<DescribeChannelModeratedByAppInstanceUserResponse> DescribeChannelModeratedByAppInstanceUserAsync(DescribeChannelModeratedByAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelModeratedByAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannelModerator

        internal virtual DescribeChannelModeratorResponse DescribeChannelModerator(DescribeChannelModeratorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratorResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelModeratorResponse>(request, options);
        }



        /// <summary>
        /// Returns the full details of a single ChannelModerator.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelModerator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannelModerator service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DescribeChannelModerator">REST API Reference for DescribeChannelModerator Operation</seealso>
        public virtual Task<DescribeChannelModeratorResponse> DescribeChannelModeratorAsync(DescribeChannelModeratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelModeratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelModeratorResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelModeratorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateChannelFlow

        internal virtual DisassociateChannelFlowResponse DisassociateChannelFlow(DisassociateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<DisassociateChannelFlowResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a channel flow from all its channels. Once disassociated, all messages
        /// to that channel stop going through the channel flow processor.
        /// 
        ///  <note> 
        /// <para>
        /// Only administrators or channel moderators can disassociate a channel flow. The <code>x-amz-chime-bearer</code>
        /// request header is mandatory. Use the <code>AppInstanceUserArn</code> of the user that
        /// makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateChannelFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/DisassociateChannelFlow">REST API Reference for DisassociateChannelFlow Operation</seealso>
        public virtual Task<DisassociateChannelFlowResponse> DisassociateChannelFlowAsync(DisassociateChannelFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateChannelFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateChannelFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannelMessage

        internal virtual GetChannelMessageResponse GetChannelMessage(GetChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageResponseUnmarshaller.Instance;

            return Invoke<GetChannelMessageResponse>(request, options);
        }



        /// <summary>
        /// Gets the full details of a channel message.
        /// 
        ///  <note> 
        /// <para>
        /// The x-amz-chime-bearer request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.NotFoundException">
        /// One or more of the resources in the request does not exist in the system.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessage">REST API Reference for GetChannelMessage Operation</seealso>
        public virtual Task<GetChannelMessageResponse> GetChannelMessageAsync(GetChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChannelMessageStatus

        internal virtual GetChannelMessageStatusResponse GetChannelMessageStatus(GetChannelMessageStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageStatusResponseUnmarshaller.Instance;

            return Invoke<GetChannelMessageStatusResponse>(request, options);
        }



        /// <summary>
        /// Gets message status for a specified <code>messageId</code>. Use this API to determine
        /// the intermediate status of messages going through channel flow processing. The API
        /// provides an alternative to retrieving message status if the event was not received
        /// because a client wasn't connected to a websocket. 
        /// 
        ///  
        /// <para>
        /// Messages can have any one of these statuses.
        /// </para>
        ///  <dl> <dt>SENT</dt> <dd> 
        /// <para>
        /// Message processed successfully
        /// </para>
        ///  </dd> <dt>PENDING</dt> <dd> 
        /// <para>
        /// Ongoing processing
        /// </para>
        ///  </dd> <dt>FAILED</dt> <dd> 
        /// <para>
        /// Processing failed
        /// </para>
        ///  </dd> <dt>DENIED</dt> <dd> 
        /// <para>
        /// Messasge denied by the processor
        /// </para>
        ///  </dd> </dl> <note> <ul> <li> 
        /// <para>
        /// This API does not return statuses for denied messages, because we don't store them
        /// once the processor denies them. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only the message sender can invoke this API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannelMessageStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChannelMessageStatus service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetChannelMessageStatus">REST API Reference for GetChannelMessageStatus Operation</seealso>
        public virtual Task<GetChannelMessageStatusResponse> GetChannelMessageStatusAsync(GetChannelMessageStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChannelMessageStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelMessageStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetChannelMessageStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMessagingSessionEndpoint

        internal virtual GetMessagingSessionEndpointResponse GetMessagingSessionEndpoint(GetMessagingSessionEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingSessionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingSessionEndpointResponseUnmarshaller.Instance;

            return Invoke<GetMessagingSessionEndpointResponse>(request, options);
        }



        /// <summary>
        /// The details of the endpoint for the messaging session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMessagingSessionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMessagingSessionEndpoint service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/GetMessagingSessionEndpoint">REST API Reference for GetMessagingSessionEndpoint Operation</seealso>
        public virtual Task<GetMessagingSessionEndpointResponse> GetMessagingSessionEndpointAsync(GetMessagingSessionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMessagingSessionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMessagingSessionEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetMessagingSessionEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelBans

        internal virtual ListChannelBansResponse ListChannelBans(ListChannelBansRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelBansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelBansResponseUnmarshaller.Instance;

            return Invoke<ListChannelBansResponse>(request, options);
        }



        /// <summary>
        /// Lists all the users banned from a particular channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelBans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelBans service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelBans">REST API Reference for ListChannelBans Operation</seealso>
        public virtual Task<ListChannelBansResponse> ListChannelBansAsync(ListChannelBansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelBansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelBansResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelBansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelFlows

        internal virtual ListChannelFlowsResponse ListChannelFlows(ListChannelFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelFlowsResponseUnmarshaller.Instance;

            return Invoke<ListChannelFlowsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated lists of all the channel flows created under a single Chime. This
        /// is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelFlows service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelFlows">REST API Reference for ListChannelFlows Operation</seealso>
        public virtual Task<ListChannelFlowsResponse> ListChannelFlowsAsync(ListChannelFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelFlowsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelMemberships

        internal virtual ListChannelMembershipsResponse ListChannelMemberships(ListChannelMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListChannelMembershipsResponse>(request, options);
        }



        /// <summary>
        /// Lists all channel memberships in a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelMemberships service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMemberships">REST API Reference for ListChannelMemberships Operation</seealso>
        public virtual Task<ListChannelMembershipsResponse> ListChannelMembershipsAsync(ListChannelMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelMembershipsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelMembershipsForAppInstanceUser

        internal virtual ListChannelMembershipsForAppInstanceUserResponse ListChannelMembershipsForAppInstanceUser(ListChannelMembershipsForAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsForAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<ListChannelMembershipsForAppInstanceUserResponse>(request, options);
        }



        /// <summary>
        /// Lists all channels that a particular <code>AppInstanceUser</code> is a part of. Only
        /// an <code>AppInstanceAdmin</code> can call the API with a user ARN that is not their
        /// own. 
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMembershipsForAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelMembershipsForAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMembershipsForAppInstanceUser">REST API Reference for ListChannelMembershipsForAppInstanceUser Operation</seealso>
        public virtual Task<ListChannelMembershipsForAppInstanceUserResponse> ListChannelMembershipsForAppInstanceUserAsync(ListChannelMembershipsForAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMembershipsForAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMembershipsForAppInstanceUserResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelMembershipsForAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelMessages

        internal virtual ListChannelMessagesResponse ListChannelMessages(ListChannelMessagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMessagesResponseUnmarshaller.Instance;

            return Invoke<ListChannelMessagesResponse>(request, options);
        }



        /// <summary>
        /// List all the messages in a channel. Returns a paginated list of <code>ChannelMessages</code>.
        /// By default, sorted by creation timestamp in descending order.
        /// 
        ///  <note> 
        /// <para>
        /// Redacted messages appear in the results as empty, since they are only redacted, not
        /// deleted. Deleted messages do not appear in the results. This action always returns
        /// the latest version of an edited message.
        /// </para>
        ///  
        /// <para>
        /// Also, the x-amz-chime-bearer request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelMessages service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelMessages">REST API Reference for ListChannelMessages Operation</seealso>
        public virtual Task<ListChannelMessagesResponse> ListChannelMessagesAsync(ListChannelMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelMessagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelModerators

        internal virtual ListChannelModeratorsResponse ListChannelModerators(ListChannelModeratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelModeratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelModeratorsResponseUnmarshaller.Instance;

            return Invoke<ListChannelModeratorsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the moderators for a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelModerators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelModerators service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelModerators">REST API Reference for ListChannelModerators Operation</seealso>
        public virtual Task<ListChannelModeratorsResponse> ListChannelModeratorsAsync(ListChannelModeratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelModeratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelModeratorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelModeratorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannels

        internal virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }



        /// <summary>
        /// Lists all Channels created under a single Chime App as a paginated list. You can specify
        /// filters to narrow results.
        /// 
        ///  <p class="title"> <b>Functionality &amp; restrictions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use privacy = <code>PUBLIC</code> to retrieve all public channels in the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only an <code>AppInstanceAdmin</code> can set privacy = <code>PRIVATE</code> to list
        /// the private channels in an account.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelsAssociatedWithChannelFlow

        internal virtual ListChannelsAssociatedWithChannelFlowResponse ListChannelsAssociatedWithChannelFlow(ListChannelsAssociatedWithChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsAssociatedWithChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsAssociatedWithChannelFlowResponseUnmarshaller.Instance;

            return Invoke<ListChannelsAssociatedWithChannelFlowResponse>(request, options);
        }



        /// <summary>
        /// Lists all channels associated with a specified channel flow. You can associate a channel
        /// flow with multiple channels, but you can only associate a channel with one channel
        /// flow. This is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsAssociatedWithChannelFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelsAssociatedWithChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsAssociatedWithChannelFlow">REST API Reference for ListChannelsAssociatedWithChannelFlow Operation</seealso>
        public virtual Task<ListChannelsAssociatedWithChannelFlowResponse> ListChannelsAssociatedWithChannelFlowAsync(ListChannelsAssociatedWithChannelFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsAssociatedWithChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsAssociatedWithChannelFlowResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsAssociatedWithChannelFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannelsModeratedByAppInstanceUser

        internal virtual ListChannelsModeratedByAppInstanceUserResponse ListChannelsModeratedByAppInstanceUser(ListChannelsModeratedByAppInstanceUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return Invoke<ListChannelsModeratedByAppInstanceUserResponse>(request, options);
        }



        /// <summary>
        /// A list of the channels moderated by an <code>AppInstanceUser</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelsModeratedByAppInstanceUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelsModeratedByAppInstanceUser service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListChannelsModeratedByAppInstanceUser">REST API Reference for ListChannelsModeratedByAppInstanceUser Operation</seealso>
        public virtual Task<ListChannelsModeratedByAppInstanceUserResponse> ListChannelsModeratedByAppInstanceUserAsync(ListChannelsModeratedByAppInstanceUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsModeratedByAppInstanceUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsModeratedByAppInstanceUserResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsModeratedByAppInstanceUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags applied to an Amazon Chime SDK messaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RedactChannelMessage

        internal virtual RedactChannelMessageResponse RedactChannelMessage(RedactChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactChannelMessageResponseUnmarshaller.Instance;

            return Invoke<RedactChannelMessageResponse>(request, options);
        }



        /// <summary>
        /// Redacts message content, but not metadata. The message exists in the back end, but
        /// the action returns null content, and the state shows as redacted.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RedactChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RedactChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/RedactChannelMessage">REST API Reference for RedactChannelMessage Operation</seealso>
        public virtual Task<RedactChannelMessageResponse> RedactChannelMessageAsync(RedactChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RedactChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RedactChannelMessageResponseUnmarshaller.Instance;

            return InvokeAsync<RedactChannelMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendChannelMessage

        internal virtual SendChannelMessageResponse SendChannelMessage(SendChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendChannelMessageResponseUnmarshaller.Instance;

            return Invoke<SendChannelMessageResponse>(request, options);
        }



        /// <summary>
        /// Sends a message to a particular channel that the member is a part of.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  
        /// <para>
        /// Also, <code>STANDARD</code> messages can contain 4KB of data and the 1KB of metadata.
        /// <code>CONTROL</code> messages can contain 30 bytes of data and no metadata.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/SendChannelMessage">REST API Reference for SendChannelMessage Operation</seealso>
        public virtual Task<SendChannelMessageResponse> SendChannelMessageAsync(SendChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendChannelMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendChannelMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Applies the specified tags to the specified Amazon Chime SDK messaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ResourceLimitExceededException">
        /// The request exceeds the resource limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from the specified Amazon Chime SDK messaging resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel

        internal virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }



        /// <summary>
        /// Update a channel's attributes.
        /// 
        ///  
        /// <para>
        ///  <b>Restriction</b>: You can't change a channel's privacy. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannelFlow

        internal virtual UpdateChannelFlowResponse UpdateChannelFlow(UpdateChannelFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelFlowResponse>(request, options);
        }



        /// <summary>
        /// Updates channel flow attributes. This is a developer API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelFlow service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelFlow">REST API Reference for UpdateChannelFlow Operation</seealso>
        public virtual Task<UpdateChannelFlowResponse> UpdateChannelFlowAsync(UpdateChannelFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelFlowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelFlowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannelMessage

        internal virtual UpdateChannelMessageResponse UpdateChannelMessage(UpdateChannelMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelMessageResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelMessageResponse>(request, options);
        }



        /// <summary>
        /// Updates the content of a message.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelMessage service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelMessage">REST API Reference for UpdateChannelMessage Operation</seealso>
        public virtual Task<UpdateChannelMessageResponse> UpdateChannelMessageAsync(UpdateChannelMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelMessageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannelReadMarker

        internal virtual UpdateChannelReadMarkerResponse UpdateChannelReadMarker(UpdateChannelReadMarkerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelReadMarkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelReadMarkerResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelReadMarkerResponse>(request, options);
        }



        /// <summary>
        /// The details of the time when a user last read messages in a channel.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>x-amz-chime-bearer</code> request header is mandatory. Use the <code>AppInstanceUserArn</code>
        /// of the user that makes the API call as the value in the header.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelReadMarker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannelReadMarker service method, as returned by ChimeSDKMessaging.</returns>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.BadRequestException">
        /// The input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ForbiddenException">
        /// The client is permanently forbidden from making the request.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceFailureException">
        /// The service encountered an unexpected error.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.ThrottledClientException">
        /// The client exceeded its request rate limit.
        /// </exception>
        /// <exception cref="Amazon.ChimeSDKMessaging.Model.UnauthorizedClientException">
        /// The client is not currently authorized to make the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chime-sdk-messaging-2021-05-15/UpdateChannelReadMarker">REST API Reference for UpdateChannelReadMarker Operation</seealso>
        public virtual Task<UpdateChannelReadMarkerResponse> UpdateChannelReadMarkerAsync(UpdateChannelReadMarkerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelReadMarkerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelReadMarkerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelReadMarkerResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}