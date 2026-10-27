namespace MentorLake.Soup;

/// <summary>
/// <para>
/// These represent the known HTTP status code values, plus various
/// network and internal errors.
/// </para>
/// <para>
/// Note that no libsoup functions take or return this type directly;
/// any function that works with status codes will accept unrecognized
/// status codes as well.
/// </para>
/// </summary>

[Flags]
public enum SoupStatus
{
/// <summary>
/// <para>
/// No status available. (Eg, the message has not
/// been sent yet)
/// </para>
/// </summary>

	SOUP_STATUS_NONE = 0,
/// <summary>
/// <para>
/// 100 Continue (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_CONTINUE = 100,
/// <summary>
/// <para>
/// 101 Switching Protocols (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_SWITCHING_PROTOCOLS = 101,
/// <summary>
/// <para>
/// 102 Processing (WebDAV)
/// </para>
/// </summary>

	SOUP_STATUS_PROCESSING = 102,
/// <summary>
/// <para>
/// 200 Success (HTTP). Also used by many lower-level
/// soup routines to indicate success.
/// </para>
/// </summary>

	SOUP_STATUS_OK = 200,
/// <summary>
/// <para>
/// 201 Created (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_CREATED = 201,
/// <summary>
/// <para>
/// 202 Accepted (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_ACCEPTED = 202,
/// <summary>
/// <para>
/// 203 Non-Authoritative Information
/// (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_NON_AUTHORITATIVE = 203,
/// <summary>
/// <para>
/// 204 No Content (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_NO_CONTENT = 204,
/// <summary>
/// <para>
/// 205 Reset Content (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_RESET_CONTENT = 205,
/// <summary>
/// <para>
/// 206 Partial Content (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_PARTIAL_CONTENT = 206,
/// <summary>
/// <para>
/// 207 Multi-Status (WebDAV)
/// </para>
/// </summary>

	SOUP_STATUS_MULTI_STATUS = 207,
/// <summary>
/// <para>
/// 300 Multiple Choices (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_MULTIPLE_CHOICES = 300,
/// <summary>
/// <para>
/// 301 Moved Permanently (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_MOVED_PERMANENTLY = 301,
/// <summary>
/// <para>
/// 302 Found (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_FOUND = 302,
/// <summary>
/// <para>
/// 302 Moved Temporarily (old name,
/// RFC 2068)
/// </para>
/// </summary>

	SOUP_STATUS_MOVED_TEMPORARILY = 302,
/// <summary>
/// <para>
/// 303 See Other (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_SEE_OTHER = 303,
/// <summary>
/// <para>
/// 304 Not Modified (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_NOT_MODIFIED = 304,
/// <summary>
/// <para>
/// 305 Use Proxy (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_USE_PROXY = 305,
/// <summary>
/// <para>
/// 306 [Unused] (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_NOT_APPEARING_IN_THIS_PROTOCOL = 306,
/// <summary>
/// <para>
/// 307 Temporary Redirect (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_TEMPORARY_REDIRECT = 307,
/// <summary>
/// <para>
/// 308 Permanent Redirect (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_PERMANENT_REDIRECT = 308,
/// <summary>
/// <para>
/// 400 Bad Request (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_BAD_REQUEST = 400,
/// <summary>
/// <para>
/// 401 Unauthorized (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_UNAUTHORIZED = 401,
/// <summary>
/// <para>
/// 402 Payment Required (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_PAYMENT_REQUIRED = 402,
/// <summary>
/// <para>
/// 403 Forbidden (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_FORBIDDEN = 403,
/// <summary>
/// <para>
/// 404 Not Found (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_NOT_FOUND = 404,
/// <summary>
/// <para>
/// 405 Method Not Allowed (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_METHOD_NOT_ALLOWED = 405,
/// <summary>
/// <para>
/// 406 Not Acceptable (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_NOT_ACCEPTABLE = 406,
/// <summary>
/// <para>
/// 407 Proxy Authentication
/// Required (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_PROXY_AUTHENTICATION_REQUIRED = 407,
/// <summary>
/// <para>
/// shorter alias for
/// %SOUP_STATUS_PROXY_AUTHENTICATION_REQUIRED
/// </para>
/// </summary>

	SOUP_STATUS_PROXY_UNAUTHORIZED = 407,
/// <summary>
/// <para>
/// 408 Request Timeout (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_REQUEST_TIMEOUT = 408,
/// <summary>
/// <para>
/// 409 Conflict (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_CONFLICT = 409,
/// <summary>
/// <para>
/// 410 Gone (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_GONE = 410,
/// <summary>
/// <para>
/// 411 Length Required (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_LENGTH_REQUIRED = 411,
/// <summary>
/// <para>
/// 412 Precondition Failed (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_PRECONDITION_FAILED = 412,
/// <summary>
/// <para>
/// 413 Request Entity Too Large
/// (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_REQUEST_ENTITY_TOO_LARGE = 413,
/// <summary>
/// <para>
/// 414 Request-URI Too Long (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_REQUEST_URI_TOO_LONG = 414,
/// <summary>
/// <para>
/// 415 Unsupported Media Type
/// (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_UNSUPPORTED_MEDIA_TYPE = 415,
/// <summary>
/// <para>
/// 416 Requested Range
/// Not Satisfiable (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_REQUESTED_RANGE_NOT_SATISFIABLE = 416,
/// <summary>
/// <para>
/// shorter alias for
/// %SOUP_STATUS_REQUESTED_RANGE_NOT_SATISFIABLE
/// </para>
/// </summary>

	SOUP_STATUS_INVALID_RANGE = 416,
/// <summary>
/// <para>
/// 417 Expectation Failed (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_EXPECTATION_FAILED = 417,
/// <summary>
/// <para>
/// 421 Misdirected Request
/// </para>
/// </summary>

	SOUP_STATUS_MISDIRECTED_REQUEST = 421,
/// <summary>
/// <para>
/// 422 Unprocessable Entity
/// (WebDAV)
/// </para>
/// </summary>

	SOUP_STATUS_UNPROCESSABLE_ENTITY = 422,
/// <summary>
/// <para>
/// 423 Locked (WebDAV)
/// </para>
/// </summary>

	SOUP_STATUS_LOCKED = 423,
/// <summary>
/// <para>
/// 424 Failed Dependency (WebDAV)
/// </para>
/// </summary>

	SOUP_STATUS_FAILED_DEPENDENCY = 424,
/// <summary>
/// <para>
/// 500 Internal Server Error
/// (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_INTERNAL_SERVER_ERROR = 500,
/// <summary>
/// <para>
/// 501 Not Implemented (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_NOT_IMPLEMENTED = 501,
/// <summary>
/// <para>
/// 502 Bad Gateway (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_BAD_GATEWAY = 502,
/// <summary>
/// <para>
/// 503 Service Unavailable (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_SERVICE_UNAVAILABLE = 503,
/// <summary>
/// <para>
/// 504 Gateway Timeout (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_GATEWAY_TIMEOUT = 504,
/// <summary>
/// <para>
/// 505 HTTP Version Not
/// Supported (HTTP)
/// </para>
/// </summary>

	SOUP_STATUS_HTTP_VERSION_NOT_SUPPORTED = 505,
/// <summary>
/// <para>
/// 507 Insufficient Storage
/// (WebDAV)
/// </para>
/// </summary>

	SOUP_STATUS_INSUFFICIENT_STORAGE = 507,
/// <summary>
/// <para>
/// 510 Not Extended (RFC 2774)
/// </para>
/// </summary>

	SOUP_STATUS_NOT_EXTENDED = 510
}
