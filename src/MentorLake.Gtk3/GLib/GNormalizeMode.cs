namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Defines how a Unicode string is transformed in a canonical
/// form, standardizing such issues as whether a character with
/// an accent is represented as a base character and combining
/// accent or as a single precomposed character. Unicode strings
/// should generally be normalized before comparing them.
/// </para>
/// </summary>

[Flags]
public enum GNormalizeMode
{
/// <summary>
/// <para>
/// standardize differences that do not affect the
///     text content, such as the above-mentioned accent representation
/// </para>
/// </summary>

	G_NORMALIZE_DEFAULT = 0,
/// <summary>
/// <para>
/// another name for %G_NORMALIZE_DEFAULT
/// </para>
/// </summary>

	G_NORMALIZE_NFD = 0,
/// <summary>
/// <para>
/// like %G_NORMALIZE_DEFAULT, but with
///     composed forms rather than a maximally decomposed form
/// </para>
/// </summary>

	G_NORMALIZE_DEFAULT_COMPOSE = 1,
/// <summary>
/// <para>
/// another name for %G_NORMALIZE_DEFAULT_COMPOSE
/// </para>
/// </summary>

	G_NORMALIZE_NFC = 1,
/// <summary>
/// <para>
/// beyond %G_NORMALIZE_DEFAULT also standardize the
///     "compatibility" characters in Unicode, such as SUPERSCRIPT THREE
///     to the standard forms (in this case DIGIT THREE). Formatting
///     information may be lost but for most text operations such
///     characters should be considered the same
/// </para>
/// </summary>

	G_NORMALIZE_ALL = 2,
/// <summary>
/// <para>
/// another name for %G_NORMALIZE_ALL
/// </para>
/// </summary>

	G_NORMALIZE_NFKD = 2,
/// <summary>
/// <para>
/// like %G_NORMALIZE_ALL, but with composed
///     forms rather than a maximally decomposed form
/// </para>
/// </summary>

	G_NORMALIZE_ALL_COMPOSE = 3,
/// <summary>
/// <para>
/// another name for %G_NORMALIZE_ALL_COMPOSE
/// </para>
/// </summary>

	G_NORMALIZE_NFKC = 3
}
