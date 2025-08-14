namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Type of the callback used to set up @window so it can be
/// grabbed. A typical action would be ensuring the window is
/// visible, although there's room for other initialization
/// actions.
/// </para>
/// </summary>

/// <param name="seat">
/// the #GdkSeat being grabbed
/// </param>
/// <param name="window">
/// the #GdkWindow being grabbed
/// </param>
/// <param name="user_data">
/// user data passed in gdk_seat_grab()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkSeatGrabPrepareFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkSeatHandle>))] MentorLake.Gdk.GdkSeatHandle seat, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window, IntPtr user_data);
