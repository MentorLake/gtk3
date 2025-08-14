namespace MentorLake.Pango;

/// <summary>
/// <para>
/// An enumeration specifying capitalization variant of the font.
/// </para>
/// </summary>

[Flags]
public enum PangoVariant
{
/// <summary>
/// <para>
/// A normal font.
/// </para>
/// </summary>

	PANGO_VARIANT_NORMAL = 0,
/// <summary>
/// <para>
/// A font with the lower case characters
///   replaced by smaller variants of the capital characters.
/// </para>
/// </summary>

	PANGO_VARIANT_SMALL_CAPS = 1,
/// <summary>
/// <para>
/// A font with all characters
///   replaced by smaller variants of the capital characters. Since: 1.50
/// </para>
/// </summary>

	PANGO_VARIANT_ALL_SMALL_CAPS = 2,
/// <summary>
/// <para>
/// A font with the lower case characters
///   replaced by smaller variants of the capital characters.
///   Petite Caps can be even smaller than Small Caps. Since: 1.50
/// </para>
/// </summary>

	PANGO_VARIANT_PETITE_CAPS = 3,
/// <summary>
/// <para>
/// A font with all characters
///   replaced by smaller variants of the capital characters.
///   Petite Caps can be even smaller than Small Caps. Since: 1.50
/// </para>
/// </summary>

	PANGO_VARIANT_ALL_PETITE_CAPS = 4,
/// <summary>
/// <para>
/// A font with the upper case characters
///   replaced by smaller variants of the capital letters. Since: 1.50
/// </para>
/// </summary>

	PANGO_VARIANT_UNICASE = 5,
/// <summary>
/// <para>
/// A font with capital letters that
///   are more suitable for all-uppercase titles. Since: 1.50
/// </para>
/// </summary>

	PANGO_VARIANT_TITLE_CAPS = 6
}
