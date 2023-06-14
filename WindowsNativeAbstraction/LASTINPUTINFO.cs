using System.Runtime.InteropServices;

namespace WindowsNativeAbstraction;

/// <summary>
///  This structure comes from WinUser header.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct LASTINPUTINFO
{
    [MarshalAs(UnmanagedType.U4)]
    public UInt32 cbSize;

    [MarshalAs(UnmanagedType.U4)]
    public UInt32 dwTime;
}
