namespace MentorLake.Gtk;

public class GtkSeparatorClassHandle : BaseSafeHandle
{
}


public static class GtkSeparatorClassExtensions
{

	public static GtkSeparatorClass Dereference(this GtkSeparatorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkSeparatorClass>(x.DangerousGetHandle());
}
internal class GtkSeparatorClassExterns
{
}

public struct GtkSeparatorClass
{
	public GtkWidgetClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
