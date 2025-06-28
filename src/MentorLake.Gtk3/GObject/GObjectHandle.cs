namespace MentorLake.GObject;

public partial class GObjectHandle : GTypeInstanceHandle
{
	public static MentorLake.GObject.GObjectHandle New(MentorLake.GObject.GType object_type, string first_property_name, IntPtr @__arglist)
	{
		return GObjectHandleExterns.g_object_new(object_type, first_property_name, @__arglist);
	}

	public static MentorLake.GObject.GObjectHandle NewValist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args)
	{
		return GObjectHandleExterns.g_object_new_valist(object_type, first_property_name, var_args);
	}

	public static MentorLake.GObject.GObjectHandle NewWithProperties(MentorLake.GObject.GType object_type, uint n_properties, string[] names, MentorLake.GObject.GValue[] values)
	{
		return GObjectHandleExterns.g_object_new_with_properties(object_type, n_properties, names, values);
	}

	public static MentorLake.GObject.GObjectHandle Newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters)
	{
		return GObjectHandleExterns.g_object_newv(object_type, n_parameters, parameters);
	}

	public static UIntPtr CompatControl(UIntPtr what, IntPtr data)
	{
		return GObjectHandleExterns.g_object_compat_control(what, data);
	}

	public static MentorLake.GObject.GParamSpecHandle InterfaceFindProperty(MentorLake.GObject.GTypeInterfaceHandle g_iface, string property_name)
	{
		return GObjectHandleExterns.g_object_interface_find_property(g_iface, property_name);
	}

	public static void InterfaceInstallProperty(MentorLake.GObject.GTypeInterfaceHandle g_iface, MentorLake.GObject.GParamSpecHandle pspec)
	{
		GObjectHandleExterns.g_object_interface_install_property(g_iface, pspec);
	}

	public static MentorLake.GObject.GParamSpecHandle[] InterfaceListProperties(MentorLake.GObject.GTypeInterfaceHandle g_iface, out uint n_properties_p)
	{
		return GObjectHandleExterns.g_object_interface_list_properties(g_iface, out n_properties_p);
	}

}
public static class GObjectHandleSignalExtensions
{

	public static IObservable<GObjectHandleSignalStructs.NotifySignal> Signal_Notify(this GObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GObjectHandleSignalStructs.NotifySignal> obs) =>
		{
			GObjectHandleSignalDelegates.notify handler = ( MentorLake.GObject.GObjectHandle self,  MentorLake.GObject.GParamSpecHandle pspec,  IntPtr user_data) =>
			{
				

				var signalStruct = new GObjectHandleSignalStructs.NotifySignal()
				{
					Self = self, Pspec = pspec, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GObjectHandleSignalStructs
{

public class NotifySignal
{
	public MentorLake.GObject.GObjectHandle Self;
	public MentorLake.GObject.GParamSpecHandle Pspec;
	public IntPtr UserData;
}
}

public static class GObjectHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, IntPtr user_data);

}


public static class GObjectHandleExtensions
{
	public static T AddToggleRef<T>(this T @object, MentorLake.GObject.GToggleNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_add_toggle_ref(@object, notify, data);
		return @object;
	}

	public static T AddWeakPointer<T>(this T @object, ref IntPtr weak_pointer_location) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_add_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

	public static MentorLake.GObject.GBindingHandle BindProperty(this MentorLake.GObject.GObjectHandle source, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_bind_property(source, source_property, target, target_property, flags);
	}

	public static MentorLake.GObject.GBindingHandle BindPropertyFull(this MentorLake.GObject.GObjectHandle source, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GBindingTransformFunc transform_to, MentorLake.GObject.GBindingTransformFunc transform_from, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_bind_property_full(source, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
	}

	public static MentorLake.GObject.GBindingHandle BindPropertyWithClosures(this MentorLake.GObject.GObjectHandle source, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GClosureHandle transform_to, MentorLake.GObject.GClosureHandle transform_from)
	{
		if (source.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_bind_property_with_closures(source, source_property, target, target_property, flags, transform_to, transform_from);
	}

	public static MentorLake.GObject.GObjectHandle Connect(this MentorLake.GObject.GObjectHandle @object, string signal_spec, IntPtr @__arglist)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_connect(@object, signal_spec, @__arglist);
	}

	public static T Disconnect<T>(this T @object, string signal_spec, IntPtr @__arglist) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_disconnect(@object, signal_spec, @__arglist);
		return @object;
	}

	public static IntPtr DupData(this MentorLake.GObject.GObjectHandle @object, string key, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_dup_data(@object, key, dup_func, user_data);
	}

	public static IntPtr DupQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_dup_qdata(@object, quark, dup_func, user_data);
	}

	public static T ForceFloating<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_force_floating(@object);
		return @object;
	}

