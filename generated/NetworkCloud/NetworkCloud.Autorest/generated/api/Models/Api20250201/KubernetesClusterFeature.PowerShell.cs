// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.PowerShell;

    /// <summary>KubernetesClusterFeature represents the feature of a Kubernetes cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(KubernetesClusterFeatureTypeConverter))]
    public partial class KubernetesClusterFeature
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesClusterFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeature"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeature DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new KubernetesClusterFeature(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesClusterFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeature"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeature DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new KubernetesClusterFeature(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="KubernetesClusterFeature" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="KubernetesClusterFeature" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeature FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesClusterFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal KubernetesClusterFeature(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesClusterFeaturePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityLifecycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).AvailabilityLifecycle = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureAvailabilityLifecycle?) content.GetValueForProperty("AvailabilityLifecycle",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).AvailabilityLifecycle, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureAvailabilityLifecycle.CreateFrom);
            }
            if (content.Contains("DetailedStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureDetailedStatus?) content.GetValueForProperty("DetailedStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureDetailedStatus.CreateFrom);
            }
            if (content.Contains("DetailedStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatusMessage = (string) content.GetValueForProperty("DetailedStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("Option"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Option = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IStringKeyValuePair[]) content.GetValueForProperty("Option",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Option, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IStringKeyValuePair>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.StringKeyValuePairTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureProvisioningState.CreateFrom);
            }
            if (content.Contains("Required"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Required = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureRequired?) content.GetValueForProperty("Required",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Required, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureRequired.CreateFrom);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Version, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesClusterFeature"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal KubernetesClusterFeature(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.KubernetesClusterFeaturePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api50.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityLifecycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).AvailabilityLifecycle = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureAvailabilityLifecycle?) content.GetValueForProperty("AvailabilityLifecycle",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).AvailabilityLifecycle, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureAvailabilityLifecycle.CreateFrom);
            }
            if (content.Contains("DetailedStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatus = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureDetailedStatus?) content.GetValueForProperty("DetailedStatus",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatus, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureDetailedStatus.CreateFrom);
            }
            if (content.Contains("DetailedStatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatusMessage = (string) content.GetValueForProperty("DetailedStatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).DetailedStatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("Option"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Option = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IStringKeyValuePair[]) content.GetValueForProperty("Option",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Option, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IStringKeyValuePair>(__y, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.StringKeyValuePairTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureProvisioningState.CreateFrom);
            }
            if (content.Contains("Required"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Required = (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureRequired?) content.GetValueForProperty("Required",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Required, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.KubernetesClusterFeatureRequired.CreateFrom);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IKubernetesClusterFeatureInternal)this).Version, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// KubernetesClusterFeature represents the feature of a Kubernetes cluster.
    [System.ComponentModel.TypeConverter(typeof(KubernetesClusterFeatureTypeConverter))]
    public partial interface IKubernetesClusterFeature

    {

    }
}