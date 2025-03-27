namespace MentorLake.GLib;

public struct GStrv
{
	public string Value;
}

public class GStrvHandle : BaseSafeHandle
{
}

public static class GStrvHandleExtensions
{
	public static GStrv Dereference(this GStrvHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStrv>(x.DangerousGetHandle());
	public static string DereferenceValue(this GStrvHandle x) => x.Dereference().Value;
}
