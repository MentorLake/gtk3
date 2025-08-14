namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Flags for #hb_buffer_t.
/// </para>
/// </summary>

[Flags]
public enum hb_buffer_flags_t : uint
{
/// <summary>
/// <para>
/// the default buffer flag.
/// </para>
/// </summary>

	HB_BUFFER_FLAG_DEFAULT = 0,
/// <summary>
/// <para>
/// flag indicating that special handling of the beginning
///                      of text paragraph can be applied to this buffer. Should usually
///                      be set, unless you are passing to the buffer only part
///                      of the text without the full context.
/// </para>
/// </summary>

	HB_BUFFER_FLAG_BOT = 1,
/// <summary>
/// <para>
/// flag indicating that special handling of the end of text
///                      paragraph can be applied to this buffer, similar to
///                      @HB_BUFFER_FLAG_BOT.
/// </para>
/// </summary>

	HB_BUFFER_FLAG_EOT = 2,
/// <summary>
/// <para>
/// flag indication that character with Default_Ignorable
///                      Unicode property should use the corresponding glyph
///                      from the font, instead of hiding them (done by
///                      replacing them with the space glyph and zeroing the
///                      advance width.)  This flag takes precedence over
///                      @HB_BUFFER_FLAG_REMOVE_DEFAULT_IGNORABLES.
/// </para>
/// </summary>

	HB_BUFFER_FLAG_PRESERVE_DEFAULT_IGNORABLES = 4,
/// <summary>
/// <para>
/// flag indication that character with Default_Ignorable
///                      Unicode property should be removed from glyph string
///                      instead of hiding them (done by replacing them with the
///                      space glyph and zeroing the advance width.)
///                      @HB_BUFFER_FLAG_PRESERVE_DEFAULT_IGNORABLES takes
///                      precedence over this flag. Since: 1.8.0
/// </para>
/// </summary>

	HB_BUFFER_FLAG_REMOVE_DEFAULT_IGNORABLES = 8,
/// <summary>
/// <para>
/// flag indicating that a dotted circle should
///                      not be inserted in the rendering of incorrect
///                      character sequences (such at <0905 093E>). Since: 2.4.0
/// </para>
/// </summary>

	HB_BUFFER_FLAG_DO_NOT_INSERT_DOTTED_CIRCLE = 16,
/// <summary>
/// <para>
/// flag indicating that the hb_shape() call and its variants
///                      should perform various verification processes on the results
///                      of the shaping operation on the buffer.  If the verification
///                      fails, then either a buffer message is sent, if a message
///                      handler is installed on the buffer, or a message is written
///                      to standard error.  In either case, the shaping result might
///                      be modified to show the failed output. Since: 3.4.0
/// </para>
/// </summary>

	HB_BUFFER_FLAG_VERIFY = 32,
/// <summary>
/// <para>
/// flag indicating that the @HB_GLYPH_FLAG_UNSAFE_TO_CONCAT
///                      glyph-flag should be produced by the shaper. By default
///                      it will not be produced since it incurs a cost. Since: 4.0.0
/// </para>
/// </summary>

	HB_BUFFER_FLAG_PRODUCE_UNSAFE_TO_CONCAT = 64,
/// <summary>
/// <para>
/// flag indicating that the @HB_GLYPH_FLAG_SAFE_TO_INSERT_TATWEEL
///                      glyph-flag should be produced by the shaper. By default
///                      it will not be produced. Since: 5.1.0
/// </para>
/// </summary>

	HB_BUFFER_FLAG_PRODUCE_SAFE_TO_INSERT_TATWEEL = 128,
/// <summary>
/// <para>
/// All currently defined flags: Since: 4.4.0
/// </para>
/// </summary>

	HB_BUFFER_FLAG_DEFINED = 255
}
