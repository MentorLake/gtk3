namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkMenuItem widget and the derived widgets are the only valid
/// children for menus. Their function is to correctly handle highlighting,
/// alignment, events and submenus.
/// </para>
/// <para>
/// As a GtkMenuItem derives from #GtkBin it can hold any valid child widget,
/// although only a few are really useful.
/// </para>
/// <para>
/// By default, a GtkMenuItem sets a #GtkAccelLabel as its child.
/// GtkMenuItem has direct functions to set the label and its mnemonic.
/// For more advanced label settings, you can fetch the child widget from the GtkBin.
/// </para>
/// <para>
/// An example for setting markup and accelerator on a MenuItem:
/// </para>
/// <code>
/// GtkWidget *menu_item = gtk_menu_item_new_with_label (&quot;Example Menu Item&quot;);
/// GtkWidget *menu_item = gtk_menu_item_new_with_label (&quot;Example Menu Item&quot;);
/// 
/// GtkWidget *child = gtk_bin_get_child (GTK_BIN (menu_item));
/// gtk_label_set_markup (GTK_LABEL (child), &quot;&amp;lt;i&amp;gt;new label&amp;lt;/i&amp;gt; with &amp;lt;b&amp;gt;markup&amp;lt;/b&amp;gt;&quot;);
/// gtk_accel_label_set_accel (GTK_ACCEL_LABEL (child), GDK_KEY_1, 0);
/// </code>
/// <para>
/// # GtkMenuItem as GtkBuildable
/// </para>
/// <para>
/// The GtkMenuItem implementation of the #GtkBuildable interface supports
/// adding a submenu by specifying “submenu” as the “type” attribute of
/// a `&amp;lt;child&amp;gt;` element.
/// </para>
/// <para>
/// An example of UI definition fragment with submenus:
/// </para>
/// <code>
/// &amp;lt;object class=&quot;GtkMenuItem&quot;&amp;gt;
/// &amp;lt;object class=&quot;GtkMenuItem&quot;&amp;gt;
///   &amp;lt;child type=&quot;submenu&quot;&amp;gt;
///     &amp;lt;object class=&quot;GtkMenu&quot;/&amp;gt;
///   &amp;lt;/child&amp;gt;
/// &amp;lt;/object&amp;gt;
/// </code>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// menuitem
/// menuitem
/// ├── &amp;lt;child&amp;gt;
/// ╰── [arrow.right]
/// </code>
/// <para>
/// GtkMenuItem has a single CSS node with name menuitem. If the menuitem
/// has a submenu, it gets another CSS node with name arrow, which has
/// the .left or .right style class.
/// </para>
/// </summary>

public class GtkMenuItemHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkMenuItem.
/// </para>
/// </summary>

