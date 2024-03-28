# Azure Key Vault RBAC Access Checker

This console application in checks whether you have access to secrets in Azure Key Vault based on Role-Based Access Control (RBAC) permissions.

## Prerequisites

Before running this application, ensure you have the following:

- .NET Core SDK installed
- Azure subscription
- Access to an Azure Key Vault
- Appropriate RBAC permissions to access the Azure Key Vault

## Usage

1. Clone this repository to your local machine.
2. Open `Program.cs` and replace the placeholders with your Azure Key Vault URL and the user's object ID whose access you want to check.
4. Run the application.

## How it works

This application authenticates to Azure using the provided credentials and checks the user's permissions for accessing secrets in the specified Azure Key Vault. It displays whether the user has access or not. Gött mos.