namespace MentorLake.Gtk3.GObject;

public class GObjectHandle : GTypeInstanceHandle
{
	public static GObjectHandle New(GType object_type, string first_property_name, IntPtr @__arglist)
	{
		return GObjectExterns.g_object_new(object_type, first_property_name, @__arglist);
	}

	public static GObjectHandle NewValist(GType object_type, string first_property_name, IntPtr var_args)
	{
		return GObjectExterns.g_object_new_valist(object_type, first_property_name, var_args);
	}

	public static GObjectHandle NewWithProperties(GType object_type, uint n_properties, string[] names, GValue[] values)
	{
		return GObjectExterns.g_object_new_with_properties(object_type, n_properties, names, values);
	}

	public static GObjectHandle Newv(GType object_type, uint n_parameters, GParameter[] parameters)
	{
		return GObjectExterns.g_object_newv(object_type, n_parameters, parameters);
	}

	public static UIntPtr CompatControl(UIntPtr what, IntPtr data)
	{
		return GObjectExterns.g_object_compat_control(what, data);
	}

	public static GParamSpecHandle InterfaceFindProperty(GTypeInterfaceHandle g_iface, string property_name)
	{
		return GObjectExterns.g_object_interface_find_property(g_iface, property_name);
	}

	public static void InterfaceInstallProperty(GTypeInterfaceHandle g_iface, GParamSpecHandle pspec)
	{
		GObjectExterns.g_object_interface_install_property(g_iface, pspec);
	}

	public static IntPtr InterfaceListProperties(GTypeInterfaceHandle g_iface, out uint n_properties_p)
	{
		return GObjectExterns.g_object_interface_list_properties(g_iface, out n_properties_p);
	}

}

public static class GObjectSignalExtensions
{

	public static IObservable<GObjectSignalStructs.NotifySignal> Signal_Notify(this GObjectHandle instance)
	{
		return Observable.Create((IObserver<GObjectSignalStructs.NotifySignal> obs) =>
		{
			GObjectSignalDelegates.notify handler = (GObjectHandle self, GParamSpecHandle pspec, IntPtr user_data) =>
			{
				

				var signalStruct = new GObjectSignalStructs.NotifySignal()
				{
					Self = self, Pspec = pspec, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GObjectSignalStructs
{

public struct NotifySignal
{
	public GObjectHandle Self;
	public GParamSpecHandle Pspec;
	public IntPtr UserData;
}
}

public static class GObjectSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GParamSpecHandle>))] GParamSpecHandle pspec, IntPtr user_data);

}


public static class GObjectHandleExtensions
{
	public static T AddToggleRef<T>(this T @object, GToggleNotify notify, IntPtr data) where T : GObjectHandle
	{
		GObjectExterns.g_object_add_toggle_ref(@object, notify, data);
		return @object;
	}

