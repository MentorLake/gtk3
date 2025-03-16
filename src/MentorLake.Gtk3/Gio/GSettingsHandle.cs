namespace MentorLake.Gio;

public class GSettingsHandle : GObjectHandle
{
	public static MentorLake.Gio.GSettingsHandle New(string schema_id)
	{
		return GSettingsHandleExterns.g_settings_new(schema_id);
	}

	public static MentorLake.Gio.GSettingsHandle NewFull(MentorLake.Gio.GSettingsSchemaHandle schema, MentorLake.Gio.GSettingsBackendHandle backend, string path)
	{
		return GSettingsHandleExterns.g_settings_new_full(schema, backend, path);
	}

	public static MentorLake.Gio.GSettingsHandle NewWithBackend(string schema_id, MentorLake.Gio.GSettingsBackendHandle backend)
	{
		return GSettingsHandleExterns.g_settings_new_with_backend(schema_id, backend);
	}

	public static MentorLake.Gio.GSettingsHandle NewWithBackendAndPath(string schema_id, MentorLake.Gio.GSettingsBackendHandle backend, string path)
	{
		return GSettingsHandleExterns.g_settings_new_with_backend_and_path(schema_id, backend, path);
	}

	public static MentorLake.Gio.GSettingsHandle NewWithPath(string schema_id, string path)
	{
		return GSettingsHandleExterns.g_settings_new_with_path(schema_id, path);
	}

	public static string[] ListRelocatableSchemas()
	{
		return GSettingsHandleExterns.g_settings_list_relocatable_schemas();
	}

	public static string[] ListSchemas()
	{
		return GSettingsHandleExterns.g_settings_list_schemas();
	}

	public static void Sync()
	{
		GSettingsHandleExterns.g_settings_sync();
	}

	public static void Unbind(MentorLake.GObject.GObjectHandle @object, string property)
	{
		GSettingsHandleExterns.g_settings_unbind(@object, property);
	}

}
public static class GSettingsHandleSignalExtensions
{

	public static IObservable<GSettingsHandleSignalStructs.ChangeEventSignal> Signal_ChangeEvent(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.ChangeEventSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.change_event handler = ( MentorLake.Gio.GSettingsHandle self,  MentorLake.GLib.GQuarkHandle[] keys,  int n_keys,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.ChangeEventSignal()
				{
					Self = self, Keys = keys, NKeys = n_keys, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "change-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GSettingsHandleSignalStructs.ChangedSignal> Signal_Changed(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.ChangedSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.changed handler = ( MentorLake.Gio.GSettingsHandle self,  string key,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.ChangedSignal()
				{
					Self = self, Key = key, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GSettingsHandleSignalStructs.WritableChangeEventSignal> Signal_WritableChangeEvent(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.WritableChangeEventSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.writable_change_event handler = ( MentorLake.Gio.GSettingsHandle self,  uint key,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.WritableChangeEventSignal()
				{
					Self = self, Key = key, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "writable-change-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GSettingsHandleSignalStructs.WritableChangedSignal> Signal_WritableChanged(this GSettingsHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSettingsHandleSignalStructs.WritableChangedSignal> obs) =>
		{
			GSettingsHandleSignalDelegates.writable_changed handler = ( MentorLake.Gio.GSettingsHandle self,  string key,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSettingsHandleSignalStructs.WritableChangedSignal()
				{
					Self = self, Key = key, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "writable-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSettingsHandleSignalStructs
{

public struct ChangeEventSignal
{
	public MentorLake.Gio.GSettingsHandle Self;
	public MentorLake.GLib.GQuarkHandle[] Keys;
	public int NKeys;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ChangedSignal
{
	public MentorLake.Gio.GSettingsHandle Self;
	public string Key;
	public IntPtr UserData;
}

public struct WritableChangeEventSignal
{
	public MentorLake.Gio.GSettingsHandle Self;
	public uint Key;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct WritableChangedSignal
{
	public MentorLake.Gio.GSettingsHandle Self;
	public string Key;
	public IntPtr UserData;
}
}

public static class GSettingsHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GQuarkHandle>))] MentorLake.GLib.GQuarkHandle[] keys, int n_keys, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, string key, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool writable_change_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, uint key, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void writable_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle self, string key, IntPtr user_data);

}


public static class GSettingsHandleExtensions
{
	public static T Apply<T>(this T settings) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_apply(settings);
		return settings;
	}

	public static T Bind<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_bind(settings, key, @object, property, flags);
		return settings;
	}

	public static T BindWithMapping<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, MentorLake.Gio.GSettingsBindGetMapping get_mapping, MentorLake.Gio.GSettingsBindSetMapping set_mapping, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_bind_with_mapping(settings, key, @object, property, flags, get_mapping, set_mapping, user_data, destroy);
		return settings;
	}

	public static T BindWithMappingClosures<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, MentorLake.GObject.GClosureHandle get_mapping, MentorLake.GObject.GClosureHandle set_mapping) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_bind_with_mapping_closures(settings, key, @object, property, flags, get_mapping, set_mapping);
		return settings;
	}

	public static T BindWritable<T>(this T settings, string key, MentorLake.GObject.GObjectHandle @object, string property, bool inverted) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_bind_writable(settings, key, @object, property, inverted);
		return settings;
	}

	public static MentorLake.Gio.GActionHandle CreateAction(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_create_action(settings, key);
	}

	public static T Delay<T>(this T settings) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_delay(settings);
		return settings;
	}

	public static T Get<T>(this T settings, string key, string format, IntPtr @__arglist) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_get(settings, key, format, @__arglist);
		return settings;
	}

