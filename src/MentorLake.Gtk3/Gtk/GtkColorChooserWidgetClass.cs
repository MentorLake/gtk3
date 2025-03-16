namespace MentorLake.Gtk;

public class GtkColorChooserWidgetClassHandle : BaseSafeHandle
{
}


public static class GtkColorChooserWidgetClassExtensions
{

	public static GtkColorChooserWidgetClass Dereference(this GtkColorChooserWidgetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkColorChooserWidgetClass>(x.DangerousGetHandle());
}
internal class GtkColorChooserWidgetClassExterns
{
}

public struct GtkColorChooserWidgetClass
{
	public GtkBoxClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
	public IntPtr _gtk_reserved5;
	public IntPtr _gtk_reserved6;
	public IntPtr _gtk_reserved7;
	public IntPtr _gtk_reserved8;
}
