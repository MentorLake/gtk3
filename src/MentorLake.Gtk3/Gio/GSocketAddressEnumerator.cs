namespace MentorLake.Gtk3.Gio;

public class GSocketAddressEnumeratorHandle : GObjectHandle
{
}

public static class GSocketAddressEnumeratorHandleExtensions
{
	public static GSocketAddressHandle Next(this GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GSocketAddressEnumeratorExterns.g_socket_address_enumerator_next(enumerator, cancellable, out error);
	}

	public static T NextAsync<T>(this T enumerator, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketAddressEnumeratorHandle
	{
		GSocketAddressEnumeratorExterns.g_socket_address_enumerator_next_async(enumerator, cancellable, callback, user_data);
		return enumerator;
	}

	public static GSocketAddressHandle NextFinish(this GSocketAddressEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GSocketAddressEnumeratorExterns.g_socket_address_enumerator_next_finish(enumerator, result, out error);
	}

}

internal class GSocketAddressEnumeratorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_address_enumerator_next(GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_address_enumerator_next_async(GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GSocketAddressHandle g_socket_address_enumerator_next_finish(GSocketAddressEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error);

}
