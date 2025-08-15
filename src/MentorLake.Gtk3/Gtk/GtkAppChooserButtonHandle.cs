namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkAppChooserButton is a widget that lets the user select
/// an application. It implements the #GtkAppChooser interface.
/// </para>
/// <para>
/// Initially, a #GtkAppChooserButton selects the first application
/// in its list, which will either be the most-recently used application
/// or, if #GtkAppChooserButton:show-default-item is %TRUE, the
/// default application.
/// </para>
/// <para>
/// The list of applications shown in a #GtkAppChooserButton includes
/// the recommended applications for the given content type. When
/// #GtkAppChooserButton:show-default-item is set, the default application
/// is also included. To let the user chooser other applications,
/// you can set the #GtkAppChooserButton:show-dialog-item property,
/// which allows to open a full #GtkAppChooserDialog.
/// </para>
/// <para>
/// It is possible to add custom items to the list, using
/// gtk_app_chooser_button_append_custom_item(). These items cause
/// the #GtkAppChooserButton::custom-item-activated signal to be
/// emitted when they are selected.
/// </para>
/// <para>
/// To track changes in the selected application, use the
/// #GtkComboBox::changed signal.
/// </para>
/// </summary>

public class GtkAppChooserButtonHandle : GtkComboBoxHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAppChooserButton for applications
/// that can handle content of the given type.
/// </para>
/// </summary>

/// <param name="content_type">
/// the content type to show applications for
/// </param>
/// <return>
/// a newly created #GtkAppChooserButton
/// </return>

	public static MentorLake.Gtk.GtkAppChooserButtonHandle New(string content_type)
	{
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_new(content_type);
	}

}
public static class GtkAppChooserButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when a custom item, previously added with
/// gtk_app_chooser_button_append_custom_item(), is activated from the
/// dropdown menu.
/// </para>
/// </summary>

	public static IObservable<GtkAppChooserButtonHandleSignalStructs.CustomItemActivatedSignal> Signal_CustomItemActivated(this GtkAppChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonHandleSignalStructs.CustomItemActivatedSignal> obs) =>
		{
			GtkAppChooserButtonHandleSignalDelegates.custom_item_activated handler = ( MentorLake.Gtk.GtkAppChooserButtonHandle self,  string item_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonHandleSignalStructs.CustomItemActivatedSignal()
				{
					Self = self, ItemName = item_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "custom-item-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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

	public static IObservable<GtkAppChooserButtonHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkAppChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkAppChooserButtonHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonHandleSignalStructs.EditingDoneSignal()
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

	public static IObservable<GtkAppChooserButtonHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkAppChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkAppChooserButtonHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonHandleSignalStructs.RemoveWidgetSignal()
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
}

public static class GtkAppChooserButtonHandleSignalStructs
{

public class CustomItemActivatedSignal
{

	public MentorLake.Gtk.GtkAppChooserButtonHandle Self;
/// <summary>
/// <para>
/// the name of the activated item
/// </para>
/// </summary>

	public string ItemName;

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
}

public static class GtkAppChooserButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when a custom item, previously added with
/// gtk_app_chooser_button_append_custom_item(), is activated from the
/// dropdown menu.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="item_name">
/// the name of the activated item
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void custom_item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string item_name, IntPtr user_data);


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

}


public static class GtkAppChooserButtonHandleExtensions
{
/// <summary>
/// <para>
/// Appends a custom item to the list of applications that is shown
/// in the popup; the item name must be unique per-widget.
/// Clients can use the provided name as a detail for the
/// #GtkAppChooserButton::custom-item-activated signal, to add a
/// callback for the activation of a particular custom item in the list.
/// See also gtk_app_chooser_button_append_separator().
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <param name="name">
/// the name of the custom item
/// </param>
/// <param name="label">
/// the label for the custom item
/// </param>
/// <param name="icon">
/// the icon for the custom item
/// </param>

	public static T AppendCustomItem<T>(this T self, string name, string label, MentorLake.Gio.GIconHandle icon) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_append_custom_item(self, name, label, icon);
		return self;
	}

/// <summary>
/// <para>
/// Appends a separator to the list of applications that is shown
/// in the popup.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>

	public static T AppendSeparator<T>(this T self) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_append_separator(self);
		return self;
	}

/// <summary>
/// <para>
/// Returns the text to display at the top of the dialog.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <return>
/// the text to display at the top of the dialog,
///     or %NULL, in which case a default text is displayed
/// </return>

	public static string GetHeading(this MentorLake.Gtk.GtkAppChooserButtonHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_get_heading(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooserButton:show-default-item
/// property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <return>
/// the value of #GtkAppChooserButton:show-default-item
/// </return>

	public static bool GetShowDefaultItem(this MentorLake.Gtk.GtkAppChooserButtonHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_get_show_default_item(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooserButton:show-dialog-item
/// property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <return>
/// the value of #GtkAppChooserButton:show-dialog-item
/// </return>

	public static bool GetShowDialogItem(this MentorLake.Gtk.GtkAppChooserButtonHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_get_show_dialog_item(self);
	}

/// <summary>
/// <para>
/// Selects a custom item previously added with
/// gtk_app_chooser_button_append_custom_item().
/// </para>
/// <para>
/// Use gtk_app_chooser_refresh() to bring the selection
/// to its initial state.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <param name="name">
/// the name of the custom item
/// </param>

	public static T SetActiveCustomItem<T>(this T self, string name) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_active_custom_item(self, name);
		return self;
	}

/// <summary>
/// <para>
/// Sets the text to display at the top of the dialog.
/// If the heading is not set, the dialog displays a default text.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <param name="heading">
/// a string containing Pango markup
/// </param>

	public static T SetHeading<T>(this T self, string heading) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_heading(self, heading);
		return self;
	}

/// <summary>
/// <para>
/// Sets whether the dropdown menu of this button should show the
/// default application for the given content type at top.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <param name="setting">
/// the new value for #GtkAppChooserButton:show-default-item
/// </param>

	public static T SetShowDefaultItem<T>(this T self, bool setting) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_show_default_item(self, setting);
		return self;
	}

/// <summary>
/// <para>
/// Sets whether the dropdown menu of this button should show an
/// entry to trigger a #GtkAppChooserDialog.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserButton
/// </param>
/// <param name="setting">
/// the new value for #GtkAppChooserButton:show-dialog-item
/// </param>

	public static T SetShowDialogItem<T>(this T self, bool setting) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_show_dialog_item(self, setting);
		return self;
	}

}

internal class GtkAppChooserButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkAppChooserButtonHandle gtk_app_chooser_button_new(string content_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_append_custom_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string name, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_append_separator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_button_get_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_button_get_show_default_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_button_get_show_dialog_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_active_custom_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string heading);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_show_default_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_show_dialog_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, bool setting);

}
