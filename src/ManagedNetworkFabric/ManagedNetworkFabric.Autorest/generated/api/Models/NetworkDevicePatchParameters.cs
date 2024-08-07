// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>
    /// The Network Device Patch Parameters defines the patch parameters of the resource.
    /// </summary>
    public partial class NetworkDevicePatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchParametersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdate __tagsUpdate = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.TagsUpdate();

        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inlined)]
        public string Annotation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)Property).Annotation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)Property).Annotation = value ?? null; }

        /// <summary>The host name of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inlined)]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)Property).HostName = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchParametersProperties Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NetworkDevicePatchParametersProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchParametersProperties _property;

        /// <summary>Network Device Patch properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchParametersProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NetworkDevicePatchParametersProperties()); set => this._property = value; }

        /// <summary>
        /// Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inlined)]
        public string SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)Property).SerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)Property).SerialNumber = value ?? null; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)__tagsUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)__tagsUpdate).Tag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="NetworkDevicePatchParameters" /> instance.</summary>
        public NetworkDevicePatchParameters()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__tagsUpdate), __tagsUpdate);
            await eventListener.AssertObjectIsValid(nameof(__tagsUpdate), __tagsUpdate);
        }
    }
    /// The Network Device Patch Parameters defines the patch parameters of the resource.
    public partial interface INetworkDevicePatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdate
    {
        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Switch configuration description.",
        SerializedName = @"annotation",
        PossibleTypes = new [] { typeof(string) })]
        string Annotation { get; set; }
        /// <summary>The host name of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The host name of the device.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>
        /// Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }

    }
    /// The Network Device Patch Parameters defines the patch parameters of the resource.
    internal partial interface INetworkDevicePatchParametersInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal
    {
        /// <summary>Switch configuration description.</summary>
        string Annotation { get; set; }
        /// <summary>The host name of the device.</summary>
        string HostName { get; set; }
        /// <summary>Network Device Patch properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchParametersProperties Property { get; set; }
        /// <summary>
        /// Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.
        /// </summary>
        string SerialNumber { get; set; }

    }
}