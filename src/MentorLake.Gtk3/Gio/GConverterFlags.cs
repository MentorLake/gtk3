namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used when calling a g_converter_convert().
/// </para>
/// </summary>

[Flags]
public enum GConverterFlags : uint
{
/// <summary>
/// <para>
/// No flags.
/// </para>
/// </summary>

	G_CONVERTER_NO_FLAGS = 0,
/// <summary>
/// <para>
/// At end of input data
/// </para>
/// </summary>

	G_CONVERTER_INPUT_AT_END = 1,
/// <summary>
/// <para>
/// Flush data
/// </para>
/// </summary>

	G_CONVERTER_FLUSH = 2
}
