namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of function passed to g_main_context_set_poll_func().
/// The semantics of the function should match those of the poll() system call.
/// </para>
/// </summary>

/// <param name="ufds">
/// an array of #GPollFD elements
/// </param>
/// <param name="nfsd">
/// the number of elements in @ufds
/// </param>
/// <param name="timeout_">
/// the maximum time to wait for an event of the file descriptors.
///     A negative value indicates an infinite timeout.
/// </param>
/// <return>
/// the number of #GPollFD elements which have events or errors
///     reported, or -1 if an error occurred.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GPollFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle ufds, uint nfsd, int timeout_);
