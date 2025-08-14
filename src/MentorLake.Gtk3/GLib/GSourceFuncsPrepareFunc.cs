namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Checks the source for readiness.
/// </para>
/// <para>
/// Called before all the file descriptors are polled. If the
/// source can determine that it is ready here (without waiting for the
/// results of the poll call) it should return %TRUE. It can also return
/// a @timeout_ value which should be the maximum timeout (in milliseconds)
/// which should be passed to the poll call. The actual timeout used will
/// be `-1` if all sources returned `-1`, or it will be the minimum of all
/// the @timeout_ values returned which were greater than or equal to `0`.
/// If the prepare function returns a timeout and the source also has a
/// ready time set, then the lower of the two will be used.
/// </para>
/// <para>
/// Since 2.36 this may be `NULL`, in which case the effect is as if the
/// function always returns `FALSE` with a timeout of `-1`.
/// </para>
/// </summary>

/// <param name="source">
/// The #GSource
/// </param>
/// <param name="timeout_">
/// the maximum timeout (in milliseconds) which should be passed to the poll call
/// </param>
/// <return>
/// %TRUE if the source is ready, %FALSE otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSourceFuncsPrepareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, out int timeout_);
