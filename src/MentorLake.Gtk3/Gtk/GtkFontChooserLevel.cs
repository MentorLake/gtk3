namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// This enumeration specifies the granularity of font selection
/// that is desired in a font chooser.
/// </para>
/// <para>
/// This enumeration may be extended in the future; applications should
/// ignore unknown values.
/// </para>
/// </summary>

[Flags]
public enum GtkFontChooserLevel : uint
{
/// <summary>
/// <para>
/// Allow selecting a font family
/// </para>
/// </summary>

	GTK_FONT_CHOOSER_LEVEL_FAMILY = 0,
/// <summary>
/// <para>
/// Allow selecting a specific font face
/// </para>
/// </summary>

	GTK_FONT_CHOOSER_LEVEL_STYLE = 1,
/// <summary>
/// <para>
/// Allow selecting a specific font size
/// </para>
/// </summary>

	GTK_FONT_CHOOSER_LEVEL_SIZE = 2,

	GTK_FONT_CHOOSER_LEVEL_VARIATIONS = 4,
/// <summary>
/// <para>
/// Allow selecting specific OpenType font features
/// </para>
/// </summary>

	GTK_FONT_CHOOSER_LEVEL_FEATURES = 8
}
