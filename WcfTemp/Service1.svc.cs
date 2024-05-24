﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfTemp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString);
        Temp temp = new Temp();
        table tabledt = new table();
        public Temp SP_GetCountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("[SP_GetCountry]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable("Paging");
            da.Fill(dt);
            temp.Temptable = dt;


            con.Close();

            return temp;
        }
        public Temp SP_GetCategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("[SP_GetCategory]", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable("Paging");
            da.Fill(dt);
            temp.Temptable = dt;


            con.Close();

            return temp;
        }
        public Temp SP_GetNews(string country, string category, string query, string page)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("[SP_GetNews] '" + country + "','" + category + "','" + query + "','" + page + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable("Paging");
            da.Fill(dt);
            temp.Temptable = dt;


            con.Close();

            return temp;
        }

    }
}
