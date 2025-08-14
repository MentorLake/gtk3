namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The buffer serialization and de-serialization format used in
/// hb_buffer_serialize_glyphs() and hb_buffer_deserialize_glyphs().
/// </para>
/// </summary>

[Flags]
public enum hb_buffer_serialize_format_t
{
/// <summary>
/// <para>
/// a human-readable, plain text format.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FORMAT_TEXT = 1413830740,
/// <summary>
/// <para>
/// a machine-readable JSON format.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FORMAT_JSON = 1246973774,
/// <summary>
/// <para>
/// invalid format.
/// </para>
/// </summary>

	HB_BUFFER_SERIALIZE_FORMAT_INVALID = 0
}
