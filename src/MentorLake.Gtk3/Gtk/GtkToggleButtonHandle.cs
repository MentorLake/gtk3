namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkToggleButton is a #GtkButton which will remain “pressed-in” when
/// clicked. Clicking again will cause the toggle button to return to its
/// normal state.
/// </para>
/// <para>
/// A toggle button is created by calling either gtk_toggle_button_new() or
/// gtk_toggle_button_new_with_label(). If using the former, it is advisable to
/// pack a widget, (such as a #GtkLabel and/or a #GtkImage), into the toggle
/// button’s container. (See #GtkButton for more information).
/// </para>
/// <para>
/// The state of a #GtkToggleButton can be set specifically using
/// gtk_toggle_button_set_active(), and retrieved using
/// gtk_toggle_button_get_active().
/// </para>
/// <para>
/// To simply switch the state of a toggle button, use gtk_toggle_button_toggled().
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkToggleButton has a single CSS node with name button. To differentiate
/// it from a plain #GtkButton, it gets the .toggle style class.
/// </para>
/// <para>
/// ## Creating two #GtkToggleButton widgets.
/// </para>
/// <code>
/// static void output_state (GtkToggleButton *source, gpointer user_data) {
/// static void output_state (GtkToggleButton *source, gpointer user_data) {
///   printf (&quot;Active: %d\n&quot;, gtk_toggle_button_get_active (source));
/// }
/// 
/// void make_toggles (void) {
///   GtkWidget *window, *toggle1, *toggle2;
///   GtkWidget *box;
///   const char *text;
/// 
///   window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///   box = gtk_box_new (GTK_ORIENTATION_VERTICAL, 12);
/// 
///   text = &quot;Hi, I’m a toggle button.&quot;;
///   toggle1 = gtk_toggle_button_new_with_label (text);
/// 
///   // Makes this toggle button invisible
///   gtk_toggle_button_set_mode (GTK_TOGGLE_BUTTON (toggle1),
///                               TRUE);
/// 
///   g_signal_connect (toggle1, &quot;toggled&quot;,
///                     G_CALLBACK (output_state),
///                     NULL);
///   gtk_container_add (GTK_CONTAINER (box), toggle1);
/// 
///   text = &quot;Hi, I’m a toggle button.&quot;;
///   toggle2 = gtk_toggle_button_new_with_label (text);
///   gtk_toggle_button_set_mode (GTK_TOGGLE_BUTTON (toggle2),
///                               FALSE);
///   g_signal_connect (toggle2, &quot;toggled&quot;,
///                     G_CALLBACK (output_state),
///                     NULL);
///   gtk_container_add (GTK_CONTAINER (box), toggle2);
/// 
///   gtk_container_add (GTK_CONTAINER (window), box);
///   gtk_widget_show_all (window);
/// }
/// </code>
/// </summary>

public class GtkToggleButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new toggle button. A widget should be packed into the button, as in gtk_button_new().
/// </para>
/// </summary>

/// <return>
/// a new toggle button.
/// </return>

	public static MentorLake.Gtk.GtkToggleButtonHandle New()
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_new();
	}

/// <summary>
/// <para>
/// Creates a new toggle button with a text label.
/// </para>
/// </summary>

/// <param name="label">
/// a string containing the message to be placed in the toggle button.
/// </param>
/// <return>
/// a new toggle button.
/// </return>

	public static MentorLake.Gtk.GtkToggleButtonHandle NewWithLabel(string label)
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_new_with_label(label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkToggleButton containing a label. The label
/// will be created using gtk_label_new_with_mnemonic(), so underscores
/// in @label indicate the mnemonic for the button.
/// </para>
/// </summary>

/// <param name="label">
/// the text of the button, with an underscore in front of the
///         mnemonic character
/// </param>
/// <return>
/// a new #GtkToggleButton
/// </return>

	public static MentorLake.Gtk.GtkToggleButtonHandle NewWithMnemonic(string label)
	{
		return GtkToggleButtonHandleExterns.gtk_toggle_button_new_with_mnemonic(label);
	}

}
public static class GtkToggleButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// Should be connected if you wish to perform an action whenever the
/// #GtkToggleButton&apos;s state is changed.
/// </para>
/// </summary>

	public static IObservable<GtkToggleButtonHandleSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToggleButtonHandleSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleButtonHandleSignalDelegates.toggled handler = ( MentorLake.Gtk.GtkToggleButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleButtonHandleSignalStructs.ToggledSignal()
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

public static class GtkToggleButtonHandleSignalStructs
{

public class ToggledSignal
{

	public MentorLake.Gtk.GtkToggleButtonHandle Self;

	public IntPtr UserData;
}
}

public static class GtkToggleButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// Should be connected if you wish to perform an action whenever the
/// #GtkToggleButton&apos;s state is changed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle self, IntPtr user_data);

}


public static class GtkToggleButtonHandleExtensions
{
/// <summary>
/// <para>
/// Queries a #GtkToggleButton and returns its current state. Returns %TRUE if
/// the toggle button is pressed in and %FALSE if it is raised.
/// </para>
/// </summary>

/// <param name="toggle_button">
/// a #GtkToggleButton.
/// </param>
/// <return>
/// a #gboolean value.
/// </return>

