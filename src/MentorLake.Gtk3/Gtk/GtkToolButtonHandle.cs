namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkToolButtons are #GtkToolItems containing buttons.
/// </para>
/// <para>
/// Use gtk_tool_button_new() to create a new #GtkToolButton.
/// </para>
/// <para>
/// The label of a #GtkToolButton is determined by the properties
/// #GtkToolButton:label-widget, #GtkToolButton:label, and
/// #GtkToolButton:stock-id. If #GtkToolButton:label-widget is
/// non-%NULL, then that widget is used as the label. Otherwise, if
/// #GtkToolButton:label is non-%NULL, that string is used as the label.
/// Otherwise, if #GtkToolButton:stock-id is non-%NULL, the label is
/// determined by the stock item. Otherwise, the button does not have a label.
/// </para>
/// <para>
/// The icon of a #GtkToolButton is determined by the properties
/// #GtkToolButton:icon-widget and #GtkToolButton:stock-id. If
/// #GtkToolButton:icon-widget is non-%NULL, then
/// that widget is used as the icon. Otherwise, if #GtkToolButton:stock-id is
/// non-%NULL, the icon is determined by the stock item. Otherwise,
/// the button does not have a icon.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkToolButton has a single CSS node with name toolbutton.
/// </para>
/// </summary>

public class GtkToolButtonHandle : GtkToolItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkToolButton using @icon_widget as contents and @label as
/// label.
/// </para>
/// </summary>

/// <param name="icon_widget">
/// a widget that will be used as the button contents, or %NULL
/// </param>
/// <param name="label">
/// a string that will be used as label, or %NULL
/// </param>
/// <return>
/// A new #GtkToolButton
/// </return>

	public static MentorLake.Gtk.GtkToolButtonHandle New(MentorLake.Gtk.GtkWidgetHandle icon_widget, string label)
	{
		return GtkToolButtonHandleExterns.gtk_tool_button_new(icon_widget, label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkToolButton containing the image and text from a
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
/// A new #GtkToolButton
/// </return>

	public static MentorLake.Gtk.GtkToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkToolButtonHandleExterns.gtk_tool_button_new_from_stock(stock_id);
	}

}
public static class GtkToolButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the tool button is clicked with the mouse
/// or activated with the keyboard.
/// </para>
/// </summary>

	public static IObservable<GtkToolButtonHandleSignalStructs.ClickedSignal> Signal_Clicked(this GtkToolButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolButtonHandleSignalStructs.ClickedSignal> obs) =>
		{
			GtkToolButtonHandleSignalDelegates.clicked handler = ( MentorLake.Gtk.GtkToolButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolButtonHandleSignalStructs.ClickedSignal()
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
}

public static class GtkToolButtonHandleSignalStructs
{

public class ClickedSignal
{

	public MentorLake.Gtk.GtkToolButtonHandle Self;

	public IntPtr UserData;
}
}

public static class GtkToolButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the tool button is clicked with the mouse
/// or activated with the keyboard.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle self, IntPtr user_data);

}


public static class GtkToolButtonHandleExtensions
{
/// <summary>
/// <para>
/// Returns the name of the themed icon for the tool button,
/// see gtk_tool_button_set_icon_name().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <return>
/// the icon name or %NULL if the tool button has
/// no themed icon
/// </return>

	public static string GetIconName(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_icon_name(button);
	}

/// <summary>
/// <para>
/// Return the widget used as icon widget on @button.
/// See gtk_tool_button_set_icon_widget().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <return>
/// The widget used as icon
///     on @button, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetIconWidget(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_icon_widget(button);
	}

/// <summary>
/// <para>
/// Returns the label used by the tool button, or %NULL if the tool button
/// doesn’t have a label. or uses a the label from a stock item. The returned
/// string is owned by GTK+, and must not be modified or freed.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <return>
/// The label, or %NULL
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_label(button);
	}

/// <summary>
/// <para>
/// Returns the widget used as label on @button.
/// See gtk_tool_button_set_label_widget().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <return>
/// The widget used as label
///     on @button, or %NULL.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_label_widget(button);
	}

