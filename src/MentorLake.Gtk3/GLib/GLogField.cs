namespace MentorLake.GLib;

public class GLogFieldHandle : BaseSafeHandle
{
}


public static class GLogFieldExtensions
{

	public static GLogField Dereference(this GLogFieldHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GLogField>(x.DangerousGetHandle());
}
internal class GLogFieldExterns
{
}

public struct GLogField
{
	public string key;
	public IntPtr value;
	public UIntPtr length;
}
