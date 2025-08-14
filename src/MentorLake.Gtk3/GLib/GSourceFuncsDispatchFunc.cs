namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Dispatches the source callback.
/// </para>
/// <para>
/// Called to dispatch the event source, after it has returned
/// `TRUE` in either its prepare or its check function, or if a ready time
/// has been reached. The dispatch function receives a callback function and
/// user data. The callback function may be `NULL` if the source was never
/// connected to a callback using [method@GLib.Source.set_callback]. The dispatch
/// function should call the callback function with @user_data and whatever
/// additional parameters are needed for this type of event source. The
/// return value of the dispatch function should be [const@GLib.SOURCE_REMOVE]
/// if the source should be removed or [const@GLib.SOURCE_CONTINUE] to keep it.
/// </para>
/// </summary>

/// <param name="source">
/// The #GSource
/// </param>
/// <param name="callback">
/// The #GSourceFunc to call
/// </param>
/// <param name="user_data">
/// data to pass to @callback
/// </param>
/// <return>
/// [const@GLib.SOURCE_REMOVE] if the source should be removed,
///   [const@GLib.SOURCE_CONTINUE] otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSourceFuncsDispatchFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc callback, IntPtr user_data);
