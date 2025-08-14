namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkMenuShell is the abstract base class used to derive the
/// #GtkMenu and #GtkMenuBar subclasses.
/// </para>
/// <para>
/// A #GtkMenuShell is a container of #GtkMenuItem objects arranged
/// in a list which can be navigated, selected, and activated by the
/// user to perform application functions. A #GtkMenuItem can have a
/// submenu associated with it, allowing for nested hierarchical menus.
/// </para>
/// <para>
/// # Terminology
/// </para>
/// <para>
/// A menu item can be “selected”, this means that it is displayed
/// in the prelight state, and if it has a submenu, that submenu
/// will be popped up.
/// </para>
/// <para>
/// A menu is “active” when it is visible onscreen and the user
/// is selecting from it. A menubar is not active until the user
/// clicks on one of its menuitems. When a menu is active,
/// passing the mouse over a submenu will pop it up.
/// </para>
/// <para>
/// There is also is a concept of the current menu and a current
/// menu item. The current menu item is the selected menu item
/// that is furthest down in the hierarchy. (Every active menu shell
/// does not necessarily contain a selected menu item, but if
/// it does, then the parent menu shell must also contain
/// a selected menu item.) The current menu is the menu that
/// contains the current menu item. It will always have a GTK
/// grab and receive all key presses.
/// </para>
/// </summary>

public class GtkMenuShellHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}
public static class GtkMenuShellHandleSignalExtensions
{
/// <summary>
/// <para>
/// An action signal that activates the current menu item within
/// the menu shell.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.ActivateCurrentSignal> Signal_ActivateCurrent(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.ActivateCurrentSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.activate_current handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  bool force_hide,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.ActivateCurrentSignal()
				{
					Self = self, ForceHide = force_hide, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-current", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// An action signal which cancels the selection within the menu shell.
/// Causes the #GtkMenuShell::selection-done signal to be emitted.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.CancelSignal> Signal_Cancel(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.CancelSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.cancel handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.CancelSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cancel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// A keybinding signal which moves the focus in the
/// given @direction.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.CycleFocusSignal> Signal_CycleFocus(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.CycleFocusSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.cycle_focus handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.CycleFocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cycle-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a menu shell is deactivated.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.DeactivateSignal> Signal_Deactivate(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.DeactivateSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.deactivate handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.DeactivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "deactivate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::insert signal is emitted when a new #GtkMenuItem is added to
/// a #GtkMenuShell.  A separate signal is used instead of
/// GtkContainer::add because of the need for an additional position
/// parameter.
/// </para>
/// <para>
/// The inverse of this signal is the GtkContainer::removed signal.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.InsertSignal> Signal_Insert(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.InsertSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.insert handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  int position,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.InsertSignal()
				{
					Self = self, Child = child, Position = position, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// An keybinding signal which moves the current menu item
/// in the direction specified by @direction.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.MoveCurrentSignal> Signal_MoveCurrent(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.MoveCurrentSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.move_current handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  MentorLake.Gtk.GtkMenuDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.MoveCurrentSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-current", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::move-selected signal is emitted to move the selection to
/// another item.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.MoveSelectedSignal> Signal_MoveSelected(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.MoveSelectedSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.move_selected handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  int distance,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.MoveSelectedSignal()
				{
					Self = self, Distance = distance, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a selection has been
/// completed within a menu shell.
/// </para>
/// </summary>

	public static IObservable<GtkMenuShellHandleSignalStructs.SelectionDoneSignal> Signal_SelectionDone(this GtkMenuShellHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuShellHandleSignalStructs.SelectionDoneSignal> obs) =>
		{
			GtkMenuShellHandleSignalDelegates.selection_done handler = ( MentorLake.Gtk.GtkMenuShellHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuShellHandleSignalStructs.SelectionDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuShellHandleSignalStructs
{

public class ActivateCurrentSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;
/// <summary>
/// <para>
/// if %TRUE, hide the menu after activating the menu item
/// </para>
/// </summary>

	public bool ForceHide;

	public IntPtr UserData;
}

public class CancelSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;

	public IntPtr UserData;
}

public class CycleFocusSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;
/// <summary>
/// <para>
/// the direction to cycle in
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkDirectionType Direction;

	public IntPtr UserData;
}

public class DeactivateSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;

	public IntPtr UserData;
}

public class InsertSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;
/// <summary>
/// <para>
/// the #GtkMenuItem that is being inserted
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Child;
/// <summary>
/// <para>
/// the position at which the insert occurs
/// </para>
/// </summary>

	public int Position;

	public IntPtr UserData;
}

public class MoveCurrentSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;
/// <summary>
/// <para>
/// the direction to move
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkMenuDirectionType Direction;

	public IntPtr UserData;
}

public class MoveSelectedSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;
/// <summary>
/// <para>
/// +1 to move to the next item, -1 to move to the previous
/// </para>
/// </summary>

