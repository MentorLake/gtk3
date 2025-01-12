namespace MentorLake.Gtk3.Gtk3;

public class GtkEventControllerKeyHandle : GtkEventControllerHandle
{
	public static GtkEventControllerKeyHandle New(GtkWidgetHandle widget)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_new(widget);
	}

}

public static class GtkEventControllerKeySignalExtensions
{

	public static IObservable<GtkEventControllerKeySignalStructs.FocusInSignal> Signal_FocusIn(this GtkEventControllerKeyHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerKeySignalStructs.FocusInSignal> obs) =>
		{
			GtkEventControllerKeySignalDelegates.focus_in handler = (GtkEventControllerKeyHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeySignalStructs.FocusInSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_in", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerKeySignalStructs.FocusOutSignal> Signal_FocusOut(this GtkEventControllerKeyHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerKeySignalStructs.FocusOutSignal> obs) =>
		{
			GtkEventControllerKeySignalDelegates.focus_out handler = (GtkEventControllerKeyHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeySignalStructs.FocusOutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerKeySignalStructs.ImUpdateSignal> Signal_ImUpdate(this GtkEventControllerKeyHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerKeySignalStructs.ImUpdateSignal> obs) =>
		{
			GtkEventControllerKeySignalDelegates.im_update handler = (GtkEventControllerKeyHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeySignalStructs.ImUpdateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "im_update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerKeySignalStructs.KeyPressedSignal> Signal_KeyPressed(this GtkEventControllerKeyHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerKeySignalStructs.KeyPressedSignal> obs) =>
		{
			GtkEventControllerKeySignalDelegates.key_pressed handler = (GtkEventControllerKeyHandle self, uint keyval, uint keycode, ref GdkModifierType state, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeySignalStructs.KeyPressedSignal()
				{
					Self = self, Keyval = keyval, Keycode = keycode, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "key_pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerKeySignalStructs.KeyReleasedSignal> Signal_KeyReleased(this GtkEventControllerKeyHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerKeySignalStructs.KeyReleasedSignal> obs) =>
		{
			GtkEventControllerKeySignalDelegates.key_released handler = (GtkEventControllerKeyHandle self, uint keyval, uint keycode, ref GdkModifierType state, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeySignalStructs.KeyReleasedSignal()
				{
					Self = self, Keyval = keyval, Keycode = keycode, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "key_released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEventControllerKeySignalStructs.ModifiersSignal> Signal_Modifiers(this GtkEventControllerKeyHandle instance)
	{
		return Observable.Create((IObserver<GtkEventControllerKeySignalStructs.ModifiersSignal> obs) =>
		{
			GtkEventControllerKeySignalDelegates.modifiers handler = (GtkEventControllerKeyHandle self, ref GdkModifierType @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeySignalStructs.ModifiersSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "modifiers", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEventControllerKeySignalStructs
{

public struct FocusInSignal
{
	public GtkEventControllerKeyHandle Self;
	public IntPtr UserData;
}

public struct FocusOutSignal
{
	public GtkEventControllerKeyHandle Self;
	public IntPtr UserData;
}

public struct ImUpdateSignal
{
	public GtkEventControllerKeyHandle Self;
	public IntPtr UserData;
}

public struct KeyPressedSignal
{
	public GtkEventControllerKeyHandle Self;
	public uint Keyval;
	public uint Keycode;
	public GdkModifierType State;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct KeyReleasedSignal
{
	public GtkEventControllerKeyHandle Self;
	public uint Keyval;
	public uint Keycode;
	public GdkModifierType State;
	public IntPtr UserData;
}

public struct ModifiersSignal
{
	public GtkEventControllerKeyHandle Self;
	public GdkModifierType Object;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkEventControllerKeySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_in([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void im_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, uint keyval, uint keycode, ref GdkModifierType state, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void key_released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, uint keyval, uint keycode, ref GdkModifierType state, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, ref GdkModifierType @object, IntPtr user_data);

}


public static class GtkEventControllerKeyHandleExtensions
{
	public static bool Forward(this GtkEventControllerKeyHandle controller, GtkWidgetHandle widget)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_forward(controller, widget);
	}

	public static uint GetGroup(this GtkEventControllerKeyHandle controller)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_get_group(controller);
	}

	public static GtkIMContextHandle GetImContext(this GtkEventControllerKeyHandle controller)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_get_im_context(controller);
	}

	public static T SetImContext<T>(this T controller, GtkIMContextHandle im_context) where T : GtkEventControllerKeyHandle
	{
		GtkEventControllerKeyExterns.gtk_event_controller_key_set_im_context(controller, im_context);
		return controller;
	}

}

internal class GtkEventControllerKeyExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEventControllerKeyHandle gtk_event_controller_key_new(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_event_controller_key_forward(GtkEventControllerKeyHandle controller, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_event_controller_key_get_group(GtkEventControllerKeyHandle controller);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIMContextHandle gtk_event_controller_key_get_im_context(GtkEventControllerKeyHandle controller);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_event_controller_key_set_im_context(GtkEventControllerKeyHandle controller, GtkIMContextHandle im_context);

}
