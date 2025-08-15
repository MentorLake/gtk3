namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Flags which modify individual options.
/// </para>
/// </summary>

[Flags]
public enum GOptionFlags : uint
{
/// <summary>
/// <para>
/// No flags. Since: 2.42.
/// </para>
/// </summary>

	G_OPTION_FLAG_NONE = 0,
/// <summary>
/// <para>
/// The option doesn&apos;t appear in `--help` output.
/// </para>
/// </summary>

	G_OPTION_FLAG_HIDDEN = 1,
/// <summary>
/// <para>
/// The option appears in the main section of the
///     `--help` output, even if it is defined in a group.
/// </para>
/// </summary>

	G_OPTION_FLAG_IN_MAIN = 2,
/// <summary>
/// <para>
/// For options of the %G_OPTION_ARG_NONE kind, this
///     flag indicates that the sense of the option is reversed. i.e. %FALSE will
///     be stored into the argument rather than %TRUE.
/// </para>
/// </summary>

	G_OPTION_FLAG_REVERSE = 4,
/// <summary>
/// <para>
/// For options of the %G_OPTION_ARG_CALLBACK kind,
///     this flag indicates that the callback does not take any argument
///     (like a %G_OPTION_ARG_NONE option). Since 2.8
/// </para>
/// </summary>

	G_OPTION_FLAG_NO_ARG = 8,
/// <summary>
/// <para>
/// For options of the %G_OPTION_ARG_CALLBACK
///     kind, this flag indicates that the argument should be passed to the
///     callback in the GLib filename encoding rather than UTF-8. Since 2.8
/// </para>
/// </summary>

	G_OPTION_FLAG_FILENAME = 16,
/// <summary>
/// <para>
/// For options of the %G_OPTION_ARG_CALLBACK
///     kind, this flag indicates that the argument supply is optional.
///     If no argument is given then data of %GOptionParseFunc will be
///     set to NULL. Since 2.8
/// </para>
/// </summary>

	G_OPTION_FLAG_OPTIONAL_ARG = 32,
/// <summary>
/// <para>
/// This flag turns off the automatic conflict
///     resolution which prefixes long option names with `groupname-` if
///     there is a conflict. This option should only be used in situations
///     where aliasing is necessary to model some legacy commandline interface.
///     It is not safe to use this option, unless all option groups are under
///     your direct control. Since 2.8.
/// </para>
/// </summary>

	G_OPTION_FLAG_NOALIAS = 64
}