	public int Distance;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE to stop the signal emission, %FALSE to continue
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class SelectionDoneSignal
{

	public MentorLake.Gtk.GtkMenuShellHandle Self;

	public IntPtr UserData;
}
}

public static class GtkMenuShellHandleSignalDelegates
{

/// <summary>
/// <para>
/// An action signal that activates the current menu item within
/// the menu shell.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="force_hide">
/// if %TRUE, hide the menu after activating the menu item
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, bool force_hide, IntPtr user_data);


/// <summary>
/// <para>
/// An action signal which cancels the selection within the menu shell.
/// Causes the #GtkMenuShell::selection-done signal to be emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// A keybinding signal which moves the focus in the
/// given @direction.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="direction">
/// the direction to cycle in
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cycle_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a menu shell is deactivated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::insert signal is emitted when a new #GtkMenuItem is added to
/// a #GtkMenuShell.  A separate signal is used instead of
/// GtkContainer::add because of the need for an additional position
/// parameter.
/// </para>
/// <para>
/// The inverse of this signal is the GtkContainer::removed signal.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="child">
/// the #GtkMenuItem that is being inserted
/// </param>
/// <param name="position">
/// the position at which the insert occurs
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position, IntPtr user_data);


/// <summary>
/// <para>
/// An keybinding signal which moves the current menu item
/// in the direction specified by @direction.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="direction">
/// the direction to move
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_current([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, MentorLake.Gtk.GtkMenuDirectionType direction, IntPtr user_data);


/// <summary>
/// <para>
/// The ::move-selected signal is emitted to move the selection to
/// another item.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="distance">
/// +1 to move to the next item, -1 to move to the previous
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE to stop the signal emission, %FALSE to continue
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool move_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, int distance, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a selection has been
/// completed within a menu shell.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle self, IntPtr user_data);

}


public static class GtkMenuShellHandleExtensions
{
/// <summary>
/// <para>
/// Activates the menu item within the menu shell.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="menu_item">
/// the #GtkMenuItem to activate
/// </param>
/// <param name="force_deactivate">
/// if %TRUE, force the deactivation of the
///     menu shell after the menu item is activated
/// </param>

	public static T ActivateItem<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle menu_item, bool force_deactivate) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_activate_item(menu_shell, menu_item, force_deactivate);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Adds a new #GtkMenuItem to the end of the menu shell's
/// item list.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="child">
/// The #GtkMenuItem to add
/// </param>

	public static T Append<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_append(menu_shell, child);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Establishes a binding between a #GtkMenuShell and a #GMenuModel.
/// </para>
/// <para>
/// The contents of @shell are removed and then refilled with menu items
/// according to @model.  When @model changes, @shell is updated.
/// Calling this function twice on @shell with different @model will
/// cause the first binding to be replaced with a binding to the new
/// model. If @model is %NULL then any previous binding is undone and
/// all children are removed.
/// </para>
/// <para>
/// @with_separators determines if toplevel items (eg: sections) have
/// separators inserted between them.  This is typically desired for
/// menus but doesn’t make sense for menubars.
/// </para>
/// <para>
/// If @action_namespace is non-%NULL then the effect is as if all
/// actions mentioned in the @model have their names prefixed with the
/// namespace, plus a dot.  For example, if the action “quit” is
/// mentioned and @action_namespace is “app” then the effective action
/// name is “app.quit”.
/// </para>
/// <para>
/// This function uses #GtkActionable to define the action name and
/// target values on the created menu items.  If you want to use an
/// action group other than “app” and “win”, or if you want to use a
/// #GtkMenuShell outside of a #GtkApplicationWindow, then you will need
/// to attach your own action group to the widget hierarchy using
/// gtk_widget_insert_action_group().  As an example, if you created a
/// group with a “quit” action and inserted it with the name “mygroup”
/// then you would use the action name “mygroup.quit” in your
/// #GMenuModel.
/// </para>
/// <para>
/// For most cases you are probably better off using
/// gtk_menu_new_from_model() or gtk_menu_bar_new_from_model() or just
/// directly passing the #GMenuModel to gtk_application_set_app_menu() or
/// gtk_application_set_menubar().
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="model">
/// the #GMenuModel to bind to or %NULL to remove
///   binding
/// </param>
/// <param name="action_namespace">
/// the namespace for actions in @model
/// </param>
/// <param name="with_separators">
/// %TRUE if toplevel items in @shell should have
///   separators between them
/// </param>

	public static T BindModel<T>(this T menu_shell, MentorLake.Gio.GMenuModelHandle model, string action_namespace, bool with_separators) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_bind_model(menu_shell, model, action_namespace, with_separators);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Cancels the selection within the menu shell.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>

	public static T Cancel<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_cancel(menu_shell);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Deactivates the menu shell.
/// </para>
/// <para>
/// Typically this results in the menu shell being erased
/// from the screen.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>

	public static T Deactivate<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_deactivate(menu_shell);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Deselects the currently selected item from the menu shell,
