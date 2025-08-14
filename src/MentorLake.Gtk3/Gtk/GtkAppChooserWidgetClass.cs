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
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkBoxClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when an application item is
///    selected from the widget’s list.
/// </para>
/// </summary>

public IntPtr application_selected;
	/// <summary>
/// <para>
/// Signal emitted when an application item is
///    activated from the widget’s list.
/// </para>
/// </summary>

public IntPtr application_activated;
	/// <summary>
/// <para>
/// Signal emitted when a context menu is about to
///    popup over an application item.
/// </para>
/// </summary>

public IntPtr populate_popup;
}
