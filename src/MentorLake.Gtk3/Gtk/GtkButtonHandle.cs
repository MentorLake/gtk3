namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkButton widget is generally used to trigger a callback function that is
/// called when the button is pressed.  The various signals and how to use them
/// are outlined below.
/// </para>
/// <para>
/// The #GtkButton widget can hold any valid child widget.  That is, it can hold
/// almost any other standard #GtkWidget.  The most commonly used child is the
/// #GtkLabel.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkButton has a single CSS node with name button. The node will get the
/// style classes .image-button or .text-button, if the content is just an
/// image or label, respectively. It may also receive the .flat style class.
/// </para>
/// <para>
/// Other style classes that are commonly used with GtkButton include
/// .suggested-action and .destructive-action. In special cases, buttons
/// can be made round by adding the .circular style class.
/// </para>
/// <para>
/// Button-like widgets like #GtkToggleButton, #GtkMenuButton, #GtkVolumeButton,
/// #GtkLockButton, #GtkColorButton, #GtkFontButton or #GtkFileChooserButton use
/// style classes such as .toggle, .popup, .scale, .lock, .color, .font, .file
/// to differentiate themselves from a plain GtkButton.
/// </para>
/// </summary>

public class GtkButtonHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkButton widget. To add a child widget to the button,
/// use gtk_container_add().
/// </para>
/// </summary>

/// <return>
/// The newly created #GtkButton widget.
/// </return>

	public static MentorLake.Gtk.GtkButtonHandle New()
	{
		return GtkButtonHandleExterns.gtk_button_new();
	}

/// <summary>
/// <para>
/// Creates a new button containing an icon from the current icon theme.
/// </para>
/// <para>
/// If the icon name isn’t known, a “broken image” icon will be
/// displayed instead. If the current icon theme is changed, the icon
/// will be updated appropriately.
/// </para>
/// <para>
/// This function is a convenience wrapper around gtk_button_new() and
/// gtk_button_set_image().
/// </para>
/// </summary>

/// <param name="icon_name">
/// an icon name or %NULL
/// </param>
/// <param name="size">
/// an icon size (#GtkIconSize)
/// </param>
/// <return>
/// a new #GtkButton displaying the themed icon
/// </return>

	public static MentorLake.Gtk.GtkButtonHandle NewFromIconName(string icon_name, MentorLake.Gtk.GtkIconSize size)
	{
		return GtkButtonHandleExterns.gtk_button_new_from_icon_name(icon_name, size);
	}

/// <summary>
/// <para>
/// Creates a new #GtkButton containing the image and text from a
/// [stock item][gtkstock].
/// Some stock ids have preprocessor macros like #GTK_STOCK_OK and
/// #GTK_STOCK_APPLY.
/// </para>
/// <para>
/// If @stock_id is unknown, then it will be treated as a mnemonic
/// label (as for gtk_button_new_with_mnemonic()).
/// </para>
/// </summary>

/// <param name="stock_id">
/// the name of the stock item
/// </param>
/// <return>
/// a new #GtkButton
/// </return>

	public static MentorLake.Gtk.GtkButtonHandle NewFromStock(string stock_id)
	{
		return GtkButtonHandleExterns.gtk_button_new_from_stock(stock_id);
	}

/// <summary>
/// <para>
/// Creates a #GtkButton widget with a #GtkLabel child containing the given
/// text.
/// </para>
/// </summary>

/// <param name="label">
/// The text you want the #GtkLabel to hold.
/// </param>
/// <return>
/// The newly created #GtkButton widget.
/// </return>

	public static MentorLake.Gtk.GtkButtonHandle NewWithLabel(string label)
	{
		return GtkButtonHandleExterns.gtk_button_new_with_label(label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkButton containing a label.
/// If characters in @label are preceded by an underscore, they are underlined.
/// If you need a literal underscore character in a label, use “__” (two
/// underscores). The first underlined character represents a keyboard
/// accelerator called a mnemonic.
/// Pressing Alt and that key activates the button.
/// </para>
/// </summary>

/// <param name="label">
/// The text of the button, with an underscore in front of the
///         mnemonic character
/// </param>
/// <return>
/// a new #GtkButton
/// </return>

	public static MentorLake.Gtk.GtkButtonHandle NewWithMnemonic(string label)
	{
		return GtkButtonHandleExterns.gtk_button_new_with_mnemonic(label);
	}

}
public static class GtkButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::activate signal on GtkButton is an action signal and
/// emitting it causes the button to animate press then release.
/// Applications should never connect to this signal, but use the
/// #GtkButton::clicked signal.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the button has been activated (pressed and released).
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the pointer enters the button.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the pointer leaves the button.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the button is pressed.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when the button is released.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The ::activate signal on GtkButton is an action signal and
/// emitting it causes the button to animate press then release.
/// Applications should never connect to this signal, but use the
/// #GtkButton::clicked signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the button has been activated (pressed and released).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the pointer enters the button.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the pointer leaves the button.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the button is pressed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the button is released.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle self, IntPtr user_data);

}


