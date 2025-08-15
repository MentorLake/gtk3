namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// Save functions used by [method@GdkPixbuf.Pixbuf.save_to_callback].
/// </para>
/// <para>
/// This function is called once for each block of bytes that is &quot;written&quot;
/// by `gdk_pixbuf_save_to_callback()`.
/// </para>
/// <para>
/// If successful it should return `TRUE`; if an error occurs it should set
/// `error` and return `FALSE`, in which case `gdk_pixbuf_save_to_callback()`
/// will fail with the same error.
/// </para>
/// </summary>

/// <param name="buf">
/// bytes to be written.
/// </param>
/// <param name="count">
/// number of bytes in @buf.
/// </param>
/// <param name="error">
/// A location to return an error.
/// </param>
/// <param name="data">
/// user data passed to gdk_pixbuf_save_to_callback().
/// </param>
/// <return>
/// `TRUE` if successful, `FALSE` otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GdkPixbufSaveFunc(byte[] buf, UIntPtr count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] out MentorLake.GLib.GErrorHandle error, IntPtr data);
