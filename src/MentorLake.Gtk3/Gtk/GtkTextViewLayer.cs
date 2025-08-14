namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Used to reference the layers of #GtkTextView for the purpose of customized
/// drawing with the ::draw_layer vfunc.
/// </para>
/// </summary>

[Flags]
public enum GtkTextViewLayer
{
/// <summary>
/// <para>
/// Old deprecated layer, use %GTK_TEXT_VIEW_LAYER_BELOW_TEXT instead
/// </para>
/// </summary>

	GTK_TEXT_VIEW_LAYER_BELOW = 0,
/// <summary>
/// <para>
/// Old deprecated layer, use %GTK_TEXT_VIEW_LAYER_ABOVE_TEXT instead
/// </para>
/// </summary>

	GTK_TEXT_VIEW_LAYER_ABOVE = 1,
/// <summary>
/// <para>
/// The layer rendered below the text (but above the background).  Since: 3.20
/// </para>
/// </summary>

	GTK_TEXT_VIEW_LAYER_BELOW_TEXT = 2,
/// <summary>
/// <para>
/// The layer rendered above the text.  Since: 3.20
/// </para>
/// </summary>

	GTK_TEXT_VIEW_LAYER_ABOVE_TEXT = 3
}
