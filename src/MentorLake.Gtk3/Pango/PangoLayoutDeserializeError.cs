namespace MentorLake.Pango;

/// <summary>
/// <para>
/// Errors that can be returned by [func@Pango.Layout.deserialize].
/// </para>
/// </summary>

[Flags]
public enum PangoLayoutDeserializeError
{
/// <summary>
/// <para>
/// Unspecified error
/// </para>
/// </summary>

	PANGO_LAYOUT_DESERIALIZE_INVALID = 0,
/// <summary>
/// <para>
/// A JSon value could not be
///   interpreted
/// </para>
/// </summary>

	PANGO_LAYOUT_DESERIALIZE_INVALID_VALUE = 1,
/// <summary>
/// <para>
/// A required JSon member was
///   not found
/// </para>
/// </summary>

	PANGO_LAYOUT_DESERIALIZE_MISSING_VALUE = 2
}
