namespace MentorLake.GLib;

public class GDebugKeyHandle : BaseSafeHandle
{
}


public static class GDebugKeyExtensions
{

	public static GDebugKey Dereference(this GDebugKeyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDebugKey>(x.DangerousGetHandle());
}
internal class GDebugKeyExterns
{
}

public struct GDebugKey
{
	public string key;
	public uint value;
}
