﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class PurchaseOrdersFactory : RestSharpFactory
    {
        /// <summary>
        /// PurchaseOrdersFactory
        /// </summary>
        /// <param name="userToken">A valid user's Authentication Token</param>
        public PurchaseOrdersFactory(string userToken)
            : base(userToken)
        {
            module = "PurchaseOrders";
        }

        /// <summary>
        /// To fetch data by the owner of the Authentication Token specified in the API request
        /// </summary>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getMyRecords()
        {
            return this.getMyRecords<List<PurchaseOrders>>(module);
        }

        /// <summary>
        /// To fetch data by the owner of the Authentication Token specified in the API request
        /// </summary>
        /// <param name="parameters">
        /// Dictionary:                 key: selectColumns,     value: Module(optional columns)
        ///                             key: fromIndex, 	    value: (Default value: 1)
        ///                             key: toIndex,           value: (Default value:20 / Maximum value:200)
        ///                             key: sortColumnString,	value: You can select one of the fields in CRM in to sort the data.
        ///                             key: sortOrderString,	value: asc or desc
        ///                             key: lastModifiedTime	value: (Default value: null)
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<PurchaseOrders>>(module, parameters);
        }

        /// <summary>
        /// To fetch all users data specified in the API request
        /// </summary>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getRecords()
        {
            return this.getRecords<List<PurchaseOrders>>(module);
        }

        /// <summary>
        /// To fetch all users data specified in the API request
        /// </summary>
        /// <param name="parameters">
        /// Dictionary:                 key: selectColumns,     value: Module(optional columns)
        ///                             key: fromIndex, 	    value: (Default value: 1)
        ///                             key: toIndex,           value: (Default value:20 / Maximum value:200)
        ///                             key: sortColumnString,	value: You can select one of the fields in CRM in to sort the data.
        ///                             key: sortOrderString,	value: asc or desc
        ///                             key: lastModifiedTime	value: (Default value: null)
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<PurchaseOrders>>(module, parameters);
        }

        /// <summary>
        /// To retrieve individual records by record ID
        /// </summary>
        /// <param name="PurchaseOrderId">Specify unique ID of the record</param>
        /// <returns>PurchaseOrder</returns>
        public PurchaseOrders getRecordById(long PurchaseOrderId)
        {
            return this.getRecordById<List<PurchaseOrders>>(module, PurchaseOrderId)[0];
        }

        /// <summary>
        /// To retrieve individual records by record ID
        /// </summary>
        /// <param name="PurchaseOrderId">Specify unique ID of the record</param>
        /// <param name="parameters">
        /// Dictionary:                 key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns></returns>
        public PurchaseOrders getRecordById(long PurchaseOrderId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<PurchaseOrders>(module, PurchaseOrderId, parameters);
        }

        /// <summary>
        /// To fetch data with respect to the Custom View in Zoho CRM
        /// </summary>
        /// <param name="cvName">Name of custom View</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getCVRecords(string cvName)
        {
            return this.getCVRecords<List<PurchaseOrders>>(module, cvName);
        }

        /// <summary>
        /// To fetch data with respect to the Custom View in Zoho CRM
        /// </summary>
        /// <param name="cvName">Name of custom View</param>
        /// <param name="parameters">
        /// Dictionary:                 key: fromIndex, 	    value: (Default value: 1)
        ///                             key: toIndex,           value: (Default value:20 / Maximum value:200)
        ///                             key: lastModifiedTime	value: (Default value: null)
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns></returns>
        public List<PurchaseOrders> getCVRecords(string cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<PurchaseOrders>>(module, cvName, parameters);
        }

        /// <summary>
        /// To insert records into the required Zoho CRM module
        /// </summary>
        /// <param name="listPurchaseOrders">List of PurchaseOrders, even if it has only one element</param>
        /// <returns>True if inserted successfully or throws an exception if it could not insert properly</returns>
        public bool insertRecords(List<PurchaseOrders> listPurchaseOrders)
        {
            return this.insertRecords(module, listPurchaseOrders);
        }

        /// <summary>
        /// To insert records into the required Zoho CRM module
        /// </summary>
        /// <param name="listPurchaseOrders">List of PurchaseOrders, even if it has only one element</param>
        /// <param name="parameters">
        /// Dictionary:                 key: wfTrigger,         value: Set value as true to trigger the workflow rule while inserting record into CRM PurchaseOrder. By default, this parameter is false.
        ///                             key: duplicateCheck,    value: Set value as "1" to check the duplicate records and throw an error response or "2" to check the duplicate records, if exists, update the same.
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns>True if inserted successfully or throws an exception if it could not insert properly</returns>
        public bool insertRecords(List<PurchaseOrders> listPurchaseOrders, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listPurchaseOrders, parameters);
        }

        /// <summary>
        /// To update or modify the records in Zoho CRM
        /// </summary>
        /// <param name="PurchaseOrderId">Specify unique ID of the record</param>
        /// <param name="PurchaseOrder">PurchaseOrder with updated data</param>
        /// <returns>True if updated successfully or throws an exception if it could not updated properly</returns>
        public bool updateRecords(long PurchaseOrderId, PurchaseOrders PurchaseOrder)
        {
            List<PurchaseOrders> listPurchaseOrders = new List<PurchaseOrders>();
            listPurchaseOrders.Add(PurchaseOrder);
            return this.updateRecords(module, PurchaseOrderId, listPurchaseOrders);
        }

        /// <summary>
        /// To update or modify the records in Zoho CRM
        /// </summary>
        /// <param name="PurchaseOrderId">Specify unique ID of the record</param>
        /// <param name="PurchaseOrder">PurchaseOrder with updated data</param>
        /// <param name="parameters">
        /// Dictionary:                 key: wfTrigger,         value: Set value as true to trigger the workflow rule while inserting record into CRM PurchaseOrder. By default, this parameter is false.
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns>True if updated successfully or throws an exception if it could not updated properly</returns>
        public bool updateRecords(long PurchaseOrderId, PurchaseOrders PurchaseOrder, Dictionary<string, string> parameters)
        {
            List<PurchaseOrders> listPurchaseOrders = new List<PurchaseOrders>();
            listPurchaseOrders.Add(PurchaseOrder);
            return this.updateRecords(module, PurchaseOrderId, listPurchaseOrders, parameters);
        }

        /// <summary>
        /// To search records by regular expressions of selected columns
        /// </summary>
        /// <param name="selectColumns">All or module(field 1,field 2,field 3, field n...)</param>
        /// <param name="searchCondition">(Created By|=|username)
        /// i.e= selectColumns=Leads(Lead Name,Company,Email,Mobile,Website)&searchCondition=(Email|contains|*@sample.com*)
        /// You can specify the following expressions in API request:
        /// is OR =, isn't OR <>, contains(*srcString*), starts with(srcString*), ends with(*srcString), doesn't contain, &lt; OR is before, &gt; OR is after, &lt=, =&gt</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getSearchRecords(string selectColumns, string searchCondition)
        {
            return this.getSearchRecords<List<PurchaseOrders>>(module, selectColumns, searchCondition);
        }

        /// <summary>
        /// To search records by regular expressions of selected columns
        /// </summary>
        /// <param name="selectColumns">All or module(field 1,field 2,field 3, field n...)</param>
        /// <param name="searchCondition">(Created By|=|username)
        /// i.e= selectColumns=Leads(Lead Name,Company,Email,Mobile,Website)&searchCondition=(Email|contains|*@sample.com*)
        /// You can specify the following expressions in API request:
        /// is OR =, isn't OR <>, contains(*srcString*), starts with(srcString*), ends with(*srcString), doesn't contain, &lt; OR is before, &gt; OR is after, &lt=, =&gt</param>
        /// <param name="parameters">
        /// Dictionary:                 key: fromIndex, 	    value: (Default value: 1)
        ///                             key: toIndex,           value: (Default value:20 / Maximum value:200)
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getSearchRecords(string selectColumns, string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<PurchaseOrders>>(module, selectColumns, searchCondition, parameters);
        }

        /// <summary>
        /// To search the values based on pre-defined columns
        /// </summary>
        /// <param name="selectColumns">All or module(field 1,field 2,field 3, field n...)</param>
        /// <param name="searchColumn">Specify the predefined search column</param>
        /// <param name="searchValue">Specify the value to be searched</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getSearchRecordsByPDC(string selectColumns, string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<PurchaseOrders>>(module, selectColumns, searchColumn, searchValue);
        }

        /// <summary>
        /// To search the values based on pre-defined columns
        /// </summary>
        /// <param name="selectColumns">All or module(field 1,field 2,field 3, field n...)</param>
        /// <param name="searchColumn">Specify the predefined search column</param>
        /// <param name="searchValue">Specify the value to be searched</param>
        /// <param name="parameters">
        /// Dictionary:                 key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.
        ///                             key: version            value: (1 -4 Default value: 1)</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getSearchRecordsByPDC(string selectColumns, string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<PurchaseOrders>>(module, selectColumns, searchColumn, searchValue, parameters);
        }

        /// <summary>
        /// To delete the selected records
        /// </summary>
        /// <param name="PurchaseOrderId">Specify unique ID of the record</param>
        /// <returns>True if deleted successfully or throws an exception if it could not deleted properly</returns>
        public bool deleteRecords(long PurchaseOrderId)
        {
            return this.deleteRecords(module, PurchaseOrderId);
        }

        /// <summary>
        /// To get records related to a primary module
        /// </summary>
        /// <param name="id">The id of the record for which you want to fetch related records</param>
        /// <param name="parentModule">Module for which you want to fetch the related records
        /// Example: If you want to fetch Leads related to a Campaign, then Campaigns is your parent module.</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<PurchaseOrders>>(module, id, parentModule);
        }

        /// <summary>
        /// To get records related to a primary module
        /// </summary>
        /// <param name="id">The id of the record for which you want to fetch related records</param>
        /// <param name="parentModule">Module for which you want to fetch the related records
        /// Example: If you want to fetch Leads related to a Campaign, then Campaigns is your parent module.</param>
        /// <param name="parameters">
        /// Dictionary:                 key: fromIndex, 	    value: (Default value: 1)
        ///                             key: toIndex,           value: (Default value:20 / Maximum value:200)
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM PurchaseOrder.</param>
        /// <returns>List of PurchaseOrders</returns>
        public List<PurchaseOrders> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<PurchaseOrders>>(module, id, parentModule, parameters);
        }

        /// <summary>
        /// To get details of fields available in a module
        /// </summary>
        /// <returns>An object type Fields</returns>
        public Fields getFields()
        {
            return this.getFields(module);
        }

        // Isn't implemented
        //public bool uploadFile(long LeadId, string filePath)
        //{
        //    return this.uploadFile(module, LeadId, filePath);
        //}

        /// <summary>
        /// To download a file attached to a record
        /// </summary>
        /// <param name="AttachmentId">Specify unique ID of the attachment, to get the ID you must use Attachments</param>
        /// <returns>True if downloaded successfully or throws an exception if it could not downloaded properly</returns>
        public bool downloadFile(long AttachmentId)
        {
            return this.downloadFile(module, AttachmentId, "");
        }

        /// <summary>
        /// To download a file attached to a record
        /// </summary>
        /// <param name="AttachmentId">Specify unique ID of the attachment, to get the ID you must use Attachments</param>
        /// <param name="filePath">Specify the full file path</param>
        /// <returns>True if downloaded successfully or throws an exception if it could not downloaded properly</returns>
        public bool downloadFile(long AttachmentId, string filePath)
        {
            return this.downloadFile(module, AttachmentId, filePath);
        }

        /// <summary>
        /// To delete a file attached to a record
        /// </summary>
        /// <param name="AttachmentId">Specify unique ID of the attachment, to get the ID you must use Attachments</param>
        /// <returns>True if deleted file successfully or throws an exception if it could not deleted file properly</returns>
        public bool deleteFile(long AttachmentId)
        {
            return this.deleteFile(module, AttachmentId);
        }
    }
}
