namespace MentorLake.Gtk;

public class GtkRequestedSizeHandle : BaseSafeHandle
{
}


public static class GtkRequestedSizeExtensions
{

	public static GtkRequestedSize Dereference(this GtkRequestedSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRequestedSize>(x.DangerousGetHandle());
}
internal class GtkRequestedSizeExterns
{
}

public struct GtkRequestedSize
{
	public IntPtr data;
	public int minimum_size;
	public int natural_size;
}
