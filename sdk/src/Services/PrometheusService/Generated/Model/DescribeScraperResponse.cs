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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Represents the output of a DescribeScraper operation.
    /// </summary>
    public partial class DescribeScraperResponse : AmazonWebServiceResponse
    {
        private ScraperDescription _scraper;

        /// <summary>
        /// Gets and sets the property Scraper. 
        /// <para>
        /// The properties of the selected scrapers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScraperDescription Scraper
        {
            get { return this._scraper; }
            set { this._scraper = value; }
        }

        // Check to see if Scraper property is set
        internal bool IsSetScraper()
        {
            return this._scraper != null;
        }

    }
}