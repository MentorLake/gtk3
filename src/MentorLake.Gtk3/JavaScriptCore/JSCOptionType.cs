namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Enum values for options types.
/// </para>
/// </summary>

[Flags]
public enum JSCOptionType
{
/// <summary>
/// <para>
/// A #gboolean option type.
/// </para>
/// </summary>

	JSC_OPTION_BOOLEAN = 0,
/// <summary>
/// <para>
/// A #gint option type.
/// </para>
/// </summary>

	JSC_OPTION_INT = 1,
/// <summary>
/// <para>
/// A #guint option type.
/// </para>
/// </summary>

	JSC_OPTION_UINT = 2,
/// <summary>
/// <para>
/// A #gsize options type.
/// </para>
/// </summary>

	JSC_OPTION_SIZE = 3,
/// <summary>
/// <para>
/// A #gdouble options type.
/// </para>
/// </summary>

	JSC_OPTION_DOUBLE = 4,
/// <summary>
/// <para>
/// A string option type.
/// </para>
/// </summary>

	JSC_OPTION_STRING = 5,
/// <summary>
/// <para>
/// A range string option type.
/// </para>
/// </summary>

	JSC_OPTION_RANGE_STRING = 6
}
