namespace MentorLake.Gtk;

public class GtkRecentChooserDialogClassHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserDialogClassExtensions
{

	public static GtkRecentChooserDialogClass Dereference(this GtkRecentChooserDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserDialogClass>(x.DangerousGetHandle());
}
internal class GtkRecentChooserDialogClassExterns
{
}

public struct GtkRecentChooserDialogClass
{
	public GtkDialogClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
