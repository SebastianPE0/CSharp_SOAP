# C# SOAP Web Service Project
---
## Project Description
This project is a simple SOAP web service implemented using C# and ASP.NET Core. It exposes a HandleWebhook method, which receives a SOAP request, processes the data, and returns a response with the received message. This service can be consumed by SOAP clients such as Postman or any other SOAP-enabled tool.

## Motivation
The purpose of this project is to demonstrate how to create a SOAP-based web service in C# using ASP.NET Core. The project serves as an example of how to handle SOAP requests and send SOAP responses in a C# web application.
---
## Technologies Used
  - C#: The primary programming language for the web service.
  - ASP.NET Core: The framework used to build the web service.
  - SOAP: Simple Object Access Protocol (SOAP) used for communication.
  - Postman: A tool used for testing SOAP requests and responses.

## How to Install and Run the Project
   ### Prerequisites
- .NET 6 or higher (Install from here).
- Visual Studio 2022 or any other compatible IDE.
   ### Installation Steps
1. Clone the Repository:
```
git clone https://github.com/SebastianPE0/CSharp_SOAP.git
```
3. Open the Project in Visual Studio:
  Open the CSharp_Soap project in Visual Studio 2022.
4. Build the Project:

Click Build > Build Solution to ensure all dependencies are restored and the project is compiled.
4. Run the Project:

  Press F5 or click on Run to start the web service.
  The service will run on http://localhost:5117 by default.
## How to Use the Web Service
To interact with the SOAP web service, you can send a SOAP request using a tool like Postman or any SOAP client.

Example SOAP Request (XML)
```
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    <s:Body>
        <HandleWebhook xmlns="http://tempuri.org/">
            <message>Hello, SOAP Web Service!</message>
        </HandleWebhook>
    </s:Body>
</s:Envelope>
```
--- 
Example SOAP Response
```
<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
    <s:Body>
        <HandleWebhookResponse xmlns="http://tempuri.org/">
            <HandleWebhookResult>Received message: Hello, SOAP Web Service!</HandleWebhookResult>
        </HandleWebhookResponse>
    </s:Body>
</s:Envelope>
```
##Additional Information
Screenshot for the test
![image](https://github.com/user-attachments/assets/4b69363c-d616-4755-b046-d9807641a4da)

