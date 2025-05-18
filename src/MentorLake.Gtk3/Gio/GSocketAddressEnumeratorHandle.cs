namespace MentorLake.Gio;

public class GSocketAddressEnumeratorHandle : GObjectHandle
{
}

public static class GSocketAddressEnumeratorHandleExtensions
{
	public static MentorLake.Gio.GSocketAddressHandle Next(this MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GSocketAddressEnumeratorHandle)");
		var externCallResult = GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next(enumerator, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T NextAsync<T>(this T enumerator, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketAddressEnumeratorHandle
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GSocketAddressEnumeratorHandle)");
		GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next_async(enumerator, cancellable, callback, user_data);
		return enumerator;
	}

	public static MentorLake.Gio.GSocketAddressHandle NextFinish(this MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GSocketAddressEnumeratorHandle)");
		var externCallResult = GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next_finish(enumerator, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GSocketAddressEnumeratorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_enumerator_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_address_enumerator_next_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_enumerator_next_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
