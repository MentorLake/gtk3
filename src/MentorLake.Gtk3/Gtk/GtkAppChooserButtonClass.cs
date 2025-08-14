namespace MentorLake.Gtk;


public class GtkAppChooserButtonClassHandle : BaseSafeHandle
{
}


public static class GtkAppChooserButtonClassExtensions
{

	public static GtkAppChooserButtonClass Dereference(this GtkAppChooserButtonClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkAppChooserButtonClass>(x.DangerousGetHandle());
}
internal class GtkAppChooserButtonClassExterns
{
}


public struct GtkAppChooserButtonClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkComboBoxClass parent_class;
	/// <summary>
/// <para>
/// Signal emitted when a custom item,
///    previously added with gtk_app_chooser_button_append_custom_item(),
///    is activated from the dropdown menu.
/// </para>
/// </summary>

public IntPtr custom_item_activated;
}
