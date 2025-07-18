// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// BareMetalMachineRunCommandParameters represents the body of the request to execute a script on the bare metal machine.
    /// </summary>
    public partial class BareMetalMachineRunCommandParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineRunCommandParameters,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineRunCommandParametersInternal
    {

        /// <summary>Backing field for <see cref="Argument" /> property.</summary>
        private string[] _argument;

        /// <summary>
        /// The list of string arguments that will be passed to the script in order as separate arguments.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string[] Argument { get => this._argument; set => this._argument = value; }

        /// <summary>Backing field for <see cref="LimitTimeSecond" /> property.</summary>
        private long _limitTimeSecond;

        /// <summary>
        /// The maximum time the script is allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured,
        /// and the exit code matching a timeout will be returned (252).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long LimitTimeSecond { get => this._limitTimeSecond; set => this._limitTimeSecond = value; }

        /// <summary>Backing field for <see cref="Script" /> property.</summary>
        private string _script;

        /// <summary>The base64 encoded script to execute on the bare metal machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public string Script { get => this._script; set => this._script = value; }

        /// <summary>Creates an new <see cref="BareMetalMachineRunCommandParameters" /> instance.</summary>
        public BareMetalMachineRunCommandParameters()
        {

        }
    }
    /// BareMetalMachineRunCommandParameters represents the body of the request to execute a script on the bare metal machine.
    public partial interface IBareMetalMachineRunCommandParameters :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of string arguments that will be passed to the script in order as separate arguments.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of string arguments that will be passed to the script in order as separate arguments.",
        SerializedName = @"arguments",
        PossibleTypes = new [] { typeof(string) })]
        string[] Argument { get; set; }
        /// <summary>
        /// The maximum time the script is allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured,
        /// and the exit code matching a timeout will be returned (252).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The maximum time the script is allowed to run.
        If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured, and the exit code matching a timeout will be returned (252).",
        SerializedName = @"limitTimeSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long LimitTimeSecond { get; set; }
        /// <summary>The base64 encoded script to execute on the bare metal machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The base64 encoded script to execute on the bare metal machine.",
        SerializedName = @"script",
        PossibleTypes = new [] { typeof(string) })]
        string Script { get; set; }

    }
    /// BareMetalMachineRunCommandParameters represents the body of the request to execute a script on the bare metal machine.
    internal partial interface IBareMetalMachineRunCommandParametersInternal

    {
        /// <summary>
        /// The list of string arguments that will be passed to the script in order as separate arguments.
        /// </summary>
        string[] Argument { get; set; }
        /// <summary>
        /// The maximum time the script is allowed to run.
        /// If the execution time exceeds the maximum, the script will be stopped, any output produced until then will be captured,
        /// and the exit code matching a timeout will be returned (252).
        /// </summary>
        long LimitTimeSecond { get; set; }
        /// <summary>The base64 encoded script to execute on the bare metal machine.</summary>
        string Script { get; set; }

    }
}