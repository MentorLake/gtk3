namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkPaned has two panes, arranged either
/// horizontally or vertically. The division between
/// the two panes is adjustable by the user by dragging
/// a handle.
/// </para>
/// <para>
/// Child widgets are
/// added to the panes of the widget with gtk_paned_pack1() and
/// gtk_paned_pack2(). The division between the two children is set by default
/// from the size requests of the children, but it can be adjusted by the
/// user.
/// </para>
/// <para>
/// A paned widget draws a separator between the two child widgets and a
/// small handle that the user can drag to adjust the division. It does not
/// draw any relief around the children or around the separator. (The space
/// in which the separator is called the gutter.) Often, it is useful to put
/// each child inside a #GtkFrame with the shadow type set to %GTK_SHADOW_IN
/// so that the gutter appears as a ridge. No separator is drawn if one of
/// the children is missing.
/// </para>
/// <para>
/// Each child has two options that can be set, @resize and @shrink. If
/// @resize is true, then when the #GtkPaned is resized, that child will
/// expand or shrink along with the paned widget. If @shrink is true, then
/// that child can be made smaller than its requisition by the user.
/// Setting @shrink to %FALSE allows the application to set a minimum size.
/// If @resize is false for both children, then this is treated as if
/// @resize is true for both children.
/// </para>
/// <para>
/// The application can set the position of the slider as if it were set
/// by the user, by calling gtk_paned_set_position().
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// paned
/// paned
/// ├── &amp;lt;child&amp;gt;
/// ├── separator[.wide]
/// ╰── &amp;lt;child&amp;gt;
/// </code>
/// <para>
/// GtkPaned has a main CSS node with name paned, and a subnode for
/// the separator with name separator. The subnode gets a .wide style
/// class when the paned is supposed to be wide.
/// </para>
/// <para>
/// In horizontal orientation, the nodes of the children are always arranged
/// from left to right. So :first-child will always select the leftmost child,
/// regardless of text direction.
/// </para>
/// <para>
/// ## Creating a paned widget with minimum sizes.
/// </para>
/// <code>
/// GtkWidget *hpaned = gtk_paned_new (GTK_ORIENTATION_HORIZONTAL);
/// GtkWidget *hpaned = gtk_paned_new (GTK_ORIENTATION_HORIZONTAL);
/// GtkWidget *frame1 = gtk_frame_new (NULL);
/// GtkWidget *frame2 = gtk_frame_new (NULL);
/// gtk_frame_set_shadow_type (GTK_FRAME (frame1), GTK_SHADOW_IN);
/// gtk_frame_set_shadow_type (GTK_FRAME (frame2), GTK_SHADOW_IN);
/// 
/// gtk_widget_set_size_request (hpaned, 200, -1);
/// 
/// gtk_paned_pack1 (GTK_PANED (hpaned), frame1, TRUE, FALSE);
/// gtk_widget_set_size_request (frame1, 50, -1);
/// 
/// gtk_paned_pack2 (GTK_PANED (hpaned), frame2, FALSE, FALSE);
/// gtk_widget_set_size_request (frame2, 50, -1);
/// </code>
/// </summary>

public class GtkPanedHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkPaned widget.
/// </para>
/// </summary>

