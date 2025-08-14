namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkToggleAction corresponds roughly to a #GtkCheckMenuItem. It has an
/// “active” state specifying whether the action has been checked or not.
/// </para>
/// </summary>

public class GtkToggleActionHandle : GtkActionHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkToggleAction object. To add the action to
/// a #GtkActionGroup and set the accelerator for the action,
/// call gtk_action_group_add_action_with_accel().
/// </para>
/// </summary>

/// <param name="name">
/// A unique name for the action
/// </param>
/// <param name="label">
/// The label displayed in menu items and on buttons,
///         or %NULL
/// </param>
/// <param name="tooltip">
/// A tooltip for the action, or %NULL
/// </param>
/// <param name="stock_id">
/// The stock icon to display in widgets representing
///            the action, or %NULL
/// </param>
/// <return>
/// a new #GtkToggleAction
/// </return>

	public static MentorLake.Gtk.GtkToggleActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkToggleActionHandleExterns.gtk_toggle_action_new(name, label, tooltip, stock_id);
	}

}
public static class GtkToggleActionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Should be connected if you wish to perform an action
/// whenever the #GtkToggleAction state is changed.
/// </para>
/// </summary>

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

public class ToggledSignal
{

	public MentorLake.Gtk.GtkToggleActionHandle Self;

	public IntPtr UserData;
}
}

public static class GtkToggleActionHandleSignalDelegates
{

/// <summary>
/// <para>
/// Should be connected if you wish to perform an action
/// whenever the #GtkToggleAction state is changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))] MentorLake.Gtk.GtkToggleActionHandle self, IntPtr user_data);

}


public static class GtkToggleActionHandleExtensions
{
/// <summary>
/// <para>
/// Returns the checked state of the toggle action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// the checked state of the toggle action
/// </return>

	public static bool GetActive(this MentorLake.Gtk.GtkToggleActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkToggleActionHandle)");
		return GtkToggleActionHandleExterns.gtk_toggle_action_get_active(action);
	}

/// <summary>
/// <para>
/// Returns whether the action should have proxies like a radio action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <return>
/// whether the action should have proxies like a radio action.
/// </return>

	public static bool GetDrawAsRadio(this MentorLake.Gtk.GtkToggleActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkToggleActionHandle)");
		return GtkToggleActionHandleExterns.gtk_toggle_action_get_draw_as_radio(action);
	}

/// <summary>
/// <para>
/// Sets the checked state on the toggle action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="is_active">
/// whether the action should be checked or not
/// </param>

	public static T SetActive<T>(this T action, bool is_active) where T : GtkToggleActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkToggleActionHandle)");
		GtkToggleActionHandleExterns.gtk_toggle_action_set_active(action, is_active);
		return action;
	}

/// <summary>
/// <para>
/// Sets whether the action should have proxies like a radio action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>
/// <param name="draw_as_radio">
/// whether the action should have proxies like a radio
///    action
/// </param>

	public static T SetDrawAsRadio<T>(this T action, bool draw_as_radio) where T : GtkToggleActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkToggleActionHandle)");
		GtkToggleActionHandleExterns.gtk_toggle_action_set_draw_as_radio(action, draw_as_radio);
		return action;
	}

/// <summary>
/// <para>
/// Emits the “toggled” signal on the toggle action.
/// </para>
/// </summary>

/// <param name="action">
/// the action object
/// </param>

	public static T Toggled<T>(this T action) where T : GtkToggleActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkToggleActionHandle)");
		GtkToggleActionHandleExterns.gtk_toggle_action_toggled(action);
		return action;
	}

}

internal class GtkToggleActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToggleActionHandle>))]
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
