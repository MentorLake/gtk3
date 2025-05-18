namespace MentorLake.Gtk;

public class GtkAccelGroupHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkAccelGroupHandle New()
	{
		return GtkAccelGroupHandleExterns.gtk_accel_group_new();
	}

	public static MentorLake.Gtk.GtkAccelGroupHandle FromAccelClosure(MentorLake.GObject.GClosureHandle closure)
	{
		return GtkAccelGroupHandleExterns.gtk_accel_group_from_accel_closure(closure);
	}

}
public static class GtkAccelGroupHandleSignalExtensions
{

	public static IObservable<GtkAccelGroupHandleSignalStructs.AccelActivateSignal> Signal_AccelActivate(this GtkAccelGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAccelGroupHandleSignalStructs.AccelActivateSignal> obs) =>
		{
			GtkAccelGroupHandleSignalDelegates.accel_activate handler = ( MentorLake.Gtk.GtkAccelGroupHandle self,  MentorLake.GObject.GObjectHandle acceleratable,  uint keyval,  MentorLake.Gdk.GdkModifierType modifier,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelGroupHandleSignalStructs.AccelActivateSignal()
				{
					Self = self, Acceleratable = acceleratable, Keyval = keyval, Modifier = modifier, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAccelGroupHandleSignalStructs.AccelChangedSignal> Signal_AccelChanged(this GtkAccelGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAccelGroupHandleSignalStructs.AccelChangedSignal> obs) =>
		{
			GtkAccelGroupHandleSignalDelegates.accel_changed handler = ( MentorLake.Gtk.GtkAccelGroupHandle self,  uint keyval,  MentorLake.Gdk.GdkModifierType modifier,  MentorLake.GObject.GClosureHandle accel_closure,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelGroupHandleSignalStructs.AccelChangedSignal()
				{
					Self = self, Keyval = keyval, Modifier = modifier, AccelClosure = accel_closure, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkAccelGroupHandleSignalStructs
{

public class AccelActivateSignal
{
	public MentorLake.Gtk.GtkAccelGroupHandle Self;
	public MentorLake.GObject.GObjectHandle Acceleratable;
	public uint Keyval;
	public MentorLake.Gdk.GdkModifierType Modifier;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class AccelChangedSignal
{
	public MentorLake.Gtk.GtkAccelGroupHandle Self;
	public uint Keyval;
	public MentorLake.Gdk.GdkModifierType Modifier;
	public MentorLake.GObject.GClosureHandle AccelClosure;
	public IntPtr UserData;
}
}

public static class GtkAccelGroupHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accel_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle acceleratable, uint keyval, MentorLake.Gdk.GdkModifierType modifier, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle self, uint keyval, MentorLake.Gdk.GdkModifierType modifier, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle accel_closure, IntPtr user_data);

}


public static class GtkAccelGroupHandleExtensions
{
	public static bool Activate(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.GLib.GQuark accel_quark, MentorLake.GObject.GObjectHandle acceleratable, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_activate(accel_group, accel_quark, acceleratable, accel_key, accel_mods);
	}

	public static T Connect<T>(this T accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags, MentorLake.GObject.GClosureHandle closure) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_connect(accel_group, accel_key, accel_mods, accel_flags, closure);
		return accel_group;
	}

	public static T ConnectByPath<T>(this T accel_group, string accel_path, MentorLake.GObject.GClosureHandle closure) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_connect_by_path(accel_group, accel_path, closure);
		return accel_group;
	}

	public static bool Disconnect(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.GObject.GClosureHandle closure)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_disconnect(accel_group, closure);
	}

	public static bool DisconnectKey(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_disconnect_key(accel_group, accel_key, accel_mods);
	}

	public static MentorLake.Gtk.GtkAccelKeyHandle Find(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.Gtk.GtkAccelGroupFindFunc find_func, IntPtr data)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_find(accel_group, find_func, data);
	}

	public static bool GetIsLocked(this MentorLake.Gtk.GtkAccelGroupHandle accel_group)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_get_is_locked(accel_group);
	}

	public static MentorLake.Gdk.GdkModifierType GetModifierMask(this MentorLake.Gtk.GtkAccelGroupHandle accel_group)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_get_modifier_mask(accel_group);
	}

	public static T Lock<T>(this T accel_group) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_lock(accel_group);
		return accel_group;
	}

	public static MentorLake.Gtk.GtkAccelGroupEntry[] Query(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, out uint n_entries)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_query(accel_group, accel_key, accel_mods, out n_entries);
	}

	public static T Unlock<T>(this T accel_group) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_unlock(accel_group);
		return accel_group;
	}

}

internal class GtkAccelGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_accel_group_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.GLib.GQuark accel_quark, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle acceleratable, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_connect_by_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, string accel_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_disconnect_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelKeyHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelKeyHandle gtk_accel_group_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.Gtk.GtkAccelGroupFindFunc find_func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_get_is_locked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gtk_accel_group_get_modifier_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAccelGroupEntry[] gtk_accel_group_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, out uint n_entries);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_accel_group_from_accel_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

}
