﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.Application.Fun.IServices
{
    public interface IFileService
    {
        Task<Stream> OpenReadAsync(string relativePath);
    }
}
