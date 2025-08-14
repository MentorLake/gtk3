namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkActionEntry structs are used with gtk_action_group_add_actions() to
/// construct actions.
/// </para>
/// </summary>

public class GtkActionEntryHandle : BaseSafeHandle
{
}


public static class GtkActionEntryExtensions
{

	public static GtkActionEntry Dereference(this GtkActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkActionEntry>(x.DangerousGetHandle());
}
internal class GtkActionEntryExterns
{
}

/// <summary>
/// <para>
/// #GtkActionEntry structs are used with gtk_action_group_add_actions() to
/// construct actions.
/// </para>
/// </summary>

public struct GtkActionEntry
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
///  for translation, see gtk_action_group_set_translation_domain(). If
///  @label is %NULL, the label of the stock item with id @stock_id is used.
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
}
