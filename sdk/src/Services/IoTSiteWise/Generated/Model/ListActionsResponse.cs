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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the ListActions operation.
    /// </summary>
    public partial class ListActionsResponse : AmazonWebServiceResponse
    {
        private List<ActionSummary> _actionSummaries = new List<ActionSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ActionSummaries. 
        /// <para>
        /// A list that summarizes the actions associated with the specified asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ActionSummary> ActionSummaries
        {
            get { return this._actionSummaries; }
            set { this._actionSummaries = value; }
        }

        // Check to see if ActionSummaries property is set
        internal bool IsSetActionSummaries()
        {
            return this._actionSummaries != null && this._actionSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no additional results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}