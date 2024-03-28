using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

// Specify your Azure Key Vault URL
string keyVaultUrl = "https://rbacumbracowebnausea87.vault.azure.net/";

// Specify the names of the secrets you want to retrieve
string[] secretNames = ["ClientId", "ClientSecretId", "TenantId"];

try
{
    // Create a new SecretClient using Azure Identity
    var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());

    foreach (string secretName in secretNames)
    {
        try
        {
            // Retrieve the secret from the Key Vault
            KeyVaultSecret secret = await client.GetSecretAsync(secretName);

            Console.WriteLine($"Value for {secretName} is: {secret.Value}\n");
        }
        catch (Azure.RequestFailedException ex)
        {
            Console.WriteLine($"Error accessing secret {secretName}: {ex.Message}");
            continue;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error accessing secret: {ex.Message}");
}
