namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A type corresponding to the appropriate struct type for the stat()
/// system call, depending on the platform and/or compiler being used.
/// </para>
/// <para>
/// See g_stat() for more information.
/// </para>
/// </summary>

public class GStatBufHandle : BaseSafeHandle
{
}


public static class GStatBufExtensions
{

	public static GStatBuf Dereference(this GStatBufHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStatBuf>(x.DangerousGetHandle());
}
internal class GStatBufExterns
{
}

/// <summary>
/// <para>
/// A type corresponding to the appropriate struct type for the stat()
/// system call, depending on the platform and/or compiler being used.
/// </para>
/// <para>
/// See g_stat() for more information.
/// </para>
/// </summary>

public struct GStatBuf
{
}
