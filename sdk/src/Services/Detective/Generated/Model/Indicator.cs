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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Investigations triages indicators of compromises such as a finding and surfaces only
    /// the most critical and suspicious issues, so you can focus on high-level investigations.
    /// </summary>
    public partial class Indicator
    {
        private IndicatorDetail _indicatorDetail;
        private IndicatorType _indicatorType;

        /// <summary>
        /// Gets and sets the property IndicatorDetail. 
        /// <para>
        /// Details about the indicator of compromise.
        /// </para>
        /// </summary>
        public IndicatorDetail IndicatorDetail
        {
            get { return this._indicatorDetail; }
            set { this._indicatorDetail = value; }
        }

        // Check to see if IndicatorDetail property is set
        internal bool IsSetIndicatorDetail()
        {
            return this._indicatorDetail != null;
        }

        /// <summary>
        /// Gets and sets the property IndicatorType. 
        /// <para>
        /// The type of indicator.
        /// </para>
        /// </summary>
        public IndicatorType IndicatorType
        {
            get { return this._indicatorType; }
            set { this._indicatorType = value; }
        }

        // Check to see if IndicatorType property is set
        internal bool IsSetIndicatorType()
        {
            return this._indicatorType != null;
        }

    }
}