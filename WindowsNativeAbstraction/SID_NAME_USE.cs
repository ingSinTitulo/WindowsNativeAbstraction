namespace WindowsNativeAbstraction;

/// <summary>
///  This enum comes from WinNT header.
/// </summary>
public enum SID_NAME_USE : int
{
    SidTypeUser = 1,
    SidTypeGroup,
    SidTypeDomain,
    SidTypeAlias,
    SidTypeWellKnownGroup,
    SidTypeDeletedAccount,
    SidTypeInvalid,
    SidTypeUnknown,
    SidTypeComputer,
    SidTypeLabel,
    SidTypeLogonSession,
}