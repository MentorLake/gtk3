namespace MentorLake.Gtk;

public class GtkToggleToolButtonHandle : GtkToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkToggleToolButtonHandle New()
	{
		return GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_new();
	}

	public static MentorLake.Gtk.GtkToggleToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_new_from_stock(stock_id);
	}

}
public static class GtkToggleToolButtonHandleSignalExtensions
{

	public static IObservable<GtkToggleToolButtonHandleSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleToolButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToggleToolButtonHandleSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleToolButtonHandleSignalDelegates.toggled handler = ( MentorLake.Gtk.GtkToggleToolButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleToolButtonHandleSignalStructs.ToggledSignal()
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

public static class GtkToggleToolButtonHandleSignalStructs
{

public class ToggledSignal
{
	public MentorLake.Gtk.GtkToggleToolButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToggleToolButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))] MentorLake.Gtk.GtkToggleToolButtonHandle self, IntPtr user_data);

}


public static class GtkToggleToolButtonHandleExtensions
{
	public static bool GetActive(this MentorLake.Gtk.GtkToggleToolButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkToggleToolButtonHandle)");
		return GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_get_active(button);
	}

	public static T SetActive<T>(this T button, bool is_active) where T : GtkToggleToolButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkToggleToolButtonHandle)");
		GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_set_active(button, is_active);
		return button;
	}

}

internal class GtkToggleToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToggleToolButtonHandle gtk_toggle_tool_button_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToggleToolButtonHandle gtk_toggle_tool_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_tool_button_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))] MentorLake.Gtk.GtkToggleToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_tool_button_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))] MentorLake.Gtk.GtkToggleToolButtonHandle button, bool is_active);

}
