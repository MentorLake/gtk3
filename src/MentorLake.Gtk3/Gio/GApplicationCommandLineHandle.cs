namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GApplicationCommandLine` represents a command-line invocation of
/// an application.
/// </para>
/// <para>
/// It is created by [class@Gio.Application] and emitted
/// in the [signal@Gio.Application::command-line] signal and virtual function.
/// </para>
/// <para>
/// The class contains the list of arguments that the program was invoked
/// with. It is also possible to query if the commandline invocation was
/// local (ie: the current process is running in direct response to the
/// invocation) or remote (ie: some other process forwarded the
/// commandline to this process).
/// </para>
/// <para>
/// The `GApplicationCommandLine` object can provide the @argc and @argv
/// parameters for use with the [struct@GLib.OptionContext] command-line parsing API,
/// with the [method@Gio.ApplicationCommandLine.get_arguments] function. See
/// [gapplication-example-cmdline3.c][gapplication-example-cmdline3]
/// for an example.
/// </para>
/// <para>
/// The exit status of the originally-invoked process may be set and
/// messages can be printed to stdout or stderr of that process.
/// </para>
/// <para>
/// For remote invocation, the originally-invoked process exits when
/// [method@Gio.ApplicationCommandLine.done] method is called. This method is
/// also automatically called when the object is disposed.
/// </para>
/// <para>
/// The main use for `GApplicationCommandLine` (and the
/// [signal@Gio.Application::command-line] signal) is &apos;Emacs server&apos; like use cases:
/// You can set the `EDITOR` environment variable to have e.g. git use
/// your favourite editor to edit commit messages, and if you already
/// have an instance of the editor running, the editing will happen
/// in the running instance, instead of opening a new one. An important
/// aspect of this use case is that the process that gets started by git
/// does not return until the editing is done.
/// </para>
/// <para>
/// Normally, the commandline is completely handled in the
/// [signal@Gio.Application::command-line] handler. The launching instance exits
/// once the signal handler in the primary instance has returned, and
/// the return value of the signal handler becomes the exit status
/// of the launching instance.
/// </para>
/// <para>
/// ```c
/// static int
/// command_line (GApplication            *application,
///               GApplicationCommandLine *cmdline)
/// {
///   gchar **argv;
///   gint argc;
///   gint i;
/// </para>
/// <para>
///   argv = g_application_command_line_get_arguments (cmdline, &amp;argc);
/// </para>
/// <para>
///   g_application_command_line_print (cmdline,
///                                     &quot;This text is written back\n&quot;
///                                     &quot;to stdout of the caller\n&quot;);
/// </para>
/// <para>
///   for (i = 0; i &amp;lt; argc; i++)
///     g_print (&quot;argument %d: %s\n&quot;, i, argv[i]);
/// </para>
/// <para>
///   g_strfreev (argv);
/// </para>
/// <para>
///   return 0;
/// }
/// ```
/// </para>
/// <para>
/// The complete example can be found here:
/// [gapplication-example-cmdline.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gapplication-example-cmdline.c)
/// </para>
/// <para>
/// In more complicated cases, the handling of the commandline can be
/// split between the launcher and the primary instance.
/// </para>
/// <para>
/// ```c
/// static gboolean
///  test_local_cmdline (GApplication   *application,
///                      gchar        ***arguments,
///                      gint           *exit_status)
/// {
///   gint i, j;
///   gchar **argv;
/// </para>
/// <para>
///   argv = *arguments;
/// </para>
/// <para>
///   if (argv[0] == NULL)
///     {
///       *exit_status = 0;
///       return FALSE;
///     }
/// </para>
/// <para>
///   i = 1;
///   while (argv[i])
///     {
///       if (g_str_has_prefix (argv[i], &quot;--local-&quot;))
///         {
///           g_print (&quot;handling argument %s locally\n&quot;, argv[i]);
///           g_free (argv[i]);
///           for (j = i; argv[j]; j++)
///             argv[j] = argv[j + 1];
///         }
///       else
///         {
///           g_print (&quot;not handling argument %s locally\n&quot;, argv[i]);
///           i++;
///         }
///     }
/// </para>
/// <para>
///   *exit_status = 0;
/// </para>
/// <para>
///   return FALSE;
/// }
/// </para>
/// <para>
/// static void
/// test_application_class_init (TestApplicationClass *class)
/// {
///   G_APPLICATION_CLASS (class)-&amp;gt;local_command_line = test_local_cmdline;
/// </para>
/// <para>
///   ...
/// }
/// ```
/// </para>
/// <para>
/// In this example of split commandline handling, options that start
/// with `--local-` are handled locally, all other options are passed
/// to the [signal@Gio.Application::command-line] handler which runs in the primary
/// instance.
/// </para>
/// <para>
/// The complete example can be found here:
/// [gapplication-example-cmdline2.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gapplication-example-cmdline2.c)
/// </para>
/// <para>
/// If handling the commandline requires a lot of work, it may be better to defer it.
/// </para>
/// <para>
/// ```c
/// static gboolean
/// my_cmdline_handler (gpointer data)
/// {
///   GApplicationCommandLine *cmdline = data;
/// </para>
/// <para>
///   // do the heavy lifting in an idle
/// </para>
/// <para>
///   g_application_command_line_set_exit_status (cmdline, 0);
///   g_object_unref (cmdline); // this releases the application
/// </para>
/// <para>
///   return G_SOURCE_REMOVE;
/// }
/// </para>
/// <para>
/// static int
/// command_line (GApplication            *application,
///               GApplicationCommandLine *cmdline)
/// {
///   // keep the application running until we are done with this commandline
///   g_application_hold (application);
/// </para>
/// <para>
///   g_object_set_data_full (G_OBJECT (cmdline),
///                           &quot;application&quot;, application,
///                           (GDestroyNotify)g_application_release);
/// </para>
/// <para>
///   g_object_ref (cmdline);
///   g_idle_add (my_cmdline_handler, cmdline);
/// </para>
/// <para>
///   return 0;
/// }
/// ```
/// </para>
/// <para>
/// In this example the commandline is not completely handled before
/// the [signal@Gio.Application::command-line] handler returns. Instead, we keep
/// a reference to the `GApplicationCommandLine` object and handle it
/// later (in this example, in an idle). Note that it is necessary to
/// hold the application until you are done with the commandline.
/// </para>
/// <para>
/// The complete example can be found here:
/// [gapplication-example-cmdline3.c](https://gitlab.gnome.org/GNOME/glib/-/blob/HEAD/gio/tests/gapplication-example-cmdline3.c)
/// </para>
/// </summary>

