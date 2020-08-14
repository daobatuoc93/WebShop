using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.ApplicationService_Domain_.Catalog.Common
{
    public interface IStorageService
    {
        string GetFileUrl(string Name);
        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);
        Task DeleteFileAsync(string fileName);
    }
}
