namespace MentorLake.Gtk;

public class GtkFileChooserWidgetClassHandle : BaseSafeHandle
{
}


public static class GtkFileChooserWidgetClassExtensions
{

	public static GtkFileChooserWidgetClass Dereference(this GtkFileChooserWidgetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkFileChooserWidgetClass>(x.DangerousGetHandle());
}
internal class GtkFileChooserWidgetClassExterns
{
}

public struct GtkFileChooserWidgetClass
{
	public GtkBoxClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
