# Xero.Net.OAuth2
This is a .NET Framework version of the official XeroAPI/Net-Standard SDK that provides access to the Xero OAuth2 API

Tested against 4.7.2

This exists because I found some issues using the official API and binding sources in my .NET Framework applications. 

When testing and creating a .Net Framework version of the NetStandard SDK I found the binding sources worked perfectly.

I have now made this version which is a complete merge of the NetStandard code base and my OAuth2 Wrapper code.

I have left all the NetStandard code public so you can use either the new Wrapper elements via Xero.Net.Core or the Xero.Net.Api.Api

This Wrapper is exposed as Xero.Net.Core for the new API Wrapper methods and Xero.Net.Api.Model for the models for the returned data.


### Xero.Net.OAuth2 easier to use.

This new wrapper provides a simple way to get your Xero oAuth2 tokens and wrap the NetStandard API calls into easier to use Synchronous calls.

The core oAuth2 process is wrapped up in a nice self contained class to do all the work for you.

Just provide the required Xero Client ID, Callback URL, scope and original saved token (if you have one) and the wrapper will launch a web browser if the token has expired or is not yet generated.

It uses a wrapper around the System.Net.HttListener class that waits for the call back response once the user has authenticated and will then exchange the provided authentication code for the access tokens.

This wrapper will also handle the refresh of the access tokens if required.

This API Wrapper was designed to simplify the API calls to Xero and convert all the Async calls to sync calls. there are also events to provide feedback to the calling application

My codebase is contained in "Core".

The Core API wrapper now Inherit the NetStandard API's so you may access the Async calls direcly via my Core API. This is usefull to expose the Async methods and provide access to perform actions not available in my own Api code
Using my Core Api code should cater for most things but at least it will give access without the need to instatiate a NetStandard version Api object.


