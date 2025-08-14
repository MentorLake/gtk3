namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A function of this type is passed to gdk_window_invalidate_maybe_recurse().
/// It gets called for each child of the window to determine whether to
/// recursively invalidate it or now.
/// </para>
/// </summary>

/// <param name="window">
/// a #GdkWindow
/// </param>
/// <param name="user_data">
/// user data
/// </param>
/// <return>
/// %TRUE to invalidate @window recursively
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkWindowChildFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, IntPtr user_data);
