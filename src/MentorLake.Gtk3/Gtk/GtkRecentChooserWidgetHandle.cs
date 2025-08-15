namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRecentChooserWidget is a widget suitable for selecting recently used
/// files.  It is the main building block of a #GtkRecentChooserDialog.  Most
/// applications will only need to use the latter; you can use
/// #GtkRecentChooserWidget as part of a larger window if you have special needs.
/// </para>
/// <para>
/// Note that #GtkRecentChooserWidget does not have any methods of its own.
/// Instead, you should use the functions that work on a #GtkRecentChooser.
/// </para>
/// <para>
/// Recently used files are supported since GTK+ 2.10.
/// </para>
/// </summary>

public class GtkRecentChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkRecentChooserHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRecentChooserWidget object.  This is an embeddable widget
/// used to access the recently used resources list.
/// </para>
/// </summary>

/// <return>
/// a new #GtkRecentChooserWidget
/// </return>

	public static MentorLake.Gtk.GtkRecentChooserWidgetHandle New()
	{
		return GtkRecentChooserWidgetHandleExterns.gtk_recent_chooser_widget_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkRecentChooserWidget with a specified recent manager.
/// </para>
/// <para>
/// This is useful if you have implemented your own recent manager, or if you
/// have a customized instance of a #GtkRecentManager object.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <return>
/// a new #GtkRecentChooserWidget
/// </return>

	public static MentorLake.Gtk.GtkRecentChooserWidgetHandle NewForManager(MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserWidgetHandleExterns.gtk_recent_chooser_widget_new_for_manager(manager);
	}

}
public static class GtkRecentChooserWidgetHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the user &quot;activates&quot; a recent item
/// in the recent chooser.  This can happen by double-clicking on an item
/// in the recently used resources list, or by pressing
/// `Enter`.
/// </para>
/// </summary>

	public static IObservable<GtkRecentChooserWidgetHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserWidgetHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentChooserWidgetHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserWidgetHandleSignalStructs.ItemActivatedSignal()
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

	public static IObservable<GtkRecentChooserWidgetHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserWidgetHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentChooserWidgetHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserWidgetHandleSignalStructs.SelectionChangedSignal()
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

public static class GtkRecentChooserWidgetHandleSignalStructs
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

public static class GtkRecentChooserWidgetHandleSignalDelegates
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


public static class GtkRecentChooserWidgetHandleExtensions
{
}

internal class GtkRecentChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new_for_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

}
