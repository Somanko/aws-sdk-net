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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LaunchPermissionConfiguration Marshaller
    /// </summary>       
    public class LaunchPermissionConfigurationMarshaller : IRequestMarshaller<LaunchPermissionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LaunchPermissionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetOrganizationalUnitArns())
            {
                context.Writer.WritePropertyName("organizationalUnitArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrganizationalUnitArnsListValue in requestObject.OrganizationalUnitArns)
                {
                        context.Writer.Write(requestObjectOrganizationalUnitArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOrganizationArns())
            {
                context.Writer.WritePropertyName("organizationArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrganizationArnsListValue in requestObject.OrganizationArns)
                {
                        context.Writer.Write(requestObjectOrganizationArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserGroups())
            {
                context.Writer.WritePropertyName("userGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUserGroupsListValue in requestObject.UserGroups)
                {
                        context.Writer.Write(requestObjectUserGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserIds())
            {
                context.Writer.WritePropertyName("userIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUserIdsListValue in requestObject.UserIds)
                {
                        context.Writer.Write(requestObjectUserIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LaunchPermissionConfigurationMarshaller Instance = new LaunchPermissionConfigurationMarshaller();

    }
}