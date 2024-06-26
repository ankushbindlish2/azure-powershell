// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Support
{

    /// <summary>
    /// For more information see [setting the AKS cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel).
    /// </summary>
    public partial struct UpgradeChannel :
        System.IEquatable<UpgradeChannel>
    {
        /// <summary>
        /// Automatically upgrade the node image to the latest version available. Microsoft provides patches and new images for image
        /// nodes frequently (usually weekly), but your running nodes won't get the new images unless you do a node image upgrade.
        /// Turning on the node-image channel will automatically update your node images whenever a new version is available.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel NodeImage = @"node-image";

        /// <summary>
        /// Disables auto-upgrades and keeps the cluster at its current version of Kubernetes.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel None = @"none";

        /// <summary>
        /// Automatically upgrade the cluster to the latest supported patch version when it becomes available while keeping the minor
        /// version the same. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1
        /// are available, your cluster is upgraded to 1.17.9.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel Patch = @"patch";

        /// <summary>
        /// Automatically upgrade the cluster to the latest supported patch release on the latest supported minor version. In cases
        /// where the cluster is at a version of Kubernetes that is at an N-2 minor version where N is the latest supported minor
        /// version, the cluster first upgrades to the latest supported patch version on N-1 minor version. For example, if a cluster
        /// is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster first is upgraded
        /// to 1.18.6, then is upgraded to 1.19.1.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel Rapid = @"rapid";

        /// <summary>
        /// Automatically upgrade the cluster to the latest supported patch release on minor version N-1, where N is the latest supported
        /// minor version. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are
        /// available, your cluster is upgraded to 1.18.6.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel Stable = @"stable";

        /// <summary>the value for an instance of the <see cref="UpgradeChannel" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to UpgradeChannel</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpgradeChannel" />.</param>
        internal static object CreateFrom(object value)
        {
            return new UpgradeChannel(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type UpgradeChannel</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type UpgradeChannel (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is UpgradeChannel && Equals((UpgradeChannel)obj);
        }

        /// <summary>Returns hashCode for enum UpgradeChannel</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for UpgradeChannel</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="UpgradeChannel"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private UpgradeChannel(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to UpgradeChannel</summary>
        /// <param name="value">the value to convert to an instance of <see cref="UpgradeChannel" />.</param>

        public static implicit operator UpgradeChannel(string value)
        {
            return new UpgradeChannel(value);
        }

        /// <summary>Implicit operator to convert UpgradeChannel to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="UpgradeChannel" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum UpgradeChannel</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum UpgradeChannel</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.UpgradeChannel e2)
        {
            return e2.Equals(e1);
        }
    }
}