[![NuGet.org](https://img.shields.io/badge/NuGet.org-Xero.NetStandard.OAuth2-brightgreen?style=plastic&logo=appveyor)](https://www.nuget.org/packages/Xero.NetStandard.OAuth2/)

Visit https://github.com/XeroAPI/Xero-NetStandard

#### You do not need to install the Nuget package for this Wrapper to work as its a clone of 3.12.1

### Limitations
Presently the project is being worked on so dont expect it to work perfectly.
The API currently exposes the Xero AccountApi, Assets and Projects. The Payroll elements will follow later. However the underlying NetStandard methods are available via Xero.Net.Api.Api if you need to use them

### Create a Xero App first 
You can follow these steps to create your Xero app to allow access to your Xero tenant(s)

* Create a free Xero user account (if you don't have one)
* Use this URL for beta access to oAuth2 [https://developer.xero.com/myapps](https://developer.xero.com/myapps)
* Click "New app" link
* Enter your App name, company url, privacy policy url, and redirect URI (this is your callback url - localhost, etc) I would suggest http://localhost:8888/callback/
* Choose PKCE
* Agree to terms and condition and click "Create App".
* Copy your client id and client secret and save for use later.
* Click the "Save" button. 

## Inspired By
The need to make life simple!

Code for the listener was found here
http://www.gabescode.com/dotnet/2018/11/01/basic-HttpListener-web-service.html 
I built something similar in the past using the TCP Listener and started to look at midifing this to do the listening but found it didnt work as I hoped. Subsequently an example provided by Xero pointed to this listener and I managed to make it work.


## Getting Started
Clone/Download the repository
To restore the packages used from NuGet and you may need to execute in the Nuget package console

``
Update-Package -reinstall
``


Example of how to use this API Wrapper

There are a number ways to setup the API

1 Create a config object. Set it up and pass it to the API
```c#
// Setup New Config
XeroConfiguration XeroConfig = new XeroConfiguration
{
    ClientID = XeroClientID,
    CallbackUri = XeroCallbackUri,
    // Add Scopes this way or see below
    ////Scopes = new List<Xero.Net.Core.OAuth2.Model.XeroScope> { Xero.Net.Core.OAuth2.Model.XeroScope.accounting_contacts, Xero.Net.Core.OAuth2.Model.XeroScope.accounting_transactions },
    //State = XeroState, // Optional - Not needed for a desktop app
    codeVerifier = null // Code verifier will be generated if empty
};

XeroConfig.AddScope(Xero.Net.Core.OAuth2.Model.XeroScope.all);
Xero.Net.Core.API  xeroAPI = new Xero.Net.Core.API(XeroConfig);
```
2 Load the Config from storage and pass to the API
```c#
string tokendata = ReadTextFile("tokendata.txt");
if (!string.IsNullOrEmpty(tokendata))
{
    XeroConfiguration XeroConfig = DeSerializeObject<XeroConfiguration>(tokendata);
    Xero.Net.Core.API  xeroAPI = new Xero.Net.Core.API(XeroConfig);
}
```
Alternative ways to load the configuration from storage

```c#
// Load from a saved Json string same as above
XeroConfig = Utils.DeSerializeObject<XeroConfiguration>(tokendata);

// Load direct from a file that contains the Json
XeroConfig = new XeroConfiguration("tokendata.xml");

// Load from the Json string (deserialized internally)
XeroConfig = new XeroConfiguration(tokendata); // Load from json string
```

3 Create a new Config and restore just the Access Token portion

```c#
XeroConfiguration XeroConfig = new XeroConfiguration
{
    ClientID = XeroClientID,
    CallbackUri = XeroCallbackUri,
    // Add Scopes this way or see below
    ////Scopes = new List<Xero.Net.Core.OAuth2.Model.XeroScope> { Xero.Net.Core.OAuth2.Model.XeroScope.accounting_contacts, Xero.Net.Core.OAuth2.Model.XeroScope.accounting_transactions },
    //State = XeroState, // Optional - Not needed for a desktop app
    codeVerifier = null // Code verifier will be generated if empty
};

string tokendata = ReadTextFile("tokendata.txt");
if (!string.IsNullOrEmpty(tokendata))
{
    XeroAccessToken token = DeSerializeObject<XeroAccessToken>(tokendata);
    XeroConfig.AccessTokenSet = token;
    Xero.Net.Core.API xeroAPI = new Xero.Net.Core.API(XeroConfig);
    
    xeroAPI.InitializeAPI();
}
```

By default the API will select the first tenant in the list , if you only have 1 authorized then all is fine otherwise ensure you select it (either allow your user to choose or select it yourself

```c#
// Find the Demo Company TenantID
Tenant Tenant = xeroAPI.Tenants.Find(x => x.TenantName.ToLower() == "demo company (uk)");
xeroAPI.SelectedTenant = Tenant; // Ensure its selected
```

## There are a few main classes.

* The LocalHttpListener class. This is a wrapper for the System.Net.HttpListener and is key to getting the codes from Xero
* oAuth2. This is the class that handles the Auth code flow and sets up the Listener. This is not directly exposed and will be used by the API class to do the work.
* API. The main wrapper that keeps the access simple with sync calls instead of async calls.

To get started you will just need two things to make calls to the Accounting Api. These are obtained by the oAuth2 Process
* tenantid
* accessToken

## Features
### Paging data
* All API calls that implement the need to page the results (100 per API call to Xero) are automatically dealt with so you will get ALL records that you request regardless of how many are in Xero.
* If you want a quick first page (collections of additional data like LineItems are not returned) just set the onlypage = -1

### Others
* Simplified usage. No need to worry about async calls
* scopes are handled by a list enums
* Exceptions are passed throuh from the Xero API

## Examples

To request data from Xero its a simple as

```c#
var accounts = xeroAPI.AccountingApi.Accounts(); 
```
or fetch a single item.

```c#
var singleAccount = xeroAPI.AccountingApi.Account(accounts[5].AccountID.Value);
```
Invoices
```c#
var invoices = xeroAPI.AccountingApi.Invoices();
var singleinvcoice = xeroAPI.AccountingApi.Invoice(invoices[5].InvoiceID.Value);
```
Quick first page of invoices
```c#
var invoices = xeroAPI.AccountingApi.Invoices(null, null, -1);
```

fetch a list of assets
```c#
 try
	{
		 
		var assets = xeroAPI.AssetApi.Assets(Xero.Net.Api.Model.Asset.AssetStatusQueryParam.REGISTERED);
	}
	catch (Exception ex)
	{
		// Deal with the error	 
	}
```

You can even create a record using a single call

```c#
var createdInv = xeroAPI.AccountingApi.CreateInvoice(invoiceRecord);
```

This requires an invoice object to be created and can be accomplished via building the object first

```c#
// Create a test invoice
var xeroContact = new Xero.Net.Api.Model.Accounting.Contact
{
    Name = "Client Name",
    FirstName = "Client",
    LastName = "Name",
    EmailAddress = "emailaddress@na.com",
    IsCustomer = true,

    AccountNumber = $"NEW-ACC",
    // Website = "http://google.com"; // Currently the Zero API has this read only!!

    Addresses = new List<Xero.Net.Api.Model.Accounting.Address>()
};

var address = new Xero.Net.Api.Model.Accounting.Address
{
    AddressType = Xero.Net.Api.Model.Accounting.Address.AddressTypeEnum.STREET,
    AddressLine1 = "Address1_Line1",
    AddressLine2 = "Address1_Line2",
    AddressLine3 = "Address1_Line3",
    City = "Address1_City",
    Region = "Address1_County",
    PostalCode = "Address1_PostalCode",
    Country = "Address1_Country"
};

xeroContact.Addresses.Add(address);

xeroContact.Phones = new List<Xero.Net.Api.Model.Accounting.Phone>();

var phone = new Xero.Net.Api.Model.Accounting.Phone();
phone.PhoneType = Xero.Net.Api.Model.Accounting.Phone.PhoneTypeEnum.DEFAULT;
phone.PhoneNumber = "Telephone1";

xeroContact.Phones.Add(phone);

var fax = new Xero.Net.Api.Model.Accounting.Phone();
fax.PhoneType = Xero.Net.Api.Model.Accounting.Phone.PhoneTypeEnum.FAX;
fax.PhoneNumber = "Fax";
xeroContact.Phones.Add(fax);

var mobile = new Xero.Net.Api.Model.Accounting.Phone();
mobile.PhoneType = Xero.Net.Api.Model.Accounting.Phone.PhoneTypeEnum.MOBILE;
mobile.PhoneNumber = "MobilePhone";
xeroContact.Phones.Add(mobile);

// Build the Invoice Body
var invoiceRecord = new Xero.Net.Api.Model.Accounting.Invoice();
invoiceRecord.Contact = xeroContact;
invoiceRecord.Date = DateTime.Now;
invoiceRecord.DueDate = DateTime.Now.AddDays(30);
invoiceRecord.Status = Xero.Net.Api.Model.Accounting.Invoice.StatusEnum.DRAFT;
invoiceRecord.LineAmountTypes = Xero.Net.Api.Model.Accounting.LineAmountTypes.Exclusive;

invoiceRecord.Type = Xero.Net.Api.Model.Accounting.Invoice.TypeEnum.ACCREC;
invoiceRecord.Reference = $"oAuth2/Testing";
invoiceRecord.LineItems = new List<Xero.Net.Api.Model.Accounting.LineItem>();

// Line Item 1
// Create the Tracking Item
var tracking = new List<Xero.Net.Api.Model.Accounting.LineItemTracking>();
tracking.Add(new Xero.Net.Api.Model.Accounting.LineItemTracking { Name = "Region", Option = "Eastside" });

Xero.Net.Api.Model.Accounting.LineItem lineItem = new Xero.Net.Api.Model.Accounting.LineItem
{
    Description = $"Product Item 1{Environment.NewLine}Additional Description text",
    Quantity = 1,
    UnitAmount = 123m,
    LineAmount = 123m,
    TaxAmount = 123m * .20m,
    AccountCode = "200",
    Tracking = tracking
};

invoiceRecord.LineItems.Add(lineItem); // Add the line item to the invoice object

// Line Item 2
// Create the Tracking Item
tracking = new List<Xero.Net.Api.Model.Accounting.LineItemTracking>();
tracking.Add(new Xero.Net.Api.Model.Accounting.LineItemTracking { Name = "Region", Option = "South" });

Xero.Net.Api.Model.Accounting.LineItem lineItem2 = new Xero.Net.Api.Model.Accounting.LineItem
{
    Description = $"Product Item 2{Environment.NewLine}Additional Description text2",
    Quantity = 2,
    UnitAmount = 456m,
    LineAmount = 456m * 2,
    TaxAmount = (456m * 2) * .20m,
    AccountCode = "200",
    Tracking = tracking
};

invoiceRecord.LineItems.Add(lineItem2); // Add the line item to the invoice object             

if (invoiceRecord.ValidationErrors == null || invoiceRecord.ValidationErrors.Count == 0)
{
    var createdInv = xeroAPI.AccountingApi.CreateInvoice(invoiceRecord);
    if (createdInv.InvoiceID != Guid.Empty)
    {
        Debug.WriteLine("Created New Invoice");
    }
}

```            
## Known Issues and Future Updates
* Currently the oAuth2 handles PKCE only.
* The State value used in the OAuth2 process is sent and received but is not checked for validity
* Need to add Simplified Payroll (Au, Nz and Uk) Access (Base NetStandard access is available)
* Need to add Simplified BankFeeds Access (Base NetStandard access is available)
* Need to add Simplified Identity Access (Base NetStandard access is available)
* Need to add Simplified Files Access (Base NetStandard access is available)
* Need to add Simplified Asset Access (Base NetStandard access is available)


## License

MIT License

Copyright (c) 2021 AGenius

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
