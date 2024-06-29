using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordlist.Helpers
{
    public static class PathHelper
    {
        public static string GetValidatedFilePath(string path)
        {
            var fullPath = GetFullPath(path);

            if (!IsValidPath(fullPath))
            {
                throw new ArgumentException($"The file  path is not valid.", nameof(path));
            }

            if (!File.Exists(fullPath))
            {
                throw new ArgumentException($"The file path does not exist.", fullPath);
            }

            return fullPath;
        }


        public static bool IsValidPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("The file path is null or empty.", nameof(path));
            }

            if (!Path.IsPathFullyQualified(path))
            {
                throw new ArgumentException("The file path is not fully qualified.", nameof(path));
            }
            return true;
        }

        public static string GetFullPath(string path)
        {
            try
            {
                return Path.GetFullPath(path);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occured while getting full path for '{path}': {ex.Message}");
            }
        }
    }
}
