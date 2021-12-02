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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplicationLayerAutomaticResponse operation.
    /// Updates an existing Shield Advanced automatic application layer DDoS mitigation configuration
    /// for the specified resource.
    /// </summary>
    public partial class UpdateApplicationLayerAutomaticResponseRequest : AmazonShieldRequest
    {
        private ResponseAction _action;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action setting that Shield Advanced should use in the WAF rules that
        /// it creates on behalf of the protected resource in response to DDoS attacks. You specify
        /// this as part of the configuration for the automatic application layer DDoS mitigation
        /// feature, when you enable or update automatic mitigation. Shield Advanced creates the
        /// WAF rules in a Shield Advanced-managed rule group, inside the web ACL that you have
        /// associated with the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResponseAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}