namespace MentorLake.Gio;

public class GSocketAddressEnumeratorHandle : GObjectHandle
{
}

public static class GSocketAddressEnumeratorHandleExtensions
{
	public static MentorLake.Gio.GSocketAddressHandle Next(this MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next(enumerator, cancellable, error);
	}

	public static T NextAsync<T>(this T enumerator, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketAddressEnumeratorHandle
	{
		GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next_async(enumerator, cancellable, callback, user_data);
		return enumerator;
	}

	public static MentorLake.Gio.GSocketAddressHandle NextFinish(this MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, MentorLake.Gio.GAsyncResultHandle result, IntPtr error)
	{
		return GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next_finish(enumerator, result, error);
	}

}

internal class GSocketAddressEnumeratorHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_enumerator_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_address_enumerator_next_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_enumerator_next_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, IntPtr error);

}
