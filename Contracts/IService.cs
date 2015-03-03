using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MyWcfSerLib.Contracts
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        System.IO.Stream ReadImg();

        [OperationContract]
        void ReceiveImg(System.IO.Stream stream);
    }
}