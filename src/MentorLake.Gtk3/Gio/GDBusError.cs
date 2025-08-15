namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Error codes for the %G_DBUS_ERROR error domain.
/// </para>
/// </summary>

[Flags]
public enum GDBusError
{
/// <summary>
/// <para>
/// A generic error; &quot;something went wrong&quot; - see the error message for
/// more.
/// </para>
/// </summary>

	G_DBUS_ERROR_FAILED = 0,
/// <summary>
/// <para>
/// There was not enough memory to complete an operation.
/// </para>
/// </summary>

	G_DBUS_ERROR_NO_MEMORY = 1,
/// <summary>
/// <para>
/// The bus doesn&apos;t know how to launch a service to supply the bus name
/// you wanted.
/// </para>
/// </summary>

	G_DBUS_ERROR_SERVICE_UNKNOWN = 2,
/// <summary>
/// <para>
/// The bus name you referenced doesn&apos;t exist (i.e. no application owns
/// it).
/// </para>
/// </summary>

	G_DBUS_ERROR_NAME_HAS_NO_OWNER = 3,
/// <summary>
/// <para>
/// No reply to a message expecting one, usually means a timeout occurred.
/// </para>
/// </summary>

	G_DBUS_ERROR_NO_REPLY = 4,
/// <summary>
/// <para>
/// Something went wrong reading or writing to a socket, for example.
/// </para>
/// </summary>

	G_DBUS_ERROR_IO_ERROR = 5,
/// <summary>
/// <para>
/// A D-Bus bus address was malformed.
/// </para>
/// </summary>

	G_DBUS_ERROR_BAD_ADDRESS = 6,
/// <summary>
/// <para>
/// Requested operation isn&apos;t supported (like ENOSYS on UNIX).
/// </para>
/// </summary>

	G_DBUS_ERROR_NOT_SUPPORTED = 7,
/// <summary>
/// <para>
/// Some limited resource is exhausted.
/// </para>
/// </summary>

	G_DBUS_ERROR_LIMITS_EXCEEDED = 8,
/// <summary>
/// <para>
/// Security restrictions don&apos;t allow doing what you&apos;re trying to do.
/// </para>
/// </summary>

	G_DBUS_ERROR_ACCESS_DENIED = 9,
/// <summary>
/// <para>
/// Authentication didn&apos;t work.
/// </para>
/// </summary>

	G_DBUS_ERROR_AUTH_FAILED = 10,
/// <summary>
/// <para>
/// Unable to connect to server (probably caused by ECONNREFUSED on a
/// socket).
/// </para>
/// </summary>

	G_DBUS_ERROR_NO_SERVER = 11,
/// <summary>
/// <para>
/// Certain timeout errors, possibly ETIMEDOUT on a socket.  Note that
/// %G_DBUS_ERROR_NO_REPLY is used for message reply timeouts. Warning:
/// this is confusingly-named given that %G_DBUS_ERROR_TIMED_OUT also
/// exists. We can&apos;t fix it for compatibility reasons so just be
/// careful.
/// </para>
/// </summary>

	G_DBUS_ERROR_TIMEOUT = 12,
/// <summary>
/// <para>
/// No network access (probably ENETUNREACH on a socket).
/// </para>
/// </summary>

	G_DBUS_ERROR_NO_NETWORK = 13,
/// <summary>
/// <para>
/// Can&apos;t bind a socket since its address is in use (i.e. EADDRINUSE).
/// </para>
/// </summary>

	G_DBUS_ERROR_ADDRESS_IN_USE = 14,
/// <summary>
/// <para>
/// The connection is disconnected and you&apos;re trying to use it.
/// </para>
/// </summary>

	G_DBUS_ERROR_DISCONNECTED = 15,
/// <summary>
/// <para>
/// Invalid arguments passed to a method call.
/// </para>
/// </summary>

	G_DBUS_ERROR_INVALID_ARGS = 16,
/// <summary>
/// <para>
/// Missing file.
/// </para>
/// </summary>

	G_DBUS_ERROR_FILE_NOT_FOUND = 17,
/// <summary>
/// <para>
/// Existing file and the operation you&apos;re using does not silently overwrite.
/// </para>
/// </summary>

	G_DBUS_ERROR_FILE_EXISTS = 18,
/// <summary>
/// <para>
/// Method name you invoked isn&apos;t known by the object you invoked it on.
/// </para>
/// </summary>

