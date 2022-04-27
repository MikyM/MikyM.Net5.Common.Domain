namespace MikyM.Common.Domain_Net5.Entities
{
    /// <summary>
    /// Audit log action type
    /// </summary>
    public enum AuditType
    {
        None = 0,
        Create = 1,
        Update = 2,
        Disable = 3,
        Delete = 4
    }
}