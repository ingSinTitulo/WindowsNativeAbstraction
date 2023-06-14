using System.Runtime.InteropServices;
using System.Text;

namespace WindowsNativeAbstraction;

/// <summary>
///  This class contains all abstracted methods from User32 and AdvAPI DLLs.
/// </summary>
public class NativeMethods
{
    /// <summary>
    /// Get the Sid object for the current User.
    /// </summary>
    [DllImport("advapi32", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool LookupAccountSid(string lpSystemName,
        [MarshalAs(UnmanagedType.LPArray)] byte[] Sid, StringBuilder lpName,
        ref uint cchName, StringBuilder ReferencedDomainName,
        ref uint cchReferencedDomainName, out SID_NAME_USE peUse);

    /// <summary>
    /// Get the last time that an Input event was triggered.
    /// </summary>
    [DllImport("user32.dll")]
    public static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
}
