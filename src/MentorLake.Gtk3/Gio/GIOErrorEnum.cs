namespace MentorLake.Gio;

[Flags]
public enum GIOErrorEnum
{
	G_IO_ERROR_FAILED = 0,
	G_IO_ERROR_NOT_FOUND = 1,
	G_IO_ERROR_EXISTS = 2,
	G_IO_ERROR_IS_DIRECTORY = 3,
	G_IO_ERROR_NOT_DIRECTORY = 4,
	G_IO_ERROR_NOT_EMPTY = 5,
	G_IO_ERROR_NOT_REGULAR_FILE = 6,
	G_IO_ERROR_NOT_SYMBOLIC_LINK = 7,
	G_IO_ERROR_NOT_MOUNTABLE_FILE = 8,
	G_IO_ERROR_FILENAME_TOO_LONG = 9,
	G_IO_ERROR_INVALID_FILENAME = 10,
	G_IO_ERROR_TOO_MANY_LINKS = 11,
	G_IO_ERROR_NO_SPACE = 12,
	G_IO_ERROR_INVALID_ARGUMENT = 13,
	G_IO_ERROR_PERMISSION_DENIED = 14,
	G_IO_ERROR_NOT_SUPPORTED = 15,
	G_IO_ERROR_NOT_MOUNTED = 16,
	G_IO_ERROR_ALREADY_MOUNTED = 17,
	G_IO_ERROR_CLOSED = 18,
	G_IO_ERROR_CANCELLED = 19,
	G_IO_ERROR_PENDING = 20,
	G_IO_ERROR_READ_ONLY = 21,
	G_IO_ERROR_CANT_CREATE_BACKUP = 22,
	G_IO_ERROR_WRONG_ETAG = 23,
	G_IO_ERROR_TIMED_OUT = 24,
	G_IO_ERROR_WOULD_RECURSE = 25,
	G_IO_ERROR_BUSY = 26,
	G_IO_ERROR_WOULD_BLOCK = 27,
	G_IO_ERROR_HOST_NOT_FOUND = 28,
	G_IO_ERROR_WOULD_MERGE = 29,
	G_IO_ERROR_FAILED_HANDLED = 30,
	G_IO_ERROR_TOO_MANY_OPEN_FILES = 31,
	G_IO_ERROR_NOT_INITIALIZED = 32,
	G_IO_ERROR_ADDRESS_IN_USE = 33,
	G_IO_ERROR_PARTIAL_INPUT = 34,
	G_IO_ERROR_INVALID_DATA = 35,
	G_IO_ERROR_DBUS_ERROR = 36,
	G_IO_ERROR_HOST_UNREACHABLE = 37,
	G_IO_ERROR_NETWORK_UNREACHABLE = 38,
	G_IO_ERROR_CONNECTION_REFUSED = 39,
	G_IO_ERROR_PROXY_FAILED = 40,
	G_IO_ERROR_PROXY_AUTH_FAILED = 41,
	G_IO_ERROR_PROXY_NEED_AUTH = 42,
	G_IO_ERROR_PROXY_NOT_ALLOWED = 43,
	G_IO_ERROR_BROKEN_PIPE = 44,
	G_IO_ERROR_CONNECTION_CLOSED = 44,
	G_IO_ERROR_NOT_CONNECTED = 45,
	G_IO_ERROR_MESSAGE_TOO_LARGE = 46,
	G_IO_ERROR_NO_SUCH_DEVICE = 47,
	G_IO_ERROR_DESTINATION_UNSET = 48
}
