namespace MentorLake.Gtk;

public class GtkTreeDragSourceIfaceHandle : BaseSafeHandle
{
}


public static class GtkTreeDragSourceIfaceExtensions
{

	public static GtkTreeDragSourceIface Dereference(this GtkTreeDragSourceIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeDragSourceIface>(x.DangerousGetHandle());
}
internal class GtkTreeDragSourceIfaceExterns
{
}

public struct GtkTreeDragSourceIface
{
	public IntPtr row_draggable;
	public IntPtr drag_data_get;
	public IntPtr drag_data_delete;
}
