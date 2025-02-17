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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The platform-related details about the DataSync agent, such as the version number.
    /// </summary>
    public partial class Platform
    {
        private string _version;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the DataSync agent.
        /// </para>
        ///  <important> 
        /// <para>
        /// Beginning December 7, 2023, we will discontinue version 1 DataSync agents. Check the
        /// DataSync console to see if you have affected agents. If you do, <a href="https://docs.aws.amazon.com/datasync/latest/userguide/replacing-agent.html">replace</a>
        /// those agents before then to avoid data transfer or storage discovery disruptions.
        /// If you need more help, contact <a href="https://aws.amazon.com/contact-us/">Amazon
        /// Web Services Support</a>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}