namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The different types of sections indicate parts of a CSS document as
/// parsed by GTK’s CSS parser. They are oriented towards the
/// [CSS Grammar](http://www.w3.org/TR/CSS21/grammar.html),
/// but may contain extensions.
/// </para>
/// <para>
/// More types might be added in the future as the parser incorporates
/// more features.
/// </para>
/// </summary>

[Flags]
public enum GtkCssSectionType
{
/// <summary>
/// <para>
/// The section describes a complete document.
///   This section time is the only one where gtk_css_section_get_parent()
///   might return %NULL.
/// </para>
/// </summary>

	GTK_CSS_SECTION_DOCUMENT = 0,
/// <summary>
/// <para>
/// The section defines an import rule.
/// </para>
/// </summary>

	GTK_CSS_SECTION_IMPORT = 1,
/// <summary>
/// <para>
/// The section defines a color. This
///   is a GTK extension to CSS.
/// </para>
/// </summary>

	GTK_CSS_SECTION_COLOR_DEFINITION = 2,
/// <summary>
/// <para>
/// The section defines a binding set. This
///   is a GTK extension to CSS.
/// </para>
/// </summary>

	GTK_CSS_SECTION_BINDING_SET = 3,
/// <summary>
/// <para>
/// The section defines a CSS ruleset.
/// </para>
/// </summary>

	GTK_CSS_SECTION_RULESET = 4,
/// <summary>
/// <para>
/// The section defines a CSS selector.
/// </para>
/// </summary>

	GTK_CSS_SECTION_SELECTOR = 5,
/// <summary>
/// <para>
/// The section defines the declaration of
///   a CSS variable.
/// </para>
/// </summary>

	GTK_CSS_SECTION_DECLARATION = 6,
/// <summary>
/// <para>
/// The section defines the value of a CSS declaration.
/// </para>
/// </summary>

	GTK_CSS_SECTION_VALUE = 7,
/// <summary>
/// <para>
/// The section defines keyframes. See [CSS
///   Animations](http://dev.w3.org/csswg/css3-animations/#keyframes) for details. Since 3.6
/// </para>
/// </summary>

	GTK_CSS_SECTION_KEYFRAMES = 8
}
