namespace MentorLake.GObject;

/// <summary>
/// <para>
/// Through the #GParamFlags flag values, certain aspects of parameters
/// can be configured.
/// </para>
/// <para>
/// See also: %G_PARAM_STATIC_STRINGS
/// </para>
/// </summary>

[Flags]
public enum GParamFlags : uint
{
/// <summary>
/// <para>
/// the parameter is readable
/// </para>
/// </summary>

	G_PARAM_READABLE = 1,
/// <summary>
/// <para>
/// the parameter is writable
/// </para>
/// </summary>

	G_PARAM_WRITABLE = 2,
/// <summary>
/// <para>
/// alias for %G_PARAM_READABLE | %G_PARAM_WRITABLE
/// </para>
/// </summary>

	G_PARAM_READWRITE = 3,
/// <summary>
/// <para>
/// the parameter will be set upon object construction.
///   See [vfunc@Object.constructed] for more details
/// </para>
/// </summary>

	G_PARAM_CONSTRUCT = 4,
/// <summary>
/// <para>
/// the parameter can only be set upon object construction.
///   See [vfunc@Object.constructed] for more details
/// </para>
/// </summary>

	G_PARAM_CONSTRUCT_ONLY = 8,
/// <summary>
/// <para>
/// upon parameter conversion (see g_param_value_convert())
///  strict validation is not required
/// </para>
/// </summary>

	G_PARAM_LAX_VALIDATION = 16,
/// <summary>
/// <para>
/// the string used as name when constructing the
///  parameter is guaranteed to remain valid and
///  unmodified for the lifetime of the parameter.
///  Since 2.8
/// </para>
/// </summary>

	G_PARAM_STATIC_NAME = 32,
/// <summary>
/// <para>
/// internal
/// </para>
/// </summary>

	G_PARAM_PRIVATE = 32,
/// <summary>
/// <para>
/// the string used as nick when constructing the
///  parameter is guaranteed to remain valid and
///  unmmodified for the lifetime of the parameter.
///  Since 2.8
/// </para>
/// </summary>

	G_PARAM_STATIC_NICK = 64,
/// <summary>
/// <para>
/// the string used as blurb when constructing the
///  parameter is guaranteed to remain valid and
///  unmodified for the lifetime of the parameter.
///  Since 2.8
/// </para>
/// </summary>

	G_PARAM_STATIC_BLURB = 128,
/// <summary>
/// <para>
/// calls to g_object_set_property() for this
///   property will not automatically result in a &quot;notify&quot; signal being
///   emitted: the implementation must call g_object_notify() themselves
///   in case the property actually changes.  Since: 2.42.
/// </para>
/// </summary>

	G_PARAM_EXPLICIT_NOTIFY = 1073741824,
/// <summary>
/// <para>
/// the parameter is deprecated and will be removed
///  in a future version. A warning will be generated if it is used
///  while running with G_ENABLE_DIAGNOSTIC=1.
///  Since 2.26
/// </para>
/// </summary>

	G_PARAM_DEPRECATED = 2147483648
}
