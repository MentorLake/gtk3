namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Error codes that identify various errors that can occur while using
/// #GtkBuilder.
/// </para>
/// </summary>

[Flags]
public enum GtkBuilderError
{
/// <summary>
/// <para>
/// A type-func attribute didn’t name
///  a function that returns a #GType.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_INVALID_TYPE_FUNCTION = 0,
/// <summary>
/// <para>
/// The input contained a tag that #GtkBuilder
///  can’t handle.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_UNHANDLED_TAG = 1,
/// <summary>
/// <para>
/// An attribute that is required by
///  #GtkBuilder was missing.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_MISSING_ATTRIBUTE = 2,
/// <summary>
/// <para>
/// #GtkBuilder found an attribute that
///  it doesn’t understand.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_INVALID_ATTRIBUTE = 3,
/// <summary>
/// <para>
/// #GtkBuilder found a tag that
///  it doesn’t understand.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_INVALID_TAG = 4,
/// <summary>
/// <para>
/// A required property value was
///  missing.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_MISSING_PROPERTY_VALUE = 5,
/// <summary>
/// <para>
/// #GtkBuilder couldn’t parse
///  some attribute value.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_INVALID_VALUE = 6,
/// <summary>
/// <para>
/// The input file requires a newer version
///  of GTK+.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_VERSION_MISMATCH = 7,
/// <summary>
/// <para>
/// An object id occurred twice.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_DUPLICATE_ID = 8,
/// <summary>
/// <para>
/// A specified object type is of the same type or
///  derived from the type of the composite class being extended with builder XML.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_OBJECT_TYPE_REFUSED = 9,
/// <summary>
/// <para>
/// The wrong type was specified in a composite class’s template XML
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_TEMPLATE_MISMATCH = 10,
/// <summary>
/// <para>
/// The specified property is unknown for the object class.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_INVALID_PROPERTY = 11,
/// <summary>
/// <para>
/// The specified signal is unknown for the object class.
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_INVALID_SIGNAL = 12,
/// <summary>
/// <para>
/// An object id is unknown
/// </para>
/// </summary>

	GTK_BUILDER_ERROR_INVALID_ID = 13
}
