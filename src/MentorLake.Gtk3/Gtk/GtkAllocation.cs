namespace MentorLake.Gtk;

public struct GtkAllocation
{
	public MentorLake.Gdk.GdkRectangle Value;
}

public class GtkAllocationHandle : BaseSafeHandle
{
}

public static class GtkAllocationHandleExtensions
{
	public static GtkAllocation Dereference(this GtkAllocationHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAllocation>(x.DangerousGetHandle());
	public static MentorLake.Gdk.GdkRectangle DereferenceValue(this GtkAllocationHandle x) => x.Dereference().Value;
}