	public static bool GetBoolean(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_boolean(settings, key);
	}

	public static MentorLake.Gio.GSettingsHandle GetChild(this MentorLake.Gio.GSettingsHandle settings, string name)
	{
		return GSettingsHandleExterns.g_settings_get_child(settings, name);
	}

	public static MentorLake.GLib.GVariantHandle GetDefaultValue(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_default_value(settings, key);
	}

	public static double GetDouble(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_double(settings, key);
	}

	public static int GetEnum(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_enum(settings, key);
	}

	public static uint GetFlags(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_flags(settings, key);
	}

	public static bool GetHasUnapplied(this MentorLake.Gio.GSettingsHandle settings)
	{
		return GSettingsHandleExterns.g_settings_get_has_unapplied(settings);
	}

	public static int GetInt(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_int(settings, key);
	}

	public static long GetInt64(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_int64(settings, key);
	}

	public static IntPtr GetMapped(this MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.Gio.GSettingsGetMapping mapping, IntPtr user_data)
	{
		return GSettingsHandleExterns.g_settings_get_mapped(settings, key, mapping, user_data);
	}

	public static MentorLake.GLib.GVariantHandle GetRange(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_range(settings, key);
	}

	public static string GetString(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_string(settings, key);
	}

	public static string[] GetStrv(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_strv(settings, key);
	}

	public static uint GetUint(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_uint(settings, key);
	}

	public static ulong GetUint64(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_uint64(settings, key);
	}

	public static MentorLake.GLib.GVariantHandle GetUserValue(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_user_value(settings, key);
	}

	public static MentorLake.GLib.GVariantHandle GetValue(this MentorLake.Gio.GSettingsHandle settings, string key)
	{
		return GSettingsHandleExterns.g_settings_get_value(settings, key);
	}

	public static bool IsWritable(this MentorLake.Gio.GSettingsHandle settings, string name)
	{
		return GSettingsHandleExterns.g_settings_is_writable(settings, name);
	}

	public static string[] ListChildren(this MentorLake.Gio.GSettingsHandle settings)
	{
		return GSettingsHandleExterns.g_settings_list_children(settings);
	}

	public static string[] ListKeys(this MentorLake.Gio.GSettingsHandle settings)
	{
		return GSettingsHandleExterns.g_settings_list_keys(settings);
	}

	public static bool RangeCheck(this MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.GLib.GVariantHandle value)
	{
		return GSettingsHandleExterns.g_settings_range_check(settings, key, value);
	}

