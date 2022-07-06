﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace PruebaQr.LL
{
   public interface IQrService
    {

        dynamic CreateQr(Guid guid);

        Stream ToStream(Image image);

        Image GetImage(Uri uri);
  
    }
}
