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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The document level statistics of an ingestion job
    /// </summary>
    public partial class IngestionJobStatistics
    {
        private long? _numberOfDocumentsDeleted;
        private long? _numberOfDocumentsFailed;
        private long? _numberOfDocumentsScanned;
        private long? _numberOfModifiedDocumentsIndexed;
        private long? _numberOfNewDocumentsIndexed;

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsDeleted. 
        /// <para>
        /// Number of deleted documents
        /// </para>
        /// </summary>
        public long NumberOfDocumentsDeleted
        {
            get { return this._numberOfDocumentsDeleted.GetValueOrDefault(); }
            set { this._numberOfDocumentsDeleted = value; }
        }

        // Check to see if NumberOfDocumentsDeleted property is set
        internal bool IsSetNumberOfDocumentsDeleted()
        {
            return this._numberOfDocumentsDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsFailed. 
        /// <para>
        /// Number of failed documents
        /// </para>
        /// </summary>
        public long NumberOfDocumentsFailed
        {
            get { return this._numberOfDocumentsFailed.GetValueOrDefault(); }
            set { this._numberOfDocumentsFailed = value; }
        }

        // Check to see if NumberOfDocumentsFailed property is set
        internal bool IsSetNumberOfDocumentsFailed()
        {
            return this._numberOfDocumentsFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDocumentsScanned. 
        /// <para>
        /// Number of scanned documents
        /// </para>
        /// </summary>
        public long NumberOfDocumentsScanned
        {
            get { return this._numberOfDocumentsScanned.GetValueOrDefault(); }
            set { this._numberOfDocumentsScanned = value; }
        }

        // Check to see if NumberOfDocumentsScanned property is set
        internal bool IsSetNumberOfDocumentsScanned()
        {
            return this._numberOfDocumentsScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfModifiedDocumentsIndexed. 
        /// <para>
        /// Number of modified documents indexed
        /// </para>
        /// </summary>
        public long NumberOfModifiedDocumentsIndexed
        {
            get { return this._numberOfModifiedDocumentsIndexed.GetValueOrDefault(); }
            set { this._numberOfModifiedDocumentsIndexed = value; }
        }

        // Check to see if NumberOfModifiedDocumentsIndexed property is set
        internal bool IsSetNumberOfModifiedDocumentsIndexed()
        {
            return this._numberOfModifiedDocumentsIndexed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfNewDocumentsIndexed. 
        /// <para>
        /// Number of indexed documents
        /// </para>
        /// </summary>
        public long NumberOfNewDocumentsIndexed
        {
            get { return this._numberOfNewDocumentsIndexed.GetValueOrDefault(); }
            set { this._numberOfNewDocumentsIndexed = value; }
        }

        // Check to see if NumberOfNewDocumentsIndexed property is set
        internal bool IsSetNumberOfNewDocumentsIndexed()
        {
            return this._numberOfNewDocumentsIndexed.HasValue; 
        }

    }
}