namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Defines the type of the function that gets called once the initial
/// setup of @pixbuf is done.
/// </para>
/// <para>
/// #GdkPixbufLoader uses a function of this type to emit the
/// "<link linkend="GdkPixbufLoader-area-prepared">area_prepared</link>"
/// signal.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// the #GdkPixbuf that is currently being loaded.
/// </param>
/// <param name="anim">
/// if an animation is being loaded, the #GdkPixbufAnimation, else %NULL.
/// </param>
/// <param name="user_data">
/// the loader.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModulePreparedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufAnimationHandle>))] MentorLake.GdkPixbuf.GdkPixbufAnimationHandle anim, IntPtr user_data);
