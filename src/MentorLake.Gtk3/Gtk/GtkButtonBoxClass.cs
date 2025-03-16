namespace MentorLake.Gtk;

public class GtkButtonBoxClassHandle : BaseSafeHandle
{
}


public static class GtkButtonBoxClassExtensions
{

	public static GtkButtonBoxClass Dereference(this GtkButtonBoxClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkButtonBoxClass>(x.DangerousGetHandle());
}
internal class GtkButtonBoxClassExterns
{
}

public struct GtkButtonBoxClass
{
	public GtkBoxClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
