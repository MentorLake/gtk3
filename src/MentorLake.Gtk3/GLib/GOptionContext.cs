namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GOptionContext` struct defines which options
/// are accepted by the commandline option parser. The struct has only private
/// fields and should not be directly accessed.
/// </para>
/// </summary>

public class GOptionContextHandle : BaseSafeHandle
{
}


public static class GOptionContextExtensions
{
/// <summary>
/// <para>
/// Adds a #GOptionGroup to the @context, so that parsing with @context
/// will recognize the options in the group. Note that this will take
/// ownership of the @group and thus the @group should not be freed.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="group">
/// the group to add
/// </param>

	public static void AddGroup(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionGroupHandle group)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_add_group(context, group);
	}

/// <summary>
/// <para>
/// A convenience function which creates a main group if it doesn&apos;t
/// exist, adds the @entries to it and sets the translation domain.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="entries">
/// a %NULL-terminated array of #GOptionEntrys
/// </param>
/// <param name="translation_domain">
/// a translation domain to use for translating
///    the `--help` output for the options in @entries
///    with gettext(), or %NULL
/// </param>

	public static void AddMainEntries(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionEntry[] entries, string translation_domain)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_add_main_entries(context, entries, translation_domain);
	}

/// <summary>
/// <para>
/// Frees context and all the groups which have been
/// added to it.
/// </para>
/// <para>
/// Please note that parsed arguments need to be freed separately (see
/// #GOptionEntry).
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>

	public static void Free(this MentorLake.GLib.GOptionContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_free(context);
	}

/// <summary>
/// <para>
/// Returns the description. See g_option_context_set_description().
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <return>
/// the description
/// </return>

	public static string GetDescription(this MentorLake.GLib.GOptionContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		return GOptionContextExterns.g_option_context_get_description(context);
	}

/// <summary>
/// <para>
/// Returns a formatted, translated help text for the given context.
/// To obtain the text produced by `--help`, call
/// `g_option_context_get_help (context, TRUE, NULL)`.
/// To obtain the text produced by `--help-all`, call
/// `g_option_context_get_help (context, FALSE, NULL)`.
/// To obtain the help text for an option group, call
/// `g_option_context_get_help (context, FALSE, group)`.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="main_help">
/// if %TRUE, only include the main group
/// </param>
/// <param name="group">
/// the #GOptionGroup to create help for, or %NULL
/// </param>
/// <return>
/// A newly allocated string containing the help text
/// </return>

	public static string GetHelp(this MentorLake.GLib.GOptionContextHandle context, bool main_help, MentorLake.GLib.GOptionGroupHandle group)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		return GOptionContextExterns.g_option_context_get_help(context, main_help, group);
	}

/// <summary>
/// <para>
/// Returns whether automatic `--help` generation
/// is turned on for @context. See g_option_context_set_help_enabled().
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <return>
/// %TRUE if automatic help generation is turned on.
/// </return>

	public static bool GetHelpEnabled(this MentorLake.GLib.GOptionContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		return GOptionContextExterns.g_option_context_get_help_enabled(context);
	}

/// <summary>
/// <para>
/// Returns whether unknown options are ignored or not. See
/// g_option_context_set_ignore_unknown_options().
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <return>
/// %TRUE if unknown options are ignored.
/// </return>

	public static bool GetIgnoreUnknownOptions(this MentorLake.GLib.GOptionContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		return GOptionContextExterns.g_option_context_get_ignore_unknown_options(context);
	}

/// <summary>
/// <para>
/// Returns a pointer to the main group of @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <return>
/// the main group of @context, or %NULL if
///  @context doesn&apos;t have a main group. Note that group belongs to
///  @context and should not be modified or freed.
/// </return>

	public static MentorLake.GLib.GOptionGroupHandle GetMainGroup(this MentorLake.GLib.GOptionContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		return GOptionContextExterns.g_option_context_get_main_group(context);
	}

/// <summary>
/// <para>
/// Returns whether strict POSIX code is enabled.
/// </para>
/// <para>
/// See g_option_context_set_strict_posix() for more information.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <return>
/// %TRUE if strict POSIX is enabled, %FALSE otherwise.
/// </return>

	public static bool GetStrictPosix(this MentorLake.GLib.GOptionContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		return GOptionContextExterns.g_option_context_get_strict_posix(context);
	}

/// <summary>
/// <para>
/// Returns the summary. See g_option_context_set_summary().
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <return>
/// the summary
/// </return>

	public static string GetSummary(this MentorLake.GLib.GOptionContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		return GOptionContextExterns.g_option_context_get_summary(context);
	}

/// <summary>
/// <para>
/// Parses the command line arguments, recognizing options
/// which have been added to @context. A side-effect of
/// calling this function is that g_set_prgname() will be
/// called.
/// </para>
/// <para>
/// If the parsing is successful, any parsed arguments are
/// removed from the array and @argc and @argv are updated
/// accordingly. A &apos;--&apos; option is stripped from @argv
/// unless there are unparsed options before and after it,
/// or some of the options after it start with &apos;-&apos;. In case
/// of an error, @argc and @argv are left unmodified.
/// </para>
/// <para>
/// If automatic `--help` support is enabled
/// (see g_option_context_set_help_enabled()), and the
/// @argv array contains one of the recognized help options,
/// this function will produce help output to stdout and
/// call `exit (0)`.
/// </para>
/// <para>
/// Note that function depends on the [current locale][setlocale] for
/// automatic character set conversion of string and filename
/// arguments.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="argc">
/// a pointer to the number of command line arguments
/// </param>
/// <param name="argv">
/// a pointer to the array of command line arguments
/// </param>
/// <return>
/// %TRUE if the parsing was successful,
///               %FALSE if an error occurred
/// </return>

	public static bool Parse(this MentorLake.GLib.GOptionContextHandle context, ref int argc, ref string[] argv)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		var externCallResult = GOptionContextExterns.g_option_context_parse(context, ref argc, ref argv, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses the command line arguments.
/// </para>
/// <para>
/// This function is similar to g_option_context_parse() except that it
/// respects the normal memory rules when dealing with a strv instead of
/// assuming that the passed-in array is the argv of the main function.
/// </para>
/// <para>
/// In particular, strings that are removed from the arguments list will
/// be freed using g_free().
/// </para>
/// <para>
/// On Windows, the strings are expected to be in UTF-8.  This is in
/// contrast to g_option_context_parse() which expects them to be in the
/// system codepage, which is how they are passed as @argv to main().
/// See g_win32_get_command_line() for a solution.
/// </para>
/// <para>
/// This function is useful if you are trying to use #GOptionContext with
/// #GApplication.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="arguments">
/// a pointer
///    to the command line arguments (which must be in UTF-8 on Windows).
///    Starting with GLib 2.62, @arguments can be %NULL, which matches
///    g_option_context_parse().
/// </param>
/// <return>
/// %TRUE if the parsing was successful,
///          %FALSE if an error occurred
/// </return>

	public static bool ParseStrv(this MentorLake.GLib.GOptionContextHandle context, ref string[] arguments)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		var externCallResult = GOptionContextExterns.g_option_context_parse_strv(context, ref arguments, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Adds a string to be displayed in `--help` output after the list
/// of options. This text often includes a bug reporting address.
/// </para>
/// <para>
/// Note that the summary is translated (see
/// g_option_context_set_translate_func()).
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="description">
/// a string to be shown in `--help` output
///   after the list of options, or %NULL
/// </param>

	public static void SetDescription(this MentorLake.GLib.GOptionContextHandle context, string description)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_description(context, description);
	}

/// <summary>
/// <para>
/// Enables or disables automatic generation of `--help` output.
/// By default, g_option_context_parse() recognizes `--help`, `-h`,
/// `-?`, `--help-all` and `--help-groupname` and creates suitable
/// output to stdout.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="help_enabled">
/// %TRUE to enable `--help`, %FALSE to disable it
/// </param>

	public static void SetHelpEnabled(this MentorLake.GLib.GOptionContextHandle context, bool help_enabled)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_help_enabled(context, help_enabled);
	}

/// <summary>
/// <para>
/// Sets whether to ignore unknown options or not. If an argument is
/// ignored, it is left in the @argv array after parsing. By default,
/// g_option_context_parse() treats unknown options as error.
/// </para>
/// <para>
/// This setting does not affect non-option arguments (i.e. arguments
/// which don&apos;t start with a dash). But note that GOption cannot reliably
/// determine whether a non-option belongs to a preceding unknown option.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="ignore_unknown">
/// %TRUE to ignore unknown options, %FALSE to produce
///    an error when unknown options are met
/// </param>

	public static void SetIgnoreUnknownOptions(this MentorLake.GLib.GOptionContextHandle context, bool ignore_unknown)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_ignore_unknown_options(context, ignore_unknown);
	}

/// <summary>
/// <para>
/// Sets a #GOptionGroup as main group of the @context.
/// This has the same effect as calling g_option_context_add_group(),
/// the only difference is that the options in the main group are
/// treated differently when generating `--help` output.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="group">
/// the group to set as main group
/// </param>

	public static void SetMainGroup(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionGroupHandle group)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_main_group(context, group);
	}

/// <summary>
/// <para>
/// Sets strict POSIX mode.
/// </para>
/// <para>
/// By default, this mode is disabled.
/// </para>
/// <para>
/// In strict POSIX mode, the first non-argument parameter encountered
/// (eg: filename) terminates argument processing.  Remaining arguments
/// are treated as non-options and are not attempted to be parsed.
/// </para>
/// <para>
/// If strict POSIX mode is disabled then parsing is done in the GNU way
/// where option arguments can be freely mixed with non-options.
/// </para>
/// <para>
/// As an example, consider &quot;ls foo -l&quot;.  With GNU style parsing, this
/// will list &quot;foo&quot; in long mode.  In strict POSIX style, this will list
/// the files named &quot;foo&quot; and &quot;-l&quot;.
/// </para>
/// <para>
/// It may be useful to force strict POSIX mode when creating &quot;verb
/// style&quot; command line tools.  For example, the &quot;gsettings&quot; command line
/// tool supports the global option &quot;--schemadir&quot; as well as many
/// subcommands (&quot;get&quot;, &quot;set&quot;, etc.) which each have their own set of
/// arguments.  Using strict POSIX mode will allow parsing the global
/// options up to the verb name while leaving the remaining options to be
/// parsed by the relevant subcommand (which can be determined by
/// examining the verb name, which should be present in argv[1] after
/// parsing).
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="strict_posix">
/// the new value
/// </param>

	public static void SetStrictPosix(this MentorLake.GLib.GOptionContextHandle context, bool strict_posix)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_strict_posix(context, strict_posix);
	}

/// <summary>
/// <para>
/// Adds a string to be displayed in `--help` output before the list
/// of options. This is typically a summary of the program functionality.
/// </para>
/// <para>
/// Note that the summary is translated (see
/// g_option_context_set_translate_func() and
/// g_option_context_set_translation_domain()).
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="summary">
/// a string to be shown in `--help` output
///  before the list of options, or %NULL
/// </param>

	public static void SetSummary(this MentorLake.GLib.GOptionContextHandle context, string summary)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_summary(context, summary);
	}

/// <summary>
/// <para>
/// Sets the function which is used to translate the contexts
/// user-visible strings, for `--help` output. If @func is %NULL,
/// strings are not translated.
/// </para>
/// <para>
/// Note that option groups have their own translation functions,
/// this function only affects the @parameter_string (see g_option_context_new()),
/// the summary (see g_option_context_set_summary()) and the description
/// (see g_option_context_set_description()).
/// </para>
/// <para>
/// If you are using gettext(), you only need to set the translation
/// domain, see g_option_context_set_translation_domain().
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="func">
/// the #GTranslateFunc, or %NULL
/// </param>
/// <param name="data">
/// user data to pass to @func, or %NULL
/// </param>
/// <param name="destroy_notify">
/// a function which gets called to free @data, or %NULL
/// </param>

	public static void SetTranslateFunc(this MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_translate_func(context, func, data, destroy_notify);
	}

/// <summary>
/// <para>
/// A convenience function to use gettext() for translating
/// user-visible strings.
/// </para>
/// </summary>

/// <param name="context">
/// a #GOptionContext
/// </param>
/// <param name="domain">
/// the domain to use
/// </param>

	public static void SetTranslationDomain(this MentorLake.GLib.GOptionContextHandle context, string domain)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GOptionContext)");
		GOptionContextExterns.g_option_context_set_translation_domain(context, domain);
	}


	public static GOptionContext Dereference(this GOptionContextHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOptionContext>(x.DangerousGetHandle());
}
internal class GOptionContextExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_add_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_add_main_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GOptionEntry[] entries, string translation_domain);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_option_context_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_option_context_get_help([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool main_help, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_get_help_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_get_ignore_unknown_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))]
	internal static extern MentorLake.GLib.GOptionGroupHandle g_option_context_get_main_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_get_strict_posix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_option_context_get_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, ref int argc, ref string[] argv, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_option_context_parse_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, ref string[] arguments, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, string description);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_help_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool help_enabled);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_ignore_unknown_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool ignore_unknown);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_main_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_strict_posix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, bool strict_posix);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_summary([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, string summary);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_translate_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_context_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))] MentorLake.GLib.GOptionContextHandle context, string domain);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionContextHandle>))]
	internal static extern MentorLake.GLib.GOptionContextHandle g_option_context_new(string parameter_string);

}

/// <summary>
/// <para>
/// A `GOptionContext` struct defines which options
/// are accepted by the commandline option parser. The struct has only private
/// fields and should not be directly accessed.
/// </para>
/// </summary>

public struct GOptionContext
{
/// <summary>
/// <para>
/// Creates a new option context.
/// </para>
/// <para>
/// The @parameter_string can serve multiple purposes. It can be used
/// to add descriptions for &quot;rest&quot; arguments, which are not parsed by
/// the #GOptionContext, typically something like &quot;FILES&quot; or
/// &quot;FILE1 FILE2...&quot;. If you are using %G_OPTION_REMAINING for
/// collecting &quot;rest&quot; arguments, GLib handles this automatically by
/// using the @arg_description of the corresponding #GOptionEntry in
/// the usage summary.
/// </para>
/// <para>
/// Another usage is to give a short summary of the program
/// functionality, like &quot; - frob the strings&quot;, which will be displayed
/// in the same line as the usage. For a longer description of the
/// program functionality that should be displayed as a paragraph
/// below the usage line, use g_option_context_set_summary().
/// </para>
/// <para>
/// Note that the @parameter_string is translated using the
/// function set with g_option_context_set_translate_func(), so
/// it should normally be passed untranslated.
/// </para>
/// </summary>

/// <param name="parameter_string">
/// a string which is displayed in
///    the first line of `--help` output, after the usage summary
///    `programname [OPTION...]`
/// </param>
/// <return>
/// a newly created #GOptionContext, which must be
///    freed with g_option_context_free() after use.
/// </return>

	public static MentorLake.GLib.GOptionContextHandle New(string parameter_string)
	{
		return GOptionContextExterns.g_option_context_new(parameter_string);
	}

}
