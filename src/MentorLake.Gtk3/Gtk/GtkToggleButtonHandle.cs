namespace MentorLake.Gtk;

public class GtkToggleButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkToggleButtonHandle New()
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_new();
	}

	public static MentorLake.Gtk.GtkToggleButtonHandle NewWithLabel(string label)
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_new_with_label(label);
	}

	public static MentorLake.Gtk.GtkToggleButtonHandle NewWithMnemonic(string label)
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_new_with_mnemonic(label);
	}

}
public static class GtkToggleButtonHandleSignalExtensions
{

	public static IObservable<GtkToggleButtonHandleSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToggleButtonHandleSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleButtonHandleSignalDelegates.toggled handler = ( MentorLake.Gtk.GtkToggleButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleButtonHandleSignalStructs.ToggledSignal()
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

public static class GtkToggleButtonHandleSignalStructs
{

public struct ToggledSignal
{
	public MentorLake.Gtk.GtkToggleButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToggleButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle self, IntPtr user_data);

}


public static class GtkToggleButtonHandleExtensions
{
	public static bool GetActive(this MentorLake.Gtk.GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_get_active(toggle_button);
	}

	public static bool GetInconsistent(this MentorLake.Gtk.GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_get_inconsistent(toggle_button);
	}

	public static bool GetMode(this MentorLake.Gtk.GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_get_mode(toggle_button);
	}

	public static T SetActive<T>(this T toggle_button, bool is_active) where T : GtkToggleButtonHandle
	{
		GtkToggleButtonHandleExterns.gtk_toggle_button_set_active(toggle_button, is_active);
		return toggle_button;
	}

	public static T SetInconsistent<T>(this T toggle_button, bool setting) where T : GtkToggleButtonHandle
	{
		GtkToggleButtonHandleExterns.gtk_toggle_button_set_inconsistent(toggle_button, setting);
		return toggle_button;
	}

	public static T SetMode<T>(this T toggle_button, bool draw_indicator) where T : GtkToggleButtonHandle
	{
		GtkToggleButtonHandleExterns.gtk_toggle_button_set_mode(toggle_button, draw_indicator);
		return toggle_button;
	}

	public static T Toggled<T>(this T toggle_button) where T : GtkToggleButtonHandle
	{
		GtkToggleButtonHandleExterns.gtk_toggle_button_toggled(toggle_button);
		return toggle_button;
	}

}

internal class GtkToggleButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToggleButtonHandle gtk_toggle_button_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToggleButtonHandle gtk_toggle_button_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkToggleButtonHandle gtk_toggle_button_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_button_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_button_get_inconsistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_button_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button, bool is_active);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_set_inconsistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button, bool draw_indicator);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

}
