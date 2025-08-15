namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkSpinButton is an ideal way to allow the user to set the value of
/// some attribute. Rather than having to directly type a number into a
/// #GtkEntry, GtkSpinButton allows the user to click on one of two arrows
/// to increment or decrement the displayed value. A value can still be
/// typed in, with the bonus that it can be checked to ensure it is in a
/// given range.
/// </para>
/// <para>
/// The main properties of a GtkSpinButton are through an adjustment.
/// See the #GtkAdjustment section for more details about an adjustment&apos;s
/// properties. Note that GtkSpinButton will by default make its entry
/// large enough to accomodate the lower and upper bounds of the adjustment,
/// which can lead to surprising results. Best practice is to set both
/// the #GtkEntry:width-chars and #GtkEntry:max-width-chars poperties
/// to the desired number of characters to display in the entry.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// spinbutton.horizontal
/// spinbutton.horizontal
/// ├── undershoot.left
/// ├── undershoot.right
/// ├── entry
/// │   ╰── ...
/// ├── button.down
/// ╰── button.up
/// </code>
/// <code>
/// spinbutton.vertical
/// spinbutton.vertical
/// ├── undershoot.left
/// ├── undershoot.right
/// ├── button.up
/// ├── entry
/// │   ╰── ...
/// ╰── button.down
/// </code>
/// <para>
/// GtkSpinButtons main CSS node has the name spinbutton. It creates subnodes
/// for the entry and the two buttons, with these names. The button nodes have
/// the style classes .up and .down. The GtkEntry subnodes (if present) are put
/// below the entry node. The orientation of the spin button is reflected in
/// the .vertical or .horizontal style class on the main node.
/// </para>
/// <para>
/// ## Using a GtkSpinButton to get an integer
/// </para>
/// <code>
/// // Provides a function to retrieve an integer value from a GtkSpinButton
/// // Provides a function to retrieve an integer value from a GtkSpinButton
/// // and creates a spin button to model percentage values.
/// 
/// gint
/// grab_int_value (GtkSpinButton *button,
///                 gpointer       user_data)
/// {
///   return gtk_spin_button_get_value_as_int (button);
/// }
/// 
/// void
/// create_integer_spin_button (void)
/// {
/// 
///   GtkWidget *window, *button;
///   GtkAdjustment *adjustment;
/// 
///   adjustment = gtk_adjustment_new (50.0, 0.0, 100.0, 1.0, 5.0, 0.0);
/// 
///   window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///   gtk_container_set_border_width (GTK_CONTAINER (window), 5);
/// 
///   // creates the spinbutton, with no decimal places
///   button = gtk_spin_button_new (adjustment, 1.0, 0);
///   gtk_container_add (GTK_CONTAINER (window), button);
/// 
///   gtk_widget_show_all (window);
/// }
/// </code>
/// <para>
/// ## Using a GtkSpinButton to get a floating point value
/// </para>
/// <code>
/// // Provides a function to retrieve a floating point value from a
/// // Provides a function to retrieve a floating point value from a
/// // GtkSpinButton, and creates a high precision spin button.
/// 
/// gfloat
/// grab_float_value (GtkSpinButton *button,
///                   gpointer       user_data)
/// {
///   return gtk_spin_button_get_value (button);
/// }
/// 
/// void
/// create_floating_spin_button (void)
/// {
///   GtkWidget *window, *button;
///   GtkAdjustment *adjustment;
/// 
///   adjustment = gtk_adjustment_new (2.500, 0.0, 5.0, 0.001, 0.1, 0.0);
/// 
///   window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///   gtk_container_set_border_width (GTK_CONTAINER (window), 5);
/// 
///   // creates the spinbutton, with three decimal places
///   button = gtk_spin_button_new (adjustment, 0.001, 3);
///   gtk_container_add (GTK_CONTAINER (window), button);
/// 
///   gtk_widget_show_all (window);
/// }
/// </code>
/// </summary>

public class GtkSpinButtonHandle : GtkEntryHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkEditableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkSpinButton.
/// </para>
/// </summary>

/// <param name="adjustment">
/// the #GtkAdjustment object that this spin
///     button should use, or %NULL
/// </param>
/// <param name="climb_rate">
/// specifies by how much the rate of change in the value will
///     accelerate if you continue to hold down an up/down button or arrow key
/// </param>
/// <param name="digits">
/// the number of decimal places to display
/// </param>
/// <return>
/// The new spin button as a #GtkWidget
/// </return>

	public static MentorLake.Gtk.GtkSpinButtonHandle New(MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits)
	{
		return GtkSpinButtonHandleExterns.gtk_spin_button_new(adjustment, climb_rate, digits);
	}

