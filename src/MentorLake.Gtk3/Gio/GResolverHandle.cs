namespace MentorLake.Gio;

public class GResolverHandle : GObjectHandle
{
	public static void FreeAddresses(MentorLake.GLib.GListHandle addresses)
	{
		GResolverHandleExterns.g_resolver_free_addresses(addresses);
	}

	public static void FreeTargets(MentorLake.GLib.GListHandle targets)
	{
		GResolverHandleExterns.g_resolver_free_targets(targets);
	}

	public static MentorLake.Gio.GResolverHandle GetDefault()
	{
		return GResolverHandleExterns.g_resolver_get_default();
	}

}
public static class GResolverHandleSignalExtensions
{

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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void reload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResolverHandle>))] MentorLake.Gio.GResolverHandle self, IntPtr user_data);

}


public static class GResolverHandleExtensions
{
	public static uint GetTimeout(this MentorLake.Gio.GResolverHandle resolver)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		return GResolverHandleExterns.g_resolver_get_timeout(resolver);
	}

	public static string LookupByAddress(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GInetAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_address(resolver, address, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LookupByAddressAsync<T>(this T resolver, MentorLake.Gio.GInetAddressHandle address, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_by_address_async(resolver, address, cancellable, callback, user_data);
		return resolver;
	}

	public static string LookupByAddressFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_address_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GListHandle LookupByName(this MentorLake.Gio.GResolverHandle resolver, string hostname, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name(resolver, hostname, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LookupByNameAsync<T>(this T resolver, string hostname, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_by_name_async(resolver, hostname, cancellable, callback, user_data);
		return resolver;
	}

	public static MentorLake.GLib.GListHandle LookupByNameFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GListHandle LookupByNameWithFlags(this MentorLake.Gio.GResolverHandle resolver, string hostname, MentorLake.Gio.GResolverNameLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name_with_flags(resolver, hostname, flags, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LookupByNameWithFlagsAsync<T>(this T resolver, string hostname, MentorLake.Gio.GResolverNameLookupFlags flags, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_by_name_with_flags_async(resolver, hostname, flags, cancellable, callback, user_data);
		return resolver;
	}

	public static MentorLake.GLib.GListHandle LookupByNameWithFlagsFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_by_name_with_flags_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GListHandle LookupRecords(this MentorLake.Gio.GResolverHandle resolver, string rrname, MentorLake.Gio.GResolverRecordType record_type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_records(resolver, rrname, record_type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LookupRecordsAsync<T>(this T resolver, string rrname, MentorLake.Gio.GResolverRecordType record_type, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_records_async(resolver, rrname, record_type, cancellable, callback, user_data);
		return resolver;
	}

	public static MentorLake.GLib.GListHandle LookupRecordsFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_records_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GListHandle LookupService(this MentorLake.Gio.GResolverHandle resolver, string service, string protocol, string domain, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_service(resolver, service, protocol, domain, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LookupServiceAsync<T>(this T resolver, string service, string protocol, string domain, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_lookup_service_async(resolver, service, protocol, domain, cancellable, callback, user_data);
		return resolver;
	}

	public static MentorLake.GLib.GListHandle LookupServiceFinish(this MentorLake.Gio.GResolverHandle resolver, MentorLake.Gio.GAsyncResultHandle result)
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		var externCallResult = GResolverHandleExterns.g_resolver_lookup_service_finish(resolver, result, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T SetDefault<T>(this T resolver) where T : GResolverHandle
	{
		if (resolver.IsInvalid) throw new Exception("Invalid handle (GResolverHandle)");
		GResolverHandleExterns.g_resolver_set_default(resolver);
		return resolver;
	}

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
