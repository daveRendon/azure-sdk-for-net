// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes an OS profile.
    /// </summary>
    public partial class OSProfile
    {
        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        public OSProfile() { }

        /// <summary>
        /// Initializes a new instance of the OSProfile class.
        /// </summary>
        /// <param name="computerName">the computer name.</param>
        /// <param name="adminUsername">the admin user name.</param>
        /// <param name="adminPassword">the admin user password.</param>
        /// <param name="customData">a base-64 encoded string of custom
        /// data.</param>
        /// <param name="windowsConfiguration">the Windows Configuration of
        /// the OS profile.</param>
        /// <param name="linuxConfiguration">the Linux Configuration of the OS
        /// profile.</param>
        /// <param name="secrets">the List of certificates for addition to the
        /// VM.</param>
        public OSProfile(string computerName = default(string), string adminUsername = default(string), string adminPassword = default(string), string customData = default(string), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration), LinuxConfiguration linuxConfiguration = default(LinuxConfiguration), System.Collections.Generic.IList<VaultSecretGroup> secrets = default(System.Collections.Generic.IList<VaultSecretGroup>))
        {
            ComputerName = computerName;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
        }

        /// <summary>
        /// Gets or sets the computer name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "computerName")]
        public string ComputerName { get; set; }

        /// <summary>
        /// Gets or sets the admin user name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Gets or sets the admin user password.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets a base-64 encoded string of custom data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "customData")]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or sets the Windows Configuration of the OS profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the Linux Configuration of the OS profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the List of certificates for addition to the VM.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "secrets")]
        public System.Collections.Generic.IList<VaultSecretGroup> Secrets { get; set; }

    }
}
