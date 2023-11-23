using Microsoft.AspNetCore.Http;

namespace BirdSellingAPI._4._Core.Helper
{
    public static class ImageHandler
    {
        public static string UploadImageToFile(IWebHostEnvironment webHostEnvironment,IFormFile formFile, string type, string uniqueID)
        {
            if (formFile.Length > 0)
            {
                var contentPath = webHostEnvironment.ContentRootPath;
                var folderPath = Path.Combine(contentPath, "Uploads", type);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                var extentionFile = Path.GetExtension(formFile.FileName);
                var filePath = Path.Combine(folderPath, uniqueID + extentionFile);
                var returnFilePath = Path.Combine("Uploads", type, uniqueID + extentionFile);
                var count = 0;
                while (File.Exists(filePath))
                {
                    count = count + 1;
                    var newFileName = uniqueID + "_" + count;
                    filePath = Path.Combine(folderPath, newFileName + extentionFile);
                    returnFilePath = Path.Combine("Uploads", type, newFileName + extentionFile);
                }
                using (var stream = System.IO.File.Create(filePath))
                {
                    formFile.CopyTo(stream);
                }
                return returnFilePath;
            }
            return null;
        }

        //public static byte[] loadFile (IWebHostEnvironment webHostEnvironment, string imagePath)
        //{
        //    string imageUrl = string.Empty;
        //    string hostUrl = $"{webHostEnvironment.WebRootPath}/{imagePath}";
        //    // Check if the image file exists.
        //    if (!System.IO.File.Exists(imagePath))
        //    {
        //        return null;
        //    }
        //    // Read the image file into a byte array.
        //    return System.IO.File.ReadAllBytes(imagePath);
        //}

    }
}
