namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags used to define the behaviour of a #GApplication.
/// </para>
/// </summary>

[Flags]
public enum GApplicationFlags : uint
{
/// <summary>
/// <para>
/// Default flags.
/// </para>
/// </summary>

	G_APPLICATION_FLAGS_NONE = 0,
/// <summary>
/// <para>
/// Default flags.
/// </para>
/// </summary>

	G_APPLICATION_DEFAULT_FLAGS = 0,
/// <summary>
/// <para>
/// Run as a service. In this mode, registration
///      fails if the service is already running, and the application
///      will initially wait up to 10 seconds for an initial activation
///      message to arrive.
/// </para>
/// </summary>

	G_APPLICATION_IS_SERVICE = 1,
/// <summary>
/// <para>
/// Don't try to become the primary instance.
/// </para>
/// </summary>

	G_APPLICATION_IS_LAUNCHER = 2,
/// <summary>
/// <para>
/// This application handles opening files (in
///     the primary instance). Note that this flag only affects the default
///     implementation of local_command_line(), and has no effect if
///     %G_APPLICATION_HANDLES_COMMAND_LINE is given.
///     See g_application_run() for details.
/// </para>
/// </summary>

	G_APPLICATION_HANDLES_OPEN = 4,
/// <summary>
/// <para>
/// This application handles command line
///     arguments (in the primary instance). Note that this flag only affect
///     the default implementation of local_command_line().
///     See g_application_run() for details.
/// </para>
/// </summary>

	G_APPLICATION_HANDLES_COMMAND_LINE = 8,
/// <summary>
/// <para>
/// Send the environment of the
///     launching process to the primary instance. Set this flag if your
///     application is expected to behave differently depending on certain
///     environment variables. For instance, an editor might be expected
///     to use the `GIT_COMMITTER_NAME` environment variable
///     when editing a git commit message. The environment is available
///     to the #GApplication::command-line signal handler, via
///     g_application_command_line_getenv().
/// </para>
/// </summary>

	G_APPLICATION_SEND_ENVIRONMENT = 16,
/// <summary>
/// <para>
/// Make no attempts to do any of the typical
///     single-instance application negotiation, even if the application
///     ID is given.  The application neither attempts to become the
///     owner of the application ID nor does it check if an existing
///     owner already exists.  Everything occurs in the local process.
///     Since: 2.30.
/// </para>
/// </summary>

	G_APPLICATION_NON_UNIQUE = 32,
/// <summary>
/// <para>
/// Allow users to override the
///     application ID from the command line with `--gapplication-app-id`.
///     Since: 2.48
/// </para>
/// </summary>

	G_APPLICATION_CAN_OVERRIDE_APP_ID = 64,
/// <summary>
/// <para>
/// Allow another instance to take over
///     the bus name. Since: 2.60
/// </para>
/// </summary>

	G_APPLICATION_ALLOW_REPLACEMENT = 128,
/// <summary>
/// <para>
/// Take over from another instance. This flag is
///     usually set by passing `--gapplication-replace` on the commandline.
///     Since: 2.60
/// </para>
/// </summary>

	G_APPLICATION_REPLACE = 256
}
