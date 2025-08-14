namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GLoadableIcon` extends the [iface@Gio.Icon] interface and adds the ability
/// to load icons from streams.
/// </para>
/// </summary>

public interface GLoadableIconHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GLoadableIconHandleImpl : BaseSafeHandle, GLoadableIconHandle
{
}

public static class GLoadableIconHandleExtensions
{
/// <summary>
/// <para>
/// Loads a loadable icon. For the asynchronous version of this function,
/// see g_loadable_icon_load_async().
/// </para>
/// </summary>

/// <param name="icon">
/// a #GLoadableIcon.
/// </param>
/// <param name="size">
/// an integer.
/// </param>
/// <param name="type">
/// a location to store the type of the loaded
/// icon, %NULL to ignore.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to
/// ignore.
/// </param>
/// <return>
/// a #GInputStream to read the icon from.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle Load(this MentorLake.Gio.GLoadableIconHandle icon, int size, out string type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GLoadableIconHandle)");
		var externCallResult = GLoadableIconHandleExterns.g_loadable_icon_load(icon, size, out type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads an icon asynchronously. To finish this function, see
/// g_loadable_icon_load_finish(). For the synchronous, blocking
/// version of this function, see g_loadable_icon_load().
/// </para>
/// </summary>

/// <param name="icon">
/// a #GLoadableIcon.
/// </param>
/// <param name="size">
/// an integer.
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback
///   to call when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T LoadAsync<T>(this T icon, int size, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GLoadableIconHandle
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GLoadableIconHandle)");
		GLoadableIconHandleExterns.g_loadable_icon_load_async(icon, size, cancellable, callback, user_data);
		return icon;
	}

/// <summary>
/// <para>
/// Finishes an asynchronous icon load started in g_loadable_icon_load_async().
/// </para>
/// </summary>

/// <param name="icon">
/// a #GLoadableIcon.
/// </param>
/// <param name="res">
/// a #GAsyncResult.
/// </param>
/// <param name="type">
/// a location to store the type of the loaded
///        icon, %NULL to ignore.
/// </param>
/// <return>
/// a #GInputStream to read the icon from.
/// </return>

	public static MentorLake.Gio.GInputStreamHandle LoadFinish(this MentorLake.Gio.GLoadableIconHandle icon, MentorLake.Gio.GAsyncResultHandle res, out string type)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GLoadableIconHandle)");
		var externCallResult = GLoadableIconHandleExterns.g_loadable_icon_load_finish(icon, res, out type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GLoadableIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_loadable_icon_load([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, int size, out string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_loadable_icon_load_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, int size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_loadable_icon_load_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out string type, out MentorLake.GLib.GErrorHandle error);

}
