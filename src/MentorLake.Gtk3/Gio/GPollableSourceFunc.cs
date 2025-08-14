namespace MentorLake.Gio;

/// <summary>
/// <para>
/// This is the function type of the callback used for the #GSource
/// returned by g_pollable_input_stream_create_source() and
/// g_pollable_output_stream_create_source().
/// </para>
/// </summary>

/// <param name="pollable_stream">
/// the #GPollableInputStream or #GPollableOutputStream
/// </param>
/// <param name="data">
/// data passed in by the user.
/// </param>
/// <return>
/// it should return %FALSE if the source should be removed.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GPollableSourceFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle pollable_stream, IntPtr data);
