namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The type of #hb_buffer_t contents.
/// </para>
/// </summary>

[Flags]
public enum hb_buffer_content_type_t
{
/// <summary>
/// <para>
/// Initial value for new buffer.
/// </para>
/// </summary>

	HB_BUFFER_CONTENT_TYPE_INVALID = 0,
/// <summary>
/// <para>
/// The buffer contains input characters (before shaping).
/// </para>
/// </summary>

	HB_BUFFER_CONTENT_TYPE_UNICODE = 1,
/// <summary>
/// <para>
/// The buffer contains output glyphs (after shaping).
/// </para>
/// </summary>

	HB_BUFFER_CONTENT_TYPE_GLYPHS = 2
}
