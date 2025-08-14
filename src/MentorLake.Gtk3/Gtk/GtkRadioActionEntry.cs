namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRadioActionEntry structs are used with
/// gtk_action_group_add_radio_actions() to construct groups of radio actions.
/// </para>
/// </summary>

public class GtkRadioActionEntryHandle : BaseSafeHandle
{
}


public static class GtkRadioActionEntryExtensions
{

	public static GtkRadioActionEntry Dereference(this GtkRadioActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRadioActionEntry>(x.DangerousGetHandle());
}
internal class GtkRadioActionEntryExterns
{
}

/// <summary>
/// <para>
/// #GtkRadioActionEntry structs are used with
/// gtk_action_group_add_radio_actions() to construct groups of radio actions.
/// </para>
/// </summary>

public struct GtkRadioActionEntry
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
/// The value to set on the radio action. See
///  gtk_radio_action_get_current_value().
/// </para>
/// </summary>

public int value;
}
