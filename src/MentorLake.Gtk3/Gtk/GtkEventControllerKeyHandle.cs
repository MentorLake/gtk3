namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkEventControllerKey is an event controller meant for situations
/// where you need access to key events.
/// </para>
/// <para>
/// This object was added in 3.24.
/// </para>
/// </summary>

public class GtkEventControllerKeyHandle : GtkEventControllerHandle
{

/// <param name="widget">
/// </param>

	public static MentorLake.Gtk.GtkEventControllerKeyHandle New(MentorLake.Gtk.GtkWidgetHandle widget)
	{
		return GtkEventControllerKeyHandleExterns.gtk_event_controller_key_new(widget);
	}

}
public static class GtkEventControllerKeyHandleSignalExtensions
{

	public static IObservable<GtkEventControllerKeyHandleSignalStructs.FocusInSignal> Signal_FocusIn(this GtkEventControllerKeyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerKeyHandleSignalStructs.FocusInSignal> obs) =>
		{
			GtkEventControllerKeyHandleSignalDelegates.focus_in handler = ( MentorLake.Gtk.GtkEventControllerKeyHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeyHandleSignalStructs.FocusInSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-in", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEventControllerKeyHandleSignalStructs.FocusOutSignal> Signal_FocusOut(this GtkEventControllerKeyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerKeyHandleSignalStructs.FocusOutSignal> obs) =>
		{
			GtkEventControllerKeyHandleSignalDelegates.focus_out handler = ( MentorLake.Gtk.GtkEventControllerKeyHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeyHandleSignalStructs.FocusOutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEventControllerKeyHandleSignalStructs.ImUpdateSignal> Signal_ImUpdate(this GtkEventControllerKeyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerKeyHandleSignalStructs.ImUpdateSignal> obs) =>
		{
			GtkEventControllerKeyHandleSignalDelegates.im_update handler = ( MentorLake.Gtk.GtkEventControllerKeyHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeyHandleSignalStructs.ImUpdateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "im-update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted whenever a key is pressed.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerKeyHandleSignalStructs.KeyPressedSignal> Signal_KeyPressed(this GtkEventControllerKeyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerKeyHandleSignalStructs.KeyPressedSignal> obs) =>
		{
			GtkEventControllerKeyHandleSignalDelegates.key_pressed handler = ( MentorLake.Gtk.GtkEventControllerKeyHandle self,  uint keyval,  uint keycode,  MentorLake.Gdk.GdkModifierType state,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeyHandleSignalStructs.KeyPressedSignal()
				{
					Self = self, Keyval = keyval, Keycode = keycode, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "key-pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted whenever a key is released.
/// </para>
/// </summary>

	public static IObservable<GtkEventControllerKeyHandleSignalStructs.KeyReleasedSignal> Signal_KeyReleased(this GtkEventControllerKeyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerKeyHandleSignalStructs.KeyReleasedSignal> obs) =>
		{
			GtkEventControllerKeyHandleSignalDelegates.key_released handler = ( MentorLake.Gtk.GtkEventControllerKeyHandle self,  uint keyval,  uint keycode,  MentorLake.Gdk.GdkModifierType state,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeyHandleSignalStructs.KeyReleasedSignal()
				{
					Self = self, Keyval = keyval, Keycode = keycode, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "key-released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEventControllerKeyHandleSignalStructs.ModifiersSignal> Signal_Modifiers(this GtkEventControllerKeyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEventControllerKeyHandleSignalStructs.ModifiersSignal> obs) =>
		{
			GtkEventControllerKeyHandleSignalDelegates.modifiers handler = ( MentorLake.Gtk.GtkEventControllerKeyHandle self,  MentorLake.Gdk.GdkModifierType @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEventControllerKeyHandleSignalStructs.ModifiersSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "modifiers", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkEventControllerKeyHandleSignalStructs
{

public class FocusInSignal
{

	public MentorLake.Gtk.GtkEventControllerKeyHandle Self;

	public IntPtr UserData;
}

public class FocusOutSignal
{

	public MentorLake.Gtk.GtkEventControllerKeyHandle Self;

	public IntPtr UserData;
}

public class ImUpdateSignal
{

	public MentorLake.Gtk.GtkEventControllerKeyHandle Self;

	public IntPtr UserData;
}

public class KeyPressedSignal
{

	public MentorLake.Gtk.GtkEventControllerKeyHandle Self;
/// <summary>
/// <para>
/// the pressed key.
/// </para>
/// </summary>

	public uint Keyval;
/// <summary>
/// <para>
/// the raw code of the pressed key.
/// </para>
/// </summary>

	public uint Keycode;
/// <summary>
/// <para>
/// the bitmask, representing the state of modifier keys and pointer buttons. See #GdkModifierType.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkModifierType State;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the key press was handled, %FALSE otherwise.
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class KeyReleasedSignal
{

	public MentorLake.Gtk.GtkEventControllerKeyHandle Self;
/// <summary>
/// <para>
/// the released key.
/// </para>
/// </summary>

	public uint Keyval;
/// <summary>
/// <para>
/// the raw code of the released key.
/// </para>
/// </summary>

	public uint Keycode;
/// <summary>
/// <para>
/// the bitmask, representing the state of modifier keys and pointer buttons. See #GdkModifierType.
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkModifierType State;

	public IntPtr UserData;
}

public class ModifiersSignal
{

	public MentorLake.Gtk.GtkEventControllerKeyHandle Self;

	public MentorLake.Gdk.GdkModifierType Object;

	public IntPtr UserData;

	public bool ReturnValue;
}
}

public static class GtkEventControllerKeyHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_in([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void im_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever a key is pressed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="keyval">
/// the pressed key.
/// </param>
/// <param name="keycode">
/// the raw code of the pressed key.
/// </param>
/// <param name="state">
/// the bitmask, representing the state of modifier keys and pointer buttons. See #GdkModifierType.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the key press was handled, %FALSE otherwise.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle self, uint keyval, uint keycode, MentorLake.Gdk.GdkModifierType state, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted whenever a key is released.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="keyval">
/// the released key.
/// </param>
/// <param name="keycode">
/// the raw code of the released key.
/// </param>
/// <param name="state">
/// the bitmask, representing the state of modifier keys and pointer buttons. See #GdkModifierType.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void key_released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle self, uint keyval, uint keycode, MentorLake.Gdk.GdkModifierType state, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle self, MentorLake.Gdk.GdkModifierType @object, IntPtr user_data);

}


public static class GtkEventControllerKeyHandleExtensions
{

/// <param name="controller">
/// </param>
/// <param name="widget">
/// </param>

	public static bool Forward(this MentorLake.Gtk.GtkEventControllerKeyHandle controller, MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerKeyHandle)");
		return GtkEventControllerKeyHandleExterns.gtk_event_controller_key_forward(controller, widget);
	}


/// <param name="controller">
/// </param>

	public static uint GetGroup(this MentorLake.Gtk.GtkEventControllerKeyHandle controller)
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerKeyHandle)");
		return GtkEventControllerKeyHandleExterns.gtk_event_controller_key_get_group(controller);
	}

/// <summary>
/// <para>
/// Gets the IM context of a key controller.
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkEventControllerKey
/// </param>
/// <return>
/// the IM context
/// </return>

	public static MentorLake.Gtk.GtkIMContextHandle GetImContext(this MentorLake.Gtk.GtkEventControllerKeyHandle controller)
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerKeyHandle)");
		return GtkEventControllerKeyHandleExterns.gtk_event_controller_key_get_im_context(controller);
	}


/// <param name="controller">
/// </param>
/// <param name="im_context">
/// </param>

	public static T SetImContext<T>(this T controller, MentorLake.Gtk.GtkIMContextHandle im_context) where T : GtkEventControllerKeyHandle
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerKeyHandle)");
		GtkEventControllerKeyHandleExterns.gtk_event_controller_key_set_im_context(controller, im_context);
		return controller;
	}

}

internal class GtkEventControllerKeyHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))]
	internal static extern MentorLake.Gtk.GtkEventControllerKeyHandle gtk_event_controller_key_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_event_controller_key_forward([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle controller, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_event_controller_key_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle controller);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))]
	internal static extern MentorLake.Gtk.GtkIMContextHandle gtk_event_controller_key_get_im_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle controller);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_controller_key_set_im_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerKeyHandle>))] MentorLake.Gtk.GtkEventControllerKeyHandle controller, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextHandle>))] MentorLake.Gtk.GtkIMContextHandle im_context);

}
