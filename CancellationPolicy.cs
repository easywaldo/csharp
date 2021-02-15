using System.Collections.Generic;

public class CancelllationPolicy
{
    public CancelllationPolicy()
    {
        this.CancellationFeeRules = new List<CancellationFeeRule>();
    }

    public bool IsRefundable { get; set; }
    public List<CancellationFeeRule> CancellationFeeRules { get; set;}
}