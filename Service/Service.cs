using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Web;
using System.Drawing;
using System.Diagnostics;

namespace MyWcfSerLib.Service
{
    public class Service : Contracts.IService
    {
        [WebInvoke(Method = "*", UriTemplate = "ReadImg")]
        public System.IO.Stream ReadImg()
        {
            string runDir = System.Environment.CurrentDirectory;
            string imgFilePath = System.IO.Path.Combine(runDir, "jillzhanglogo.jpg");
            System.IO.FileStream fs = new System.IO.FileStream(imgFilePath, System.IO.FileMode.Open);
            System.Threading.Thread.Sleep(2000);
            WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            return fs;
        }

        [WebInvoke(Method = "*", UriTemplate = "ReceiveImg")]
        public void ReceiveImg(System.IO.Stream stream)
        {
            Debug.WriteLine(WebOperationContext.Current.IncomingRequest.ContentType);
            System.Threading.Thread.Sleep(7000);
            string runDir = System.Environment.CurrentDirectory;
            string imgFilePath = System.IO.Path.Combine(runDir, "ReceiveImg.jpg");
            Image bmp = Bitmap.FromStream(stream);
            bmp.Save(imgFilePath);
        }
    }
}