public static class GtkButtonHandleExtensions
{
/// <summary>
/// <para>
/// Emits a #GtkButton::clicked signal to the given #GtkButton.
/// </para>
/// </summary>

/// <param name="button">
/// The #GtkButton you want to send the signal to.
/// </param>

	public static T Clicked<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_clicked(button);
		return button;
	}

/// <summary>
/// <para>
/// Emits a #GtkButton::enter signal to the given #GtkButton.
/// </para>
/// </summary>

/// <param name="button">
/// The #GtkButton you want to send the signal to.
/// </param>

	public static T Enter<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_enter(button);
		return button;
	}

/// <summary>
/// <para>
/// Gets the alignment of the child in the button.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="xalign">
/// return location for horizontal alignment
/// </param>
/// <param name="yalign">
/// return location for vertical alignment
/// </param>

	public static T GetAlignment<T>(this T button, out float xalign, out float yalign) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_get_alignment(button, out xalign, out yalign);
		return button;
	}

/// <summary>
/// <para>
/// Returns whether the button will ignore the #GtkSettings:gtk-button-images
/// setting and always show the image, if available.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// %TRUE if the button will always show the image
/// </return>

	public static bool GetAlwaysShowImage(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_always_show_image(button);
	}

/// <summary>
/// <para>
/// Returns the button’s event window if it is realized, %NULL otherwise.
/// This function should be rarely needed.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// @button’s event window.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetEventWindow(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_event_window(button);
	}

/// <summary>
/// <para>
/// Returns whether the button grabs focus when it is clicked with the mouse.
/// See gtk_button_set_focus_on_click().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// %TRUE if the button grabs focus when it is clicked with
///               the mouse.
/// </return>

	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_focus_on_click(button);
	}

/// <summary>
/// <para>
/// Gets the widget that is currenty set as the image of @button.
/// This may have been explicitly set by gtk_button_set_image()
/// or constructed by gtk_button_new_from_stock().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// a #GtkWidget or %NULL in case
///     there is no image
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetImage(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_image(button);
	}

/// <summary>
/// <para>
/// Gets the position of the image relative to the text
/// inside the button.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// the position
/// </return>

	public static MentorLake.Gtk.GtkPositionType GetImagePosition(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_image_position(button);
	}

/// <summary>
/// <para>
/// Fetches the text from the label of the button, as set by
/// gtk_button_set_label(). If the label text has not
/// been set the return value will be %NULL. This will be the
/// case if you create an empty button with gtk_button_new() to
/// use as a container.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// The text of the label widget. This string is owned
/// by the widget and must not be modified or freed.
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_label(button);
	}

/// <summary>
/// <para>
/// Returns the current relief style of the given #GtkButton.
/// </para>
/// </summary>

/// <param name="button">
/// The #GtkButton you want the #GtkReliefStyle from.
/// </param>
/// <return>
/// The current #GtkReliefStyle
/// </return>

	public static MentorLake.Gtk.GtkReliefStyle GetRelief(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_relief(button);
	}

/// <summary>
/// <para>
/// Returns whether the button label is a stock item.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// %TRUE if the button label is used to
///               select a stock item instead of being
///               used directly as the label text.
/// </return>

	public static bool GetUseStock(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_use_stock(button);
	}

/// <summary>
/// <para>
/// Returns whether an embedded underline in the button label indicates a
/// mnemonic. See gtk_button_set_use_underline ().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <return>
/// %TRUE if an embedded underline in the button label
///               indicates the mnemonic accelerator keys.
/// </return>

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		return GtkButtonHandleExterns.gtk_button_get_use_underline(button);
	}

/// <summary>
/// <para>
/// Emits a #GtkButton::leave signal to the given #GtkButton.
/// </para>
/// </summary>

/// <param name="button">
/// The #GtkButton you want to send the signal to.
/// </param>

	public static T Leave<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_leave(button);
		return button;
	}

/// <summary>
/// <para>
/// Emits a #GtkButton::pressed signal to the given #GtkButton.
/// </para>
/// </summary>

/// <param name="button">
/// The #GtkButton you want to send the signal to.
/// </param>

	public static T Pressed<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_pressed(button);
		return button;
	}

