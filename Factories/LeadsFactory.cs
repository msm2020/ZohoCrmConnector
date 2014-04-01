﻿using ZohoCrmConnector.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace ZohoCrmConnector.Factories
{
    public class LeadsFactory : ConectionFactory
    {
        public LeadsFactory(string recordId)
            : base(recordId)
        {
            
        }

        public Entities.leads Get(long leadID)
        {
            var userToken = "b447d78308ef09d3bb3da3849da90c71";

            RestClient client = new RestClient();
            client.BaseUrl = "https://crm.zoho.com/crm/private/xml/";

            RestRequest request = new RestRequest(Method.GET);
            request.Resource = "{module}/{method}";
            request.AddParameter("module", "Leads", ParameterType.UrlSegment);
            request.AddParameter("method", "getRecords", ParameterType.UrlSegment);
            request.AddParameter("authtoken", userToken);
            request.AddParameter("scope", "crmapi");
            request.AddParameter("newFormat", "1");
            request.AddParameter("selectColumns", "All");
            request.RootElement = "rows";

            var response = client.Execute<Entities.leads>(request);


            return (Entities.leads) response;
        }
    }
}
/*
        public long leadID { get; set; }
        public long smowerID { get; set; }
        public long leadOwner { get; set; }
        public string company { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        //public string designation { get; set; }
        public string tittle { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string mobile { get; set; }
        public string website { get; set; }
        public long campaingSource { get; set; }
        //public string leadSource { get; set; }
        public string leadStatus { get; set; }
        public string industry { get; set; }
        public int numEmployees { get; set; }
        public double annualRevenue { get; set; }
        public string rating { get; set; }
        public long smcreatorID { get; set; }
        public string createdBY { get; set; }
        public long modifiedID { get; set; }
        public string modifiedBY { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
        public string country { get; set; }
        public string skypeID { get; set; }
        public string description { get; set; }
        public bool emailOptOut { get; set; }
        public string salutation { get; set; }
        public string emailSec { get; set; }
        public DateTime lastActivity { get; set; }
        public string twitter { get; set; }
 */