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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIdentityProvider operation.
    /// Updates IdP information for a user pool.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class UpdateIdentityProviderRequest : AmazonCognitoIdentityProviderRequest
    {
        private Dictionary<string, string> _attributeMapping = new Dictionary<string, string>();
        private List<string> _idpIdentifiers = new List<string>();
        private Dictionary<string, string> _providerDetails = new Dictionary<string, string>();
        private string _providerName;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AttributeMapping. 
        /// <para>
        /// The IdP attribute mapping to be changed.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AttributeMapping
        {
            get { return this._attributeMapping; }
            set { this._attributeMapping = value; }
        }

        // Check to see if AttributeMapping property is set
        internal bool IsSetAttributeMapping()
        {
            return this._attributeMapping != null && this._attributeMapping.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdpIdentifiers. 
        /// <para>
        /// A list of IdP identifiers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> IdpIdentifiers
        {
            get { return this._idpIdentifiers; }
            set { this._idpIdentifiers = value; }
        }

        // Check to see if IdpIdentifiers property is set
        internal bool IsSetIdpIdentifiers()
        {
            return this._idpIdentifiers != null && this._idpIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProviderDetails. 
        /// <para>
        /// The IdP details to be updated, such as <c>MetadataURL</c> and <c>MetadataFile</c>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ProviderDetails
        {
            get { return this._providerDetails; }
            set { this._providerDetails = value; }
        }

        // Check to see if ProviderDetails property is set
        internal bool IsSetProviderDetails()
        {
            return this._providerDetails != null && this._providerDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The IdP name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}