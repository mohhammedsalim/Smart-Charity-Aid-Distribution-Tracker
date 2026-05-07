using System.ComponentModel;
public enum DistributionStatus
{
    [Description("منفذة")]
    Completed,
    [Description("ملغاة")]
    Cancelled,
    [Description("معلقة")]
    Pending
}