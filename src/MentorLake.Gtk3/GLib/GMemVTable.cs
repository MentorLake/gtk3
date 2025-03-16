namespace MentorLake.GLib;

public class GMemVTableHandle : BaseSafeHandle
{
}


public static class GMemVTableExtensions
{

	public static GMemVTable Dereference(this GMemVTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemVTable>(x.DangerousGetHandle());
}
internal class GMemVTableExterns
{
}

public struct GMemVTable
{
	public IntPtr malloc;
	public IntPtr realloc;
	public IntPtr free;
	public IntPtr calloc;
	public IntPtr try_malloc;
	public IntPtr try_realloc;
}
