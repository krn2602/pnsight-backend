namespace ProductInsight.Api.Services;
public static class EanValidator {
    private static readonly int[] ValidLengths = { 8, 12, 13 ,14 };

    public static bool IsValid (string? ean) {
        if(string.IsNullOrWhiteSpace(ean))
            return false;
        
        foreach (char c in ean) { 
            if(c<'0' || c > '9')
                return false;
            }

        if (!ValidLengths.Contains(ean.Length))
            return false;
        
        int sum = 0;
        for( int i = 0; i < ean.Length - 1 ; i++) {
            int digit = ean[ean.Length - 2 - i] - '0';
            sum += digit * (i % 2 == 0 ? 3 : 1 );

        }
        int expectedDigit = (10 - sum % 10) % 10;
        int actualDigit = ean[^1] - '0';
        
        return expectedDigit == actualDigit;
        
    }
} 