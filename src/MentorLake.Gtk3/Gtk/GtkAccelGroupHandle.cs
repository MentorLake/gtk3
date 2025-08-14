namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkAccelGroup represents a group of keyboard accelerators,
/// typically attached to a toplevel #GtkWindow (with
/// gtk_window_add_accel_group()). Usually you won’t need to create a
/// #GtkAccelGroup directly; instead, when using #GtkUIManager, GTK+
/// automatically sets up the accelerators for your menus in the ui
/// manager’s #GtkAccelGroup.
/// </para>
/// <para>
/// Note that “accelerators” are different from
/// “mnemonics”. Accelerators are shortcuts for
/// activating a menu item; they appear alongside the menu item they’re a
/// shortcut for. For example “Ctrl+Q” might appear alongside the “Quit”
/// menu item. Mnemonics are shortcuts for GUI elements such as text
/// entries or buttons; they appear as underlined characters. See
/// gtk_label_new_with_mnemonic(). Menu items can have both accelerators
/// and mnemonics, of course.
/// </para>
/// </summary>

public class GtkAccelGroupHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAccelGroup.
/// </para>
/// </summary>

/// <return>
/// a new #GtkAccelGroup object
/// </return>

	public static MentorLake.Gtk.GtkAccelGroupHandle New()
	{
		return GtkAccelGroupHandleExterns.gtk_accel_group_new();
	}

/// <summary>
/// <para>
/// Finds the #GtkAccelGroup to which @closure is connected;
/// see gtk_accel_group_connect().
/// </para>
/// </summary>

/// <param name="closure">
/// a #GClosure
/// </param>
/// <return>
/// the #GtkAccelGroup to which @closure
///     is connected, or %NULL
/// </return>

	public static MentorLake.Gtk.GtkAccelGroupHandle FromAccelClosure(MentorLake.GObject.GClosureHandle closure)
	{
		return GtkAccelGroupHandleExterns.gtk_accel_group_from_accel_closure(closure);
	}

}
public static class GtkAccelGroupHandleSignalExtensions
{
/// <summary>
/// <para>
/// The accel-activate signal is an implementation detail of
/// #GtkAccelGroup and not meant to be used by applications.
/// </para>
/// </summary>

