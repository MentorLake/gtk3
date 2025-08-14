namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Checks if the source is ready to be dispatched.
/// </para>
/// <para>
/// Called after all the file descriptors are polled. The source
/// should return %TRUE if it is ready to be dispatched. Note that some
/// time may have passed since the previous prepare function was called,
/// so the source should be checked again here.
/// </para>
/// <para>
/// Since 2.36 this may be `NULL`, in which case the effect is
/// as if the function always returns `FALSE`.
/// </para>
/// </summary>

/// <param name="source">
/// The #GSource
/// </param>
/// <return>
/// %TRUE if ready to be dispatched, %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSourceFuncsCheckFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source);