public class GApplicationCommandLineHandle : GObjectHandle
{
}

public static class GApplicationCommandLineHandleExtensions
{
/// <summary>
/// <para>
/// Creates a #GFile corresponding to a filename that was given as part
/// of the invocation of @cmdline.
/// </para>
/// <para>
/// This differs from g_file_new_for_commandline_arg() in that it
/// resolves relative pathnames using the current working directory of
/// the invoking process rather than the local process.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="arg">
/// an argument from @cmdline
/// </param>
/// <return>
/// a new #GFile
/// </return>

	public static MentorLake.Gio.GFileHandle CreateFileForArg(this MentorLake.Gio.GApplicationCommandLineHandle cmdline, string arg)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_create_file_for_arg(cmdline, arg);
	}

/// <summary>
/// <para>
/// Signals that command line processing is completed.
/// </para>
/// <para>
/// For remote invocation, it causes the invoking process to terminate.
/// </para>
/// <para>
/// For local invocation, it does nothing.
/// </para>
/// <para>
/// This method should be called in the [signal@Gio.Application::command-line]
/// handler, after the exit status is set and all messages are printed.
/// </para>
/// <para>
/// After this call, g_application_command_line_set_exit_status() has no effect.
/// Subsequent calls to this method are no-ops.
/// </para>
/// <para>
/// This method is automatically called when the #GApplicationCommandLine
/// object is disposed — so you can omit the call in non-garbage collected
/// languages.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>

	public static T Done<T>(this T cmdline) where T : GApplicationCommandLineHandle
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		GApplicationCommandLineHandleExterns.g_application_command_line_done(cmdline);
		return cmdline;
	}

/// <summary>
/// <para>
/// Gets the list of arguments that was passed on the command line.
/// </para>
/// <para>
/// The strings in the array may contain non-UTF-8 data on UNIX (such as
/// filenames or arguments given in the system locale) but are always in
/// UTF-8 on Windows.
/// </para>
/// <para>
/// If you wish to use the return value with #GOptionContext, you must
/// use g_option_context_parse_strv().
/// </para>
/// <para>
/// The return value is %NULL-terminated and should be freed using
/// g_strfreev().
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="argc">
/// the length of the arguments array, or %NULL
/// </param>
/// <return>
/// 
///      the string array containing the arguments (the argv)
/// </return>

	public static string[] GetArguments(this MentorLake.Gio.GApplicationCommandLineHandle cmdline, out int argc)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_arguments(cmdline, out argc);
	}

/// <summary>
/// <para>
/// Gets the working directory of the command line invocation.
/// The string may contain non-utf8 data.
/// </para>
/// <para>
/// It is possible that the remote application did not send a working
/// directory, so this may be %NULL.
/// </para>
/// <para>
/// The return value should not be modified or freed and is valid for as
/// long as @cmdline exists.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <return>
/// the current directory, or %NULL
/// </return>

	public static string GetCwd(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_cwd(cmdline);
	}