	public static IObservable<GtkAccelGroupHandleSignalStructs.AccelActivateSignal> Signal_AccelActivate(this GtkAccelGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAccelGroupHandleSignalStructs.AccelActivateSignal> obs) =>
		{
			GtkAccelGroupHandleSignalDelegates.accel_activate handler = ( MentorLake.Gtk.GtkAccelGroupHandle self,  MentorLake.GObject.GObjectHandle acceleratable,  uint keyval,  MentorLake.Gdk.GdkModifierType modifier,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelGroupHandleSignalStructs.AccelActivateSignal()
				{
					Self = self, Acceleratable = acceleratable, Keyval = keyval, Modifier = modifier, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The accel-changed signal is emitted when an entry
/// is added to or removed from the accel group.
/// </para>
/// <para>
/// Widgets like #GtkAccelLabel which display an associated
/// accelerator should connect to this signal, and rebuild
/// their visual representation if the @accel_closure is theirs.
/// </para>
/// </summary>

	public static IObservable<GtkAccelGroupHandleSignalStructs.AccelChangedSignal> Signal_AccelChanged(this GtkAccelGroupHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAccelGroupHandleSignalStructs.AccelChangedSignal> obs) =>
		{
			GtkAccelGroupHandleSignalDelegates.accel_changed handler = ( MentorLake.Gtk.GtkAccelGroupHandle self,  uint keyval,  MentorLake.Gdk.GdkModifierType modifier,  MentorLake.GObject.GClosureHandle accel_closure,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelGroupHandleSignalStructs.AccelChangedSignal()
				{
					Self = self, Keyval = keyval, Modifier = modifier, AccelClosure = accel_closure, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkAccelGroupHandleSignalStructs
{

public class AccelActivateSignal
{

	public MentorLake.Gtk.GtkAccelGroupHandle Self;
/// <summary>
/// <para>
/// the object on which the accelerator was activated
/// </para>
/// </summary>

	public MentorLake.GObject.GObjectHandle Acceleratable;
/// <summary>
/// <para>
/// the accelerator keyval
/// </para>
/// </summary>

	public uint Keyval;
/// <summary>
/// <para>
/// the modifier combination of the accelerator
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkModifierType Modifier;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the accelerator was activated
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class AccelChangedSignal
{

	public MentorLake.Gtk.GtkAccelGroupHandle Self;
/// <summary>
/// <para>
/// the accelerator keyval
/// </para>
/// </summary>

	public uint Keyval;
/// <summary>
/// <para>
/// the modifier combination of the accelerator
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkModifierType Modifier;
/// <summary>
/// <para>
/// the #GClosure of the accelerator
/// </para>
/// </summary>

	public MentorLake.GObject.GClosureHandle AccelClosure;

	public IntPtr UserData;
}
}

public static class GtkAccelGroupHandleSignalDelegates
{

/// <summary>
/// <para>
/// The accel-activate signal is an implementation detail of
/// #GtkAccelGroup and not meant to be used by applications.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="acceleratable">
/// the object on which the accelerator was activated
/// </param>
/// <param name="keyval">
/// the accelerator keyval
/// </param>
/// <param name="modifier">
/// the modifier combination of the accelerator
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the accelerator was activated
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool accel_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle acceleratable, uint keyval, MentorLake.Gdk.GdkModifierType modifier, IntPtr user_data);


/// <summary>
/// <para>
/// The accel-changed signal is emitted when an entry
/// is added to or removed from the accel group.
/// </para>
/// <para>
/// Widgets like #GtkAccelLabel which display an associated
/// accelerator should connect to this signal, and rebuild
/// their visual representation if the @accel_closure is theirs.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="keyval">
/// the accelerator keyval
/// </param>
/// <param name="modifier">
/// the modifier combination of the accelerator
/// </param>
/// <param name="accel_closure">
/// the #GClosure of the accelerator
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle self, uint keyval, MentorLake.Gdk.GdkModifierType modifier, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle accel_closure, IntPtr user_data);

}


public static class GtkAccelGroupHandleExtensions
{
/// <summary>
/// <para>
/// Finds the first accelerator in @accel_group that matches
/// @accel_key and @accel_mods, and activates it.
/// </para>
/// </summary>

/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>
/// <param name="accel_quark">
/// the quark for the accelerator name
/// </param>
/// <param name="acceleratable">
/// the #GObject, usually a #GtkWindow, on which
///    to activate the accelerator
/// </param>
/// <param name="accel_key">
/// accelerator keyval from a key event
/// </param>
/// <param name="accel_mods">
/// keyboard state mask from a key event
/// </param>
/// <return>
/// %TRUE if an accelerator was activated and handled
///     this keypress
/// </return>

	public static bool Activate(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.GLib.GQuark accel_quark, MentorLake.GObject.GObjectHandle acceleratable, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_activate(accel_group, accel_quark, acceleratable, accel_key, accel_mods);
	}

/// <summary>
/// <para>
/// Installs an accelerator in this group. When @accel_group is being
/// activated in response to a call to gtk_accel_groups_activate(),
/// @closure will be invoked if the @accel_key and @accel_mods from
/// gtk_accel_groups_activate() match those of this connection.
/// </para>
/// <para>
/// The signature used for the @closure is that of #GtkAccelGroupActivate.
/// </para>
/// <para>
/// Note that, due to implementation details, a single closure can
/// only be connected to one accelerator group.
/// </para>
/// </summary>

/// <param name="accel_group">
/// the accelerator group to install an accelerator in
/// </param>
/// <param name="accel_key">
/// key value of the accelerator
/// </param>
/// <param name="accel_mods">
/// modifier combination of the accelerator
/// </param>
/// <param name="accel_flags">
/// a flag mask to configure this accelerator
/// </param>
/// <param name="closure">
/// closure to be executed upon accelerator activation
/// </param>

	public static T Connect<T>(this T accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags, MentorLake.GObject.GClosureHandle closure) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_connect(accel_group, accel_key, accel_mods, accel_flags, closure);
		return accel_group;
	}

/// <summary>
/// <para>
/// Installs an accelerator in this group, using an accelerator path
/// to look up the appropriate key and modifiers (see
/// gtk_accel_map_add_entry()). When @accel_group is being activated
/// in response to a call to gtk_accel_groups_activate(), @closure will
/// be invoked if the @accel_key and @accel_mods from
/// gtk_accel_groups_activate() match the key and modifiers for the path.
/// </para>
/// <para>
/// The signature used for the @closure is that of #GtkAccelGroupActivate.
/// </para>
/// <para>
/// Note that @accel_path string will be stored in a #GQuark. Therefore,
/// if you pass a static string, you can save some memory by interning it
/// first with g_intern_static_string().
/// </para>
/// </summary>

/// <param name="accel_group">
/// the accelerator group to install an accelerator in
/// </param>
/// <param name="accel_path">
/// path used for determining key and modifiers
/// </param>
/// <param name="closure">
/// closure to be executed upon accelerator activation
/// </param>

	public static T ConnectByPath<T>(this T accel_group, string accel_path, MentorLake.GObject.GClosureHandle closure) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_connect_by_path(accel_group, accel_path, closure);
		return accel_group;
	}

/// <summary>
/// <para>
/// Removes an accelerator previously installed through
/// gtk_accel_group_connect().
/// </para>
/// <para>
/// Since 2.20 @closure can be %NULL.
/// </para>
/// </summary>

/// <param name="accel_group">
/// the accelerator group to remove an accelerator from
/// </param>
/// <param name="closure">
/// the closure to remove from this accelerator
///     group, or %NULL to remove all closures
/// </param>
/// <return>
/// %TRUE if the closure was found and got disconnected
/// </return>

	public static bool Disconnect(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.GObject.GClosureHandle closure)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_disconnect(accel_group, closure);
	}

/// <summary>
/// <para>
/// Removes an accelerator previously installed through
/// gtk_accel_group_connect().
/// </para>
/// </summary>

/// <param name="accel_group">
/// the accelerator group to install an accelerator in
/// </param>
/// <param name="accel_key">
/// key value of the accelerator
/// </param>
/// <param name="accel_mods">
/// modifier combination of the accelerator
/// </param>
/// <return>
/// %TRUE if there was an accelerator which could be
///     removed, %FALSE otherwise
/// </return>

	public static bool DisconnectKey(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_disconnect_key(accel_group, accel_key, accel_mods);
	}

/// <summary>
/// <para>
/// Finds the first entry in an accelerator group for which
/// @find_func returns %TRUE and returns its #GtkAccelKey.
/// </para>
/// </summary>

/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>
/// <param name="find_func">
/// a function to filter the entries
///    of @accel_group with
/// </param>
/// <param name="data">
/// data to pass to @find_func
/// </param>
/// <return>
/// the key of the first entry passing
///    @find_func. The key is owned by GTK+ and must not be freed.
/// </return>

	public static MentorLake.Gtk.GtkAccelKeyHandle Find(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.Gtk.GtkAccelGroupFindFunc find_func, IntPtr data)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_find(accel_group, find_func, data);
	}

/// <summary>
/// <para>
/// Locks are added and removed using gtk_accel_group_lock() and
/// gtk_accel_group_unlock().
/// </para>
/// </summary>

/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>
/// <return>
/// %TRUE if there are 1 or more locks on the @accel_group,
///     %FALSE otherwise.
/// </return>

	public static bool GetIsLocked(this MentorLake.Gtk.GtkAccelGroupHandle accel_group)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_get_is_locked(accel_group);
	}

/// <summary>
/// <para>
/// Gets a #GdkModifierType representing the mask for this
/// @accel_group. For example, #GDK_CONTROL_MASK, #GDK_SHIFT_MASK, etc.
/// </para>
/// </summary>

/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>
/// <return>
/// the modifier mask for this accel group.
/// </return>

	public static MentorLake.Gdk.GdkModifierType GetModifierMask(this MentorLake.Gtk.GtkAccelGroupHandle accel_group)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_get_modifier_mask(accel_group);
	}

/// <summary>
/// <para>
/// Locks the given accelerator group.
/// </para>
/// <para>
/// Locking an acelerator group prevents the accelerators contained
/// within it to be changed during runtime. Refer to
/// gtk_accel_map_change_entry() about runtime accelerator changes.
/// </para>
/// <para>
/// If called more than once, @accel_group remains locked until
/// gtk_accel_group_unlock() has been called an equivalent number
/// of times.
/// </para>
/// </summary>

/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>

