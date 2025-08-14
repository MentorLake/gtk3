namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function which is called when an extended
/// error instance is freed. It is passed the error pointer about to be
/// freed, and should free the error's private data fields.
/// </para>
/// <para>
/// Normally, it is better to use G_DEFINE_EXTENDED_ERROR(), as it
/// already takes care of getting the private data from @error.
/// </para>
/// </summary>

/// <param name="error">
/// extended error to clear
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GErrorClearFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);
