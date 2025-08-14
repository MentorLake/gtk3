namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkToggleActionEntry structs are used with
/// gtk_action_group_add_toggle_actions() to construct toggle actions.
/// </para>
/// </summary>

public class GtkToggleActionEntryHandle : BaseSafeHandle
{
}


public static class GtkToggleActionEntryExtensions
{

	public static GtkToggleActionEntry Dereference(this GtkToggleActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkToggleActionEntry>(x.DangerousGetHandle());
}
internal class GtkToggleActionEntryExterns
{
}

/// <summary>
/// <para>
/// #GtkToggleActionEntry structs are used with
/// gtk_action_group_add_toggle_actions() to construct toggle actions.
/// </para>
/// </summary>

public struct GtkToggleActionEntry
{
	/// <summary>
/// <para>
/// The name of the action.
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// The stock id for the action, or the name of an icon from the
///  icon theme.
/// </para>
/// </summary>

public string stock_id;
	/// <summary>
/// <para>
/// The label for the action. This field should typically be marked
///  for translation, see gtk_action_group_set_translation_domain().
/// </para>
/// </summary>

public string label;
	/// <summary>
/// <para>
/// The accelerator for the action, in the format understood by
///  gtk_accelerator_parse().
/// </para>
/// </summary>

public string accelerator;
	/// <summary>
/// <para>
/// The tooltip for the action. This field should typically be
///  marked for translation, see gtk_action_group_set_translation_domain().
/// </para>
/// </summary>

public string tooltip;
	/// <summary>
/// <para>
/// The function to call when the action is activated.
/// </para>
/// </summary>

public GCallback callback;
	/// <summary>
/// <para>
/// The initial state of the toggle action.
/// </para>
/// </summary>

public bool is_active;
}
