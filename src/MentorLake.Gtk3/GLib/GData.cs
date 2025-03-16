namespace MentorLake.GLib;

public class GDataHandle : BaseSafeHandle
{
}


public static class GDataExtensions
{

	public static GData Dereference(this GDataHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GData>(x.DangerousGetHandle());
}
internal class GDataExterns
{
}

public struct GData
{
}
