namespace MentorLake.Gtk;

public class GtkPanedClassHandle : BaseSafeHandle
{
}


public static class GtkPanedClassExtensions
{

	public static GtkPanedClass Dereference(this GtkPanedClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPanedClass>(x.DangerousGetHandle());
}
internal class GtkPanedClassExterns
{
}

public struct GtkPanedClass
{
	public GtkContainerClass parent_class;
	public IntPtr cycle_child_focus;
	public IntPtr toggle_handle_focus;
	public IntPtr move_handle;
	public IntPtr cycle_handle_focus;
	public IntPtr accept_position;
	public IntPtr cancel_position;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
