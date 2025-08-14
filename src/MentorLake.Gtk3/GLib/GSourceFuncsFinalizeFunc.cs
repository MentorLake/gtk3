namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Finalizes the source.
/// </para>
/// <para>
/// Called when the source is finalized. At this point, the source
/// will have been destroyed, had its callback cleared, and have been removed
/// from its [type@GLib.MainContext], but it will still have its final reference
/// count, so methods can be called on it from within this function.
/// </para>
/// </summary>

/// <param name="source">
/// The #GSource
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSourceFuncsFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);