/// <summary>
/// <para>
/// This is a convenience constructor that allows creation of a numeric
/// #GtkSpinButton without manually creating an adjustment. The value is
/// initially set to the minimum value and a page increment of 10 * @step
/// is the default. The precision of the spin button is equivalent to the
/// precision of @step.
/// </para>
/// <para>
/// Note that the way in which the precision is derived works best if @step
/// is a power of ten. If the resulting precision is not suitable for your
/// needs, use gtk_spin_button_set_digits() to correct it.
/// </para>
/// </summary>

/// <param name="min">
/// Minimum allowable value
/// </param>
/// <param name="max">
/// Maximum allowable value
/// </param>
/// <param name="step">
/// Increment added or subtracted by spinning the widget
/// </param>
/// <return>
/// The new spin button as a #GtkWidget
/// </return>

	public static MentorLake.Gtk.GtkSpinButtonHandle NewWithRange(double min, double max, double step)
	{
		return GtkSpinButtonHandleExterns.gtk_spin_button_new_with_range(min, max, step);
	}

}
public static class GtkSpinButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::change-value signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a value change.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal are Up/Down and PageUp and/PageDown.
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.ChangeValueSignal> Signal_ChangeValue(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.ChangeValueSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.change_value handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  MentorLake.Gtk.GtkScrollType scroll,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.ChangeValueSignal()
				{
					Self = self, Scroll = scroll, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "change-value", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::input signal can be used to influence the conversion of
/// the users input into a double value. The signal handler is
/// expected to use gtk_entry_get_text() to retrieve the text of
/// the entry and set @new_value to the new value.
/// </para>
/// <para>
/// The default conversion uses g_strtod().
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.InputSignal> Signal_Input(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.InputSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.input handler = ( MentorLake.Gtk.GtkSpinButtonHandle self, out double new_value,  IntPtr user_data) =>
			{
				new_value = default;

				var signalStruct = new GtkSpinButtonHandleSignalStructs.InputSignal()
				{
					Self = self, NewValue = new_value, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "input", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::output signal can be used to change to formatting
/// of the value that is displayed in the spin buttons entry.
/// <code>
/// // show leading zeros
/// // show leading zeros
/// static gboolean
/// on_output (GtkSpinButton *spin,
///            gpointer       data)
/// {
///    GtkAdjustment *adjustment;
///    gchar *text;
///    int value;
/// 
///    adjustment = gtk_spin_button_get_adjustment (spin);
///    value = (int)gtk_adjustment_get_value (adjustment);
///    text = g_strdup_printf (&quot;%02d&quot;, value);
///    gtk_entry_set_text (GTK_ENTRY (spin), text);
///    g_free (text);
/// 
///    return TRUE;
/// }
/// </code>
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.OutputSignal> Signal_Output(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.OutputSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.output handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.OutputSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "output", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::value-changed signal is emitted when the value represented by
/// @spinbutton changes. Also see the #GtkSpinButton::output signal.
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.value_changed handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.ValueChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "value-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::wrapped signal is emitted right after the spinbutton wraps
/// from its maximum to minimum value or vice-versa.
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.WrappedSignal> Signal_Wrapped(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.WrappedSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.wrapped handler = ( MentorLake.Gtk.GtkSpinButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.WrappedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "wrapped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is a sign for the cell renderer to update its
/// value from the @cell_editable.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing, e.g.
/// #GtkEntry emits this signal when the user presses Enter. Typical things to
/// do in a handler for ::editing-done are to capture the edited value,
/// disconnect the @cell_editable from signals on the #GtkCellRenderer, etc.
/// </para>
/// <para>
/// gtk_cell_editable_editing_done() is a convenience method
/// for emitting #GtkCellEditable::editing-done.
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.EditingDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "editing-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is meant to indicate that the cell is finished
/// editing, and the @cell_editable widget is being removed and may
/// subsequently be destroyed.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing. It must
/// be emitted after the #GtkCellEditable::editing-done signal,
/// to give the cell renderer a chance to update the cell&apos;s value
/// before the widget is removed.
/// </para>
/// <para>
/// gtk_cell_editable_remove_widget() is a convenience method
/// for emitting #GtkCellEditable::remove-widget.
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.RemoveWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::changed signal is emitted at the end of a single
/// user-visible operation on the contents of the #GtkEditable.
/// </para>
/// <para>
/// E.g., a paste operation that replaces the contents of the
/// selection will cause only one signal emission (even though it
/// is implemented by first deleting the selection, then inserting
/// the new content, and may cause multiple ::notify::text signals
/// to be emitted).
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when text is deleted from
/// the widget by the user. The default handler for
/// this signal will normally be responsible for deleting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the range of deleted text, or
/// prevent it from being deleted entirely. The @start_pos
/// and @end_pos parameters are interpreted as for
/// gtk_editable_delete_text().
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.DeleteTextSignal> Signal_DeleteText(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.DeleteTextSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.delete_text handler = ( MentorLake.Gtk.GtkEditableHandle self,  int start_pos,  int end_pos,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.DeleteTextSignal()
				{
					Self = self, StartPos = start_pos, EndPos = end_pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when text is inserted into
/// the widget by the user. The default handler for
/// this signal will normally be responsible for inserting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the inserted text, or prevent
/// it from being inserted entirely.
/// </para>
/// </summary>

	public static IObservable<GtkSpinButtonHandleSignalStructs.InsertTextSignal> Signal_InsertText(this GtkSpinButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkSpinButtonHandleSignalStructs.InsertTextSignal> obs) =>
		{
			GtkSpinButtonHandleSignalDelegates.insert_text handler = ( MentorLake.Gtk.GtkEditableHandle self,  string new_text,  int new_text_length, ref int position,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkSpinButtonHandleSignalStructs.InsertTextSignal()
				{
					Self = self, NewText = new_text, NewTextLength = new_text_length, Position = position, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkSpinButtonHandleSignalStructs
{

public class ChangeValueSignal
{

	public MentorLake.Gtk.GtkSpinButtonHandle Self;
/// <summary>
/// <para>
/// a #GtkScrollType to specify the speed and amount of change
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkScrollType Scroll;

	public IntPtr UserData;
}

public class InputSignal
{

	public MentorLake.Gtk.GtkSpinButtonHandle Self;
/// <summary>
/// <para>
/// return location for the new value
/// </para>
/// </summary>

	public double NewValue;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE for a successful conversion, %FALSE if the input
///     was not handled, and %GTK_INPUT_ERROR if the conversion failed.
/// </para>
/// </summary>

	public int ReturnValue;
}

public class OutputSignal
{

	public MentorLake.Gtk.GtkSpinButtonHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the value has been displayed
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class ValueChangedSignal
{

	public MentorLake.Gtk.GtkSpinButtonHandle Self;

	public IntPtr UserData;
}

public class WrappedSignal
{

	public MentorLake.Gtk.GtkSpinButtonHandle Self;

	public IntPtr UserData;
}

public class EditingDoneSignal
{

	public MentorLake.Gtk.GtkCellEditableHandle Self;

	public IntPtr UserData;
}

public class RemoveWidgetSignal
{

	public MentorLake.Gtk.GtkCellEditableHandle Self;

	public IntPtr UserData;
}

public class ChangedSignal
{

	public MentorLake.Gtk.GtkEditableHandle Self;

	public IntPtr UserData;
}

public class DeleteTextSignal
{

	public MentorLake.Gtk.GtkEditableHandle Self;
/// <summary>
/// <para>
/// the starting position
/// </para>
/// </summary>

	public int StartPos;
/// <summary>
/// <para>
/// the end position
/// </para>
/// </summary>

	public int EndPos;

	public IntPtr UserData;
}

public class InsertTextSignal
{

	public MentorLake.Gtk.GtkEditableHandle Self;
/// <summary>
/// <para>
/// the new text to insert
/// </para>
/// </summary>

	public string NewText;
/// <summary>
/// <para>
/// the length of the new text, in bytes,
///     or -1 if new_text is nul-terminated
/// </para>
/// </summary>

	public int NewTextLength;
/// <summary>
/// <para>
/// the position, in characters,
///     at which to insert the new text. this is an in-out
///     parameter.  After the signal emission is finished, it
///     should point after the newly inserted text.
/// </para>
/// </summary>

	public int Position;

	public IntPtr UserData;
}
}

public static class GtkSpinButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::change-value signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user initiates a value change.
/// </para>
/// <para>
/// Applications should not connect to it, but may emit it with
/// g_signal_emit_by_name() if they need to control the cursor
/// programmatically.
/// </para>
/// <para>
/// The default bindings for this signal are Up/Down and PageUp and/PageDown.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="scroll">
/// a #GtkScrollType to specify the speed and amount of change
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void change_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, MentorLake.Gtk.GtkScrollType scroll, IntPtr user_data);


/// <summary>
/// <para>
/// The ::input signal can be used to influence the conversion of
/// the users input into a double value. The signal handler is
/// expected to use gtk_entry_get_text() to retrieve the text of
/// the entry and set @new_value to the new value.
/// </para>
/// <para>
/// The default conversion uses g_strtod().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="new_value">
/// return location for the new value
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE for a successful conversion, %FALSE if the input
///     was not handled, and %GTK_INPUT_ERROR if the conversion failed.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int input([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, out double new_value, IntPtr user_data);


/// <summary>
/// <para>
/// The ::output signal can be used to change to formatting
/// of the value that is displayed in the spin buttons entry.
/// <code>
/// // show leading zeros
/// // show leading zeros
/// static gboolean
/// on_output (GtkSpinButton *spin,
///            gpointer       data)
/// {
///    GtkAdjustment *adjustment;
///    gchar *text;
///    int value;
/// 
///    adjustment = gtk_spin_button_get_adjustment (spin);
///    value = (int)gtk_adjustment_get_value (adjustment);
///    text = g_strdup_printf (&quot;%02d&quot;, value);
///    gtk_entry_set_text (GTK_ENTRY (spin), text);
///    g_free (text);
/// 
///    return TRUE;
/// }
/// </code>
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the value has been displayed
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool output([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::value-changed signal is emitted when the value represented by
/// @spinbutton changes. Also see the #GtkSpinButton::output signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::wrapped signal is emitted right after the spinbutton wraps
/// from its maximum to minimum value or vice-versa.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void wrapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is a sign for the cell renderer to update its
/// value from the @cell_editable.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing, e.g.
/// #GtkEntry emits this signal when the user presses Enter. Typical things to
/// do in a handler for ::editing-done are to capture the edited value,
/// disconnect the @cell_editable from signals on the #GtkCellRenderer, etc.
/// </para>
/// <para>
/// gtk_cell_editable_editing_done() is a convenience method
/// for emitting #GtkCellEditable::editing-done.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is meant to indicate that the cell is finished
/// editing, and the @cell_editable widget is being removed and may
/// subsequently be destroyed.
/// </para>
/// <para>
/// Implementations of #GtkCellEditable are responsible for
/// emitting this signal when they are done editing. It must
/// be emitted after the #GtkCellEditable::editing-done signal,
/// to give the cell renderer a chance to update the cell&apos;s value
/// before the widget is removed.
/// </para>
/// <para>
/// gtk_cell_editable_remove_widget() is a convenience method
/// for emitting #GtkCellEditable::remove-widget.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::changed signal is emitted at the end of a single
/// user-visible operation on the contents of the #GtkEditable.
/// </para>
/// <para>
/// E.g., a paste operation that replaces the contents of the
/// selection will cause only one signal emission (even though it
/// is implemented by first deleting the selection, then inserting
/// the new content, and may cause multiple ::notify::text signals
/// to be emitted).
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when text is deleted from
/// the widget by the user. The default handler for
/// this signal will normally be responsible for deleting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the range of deleted text, or
/// prevent it from being deleted entirely. The @start_pos
/// and @end_pos parameters are interpreted as for
/// gtk_editable_delete_text().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="start_pos">
/// the starting position
/// </param>
/// <param name="end_pos">
/// the end position
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, int start_pos, int end_pos, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when text is inserted into
/// the widget by the user. The default handler for
/// this signal will normally be responsible for inserting
/// the text, so by connecting to this signal and then
/// stopping the signal with g_signal_stop_emission(), it
/// is possible to modify the inserted text, or prevent
/// it from being inserted entirely.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="new_text">
/// the new text to insert
/// </param>
/// <param name="new_text_length">
/// the length of the new text, in bytes,
///     or -1 if new_text is nul-terminated
/// </param>
/// <param name="position">
/// the position, in characters,
///     at which to insert the new text. this is an in-out
///     parameter.  After the signal emission is finished, it
///     should point after the newly inserted text.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle self, string new_text, int new_text_length, ref int position, IntPtr user_data);

}


public static class GtkSpinButtonHandleExtensions
{
/// <summary>
/// <para>
/// Changes the properties of an existing spin button. The adjustment,
/// climb rate, and number of decimal places are updated accordingly.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="adjustment">
/// a #GtkAdjustment to replace the spin button’s
///     existing adjustment, or %NULL to leave its current adjustment unchanged
/// </param>
/// <param name="climb_rate">
/// the new climb rate
/// </param>
/// <param name="digits">
/// the number of decimal places to display in the spin button
/// </param>

	public static T Configure<T>(this T spin_button, MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_configure(spin_button, adjustment, climb_rate, digits);
		return spin_button;
	}

/// <summary>
/// <para>
/// Get the adjustment associated with a #GtkSpinButton
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// the #GtkAdjustment of @spin_button
/// </return>

	public static MentorLake.Gtk.GtkAdjustmentHandle GetAdjustment(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_adjustment(spin_button);
	}

/// <summary>
/// <para>
/// Fetches the precision of @spin_button. See gtk_spin_button_set_digits().
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// the current precision
/// </return>

	public static uint GetDigits(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_digits(spin_button);
	}

/// <summary>
/// <para>
/// Gets the current step and page the increments used by @spin_button. See
/// gtk_spin_button_set_increments().
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="step">
/// location to store step increment, or %NULL
/// </param>
/// <param name="page">
/// location to store page increment, or %NULL
/// </param>

	public static T GetIncrements<T>(this T spin_button, out double step, out double page) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_get_increments(spin_button, out step, out page);
		return spin_button;
	}

/// <summary>
/// <para>
/// Returns whether non-numeric text can be typed into the spin button.
/// See gtk_spin_button_set_numeric().
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// %TRUE if only numeric text can be entered
/// </return>

	public static bool GetNumeric(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_numeric(spin_button);
	}

/// <summary>
/// <para>
/// Gets the range allowed for @spin_button.
/// See gtk_spin_button_set_range().
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="min">
/// location to store minimum allowed value, or %NULL
/// </param>
/// <param name="max">
/// location to store maximum allowed value, or %NULL
/// </param>

	public static T GetRange<T>(this T spin_button, out double min, out double max) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_get_range(spin_button, out min, out max);
		return spin_button;
	}

/// <summary>
/// <para>
/// Returns whether the values are corrected to the nearest step.
/// See gtk_spin_button_set_snap_to_ticks().
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// %TRUE if values are snapped to the nearest step
/// </return>

	public static bool GetSnapToTicks(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_snap_to_ticks(spin_button);
	}

/// <summary>
/// <para>
/// Gets the update behavior of a spin button.
/// See gtk_spin_button_set_update_policy().
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// the current update policy
/// </return>

	public static MentorLake.Gtk.GtkSpinButtonUpdatePolicy GetUpdatePolicy(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_update_policy(spin_button);
	}

/// <summary>
/// <para>
/// Get the value in the @spin_button.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// the value of @spin_button
/// </return>

	public static double GetValue(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_value(spin_button);
	}

/// <summary>
/// <para>
/// Get the value @spin_button represented as an integer.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// the value of @spin_button
/// </return>

	public static int GetValueAsInt(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_value_as_int(spin_button);
	}

/// <summary>
/// <para>
/// Returns whether the spin button’s value wraps around to the
/// opposite limit when the upper or lower limit of the range is
/// exceeded. See gtk_spin_button_set_wrap().
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <return>
/// %TRUE if the spin button wraps around
/// </return>

	public static bool GetWrap(this MentorLake.Gtk.GtkSpinButtonHandle spin_button)
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		return GtkSpinButtonHandleExterns.gtk_spin_button_get_wrap(spin_button);
	}

/// <summary>
/// <para>
/// Replaces the #GtkAdjustment associated with @spin_button.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="adjustment">
/// a #GtkAdjustment to replace the existing adjustment
/// </param>

	public static T SetAdjustment<T>(this T spin_button, MentorLake.Gtk.GtkAdjustmentHandle adjustment) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_adjustment(spin_button, adjustment);
		return spin_button;
	}

/// <summary>
/// <para>
/// Set the precision to be displayed by @spin_button. Up to 20 digit precision
/// is allowed.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="digits">
/// the number of digits after the decimal point to be displayed for the spin button’s value
/// </param>

	public static T SetDigits<T>(this T spin_button, uint digits) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_digits(spin_button, digits);
		return spin_button;
	}

/// <summary>
/// <para>
/// Sets the step and page increments for spin_button.  This affects how
/// quickly the value changes when the spin button’s arrows are activated.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="step">
/// increment applied for a button 1 press.
/// </param>
/// <param name="page">
/// increment applied for a button 2 press.
/// </param>

	public static T SetIncrements<T>(this T spin_button, double step, double page) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_increments(spin_button, step, page);
		return spin_button;
	}

/// <summary>
/// <para>
/// Sets the flag that determines if non-numeric text can be typed
/// into the spin button.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="numeric">
/// flag indicating if only numeric entry is allowed
/// </param>

	public static T SetNumeric<T>(this T spin_button, bool numeric) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_numeric(spin_button, numeric);
		return spin_button;
	}

/// <summary>
/// <para>
/// Sets the minimum and maximum allowable values for @spin_button.
/// </para>
/// <para>
/// If the current value is outside this range, it will be adjusted
/// to fit within the range, otherwise it will remain unchanged.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="min">
/// minimum allowable value
/// </param>
/// <param name="max">
/// maximum allowable value
/// </param>

	public static T SetRange<T>(this T spin_button, double min, double max) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_range(spin_button, min, max);
		return spin_button;
	}

/// <summary>
/// <para>
/// Sets the policy as to whether values are corrected to the
/// nearest step increment when a spin button is activated after
/// providing an invalid value.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="snap_to_ticks">
/// a flag indicating if invalid values should be corrected
/// </param>

	public static T SetSnapToTicks<T>(this T spin_button, bool snap_to_ticks) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_snap_to_ticks(spin_button, snap_to_ticks);
		return spin_button;
	}

/// <summary>
/// <para>
/// Sets the update behavior of a spin button.
/// This determines whether the spin button is always updated
/// or only when a valid value is set.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="policy">
/// a #GtkSpinButtonUpdatePolicy value
/// </param>

	public static T SetUpdatePolicy<T>(this T spin_button, MentorLake.Gtk.GtkSpinButtonUpdatePolicy policy) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_update_policy(spin_button, policy);
		return spin_button;
	}

/// <summary>
/// <para>
/// Sets the value of @spin_button.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="value">
/// the new value
/// </param>

	public static T SetValue<T>(this T spin_button, double value) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_value(spin_button, value);
		return spin_button;
	}

/// <summary>
/// <para>
/// Sets the flag that determines if a spin button value wraps
/// around to the opposite limit when the upper or lower limit
/// of the range is exceeded.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="wrap">
/// a flag indicating if wrapping behavior is performed
/// </param>

	public static T SetWrap<T>(this T spin_button, bool wrap) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_set_wrap(spin_button, wrap);
		return spin_button;
	}

/// <summary>
/// <para>
/// Increment or decrement a spin button’s value in a specified
/// direction by a specified amount.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>
/// <param name="direction">
/// a #GtkSpinType indicating the direction to spin
/// </param>
/// <param name="increment">
/// step increment to apply in the specified direction
/// </param>

	public static T Spin<T>(this T spin_button, MentorLake.Gtk.GtkSpinType direction, double increment) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_spin(spin_button, direction, increment);
		return spin_button;
	}

/// <summary>
/// <para>
/// Manually force an update of the spin button.
/// </para>
/// </summary>

/// <param name="spin_button">
/// a #GtkSpinButton
/// </param>

	public static T Update<T>(this T spin_button) where T : GtkSpinButtonHandle
	{
		if (spin_button.IsInvalid) throw new Exception("Invalid handle (GtkSpinButtonHandle)");
		GtkSpinButtonHandleExterns.gtk_spin_button_update(spin_button);
		return spin_button;
	}

}

internal class GtkSpinButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkSpinButtonHandle gtk_spin_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkSpinButtonHandle gtk_spin_button_new_with_range(double min, double max, double step);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_configure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment, double climb_rate, uint digits);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))]
	internal static extern MentorLake.Gtk.GtkAdjustmentHandle gtk_spin_button_get_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_spin_button_get_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_get_increments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, out double step, out double page);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_spin_button_get_numeric([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, out double min, out double max);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_spin_button_get_snap_to_ticks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSpinButtonUpdatePolicy gtk_spin_button_get_update_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_spin_button_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_spin_button_get_value_as_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_spin_button_get_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_adjustment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAdjustmentHandle>))] MentorLake.Gtk.GtkAdjustmentHandle adjustment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_digits([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, uint digits);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_increments([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, double step, double page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_numeric([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, bool numeric);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, double min, double max);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_snap_to_ticks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, bool snap_to_ticks);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_update_policy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, MentorLake.Gtk.GtkSpinButtonUpdatePolicy policy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_set_wrap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, bool wrap);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_spin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button, MentorLake.Gtk.GtkSpinType direction, double increment);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_spin_button_update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSpinButtonHandle>))] MentorLake.Gtk.GtkSpinButtonHandle spin_button);

}
