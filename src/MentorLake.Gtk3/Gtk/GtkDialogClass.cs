namespace MentorLake.Gtk;

public class GtkDialogClassHandle : BaseSafeHandle
{
}


public static class GtkDialogClassExtensions
{

	public static GtkDialogClass Dereference(this GtkDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkDialogClass>(x.DangerousGetHandle());
}
internal class GtkDialogClassExterns
{
}

public struct GtkDialogClass
{
	public GtkWindowClass parent_class;
	public IntPtr response;
	public IntPtr close;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
