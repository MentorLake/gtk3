namespace MentorLake.GLib;

public class GOptionEntryHandle : BaseSafeHandle
{
}


public static class GOptionEntryExtensions
{

	public static GOptionEntry Dereference(this GOptionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOptionEntry>(x.DangerousGetHandle());
}
internal class GOptionEntryExterns
{
}

public struct GOptionEntry
{
	public string long_name;
	public char short_name;
	public int flags;
	public GOptionArg arg;
	public IntPtr arg_data;
	public string description;
	public string arg_description;
}