	public static bool GetActive(this MentorLake.Gtk.GtkToggleButtonHandle toggle_button)
	{
		if (toggle_button.IsInvalid) throw new Exception("Invalid handle (GtkToggleButtonHandle)");
		return GtkToggleButtonHandleExterns.gtk_toggle_button_get_active(toggle_button);
	}

/// <summary>
/// <para>
/// Gets the value set by gtk_toggle_button_set_inconsistent().
/// </para>
/// </summary>

/// <param name="toggle_button">
/// a #GtkToggleButton
/// </param>
/// <return>
/// %TRUE if the button is displayed as inconsistent, %FALSE otherwise
/// </return>

	public static bool GetInconsistent(this MentorLake.Gtk.GtkToggleButtonHandle toggle_button)
	{
		if (toggle_button.IsInvalid) throw new Exception("Invalid handle (GtkToggleButtonHandle)");
		return GtkToggleButtonHandleExterns.gtk_toggle_button_get_inconsistent(toggle_button);
	}

/// <summary>
/// <para>
/// Retrieves whether the button is displayed as a separate indicator
/// and label. See gtk_toggle_button_set_mode().
/// </para>
/// </summary>

/// <param name="toggle_button">
/// a #GtkToggleButton
/// </param>
/// <return>
/// %TRUE if the togglebutton is drawn as a separate indicator
///   and label.
/// </return>

	public static bool GetMode(this MentorLake.Gtk.GtkToggleButtonHandle toggle_button)
	{
		if (toggle_button.IsInvalid) throw new Exception("Invalid handle (GtkToggleButtonHandle)");
		return GtkToggleButtonHandleExterns.gtk_toggle_button_get_mode(toggle_button);
	}

/// <summary>
/// <para>
/// Sets the status of the toggle button. Set to %TRUE if you want the
/// GtkToggleButton to be “pressed in”, and %FALSE to raise it.
/// This action causes the #GtkToggleButton::toggled signal and the
/// #GtkButton::clicked signal to be emitted.
/// </para>
/// </summary>

/// <param name="toggle_button">
/// a #GtkToggleButton.
/// </param>
/// <param name="is_active">
/// %TRUE or %FALSE.
/// </param>

	public static T SetActive<T>(this T toggle_button, bool is_active) where T : GtkToggleButtonHandle
	{
		if (toggle_button.IsInvalid) throw new Exception("Invalid handle (GtkToggleButtonHandle)");
		GtkToggleButtonHandleExterns.gtk_toggle_button_set_active(toggle_button, is_active);
		return toggle_button;
	}

/// <summary>
/// <para>
/// If the user has selected a range of elements (such as some text or
/// spreadsheet cells) that are affected by a toggle button, and the
/// current values in that range are inconsistent, you may want to
/// display the toggle in an “in between” state. This function turns on
/// “in between” display.  Normally you would turn off the inconsistent
/// state again if the user toggles the toggle button. This has to be
/// done manually, gtk_toggle_button_set_inconsistent() only affects
/// visual appearance, it doesn’t affect the semantics of the button.
/// </para>
/// </summary>

/// <param name="toggle_button">
/// a #GtkToggleButton
/// </param>
/// <param name="setting">
/// %TRUE if state is inconsistent
/// </param>

	public static T SetInconsistent<T>(this T toggle_button, bool setting) where T : GtkToggleButtonHandle
	{
		if (toggle_button.IsInvalid) throw new Exception("Invalid handle (GtkToggleButtonHandle)");
		GtkToggleButtonHandleExterns.gtk_toggle_button_set_inconsistent(toggle_button, setting);
		return toggle_button;
	}

/// <summary>
/// <para>
/// Sets whether the button is displayed as a separate indicator and label.
/// You can call this function on a checkbutton or a radiobutton with
/// @draw_indicator = %FALSE to make the button look like a normal button.
/// </para>
/// <para>
/// This can be used to create linked strip of buttons that work like
/// a #GtkStackSwitcher.
/// </para>
/// <para>
/// This function only affects instances of classes like #GtkCheckButton
/// and #GtkRadioButton that derive from #GtkToggleButton,
/// not instances of #GtkToggleButton itself.
/// </para>
/// </summary>

/// <param name="toggle_button">
/// a #GtkToggleButton
/// </param>
/// <param name="draw_indicator">
/// if %TRUE, draw the button as a separate indicator
/// and label; if %FALSE, draw the button like a normal button
/// </param>

	public static T SetMode<T>(this T toggle_button, bool draw_indicator) where T : GtkToggleButtonHandle
	{
		if (toggle_button.IsInvalid) throw new Exception("Invalid handle (GtkToggleButtonHandle)");
		GtkToggleButtonHandleExterns.gtk_toggle_button_set_mode(toggle_button, draw_indicator);
		return toggle_button;
	}

/// <summary>
/// <para>
/// Emits the #GtkToggleButton::toggled signal on the
/// #GtkToggleButton. There is no good reason for an
/// application ever to call this function.
/// </para>
/// </summary>

/// <param name="toggle_button">
/// a #GtkToggleButton.
/// </param>

	public static T Toggled<T>(this T toggle_button) where T : GtkToggleButtonHandle
	{
		if (toggle_button.IsInvalid) throw new Exception("Invalid handle (GtkToggleButtonHandle)");
		GtkToggleButtonHandleExterns.gtk_toggle_button_toggled(toggle_button);
		return toggle_button;
	}

}

internal class GtkToggleButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToggleButtonHandle gtk_toggle_button_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToggleButtonHandle gtk_toggle_button_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToggleButtonHandle gtk_toggle_button_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_button_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_button_get_inconsistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_toggle_button_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button, bool is_active);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_set_inconsistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button, bool draw_indicator);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_toggle_button_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToggleButtonHandle>))] MentorLake.Gtk.GtkToggleButtonHandle toggle_button);

}