/// <return>
/// the newly created #GtkMenuItem
/// </return>

	public static MentorLake.Gtk.GtkMenuItemHandle New()
	{
		return GtkMenuItemHandleExterns.gtk_menu_item_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkMenuItem whose child is a #GtkLabel.
/// </para>
/// </summary>

/// <param name="label">
/// the text for the label
/// </param>
/// <return>
/// the newly created #GtkMenuItem
/// </return>

	public static MentorLake.Gtk.GtkMenuItemHandle NewWithLabel(string label)
	{
		return GtkMenuItemHandleExterns.gtk_menu_item_new_with_label(label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkMenuItem containing a label.
/// </para>
/// <para>
/// The label will be created using gtk_label_new_with_mnemonic(),
/// so underscores in @label indicate the mnemonic for the menu item.
/// </para>
/// </summary>

/// <param name="label">
/// The text of the button, with an underscore in front of the
///     mnemonic character
/// </param>
/// <return>
/// a new #GtkMenuItem
/// </return>

	public static MentorLake.Gtk.GtkMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkMenuItemHandleExterns.gtk_menu_item_new_with_mnemonic(label);
	}

}
public static class GtkMenuItemHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the item is activated.
/// </para>
/// </summary>

	public static IObservable<GtkMenuItemHandleSignalStructs.ActivateSignal> Signal_Activate(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ActivateSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.activate handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ActivateSignal()
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
/// Emitted when the item is activated, but also if the menu item has a
/// submenu. For normal applications, the relevant signal is
/// #GtkMenuItem::activate.
/// </para>
/// </summary>

	public static IObservable<GtkMenuItemHandleSignalStructs.ActivateItemSignal> Signal_ActivateItem(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ActivateItemSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.activate_item handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ActivateItemSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate-item", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.DeselectSignal> Signal_Deselect(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.DeselectSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.deselect handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.DeselectSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "deselect", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.SelectSignal> Signal_Select(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.SelectSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.select handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.SelectSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.ToggleSizeAllocateSignal> Signal_ToggleSizeAllocate(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ToggleSizeAllocateSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.toggle_size_allocate handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  int @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ToggleSizeAllocateSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-size-allocate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkMenuItemHandleSignalStructs.ToggleSizeRequestSignal> Signal_ToggleSizeRequest(this GtkMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuItemHandleSignalStructs.ToggleSizeRequestSignal> obs) =>
		{
			GtkMenuItemHandleSignalDelegates.toggle_size_request handler = ( MentorLake.Gtk.GtkMenuItemHandle self,  IntPtr @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuItemHandleSignalStructs.ToggleSizeRequestSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggle-size-request", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuItemHandleSignalStructs
{

public class ActivateSignal
{

	public MentorLake.Gtk.GtkMenuItemHandle Self;

	public IntPtr UserData;
}

public class ActivateItemSignal
{

	public MentorLake.Gtk.GtkMenuItemHandle Self;

	public IntPtr UserData;
}

public class DeselectSignal
{

	public MentorLake.Gtk.GtkMenuItemHandle Self;

	public IntPtr UserData;
}

public class SelectSignal
{

	public MentorLake.Gtk.GtkMenuItemHandle Self;

	public IntPtr UserData;
}

public class ToggleSizeAllocateSignal
{

	public MentorLake.Gtk.GtkMenuItemHandle Self;

	public int Object;

	public IntPtr UserData;
}

public class ToggleSizeRequestSignal
{

	public MentorLake.Gtk.GtkMenuItemHandle Self;

	public IntPtr Object;

	public IntPtr UserData;
}
}

public static class GtkMenuItemHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the item is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the item is activated, but also if the menu item has a
/// submenu. For normal applications, the relevant signal is
/// #GtkMenuItem::activate.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deselect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, int @object, IntPtr user_data);



/// <param name="self">
/// </param>
/// <param name="@object">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle self, IntPtr @object, IntPtr user_data);

}


public static class GtkMenuItemHandleExtensions
{
/// <summary>
/// <para>
/// Emits the #GtkMenuItem::activate signal on the given item
/// </para>
/// </summary>

/// <param name="menu_item">
/// the menu item
/// </param>

	public static T Activate<T>(this T menu_item) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_activate(menu_item);
		return menu_item;
	}

/// <summary>
/// <para>
/// Emits the #GtkMenuItem::deselect signal on the given item.
/// </para>
/// </summary>

/// <param name="menu_item">
/// the menu item
/// </param>

	public static T Deselect<T>(this T menu_item) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_deselect(menu_item);
		return menu_item;
	}

/// <summary>
/// <para>
/// Retrieve the accelerator path that was previously set on @menu_item.
/// </para>
/// <para>
/// See gtk_menu_item_set_accel_path() for details.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a valid #GtkMenuItem
/// </param>
/// <return>
/// the accelerator path corresponding to
///     this menu item’s functionality, or %NULL if not set
/// </return>

	public static string GetAccelPath(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_accel_path(menu_item);
	}

/// <summary>
/// <para>
/// Sets @text on the @menu_item label
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <return>
/// The text in the @menu_item label. This is the internal
///   string used by the label, and must not be modified.
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_label(menu_item);
	}

/// <summary>
/// <para>
/// Returns whether the @menu_item reserves space for
/// the submenu indicator, regardless if it has a submenu
/// or not.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <return>
/// %TRUE if @menu_item always reserves space for the
///     submenu indicator
/// </return>

	public static bool GetReserveIndicator(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_reserve_indicator(menu_item);
	}

/// <summary>
/// <para>
/// Gets whether the menu item appears justified at the right
/// side of the menu bar.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <return>
/// %TRUE if the menu item will appear at the
///   far right if added to a menu bar.
/// </return>

	public static bool GetRightJustified(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_right_justified(menu_item);
	}

/// <summary>
/// <para>
/// Gets the submenu underneath this menu item, if any.
/// See gtk_menu_item_set_submenu().
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <return>
/// submenu for this menu item, or %NULL if none
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetSubmenu(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_submenu(menu_item);
	}

/// <summary>
/// <para>
/// Checks if an underline in the text indicates the next character
/// should be used for the mnemonic accelerator key.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <return>
/// %TRUE if an embedded underline in the label
///     indicates the mnemonic accelerator key.
/// </return>

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkMenuItemHandle menu_item)
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		return GtkMenuItemHandleExterns.gtk_menu_item_get_use_underline(menu_item);
	}

/// <summary>
/// <para>
/// Emits the #GtkMenuItem::select signal on the given item.
/// </para>
/// </summary>

/// <param name="menu_item">
/// the menu item
/// </param>

	public static T Select<T>(this T menu_item) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_select(menu_item);
		return menu_item;
	}

