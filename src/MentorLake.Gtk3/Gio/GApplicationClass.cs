namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Virtual function table for #GApplication.
/// </para>
/// </summary>

public class GApplicationClassHandle : BaseSafeHandle
{
}


public static class GApplicationClassExtensions
{

	public static GApplicationClass Dereference(this GApplicationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GApplicationClass>(x.DangerousGetHandle());
}
internal class GApplicationClassExterns
{
}

/// <summary>
/// <para>
/// Virtual function table for #GApplication.
/// </para>
/// </summary>

public struct GApplicationClass
{
	/// <summary>
/// <para>
/// invoked on the primary instance immediately after registration
/// </para>
/// </summary>

public IntPtr startup;
	/// <summary>
/// <para>
/// invoked on the primary instance when an activation occurs
/// </para>
/// </summary>

public IntPtr activate;
	/// <summary>
/// <para>
/// invoked on the primary instance when there are files to open
/// </para>
/// </summary>

public IntPtr open;
	/// <summary>
/// <para>
/// invoked on the primary instance when a command-line is
///   not handled locally
/// </para>
/// </summary>

public IntPtr command_line;
	/// <summary>
/// <para>
/// invoked (locally). The virtual function has the chance
///     to inspect (and possibly replace) command line arguments. See
///     g_application_run() for more information. Also see the
///     #GApplication::handle-local-options signal, which is a simpler
///     alternative to handling some commandline options locally
/// </para>
/// </summary>

public IntPtr local_command_line;
	/// <summary>
/// <para>
/// invoked on the primary instance before 'activate', 'open',
///     'command-line' or any action invocation, gets the 'platform data' from
///     the calling instance
/// </para>
/// </summary>

public IntPtr before_emit;
	/// <summary>
/// <para>
/// invoked on the primary instance after 'activate', 'open',
///     'command-line' or any action invocation, gets the 'platform data' from
///     the calling instance
/// </para>
/// </summary>

public IntPtr after_emit;
	/// <summary>
/// <para>
/// invoked (locally) to add 'platform data' to be sent to
///     the primary instance when activating, opening or invoking actions
/// </para>
/// </summary>

public IntPtr add_platform_data;
	/// <summary>
/// <para>
/// Used to be invoked on the primary instance when the use
///     count of the application drops to zero (and after any inactivity
///     timeout, if requested). Not used anymore since 2.32
/// </para>
/// </summary>

public IntPtr quit_mainloop;
	/// <summary>
/// <para>
/// Used to be invoked on the primary instance from
///     g_application_run() if the use-count is non-zero. Since 2.32,
///     GApplication is iterating the main context directly and is not
///     using @run_mainloop anymore
/// </para>
/// </summary>

public IntPtr run_mainloop;
	/// <summary>
/// <para>
/// invoked only on the registered primary instance immediately
///      after the main loop terminates
/// </para>
/// </summary>

public IntPtr shutdown;
	/// <summary>
/// <para>
/// invoked locally during registration, if the application is
///     using its D-Bus backend. You can use this to export extra objects on the
///     bus, that need to exist before the application tries to own the bus name.
///     The function is passed the #GDBusConnection to to session bus, and the
///     object path that #GApplication will use to export its D-Bus API.
///     If this function returns %TRUE, registration will proceed; otherwise
///     registration will abort. Since: 2.34
/// </para>
/// </summary>

public IntPtr dbus_register;
	/// <summary>
/// <para>
/// invoked locally during unregistration, if the application
///     is using its D-Bus backend. Use this to undo anything done by
///     the @dbus_register vfunc. Since: 2.34
/// </para>
/// </summary>

public IntPtr dbus_unregister;
	/// <summary>
/// <para>
/// invoked locally after the parsing of the commandline
///  options has occurred. Since: 2.40
/// </para>
/// </summary>

public IntPtr handle_local_options;
	/// <summary>
/// <para>
/// invoked when another instance is taking over the name. Since: 2.60
/// </para>
/// </summary>

public IntPtr name_lost;
}
