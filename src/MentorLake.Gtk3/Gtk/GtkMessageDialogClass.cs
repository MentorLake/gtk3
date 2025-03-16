namespace MentorLake.Gtk;

public class GtkMessageDialogClassHandle : BaseSafeHandle
{
}


public static class GtkMessageDialogClassExtensions
{

	public static GtkMessageDialogClass Dereference(this GtkMessageDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkMessageDialogClass>(x.DangerousGetHandle());
}
internal class GtkMessageDialogClassExterns
{
}

public struct GtkMessageDialogClass
{
	public GtkDialogClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