/// <summary>
/// <para>
/// Gets the contents of the &apos;environ&apos; variable of the command line
/// invocation, as would be returned by g_get_environ(), ie as a
/// %NULL-terminated list of strings in the form &apos;NAME=VALUE&apos;.
/// The strings may contain non-utf8 data.
/// </para>
/// <para>
/// The remote application usually does not send an environment.  Use
/// %G_APPLICATION_SEND_ENVIRONMENT to affect that.  Even with this flag
/// set it is possible that the environment is still not available (due
/// to invocation messages from other applications).
/// </para>
/// <para>
/// The return value should not be modified or freed and is valid for as
/// long as @cmdline exists.
/// </para>
/// <para>
/// See g_application_command_line_getenv() if you are only interested
/// in the value of a single environment variable.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <return>
/// 
///     the environment strings, or %NULL if they were not sent
/// </return>

	public static string[] GetEnviron(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_environ(cmdline);
	}

/// <summary>
/// <para>
/// Gets the exit status of @cmdline.  See
/// g_application_command_line_set_exit_status() for more information.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <return>
/// the exit status
/// </return>

	public static int GetExitStatus(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_exit_status(cmdline);
	}

/// <summary>
/// <para>
/// Determines if @cmdline represents a remote invocation.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <return>
/// %TRUE if the invocation was remote
/// </return>

	public static bool GetIsRemote(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_is_remote(cmdline);
	}

/// <summary>
/// <para>
/// Gets the options that were passed to g_application_command_line().
/// </para>
/// <para>
/// If you did not override local_command_line() then these are the same
/// options that were parsed according to the #GOptionEntrys added to the
/// application with g_application_add_main_option_entries() and possibly
/// modified from your GApplication::handle-local-options handler.
/// </para>
/// <para>
/// If no options were sent then an empty dictionary is returned so that
/// you don&apos;t need to check for %NULL.
/// </para>
/// <para>
/// The data has been passed via an untrusted external process, so the types of
/// all values must be checked before being used.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <return>
/// a #GVariantDict with the options
/// </return>

	public static MentorLake.GLib.GVariantDictHandle GetOptionsDict(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_options_dict(cmdline);
	}

/// <summary>
/// <para>
/// Gets the platform data associated with the invocation of @cmdline.
/// </para>
/// <para>
/// This is a #GVariant dictionary containing information about the
/// context in which the invocation occurred.  It typically contains
/// information like the current working directory and the startup
/// notification ID.
/// </para>
/// <para>
/// It comes from an untrusted external process and hence the types of all
/// values must be validated before being used.
/// </para>
/// <para>
/// For local invocation, it will be %NULL.
/// </para>
/// </summary>

/// <param name="cmdline">
/// #GApplicationCommandLine
/// </param>
/// <return>
/// the platform data, or %NULL
/// </return>

	public static MentorLake.GLib.GVariantHandle GetPlatformData(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_platform_data(cmdline);
	}

/// <summary>
/// <para>
/// Gets the stdin of the invoking process.
/// </para>
/// <para>
/// The #GInputStream can be used to read data passed to the standard
/// input of the invoking process.
/// This doesn&apos;t work on all platforms.  Presently, it is only available
/// on UNIX when using a D-Bus daemon capable of passing file descriptors.
/// If stdin is not available then %NULL will be returned.  In the
/// future, support may be expanded to other platforms.
/// </para>
/// <para>
/// You must only call this function once per commandline invocation.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <return>
/// a #GInputStream for stdin
/// </return>

	public static MentorLake.Gio.GInputStreamHandle GetStdin(this MentorLake.Gio.GApplicationCommandLineHandle cmdline)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_get_stdin(cmdline);
	}

/// <summary>
/// <para>
/// Gets the value of a particular environment variable of the command
/// line invocation, as would be returned by g_getenv().  The strings may
/// contain non-utf8 data.
/// </para>
/// <para>
/// The remote application usually does not send an environment.  Use
/// %G_APPLICATION_SEND_ENVIRONMENT to affect that.  Even with this flag
/// set it is possible that the environment is still not available (due
/// to invocation messages from other applications).
/// </para>
/// <para>
/// The return value should not be modified or freed and is valid for as
/// long as @cmdline exists.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="name">
/// the environment variable to get
/// </param>
/// <return>
/// the value of the variable, or %NULL if unset or unsent
/// </return>

	public static string Getenv(this MentorLake.Gio.GApplicationCommandLineHandle cmdline, string name)
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		return GApplicationCommandLineHandleExterns.g_application_command_line_getenv(cmdline, name);
	}

