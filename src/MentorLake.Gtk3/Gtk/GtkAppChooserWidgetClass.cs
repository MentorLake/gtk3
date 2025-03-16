namespace MentorLake.Gtk;

public class GtkAppChooserWidgetClassHandle : BaseSafeHandle
{
}


public static class GtkAppChooserWidgetClassExtensions
{

	public static GtkAppChooserWidgetClass Dereference(this GtkAppChooserWidgetClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAppChooserWidgetClass>(x.DangerousGetHandle());
}
internal class GtkAppChooserWidgetClassExterns
{
}

public struct GtkAppChooserWidgetClass
{
	public GtkBoxClass parent_class;
	public IntPtr application_selected;
	public IntPtr application_activated;
	public IntPtr populate_popup;
}
