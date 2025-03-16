namespace MentorLake.Gtk;

public class GtkFontChooserDialogClassHandle : BaseSafeHandle
{
}


public static class GtkFontChooserDialogClassExtensions
{

	public static GtkFontChooserDialogClass Dereference(this GtkFontChooserDialogClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFontChooserDialogClass>(x.DangerousGetHandle());
}
internal class GtkFontChooserDialogClassExterns
{
}

public struct GtkFontChooserDialogClass
{
	public GtkDialogClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