/// <summary>
/// <para>
/// Emits a #GtkButton::released signal to the given #GtkButton.
/// </para>
/// </summary>

/// <param name="button">
/// The #GtkButton you want to send the signal to.
/// </param>

	public static T Released<T>(this T button) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_released(button);
		return button;
	}

/// <summary>
/// <para>
/// Sets the alignment of the child. This property has no effect unless
/// the child is a #GtkMisc or a #GtkAlignment.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="xalign">
/// the horizontal position of the child, 0.0 is left aligned,
///   1.0 is right aligned
/// </param>
/// <param name="yalign">
/// the vertical position of the child, 0.0 is top aligned,
///   1.0 is bottom aligned
/// </param>

	public static T SetAlignment<T>(this T button, float xalign, float yalign) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_alignment(button, xalign, yalign);
		return button;
	}

/// <summary>
/// <para>
/// If %TRUE, the button will ignore the #GtkSettings:gtk-button-images
/// setting and always show the image, if available.
/// </para>
/// <para>
/// Use this property if the button  would be useless or hard to use
/// without the image.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="always_show">
/// %TRUE if the menuitem should always show the image
/// </param>

	public static T SetAlwaysShowImage<T>(this T button, bool always_show) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_always_show_image(button, always_show);
		return button;
	}

/// <summary>
/// <para>
/// Sets whether the button will grab focus when it is clicked with the mouse.
/// Making mouse clicks not grab focus is useful in places like toolbars where
/// you don’t want the keyboard focus removed from the main area of the
/// application.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="focus_on_click">
/// whether the button grabs focus when clicked with the mouse
/// </param>

	public static T SetFocusOnClick<T>(this T button, bool focus_on_click) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_focus_on_click(button, focus_on_click);
		return button;
	}

/// <summary>
/// <para>
/// Set the image of @button to the given widget. The image will be
/// displayed if the label text is %NULL or if
/// #GtkButton:always-show-image is %TRUE. You don’t have to call
/// gtk_widget_show() on @image yourself.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="image">
/// a widget to set as the image for the button, or %NULL to unset
/// </param>

	public static T SetImage<T>(this T button, MentorLake.Gtk.GtkWidgetHandle image) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_image(button, image);
		return button;
	}

/// <summary>
/// <para>
/// Sets the position of the image relative to the text
/// inside the button.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="position">
/// the position
/// </param>

	public static T SetImagePosition<T>(this T button, MentorLake.Gtk.GtkPositionType position) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_image_position(button, position);
		return button;
	}

/// <summary>
/// <para>
/// Sets the text of the label of the button to @str. This text is
/// also used to select the stock item if gtk_button_set_use_stock()
/// is used.
/// </para>
/// <para>
/// This will also clear any previously set labels.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="label">
/// a string
/// </param>

	public static T SetLabel<T>(this T button, string label) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_label(button, label);
		return button;
	}

/// <summary>
/// <para>
/// Sets the relief style of the edges of the given #GtkButton widget.
/// Two styles exist, %GTK_RELIEF_NORMAL and %GTK_RELIEF_NONE.
/// The default style is, as one can guess, %GTK_RELIEF_NORMAL.
/// The deprecated value %GTK_RELIEF_HALF behaves the same as
/// %GTK_RELIEF_NORMAL.
/// </para>
/// </summary>

/// <param name="button">
/// The #GtkButton you want to set relief styles of
/// </param>
/// <param name="relief">
/// The GtkReliefStyle as described above
/// </param>

	public static T SetRelief<T>(this T button, MentorLake.Gtk.GtkReliefStyle relief) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_relief(button, relief);
		return button;
	}

/// <summary>
/// <para>
/// If %TRUE, the label set on the button is used as a
/// stock id to select the stock item for the button.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="use_stock">
/// %TRUE if the button should use a stock item
/// </param>

	public static T SetUseStock<T>(this T button, bool use_stock) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_use_stock(button, use_stock);
		return button;
	}

/// <summary>
/// <para>
/// If true, an underline in the text of the button label indicates
/// the next character should be used for the mnemonic accelerator key.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkButton
/// </param>
/// <param name="use_underline">
/// %TRUE if underlines in the text indicate mnemonics
/// </param>

	public static T SetUseUnderline<T>(this T button, bool use_underline) where T : GtkButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkButtonHandle)");
		GtkButtonHandleExterns.gtk_button_set_use_underline(button, use_underline);
		return button;
	}

}

internal class GtkButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new_from_icon_name(string icon_name, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkButtonHandle gtk_button_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_button_get_event_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_button_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkButtonHandle>))] MentorLake.Gtk.GtkButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
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
