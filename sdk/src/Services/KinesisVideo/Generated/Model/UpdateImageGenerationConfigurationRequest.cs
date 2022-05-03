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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateImageGenerationConfiguration operation.
    /// Updates the <code>StreamInfo</code> and <code>ImageProcessingConfiguration</code>
    /// fields.
    /// </summary>
    public partial class UpdateImageGenerationConfigurationRequest : AmazonKinesisVideoRequest
    {
        private ImageGenerationConfiguration _imageGenerationConfiguration;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ImageGenerationConfiguration. 
        /// <para>
        /// The structure that contains the information required for the KVS images delivery.
        /// If the structure is null, the configuration will be deleted from the stream.
        /// </para>
        /// </summary>
        public ImageGenerationConfiguration ImageGenerationConfiguration
        {
            get { return this._imageGenerationConfiguration; }
            set { this._imageGenerationConfiguration = value; }
        }

        // Check to see if ImageGenerationConfiguration property is set
        internal bool IsSetImageGenerationConfiguration()
        {
            return this._imageGenerationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis video stream from where you want to
        /// update the image generation configuration. You must specify either the <code>StreamName</code>
        /// or the <code>StreamARN</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream from which to update the image generation configuration. You
        /// must specify either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}