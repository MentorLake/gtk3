namespace MentorLake.Gio;

/// <summary>
/// <para>
/// The object that handles DNS resolution. Use [func@Gio.Resolver.get_default]
/// to get the default resolver.
/// </para>
/// <para>
/// `GResolver` provides cancellable synchronous and asynchronous DNS
/// resolution, for hostnames ([method@Gio.Resolver.lookup_by_address],
/// [method@Gio.Resolver.lookup_by_name] and their async variants) and SRV
/// (service) records ([method@Gio.Resolver.lookup_service]).
/// </para>
/// <para>
/// [class@Gio.NetworkAddress] and [class@Gio.NetworkService] provide wrappers
/// around `GResolver` functionality that also implement
/// [iface@Gio.SocketConnectable], making it easy to connect to a remote
/// host/service.
/// </para>
/// <para>
/// The default resolver (see [func@Gio.Resolver.get_default]) has a timeout of
/// 30s set on it since GLib 2.78. Earlier versions of GLib did not support
/// resolver timeouts.
/// </para>
/// <para>
/// This is an abstract type; subclasses of it implement different resolvers for
/// different platforms and situations.
/// </para>
/// </summary>

public class GResolverHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Frees @addresses (which should be the return value from
/// g_resolver_lookup_by_name() or g_resolver_lookup_by_name_finish()).
/// (This is a convenience method; you can also simply free the results
/// by hand.)
/// </para>
/// </summary>

/// <param name="addresses">
/// a #GList of #GInetAddress
/// </param>

	public static void FreeAddresses(MentorLake.GLib.GListHandle addresses)
	{
		GResolverHandleExterns.g_resolver_free_addresses(addresses);
	}

/// <summary>
/// <para>
/// Frees @targets (which should be the return value from
/// g_resolver_lookup_service() or g_resolver_lookup_service_finish()).
/// (This is a convenience method; you can also simply free the
/// results by hand.)
/// </para>
/// </summary>

/// <param name="targets">
/// a #GList of #GSrvTarget
/// </param>

	public static void FreeTargets(MentorLake.GLib.GListHandle targets)
	{
		GResolverHandleExterns.g_resolver_free_targets(targets);
	}

/// <summary>
/// <para>
/// Gets the default #GResolver. You should unref it when you are done
/// with it. #GResolver may use its reference count as a hint about how
/// many threads it should allocate for concurrent DNS resolutions.
/// </para>
/// </summary>

/// <return>
/// the default #GResolver.
/// </return>

	public static MentorLake.Gio.GResolverHandle GetDefault()
	{
		return GResolverHandleExterns.g_resolver_get_default();
	}

}
public static class GResolverHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the resolver notices that the system resolver
/// configuration has changed.
/// </para>
/// </summary>

	public static IObservable<GResolverHandleSignalStructs.ReloadSignal> Signal_Reload(this GResolverHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GResolverHandleSignalStructs.ReloadSignal> obs) =>
		{
			GResolverHandleSignalDelegates.reload handler = ( MentorLake.Gio.GResolverHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GResolverHandleSignalStructs.ReloadSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "reload", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GResolverHandleSignalStructs
{

public class ReloadSignal
{

	public MentorLake.Gio.GResolverHandle Self;

	public IntPtr UserData;
}
}

public static class GResolverHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the resolver notices that the system resolver
/// configuration has changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void reload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle self, IntPtr user_data);

}


public static class GResolverHandleExtensions
{
/// <summary>
/// <para>
/// Get the timeout applied to all resolver lookups. See #GResolver:timeout.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <return>
/// the resolver timeout, in milliseconds, or `0` for no timeout
/// </return>

	public static uint GetTimeout(this MentorLake.Gio.GResolverHandle resolver)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		return GResolverHandleExterns.g_resolver_get_timeout(resolver);
	}

/// <summary>
/// <para>
/// Synchronously reverse-resolves @address to determine its
/// associated hostname.
/// </para>
/// <para>
/// If the DNS resolution fails, @error (if non-%NULL) will be set to
/// a value from #GResolverError.
/// </para>
/// <para>
/// If @cancellable is non-%NULL, it can be used to cancel the
/// operation, in which case @error (if non-%NULL) will be set to
/// %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="address">
/// the address to reverse-resolve
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a hostname (either ASCII-only, or in ASCII-encoded
///     form), or %NULL on error.
/// </return>

	public static string LookupByAddress(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GInetAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_address(resolver, address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Begins asynchronously reverse-resolving @address to determine its
/// associated hostname, and eventually calls @callback, which must
/// call g_resolver_lookup_by_address_finish() to get the final result.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="address">
/// the address to reverse-resolve
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call after resolution completes
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T LookupByAddressAsync<T>(this T resolver, MentorLake.Gio.GInetAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_by_address_async(resolver, address, cancellable, callback, user_data);
		return resolver;
	}

/// <summary>
/// <para>
/// Retrieves the result of a previous call to
/// g_resolver_lookup_by_address_async().
/// </para>
/// <para>
/// If the DNS resolution failed, @error (if non-%NULL) will be set to
/// a value from #GResolverError. If the operation was cancelled,
/// @error will be set to %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="result">
/// the result passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// a hostname (either ASCII-only, or in ASCII-encoded
/// form), or %NULL on error.
/// </return>

	public static string LookupByAddressFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_address_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously resolves @hostname to determine its associated IP
/// address(es). @hostname may be an ASCII-only or UTF-8 hostname, or
/// the textual form of an IP address (in which case this just becomes
/// a wrapper around g_inet_address_new_from_string()).
/// </para>
/// <para>
/// On success, g_resolver_lookup_by_name() will return a non-empty #GList of
/// #GInetAddress, sorted in order of preference and guaranteed to not
/// contain duplicates. That is, if using the result to connect to
/// @hostname, you should attempt to connect to the first address
/// first, then the second if the first fails, etc. If you are using
/// the result to listen on a socket, it is appropriate to add each
/// result using e.g. g_socket_listener_add_address().
/// </para>
/// <para>
/// If the DNS resolution fails, @error (if non-%NULL) will be set to a
/// value from #GResolverError and %NULL will be returned.
/// </para>
/// <para>
/// If @cancellable is non-%NULL, it can be used to cancel the
/// operation, in which case @error (if non-%NULL) will be set to
/// %G_IO_ERROR_CANCELLED.
/// </para>
/// <para>
/// If you are planning to connect to a socket on the resolved IP
/// address, it may be easier to create a #GNetworkAddress and use its
/// #GSocketConnectable interface.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="hostname">
/// the hostname to look up
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a non-empty #GList
/// of #GInetAddress, or %NULL on error. You
/// must unref each of the addresses and free the list when you are
/// done with it. (You can use g_resolver_free_addresses() to do this.)
/// </return>

	public static MentorLake.GLib.GListHandle LookupByName(this MentorLake.Gio.GResolverHandle resolver, string hostname, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name(resolver, hostname, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Begins asynchronously resolving @hostname to determine its
/// associated IP address(es), and eventually calls @callback, which
/// must call g_resolver_lookup_by_name_finish() to get the result.
/// See g_resolver_lookup_by_name() for more details.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="hostname">
/// the hostname to look up the address of
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call after resolution completes
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T LookupByNameAsync<T>(this T resolver, string hostname, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_by_name_async(resolver, hostname, cancellable, callback, user_data);
		return resolver;
	}

/// <summary>
/// <para>
/// Retrieves the result of a call to
/// g_resolver_lookup_by_name_async().
/// </para>
/// <para>
/// If the DNS resolution failed, @error (if non-%NULL) will be set to
/// a value from #GResolverError. If the operation was cancelled,
/// @error will be set to %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="result">
/// the result passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// a #GList
/// of #GInetAddress, or %NULL on error. See g_resolver_lookup_by_name()
/// for more details.
/// </return>

	public static MentorLake.GLib.GListHandle LookupByNameFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This differs from g_resolver_lookup_by_name() in that you can modify
/// the lookup behavior with @flags. For example this can be used to limit
/// results with %G_RESOLVER_NAME_LOOKUP_FLAGS_IPV4_ONLY.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="hostname">
/// the hostname to look up
/// </param>
/// <param name="flags">
/// extra #GResolverNameLookupFlags for the lookup
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a non-empty #GList
/// of #GInetAddress, or %NULL on error. You
/// must unref each of the addresses and free the list when you are
/// done with it. (You can use g_resolver_free_addresses() to do this.)
/// </return>

	public static MentorLake.GLib.GListHandle LookupByNameWithFlags(this MentorLake.Gio.GResolverHandle resolver, string hostname, MentorLake.Gio.GResolverNameLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name_with_flags(resolver, hostname, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Begins asynchronously resolving @hostname to determine its
/// associated IP address(es), and eventually calls @callback, which
/// must call g_resolver_lookup_by_name_with_flags_finish() to get the result.
/// See g_resolver_lookup_by_name() for more details.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="hostname">
/// the hostname to look up the address of
/// </param>
/// <param name="flags">
/// extra #GResolverNameLookupFlags for the lookup
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call after resolution completes
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T LookupByNameWithFlagsAsync<T>(this T resolver, string hostname, MentorLake.Gio.GResolverNameLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_by_name_with_flags_async(resolver, hostname, flags, cancellable, callback, user_data);
		return resolver;
	}

/// <summary>
/// <para>
/// Retrieves the result of a call to
/// g_resolver_lookup_by_name_with_flags_async().
/// </para>
/// <para>
/// If the DNS resolution failed, @error (if non-%NULL) will be set to
/// a value from #GResolverError. If the operation was cancelled,
/// @error will be set to %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="result">
/// the result passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// a #GList
/// of #GInetAddress, or %NULL on error. See g_resolver_lookup_by_name()
/// for more details.
/// </return>

	public static MentorLake.GLib.GListHandle LookupByNameWithFlagsFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name_with_flags_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously performs a DNS record lookup for the given @rrname and returns
/// a list of records as #GVariant tuples. See #GResolverRecordType for
/// information on what the records contain for each @record_type.
/// </para>
/// <para>
/// If the DNS resolution fails, @error (if non-%NULL) will be set to
/// a value from #GResolverError and %NULL will be returned.
/// </para>
/// <para>
/// If @cancellable is non-%NULL, it can be used to cancel the
/// operation, in which case @error (if non-%NULL) will be set to
/// %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="rrname">
/// the DNS name to look up the record for
/// </param>
/// <param name="record_type">
/// the type of DNS record to look up
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a non-empty #GList of
/// #GVariant, or %NULL on error. You must free each of the records and the list
/// when you are done with it. (You can use g_list_free_full() with
/// g_variant_unref() to do this.)
/// </return>

	public static MentorLake.GLib.GListHandle LookupRecords(this MentorLake.Gio.GResolverHandle resolver, string rrname, MentorLake.Gio.GResolverRecordType record_type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_records(resolver, rrname, record_type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Begins asynchronously performing a DNS lookup for the given
/// @rrname, and eventually calls @callback, which must call
/// g_resolver_lookup_records_finish() to get the final result. See
/// g_resolver_lookup_records() for more details.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="rrname">
/// the DNS name to look up the record for
/// </param>
/// <param name="record_type">
/// the type of DNS record to look up
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call after resolution completes
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T LookupRecordsAsync<T>(this T resolver, string rrname, MentorLake.Gio.GResolverRecordType record_type, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_records_async(resolver, rrname, record_type, cancellable, callback, user_data);
		return resolver;
	}

/// <summary>
/// <para>
/// Retrieves the result of a previous call to
/// g_resolver_lookup_records_async(). Returns a non-empty list of records as
/// #GVariant tuples. See #GResolverRecordType for information on what the
/// records contain.
/// </para>
/// <para>
/// If the DNS resolution failed, @error (if non-%NULL) will be set to
/// a value from #GResolverError. If the operation was cancelled,
/// @error will be set to %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="result">
/// the result passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// a non-empty #GList of
/// #GVariant, or %NULL on error. You must free each of the records and the list
/// when you are done with it. (You can use g_list_free_full() with
/// g_variant_unref() to do this.)
/// </return>

	public static MentorLake.GLib.GListHandle LookupRecordsFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_records_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Synchronously performs a DNS SRV lookup for the given @service and
/// @protocol in the given @domain and returns an array of #GSrvTarget.
/// @domain may be an ASCII-only or UTF-8 hostname. Note also that the
/// @service and @protocol arguments do not include the leading underscore
/// that appears in the actual DNS entry.
/// </para>
/// <para>
/// On success, g_resolver_lookup_service() will return a non-empty #GList of
/// #GSrvTarget, sorted in order of preference. (That is, you should
/// attempt to connect to the first target first, then the second if
/// the first fails, etc.)
/// </para>
/// <para>
/// If the DNS resolution fails, @error (if non-%NULL) will be set to
/// a value from #GResolverError and %NULL will be returned.
/// </para>
/// <para>
/// If @cancellable is non-%NULL, it can be used to cancel the
/// operation, in which case @error (if non-%NULL) will be set to
/// %G_IO_ERROR_CANCELLED.
/// </para>
/// <para>
/// If you are planning to connect to the service, it is usually easier
/// to create a #GNetworkService and use its #GSocketConnectable
/// interface.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="service">
/// the service type to look up (eg, &quot;ldap&quot;)
/// </param>
/// <param name="protocol">
/// the networking protocol to use for @service (eg, &quot;tcp&quot;)
/// </param>
/// <param name="domain">
/// the DNS domain to look up the service in
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <return>
/// a non-empty #GList of
/// #GSrvTarget, or %NULL on error. You must free each of the targets and the
/// list when you are done with it. (You can use g_resolver_free_targets() to do
/// this.)
/// </return>

	public static MentorLake.GLib.GListHandle LookupService(this MentorLake.Gio.GResolverHandle resolver, string service, string protocol, string domain, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_service(resolver, service, protocol, domain, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Begins asynchronously performing a DNS SRV lookup for the given
/// @service and @protocol in the given @domain, and eventually calls
/// @callback, which must call g_resolver_lookup_service_finish() to
/// get the final result. See g_resolver_lookup_service() for more
/// details.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="service">
/// the service type to look up (eg, &quot;ldap&quot;)
/// </param>
/// <param name="protocol">
/// the networking protocol to use for @service (eg, &quot;tcp&quot;)
/// </param>
/// <param name="domain">
/// the DNS domain to look up the service in
/// </param>
/// <param name="cancellable">
/// a #GCancellable, or %NULL
/// </param>
/// <param name="callback">
/// callback to call after resolution completes
/// </param>
/// <param name="user_data">
/// data for @callback
/// </param>

	public static T LookupServiceAsync<T>(this T resolver, string service, string protocol, string domain, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_service_async(resolver, service, protocol, domain, cancellable, callback, user_data);
		return resolver;
	}

/// <summary>
/// <para>
/// Retrieves the result of a previous call to
/// g_resolver_lookup_service_async().
/// </para>
/// <para>
/// If the DNS resolution failed, @error (if non-%NULL) will be set to
/// a value from #GResolverError. If the operation was cancelled,
/// @error will be set to %G_IO_ERROR_CANCELLED.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="result">
/// the result passed to your #GAsyncReadyCallback
/// </param>
/// <return>
/// a non-empty #GList of
/// #GSrvTarget, or %NULL on error. See g_resolver_lookup_service() for more
/// details.
/// </return>

	public static MentorLake.GLib.GListHandle LookupServiceFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_service_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Sets @resolver to be the application&apos;s default resolver (reffing
/// @resolver, and unreffing the previous default resolver, if any).
/// Future calls to g_resolver_get_default() will return this resolver.
/// </para>
/// <para>
/// This can be used if an application wants to perform any sort of DNS
/// caching or &quot;pinning&quot;; it can implement its own #GResolver that
/// calls the original default resolver for DNS operations, and
/// implements its own cache policies on top of that, and then set
/// itself as the default resolver for all later code to use.
/// </para>
/// </summary>

/// <param name="resolver">
/// the new default #GResolver
/// </param>

	public static T SetDefault<T>(this T resolver) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_set_default(resolver);
		return resolver;
	}

/// <summary>
/// <para>
/// Set the timeout applied to all resolver lookups. See #GResolver:timeout.
/// </para>
/// </summary>

/// <param name="resolver">
/// a #GResolver
/// </param>
/// <param name="timeout_ms">
/// timeout in milliseconds, or `0` for no timeouts
/// </param>

	public static T SetTimeout<T>(this T resolver, uint timeout_ms) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_set_timeout(resolver, timeout_ms);
		return resolver;
	}

}

internal class GResolverHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern uint g_resolver_get_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_resolver_lookup_by_address([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_lookup_by_address_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInetAddressHandle>))] MentorLake.Gio.GInetAddressHandle address, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_resolver_lookup_by_address_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string hostname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_lookup_by_name_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string hostname, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_by_name_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_by_name_with_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string hostname, MentorLake.Gio.GResolverNameLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_lookup_by_name_with_flags_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string hostname, MentorLake.Gio.GResolverNameLookupFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_by_name_with_flags_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_records([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string rrname, MentorLake.Gio.GResolverRecordType record_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_lookup_records_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string rrname, MentorLake.Gio.GResolverRecordType record_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_records_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_service([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string service, string protocol, string domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_lookup_service_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, string service, string protocol, string domain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_resolver_lookup_service_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_set_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_set_timeout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle resolver, uint timeout_ms);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_free_addresses([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle addresses);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resolver_free_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))]
	internal static extern MentorLake.Gio.GResolverHandle g_resolver_get_default();

}
