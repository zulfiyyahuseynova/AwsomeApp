using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AwesomeApp.Utilies.Extension
{
    public static class FileExtension
    {
        public async static Task<string> SaveFileAsync(this IFormFile file, string savePath)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string path = Path.Combine(savePath, fileName);
            using(FileStream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}