/// <summary>
/// <para>
/// Set the accelerator path on @menu_item, through which runtime
/// changes of the menu item’s accelerator caused by the user can be
/// identified and saved to persistent storage (see gtk_accel_map_save()
/// on this). To set up a default accelerator for this menu item, call
/// gtk_accel_map_add_entry() with the same @accel_path. See also
/// gtk_accel_map_add_entry() on the specifics of accelerator paths,
/// and gtk_menu_set_accel_path() for a more convenient variant of
/// this function.
/// </para>
/// <para>
/// This function is basically a convenience wrapper that handles
/// calling gtk_widget_set_accel_path() with the appropriate accelerator
/// group for the menu item.
/// </para>
/// <para>
/// Note that you do need to set an accelerator on the parent menu with
/// gtk_menu_set_accel_group() for this to work.
/// </para>
/// <para>
/// Note that @accel_path string will be stored in a #GQuark.
/// Therefore, if you pass a static string, you can save some memory
/// by interning it first with g_intern_static_string().
/// </para>
/// </summary>

/// <param name="menu_item">
/// a valid #GtkMenuItem
/// </param>
/// <param name="accel_path">
/// accelerator path, corresponding to this menu
///     item’s functionality, or %NULL to unset the current path.
/// </param>

	public static T SetAccelPath<T>(this T menu_item, string accel_path) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_accel_path(menu_item, accel_path);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets @text on the @menu_item label
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <param name="label">
/// the text you want to set
/// </param>

	public static T SetLabel<T>(this T menu_item, string label) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_label(menu_item, label);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets whether the @menu_item should reserve space for
/// the submenu indicator, regardless if it actually has
/// a submenu or not.
/// </para>
/// <para>
/// There should be little need for applications to call
/// this functions.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <param name="reserve">
/// the new value
/// </param>

	public static T SetReserveIndicator<T>(this T menu_item, bool reserve) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_reserve_indicator(menu_item, reserve);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets whether the menu item appears justified at the right
/// side of a menu bar. This was traditionally done for “Help”
/// menu items, but is now considered a bad idea. (If the widget
/// layout is reversed for a right-to-left language like Hebrew
/// or Arabic, right-justified-menu-items appear at the left.)
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem.
/// </param>
/// <param name="right_justified">
/// if %TRUE the menu item will appear at the
///   far right if added to a menu bar
/// </param>

	public static T SetRightJustified<T>(this T menu_item, bool right_justified) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_right_justified(menu_item, right_justified);
		return menu_item;
	}

/// <summary>
/// <para>
/// Sets or replaces the menu item’s submenu, or removes it when a %NULL
/// submenu is passed.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <param name="submenu">
/// the submenu, or %NULL
/// </param>

	public static T SetSubmenu<T>(this T menu_item, MentorLake.Gtk.GtkWidgetHandle submenu) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_submenu(menu_item, submenu);
		return menu_item;
	}

/// <summary>
/// <para>
/// If true, an underline in the text indicates the next character
/// should be used for the mnemonic accelerator key.
/// </para>
/// </summary>

/// <param name="menu_item">
/// a #GtkMenuItem
/// </param>
/// <param name="setting">
/// %TRUE if underlines in the text indicate mnemonics
/// </param>

	public static T SetUseUnderline<T>(this T menu_item, bool setting) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_set_use_underline(menu_item, setting);
		return menu_item;
	}

/// <summary>
/// <para>
/// Emits the #GtkMenuItem::toggle-size-allocate signal on the given item.
/// </para>
/// </summary>

/// <param name="menu_item">
/// the menu item.
/// </param>
/// <param name="allocation">
/// the allocation to use as signal data.
/// </param>

	public static T ToggleSizeAllocate<T>(this T menu_item, int allocation) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_toggle_size_allocate(menu_item, allocation);
		return menu_item;
	}

/// <summary>
/// <para>
/// Emits the #GtkMenuItem::toggle-size-request signal on the given item.
/// </para>
/// </summary>

/// <param name="menu_item">
/// the menu item
/// </param>
/// <param name="requisition">
/// the requisition to use as signal data.
/// </param>

	public static T ToggleSizeRequest<T>(this T menu_item, ref int requisition) where T : GtkMenuItemHandle
	{
		if (menu_item.IsInvalid) throw new Exception("Invalid handle (GtkMenuItemHandle)");
		GtkMenuItemHandleExterns.gtk_menu_item_toggle_size_request(menu_item, ref requisition);
		return menu_item;
	}

}

internal class GtkMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuItemHandle gtk_menu_item_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuItemHandle gtk_menu_item_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkMenuItemHandle gtk_menu_item_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_deselect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_item_get_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_menu_item_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_item_get_reserve_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_item_get_right_justified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_item_get_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_menu_item_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_select([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, string accel_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_reserve_indicator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, bool reserve);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_right_justified([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, bool right_justified);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_submenu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle submenu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_toggle_size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, int allocation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_item_toggle_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuItemHandle>))] MentorLake.Gtk.GtkMenuItemHandle menu_item, ref int requisition);

}
