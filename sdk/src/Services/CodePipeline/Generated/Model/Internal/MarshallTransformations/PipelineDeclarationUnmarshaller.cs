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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipelineDeclaration Object
    /// </summary>  
    public class PipelineDeclarationUnmarshaller : IUnmarshaller<PipelineDeclaration, XmlUnmarshallerContext>, IUnmarshaller<PipelineDeclaration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PipelineDeclaration IUnmarshaller<PipelineDeclaration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PipelineDeclaration Unmarshall(JsonUnmarshallerContext context)
        {
            PipelineDeclaration unmarshalledObject = new PipelineDeclaration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("artifactStore", targetDepth))
                {
                    var unmarshaller = ArtifactStoreUnmarshaller.Instance;
                    unmarshalledObject.ArtifactStore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("artifactStores", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ArtifactStore, StringUnmarshaller, ArtifactStoreUnmarshaller>(StringUnmarshaller.Instance, ArtifactStoreUnmarshaller.Instance);
                    unmarshalledObject.ArtifactStores = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PipelineType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StageDeclaration, StageDeclarationUnmarshaller>(StageDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Stages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("triggers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PipelineTriggerDeclaration, PipelineTriggerDeclarationUnmarshaller>(PipelineTriggerDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Triggers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("variables", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PipelineVariableDeclaration, PipelineVariableDeclarationUnmarshaller>(PipelineVariableDeclarationUnmarshaller.Instance);
                    unmarshalledObject.Variables = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PipelineDeclarationUnmarshaller _instance = new PipelineDeclarationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipelineDeclarationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}