	G_DBUS_ERROR_UNKNOWN_METHOD = 19,
/// <summary>
/// <para>
/// Certain timeout errors, e.g. while starting a service. Warning: this is
/// confusingly-named given that %G_DBUS_ERROR_TIMEOUT also exists. We
/// can&apos;t fix it for compatibility reasons so just be careful.
/// </para>
/// </summary>

	G_DBUS_ERROR_TIMED_OUT = 20,
/// <summary>
/// <para>
/// Tried to remove or modify a match rule that didn&apos;t exist.
/// </para>
/// </summary>

	G_DBUS_ERROR_MATCH_RULE_NOT_FOUND = 21,
/// <summary>
/// <para>
/// The match rule isn&apos;t syntactically valid.
/// </para>
/// </summary>

	G_DBUS_ERROR_MATCH_RULE_INVALID = 22,
/// <summary>
/// <para>
/// While starting a new process, the exec() call failed.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_EXEC_FAILED = 23,
/// <summary>
/// <para>
/// While starting a new process, the fork() call failed.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_FORK_FAILED = 24,
/// <summary>
/// <para>
/// While starting a new process, the child exited with a status code.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_CHILD_EXITED = 25,
/// <summary>
/// <para>
/// While starting a new process, the child exited on a signal.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_CHILD_SIGNALED = 26,
/// <summary>
/// <para>
/// While starting a new process, something went wrong.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_FAILED = 27,
/// <summary>
/// <para>
/// We failed to setup the environment correctly.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_SETUP_FAILED = 28,
/// <summary>
/// <para>
/// We failed to setup the config parser correctly.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_CONFIG_INVALID = 29,
/// <summary>
/// <para>
/// Bus name was not valid.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_SERVICE_INVALID = 30,
/// <summary>
/// <para>
/// Service file not found in system-services directory.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_SERVICE_NOT_FOUND = 31,
/// <summary>
/// <para>
/// Permissions are incorrect on the setuid helper.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_PERMISSIONS_INVALID = 32,
/// <summary>
/// <para>
/// Service file invalid (Name, User or Exec missing).
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_FILE_INVALID = 33,
/// <summary>
/// <para>
/// Tried to get a UNIX process ID and it wasn&apos;t available.
/// </para>
/// </summary>

	G_DBUS_ERROR_SPAWN_NO_MEMORY = 34,
/// <summary>
/// <para>
/// Tried to get a UNIX process ID and it wasn&apos;t available.
/// </para>
/// </summary>

	G_DBUS_ERROR_UNIX_PROCESS_ID_UNKNOWN = 35,
/// <summary>
/// <para>
/// A type signature is not valid.
/// </para>
/// </summary>

	G_DBUS_ERROR_INVALID_SIGNATURE = 36,
/// <summary>
/// <para>
/// A file contains invalid syntax or is otherwise broken.
/// </para>
/// </summary>

	G_DBUS_ERROR_INVALID_FILE_CONTENT = 37,
/// <summary>
/// <para>
/// Asked for SELinux security context and it wasn&apos;t available.
/// </para>
/// </summary>

	G_DBUS_ERROR_SELINUX_SECURITY_CONTEXT_UNKNOWN = 38,
/// <summary>
/// <para>
/// Asked for ADT audit data and it wasn&apos;t available.
/// </para>
/// </summary>

	G_DBUS_ERROR_ADT_AUDIT_DATA_UNKNOWN = 39,
/// <summary>
/// <para>
/// There&apos;s already an object with the requested object path.
/// </para>
/// </summary>

	G_DBUS_ERROR_OBJECT_PATH_IN_USE = 40,
/// <summary>
/// <para>
/// Object you invoked a method on isn&apos;t known. Since 2.42
/// </para>
/// </summary>

	G_DBUS_ERROR_UNKNOWN_OBJECT = 41,
/// <summary>
/// <para>
/// Interface you invoked a method on isn&apos;t known by the object. Since 2.42
/// </para>
/// </summary>

	G_DBUS_ERROR_UNKNOWN_INTERFACE = 42,
/// <summary>
/// <para>
/// Property you tried to access isn&apos;t known by the object. Since 2.42
/// </para>
/// </summary>

	G_DBUS_ERROR_UNKNOWN_PROPERTY = 43,
/// <summary>
/// <para>
/// Property you tried to set is read-only. Since 2.42
/// </para>
/// </summary>

	G_DBUS_ERROR_PROPERTY_READ_ONLY = 44
}
