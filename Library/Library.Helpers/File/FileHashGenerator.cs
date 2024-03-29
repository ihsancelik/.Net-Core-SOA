﻿using System;
using System.IO;
using System.Security.Cryptography;

namespace Library.Helpers.File
{
    public abstract class FileHashGenerator
    {
        public static string Generate(Stream stream)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            }
        }
    }
}
