namespace MentorLake.Gtk;

public class GtkRecentChooserWidgetClassHandle : BaseSafeHandle
{
}


public static class GtkRecentChooserWidgetClassExtensions
{

	public static GtkRecentChooserWidgetClass Dereference(this GtkRecentChooserWidgetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRecentChooserWidgetClass>(x.DangerousGetHandle());
}
internal class GtkRecentChooserWidgetClassExterns
{
}

public struct GtkRecentChooserWidgetClass
{
	public GtkBoxClass parent_class;
	public IntPtr _gtk_reserved1;
	public IntPtr _gtk_reserved2;
	public IntPtr _gtk_reserved3;
	public IntPtr _gtk_reserved4;
}
