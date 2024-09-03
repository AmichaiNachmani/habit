string secretValue = Environment.GetEnvironmentVariable("MY_SECRET");

if (!string.IsNullOrEmpty(secretValue))
{
    Console.WriteLine($"The secret is: {secretValue}");
}
else
{
    Console.WriteLine("No secret found.");
}