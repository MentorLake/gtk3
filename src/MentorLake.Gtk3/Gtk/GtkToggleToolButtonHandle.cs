namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkToggleToolButton is a #GtkToolItem that contains a toggle
/// button.
/// </para>
/// <para>
/// Use gtk_toggle_tool_button_new() to create a new GtkToggleToolButton.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkToggleToolButton has a single CSS node with name togglebutton.
/// </para>
/// </summary>

public class GtkToggleToolButtonHandle : GtkToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Returns a new #GtkToggleToolButton
/// </para>
/// </summary>

/// <return>
/// a newly created #GtkToggleToolButton
/// </return>

	public static MentorLake.Gtk.GtkToggleToolButtonHandle New()
	{
		return GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkToggleToolButton containing the image and text from a
/// stock item. Some stock ids have preprocessor macros like #GTK_STOCK_OK
/// and #GTK_STOCK_APPLY.
/// </para>
/// <para>
/// It is an error if @stock_id is not a name of a stock item.
/// </para>
/// </summary>

/// <param name="stock_id">
/// the name of the stock item
/// </param>
/// <return>
/// A new #GtkToggleToolButton
/// </return>

	public static MentorLake.Gtk.GtkToggleToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_new_from_stock(stock_id);
	}

}
public static class GtkToggleToolButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted whenever the toggle tool button changes state.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Emitted whenever the toggle tool button changes state.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))] MentorLake.Gtk.GtkToggleToolButtonHandle self, IntPtr user_data);

}


public static class GtkToggleToolButtonHandleExtensions
{
/// <summary>
/// <para>
/// Queries a #GtkToggleToolButton and returns its current state.
/// Returns %TRUE if the toggle button is pressed in and %FALSE if it is raised.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToggleToolButton
/// </param>
/// <return>
/// %TRUE if the toggle tool button is pressed in, %FALSE if not
/// </return>

	public static bool GetActive(this MentorLake.Gtk.GtkToggleToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToggleToolButtonHandle)");
		return GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_get_active(button);
	}

/// <summary>
/// <para>
/// Sets the status of the toggle tool button. Set to %TRUE if you
/// want the GtkToggleButton to be “pressed in”, and %FALSE to raise it.
/// This action causes the toggled signal to be emitted.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToggleToolButton
/// </param>
/// <param name="is_active">
/// whether @button should be active
/// </param>

	public static T SetActive<T>(this T button, bool is_active) where T : GtkToggleToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToggleToolButtonHandle)");
		GtkToggleToolButtonHandleExterns.gtk_toggle_tool_button_set_active(button, is_active);
		return button;
	}

}

internal class GtkToggleToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToggleToolButtonHandle gtk_toggle_tool_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToggleToolButtonHandle gtk_toggle_tool_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_tool_button_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))] MentorLake.Gtk.GtkToggleToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_tool_button_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleToolButtonHandle>))] MentorLake.Gtk.GtkToggleToolButtonHandle button, bool is_active);

}
