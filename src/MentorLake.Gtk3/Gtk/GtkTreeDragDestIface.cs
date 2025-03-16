namespace MentorLake.Gtk;

public class GtkTreeDragDestIfaceHandle : BaseSafeHandle
{
}


public static class GtkTreeDragDestIfaceExtensions
{

	public static GtkTreeDragDestIface Dereference(this GtkTreeDragDestIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTreeDragDestIface>(x.DangerousGetHandle());
}
internal class GtkTreeDragDestIfaceExterns
{
}

public struct GtkTreeDragDestIface
{
	public IntPtr drag_data_received;
	public IntPtr row_drop_possible;
}
