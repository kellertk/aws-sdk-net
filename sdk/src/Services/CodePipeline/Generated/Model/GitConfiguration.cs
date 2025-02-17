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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// A type of trigger configuration for Git-based source actions.
    /// 
    ///  <note> 
    /// <para>
    /// You can specify the Git configuration trigger type for all third-party Git-based source
    /// actions that are supported by the <c>CodeStarSourceConnection</c> action type.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// V2 type pipelines, along with triggers on Git tags and pipeline-level variables, are
    /// not currently supported for CloudFormation and CDK resources in CodePipeline. For
    /// more information about V2 type pipelines, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/pipeline-types.html">Pipeline
    /// types</a> in the <i>CodePipeline User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GitConfiguration
    {
        private List<GitPushFilter> _push = new List<GitPushFilter>();
        private string _sourceActionName;

        /// <summary>
        /// Gets and sets the property Push. 
        /// <para>
        /// The field where the repository event that will start the pipeline, such as pushing
        /// Git tags, is specified with details.
        /// </para>
        ///  <note> 
        /// <para>
        /// Git tags is the only supported event type.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<GitPushFilter> Push
        {
            get { return this._push; }
            set { this._push = value; }
        }

        // Check to see if Push property is set
        internal bool IsSetPush()
        {
            return this._push != null && this._push.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceActionName. 
        /// <para>
        /// The name of the pipeline source action where the trigger configuration, such as Git
        /// tags, is specified. The trigger configuration will start the pipeline upon the specified
        /// change only.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only specify one trigger configuration per source action.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string SourceActionName
        {
            get { return this._sourceActionName; }
            set { this._sourceActionName = value; }
        }

        // Check to see if SourceActionName property is set
        internal bool IsSetSourceActionName()
        {
            return this._sourceActionName != null;
        }

    }
}