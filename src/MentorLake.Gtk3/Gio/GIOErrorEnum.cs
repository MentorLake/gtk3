namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Error codes returned by GIO functions.
/// </para>
/// <para>
/// Note that this domain may be extended in future GLib releases. In
/// general, new error codes either only apply to new APIs, or else
/// replace %G_IO_ERROR_FAILED in cases that were not explicitly
/// distinguished before. You should therefore avoid writing code like
/// <code>
/// if (g_error_matches (error, G_IO_ERROR, G_IO_ERROR_FAILED))
/// if (g_error_matches (error, G_IO_ERROR, G_IO_ERROR_FAILED))
///   {
///     // Assume that this is EPRINTERONFIRE
///     ...
///   }
/// </code>
/// %G_IO_ERROR_FAILED.
/// </para>
/// <para>
/// See also #GPollableReturn for a cheaper way of returning
/// %G_IO_ERROR_WOULD_BLOCK to callers without allocating a #GError.
/// </para>
/// </summary>

[Flags]
public enum GIOErrorEnum
{
/// <summary>
/// <para>
/// Generic error condition for when an operation fails
///     and no more specific #GIOErrorEnum value is defined.
/// </para>
/// </summary>

	G_IO_ERROR_FAILED = 0,
/// <summary>
/// <para>
/// File not found.
/// </para>
/// </summary>

	G_IO_ERROR_NOT_FOUND = 1,
/// <summary>
/// <para>
/// File already exists.
/// </para>
/// </summary>

	G_IO_ERROR_EXISTS = 2,
/// <summary>
/// <para>
/// File is a directory.
/// </para>
/// </summary>

	G_IO_ERROR_IS_DIRECTORY = 3,
/// <summary>
/// <para>
/// File is not a directory.
/// </para>
/// </summary>

	G_IO_ERROR_NOT_DIRECTORY = 4,
/// <summary>
/// <para>
/// File is a directory that isn&apos;t empty.
/// </para>
/// </summary>

	G_IO_ERROR_NOT_EMPTY = 5,
/// <summary>
/// <para>
/// File is not a regular file.
/// </para>
/// </summary>

	G_IO_ERROR_NOT_REGULAR_FILE = 6,
/// <summary>
/// <para>
/// File is not a symbolic link.
/// </para>
/// </summary>

	G_IO_ERROR_NOT_SYMBOLIC_LINK = 7,
/// <summary>
/// <para>
/// File cannot be mounted.
/// </para>
/// </summary>

	G_IO_ERROR_NOT_MOUNTABLE_FILE = 8,
/// <summary>
/// <para>
/// Filename is too many characters.
/// </para>
/// </summary>

	G_IO_ERROR_FILENAME_TOO_LONG = 9,
/// <summary>
/// <para>
/// Filename is invalid or contains invalid characters.
/// </para>
/// </summary>

	G_IO_ERROR_INVALID_FILENAME = 10,
/// <summary>
/// <para>
/// File contains too many symbolic links.
/// </para>
/// </summary>

	G_IO_ERROR_TOO_MANY_LINKS = 11,
/// <summary>
/// <para>
/// No space left on drive.
/// </para>
/// </summary>

	G_IO_ERROR_NO_SPACE = 12,
/// <summary>
/// <para>
/// Invalid argument.
/// </para>
/// </summary>

	G_IO_ERROR_INVALID_ARGUMENT = 13,
/// <summary>
/// <para>
/// Permission denied.
/// </para>
/// </summary>

	G_IO_ERROR_PERMISSION_DENIED = 14,
/// <summary>
/// <para>
/// Operation (or one of its parameters) not supported
/// </para>
/// </summary>

	G_IO_ERROR_NOT_SUPPORTED = 15,
/// <summary>
/// <para>
/// File isn&apos;t mounted.
/// </para>
/// </summary>

	G_IO_ERROR_NOT_MOUNTED = 16,
/// <summary>
/// <para>
/// File is already mounted.
/// </para>
/// </summary>

	G_IO_ERROR_ALREADY_MOUNTED = 17,
/// <summary>
/// <para>
/// File was closed.
/// </para>
/// </summary>

	G_IO_ERROR_CLOSED = 18,
/// <summary>
/// <para>
/// Operation was cancelled. See #GCancellable.
/// </para>
/// </summary>

	G_IO_ERROR_CANCELLED = 19,
/// <summary>
/// <para>
/// Operations are still pending.
/// </para>
/// </summary>

	G_IO_ERROR_PENDING = 20,
/// <summary>
/// <para>
/// File is read only.
/// </para>
/// </summary>

	G_IO_ERROR_READ_ONLY = 21,
/// <summary>
/// <para>
/// Backup couldn&apos;t be created.
/// </para>
/// </summary>

	G_IO_ERROR_CANT_CREATE_BACKUP = 22,
/// <summary>
/// <para>
/// File&apos;s Entity Tag was incorrect.
/// </para>
/// </summary>

	G_IO_ERROR_WRONG_ETAG = 23,
/// <summary>
/// <para>
/// Operation timed out.
/// </para>
/// </summary>

