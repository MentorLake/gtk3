namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The callback passed to [method@MessageHeaders.foreach].
/// </para>
/// </summary>

/// <param name="name">
/// the header name
/// </param>
/// <param name="value">
/// the header value
/// </param>
/// <param name="user_data">
/// the data passed to [method@MessageHeaders.foreach]
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SoupMessageHeadersForeachFunc(string name, string value, IntPtr user_data);
