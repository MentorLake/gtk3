namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The #GOptionArg enum values determine which type of extra argument the
/// options expect to find. If an option expects an extra argument, it can
/// be specified in several ways; with a short option: `-x arg`, with a long
/// option: `--name arg` or combined in a single argument: `--name=arg`.
/// </para>
/// </summary>

[Flags]
public enum GOptionArg
{
/// <summary>
/// <para>
/// No extra argument. This is useful for simple flags or booleans.
/// </para>
/// </summary>

	G_OPTION_ARG_NONE = 0,
/// <summary>
/// <para>
/// The option takes a UTF-8 string argument.
/// </para>
/// </summary>

	G_OPTION_ARG_STRING = 1,
/// <summary>
/// <para>
/// The option takes an integer argument.
/// </para>
/// </summary>

	G_OPTION_ARG_INT = 2,
/// <summary>
/// <para>
/// The option provides a callback (of type
///     #GOptionArgFunc) to parse the extra argument.
/// </para>
/// </summary>

	G_OPTION_ARG_CALLBACK = 3,
/// <summary>
/// <para>
/// The option takes a filename as argument, which will
///        be in the GLib filename encoding rather than UTF-8.
/// </para>
/// </summary>

	G_OPTION_ARG_FILENAME = 4,
/// <summary>
/// <para>
/// The option takes a string argument, multiple
///     uses of the option are collected into an array of strings.
/// </para>
/// </summary>

	G_OPTION_ARG_STRING_ARRAY = 5,
/// <summary>
/// <para>
/// The option takes a filename as argument,
///     multiple uses of the option are collected into an array of strings.
/// </para>
/// </summary>

	G_OPTION_ARG_FILENAME_ARRAY = 6,
/// <summary>
/// <para>
/// The option takes a double argument. The argument
///     can be formatted either for the user&apos;s locale or for the &quot;C&quot; locale.
///     Since 2.12
/// </para>
/// </summary>

	G_OPTION_ARG_DOUBLE = 7,
/// <summary>
/// <para>
/// The option takes a 64-bit integer. Like
///     %G_OPTION_ARG_INT but for larger numbers. The number can be in
///     decimal base, or in hexadecimal (when prefixed with `0x`, for
///     example, `0xffffffff`). Since 2.12
/// </para>
/// </summary>

	G_OPTION_ARG_INT64 = 8
}
