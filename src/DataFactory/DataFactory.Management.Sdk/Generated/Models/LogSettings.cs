// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Log settings.
    /// </summary>
    public partial class LogSettings
    {
        /// <summary>
        /// Initializes a new instance of the LogSettings class.
        /// </summary>
        public LogSettings()
        {
            this.LogLocationSettings = new LogLocationSettings();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogSettings class.
        /// </summary>

        /// <param name="enableCopyActivityLog">Specifies whether to enable copy activity log. Type: boolean (or Expression
        /// with resultType boolean).
        /// </param>

        /// <param name="copyActivityLogSettings">Specifies settings for copy activity log.
        /// </param>

        /// <param name="logLocationSettings">Log location settings customer needs to provide when enabling log.
        /// </param>
        public LogSettings(LogLocationSettings logLocationSettings, object enableCopyActivityLog = default(object), CopyActivityLogSettings copyActivityLogSettings = default(CopyActivityLogSettings))

        {
            this.EnableCopyActivityLog = enableCopyActivityLog;
            this.CopyActivityLogSettings = copyActivityLogSettings;
            this.LogLocationSettings = logLocationSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifies whether to enable copy activity log. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableCopyActivityLog")]
        public object EnableCopyActivityLog {get; set; }

        /// <summary>
        /// Gets or sets specifies settings for copy activity log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "copyActivityLogSettings")]
        public CopyActivityLogSettings CopyActivityLogSettings {get; set; }

        /// <summary>
        /// Gets or sets log location settings customer needs to provide when enabling
        /// log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "logLocationSettings")]
        public LogLocationSettings LogLocationSettings {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.LogLocationSettings == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "LogLocationSettings");
            }


            if (this.LogLocationSettings != null)
            {
                this.LogLocationSettings.Validate();
            }
        }
    }
}