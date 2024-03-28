using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

// Specify your Azure Key Vault URL
string keyVaultUrl = "https://rbacumbracowebnausea87.vault.azure.net/";

// Create a new SecretClient using Azure Identity
var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());

// Specify the name of the secret you want to retrieve
string clientId = "ClientId" ?? string.Empty;
string clientSecretId = "ClientSecretId" ?? string.Empty;
string tenantId = "TenantId" ?? string.Empty;

try
{
    // Retrieve the secret from the Key Vault
    var clientIdVal = client.GetSecret(clientId).Value;
    var clientSecretIdVal = client.GetSecret(clientSecretId).Value;
    var tenantIdVal = client.GetSecret(tenantId).Value;

    Console.WriteLine($"Values are: {clientIdVal.Value}");
    Console.WriteLine($"Values are: {clientSecretIdVal.Value}");
    Console.WriteLine($"Values are: {tenantIdVal.Value}");
}

catch (Exception ex)
{
    Console.WriteLine($"Error accessing secret: {ex.Message}");
}
