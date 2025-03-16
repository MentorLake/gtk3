namespace MentorLake.Gtk;

public class GtkToggleActionHandle : GtkActionHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkToggleActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkToggleActionHandleExterns.gtk_toggle_action_new(name, label, tooltip, stock_id);
	}

}
public static class GtkToggleActionHandleSignalExtensions
{

	public static IObservable<GtkToggleActionHandleSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToggleActionHandleSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleActionHandleSignalDelegates.toggled handler = ( MentorLake.Gtk.GtkToggleActionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleActionHandleSignalStructs.ToggledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkToggleActionHandleSignalStructs
{

public struct ToggledSignal
{
	public MentorLake.Gtk.GtkToggleActionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToggleActionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))] MentorLake.Gtk.GtkToggleActionHandle self, IntPtr user_data);

}


public static class GtkToggleActionHandleExtensions
{
	public static bool GetActive(this MentorLake.Gtk.GtkToggleActionHandle action)
	{
		return GtkToggleActionHandleExterns.gtk_toggle_action_get_active(action);
	}

	public static bool GetDrawAsRadio(this MentorLake.Gtk.GtkToggleActionHandle action)
	{
		return GtkToggleActionHandleExterns.gtk_toggle_action_get_draw_as_radio(action);
	}

	public static T SetActive<T>(this T action, bool is_active) where T : GtkToggleActionHandle
	{
		GtkToggleActionHandleExterns.gtk_toggle_action_set_active(action, is_active);
		return action;
	}

	public static T SetDrawAsRadio<T>(this T action, bool draw_as_radio) where T : GtkToggleActionHandle
	{
		GtkToggleActionHandleExterns.gtk_toggle_action_set_draw_as_radio(action, draw_as_radio);
		return action;
	}

	public static T Toggled<T>(this T action) where T : GtkToggleActionHandle
	{
		GtkToggleActionHandleExterns.gtk_toggle_action_toggled(action);
		return action;
	}

}

internal class GtkToggleActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToggleActionHandle gtk_toggle_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_action_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))] MentorLake.Gtk.GtkToggleActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_action_get_draw_as_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))] MentorLake.Gtk.GtkToggleActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_action_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))] MentorLake.Gtk.GtkToggleActionHandle action, bool is_active);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_action_set_draw_as_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))] MentorLake.Gtk.GtkToggleActionHandle action, bool draw_as_radio);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_action_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))] MentorLake.Gtk.GtkToggleActionHandle action);

}
