namespace MentorLake.GObject;

public class GClosureHandle : BaseSafeHandle
{
	public static MentorLake.GObject.GClosureHandle NewObject(uint sizeof_closure, MentorLake.GObject.GObjectHandle @object)
	{
		return GClosureExterns.g_closure_new_object(sizeof_closure, @object);
	}

	public static MentorLake.GObject.GClosureHandle NewSimple(uint sizeof_closure, IntPtr data)
	{
		return GClosureExterns.g_closure_new_simple(sizeof_closure, data);
	}

}


public static class GClosureExtensions
{
	public static void AddFinalizeNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_add_finalize_notifier(closure, notify_data, notify_func);
	}

	public static void AddInvalidateNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_add_invalidate_notifier(closure, notify_data, notify_func);
	}

	public static void AddMarshalGuards(this MentorLake.GObject.GClosureHandle closure, IntPtr pre_marshal_data, MentorLake.GObject.GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, MentorLake.GObject.GClosureNotify post_marshal_notify)
	{
		GClosureExterns.g_closure_add_marshal_guards(closure, pre_marshal_data, pre_marshal_notify, post_marshal_data, post_marshal_notify);
	}

	public static void Invalidate(this MentorLake.GObject.GClosureHandle closure)
	{
		GClosureExterns.g_closure_invalidate(closure);
	}

	public static void Invoke(this MentorLake.GObject.GClosureHandle closure, out MentorLake.GObject.GValue return_value, uint n_param_values, MentorLake.GObject.GValue[] param_values, IntPtr invocation_hint)
	{
		GClosureExterns.g_closure_invoke(closure, out return_value, n_param_values, param_values, invocation_hint);
	}

	public static MentorLake.GObject.GClosureHandle Ref(this MentorLake.GObject.GClosureHandle closure)
	{
		return GClosureExterns.g_closure_ref(closure);
	}

	public static void RemoveFinalizeNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_remove_finalize_notifier(closure, notify_data, notify_func);
	}

	public static void RemoveInvalidateNotifier(this MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_remove_invalidate_notifier(closure, notify_data, notify_func);
	}

	public static void SetMarshal(this MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GClosureMarshal marshal)
	{
		GClosureExterns.g_closure_set_marshal(closure, marshal);
	}

	public static void SetMetaMarshal(this MentorLake.GObject.GClosureHandle closure, IntPtr marshal_data, MentorLake.GObject.GClosureMarshal meta_marshal)
	{
		GClosureExterns.g_closure_set_meta_marshal(closure, marshal_data, meta_marshal);
	}

	public static void Sink(this MentorLake.GObject.GClosureHandle closure)
	{
		GClosureExterns.g_closure_sink(closure);
	}

	public static void Unref(this MentorLake.GObject.GClosureHandle closure)
	{
		GClosureExterns.g_closure_unref(closure);
	}


	public static GClosure Dereference(this GClosureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GClosure>(x.DangerousGetHandle());
}
internal class GClosureExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle g_closure_new_object(uint sizeof_closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle g_closure_new_simple(uint sizeof_closure, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_add_finalize_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_add_invalidate_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_add_marshal_guards([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr pre_marshal_data, MentorLake.GObject.GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, MentorLake.GObject.GClosureNotify post_marshal_notify);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_invalidate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_invoke([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, out MentorLake.GObject.GValue return_value, uint n_param_values, MentorLake.GObject.GValue[] param_values, IntPtr invocation_hint);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GClosureHandle g_closure_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_remove_finalize_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_remove_invalidate_notifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr notify_data, MentorLake.GObject.GClosureNotify notify_func);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_set_marshal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, MentorLake.GObject.GClosureMarshal marshal);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_set_meta_marshal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, IntPtr marshal_data, MentorLake.GObject.GClosureMarshal meta_marshal);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_closure_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

}

public struct GClosure
{
	public uint in_marshal;
	public uint is_invalid;
	public IntPtr marshal;
}
