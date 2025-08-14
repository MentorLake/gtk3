namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A GOptionEntry struct defines a single option. To have an effect, they
/// must be added to a #GOptionGroup with g_option_context_add_main_entries()
/// or g_option_group_add_entries().
/// </para>
/// </summary>

public class GOptionEntryHandle : BaseSafeHandle
{
}


public static class GOptionEntryExtensions
{

	public static GOptionEntry Dereference(this GOptionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOptionEntry>(x.DangerousGetHandle());
}
internal class GOptionEntryExterns
{
}

/// <summary>
/// <para>
/// A GOptionEntry struct defines a single option. To have an effect, they
/// must be added to a #GOptionGroup with g_option_context_add_main_entries()
/// or g_option_group_add_entries().
/// </para>
/// </summary>

public struct GOptionEntry
{
	/// <summary>
/// <para>
/// The long name of an option can be used to specify it
///     in a commandline as `--long_name`. Every option must have a
///     long name. To resolve conflicts if multiple option groups contain
///     the same long name, it is also possible to specify the option as
///     `--groupname-long_name`.
/// </para>
/// </summary>

public string long_name;
	/// <summary>
/// <para>
/// If an option has a short name, it can be specified
///     `-short_name` in a commandline. @short_name must be  a printable
///     ASCII character different from '-', or zero if the option has no
///     short name.
/// </para>
/// </summary>

public char short_name;
	/// <summary>
/// <para>
/// Flags from #GOptionFlags
/// </para>
/// </summary>

public int flags;
	/// <summary>
/// <para>
/// The type of the option, as a #GOptionArg
/// </para>
/// </summary>

public GOptionArg arg;
	/// <summary>
/// <para>
/// If the @arg type is %G_OPTION_ARG_CALLBACK, then @arg_data
///     must point to a #GOptionArgFunc callback function, which will be
///     called to handle the extra argument. Otherwise, @arg_data is a
///     pointer to a location to store the value, the required type of
///     the location depends on the @arg type:
///      - %G_OPTION_ARG_NONE: %gboolean
///      - %G_OPTION_ARG_STRING: %gchar*
///      - %G_OPTION_ARG_INT: %gint
///      - %G_OPTION_ARG_FILENAME: %gchar*
///      - %G_OPTION_ARG_STRING_ARRAY: %gchar**
///      - %G_OPTION_ARG_FILENAME_ARRAY: %gchar**
///      - %G_OPTION_ARG_DOUBLE: %gdouble
///     If @arg type is %G_OPTION_ARG_STRING or %G_OPTION_ARG_FILENAME,
///     the location will contain a newly allocated string if the option
///     was given. That string needs to be freed by the callee using g_free().
///     Likewise if @arg type is %G_OPTION_ARG_STRING_ARRAY or
///     %G_OPTION_ARG_FILENAME_ARRAY, the data should be freed using g_strfreev().
/// </para>
/// </summary>

public IntPtr arg_data;
	/// <summary>
/// <para>
/// the description for the option in `--help`
///     output. The @description is translated using the @translate_func
///     of the group, see g_option_group_set_translation_domain().
/// </para>
/// </summary>

public string description;
	/// <summary>
/// <para>
/// The placeholder to use for the extra argument parsed
///     by the option in `--help` output. The @arg_description is translated
///     using the @translate_func of the group, see
///     g_option_group_set_translation_domain().
/// </para>
/// </summary>

public string arg_description;
}
