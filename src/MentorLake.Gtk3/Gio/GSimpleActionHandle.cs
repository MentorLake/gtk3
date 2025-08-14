namespace MentorLake.Gio;

/// <summary>
/// <para>
/// A `GSimpleAction` is the obvious simple implementation of the
/// [iface@Gio.Action] interface. This is the easiest way to create an action for
/// purposes of adding it to a [class@Gio.SimpleActionGroup].
/// </para>
/// </summary>

public class GSimpleActionHandle : GObjectHandle, GActionHandle
{
/// <summary>
/// <para>
/// Creates a new action.
/// </para>
/// <para>
/// The created action is stateless. See g_simple_action_new_stateful() to create
/// an action that has state.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the action
/// </param>
/// <param name="parameter_type">
/// the type of parameter that will be passed to
///   handlers for the #GSimpleAction::activate signal, or %NULL for no parameter
/// </param>
/// <return>
/// a new #GSimpleAction
/// </return>

	public static MentorLake.Gio.GSimpleActionHandle New(string name, MentorLake.GLib.GVariantTypeHandle parameter_type)
	{
		return GSimpleActionHandleExterns.g_simple_action_new(name, parameter_type);
	}

/// <summary>
/// <para>
/// Creates a new stateful action.
/// </para>
/// <para>
/// All future state values must have the same #GVariantType as the initial
/// @state.
/// </para>
/// <para>
/// If the @state #GVariant is floating, it is consumed.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the action
/// </param>
/// <param name="parameter_type">
/// the type of the parameter that will be passed to
///   handlers for the #GSimpleAction::activate signal, or %NULL for no parameter
/// </param>
/// <param name="state">
/// the initial state of the action
/// </param>
/// <return>
/// a new #GSimpleAction
/// </return>

	public static MentorLake.Gio.GSimpleActionHandle NewStateful(string name, MentorLake.GLib.GVariantTypeHandle parameter_type, MentorLake.GLib.GVariantHandle state)
	{
		return GSimpleActionHandleExterns.g_simple_action_new_stateful(name, parameter_type, state);
	}

}
public static class GSimpleActionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Indicates that the action was just activated.
/// </para>
/// <para>
/// @parameter will always be of the expected type, i.e. the parameter type
/// specified when the action was created. If an incorrect type is given when
/// activating the action, this signal is not emitted.
/// </para>
/// <para>
/// Since GLib 2.40, if no handler is connected to this signal then the
/// default behaviour for boolean-stated actions with a %NULL parameter
/// type is to toggle them via the #GSimpleAction::change-state signal.
/// For stateful actions where the state type is equal to the parameter
/// type, the default is to forward them directly to
/// #GSimpleAction::change-state.  This should allow almost all users
/// of #GSimpleAction to connect only one handler or the other.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Indicates that the action just received a request to change its
/// state.
/// </para>
/// <para>
/// @value will always be of the correct state type, i.e. the type of the
/// initial state passed to g_simple_action_new_stateful(). If an incorrect
/// type is given when requesting to change the state, this signal is not
/// emitted.
/// </para>
/// <para>
/// If no handler is connected to this signal then the default
/// behaviour is to call g_simple_action_set_state() to set the state
/// to the requested value. If you connect a signal handler then no
/// default action is taken. If the state should change then you must
/// call g_simple_action_set_state() from the handler.
/// </para>
/// <para>
/// An example of a 'change-state' handler:
/// |[<!-- language="C" -->
/// static void
/// change_volume_state (GSimpleAction *action,
///                      GVariant      *value,
///                      gpointer       user_data)
/// {
///   gint requested;
/// </para>
/// <para>
///   requested = g_variant_get_int32 (value);
/// </para>
/// <para>
///   // Volume only goes from 0 to 10
///   if (0 <= requested && requested <= 10)
///     g_simple_action_set_state (action, value);
/// }
/// ]|
/// </para>
/// <para>
/// The handler need not set the state to the requested value.
/// It could set it to any value at all, or take some other action.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the parameter to the activation, or %NULL if it has
///   no parameter
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle Parameter;

	public IntPtr UserData;
}

public class ChangeStateSignal
{

	public MentorLake.Gio.GSimpleActionHandle Self;
/// <summary>
/// <para>
/// the requested value for the state
/// </para>
/// </summary>