	public static T FreezeNotify<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_freeze_notify(@object);
		return @object;
	}

	public static T Get<T>(this T @object, string first_property_name, IntPtr @__arglist) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_get(@object, first_property_name, @__arglist);
		return @object;
	}

	public static IntPtr GetData(this MentorLake.GObject.GObjectHandle @object, string key)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_get_data(@object, key);
	}

	public static T GetProperty<T>(this T @object, string property_name, MentorLake.GObject.GValueHandle value) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_get_property(@object, property_name, value);
		return @object;
	}

	public static IntPtr GetQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_get_qdata(@object, quark);
	}

	public static T GetValist<T>(this T @object, string first_property_name, IntPtr var_args) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_get_valist(@object, first_property_name, var_args);
		return @object;
	}

	public static T Getv<T>(this T @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_getv(@object, n_properties, names, values);
		return @object;
	}

	public static bool IsFloating(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_is_floating(@object);
	}

	public static T Notify<T>(this T @object, string property_name) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_notify(@object, property_name);
		return @object;
	}

	public static T NotifyByPspec<T>(this T @object, MentorLake.GObject.GParamSpecHandle pspec) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_notify_by_pspec(@object, pspec);
		return @object;
	}

	public static MentorLake.GObject.GObjectHandle Ref(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_ref(@object);
	}

	public static MentorLake.GObject.GObjectHandle RefSink(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_ref_sink(@object);
	}

	public static T RemoveToggleRef<T>(this T @object, MentorLake.GObject.GToggleNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_remove_toggle_ref(@object, notify, data);
		return @object;
	}

	public static T RemoveWeakPointer<T>(this T @object, ref IntPtr weak_pointer_location) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_remove_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

	public static bool ReplaceData(this MentorLake.GObject.GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_replace_data(@object, key, oldval, newval, destroy, out old_destroy);
	}

	public static bool ReplaceQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_replace_qdata(@object, quark, oldval, newval, destroy, out old_destroy);
	}

	public static T RunDispose<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_run_dispose(@object);
		return @object;
	}

	public static T Set<T>(this T @object, string first_property_name, IntPtr @__arglist) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set(@object, first_property_name, @__arglist);
		return @object;
	}

	public static T SetData<T>(this T @object, string key, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_data(@object, key, data);
		return @object;
	}

	public static T SetDataFull<T>(this T @object, string key, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_data_full(@object, key, data, destroy);
		return @object;
	}

	public static T SetProperty<T>(this T @object, string property_name, MentorLake.GObject.GValueHandle value) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_property(@object, property_name, value);
		return @object;
	}

	public static T SetQdata<T>(this T @object, MentorLake.GLib.GQuark quark, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_qdata(@object, quark, data);
		return @object;
	}

	public static T SetQdataFull<T>(this T @object, MentorLake.GLib.GQuark quark, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_qdata_full(@object, quark, data, destroy);
		return @object;
	}

	public static T SetValist<T>(this T @object, string first_property_name, IntPtr var_args) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_set_valist(@object, first_property_name, var_args);
		return @object;
	}

	public static T Setv<T>(this T @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_setv(@object, n_properties, names, values);
		return @object;
	}

	public static IntPtr StealData(this MentorLake.GObject.GObjectHandle @object, string key)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_steal_data(@object, key);
	}

	public static IntPtr StealQdata(this MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_steal_qdata(@object, quark);
	}

	public static MentorLake.GObject.GObjectHandle TakeRef(this MentorLake.GObject.GObjectHandle @object)
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		return GObjectHandleExterns.g_object_take_ref(@object);
	}

	public static T ThawNotify<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_thaw_notify(@object);
		return @object;
	}

	public static T Unref<T>(this T @object) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_unref(@object);
		return @object;
	}

	public static T WatchClosure<T>(this T @object, MentorLake.GObject.GClosureHandle closure) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_watch_closure(@object, closure);
		return @object;
	}

	public static T WeakRef<T>(this T @object, MentorLake.GObject.GWeakNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_weak_ref(@object, notify, data);
		return @object;
	}

	public static T WeakUnref<T>(this T @object, MentorLake.GObject.GWeakNotify notify, IntPtr data) where T : GObjectHandle
	{
		if (@object.IsInvalid) throw new Exception("Invalid handle (GObjectHandle)");
		GObjectHandleExterns.g_object_weak_unref(@object, notify, data);
		return @object;
	}

}

internal class GObjectHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_new(MentorLake.GObject.GType object_type, string first_property_name, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_new_valist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_new_with_properties(MentorLake.GObject.GType object_type, uint n_properties, string[] names, MentorLake.GObject.GValue[] values);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_add_toggle_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GToggleNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_add_weak_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))]
	internal static extern MentorLake.GObject.GBindingHandle g_object_bind_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))]
	internal static extern MentorLake.GObject.GBindingHandle g_object_bind_property_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GBindingTransformFunc transform_to, MentorLake.GObject.GBindingTransformFunc transform_from, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))]
	internal static extern MentorLake.GObject.GBindingHandle g_object_bind_property_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle transform_to, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle transform_from);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_dup_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_dup_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_force_floating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_freeze_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_get_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr var_args);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_getv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_object_is_floating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_notify_by_pspec([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_ref_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_remove_toggle_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GToggleNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_remove_weak_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_object_replace_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern bool g_object_replace_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_run_dispose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_data_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string property_name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_qdata_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_set_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string first_property_name, IntPtr var_args);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_setv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, uint n_properties, string[] names, MentorLake.GObject.GValue[] values);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_steal_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, string key);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_object_steal_qdata([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GLib.GQuark quark);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_object_take_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_thaw_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_watch_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_weak_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GWeakNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_weak_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, MentorLake.GObject.GWeakNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern UIntPtr g_object_compat_control(UIntPtr what, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_object_interface_find_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, string property_name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_interface_install_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] g_object_interface_list_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface, out uint n_properties_p);

}
