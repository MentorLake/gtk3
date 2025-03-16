namespace MentorLake.Gtk;

public class GtkSwitchHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkSwitchHandle New()
	{
		return GtkSwitchHandleExterns.gtk_switch_new();
	}

}
public static class GtkSwitchHandleSignalExtensions
{

	public static IObservable<GtkSwitchHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkSwitchHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSwitchHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkSwitchHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkSwitchHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSwitchHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
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

	public static IObservable<GtkSwitchHandleSignalStructs.StateSetSignal> Signal_StateSet(this GtkSwitchHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSwitchHandleSignalStructs.StateSetSignal> obs) =>
		{
			GtkSwitchHandleSignalDelegates.state_set handler = ( MentorLake.Gtk.GtkSwitchHandle self,  bool state,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSwitchHandleSignalStructs.StateSetSignal()
				{
					Self = self, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkSwitchHandleSignalStructs
{

public struct ActivateSignal
{
	public MentorLake.Gtk.GtkSwitchHandle Self;
	public IntPtr UserData;
}

public struct StateSetSignal
{
	public MentorLake.Gtk.GtkSwitchHandle Self;
	public bool State;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkSwitchHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool state_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle self, bool state, IntPtr user_data);

}


public static class GtkSwitchHandleExtensions
{
	public static bool GetActive(this MentorLake.Gtk.GtkSwitchHandle sw)
	{
		return GtkSwitchHandleExterns.gtk_switch_get_active(sw);
	}

	public static bool GetState(this MentorLake.Gtk.GtkSwitchHandle sw)
	{
		return GtkSwitchHandleExterns.gtk_switch_get_state(sw);
	}

	public static T SetActive<T>(this T sw, bool is_active) where T : GtkSwitchHandle
	{
		GtkSwitchHandleExterns.gtk_switch_set_active(sw, is_active);
		return sw;
	}

	public static T SetState<T>(this T sw, bool state) where T : GtkSwitchHandle
	{
		GtkSwitchHandleExterns.gtk_switch_set_state(sw, state);
		return sw;
	}

}

internal class GtkSwitchHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSwitchHandle gtk_switch_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_switch_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle sw);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_switch_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle sw);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_switch_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle sw, bool is_active);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_switch_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle sw, bool state);

}
