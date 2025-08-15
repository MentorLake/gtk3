namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Error codes returned by option parsing.
/// </para>
/// </summary>

[Flags]
public enum GOptionError
{
/// <summary>
/// <para>
/// An option was not known to the parser.
///  This error will only be reported, if the parser hasn&apos;t been instructed
///  to ignore unknown options, see g_option_context_set_ignore_unknown_options().
/// </para>
/// </summary>

	G_OPTION_ERROR_UNKNOWN_OPTION = 0,
/// <summary>
/// <para>
/// A value couldn&apos;t be parsed.
/// </para>
/// </summary>

	G_OPTION_ERROR_BAD_VALUE = 1,
/// <summary>
/// <para>
/// A #GOptionArgFunc callback failed.
/// </para>
/// </summary>

	G_OPTION_ERROR_FAILED = 2
}
