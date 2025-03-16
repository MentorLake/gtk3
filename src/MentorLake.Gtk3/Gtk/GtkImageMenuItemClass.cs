namespace MentorLake.Gtk;

public class GtkImageMenuItemClassHandle : BaseSafeHandle
{
}


public static class GtkImageMenuItemClassExtensions
{

	public static GtkImageMenuItemClass Dereference(this GtkImageMenuItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkImageMenuItemClass>(x.DangerousGetHandle());
}
internal class GtkImageMenuItemClassExterns
{
}

public struct GtkImageMenuItemClass
{
	public GtkMenuItemClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
