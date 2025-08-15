namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkSwitch is a widget that has two states: on or off. The user can control
/// which state should be active by clicking the empty area, or by dragging the
/// handle.
/// </para>
/// <para>
/// GtkSwitch can also handle situations where the underlying state changes with
/// a delay. See #GtkSwitch::state-set for details.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// switch
/// switch
/// ╰── slider
/// </code>
/// <para>
/// GtkSwitch has two css nodes, the main node with the name switch and a subnode
/// named slider. Neither of them is using any style classes.
/// </para>
/// </summary>

public class GtkSwitchHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkSwitch widget.
/// </para>
/// </summary>

/// <return>
/// the newly created #GtkSwitch instance
/// </return>

	public static MentorLake.Gtk.GtkSwitchHandle New()
	{
		return GtkSwitchHandleExterns.gtk_switch_new();
	}

}
public static class GtkSwitchHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate signal on GtkSwitch is an action signal and
/// emitting it causes the switch to animate.
/// Applications should never connect to this signal, but use the
/// notify::active signal.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// The ::state-set signal on GtkSwitch is emitted to change the underlying
/// state. It is emitted when the user changes the switch position. The
/// default handler keeps the state in sync with the #GtkSwitch:active
/// property.
/// </para>
/// <para>
/// To implement delayed state change, applications can connect to this signal,
/// initiate the change of the underlying state, and call gtk_switch_set_state()
/// when the underlying state change is complete. The signal handler should
/// return %TRUE to prevent the default handler from running.
/// </para>
/// <para>
/// Visually, the underlying state is represented by the trough color of
/// the switch, while the #GtkSwitch:active property is represented by the
/// position of the switch.
/// </para>
/// </summary>

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

public class ActivateSignal
{

	public MentorLake.Gtk.GtkSwitchHandle Self;

	public IntPtr UserData;
}

public class StateSetSignal
{

	public MentorLake.Gtk.GtkSwitchHandle Self;
/// <summary>
/// <para>
/// the new state of the switch
/// </para>
/// </summary>

	public bool State;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop the signal emission
/// </para>
/// </summary>

	public bool ReturnValue;
}
}

public static class GtkSwitchHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::activate signal on GtkSwitch is an action signal and
/// emitting it causes the switch to animate.
/// Applications should never connect to this signal, but use the
/// notify::active signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::state-set signal on GtkSwitch is emitted to change the underlying
/// state. It is emitted when the user changes the switch position. The
/// default handler keeps the state in sync with the #GtkSwitch:active
/// property.
/// </para>
/// <para>
/// To implement delayed state change, applications can connect to this signal,
/// initiate the change of the underlying state, and call gtk_switch_set_state()
/// when the underlying state change is complete. The signal handler should
/// return %TRUE to prevent the default handler from running.
/// </para>
/// <para>
/// Visually, the underlying state is represented by the trough color of
/// the switch, while the #GtkSwitch:active property is represented by the
/// position of the switch.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="state">
/// the new state of the switch
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop the signal emission
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool state_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))] MentorLake.Gtk.GtkSwitchHandle self, bool state, IntPtr user_data);

}


public static class GtkSwitchHandleExtensions
{
/// <summary>
/// <para>
/// Gets whether the #GtkSwitch is in its “on” or “off” state.
/// </para>
/// </summary>

/// <param name="sw">
/// a #GtkSwitch
/// </param>
/// <return>
/// %TRUE if the #GtkSwitch is active, and %FALSE otherwise
/// </return>

	public static bool GetActive(this MentorLake.Gtk.GtkSwitchHandle sw)
	{
		if (sw.IsInvalid) throw new Exception("Invalid handle (GtkSwitchHandle)");
		return GtkSwitchHandleExterns.gtk_switch_get_active(sw);
	}

/// <summary>
/// <para>
/// Gets the underlying state of the #GtkSwitch.
/// </para>
/// </summary>

/// <param name="sw">
/// a #GtkSwitch
/// </param>
/// <return>
/// the underlying state
/// </return>

	public static bool GetState(this MentorLake.Gtk.GtkSwitchHandle sw)
	{
		if (sw.IsInvalid) throw new Exception("Invalid handle (GtkSwitchHandle)");
		return GtkSwitchHandleExterns.gtk_switch_get_state(sw);
	}

/// <summary>
/// <para>
/// Changes the state of @sw to the desired one.
/// </para>
/// </summary>

/// <param name="sw">
/// a #GtkSwitch
/// </param>
/// <param name="is_active">
/// %TRUE if @sw should be active, and %FALSE otherwise
/// </param>

	public static T SetActive<T>(this T sw, bool is_active) where T : GtkSwitchHandle
	{
		if (sw.IsInvalid) throw new Exception("Invalid handle (GtkSwitchHandle)");
		GtkSwitchHandleExterns.gtk_switch_set_active(sw, is_active);
		return sw;
	}

/// <summary>
/// <para>
/// Sets the underlying state of the #GtkSwitch.
/// </para>
/// <para>
/// Normally, this is the same as #GtkSwitch:active, unless the switch
/// is set up for delayed state changes. This function is typically
/// called from a #GtkSwitch::state-set signal handler.
/// </para>
/// <para>
/// See #GtkSwitch::state-set for details.
/// </para>
/// </summary>

/// <param name="sw">
/// a #GtkSwitch
/// </param>
/// <param name="state">
/// the new state
/// </param>

	public static T SetState<T>(this T sw, bool state) where T : GtkSwitchHandle
	{
		if (sw.IsInvalid) throw new Exception("Invalid handle (GtkSwitchHandle)");
		GtkSwitchHandleExterns.gtk_switch_set_state(sw, state);
		return sw;
	}

}

internal class GtkSwitchHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSwitchHandle>))]
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