	public static T Lock<T>(this T accel_group) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_lock(accel_group);
		return accel_group;
	}

/// <summary>
/// <para>
/// Queries an accelerator group for all entries matching @accel_key
/// and @accel_mods.
/// </para>
/// </summary>

/// <param name="accel_group">
/// the accelerator group to query
/// </param>
/// <param name="accel_key">
/// key value of the accelerator
/// </param>
/// <param name="accel_mods">
/// modifier combination of the accelerator
/// </param>
/// <param name="n_entries">
/// location to return the number
///     of entries found, or %NULL
/// </param>
/// <return>
/// an array of
///     @n_entries #GtkAccelGroupEntry elements, or %NULL. The array
///     is owned by GTK+ and must not be freed.
/// </return>

	public static MentorLake.Gtk.GtkAccelGroupEntry[] Query(this MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, out uint n_entries)
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		return GtkAccelGroupHandleExterns.gtk_accel_group_query(accel_group, accel_key, accel_mods, out n_entries);
	}

/// <summary>
/// <para>
/// Undoes the last call to gtk_accel_group_lock() on this @accel_group.
/// </para>
/// </summary>

/// <param name="accel_group">
/// a #GtkAccelGroup
/// </param>

	public static T Unlock<T>(this T accel_group) where T : GtkAccelGroupHandle
	{
		if (accel_group.IsInvalid) throw new Exception("Invalid handle (GtkAccelGroupHandle)");
		GtkAccelGroupHandleExterns.gtk_accel_group_unlock(accel_group);
		return accel_group;
	}

}

internal class GtkAccelGroupHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_accel_group_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.GLib.GQuark accel_quark, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle acceleratable, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_connect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_connect_by_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, string accel_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_disconnect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_disconnect_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelKeyHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelKeyHandle gtk_accel_group_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, MentorLake.Gtk.GtkAccelGroupFindFunc find_func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_group_get_is_locked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gtk_accel_group_get_modifier_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAccelGroupEntry[] gtk_accel_group_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, out uint n_entries);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_group_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelGroupHandle gtk_accel_group_from_accel_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);

}
