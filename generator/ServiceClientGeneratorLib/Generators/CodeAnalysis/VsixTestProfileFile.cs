﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.CodeAnalysis
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\VsixTestProfileFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class VsixTestProfileFile : VsixTestProfileFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Project ToolsVersion=\"14.0\" DefaultTarge" +
                    "ts=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\r\n  <Prop" +
                    "ertyGroup>\r\n    <MinimumVisualStudioVersion>14.0</MinimumVisualStudioVersion>\r\n " +
                    "   <VSToolsPath Condition=\"\'$(VSToolsPath)\' == \'\'\">$(MSBuildExtensionsPath32)\\Mi" +
                    "crosoft\\VisualStudio\\v$(VisualStudioVersion)</VSToolsPath>\r\n  </PropertyGroup>\r\n" +
                    "  <Import Project=\"$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Com" +
                    "mon.props\" Condition=\"Exists(\'$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Mi" +
                    "crosoft.Common.props\')\" />\r\n  <PropertyGroup>\r\n    <Configuration Condition=\" \'$" +
                    "(Configuration)\' == \'\' \">Debug</Configuration>\r\n    <Platform Condition=\" \'$(Pla" +
                    "tform)\' == \'\' \">AnyCPU</Platform>\r\n    <SchemaVersion>2.0</SchemaVersion>\r\n    <" +
                    "ProjectTypeGuids>{82b43b9b-a64c-4715-b499-d71e9ca2bd60};{FAE04EC0-301F-11D3-BF4B" +
                    "-00C04F79EFBC}</ProjectTypeGuids>\r\n    <ProjectGuid>{11EAD86F-28B2-4DD6-AA76-72B" +
                    "B3B4AE80C}</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesigner" +
                    "Folder>Properties</AppDesignerFolder>\r\n    <RootNamespace>AWSCodeAnalysisTestExt" +
                    "ension</RootNamespace>\r\n    <AssemblyName>AWSCodeAnalysisTestExtension</Assembly" +
                    "Name>\r\n    <TargetFrameworkVersion>v4.5.2</TargetFrameworkVersion>\r\n    <Generat" +
                    "ePkgDefFile>false</GeneratePkgDefFile>\r\n    <IncludeAssemblyInVSIXContainer>fals" +
                    "e</IncludeAssemblyInVSIXContainer>\r\n    <IncludeDebugSymbolsInVSIXContainer>fals" +
                    "e</IncludeDebugSymbolsInVSIXContainer>\r\n    <IncludeDebugSymbolsInLocalVSIXDeplo" +
                    "yment>false</IncludeDebugSymbolsInLocalVSIXDeployment>\r\n    <CopyBuildOutputToOu" +
                    "tputDirectory>false</CopyBuildOutputToOutputDirectory>\r\n    <CopyOutputSymbolsTo" +
                    "OutputDirectory>false</CopyOutputSymbolsToOutputDirectory>\r\n    <VSSDKTargetPlat" +
                    "formRegRootSuffix>Roslyn</VSSDKTargetPlatformRegRootSuffix>\r\n  </PropertyGroup>\r" +
                    "\n  <PropertyGroup Condition=\" \'$(Configuration)|$(Platform)\' == \'Debug|AnyCPU\' \"" +
                    ">\r\n    <DebugSymbols>true</DebugSymbols>\r\n    <DebugType>full</DebugType>\r\n    <" +
                    "Optimize>false</Optimize>\r\n    <OutputPath>bin\\Debug\\</OutputPath>\r\n    <DefineC" +
                    "onstants>DEBUG;TRACE</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n " +
                    "   <WarningLevel>4</WarningLevel>\r\n  </PropertyGroup>\r\n  <PropertyGroup Conditio" +
                    "n=\" \'$(Configuration)|$(Platform)\' == \'Release|AnyCPU\' \">\r\n    <DebugType>pdbonl" +
                    "y</DebugType>\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>bin\\Release\\</Outp" +
                    "utPath>\r\n    <DefineConstants>TRACE</DefineConstants>\r\n    <ErrorReport>prompt</" +
                    "ErrorReport>\r\n    <WarningLevel>4</WarningLevel>\r\n  </PropertyGroup>\r\n  <Propert" +
                    "yGroup>\t\t\t\t\r\n    <StartAction>Program</StartAction>\r\n    <StartProgram>$(DevEnvD" +
                    "ir)devenv.exe</StartProgram>\r\n    <StartArguments>/rootsuffix Roslyn</StartArgum" +
                    "ents>\r\n  </PropertyGroup>\r\n  <ItemGroup>\r\n    <None Include=\"source.extension.vs" +
                    "ixmanifest\">\r\n      <SubType>Designer</SubType>\r\n    </None>\r\n  </ItemGroup>\r\n  " +
                    "<ItemGroup>\r\n");
            
            #line 60 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\VsixTestProfileFile.tt"

    foreach(var project in (List<CodeAnalysisSolutionCreator.Project>)this.Session["CodeAnalysisProjects"])
    {

            
            #line default
            #line hidden
            this.Write("    <ProjectReference Include=\"../ServiceAnalysis/");
            
            #line 64 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\VsixTestProfileFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ShortName));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 64 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\VsixTestProfileFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write(".csproj\">\r\n      <Project>");
            
            #line 65 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\VsixTestProfileFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n      <Name>");
            
            #line 66 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\VsixTestProfileFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(project.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n");
            
            #line 68 "C:\codebase\v3-master\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\CodeAnalysis\VsixTestProfileFile.tt"

    }

            
            #line default
            #line hidden
            this.Write(@"  </ItemGroup>
  <Import Project=""$(MSBuildToolsPath)\Microsoft.CSharp.targets"" />
  <Import Project=""$(VSToolsPath)\VSSDK\Microsoft.VsSDK.targets"" Condition=""'$(VSToolsPath)' != ''"" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=""BeforeBuild"">
  </Target>
  <Target Name=""AfterBuild"">
  </Target>
  -->
</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class VsixTestProfileFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
