namespace MentorLake.Gio;

public class GSimpleActionHandle : GObjectHandle, GActionHandle
{
	public static MentorLake.Gio.GSimpleActionHandle New(string name, MentorLake.GLib.GVariantTypeHandle parameter_type)
	{
		return GSimpleActionHandleExterns.g_simple_action_new(name, parameter_type);
	}

	public static MentorLake.Gio.GSimpleActionHandle NewStateful(string name, MentorLake.GLib.GVariantTypeHandle parameter_type, MentorLake.GLib.GVariantHandle state)
	{
		return GSimpleActionHandleExterns.g_simple_action_new_stateful(name, parameter_type, state);
	}

}
public static class GSimpleActionHandleSignalExtensions
{

	public static IObservable<GSimpleActionHandleSignalStructs.ActivateSignal> Signal_Activate(this GSimpleActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSimpleActionHandleSignalStructs.ActivateSignal> obs) =>
		{
			GSimpleActionHandleSignalDelegates.activate handler = ( MentorLake.Gio.GSimpleActionHandle self,  MentorLake.GLib.GVariantHandle parameter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionHandleSignalStructs.ActivateSignal()
				{
					Self = self, Parameter = parameter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GSimpleActionHandleSignalStructs.ChangeStateSignal> Signal_ChangeState(this GSimpleActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GSimpleActionHandleSignalStructs.ChangeStateSignal> obs) =>
		{
			GSimpleActionHandleSignalDelegates.change_state handler = ( MentorLake.Gio.GSimpleActionHandle self,  MentorLake.GLib.GVariantHandle value,  IntPtr user_data) =>
			{
				

				var signalStruct = new GSimpleActionHandleSignalStructs.ChangeStateSignal()
				{
					Self = self, Value = value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "change-state", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GSimpleActionHandleSignalStructs
{

public class ActivateSignal
{
	public MentorLake.Gio.GSimpleActionHandle Self;
	public MentorLake.GLib.GVariantHandle Parameter;
	public IntPtr UserData;
}

public class ChangeStateSignal
{
	public MentorLake.Gio.GSimpleActionHandle Self;
	public MentorLake.GLib.GVariantHandle Value;
	public IntPtr UserData;
}
}

public static class GSimpleActionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))] MentorLake.Gio.GSimpleActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void change_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))] MentorLake.Gio.GSimpleActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GSimpleActionHandleExtensions
{
	public static T SetEnabled<T>(this T simple, bool enabled) where T : GSimpleActionHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionHandle)");
		GSimpleActionHandleExterns.g_simple_action_set_enabled(simple, enabled);
		return simple;
	}

	public static T SetState<T>(this T simple, MentorLake.GLib.GVariantHandle value) where T : GSimpleActionHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionHandle)");
		GSimpleActionHandleExterns.g_simple_action_set_state(simple, value);
		return simple;
	}

	public static T SetStateHint<T>(this T simple, MentorLake.GLib.GVariantHandle state_hint) where T : GSimpleActionHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionHandle)");
		GSimpleActionHandleExterns.g_simple_action_set_state_hint(simple, state_hint);
		return simple;
	}

}

internal class GSimpleActionHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))]
	internal static extern MentorLake.Gio.GSimpleActionHandle g_simple_action_new(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle parameter_type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))]
	internal static extern MentorLake.Gio.GSimpleActionHandle g_simple_action_new_stateful(string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle parameter_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle state);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_set_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))] MentorLake.Gio.GSimpleActionHandle simple, bool enabled);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))] MentorLake.Gio.GSimpleActionHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_action_set_state_hint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))] MentorLake.Gio.GSimpleActionHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle state_hint);

}