/// if any.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>

	public static T Deselect<T>(this T menu_shell) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_deselect(menu_shell);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Gets the parent menu shell.
/// </para>
/// <para>
/// The parent menu shell of a submenu is the #GtkMenu or #GtkMenuBar
/// from which it was opened up.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <return>
/// the parent #GtkMenuShell
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetParentShell(this MentorLake.Gtk.GtkMenuShellHandle menu_shell)
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		return GtkMenuShellHandleExterns.gtk_menu_shell_get_parent_shell(menu_shell);
	}

/// <summary>
/// <para>
/// Gets the currently selected item.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <return>
/// the currently selected item
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetSelectedItem(this MentorLake.Gtk.GtkMenuShellHandle menu_shell)
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		return GtkMenuShellHandleExterns.gtk_menu_shell_get_selected_item(menu_shell);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the menu shell will take the keyboard focus on popup.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <return>
/// %TRUE if the menu shell will take the keyboard focus on popup.
/// </return>

	public static bool GetTakeFocus(this MentorLake.Gtk.GtkMenuShellHandle menu_shell)
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		return GtkMenuShellHandleExterns.gtk_menu_shell_get_take_focus(menu_shell);
	}

/// <summary>
/// <para>
/// Adds a new #GtkMenuItem to the menu shell’s item list
/// at the position indicated by @position.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="child">
/// The #GtkMenuItem to add
/// </param>
/// <param name="position">
/// The position in the item list where @child
///     is added. Positions are numbered from 0 to n-1
/// </param>

	public static T Insert<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_insert(menu_shell, child, position);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Adds a new #GtkMenuItem to the beginning of the menu shell's
/// item list.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="child">
/// The #GtkMenuItem to add
/// </param>

	public static T Prepend<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_prepend(menu_shell, child);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Select the first visible or selectable child of the menu shell;
/// don’t select tearoff items unless the only item is a tearoff
/// item.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="search_sensitive">
/// if %TRUE, search for the first selectable
///                    menu item, otherwise select nothing if
///                    the first item isn’t sensitive. This
///                    should be %FALSE if the menu is being
///                    popped up initially.
/// </param>

	public static T SelectFirst<T>(this T menu_shell, bool search_sensitive) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_select_first(menu_shell, search_sensitive);
		return menu_shell;
	}

/// <summary>
/// <para>
/// Selects the menu item from the menu shell.
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="menu_item">
/// The #GtkMenuItem to select
/// </param>

	public static T SelectItem<T>(this T menu_shell, MentorLake.Gtk.GtkWidgetHandle menu_item) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_select_item(menu_shell, menu_item);
		return menu_shell;
	}

/// <summary>
/// <para>
/// If @take_focus is %TRUE (the default) the menu shell will take
/// the keyboard focus so that it will receive all keyboard events
/// which is needed to enable keyboard navigation in menus.
/// </para>
/// <para>
/// Setting @take_focus to %FALSE is useful only for special applications
/// like virtual keyboard implementations which should not take keyboard
/// focus.
/// </para>
/// <para>
/// The @take_focus state of a menu or menu bar is automatically
/// propagated to submenus whenever a submenu is popped up, so you
/// don’t have to worry about recursively setting it for your entire
/// menu hierarchy. Only when programmatically picking a submenu and
/// popping it up manually, the @take_focus property of the submenu
/// needs to be set explicitly.
/// </para>
/// <para>
/// Note that setting it to %FALSE has side-effects:
/// </para>
/// <para>
/// If the focus is in some other app, it keeps the focus and keynav in
/// the menu doesn’t work. Consequently, keynav on the menu will only
/// work if the focus is on some toplevel owned by the onscreen keyboard.
/// </para>
/// <para>
/// To avoid confusing the user, menus with @take_focus set to %FALSE
/// should not display mnemonics or accelerators, since it cannot be
/// guaranteed that they will work.
/// </para>
/// <para>
/// See also gdk_keyboard_grab()
/// </para>
/// </summary>

/// <param name="menu_shell">
/// a #GtkMenuShell
/// </param>
/// <param name="take_focus">
/// %TRUE if the menu shell should take the keyboard
///     focus on popup
/// </param>

	public static T SetTakeFocus<T>(this T menu_shell, bool take_focus) where T : GtkMenuShellHandle
	{
		if (menu_shell.IsInvalid) throw new Exception("Invalid handle (GtkMenuShellHandle)");
		GtkMenuShellHandleExterns.gtk_menu_shell_set_take_focus(menu_shell, take_focus);
		return menu_shell;
	}

}

internal class GtkMenuShellHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_activate_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_item, bool force_deactivate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_bind_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMenuModelHandle>))] MentorLake.Gio.GMenuModelHandle model, string action_namespace, bool with_separators);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_deselect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_shell_get_parent_shell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_shell_get_selected_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_shell_get_take_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_select_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, bool search_sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_select_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_shell_set_take_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menu_shell, bool take_focus);

}
