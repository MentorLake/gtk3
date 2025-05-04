namespace MentorLake.Gtk;

public class GtkButtonHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkButtonHandle New()
	{
		return GtkButtonHandleExterns.gtk_button_new();
	}

	public static MentorLake.Gtk.GtkButtonHandle NewFromIconName(string icon_name, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkButtonHandleExterns.gtk_button_new_from_icon_name(icon_name, size);
	}

	public static MentorLake.Gtk.GtkButtonHandle NewFromStock(string stock_id)
	{
		return GtkButtonHandleExterns.gtk_button_new_from_stock(stock_id);
	}

	public static MentorLake.Gtk.GtkButtonHandle NewWithLabel(string label)
	{
		return GtkButtonHandleExterns.gtk_button_new_with_label(label);
	}

	public static MentorLake.Gtk.GtkButtonHandle NewWithMnemonic(string label)
	{
		return GtkButtonHandleExterns.gtk_button_new_with_mnemonic(label);
	}

}
public static class GtkButtonHandleSignalExtensions
{

	public static IObservable<GtkButtonHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkButtonHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkButtonHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonHandleSignalStructs.ActivateSignal()
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

	public static IObservable<GtkButtonHandleSignalStructs.ClickedSignal> Signal_Clicked(this GtkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkButtonHandleSignalStructs.ClickedSignal> obs) =>
		{
			GtkButtonHandleSignalDelegates.clicked handler = ( MentorLake.Gtk.GtkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonHandleSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkButtonHandleSignalStructs.EnterSignal> Signal_Enter(this GtkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkButtonHandleSignalStructs.EnterSignal> obs) =>
		{
			GtkButtonHandleSignalDelegates.enter handler = ( MentorLake.Gtk.GtkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonHandleSignalStructs.EnterSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkButtonHandleSignalStructs.LeaveSignal> Signal_Leave(this GtkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkButtonHandleSignalStructs.LeaveSignal> obs) =>
		{
			GtkButtonHandleSignalDelegates.leave handler = ( MentorLake.Gtk.GtkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonHandleSignalStructs.LeaveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkButtonHandleSignalStructs.PressedSignal> Signal_Pressed(this GtkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkButtonHandleSignalStructs.PressedSignal> obs) =>
		{
			GtkButtonHandleSignalDelegates.pressed handler = ( MentorLake.Gtk.GtkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonHandleSignalStructs.PressedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkButtonHandleSignalStructs.ReleasedSignal> Signal_Released(this GtkButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkButtonHandleSignalStructs.ReleasedSignal> obs) =>
		{
			GtkButtonHandleSignalDelegates.released handler = ( MentorLake.Gtk.GtkButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkButtonHandleSignalStructs.ReleasedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkButtonHandleSignalStructs
{

public class ActivateSignal
{
	public MentorLake.Gtk.GtkButtonHandle Self;
	public IntPtr UserData;
}

public class ClickedSignal
{
	public MentorLake.Gtk.GtkButtonHandle Self;
	public IntPtr UserData;
}

public class EnterSignal
{
	public MentorLake.Gtk.GtkButtonHandle Self;
	public IntPtr UserData;
}

public class LeaveSignal
{
	public MentorLake.Gtk.GtkButtonHandle Self;
	public IntPtr UserData;
}

public class PressedSignal
{
	public MentorLake.Gtk.GtkButtonHandle Self;
	public IntPtr UserData;
}

public class ReleasedSignal
{
	public MentorLake.Gtk.GtkButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);

}


public static class GtkButtonHandleExtensions
{
	public static T Clicked<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_clicked(button);
		return button;
	}

	public static T Enter<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_enter(button);
		return button;
	}

	public static T GetAlignment<T>(this T button, out float xalign, out float yalign) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_get_alignment(button, out xalign, out yalign);
		return button;
	}

	public static bool GetAlwaysShowImage(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_always_show_image(button);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetEventWindow(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_event_window(button);
	}

	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_focus_on_click(button);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetImage(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_image(button);
	}

	public static MentorLake.Gtk.GtkPositionType GetImagePosition(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_image_position(button);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_label(button);
	}

	public static MentorLake.Gtk.GtkReliefStyle GetRelief(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_relief(button);
	}

	public static bool GetUseStock(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_use_stock(button);
	}

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_use_underline(button);
	}

	public static T Leave<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_leave(button);
		return button;
	}

	public static T Pressed<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_pressed(button);
		return button;
	}

	public static T Released<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_released(button);
		return button;
	}

	public static T SetAlignment<T>(this T button, float xalign, float yalign) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_alignment(button, xalign, yalign);
		return button;
	}

	public static T SetAlwaysShowImage<T>(this T button, bool always_show) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_always_show_image(button, always_show);
		return button;
	}

	public static T SetFocusOnClick<T>(this T button, bool focus_on_click) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_focus_on_click(button, focus_on_click);
		return button;
	}

	public static T SetImage<T>(this T button, MentorLake.Gtk.GtkWidgetHandle image) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_image(button, image);
		return button;
	}

	public static T SetImagePosition<T>(this T button, MentorLake.Gtk.GtkPositionType position) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_image_position(button, position);
		return button;
	}

	public static T SetLabel<T>(this T button, string label) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_label(button, label);
		return button;
	}

	public static T SetRelief<T>(this T button, MentorLake.Gtk.GtkReliefStyle relief) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_relief(button, relief);
		return button;
	}

	public static T SetUseStock<T>(this T button, bool use_stock) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_use_stock(button, use_stock);
		return button;
	}

	public static T SetUseUnderline<T>(this T button, bool use_underline) where T : GtkButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_use_underline(button, use_underline);
		return button;
	}

}

internal class GtkButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new_from_icon_name(string icon_name, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, out float xalign, out float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_get_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_button_get_event_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_button_get_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_button_get_image_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_button_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkReliefStyle gtk_button_get_relief([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_get_use_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, float xalign, float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_always_show_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, bool always_show);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, bool focus_on_click);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_image([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle image);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_image_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, MentorLake.Gtk.GtkPositionType position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_relief([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, MentorLake.Gtk.GtkReliefStyle relief);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_use_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, bool use_stock);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_button_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button, bool use_underline);

}
