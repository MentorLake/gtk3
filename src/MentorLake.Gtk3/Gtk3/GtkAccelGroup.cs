namespace MentorLake.Gtk3.Gtk3;

public class GtkAccelGroupHandle : GObjectHandle
{
	public static GtkAccelGroupHandle New()
	{
		return GtkAccelGroupExterns.gtk_accel_group_new();
	}

	public static GtkAccelGroupHandle FromAccelClosure(GClosureHandle closure)
	{
		return GtkAccelGroupExterns.gtk_accel_group_from_accel_closure(closure);
	}

}

public static class GtkAccelGroupSignalExtensions
{

	public static IObservable<GtkAccelGroupSignalStructs.AccelActivateSignal> Signal_AccelActivate(this GtkAccelGroupHandle instance)
	{
		return Observable.Create((IObserver<GtkAccelGroupSignalStructs.AccelActivateSignal> obs) =>
		{
			GtkAccelGroupSignalDelegates.accel_activate handler = (GtkAccelGroupHandle self, GObjectHandle acceleratable, uint keyval, ref GdkModifierType modifier, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelGroupSignalStructs.AccelActivateSignal()
				{
					Self = self, Acceleratable = acceleratable, Keyval = keyval, Modifier = modifier, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accel_activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkAccelGroupSignalStructs.AccelChangedSignal> Signal_AccelChanged(this GtkAccelGroupHandle instance)
	{
		return Observable.Create((IObserver<GtkAccelGroupSignalStructs.AccelChangedSignal> obs) =>
		{
			GtkAccelGroupSignalDelegates.accel_changed handler = (GtkAccelGroupHandle self, uint keyval, ref GdkModifierType modifier, GClosureHandle accel_closure, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelGroupSignalStructs.AccelChangedSignal()
				{
					Self = self, Keyval = keyval, Modifier = modifier, AccelClosure = accel_closure, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accel_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkAccelGroupSignalStructs
{

public struct AccelActivateSignal
{
	public GtkAccelGroupHandle Self;
	public GObjectHandle Acceleratable;
	public uint Keyval;
	public GdkModifierType Modifier;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct AccelChangedSignal
{
	public GtkAccelGroupHandle Self;
	public uint Keyval;
	public GdkModifierType Modifier;
	public GClosureHandle AccelClosure;
	public IntPtr UserData;
}
}

public static class GtkAccelGroupSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accel_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAccelGroupHandle>))] GtkAccelGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle acceleratable, uint keyval, ref GdkModifierType modifier, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAccelGroupHandle>))] GtkAccelGroupHandle self, uint keyval, ref GdkModifierType modifier, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GClosureHandle>))] GClosureHandle accel_closure, IntPtr user_data);

}


public static class GtkAccelGroupHandleExtensions
{
	public static bool Activate(this GtkAccelGroupHandle accel_group, GQuark accel_quark, GObjectHandle acceleratable, uint accel_key, GdkModifierType accel_mods)
	{
		return GtkAccelGroupExterns.gtk_accel_group_activate(accel_group, accel_quark, acceleratable, accel_key, accel_mods);
	}

	public static T Connect<T>(this T accel_group, uint accel_key, GdkModifierType accel_mods, GtkAccelFlags accel_flags, GClosureHandle closure) where T : GtkAccelGroupHandle
	{
		GtkAccelGroupExterns.gtk_accel_group_connect(accel_group, accel_key, accel_mods, accel_flags, closure);
		return accel_group;
	}

	public static T ConnectByPath<T>(this T accel_group, string accel_path, GClosureHandle closure) where T : GtkAccelGroupHandle
	{
		GtkAccelGroupExterns.gtk_accel_group_connect_by_path(accel_group, accel_path, closure);
		return accel_group;
	}

	public static bool Disconnect(this GtkAccelGroupHandle accel_group, GClosureHandle closure)
	{
		return GtkAccelGroupExterns.gtk_accel_group_disconnect(accel_group, closure);
	}

	public static bool DisconnectKey(this GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods)
	{
		return GtkAccelGroupExterns.gtk_accel_group_disconnect_key(accel_group, accel_key, accel_mods);
	}

	public static GtkAccelKeyHandle Find(this GtkAccelGroupHandle accel_group, GtkAccelGroupFindFunc find_func, IntPtr data)
	{
		return GtkAccelGroupExterns.gtk_accel_group_find(accel_group, find_func, data);
	}

	public static bool GetIsLocked(this GtkAccelGroupHandle accel_group)
	{
		return GtkAccelGroupExterns.gtk_accel_group_get_is_locked(accel_group);
	}

	public static GdkModifierType GetModifierMask(this GtkAccelGroupHandle accel_group)
	{
		return GtkAccelGroupExterns.gtk_accel_group_get_modifier_mask(accel_group);
	}

	public static T Lock<T>(this T accel_group) where T : GtkAccelGroupHandle
	{
		GtkAccelGroupExterns.gtk_accel_group_lock(accel_group);
		return accel_group;
	}

	public static IntPtr Query(this GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods, out uint n_entries)
	{
		return GtkAccelGroupExterns.gtk_accel_group_query(accel_group, accel_key, accel_mods, out n_entries);
	}

	public static T Unlock<T>(this T accel_group) where T : GtkAccelGroupHandle
	{
		GtkAccelGroupExterns.gtk_accel_group_unlock(accel_group);
		return accel_group;
	}

}

internal class GtkAccelGroupExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelGroupHandle gtk_accel_group_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_group_activate(GtkAccelGroupHandle accel_group, GQuark accel_quark, GObjectHandle acceleratable, uint accel_key, GdkModifierType accel_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_group_connect(GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods, GtkAccelFlags accel_flags, GClosureHandle closure);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_group_connect_by_path(GtkAccelGroupHandle accel_group, string accel_path, GClosureHandle closure);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_group_disconnect(GtkAccelGroupHandle accel_group, GClosureHandle closure);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_group_disconnect_key(GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelKeyHandle gtk_accel_group_find(GtkAccelGroupHandle accel_group, GtkAccelGroupFindFunc find_func, IntPtr data);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_group_get_is_locked(GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkModifierType gtk_accel_group_get_modifier_mask(GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_group_lock(GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_accel_group_query(GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods, out uint n_entries);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_group_unlock(GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelGroupHandle gtk_accel_group_from_accel_closure(GClosureHandle closure);

}
