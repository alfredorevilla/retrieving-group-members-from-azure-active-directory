# Retrieving group members from Azure Active Directory

This console application demostrate how to retrieve members for the first 5 groups from an Azure AD tenant.

### Pre-requisites

To run this sample you will need:

- The [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download)
- An Azure work or school account. This sample does not support personal accounts.


### Run the sample

When the sample runs, it will open the Azure AD login page in your browser so that you can input your work or school account credentials. Once signed in the app will query MS Graph and display some results.

#### Option 1: Using Visual Studio

1. Open the solution file using Visual Studio.

1. On the **Debug** menu, choose **Start without Debugging**.

#### Option 2: From the command line

1. Open your command-line interface (CLI) in the directory that contains **retrieving-group-members-from-azure-active-directory.csproj**.

1. Run the following command to build the sample.

    ```Shell
    dotnet build
    ```

1. Run the following command to run the sample.

    ```Shell
    dotnet run
    ``` 

### Copyright

Copyright (c) 2020 Alfredo Octavio Revilla Tenorio