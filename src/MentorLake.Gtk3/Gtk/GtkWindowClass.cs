namespace MentorLake.Gtk;

public class GtkWindowClassHandle : BaseSafeHandle
{
}


public static class GtkWindowClassExtensions
{

	public static GtkWindowClass Dereference(this GtkWindowClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWindowClass>(x.DangerousGetHandle());
}
internal class GtkWindowClassExterns
{
}

public struct GtkWindowClass
{
	public GtkBinClass parent_class;
	public IntPtr set_focus;
	public IntPtr activate_focus;
	public IntPtr activate_default;
	public IntPtr keys_changed;
	public IntPtr enable_debugging;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
}
