namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Results returned from g_converter_convert().
/// </para>
/// </summary>

[Flags]
public enum GConverterResult
{
/// <summary>
/// <para>
/// There was an error during conversion.
/// </para>
/// </summary>

	G_CONVERTER_ERROR = 0,
/// <summary>
/// <para>
/// Some data was consumed or produced
/// </para>
/// </summary>

	G_CONVERTER_CONVERTED = 1,
/// <summary>
/// <para>
/// The conversion is finished
/// </para>
/// </summary>

	G_CONVERTER_FINISHED = 2,
/// <summary>
/// <para>
/// Flushing is finished
/// </para>
/// </summary>

	G_CONVERTER_FLUSHED = 3
}
