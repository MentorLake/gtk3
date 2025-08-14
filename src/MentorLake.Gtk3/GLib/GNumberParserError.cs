namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by functions converting a string to a number.
/// </para>
/// </summary>

[Flags]
public enum GNumberParserError
{
/// <summary>
/// <para>
/// string was not a valid number
/// </para>
/// </summary>

	G_NUMBER_PARSER_ERROR_INVALID = 0,
/// <summary>
/// <para>
/// string was a number, but out of bounds
/// </para>
/// </summary>

	G_NUMBER_PARSER_ERROR_OUT_OF_BOUNDS = 1
}
