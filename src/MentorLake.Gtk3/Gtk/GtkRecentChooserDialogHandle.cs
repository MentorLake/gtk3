namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRecentChooserDialog is a dialog box suitable for displaying the recently
/// used documents.  This widgets works by putting a #GtkRecentChooserWidget inside
/// a #GtkDialog.  It exposes the #GtkRecentChooserIface interface, so you can use
/// all the #GtkRecentChooser functions on the recent chooser dialog as well as
/// those for #GtkDialog.
/// </para>
/// <para>
/// Note that #GtkRecentChooserDialog does not have any methods of its own.
/// Instead, you should use the functions that work on a #GtkRecentChooser.
/// </para>
/// <para>
/// ## Typical usage ## {#gtkrecentchooser-typical-usage}
/// </para>
/// <para>
/// In the simplest of cases, you can use the following code to use
/// a #GtkRecentChooserDialog to select a recently used file:
/// </para>
/// <code>
/// GtkWidget *dialog;
/// GtkWidget *dialog;
/// gint res;
/// 
/// dialog = gtk_recent_chooser_dialog_new (&quot;Recent Documents&quot;,
///                                         parent_window,
///                                         _(&quot;_Cancel&quot;),
///                                         GTK_RESPONSE_CANCEL,
///                                         _(&quot;_Open&quot;),
///                                         GTK_RESPONSE_ACCEPT,
///                                         NULL);
/// 
/// res = gtk_dialog_run (GTK_DIALOG (dialog));
/// if (res == GTK_RESPONSE_ACCEPT)
///   {
///     GtkRecentInfo *info;
///     GtkRecentChooser *chooser = GTK_RECENT_CHOOSER (dialog);
/// 
///     info = gtk_recent_chooser_get_current_item (chooser);
///     open_file (gtk_recent_info_get_uri (info));
///     gtk_recent_info_unref (info);
///   }
/// 
/// gtk_widget_destroy (dialog);
/// </code>
/// <para>
/// Recently used files are supported since GTK+ 2.10.
/// </para>
/// </summary>

public class GtkRecentChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRecentChooserDialog.  This function is analogous to
/// gtk_dialog_new_with_buttons().
/// </para>
/// </summary>

/// <param name="title">
/// Title of the dialog, or %NULL
/// </param>
/// <param name="parent">
/// Transient parent of the dialog, or %NULL,
/// </param>
/// <param name="first_button_text">
/// stock ID or text to go in the first button, or %NULL
/// </param>
/// <param name="@__arglist">
/// response ID for the first button, then additional (button, id)
///   pairs, ending with %NULL
/// </param>
/// <return>
/// a new #GtkRecentChooserDialog
/// </return>

	public static MentorLake.Gtk.GtkRecentChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogHandleExterns.gtk_recent_chooser_dialog_new(title, parent, first_button_text, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRecentChooserDialog with a specified recent manager.
/// </para>
/// <para>
/// This is useful if you have implemented your own recent manager, or if you
/// have a customized instance of a #GtkRecentManager object.
/// </para>
/// </summary>

/// <param name="title">
/// Title of the dialog, or %NULL
/// </param>
/// <param name="parent">
/// Transient parent of the dialog, or %NULL,
/// </param>
/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <param name="first_button_text">
/// stock ID or text to go in the first button, or %NULL
/// </param>
/// <param name="@__arglist">
/// response ID for the first button, then additional (button, id)
///   pairs, ending with %NULL
/// </param>
/// <return>
/// a new #GtkRecentChooserDialog
/// </return>

	public static MentorLake.Gtk.GtkRecentChooserDialogHandle NewForManager(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogHandleExterns.gtk_recent_chooser_dialog_new_for_manager(title, parent, manager, first_button_text, @__arglist);
	}

}
public static class GtkRecentChooserDialogHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the user &quot;activates&quot; a recent item
/// in the recent chooser.  This can happen by double-clicking on an item
/// in the recently used resources list, or by pressing
/// `Enter`.
/// </para>
/// </summary>

	public static IObservable<GtkRecentChooserDialogHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserDialogHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentChooserDialogHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserDialogHandleSignalStructs.ItemActivatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "item-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when there is a change in the set of
/// selected recently used resources.  This can happen when a user
/// modifies the selection with the mouse or the keyboard, or when
/// explicitly calling functions to change the selection.
/// </para>
/// </summary>

	public static IObservable<GtkRecentChooserDialogHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserDialogHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentChooserDialogHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserDialogHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRecentChooserDialogHandleSignalStructs
{

public class ItemActivatedSignal
{

	public MentorLake.Gtk.GtkRecentChooserHandle Self;

	public IntPtr UserData;
}

public class SelectionChangedSignal
{

	public MentorLake.Gtk.GtkRecentChooserHandle Self;

	public IntPtr UserData;
}
}

public static class GtkRecentChooserDialogHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the user &quot;activates&quot; a recent item
/// in the recent chooser.  This can happen by double-clicking on an item
/// in the recently used resources list, or by pressing
/// `Enter`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when there is a change in the set of
/// selected recently used resources.  This can happen when a user
/// modifies the selection with the mouse or the keyboard, or when
/// explicitly calling functions to change the selection.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);

}


public static class GtkRecentChooserDialogHandleExtensions
{
}

internal class GtkRecentChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new_for_manager(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist);

}
