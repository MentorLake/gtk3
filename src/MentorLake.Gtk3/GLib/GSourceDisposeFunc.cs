namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Dispose function for @source. See [method@GLib.Source.set_dispose_function]
/// for details.
/// </para>
/// </summary>

/// <param name="source">
/// #GSource that is currently being disposed
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSourceDisposeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);