/// <summary>
/// <para>
/// Returns the name of the stock item. See gtk_tool_button_set_stock_id().
/// The returned string is owned by GTK+ and must not be freed or modifed.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <return>
/// the name of the stock item for @button.
/// </return>

	public static string GetStockId(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_stock_id(button);
	}

/// <summary>
/// <para>
/// Returns whether underscores in the label property are used as mnemonics
/// on menu items on the overflow menu. See gtk_tool_button_set_use_underline().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <return>
/// %TRUE if underscores in the label property are used as
/// mnemonics on menu items on the overflow menu.
/// </return>

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_use_underline(button);
	}

/// <summary>
/// <para>
/// Sets the icon for the tool button from a named themed icon.
/// See the docs for #GtkIconTheme for more details.
/// The #GtkToolButton:icon-name property only has an effect if not
/// overridden by non-%NULL #GtkToolButton:label-widget,
/// #GtkToolButton:icon-widget and #GtkToolButton:stock-id properties.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <param name="icon_name">
/// the name of the themed icon
/// </param>

	public static T SetIconName<T>(this T button, string icon_name) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_icon_name(button, icon_name);
		return button;
	}

/// <summary>
/// <para>
/// Sets @icon as the widget used as icon on @button. If @icon_widget is
/// %NULL the icon is determined by the #GtkToolButton:stock-id property. If the
/// #GtkToolButton:stock-id property is also %NULL, @button will not have an icon.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <param name="icon_widget">
/// the widget used as icon, or %NULL
/// </param>

	public static T SetIconWidget<T>(this T button, MentorLake.Gtk.GtkWidgetHandle icon_widget) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_icon_widget(button, icon_widget);
		return button;
	}

/// <summary>
/// <para>
/// Sets @label as the label used for the tool button. The #GtkToolButton:label
/// property only has an effect if not overridden by a non-%NULL
/// #GtkToolButton:label-widget property. If both the #GtkToolButton:label-widget
/// and #GtkToolButton:label properties are %NULL, the label is determined by the
/// #GtkToolButton:stock-id property. If the #GtkToolButton:stock-id property is
/// also %NULL, @button will not have a label.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <param name="label">
/// a string that will be used as label, or %NULL.
/// </param>

	public static T SetLabel<T>(this T button, string label) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_label(button, label);
		return button;
	}

/// <summary>
/// <para>
/// Sets @label_widget as the widget that will be used as the label
/// for @button. If @label_widget is %NULL the #GtkToolButton:label property is used
/// as label. If #GtkToolButton:label is also %NULL, the label in the stock item
/// determined by the #GtkToolButton:stock-id property is used as label. If
/// #GtkToolButton:stock-id is also %NULL, @button does not have a label.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <param name="label_widget">
/// the widget used as label, or %NULL
/// </param>

	public static T SetLabelWidget<T>(this T button, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_label_widget(button, label_widget);
		return button;
	}

/// <summary>
/// <para>
/// Sets the name of the stock item. See gtk_tool_button_new_from_stock().
/// The stock_id property only has an effect if not overridden by non-%NULL
/// #GtkToolButton:label-widget and #GtkToolButton:icon-widget properties.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <param name="stock_id">
/// a name of a stock item, or %NULL
/// </param>

	public static T SetStockId<T>(this T button, string stock_id) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_stock_id(button, stock_id);
		return button;
	}

/// <summary>
/// <para>
/// If set, an underline in the label property indicates that the next character
/// should be used for the mnemonic accelerator key in the overflow menu. For
/// example, if the label property is “_Open” and @use_underline is %TRUE,
/// the label on the tool button will be “Open” and the item on the overflow
/// menu will have an underlined “O”.
/// </para>
/// <para>
/// Labels shown on tool buttons never have mnemonics on them; this property
/// only affects the menu item on the overflow menu.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkToolButton
/// </param>
/// <param name="use_underline">
/// whether the button label has the form “_Open”
/// </param>

	public static T SetUseUnderline<T>(this T button, bool use_underline) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_use_underline(button, use_underline);
		return button;
	}

}

internal class GtkToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToolButtonHandle gtk_tool_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle icon_widget, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToolButtonHandle gtk_tool_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_button_get_icon_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_button_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_button_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_icon_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle icon_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, bool use_underline);

}
