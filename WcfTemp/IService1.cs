using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfTemp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Temp SP_GetCountry();

        [OperationContract]
        Temp SP_GetCategory();

        [OperationContract]
        Temp SP_GetNews(string country, string category, string query, string page);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Temp
    {
        [DataMember]
        public DataTable Temptable
        {
            get;
            set;
        }
    }

    [DataContract]
    public class table
    {
        [DataMember]
        public DataTable tabledata
        {
            get;
            set;
        }

    }
}
