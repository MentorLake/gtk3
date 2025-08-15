namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkMenuToolButton is a #GtkToolItem that contains a button and
/// a small additional button with an arrow. When clicked, the arrow
/// button pops up a dropdown menu.
/// </para>
/// <para>
/// Use gtk_menu_tool_button_new() to create a new
/// #GtkMenuToolButton.
/// </para>
/// <para>
/// # GtkMenuToolButton as GtkBuildable
/// </para>
/// <para>
/// The GtkMenuToolButton implementation of the GtkBuildable interface
/// supports adding a menu by specifying “menu” as the “type” attribute
/// of a `&amp;lt;child&amp;gt;` element.
/// </para>
/// <para>
/// An example for a UI definition fragment with menus:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkMenuToolButton&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkMenuToolButton&quot;&amp;gt;
///   &amp;lt;child type=&quot;menu&quot;&amp;gt;
///     &amp;lt;object class=&quot;GtkMenu&quot;/&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// </summary>

public class GtkMenuToolButtonHandle : GtkToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkMenuToolButton using @icon_widget as icon and
/// @label as label.
/// </para>
/// </summary>

/// <param name="icon_widget">
/// a widget that will be used as icon widget, or %NULL
/// </param>
/// <param name="label">
/// a string that will be used as label, or %NULL
/// </param>
/// <return>
/// the new #GtkMenuToolButton
/// </return>

	public static MentorLake.Gtk.GtkMenuToolButtonHandle New(MentorLake.Gtk.GtkWidgetHandle icon_widget, string label)
	{
		return GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_new(icon_widget, label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkMenuToolButton.
/// The new #GtkMenuToolButton will contain an icon and label from
/// the stock item indicated by @stock_id.
/// </para>
/// </summary>

/// <param name="stock_id">
/// the name of a stock item
/// </param>
/// <return>
/// the new #GtkMenuToolButton
/// </return>

	public static MentorLake.Gtk.GtkMenuToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_new_from_stock(stock_id);
	}

}
public static class GtkMenuToolButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::show-menu signal is emitted before the menu is shown.
/// </para>
/// <para>
/// It can be used to populate the menu on demand, using
/// gtk_menu_tool_button_set_menu().
/// </para>
/// <para>
/// Note that even if you populate the menu dynamically in this way,
/// you must set an empty menu on the #GtkMenuToolButton beforehand,
/// since the arrow is made insensitive if the menu is not set.
/// </para>
/// </summary>

	public static IObservable<GtkMenuToolButtonHandleSignalStructs.ShowMenuSignal> Signal_ShowMenu(this GtkMenuToolButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuToolButtonHandleSignalStructs.ShowMenuSignal> obs) =>
		{
			GtkMenuToolButtonHandleSignalDelegates.show_menu handler = ( MentorLake.Gtk.GtkMenuToolButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuToolButtonHandleSignalStructs.ShowMenuSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuToolButtonHandleSignalStructs
{

public class ShowMenuSignal
{

	public MentorLake.Gtk.GtkMenuToolButtonHandle Self;

	public IntPtr UserData;
}
}

public static class GtkMenuToolButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::show-menu signal is emitted before the menu is shown.
/// </para>
/// <para>
/// It can be used to populate the menu on demand, using
/// gtk_menu_tool_button_set_menu().
/// </para>
/// <para>
/// Note that even if you populate the menu dynamically in this way,
/// you must set an empty menu on the #GtkMenuToolButton beforehand,
/// since the arrow is made insensitive if the menu is not set.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle self, IntPtr user_data);

}


public static class GtkMenuToolButtonHandleExtensions
{
/// <summary>
/// <para>
/// Gets the #GtkMenu associated with #GtkMenuToolButton.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkMenuToolButton
/// </param>
/// <return>
/// the #GtkMenu associated
///     with #GtkMenuToolButton
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetMenu(this MentorLake.Gtk.GtkMenuToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkMenuToolButtonHandle)");
		return GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_get_menu(button);
	}

/// <summary>
/// <para>
/// Sets the tooltip markup text to be used as tooltip for the arrow button
/// which pops up the menu.  See gtk_tool_item_set_tooltip_text() for setting
/// a tooltip on the whole #GtkMenuToolButton.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkMenuToolButton
/// </param>
/// <param name="markup">
/// markup text to be used as tooltip text for button’s arrow button
/// </param>

	public static T SetArrowTooltipMarkup<T>(this T button, string markup) where T : GtkMenuToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkMenuToolButtonHandle)");
		GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_set_arrow_tooltip_markup(button, markup);
		return button;
	}

/// <summary>
/// <para>
/// Sets the tooltip text to be used as tooltip for the arrow button which
/// pops up the menu.  See gtk_tool_item_set_tooltip_text() for setting a tooltip
/// on the whole #GtkMenuToolButton.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkMenuToolButton
/// </param>
/// <param name="text">
/// text to be used as tooltip text for button’s arrow button
/// </param>

	public static T SetArrowTooltipText<T>(this T button, string text) where T : GtkMenuToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkMenuToolButtonHandle)");
		GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_set_arrow_tooltip_text(button, text);
		return button;
	}

/// <summary>
/// <para>
/// Sets the #GtkMenu that is popped up when the user clicks on the arrow.
/// If @menu is NULL, the arrow button becomes insensitive.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkMenuToolButton
/// </param>
/// <param name="menu">
/// the #GtkMenu associated with #GtkMenuToolButton
/// </param>

	public static T SetMenu<T>(this T button, MentorLake.Gtk.GtkWidgetHandle menu) where T : GtkMenuToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkMenuToolButtonHandle)");
		GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_set_menu(button, menu);
		return button;
	}

}

internal class GtkMenuToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuToolButtonHandle gtk_menu_tool_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle icon_widget, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuToolButtonHandle gtk_menu_tool_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_tool_button_get_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_tool_button_set_arrow_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_tool_button_set_arrow_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_tool_button_set_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu);

}
