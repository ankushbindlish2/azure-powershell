// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties of a task run update parameters.</summary>
    public partial class TaskRunPropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskRunPropertiesUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskRunPropertiesUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="ForceUpdateTag" /> property.</summary>
        private string _forceUpdateTag;

        /// <summary>
        /// How the run should be forced to rerun even if the run request configuration has not changed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string ForceUpdateTag { get => this._forceUpdateTag; set => this._forceUpdateTag = value; }

        /// <summary>Internal Acessors for RunRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequest Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskRunPropertiesUpdateParametersInternal.RunRequest { get => (this._runRequest = this._runRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.RunRequest()); set { {_runRequest = value;} } }

        /// <summary>Backing field for <see cref="RunRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequest _runRequest;

        /// <summary>The request (parameters) for the new run</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequest RunRequest { get => (this._runRequest = this._runRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.RunRequest()); set => this._runRequest = value; }

        /// <summary>The dedicated agent pool for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RunRequestAgentPoolName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).AgentPoolName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).AgentPoolName = value ?? null; }

        /// <summary>The value that indicates whether archiving is enabled for the run or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public bool? RunRequestIsArchiveEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).IsArchiveEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).IsArchiveEnabled = value ?? default(bool); }

        /// <summary>
        /// The template that describes the repository and tag information for run log artifact.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RunRequestLogTemplate { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).LogTemplate; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).LogTemplate = value ?? null; }

        /// <summary>The type of the run request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string RunRequestType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequestInternal)RunRequest).Type = value ?? null; }

        /// <summary>Creates an new <see cref="TaskRunPropertiesUpdateParameters" /> instance.</summary>
        public TaskRunPropertiesUpdateParameters()
        {

        }
    }
    /// The properties of a task run update parameters.
    public partial interface ITaskRunPropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// How the run should be forced to rerun even if the run request configuration has not changed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"How the run should be forced to rerun even if the run request configuration has not changed",
        SerializedName = @"forceUpdateTag",
        PossibleTypes = new [] { typeof(string) })]
        string ForceUpdateTag { get; set; }
        /// <summary>The dedicated agent pool for the run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dedicated agent pool for the run.",
        SerializedName = @"agentPoolName",
        PossibleTypes = new [] { typeof(string) })]
        string RunRequestAgentPoolName { get; set; }
        /// <summary>The value that indicates whether archiving is enabled for the run or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The value that indicates whether archiving is enabled for the run or not.",
        SerializedName = @"isArchiveEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RunRequestIsArchiveEnabled { get; set; }
        /// <summary>
        /// The template that describes the repository and tag information for run log artifact.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The template that describes the repository and tag information for run log artifact.",
        SerializedName = @"logTemplate",
        PossibleTypes = new [] { typeof(string) })]
        string RunRequestLogTemplate { get; set; }
        /// <summary>The type of the run request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the run request.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string RunRequestType { get; set; }

    }
    /// The properties of a task run update parameters.
    internal partial interface ITaskRunPropertiesUpdateParametersInternal

    {
        /// <summary>
        /// How the run should be forced to rerun even if the run request configuration has not changed
        /// </summary>
        string ForceUpdateTag { get; set; }
        /// <summary>The request (parameters) for the new run</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IRunRequest RunRequest { get; set; }
        /// <summary>The dedicated agent pool for the run.</summary>
        string RunRequestAgentPoolName { get; set; }
        /// <summary>The value that indicates whether archiving is enabled for the run or not.</summary>
        bool? RunRequestIsArchiveEnabled { get; set; }
        /// <summary>
        /// The template that describes the repository and tag information for run log artifact.
        /// </summary>
        string RunRequestLogTemplate { get; set; }
        /// <summary>The type of the run request.</summary>
        string RunRequestType { get; set; }

    }
}