# Azure Key Vault RBAC Access Checker

This console application checks whether you have access to secrets in Azure Key Vault based on Role-Based Access Control (RBAC) permissions. Just a small program to quickly see if everything works as intended.

## Prerequisites

Before running this application, ensure you have the following:

- .NET Core SDK installed
- Azure subscription (if testing your own AKV)
- Access to an Azure Key Vault
- Appropriate RBAC permissions to access the Azure Key Vault

## Usage

1. Clone this repository to your local machine.
2. Open `Program.cs` and replace the placeholders with your Azure Key Vault URL and the user's object ID whose access you want to check.
4. Run the application.
5. ???
6. Profit!

## How it works

This application authenticates to Azure using the provided credentials and checks the user's permissions for accessing secrets in the specified Azure Key Vault. It displays whether the user has access or not. Gött mos.

![bild](https://github.com/nausea87/SecretChecker/assets/62840687/e613dc6f-70a3-4d0b-832f-7d91d33dedf5)
![bild](https://github.com/nausea87/SecretChecker/assets/62840687/bb5c2fe6-4b94-4c15-8de4-31fe54f76df6)

