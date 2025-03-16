namespace MentorLake.Gtk;

public class GtkAboutDialogClassHandle : BaseSafeHandle
{
}


public static class GtkAboutDialogClassExtensions
{

	public static GtkAboutDialogClass Dereference(this GtkAboutDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAboutDialogClass>(x.DangerousGetHandle());
}
internal class GtkAboutDialogClassExterns
{
}

public struct GtkAboutDialogClass
{
	public GtkDialogClass parent_class;
	public IntPtr activate_link;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
