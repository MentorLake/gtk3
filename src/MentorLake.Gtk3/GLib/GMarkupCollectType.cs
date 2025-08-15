namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A mixed enumerated type and flags field. You must specify one type
/// (string, strdup, boolean, tristate).  Additionally, you may  optionally
/// bitwise OR the type with the flag %G_MARKUP_COLLECT_OPTIONAL.
/// </para>
/// <para>
/// It is likely that this enum will be extended in the future to
/// support other types.
/// </para>
/// </summary>

[Flags]
public enum GMarkupCollectType : uint
{
/// <summary>
/// <para>
/// used to terminate the list of attributes
///     to collect
/// </para>
/// </summary>

	G_MARKUP_COLLECT_INVALID = 0,
/// <summary>
/// <para>
/// collect the string pointer directly from
///     the attribute_values[] array. Expects a parameter of type (const
///     char **). If %G_MARKUP_COLLECT_OPTIONAL is specified and the
///     attribute isn&apos;t present then the pointer will be set to %NULL
/// </para>
/// </summary>

	G_MARKUP_COLLECT_STRING = 1,
/// <summary>
/// <para>
/// as with %G_MARKUP_COLLECT_STRING, but
///     expects a parameter of type (char **) and g_strdup()s the
///     returned pointer. The pointer must be freed with g_free()
/// </para>
/// </summary>

	G_MARKUP_COLLECT_STRDUP = 2,
/// <summary>
/// <para>
/// expects a parameter of type (gboolean *)
///     and parses the attribute value as a boolean. Sets %FALSE if the
///     attribute isn&apos;t present. Valid boolean values consist of
///     (case-insensitive) &quot;false&quot;, &quot;f&quot;, &quot;no&quot;, &quot;n&quot;, &quot;0&quot; and &quot;true&quot;, &quot;t&quot;,
///     &quot;yes&quot;, &quot;y&quot;, &quot;1&quot;
/// </para>
/// </summary>

	G_MARKUP_COLLECT_BOOLEAN = 3,
/// <summary>
/// <para>
/// as with %G_MARKUP_COLLECT_BOOLEAN, but
///     in the case of a missing attribute a value is set that compares
///     equal to neither %FALSE nor %TRUE G_MARKUP_COLLECT_OPTIONAL is
///     implied
/// </para>
/// </summary>

	G_MARKUP_COLLECT_TRISTATE = 4,
/// <summary>
/// <para>
/// can be bitwise ORed with the other fields.
///     If present, allows the attribute not to appear. A default value
///     is set depending on what value type is used
/// </para>
/// </summary>

	G_MARKUP_COLLECT_OPTIONAL = 65536
}