/// <summary>
/// <para>
/// Formats a message and prints it using the stdout print handler in the
/// invoking process.
/// </para>
/// <para>
/// If @cmdline is a local invocation then this is exactly equivalent to
/// g_print().  If @cmdline is remote then this is equivalent to calling
/// g_print() in the invoking process.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="format">
/// a printf-style format string
/// </param>
/// <param name="@__arglist">
/// arguments, as per @format
/// </param>

	public static T Print<T>(this T cmdline, string format, IntPtr @__arglist) where T : GApplicationCommandLineHandle
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		GApplicationCommandLineHandleExterns.g_application_command_line_print(cmdline, format, @__arglist);
		return cmdline;
	}

/// <summary>
/// <para>
/// Prints a message using the stdout print handler in the invoking process.
/// </para>
/// <para>
/// Unlike g_application_command_line_print(), @message is not a `printf()`-style
/// format string. Use this function if @message contains text you don&apos;t have
/// control over, that could include `printf()` escape sequences.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="message">
/// the message
/// </param>

	public static T PrintLiteral<T>(this T cmdline, string message) where T : GApplicationCommandLineHandle
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		GApplicationCommandLineHandleExterns.g_application_command_line_print_literal(cmdline, message);
		return cmdline;
	}

/// <summary>
/// <para>
/// Formats a message and prints it using the stderr print handler in the
/// invoking process.
/// </para>
/// <para>
/// If @cmdline is a local invocation then this is exactly equivalent to
/// g_printerr().  If @cmdline is remote then this is equivalent to
/// calling g_printerr() in the invoking process.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="format">
/// a printf-style format string
/// </param>
/// <param name="@__arglist">
/// arguments, as per @format
/// </param>

	public static T Printerr<T>(this T cmdline, string format, IntPtr @__arglist) where T : GApplicationCommandLineHandle
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		GApplicationCommandLineHandleExterns.g_application_command_line_printerr(cmdline, format, @__arglist);
		return cmdline;
	}

/// <summary>
/// <para>
/// Prints a message using the stderr print handler in the invoking process.
/// </para>
/// <para>
/// Unlike g_application_command_line_printerr(), @message is not
/// a `printf()`-style format string. Use this function if @message contains text
/// you don&apos;t have control over, that could include `printf()` escape sequences.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="message">
/// the message
/// </param>

	public static T PrinterrLiteral<T>(this T cmdline, string message) where T : GApplicationCommandLineHandle
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		GApplicationCommandLineHandleExterns.g_application_command_line_printerr_literal(cmdline, message);
		return cmdline;
	}

/// <summary>
/// <para>
/// Sets the exit status that will be used when the invoking process
/// exits.
/// </para>
/// <para>
/// The return value of the #GApplication::command-line signal is
/// passed to this function when the handler returns.  This is the usual
/// way of setting the exit status.
/// </para>
/// <para>
/// In the event that you want the remote invocation to continue running
/// and want to decide on the exit status in the future, you can use this
/// call.  For the case of a remote invocation, the remote process will
/// typically exit when the last reference is dropped on @cmdline.  The
/// exit status of the remote process will be equal to the last value
/// that was set with this function.
/// </para>
/// <para>
/// In the case that the commandline invocation is local, the situation
/// is slightly more complicated.  If the commandline invocation results
/// in the mainloop running (ie: because the use-count of the application
/// increased to a non-zero value) then the application is considered to
/// have been &apos;successful&apos; in a certain sense, and the exit status is
/// always zero.  If the application use count is zero, though, the exit
/// status of the local #GApplicationCommandLine is used.
/// </para>
/// <para>
/// This method is a no-op if g_application_command_line_done() has
/// been called.
/// </para>
/// </summary>

/// <param name="cmdline">
/// a #GApplicationCommandLine
/// </param>
/// <param name="exit_status">
/// the exit status
/// </param>

	public static T SetExitStatus<T>(this T cmdline, int exit_status) where T : GApplicationCommandLineHandle
	{
		if (cmdline.IsInvalid) throw new Exception("Invalid handle (GApplicationCommandLineHandle)");
		GApplicationCommandLineHandleExterns.g_application_command_line_set_exit_status(cmdline, exit_status);
		return cmdline;
	}

}

internal class GApplicationCommandLineHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle g_application_command_line_create_file_for_arg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string arg);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_application_command_line_get_arguments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, out int argc);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_command_line_get_cwd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_application_command_line_get_environ([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_application_command_line_get_exit_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_application_command_line_get_is_remote([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantDictHandle>))]
	internal static extern MentorLake.GLib.GVariantDictHandle g_application_command_line_get_options_dict([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_application_command_line_get_platform_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_application_command_line_get_stdin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_application_command_line_getenv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_print_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_printerr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_printerr_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_application_command_line_set_exit_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GApplicationCommandLineHandle>))] MentorLake.Gio.GApplicationCommandLineHandle cmdline, int exit_status);

}
