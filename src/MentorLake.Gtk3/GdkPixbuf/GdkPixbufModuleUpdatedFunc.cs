namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Defines the type of the function that gets called every time a region
/// of @pixbuf is updated.
/// </para>
/// <para>
/// #GdkPixbufLoader uses a function of this type to emit the
/// &quot;&amp;lt;link linkend=&quot;GdkPixbufLoader-area-updated&quot;&amp;gt;area_updated&amp;lt;/link&amp;gt;&quot;
/// signal.
/// </para>
/// </summary>

/// <param name="pixbuf">
/// the #GdkPixbuf that is currently being loaded.
/// </param>
/// <param name="x">
/// the X origin of the updated area.
/// </param>
/// <param name="y">
/// the Y origin of the updated area.
/// </param>
/// <param name="width">
/// the width of the updated area.
/// </param>
/// <param name="height">
/// the height of the updated area.
/// </param>
/// <param name="user_data">
/// the loader.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GdkPixbufModuleUpdatedFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf, int x, int y, int width, int height, IntPtr user_data);
