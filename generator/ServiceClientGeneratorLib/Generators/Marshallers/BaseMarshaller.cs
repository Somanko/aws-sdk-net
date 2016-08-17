﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class BaseMarshaller : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 7 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

    // Adds the neccesary namespaces for the marshaller
protected void AddCommonUsingStatements()
    {

        
        #line default
        #line hidden
        
        #line 11 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Globalization;\r\nus" +
        "ing System.IO;\r\nusing System.Text;\r\nusing System.Xml.Serialization;\r\n\r\nusing ");

        
        #line default
        #line hidden
        
        #line 19 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));

        
        #line default
        #line hidden
        
        #line 19 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".Model;\r\nusing Amazon.Runtime;\r\nusing Amazon.Runtime.Internal;\r\nusing Amazon.Runt" +
        "ime.Internal.Transform;\r\nusing Amazon.Runtime.Internal.Util;\r\n");

        
        #line default
        #line hidden
        
        #line 24 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

    }

        
        #line default
        #line hidden
        
        #line 28 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

    // Generates code to add members to the header of the request
    // If it's a custom marshaller then it calls the custom marshaller first
	protected void ProcessHeaderMembers(string variableName, IEnumerable<Member> members)
	{
		foreach(var member in members)
		{

        
        #line default
        #line hidden
        
        #line 35 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\r\n\t\t\tif(");

        
        #line default
        #line hidden
        
        #line 36 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 36 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 36 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 36 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("())\r\n");

        
        #line default
        #line hidden
        
        #line 37 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

            if (member.CustomMarshallerTransformation != null)
            {

        
        #line default
        #line hidden
        
        #line 40 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Headers[\"");

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\"] = ");

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.CustomMarshallerTransformation));

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 41 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 42 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
        
            }
            else
            {

        
        #line default
        #line hidden
        
        #line 46 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Headers[\"");

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\"] = ");

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(";\r\n");

        
        #line default
        #line hidden
        
        #line 48 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
		    }
        }
	}

    // Generates code to add the operation's requestURIMembers to the uriResourcePath
	protected void ProcessUriMembers(string variableName, Operation operation)
	{
		foreach(var member in operation.RequestUriMembers)
		{
            if (member.model.Customizations.SkipUriPropertyValidations.Contains(member.PropertyName))
            {

        
        #line default
        #line hidden
        
        #line 60 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\turiResourcePath = uriResourcePath.Replace(\"{");

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("}\", ");

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("() ? StringUtils.From");

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 61 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(") : string.Empty);\r\n");

        
        #line default
        #line hidden
        
        #line 62 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

            }
            else
            {

        
        #line default
        #line hidden
        
        #line 66 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("            if (!");

        
        #line default
        #line hidden
        
        #line 67 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 67 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 67 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 67 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("())\r\n                throw new ");

        
        #line default
        #line hidden
        
        #line 68 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseException));

        
        #line default
        #line hidden
        
        #line 68 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(\"Request object does not have required field ");

        
        #line default
        #line hidden
        
        #line 68 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 68 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(" set\");\r\n\t\t\turiResourcePath = uriResourcePath.Replace(\"{");

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("}\", StringUtils.From");

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 69 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 70 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
            }
		}
	}

	protected void ProcessRequestUri(Operation operation)
	{

        
        #line default
        #line hidden
        
        #line 77 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\tstring uriResourcePath = \"");

        
        #line default
        #line hidden
        
        #line 78 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(operation.RequestUri));

        
        #line default
        #line hidden
        
        #line 78 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\";\r\n");

        
        #line default
        #line hidden
        
        #line 79 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

		foreach(var staticQueryParam in operation.StaticQueryParameters)
		{
			if(staticQueryParam.Value != null)
			{

        
        #line default
        #line hidden
        
        #line 84 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\trequest.AddSubResource(\"");

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Key));

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\", \"");

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Value));

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 86 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
			}
			else
			{

        
        #line default
        #line hidden
        
        #line 90 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\trequest.AddSubResource(\"");

        
        #line default
        #line hidden
        
        #line 91 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(staticQueryParam.Key));

        
        #line default
        #line hidden
        
        #line 91 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 92 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
						
			}
		}
	}

    // Generates code to add any operation query members to the query string for the request
    // If the marshaller is customized, it marshalls the value before changing it to a string
	protected void ProcessQueryStringMembers(string variableName, Operation operation)
	{
		if(operation.RequestHasQueryStringMembers)		
		{
			foreach(var member in operation.RequestQueryStringMembers)
			{

        
        #line default
        #line hidden
        
        #line 105 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\r\n\t\t\tif (");

        
        #line default
        #line hidden
        
        #line 106 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 106 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 106 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 106 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("())\r\n");

        
        #line default
        #line hidden
        
        #line 107 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

                if (member.CustomMarshallerTransformation != null)
                {

        
        #line default
        #line hidden
        
        #line 110 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Parameters.Add(\"");

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\", ");

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.CustomMarshallerTransformation));

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 112 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
        
                }
                else if (member.IsMap)
                {

        
        #line default
        #line hidden
        
        #line 116 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("            {\r\n                foreach(var kvp in ");

        
        #line default
        #line hidden
        
        #line 118 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 118 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 118 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 118 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(")\r\n                {\r\n                    request.Parameters.Add(kvp.Key, kvp.Val" +
        "ue);\r\n                }\r\n            }\r\n");

        
        #line default
        #line hidden
        
        #line 123 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"

                }
                else
                {

        
        #line default
        #line hidden
        
        #line 127 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\t\t\t\trequest.Parameters.Add(\"");

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("\", StringUtils.From");

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.GetPrimitiveType()));

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("(");

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(".");

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 129 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\BaseMarshaller.tt"
			
				}
			}
		}
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
