namespace MentorLake.GLib;

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

public struct GStatBuf
{
}