/// <param name="orientation">
/// the paned’s orientation.
/// </param>
/// <return>
/// a new #GtkPaned.
/// </return>

	public static MentorLake.Gtk.GtkPanedHandle New(MentorLake.Gtk.GtkOrientation orientation)
	{
		return GtkPanedHandleExterns.gtk_paned_new(orientation);
	}

}
public static class GtkPanedHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::accept-position signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to accept the current position of the handle when
/// moving it using key bindings.
/// </para>
/// <para>
/// The default binding for this signal is Return or Space.
/// </para>
/// </summary>

	public static IObservable<GtkPanedHandleSignalStructs.AcceptPositionSignal> Signal_AcceptPosition(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.AcceptPositionSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.accept_position handler = ( MentorLake.Gtk.GtkPanedHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.AcceptPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accept-position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::cancel-position signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cancel moving the position of the handle using key
/// bindings. The position of the handle will be reset to the value prior to
/// moving it.
/// </para>
/// <para>
/// The default binding for this signal is Escape.
/// </para>
/// </summary>

	public static IObservable<GtkPanedHandleSignalStructs.CancelPositionSignal> Signal_CancelPosition(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.CancelPositionSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.cancel_position handler = ( MentorLake.Gtk.GtkPanedHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.CancelPositionSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel-position", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::cycle-child-focus signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cycle the focus between the children of the paned.
/// </para>
/// <para>
/// The default binding is f6.
/// </para>
/// </summary>

	public static IObservable<GtkPanedHandleSignalStructs.CycleChildFocusSignal> Signal_CycleChildFocus(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.CycleChildFocusSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.cycle_child_focus handler = ( MentorLake.Gtk.GtkPanedHandle self,  bool reversed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.CycleChildFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cycle-child-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::cycle-handle-focus signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cycle whether the paned should grab focus to allow
/// the user to change position of the handle by using key bindings.
/// </para>
/// <para>
/// The default binding for this signal is f8.
/// </para>
/// </summary>

	public static IObservable<GtkPanedHandleSignalStructs.CycleHandleFocusSignal> Signal_CycleHandleFocus(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.CycleHandleFocusSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.cycle_handle_focus handler = ( MentorLake.Gtk.GtkPanedHandle self,  bool reversed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.CycleHandleFocusSignal()
				{
					Self = self, Reversed = reversed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cycle-handle-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::move-handle signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to move the handle when the user is using key bindings
/// to move it.
/// </para>
/// </summary>

	public static IObservable<GtkPanedHandleSignalStructs.MoveHandleSignal> Signal_MoveHandle(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.MoveHandleSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.move_handle handler = ( MentorLake.Gtk.GtkPanedHandle self,  MentorLake.Gtk.GtkScrollType scroll_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.MoveHandleSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-handle", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::toggle-handle-focus is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to accept the current position of the handle and then
/// move focus to the next widget in the focus chain.
/// </para>
/// <para>
/// The default binding is Tab.
/// </para>
/// </summary>

	public static IObservable<GtkPanedHandleSignalStructs.ToggleHandleFocusSignal> Signal_ToggleHandleFocus(this GtkPanedHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPanedHandleSignalStructs.ToggleHandleFocusSignal> obs) =>
		{
			GtkPanedHandleSignalDelegates.toggle_handle_focus handler = ( MentorLake.Gtk.GtkPanedHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPanedHandleSignalStructs.ToggleHandleFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-handle-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPanedHandleSignalStructs
{

public class AcceptPositionSignal
{

	public MentorLake.Gtk.GtkPanedHandle Self;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class CancelPositionSignal
{

	public MentorLake.Gtk.GtkPanedHandle Self;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class CycleChildFocusSignal
{

	public MentorLake.Gtk.GtkPanedHandle Self;
/// <summary>
/// <para>
/// whether cycling backward or forward
/// </para>
/// </summary>

	public bool Reversed;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class CycleHandleFocusSignal
{

	public MentorLake.Gtk.GtkPanedHandle Self;
/// <summary>
/// <para>
/// whether cycling backward or forward
/// </para>
/// </summary>

	public bool Reversed;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class MoveHandleSignal
{

	public MentorLake.Gtk.GtkPanedHandle Self;
/// <summary>
/// <para>
/// a #GtkScrollType
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkScrollType ScrollType;

	public IntPtr UserData;

	public bool ReturnValue;
}

public class ToggleHandleFocusSignal
{

	public MentorLake.Gtk.GtkPanedHandle Self;

	public IntPtr UserData;

	public bool ReturnValue;
}
}

public static class GtkPanedHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::accept-position signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to accept the current position of the handle when
/// moving it using key bindings.
/// </para>
/// <para>
/// The default binding for this signal is Return or Space.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accept_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::cancel-position signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cancel moving the position of the handle using key
/// bindings. The position of the handle will be reset to the value prior to
/// moving it.
/// </para>
/// <para>
/// The default binding for this signal is Escape.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cancel_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::cycle-child-focus signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cycle the focus between the children of the paned.
/// </para>
/// <para>
/// The default binding is f6.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="reversed">
/// whether cycling backward or forward
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_child_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, bool reversed, IntPtr user_data);


/// <summary>
/// <para>
/// The ::cycle-handle-focus signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to cycle whether the paned should grab focus to allow
/// the user to change position of the handle by using key bindings.
/// </para>
/// <para>
/// The default binding for this signal is f8.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="reversed">
/// whether cycling backward or forward
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cycle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, bool reversed, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-handle signal is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to move the handle when the user is using key bindings
/// to move it.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="scroll_type">
/// a #GtkScrollType
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, MentorLake.Gtk.GtkScrollType scroll_type, IntPtr user_data);


/// <summary>
/// <para>
/// The ::toggle-handle-focus is a
/// [keybinding signal][GtkBindingSignal]
/// which gets emitted to accept the current position of the handle and then
/// move focus to the next widget in the focus chain.
/// </para>
/// <para>
/// The default binding is Tab.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool toggle_handle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle self, IntPtr user_data);

}


public static class GtkPanedHandleExtensions
{
/// <summary>
/// <para>
/// Adds a child to the top or left pane with default parameters. This is
/// equivalent to
/// `gtk_paned_pack1 (paned, child, FALSE, TRUE)`.
/// </para>
/// </summary>

/// <param name="paned">
/// a paned widget
/// </param>
/// <param name="child">
/// the child to add
/// </param>

	public static T Add1<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_add1(paned, child);
		return paned;
	}

/// <summary>
/// <para>
/// Adds a child to the bottom or right pane with default parameters. This
/// is equivalent to
/// `gtk_paned_pack2 (paned, child, TRUE, TRUE)`.
/// </para>
/// </summary>

/// <param name="paned">
/// a paned widget
/// </param>
/// <param name="child">
/// the child to add
/// </param>

	public static T Add2<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_add2(paned, child);
		return paned;
	}

/// <summary>
/// <para>
/// Obtains the first child of the paned widget.
/// </para>
/// </summary>

/// <param name="paned">
/// a #GtkPaned widget
/// </param>
/// <return>
/// first child, or %NULL if it is not set.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetChild1(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_child1(paned);
	}

/// <summary>
/// <para>
/// Obtains the second child of the paned widget.
/// </para>
/// </summary>

/// <param name="paned">
/// a #GtkPaned widget
/// </param>
/// <return>
/// second child, or %NULL if it is not set.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetChild2(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_child2(paned);
	}

/// <summary>
/// <para>
/// Returns the #GdkWindow of the handle. This function is
/// useful when handling button or motion events because it
/// enables the callback to distinguish between the window
/// of the paned, a child and the handle.
/// </para>
/// </summary>

/// <param name="paned">
/// a #GtkPaned
/// </param>
/// <return>
/// the paned’s handle window.
/// </return>

	public static MentorLake.Gdk.GdkWindowHandle GetHandleWindow(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_handle_window(paned);
	}

/// <summary>
/// <para>
/// Obtains the position of the divider between the two panes.
/// </para>
/// </summary>

/// <param name="paned">
/// a #GtkPaned widget
/// </param>
/// <return>
/// position of the divider
/// </return>

	public static int GetPosition(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_position(paned);
	}

/// <summary>
/// <para>
/// Gets the #GtkPaned:wide-handle property.
/// </para>
/// </summary>

/// <param name="paned">
/// a #GtkPaned
/// </param>
/// <return>
/// %TRUE if the paned should have a wide handle
/// </return>

	public static bool GetWideHandle(this MentorLake.Gtk.GtkPanedHandle paned)
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		return GtkPanedHandleExterns.gtk_paned_get_wide_handle(paned);
	}

/// <summary>
/// <para>
/// Adds a child to the top or left pane.
/// </para>
/// </summary>

/// <param name="paned">
/// a paned widget
/// </param>
/// <param name="child">
/// the child to add
/// </param>
/// <param name="resize">
/// should this child expand when the paned widget is resized.
/// </param>
/// <param name="shrink">
/// can this child be made smaller than its requisition.
/// </param>

	public static T Pack1<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_pack1(paned, child, resize, shrink);
		return paned;
	}

/// <summary>
/// <para>
/// Adds a child to the bottom or right pane.
/// </para>
/// </summary>

/// <param name="paned">
/// a paned widget
/// </param>
/// <param name="child">
/// the child to add
/// </param>
/// <param name="resize">
/// should this child expand when the paned widget is resized.
/// </param>
/// <param name="shrink">
/// can this child be made smaller than its requisition.
/// </param>

	public static T Pack2<T>(this T paned, MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_pack2(paned, child, resize, shrink);
		return paned;
	}

/// <summary>
/// <para>
/// Sets the position of the divider between the two panes.
/// </para>
/// </summary>

/// <param name="paned">
/// a #GtkPaned widget
/// </param>
/// <param name="position">
/// pixel position of divider, a negative value means that the position
///            is unset.
/// </param>

	public static T SetPosition<T>(this T paned, int position) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_set_position(paned, position);
		return paned;
	}

/// <summary>
/// <para>
/// Sets the #GtkPaned:wide-handle property.
/// </para>
/// </summary>

/// <param name="paned">
/// a #GtkPaned
/// </param>
/// <param name="wide">
/// the new value for the #GtkPaned:wide-handle property
/// </param>

	public static T SetWideHandle<T>(this T paned, bool wide) where T : GtkPanedHandle
	{
		if (paned.IsInvalid) throw new Exception("Invalid handle (GtkPanedHandle)");
		GtkPanedHandleExterns.gtk_paned_set_wide_handle(paned, wide);
		return paned;
	}

}

internal class GtkPanedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))]
	internal static extern MentorLake.Gtk.GtkPanedHandle gtk_paned_new(MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_add1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_add2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_paned_get_child1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_paned_get_child2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_paned_get_handle_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_paned_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paned_get_wide_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_pack1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_pack2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool resize, bool shrink);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paned_set_wide_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPanedHandle>))] MentorLake.Gtk.GtkPanedHandle paned, bool wide);

}
