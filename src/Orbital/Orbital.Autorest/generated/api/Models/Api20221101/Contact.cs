// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>Customer creates a contact resource for a spacecraft resource.</summary>
    public partial class Contact :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContact,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.Resource();

        /// <summary>
        /// The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string AntennaConfigurationDestinationIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).AntennaConfigurationDestinationIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).AntennaConfigurationDestinationIP = value ?? null; }

        /// <summary>List of Source IP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string[] AntennaConfigurationSourceIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).AntennaConfigurationSourceIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).AntennaConfigurationSourceIP = value ?? null /* arrayOf */; }

        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? EndAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).EndAzimuthDegree; }

        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? EndElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).EndElevationDegree; }

        /// <summary>Any error message while scheduling a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ErrorMessage; }

        /// <summary>Azure Ground Station name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 1)]
        public string GroundStationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).GroundStationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).GroundStationName = value ; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Id; }

        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? MaximumElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).MaximumElevationDegree; }

        /// <summary>Internal Acessors for AntennaConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesAntennaConfiguration Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.AntennaConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).AntennaConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).AntennaConfiguration = value; }

        /// <summary>Internal Acessors for EndAzimuthDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.EndAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).EndAzimuthDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).EndAzimuthDegree = value; }

        /// <summary>Internal Acessors for EndElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.EndElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).EndElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).EndElevationDegree = value; }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ErrorMessage = value; }

        /// <summary>Internal Acessors for MaximumElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.MaximumElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).MaximumElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).MaximumElevationDegree = value; }

        /// <summary>Internal Acessors for Profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.Profile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ContactProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ContactProfile = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsProperties Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.ContactsProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for RxEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.RxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).RxEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).RxEndTime = value; }

        /// <summary>Internal Acessors for RxStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.RxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).RxStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).RxStartTime = value; }

        /// <summary>Internal Acessors for StartAzimuthDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.StartAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).StartAzimuthDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).StartAzimuthDegree = value; }

        /// <summary>Internal Acessors for StartElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.StartElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).StartElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).StartElevationDegree = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.ContactsStatus? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for TxEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.TxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).TxEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).TxEndTime = value; }

        /// <summary>Internal Acessors for TxStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactInternal.TxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).TxStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).TxStartTime = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Name; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string ProfileId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ContactProfileId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ContactProfileId = value ; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsProperties _property;

        /// <summary>Properties of the Contact Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.ContactsProperties()); set => this._property = value; }

        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Reservation end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 4)]
        public global::System.DateTime ReservationEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ReservationEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ReservationEndTime = value ; }

        /// <summary>Reservation start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 3)]
        public global::System.DateTime ReservationStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ReservationStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).ReservationStartTime = value ; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 5)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Receive end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? RxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).RxEndTime; }

        /// <summary>Receive start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? RxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).RxStartTime; }

        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? StartAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).StartAzimuthDegree; }

        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? StartElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).StartElevationDegree; }

        /// <summary>Status of a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 2)]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.ContactsStatus? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).Status; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType? SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType? SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.CreatedByType)""); }

        /// <summary>Transmit end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? TxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).TxEndTime; }

        /// <summary>Transmit start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? TxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesInternal)Property).TxStartTime; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Contact" /> instance.</summary>
        public Contact()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Customer creates a contact resource for a spacecraft resource.
    public partial interface IContact :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResource
    {
        /// <summary>
        /// The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.",
        SerializedName = @"destinationIp",
        PossibleTypes = new [] { typeof(string) })]
        string AntennaConfigurationDestinationIP { get; set; }
        /// <summary>List of Source IP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of Source IP",
        SerializedName = @"sourceIps",
        PossibleTypes = new [] { typeof(string) })]
        string[] AntennaConfigurationSourceIP { get; set; }
        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azimuth of the antenna at the end of the contact in decimal degrees.",
        SerializedName = @"endAzimuthDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? EndAzimuthDegree { get;  }
        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Spacecraft elevation above the horizon at contact end.",
        SerializedName = @"endElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? EndElevationDegree { get;  }
        /// <summary>Any error message while scheduling a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Any error message while scheduling a contact.",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get;  }
        /// <summary>Azure Ground Station name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Azure Ground Station name.",
        SerializedName = @"groundStationName",
        PossibleTypes = new [] { typeof(string) })]
        string GroundStationName { get; set; }
        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Maximum elevation of the antenna during the contact in decimal degrees.",
        SerializedName = @"maximumElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? MaximumElevationDegree { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileId { get; set; }
        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current state of the resource's creation, deletion, or modification.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>Reservation end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Reservation end time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"reservationEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime ReservationEndTime { get; set; }
        /// <summary>Reservation start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Reservation start time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"reservationStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime ReservationStartTime { get; set; }
        /// <summary>Receive end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Receive end time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"rxEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RxEndTime { get;  }
        /// <summary>Receive start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Receive start time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"rxStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RxStartTime { get;  }
        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azimuth of the antenna at the start of the contact in decimal degrees.",
        SerializedName = @"startAzimuthDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? StartAzimuthDegree { get;  }
        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Spacecraft elevation above the horizon at contact start.",
        SerializedName = @"startElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? StartElevationDegree { get;  }
        /// <summary>Status of a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Status of a contact.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.ContactsStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.ContactsStatus? Status { get;  }
        /// <summary>Transmit end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Transmit end time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"txEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TxEndTime { get;  }
        /// <summary>Transmit start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Transmit start time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"txStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TxStartTime { get;  }

    }
    /// Customer creates a contact resource for a spacecraft resource.
    internal partial interface IContactInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api30.IResourceInternal
    {
        /// <summary>The configuration associated with the allocated antenna.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsPropertiesAntennaConfiguration AntennaConfiguration { get; set; }
        /// <summary>
        /// The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.
        /// </summary>
        string AntennaConfigurationDestinationIP { get; set; }
        /// <summary>List of Source IP</summary>
        string[] AntennaConfigurationSourceIP { get; set; }
        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        float? EndAzimuthDegree { get; set; }
        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        float? EndElevationDegree { get; set; }
        /// <summary>Any error message while scheduling a contact.</summary>
        string ErrorMessage { get; set; }
        /// <summary>Azure Ground Station name.</summary>
        string GroundStationName { get; set; }
        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        float? MaximumElevationDegree { get; set; }
        /// <summary>The reference to the contact profile resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IResourceReference Profile { get; set; }
        /// <summary>Resource ID.</summary>
        string ProfileId { get; set; }
        /// <summary>Properties of the Contact Resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.Api20221101.IContactsProperties Property { get; set; }
        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Reservation end time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime ReservationEndTime { get; set; }
        /// <summary>Reservation start time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime ReservationStartTime { get; set; }
        /// <summary>Receive end time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? RxEndTime { get; set; }
        /// <summary>Receive start time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? RxStartTime { get; set; }
        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        float? StartAzimuthDegree { get; set; }
        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        float? StartElevationDegree { get; set; }
        /// <summary>Status of a contact.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Support.ContactsStatus? Status { get; set; }
        /// <summary>Transmit end time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? TxEndTime { get; set; }
        /// <summary>Transmit start time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? TxStartTime { get; set; }

    }
}