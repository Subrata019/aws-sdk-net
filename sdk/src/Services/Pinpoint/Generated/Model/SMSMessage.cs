/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the default settings for a one-time SMS message that's sent directly to
    /// an endpoint.
    /// </summary>
    public partial class SMSMessage
    {
        private string _body;
        private string _keyword;
        private MessageType _messageType;
        private string _originationNumber;
        private string _senderId;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the SMS message.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// The SMS program name that you provided to AWS Support when you requested your dedicated
        /// number.
        /// </para>
        /// </summary>
        public string Keyword
        {
            get { return this._keyword; }
            set { this._keyword = value; }
        }

        // Check to see if Keyword property is set
        internal bool IsSetKeyword()
        {
            return this._keyword != null;
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The SMS message type. Valid values are: TRANSACTIONAL, the message is critical or
        /// time-sensitive, such as a one-time password that supports a customer transaction;
        /// and, PROMOTIONAL, the message is not critical or time-sensitive, such as a marketing
        /// message.
        /// </para>
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationNumber. 
        /// <para>
        /// The number to send the SMS message from. This value should be one of the dedicated
        /// long or short codes that's assigned to your AWS account. If you don't specify a long
        /// or short code, Amazon Pinpoint assigns a random long code to the SMS message and sends
        /// the message from that code.
        /// </para>
        /// </summary>
        public string OriginationNumber
        {
            get { return this._originationNumber; }
            set { this._originationNumber = value; }
        }

        // Check to see if OriginationNumber property is set
        internal bool IsSetOriginationNumber()
        {
            return this._originationNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// The sender ID to display as the sender of the message on a recipient's device. Support
        /// for sender IDs varies by country or region.
        /// </para>
        /// </summary>
        public string SenderId
        {
            get { return this._senderId; }
            set { this._senderId = value; }
        }

        // Check to see if SenderId property is set
        internal bool IsSetSenderId()
        {
            return this._senderId != null;
        }

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The message variables to use in the SMS message. You can override the default variables
        /// with individual address variables.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && this._substitutions.Count > 0; 
        }

    }
}