	public MentorLake.GLib.GVariantHandle Value;

	public IntPtr UserData;
}
}

public static class GSimpleActionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Indicates that the action was just activated.
/// </para>
/// <para>
/// @parameter will always be of the expected type, i.e. the parameter type
/// specified when the action was created. If an incorrect type is given when
/// activating the action, this signal is not emitted.
/// </para>
/// <para>
/// Since GLib 2.40, if no handler is connected to this signal then the
/// default behaviour for boolean-stated actions with a %NULL parameter
/// type is to toggle them via the #GSimpleAction::change-state signal.
/// For stateful actions where the state type is equal to the parameter
/// type, the default is to forward them directly to
/// #GSimpleAction::change-state.  This should allow almost all users
/// of #GSimpleAction to connect only one handler or the other.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="parameter">
/// the parameter to the activation, or %NULL if it has
///   no parameter
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))] MentorLake.Gio.GSimpleActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameter, IntPtr user_data);


/// <summary>
/// <para>
/// Indicates that the action just received a request to change its
/// state.
/// </para>
/// <para>
/// @value will always be of the correct state type, i.e. the type of the
/// initial state passed to g_simple_action_new_stateful(). If an incorrect
/// type is given when requesting to change the state, this signal is not
/// emitted.
/// </para>
/// <para>
/// If no handler is connected to this signal then the default
/// behaviour is to call g_simple_action_set_state() to set the state
/// to the requested value. If you connect a signal handler then no
/// default action is taken. If the state should change then you must
/// call g_simple_action_set_state() from the handler.
/// </para>
/// <para>
/// An example of a 'change-state' handler:
/// |[<!-- language="C" -->
/// static void
/// change_volume_state (GSimpleAction *action,
///                      GVariant      *value,
///                      gpointer       user_data)
/// {
///   gint requested;
/// </para>
/// <para>
///   requested = g_variant_get_int32 (value);
/// </para>
/// <para>
///   // Volume only goes from 0 to 10
///   if (0 <= requested && requested <= 10)
///     g_simple_action_set_state (action, value);
/// }
/// ]|
/// </para>
/// <para>
/// The handler need not set the state to the requested value.
/// It could set it to any value at all, or take some other action.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the requested value for the state
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void change_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleActionHandle>))] MentorLake.Gio.GSimpleActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr user_data);

}


public static class GSimpleActionHandleExtensions
{
/// <summary>
/// <para>
/// Sets the action as enabled or not.
/// </para>
/// <para>
/// An action must be enabled in order to be activated or in order to
/// have its state changed from outside callers.
/// </para>
/// <para>
/// This should only be called by the implementor of the action.  Users
/// of the action should not attempt to modify its enabled flag.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAction
/// </param>
/// <param name="enabled">
/// whether the action is enabled
/// </param>

	public static T SetEnabled<T>(this T simple, bool enabled) where T : GSimpleActionHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionHandle)");
		GSimpleActionHandleExterns.g_simple_action_set_enabled(simple, enabled);
		return simple;
	}

/// <summary>
/// <para>
/// Sets the state of the action.
/// </para>
/// <para>
/// This directly updates the 'state' property to the given value.
/// </para>
/// <para>
/// This should only be called by the implementor of the action.  Users
/// of the action should not attempt to directly modify the 'state'
/// property.  Instead, they should call g_action_change_state() to
/// request the change.
/// </para>
/// <para>
/// If the @value GVariant is floating, it is consumed.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAction
/// </param>
/// <param name="value">
/// the new #GVariant for the state
/// </param>

	public static T SetState<T>(this T simple, MentorLake.GLib.GVariantHandle value) where T : GSimpleActionHandle
	{
		if (simple.IsInvalid) throw new Exception("Invalid handle (GSimpleActionHandle)");
		GSimpleActionHandleExterns.g_simple_action_set_state(simple, value);
		return simple;
	}

/// <summary>
/// <para>
/// Sets the state hint for the action.
/// </para>
/// <para>
/// See g_action_get_state_hint() for more information about
/// action state hints.
/// </para>
/// </summary>

/// <param name="simple">
/// a #GSimpleAction
/// </param>
/// <param name="state_hint">
/// a #GVariant representing the state hint
/// </param>

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
