using Microsoft.AspNetCore.Components.Forms;

namespace blazorfilehandler.Utilities
{
    public interface IFileUploadService
    {
        Task<(int, string)> UploadFileAsync(IBrowserFile file, int maxFileSize, string[] allowedExtensions);
    }
}