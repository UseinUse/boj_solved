using StreamWriter wt = new(Console.OpenStandardOutput());
using StreamReader rd = new(Console.OpenStandardInput());
int n = int.Parse(Console.ReadLine());
var dp = new int[31];
dp[0] = 1;
dp[2] = 3;

for (int i = 4; i <= n; i++)
{
    if (i % 2 != 0) continue;

    dp[i] = 3 * dp[i - 2];
    for (int j = i - 4; j >= 0; j-=2)
        dp[i] += 2 * dp[j];    
}

wt.Write(dp[n]);