	G_IO_ERROR_TIMED_OUT = 24,
/// <summary>
/// <para>
/// Operation would be recursive.
/// </para>
/// </summary>

	G_IO_ERROR_WOULD_RECURSE = 25,
/// <summary>
/// <para>
/// File is busy.
/// </para>
/// </summary>

	G_IO_ERROR_BUSY = 26,
/// <summary>
/// <para>
/// Operation would block.
/// </para>
/// </summary>

	G_IO_ERROR_WOULD_BLOCK = 27,
/// <summary>
/// <para>
/// Host couldn&apos;t be found (remote operations).
/// </para>
/// </summary>

	G_IO_ERROR_HOST_NOT_FOUND = 28,
/// <summary>
/// <para>
/// Operation would merge files.
/// </para>
/// </summary>

	G_IO_ERROR_WOULD_MERGE = 29,
/// <summary>
/// <para>
/// Operation failed and a helper program has
///     already interacted with the user. Do not display any error dialog.
/// </para>
/// </summary>

	G_IO_ERROR_FAILED_HANDLED = 30,
/// <summary>
/// <para>
/// The current process has too many files
///     open and can&apos;t open any more. Duplicate descriptors do count toward
///     this limit. Since 2.20
/// </para>
/// </summary>

	G_IO_ERROR_TOO_MANY_OPEN_FILES = 31,
/// <summary>
/// <para>
/// The object has not been initialized. Since 2.22
/// </para>
/// </summary>

	G_IO_ERROR_NOT_INITIALIZED = 32,
/// <summary>
/// <para>
/// The requested address is already in use. Since 2.22
/// </para>
/// </summary>

	G_IO_ERROR_ADDRESS_IN_USE = 33,
/// <summary>
/// <para>
/// Need more input to finish operation. Since 2.24
/// </para>
/// </summary>

	G_IO_ERROR_PARTIAL_INPUT = 34,
/// <summary>
/// <para>
/// The input data was invalid. Since 2.24
/// </para>
/// </summary>

	G_IO_ERROR_INVALID_DATA = 35,
/// <summary>
/// <para>
/// A remote object generated an error that
///     doesn&apos;t correspond to a locally registered #GError error
///     domain. Use g_dbus_error_get_remote_error() to extract the D-Bus
///     error name and g_dbus_error_strip_remote_error() to fix up the
///     message so it matches what was received on the wire. Since 2.26.
/// </para>
/// </summary>

	G_IO_ERROR_DBUS_ERROR = 36,
/// <summary>
/// <para>
/// Host unreachable. Since 2.26
/// </para>
/// </summary>

	G_IO_ERROR_HOST_UNREACHABLE = 37,
/// <summary>
/// <para>
/// Network unreachable. Since 2.26
/// </para>
/// </summary>

	G_IO_ERROR_NETWORK_UNREACHABLE = 38,
/// <summary>
/// <para>
/// Connection refused. Since 2.26
/// </para>
/// </summary>

	G_IO_ERROR_CONNECTION_REFUSED = 39,
/// <summary>
/// <para>
/// Connection to proxy server failed. Since 2.26
/// </para>
/// </summary>

	G_IO_ERROR_PROXY_FAILED = 40,
/// <summary>
/// <para>
/// Proxy authentication failed. Since 2.26
/// </para>
/// </summary>

	G_IO_ERROR_PROXY_AUTH_FAILED = 41,
/// <summary>
/// <para>
/// Proxy server needs authentication. Since 2.26
/// </para>
/// </summary>

	G_IO_ERROR_PROXY_NEED_AUTH = 42,
/// <summary>
/// <para>
/// Proxy connection is not allowed by ruleset.
///     Since 2.26
/// </para>
/// </summary>

	G_IO_ERROR_PROXY_NOT_ALLOWED = 43,
/// <summary>
/// <para>
/// Broken pipe. Since 2.36
/// </para>
/// </summary>

	G_IO_ERROR_BROKEN_PIPE = 44,
/// <summary>
/// <para>
/// Connection closed by peer. Note that this
///     is the same code as %G_IO_ERROR_BROKEN_PIPE; before 2.44 some
///     &quot;connection closed&quot; errors returned %G_IO_ERROR_BROKEN_PIPE, but others
///     returned %G_IO_ERROR_FAILED. Now they should all return the same
///     value, which has this more logical name. Since 2.44.
/// </para>
/// </summary>

	G_IO_ERROR_CONNECTION_CLOSED = 44,
/// <summary>
/// <para>
/// Transport endpoint is not connected. Since 2.44
/// </para>
/// </summary>

	G_IO_ERROR_NOT_CONNECTED = 45,
/// <summary>
/// <para>
/// Message too large. Since 2.48.
/// </para>
/// </summary>

	G_IO_ERROR_MESSAGE_TOO_LARGE = 46,
/// <summary>
/// <para>
/// No such device found. Since 2.74
/// </para>
/// </summary>

	G_IO_ERROR_NO_SUCH_DEVICE = 47,
/// <summary>
/// <para>
/// Destination address unset. Since 2.80
/// </para>
/// </summary>

	G_IO_ERROR_DESTINATION_UNSET = 48
}
