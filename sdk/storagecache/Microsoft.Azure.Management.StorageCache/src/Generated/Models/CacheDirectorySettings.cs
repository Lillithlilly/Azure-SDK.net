// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cache Directory Services settings.
    /// </summary>
    public partial class CacheDirectorySettings
    {
        /// <summary>
        /// Initializes a new instance of the CacheDirectorySettings class.
        /// </summary>
        public CacheDirectorySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CacheDirectorySettings class.
        /// </summary>
        /// <param name="activeDirectory">Specifies settings for joining the
        /// HPC Cache to an Active Directory domain.</param>
        /// <param name="usernameDownload">Specifies settings for Extended
        /// Groups. Extended Groups allows users to be members of more than 16
        /// groups.</param>
        public CacheDirectorySettings(CacheActiveDirectorySettings activeDirectory = default(CacheActiveDirectorySettings), CacheUsernameDownloadSettings usernameDownload = default(CacheUsernameDownloadSettings))
        {
            ActiveDirectory = activeDirectory;
            UsernameDownload = usernameDownload;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies settings for joining the HPC Cache to an
        /// Active Directory domain.
        /// </summary>
        [JsonProperty(PropertyName = "activeDirectory")]
        public CacheActiveDirectorySettings ActiveDirectory { get; set; }

        /// <summary>
        /// Gets or sets specifies settings for Extended Groups. Extended
        /// Groups allows users to be members of more than 16 groups.
        /// </summary>
        [JsonProperty(PropertyName = "usernameDownload")]
        public CacheUsernameDownloadSettings UsernameDownload { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ActiveDirectory != null)
            {
                ActiveDirectory.Validate();
            }
        }
    }
}