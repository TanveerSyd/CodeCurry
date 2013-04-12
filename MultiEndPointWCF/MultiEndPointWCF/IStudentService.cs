using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace MultiEndPointWCF
{
    [ServiceContract]
    public interface IStudentService
    {
        //[OperationContract]
        //Reference.Repository.Student GetStudentById(int value);


        [OperationContract]
        //[WebGet(UriTemplate = "json/{id}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,           
            UriTemplate = "json/")]
        Student GetStudent();


        // TODO: Add your service operations here
    }
}