	public static T Reset<T>(this T settings, string key) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_reset(settings, key);
		return settings;
	}

	public static T Revert<T>(this T settings) where T : GSettingsHandle
	{
		GSettingsHandleExterns.g_settings_revert(settings);
		return settings;
	}

	public static bool Set(this MentorLake.Gio.GSettingsHandle settings, string key, string format, IntPtr @__arglist)
	{
		return GSettingsHandleExterns.g_settings_set(settings, key, format, @__arglist);
	}

	public static bool SetBoolean(this MentorLake.Gio.GSettingsHandle settings, string key, bool value)
	{
		return GSettingsHandleExterns.g_settings_set_boolean(settings, key, value);
	}

	public static bool SetDouble(this MentorLake.Gio.GSettingsHandle settings, string key, double value)
	{
		return GSettingsHandleExterns.g_settings_set_double(settings, key, value);
	}

	public static bool SetEnum(this MentorLake.Gio.GSettingsHandle settings, string key, int value)
	{
		return GSettingsHandleExterns.g_settings_set_enum(settings, key, value);
	}

	public static bool SetFlags(this MentorLake.Gio.GSettingsHandle settings, string key, uint value)
	{
		return GSettingsHandleExterns.g_settings_set_flags(settings, key, value);
	}

	public static bool SetInt(this MentorLake.Gio.GSettingsHandle settings, string key, int value)
	{
		return GSettingsHandleExterns.g_settings_set_int(settings, key, value);
	}

	public static bool SetInt64(this MentorLake.Gio.GSettingsHandle settings, string key, long value)
	{
		return GSettingsHandleExterns.g_settings_set_int64(settings, key, value);
	}

	public static bool SetString(this MentorLake.Gio.GSettingsHandle settings, string key, string value)
	{
		return GSettingsHandleExterns.g_settings_set_string(settings, key, value);
	}

	public static bool SetStrv(this MentorLake.Gio.GSettingsHandle settings, string key, string[] value)
	{
		return GSettingsHandleExterns.g_settings_set_strv(settings, key, value);
	}

	public static bool SetUint(this MentorLake.Gio.GSettingsHandle settings, string key, uint value)
	{
		return GSettingsHandleExterns.g_settings_set_uint(settings, key, value);
	}

	public static bool SetUint64(this MentorLake.Gio.GSettingsHandle settings, string key, ulong value)
	{
		return GSettingsHandleExterns.g_settings_set_uint64(settings, key, value);
	}

	public static bool SetValue(this MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.GLib.GVariantHandle value)
	{
		return GSettingsHandleExterns.g_settings_set_value(settings, key, value);
	}

}

internal class GSettingsHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new(string schema_id);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsSchemaHandle>))] MentorLake.Gio.GSettingsSchemaHandle schema, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_with_backend(string schema_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_with_backend_and_path(string schema_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_new_with_path(string schema_id, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind_with_mapping([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, MentorLake.Gio.GSettingsBindGetMapping get_mapping, MentorLake.Gio.GSettingsBindSetMapping set_mapping, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind_with_mapping_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, MentorLake.Gio.GSettingsBindFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle get_mapping, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle set_mapping);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_bind_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property, bool inverted);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GActionHandle g_settings_create_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_delay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsHandle g_settings_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_default_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern double g_settings_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_settings_get_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_settings_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_get_has_unapplied([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_settings_get_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern long g_settings_get_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_settings_get_mapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, MentorLake.Gio.GSettingsGetMapping mapping, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_settings_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_settings_get_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern uint g_settings_get_uint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern ulong g_settings_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_user_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_settings_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_is_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_settings_list_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_settings_list_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_range_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_revert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, bool value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, double value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_enum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, int value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, uint value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, int value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, long value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, string[] value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_uint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, uint value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, ulong value);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_settings_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsHandle>))] MentorLake.Gio.GSettingsHandle settings, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_settings_list_relocatable_schemas();

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_settings_list_schemas();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_sync();

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_unbind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property);

}