	public static T AddWeakPointer<T>(this T @object, ref IntPtr weak_pointer_location) where T : GObjectHandle
	{
		GObjectExterns.g_object_add_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

	public static GBindingHandle BindProperty(this GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags)
	{
		return GObjectExterns.g_object_bind_property(source, source_property, target, target_property, flags);
	}

	public static GBindingHandle BindPropertyFull(this GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify notify)
	{
		return GObjectExterns.g_object_bind_property_full(source, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
	}

	public static GBindingHandle BindPropertyWithClosures(this GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from)
	{
		return GObjectExterns.g_object_bind_property_with_closures(source, source_property, target, target_property, flags, transform_to, transform_from);
	}

	public static GObjectHandle Connect(this GObjectHandle @object, string signal_spec, IntPtr @__arglist)
	{
		return GObjectExterns.g_object_connect(@object, signal_spec, @__arglist);
	}

	public static T Disconnect<T>(this T @object, string signal_spec, IntPtr @__arglist) where T : GObjectHandle
	{
		GObjectExterns.g_object_disconnect(@object, signal_spec, @__arglist);
		return @object;
	}

	public static IntPtr DupData(this GObjectHandle @object, string key, GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GObjectExterns.g_object_dup_data(@object, key, dup_func, user_data);
	}

	public static IntPtr DupQdata(this GObjectHandle @object, GQuark quark, GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GObjectExterns.g_object_dup_qdata(@object, quark, dup_func, user_data);
	}

	public static T ForceFloating<T>(this T @object) where T : GObjectHandle
	{
		GObjectExterns.g_object_force_floating(@object);
		return @object;
	}

	public static T FreezeNotify<T>(this T @object) where T : GObjectHandle
	{
		GObjectExterns.g_object_freeze_notify(@object);
		return @object;
	}

	public static T Get<T>(this T @object, string first_property_name, IntPtr @__arglist) where T : GObjectHandle
	{
		GObjectExterns.g_object_get(@object, first_property_name, @__arglist);
		return @object;
	}

	public static IntPtr GetData(this GObjectHandle @object, string key)
	{
		return GObjectExterns.g_object_get_data(@object, key);
	}

	public static T GetProperty<T>(this T @object, string property_name, out GValue value) where T : GObjectHandle
	{
		GObjectExterns.g_object_get_property(@object, property_name, out value);
		return @object;
	}

	public static IntPtr GetQdata(this GObjectHandle @object, GQuark quark)
	{
		return GObjectExterns.g_object_get_qdata(@object, quark);
	}

	public static T GetValist<T>(this T @object, string first_property_name, out IntPtr var_args) where T : GObjectHandle
	{
		GObjectExterns.g_object_get_valist(@object, first_property_name, out var_args);
		return @object;
	}

	public static T Getv<T>(this T @object, uint n_properties, string[] names, GValue[] values) where T : GObjectHandle
	{
		GObjectExterns.g_object_getv(@object, n_properties, names, values);
		return @object;
	}

	public static bool IsFloating(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_is_floating(@object);
	}

	public static T Notify<T>(this T @object, string property_name) where T : GObjectHandle
	{
		GObjectExterns.g_object_notify(@object, property_name);
		return @object;
	}

	public static T NotifyByPspec<T>(this T @object, GParamSpecHandle pspec) where T : GObjectHandle
	{
		GObjectExterns.g_object_notify_by_pspec(@object, pspec);
		return @object;
	}

	public static GObjectHandle Ref(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_ref(@object);
	}

	public static GObjectHandle RefSink(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_ref_sink(@object);
	}

	public static T RemoveToggleRef<T>(this T @object, GToggleNotify notify, IntPtr data) where T : GObjectHandle
	{
		GObjectExterns.g_object_remove_toggle_ref(@object, notify, data);
		return @object;
	}

	public static T RemoveWeakPointer<T>(this T @object, ref IntPtr weak_pointer_location) where T : GObjectHandle
	{
		GObjectExterns.g_object_remove_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

	public static bool ReplaceData(this GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy)
	{
		return GObjectExterns.g_object_replace_data(@object, key, oldval, newval, destroy, out old_destroy);
	}

	public static bool ReplaceQdata(this GObjectHandle @object, GQuark quark, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy)
	{
		return GObjectExterns.g_object_replace_qdata(@object, quark, oldval, newval, destroy, out old_destroy);
	}

	public static T RunDispose<T>(this T @object) where T : GObjectHandle
	{
		GObjectExterns.g_object_run_dispose(@object);
		return @object;
	}

	public static T Set<T>(this T @object, string first_property_name, IntPtr @__arglist) where T : GObjectHandle
	{
		GObjectExterns.g_object_set(@object, first_property_name, @__arglist);
		return @object;
	}

	public static T SetData<T>(this T @object, string key, IntPtr data) where T : GObjectHandle
	{
		GObjectExterns.g_object_set_data(@object, key, data);
		return @object;
	}

	public static T SetDataFull<T>(this T @object, string key, IntPtr data, GDestroyNotify destroy) where T : GObjectHandle
	{
		GObjectExterns.g_object_set_data_full(@object, key, data, destroy);
		return @object;
	}

	public static T SetProperty<T>(this T @object, string property_name, GValueHandle value) where T : GObjectHandle
	{
		GObjectExterns.g_object_set_property(@object, property_name, value);
		return @object;
	}

	public static T SetQdata<T>(this T @object, GQuark quark, IntPtr data) where T : GObjectHandle
	{
		GObjectExterns.g_object_set_qdata(@object, quark, data);
		return @object;
	}

	public static T SetQdataFull<T>(this T @object, GQuark quark, IntPtr data, GDestroyNotify destroy) where T : GObjectHandle
	{
		GObjectExterns.g_object_set_qdata_full(@object, quark, data, destroy);
		return @object;
	}

	public static T SetValist<T>(this T @object, string first_property_name, IntPtr var_args) where T : GObjectHandle
	{
		GObjectExterns.g_object_set_valist(@object, first_property_name, var_args);
		return @object;
	}

	public static T Setv<T>(this T @object, uint n_properties, string[] names, GValue[] values) where T : GObjectHandle
	{
		GObjectExterns.g_object_setv(@object, n_properties, names, values);
		return @object;
	}

	public static IntPtr StealData(this GObjectHandle @object, string key)
	{
		return GObjectExterns.g_object_steal_data(@object, key);
	}

	public static IntPtr StealQdata(this GObjectHandle @object, GQuark quark)
	{
		return GObjectExterns.g_object_steal_qdata(@object, quark);
	}

	public static GObjectHandle TakeRef(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_take_ref(@object);
	}

	public static T ThawNotify<T>(this T @object) where T : GObjectHandle
	{
		GObjectExterns.g_object_thaw_notify(@object);
		return @object;
	}

	public static T Unref<T>(this T @object) where T : GObjectHandle
	{
		GObjectExterns.g_object_unref(@object);
		return @object;
	}

	public static T WatchClosure<T>(this T @object, GClosureHandle closure) where T : GObjectHandle
	{
		GObjectExterns.g_object_watch_closure(@object, closure);
		return @object;
	}

	public static T WeakRef<T>(this T @object, GWeakNotify notify, IntPtr data) where T : GObjectHandle
	{
		GObjectExterns.g_object_weak_ref(@object, notify, data);
		return @object;
	}

	public static T WeakUnref<T>(this T @object, GWeakNotify notify, IntPtr data) where T : GObjectHandle
	{
		GObjectExterns.g_object_weak_unref(@object, notify, data);
		return @object;
	}

	public static T GSignalStopEmissionByName<T>(this T instance, string detailed_signal) where T : GObjectHandle
	{
		GObjectExterns.g_signal_stop_emission_by_name(instance, detailed_signal);
		return instance;
	}

	public static ulong GSignalHandlerFind(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handler_find(instance, mask, signal_id, detail, closure, func, data);
	}

	public static uint GSignalHandlersUnblockMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_unblock_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static T GSignalEmitByName<T>(this T instance, string detailed_signal, IntPtr @__arglist) where T : GObjectHandle
	{
		GObjectExterns.g_signal_emit_by_name(instance, detailed_signal, @__arglist);
		return instance;
	}

	public static T GSignalHandlersDestroy<T>(this T instance) where T : GObjectHandle
	{
		GObjectExterns.g_signal_handlers_destroy(instance);
		return instance;
	}

	public static bool GSignalHasHandlerPending(this GObjectHandle instance, uint signal_id, GQuark detail, bool may_be_blocked)
	{
		return GObjectExterns.g_signal_has_handler_pending(instance, signal_id, detail, may_be_blocked);
	}

	public static ulong GSignalConnectClosureById(this GObjectHandle instance, uint signal_id, GQuark detail, GClosureHandle closure, bool after)
	{
		return GObjectExterns.g_signal_connect_closure_by_id(instance, signal_id, detail, closure, after);
	}

	public static T GSignalEmit<T>(this T instance, uint signal_id, GQuark detail, IntPtr @__arglist) where T : GObjectHandle
	{
		GObjectExterns.g_signal_emit(instance, signal_id, detail, @__arglist);
		return instance;
	}

	public static uint GSignalHandlersDisconnectMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_disconnect_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static T GSignalHandlerUnblock<T>(this T instance, ulong handler_id) where T : GObjectHandle
	{
		GObjectExterns.g_signal_handler_unblock(instance, handler_id);
		return instance;
	}

	public static bool GSignalHandlerIsConnected(this GObjectHandle instance, ulong handler_id)
	{
		return GObjectExterns.g_signal_handler_is_connected(instance, handler_id);
	}

	public static ulong GSignalConnectData(this GObjectHandle instance, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify destroy_data, GConnectFlags connect_flags)
	{
		return GObjectExterns.g_signal_connect_data(instance, detailed_signal, c_handler, data, destroy_data, connect_flags);
	}

	public static GSignalInvocationHintHandle GSignalGetInvocationHint(this GObjectHandle instance)
	{
		return GObjectExterns.g_signal_get_invocation_hint(instance);
	}

	public static T GSignalHandlerBlock<T>(this T instance, ulong handler_id) where T : GObjectHandle
	{
		GObjectExterns.g_signal_handler_block(instance, handler_id);
		return instance;
	}

	public static T GSignalHandlerDisconnect<T>(this T instance, ulong handler_id) where T : GObjectHandle
	{
		GObjectExterns.g_signal_handler_disconnect(instance, handler_id);
		return instance;
	}

	public static uint GSignalHandlersBlockMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_block_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static ulong GSignalConnectClosure(this GObjectHandle instance, string detailed_signal, GClosureHandle closure, bool after)
	{
		return GObjectExterns.g_signal_connect_closure(instance, detailed_signal, closure, after);
	}

	public static T GSignalStopEmission<T>(this T instance, uint signal_id, GQuark detail) where T : GObjectHandle
	{
		GObjectExterns.g_signal_stop_emission(instance, signal_id, detail);
		return instance;
	}

}

internal class GObjectExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_new(GType object_type, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_new_valist(GType object_type, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_new_with_properties(GType object_type, uint n_properties, string[] names, GValue[] values);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_newv(GType object_type, uint n_parameters, GParameter[] parameters);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_add_toggle_ref(GObjectHandle @object, GToggleNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_add_weak_pointer(GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(Libraries.GObject)]
	internal static extern GBindingHandle g_object_bind_property(GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GBindingHandle g_object_bind_property_full(GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.GObject)]
	internal static extern GBindingHandle g_object_bind_property_with_closures(GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_connect(GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_disconnect(GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_dup_data(GObjectHandle @object, string key, GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_dup_qdata(GObjectHandle @object, GQuark quark, GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_force_floating(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_freeze_notify(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_get(GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_get_data(GObjectHandle @object, string key);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_get_property(GObjectHandle @object, string property_name, out GValue value);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_get_qdata(GObjectHandle @object, GQuark quark);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_get_valist(GObjectHandle @object, string first_property_name, out IntPtr var_args);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_getv(GObjectHandle @object, uint n_properties, string[] names, GValue[] values);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_object_is_floating(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_notify(GObjectHandle @object, string property_name);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_notify_by_pspec(GObjectHandle @object, GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_ref(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_ref_sink(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_remove_toggle_ref(GObjectHandle @object, GToggleNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_remove_weak_pointer(GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_object_replace_data(GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_object_replace_qdata(GObjectHandle @object, GQuark quark, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_run_dispose(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set(GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_data(GObjectHandle @object, string key, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_data_full(GObjectHandle @object, string key, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_property(GObjectHandle @object, string property_name, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_qdata(GObjectHandle @object, GQuark quark, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_qdata_full(GObjectHandle @object, GQuark quark, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_valist(GObjectHandle @object, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_setv(GObjectHandle @object, uint n_properties, string[] names, GValue[] values);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_steal_data(GObjectHandle @object, string key);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_steal_qdata(GObjectHandle @object, GQuark quark);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_take_ref(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_thaw_notify(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_unref(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_watch_closure(GObjectHandle @object, GClosureHandle closure);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_weak_ref(GObjectHandle @object, GWeakNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_weak_unref(GObjectHandle @object, GWeakNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_stop_emission_by_name(GObjectHandle instance, string detailed_signal);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_handler_find(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_handlers_unblock_matched(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_emit_by_name(GObjectHandle instance, string detailed_signal, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handlers_destroy(GObjectHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_has_handler_pending(GObjectHandle instance, uint signal_id, GQuark detail, bool may_be_blocked);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_connect_closure_by_id(GObjectHandle instance, uint signal_id, GQuark detail, GClosureHandle closure, bool after);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_emit(GObjectHandle instance, uint signal_id, GQuark detail, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_handlers_disconnect_matched(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handler_unblock(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_handler_is_connected(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_connect_data(GObjectHandle instance, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify destroy_data, GConnectFlags connect_flags);

	[DllImport(Libraries.GObject)]
	internal static extern GSignalInvocationHintHandle g_signal_get_invocation_hint(GObjectHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handler_block(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handler_disconnect(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_handlers_block_matched(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_connect_closure(GObjectHandle instance, string detailed_signal, GClosureHandle closure, bool after);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_stop_emission(GObjectHandle instance, uint signal_id, GQuark detail);

	[DllImport(Libraries.GObject)]
	internal static extern UIntPtr g_object_compat_control(UIntPtr what, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_object_interface_find_property(GTypeInterfaceHandle g_iface, string property_name);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_interface_install_property(GTypeInterfaceHandle g_iface, GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_interface_list_properties(GTypeInterfaceHandle g_iface, out uint n_properties_p);

}
