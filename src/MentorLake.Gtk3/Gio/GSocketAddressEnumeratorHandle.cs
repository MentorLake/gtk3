namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GSocketAddressEnumerator` is an enumerator type for
/// [class@Gio.SocketAddress] instances. It is returned by enumeration functions
/// such as [method@Gio.SocketConnectable.enumerate], which returns a
/// `GSocketAddressEnumerator` to list each [class@Gio.SocketAddress] which could
/// be used to connect to that [iface@Gio.SocketConnectable].
/// </para>
/// <para>
/// Enumeration is typically a blocking operation, so the asynchronous methods
/// [method@Gio.SocketAddressEnumerator.next_async] and
/// [method@Gio.SocketAddressEnumerator.next_finish] should be used where
/// possible.
/// </para>
/// <para>
/// Each `GSocketAddressEnumerator` can only be enumerated once. Once
/// [method@Gio.SocketAddressEnumerator.next] has returned `NULL`, further
/// enumeration with that `GSocketAddressEnumerator` is not possible, and it can
/// be unreffed.
/// </para>
/// </summary>

public class GSocketAddressEnumeratorHandle : GObjectHandle
{
}

public static class GSocketAddressEnumeratorHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the next #GSocketAddress from @enumerator. Note that this
/// may block for some amount of time. (Eg, a #GNetworkAddress may need
/// to do a DNS lookup before it can return an address.) Use
/// g_socket_address_enumerator_next_async() if you need to avoid
/// blocking.
/// </para>
/// <para>
/// If @enumerator is expected to yield addresses, but for some reason
/// is unable to (eg, because of a DNS error), then the first call to
/// g_socket_address_enumerator_next() will return an appropriate error
/// in `*error`. However, if the first call to
/// g_socket_address_enumerator_next() succeeds, then any further
/// internal errors (other than @cancellable being triggered) will be
/// ignored.
/// </para>
/// </summary>

/// <param name="enumerator">
/// a #GSocketAddressEnumerator
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <return>
/// a #GSocketAddress (owned by the caller), or %NULL on
///     error (in which case `*error` will be set) or if there are no
///     more addresses.
/// </return>

	public static MentorLake.Gio.GSocketAddressHandle Next(this MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GSocketAddressEnumeratorHandle)");
		var externCallResult = GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next(enumerator, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Asynchronously retrieves the next #GSocketAddress from @enumerator
/// and then calls @callback, which must call
/// g_socket_address_enumerator_next_finish() to get the result.
/// </para>
/// <para>
/// It is an error to call this multiple times before the previous callback has finished.
/// </para>
/// </summary>

/// <param name="enumerator">
/// a #GSocketAddressEnumerator
/// </param>
/// <param name="cancellable">
/// optional #GCancellable object, %NULL to ignore.
/// </param>
/// <param name="callback">
/// a #GAsyncReadyCallback to call
///   when the request is satisfied
/// </param>
/// <param name="user_data">
/// the data to pass to callback function
/// </param>

	public static T NextAsync<T>(this T enumerator, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GSocketAddressEnumeratorHandle
	{
		if (enumerator.IsInvalid) throw new Exception("Invalid handle (GSocketAddressEnumeratorHandle)");
		GSocketAddressEnumeratorHandleExterns.g_socket_address_enumerator_next_async(enumerator, cancellable, callback, user_data);
		return enumerator;
	}

/// <summary>
/// <para>
/// Retrieves the result of a completed call to
/// g_socket_address_enumerator_next_async(). See
/// g_socket_address_enumerator_next() for more information about
/// error handling.
/// </para>
/// </summary>

/// <param name="enumerator">
/// a #GSocketAddressEnumerator
/// </param>
/// <param name="result">
/// a #GAsyncResult
/// </param>
/// <return>
/// a #GSocketAddress (owned by the caller), or %NULL on
///     error (in which case `*error` will be set) or if there are no
///     more addresses.
/// </return>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_enumerator_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_socket_address_enumerator_next_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSocketAddressHandle>))]
	internal static extern MentorLake.Gio.GSocketAddressHandle g_socket_address_enumerator_next_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSocketAddressEnumeratorHandle>))] MentorLake.Gio.GSocketAddressEnumeratorHandle enumerator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

}
