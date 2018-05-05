namespace ContactFile.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SqlTypes;
    using ContactFile;


    /// <summary>
    /// Summary description for DatabaseHelper
    /// </summary>
    public class DatabaseHelper
    {
        private string connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ContactFile"].ConnectionString;


        private const string queryInsertPhysicalAddress = @"
            INSERT INTO PhysicalAddresses
            (ContactID, Line1, Line2, Line3, City, StateProvince, PostalCode, Country, Description, IsDefault)
            VALUES
            (@ContactID, @Line1, @Line2, @Line3, @City, @StateProvince, @PostalCode, @Country, @Description, @IsDefault)
        ";

        private const string queryInsertPhoneNumber = @"
            INSERT INTO PhoneNumbers (ContactID, PhoneNumber, ExtensionNumber, Description, IsDefault) 
            VALUES (@ContactID, @PhoneNumber, @ExtensionNumber, @Description, @IsDefault)
        ";

        private const string querySelectAllFromContacts = "SELECT * FROM Contacts";

        private const string querySelectAllFromPhoneNumbers = "SELECT * FROM PhoneNumbers";

        private const string querySelectAllFromPhysicalAddresses = "SELECT * FROM PhysicalAddresses";

        private const string querySelectAllContactsIncludeDefualtPhoneAndAddress = @"
            WITH SingleDefaultPhoneNumber AS
            (
	            SELECT TOP 1 *
	            FROM PhoneNumbers
	            WHERE IsDefault = 'True'
            ),

            SingleDefaultPhysicalAddress AS
            (
	            SELECT TOP 1 *
	            FROM PhysicalAddresses
	            WHERE IsDefault = 'True'
            )

            SELECT contacts.ContactID AS ContactID, ContactName, CompanyName, JobTitle, ImageURL, EmailAddress, 
            SkypeUserName, TwitterUserName, WebSiteURL, Notes, TimeZoneInformation, GUID, DateCreated, DateModifed, 
            PhoneNumber, ExtensionNumber AS PhoneNumberExtension , SingleDefaultPhoneNumber.Description AS PhoneNumberDescription, 
            Line1 AS PhysicalAddressLine1, City, StateProvince, SingleDefaultPhysicalAddress.Description AS PhysicalAddressDescription
            FROM Contacts
            LEFT JOIN SingleDefaultPhoneNumber
	            ON (Contacts.ContactID = SingleDefaultPhoneNumber.ContactID)
            LEFT JOIN SingleDefaultPhysicalAddress
	            ON (Contacts.ContactID = SingleDefaultPhysicalAddress.ContactID)
        ";




        public DatabaseHelper()
        {

            connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ContactFile"].ConnectionString;
            //
            // TODO: Add constructor logic here
            //
        }


        public DataSet GetContacts()
        {
            SqlConnection contactFileDataBaseConnection = new SqlConnection(this.connectionString);
            SqlCommand command = new SqlCommand(Database.DatabaseHelper.querySelectAllFromContacts, contactFileDataBaseConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSetContacts = new DataSet();
            using (contactFileDataBaseConnection)
            {
                contactFileDataBaseConnection.Open();
                dataAdapter.Fill(dataSetContacts, "Contacts");
            }     
            return dataSetContacts;
        }

    }
}