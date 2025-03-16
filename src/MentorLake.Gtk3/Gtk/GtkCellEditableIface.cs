namespace MentorLake.Gtk;

public class GtkCellEditableIfaceHandle : BaseSafeHandle
{
}


public static class GtkCellEditableIfaceExtensions
{

	public static GtkCellEditableIface Dereference(this GtkCellEditableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkCellEditableIface>(x.DangerousGetHandle());
}
internal class GtkCellEditableIfaceExterns
{
}

public struct GtkCellEditableIface
{
	public IntPtr editing_done;
	public IntPtr remove_widget;
	public IntPtr start_editing;
}
