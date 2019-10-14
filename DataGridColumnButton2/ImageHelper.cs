using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class ImageHelper
    {
        /// <summary>
        /// 返回图片
        /// </summary>
        /// <param name="imagePath">完整路径</param>
        /// <returns></returns>
        public static Image FileToImage(string imagePath)
        {
            try
            {
                FileStream files = new FileStream(imagePath, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] imgByte = new byte[files.Length];
                files.Read(imgByte, 0, imgByte.Length);
                files.Close();
                if (Convert.IsDBNull(imgByte) == true)
                {
                    return null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream((byte[])imgByte);
                    if (ms.Length > 0)
                    {
                        return Image.FromStream(ms, true);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
