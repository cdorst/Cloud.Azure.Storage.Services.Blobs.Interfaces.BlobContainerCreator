// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using System.Threading.Tasks;

namespace Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerCreator
{
    /// <summary>Interface for service responsible for creating a blob container</summary>
    public interface IBlobContainerCreator
    {
        /// <summary>Returns the Azure Storage account instance</summary>
        Task CreateContainer(string containerName);
    }
}
