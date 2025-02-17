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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the VerifySMSSandboxPhoneNumber operation.
    /// Verifies a destination phone number with a one-time password (OTP) for the calling
    /// Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// When you start using Amazon SNS to send SMS messages, your Amazon Web Services account
    /// is in the <i>SMS sandbox</i>. The SMS sandbox provides a safe environment for you
    /// to try Amazon SNS features without risking your reputation as an SMS sender. While
    /// your Amazon Web Services account is in the SMS sandbox, you can use all of the features
    /// of Amazon SNS. However, you can send SMS messages only to verified destination phone
    /// numbers. For more information, including how to move out of the sandbox to send messages
    /// without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
    /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class VerifySMSSandboxPhoneNumberRequest : AmazonSimpleNotificationServiceRequest
    {
        private string _oneTimePassword;
        private string _phoneNumber;

        /// <summary>
        /// Gets and sets the property OneTimePassword. 
        /// <para>
        /// The OTP sent to the destination number from the <c>CreateSMSSandBoxPhoneNumber</c>
        /// call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=8)]
        public string OneTimePassword
        {
            get { return this._oneTimePassword; }
            set { this._oneTimePassword = value; }
        }

        // Check to see if OneTimePassword property is set
        internal bool IsSetOneTimePassword()
        {
            return this._oneTimePassword != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The destination phone number to verify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=20)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

    }
}