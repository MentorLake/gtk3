namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Accelerator maps are used to define runtime configurable accelerators.
/// Functions for manipulating them are are usually used by higher level
/// convenience mechanisms like #GtkUIManager and are thus considered
/// “low-level”. You’ll want to use them if you’re manually creating menus that
/// should have user-configurable accelerators.
/// </para>
/// <para>
/// An accelerator is uniquely defined by:
/// - accelerator path
/// - accelerator key
/// - accelerator modifiers
/// </para>
/// <para>
/// The accelerator path must consist of
/// “<WINDOWTYPE>/Category1/Category2/.../Action”, where WINDOWTYPE
/// should be a unique application-specific identifier that corresponds
/// to the kind of window the accelerator is being used in, e.g.
/// “Gimp-Image”, “Abiword-Document” or “Gnumeric-Settings”.
/// The “Category1/.../Action” portion is most appropriately chosen by
/// the action the accelerator triggers, i.e. for accelerators on menu
/// items, choose the item’s menu path, e.g. “File/Save As”,
/// “Image/View/Zoom” or “Edit/Select All”. So a full valid accelerator
/// path may look like: “<Gimp-Toolbox>/File/Dialogs/Tool Options...”.
/// </para>
/// <para>
/// All accelerators are stored inside one global #GtkAccelMap that can
/// be obtained using gtk_accel_map_get(). See
/// [Monitoring changes][monitoring-changes] for additional
/// details.
/// </para>
/// <para>
/// # Manipulating accelerators
/// </para>
/// <para>
/// New accelerators can be added using gtk_accel_map_add_entry().
/// To search for specific accelerator, use gtk_accel_map_lookup_entry().
/// Modifications of existing accelerators should be done using
/// gtk_accel_map_change_entry().
/// </para>
/// <para>
/// In order to avoid having some accelerators changed, they can be
/// locked using gtk_accel_map_lock_path(). Unlocking is done using
/// gtk_accel_map_unlock_path().
/// </para>
/// <para>
/// # Saving and loading accelerator maps
/// </para>
/// <para>
/// Accelerator maps can be saved to and loaded from some external
/// resource. For simple saving and loading from file,
/// gtk_accel_map_save() and gtk_accel_map_load() are provided.
/// Saving and loading can also be done by providing file descriptor
/// to gtk_accel_map_save_fd() and gtk_accel_map_load_fd().
/// </para>
/// <para>
/// # Monitoring changes
/// </para>
/// <para>
/// #GtkAccelMap object is only useful for monitoring changes of
/// accelerators. By connecting to #GtkAccelMap::changed signal, one
/// can monitor changes of all accelerators. It is also possible to
/// monitor only single accelerator path by using it as a detail of
/// the #GtkAccelMap::changed signal.
/// </para>
/// </summary>

public class GtkAccelMapHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Registers a new accelerator with the global accelerator map.
/// This function should only be called once per @accel_path
/// with the canonical @accel_key and @accel_mods for this path.
/// To change the accelerator during runtime programatically, use
/// gtk_accel_map_change_entry().
/// </para>
/// <para>
/// Set @accel_key and @accel_mods to 0 to request a removal of
/// the accelerator.
/// </para>
/// <para>
/// Note that @accel_path string will be stored in a #GQuark. Therefore, if you
/// pass a static string, you can save some memory by interning it first with
/// g_intern_static_string().
/// </para>
/// </summary>

/// <param name="accel_path">
/// valid accelerator path
/// </param>
/// <param name="accel_key">
/// the accelerator key
/// </param>
/// <param name="accel_mods">
/// the accelerator modifiers
/// </param>

	public static void AddEntry(string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_add_entry(accel_path, accel_key, accel_mods);
	}

/// <summary>
/// <para>
/// Adds a filter to the global list of accel path filters.
/// </para>
/// <para>
/// Accel map entries whose accel path matches one of the filters
/// are skipped by gtk_accel_map_foreach().
/// </para>
/// <para>
/// This function is intended for GTK+ modules that create their own
/// menus, but don’t want them to be saved into the applications accelerator
/// map dump.
/// </para>
/// </summary>

/// <param name="filter_pattern">
/// a pattern (see #GPatternSpec)
/// </param>

	public static void AddFilter(string filter_pattern)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_add_filter(filter_pattern);
	}

/// <summary>
/// <para>
/// Changes the @accel_key and @accel_mods currently associated with @accel_path.
/// Due to conflicts with other accelerators, a change may not always be possible,
/// @replace indicates whether other accelerators may be deleted to resolve such
/// conflicts. A change will only occur if all conflicts could be resolved (which
/// might not be the case if conflicting accelerators are locked). Successful
/// changes are indicated by a %TRUE return value.
/// </para>
/// <para>
/// Note that @accel_path string will be stored in a #GQuark. Therefore, if you
/// pass a static string, you can save some memory by interning it first with
/// g_intern_static_string().
/// </para>
/// </summary>

/// <param name="accel_path">
/// a valid accelerator path
/// </param>
/// <param name="accel_key">
/// the new accelerator key
/// </param>
/// <param name="accel_mods">
/// the new accelerator modifiers
/// </param>
/// <param name="replace">
/// %TRUE if other accelerators may be deleted upon conflicts
/// </param>
/// <return>
/// %TRUE if the accelerator could be changed, %FALSE otherwise
/// </return>

	public static bool ChangeEntry(string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, bool replace)
	{
		return GtkAccelMapHandleExterns.gtk_accel_map_change_entry(accel_path, accel_key, accel_mods, replace);
	}

/// <summary>
/// <para>
/// Loops over the entries in the accelerator map whose accel path
/// doesn’t match any of the filters added with gtk_accel_map_add_filter(),
/// and execute @foreach_func on each. The signature of @foreach_func is
/// that of #GtkAccelMapForeach, the @changed parameter indicates whether
/// this accelerator was changed during runtime (thus, would need
/// saving during an accelerator map dump).
/// </para>
/// </summary>

/// <param name="data">
/// data to be passed into @foreach_func
/// </param>
/// <param name="foreach_func">
/// function to be executed for each accel
///                map entry which is not filtered out
/// </param>

	public static void Foreach(IntPtr data, MentorLake.Gtk.GtkAccelMapForeach foreach_func)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_foreach(data, foreach_func);
	}

/// <summary>
/// <para>
/// Loops over all entries in the accelerator map, and execute
/// @foreach_func on each. The signature of @foreach_func is that of
/// #GtkAccelMapForeach, the @changed parameter indicates whether
/// this accelerator was changed during runtime (thus, would need
/// saving during an accelerator map dump).
/// </para>
/// </summary>

/// <param name="data">
/// data to be passed into @foreach_func
/// </param>
/// <param name="foreach_func">
/// function to be executed for each accel
///                map entry
/// </param>

	public static void ForeachUnfiltered(IntPtr data, MentorLake.Gtk.GtkAccelMapForeach foreach_func)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_foreach_unfiltered(data, foreach_func);
	}

/// <summary>
/// <para>
/// Gets the singleton global #GtkAccelMap object. This object
/// is useful only for notification of changes to the accelerator
/// map via the ::changed signal; it isn’t a parameter to the
/// other accelerator map functions.
/// </para>
/// </summary>

/// <return>
/// the global #GtkAccelMap object
/// </return>

	public static MentorLake.Gtk.GtkAccelMapHandle Get()
	{
		return GtkAccelMapHandleExterns.gtk_accel_map_get();
	}

/// <summary>
/// <para>
/// Parses a file previously saved with gtk_accel_map_save() for
/// accelerator specifications, and propagates them accordingly.
/// </para>
/// </summary>

/// <param name="file_name">
/// a file containing accelerator specifications,
///   in the GLib file name encoding
/// </param>

	public static void Load(string file_name)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_load(file_name);
	}

/// <summary>
/// <para>
/// Filedescriptor variant of gtk_accel_map_load().
/// </para>
/// <para>
/// Note that the file descriptor will not be closed by this function.
/// </para>
/// </summary>

/// <param name="fd">
/// a valid readable file descriptor
/// </param>

	public static void LoadFd(int fd)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_load_fd(fd);
	}

/// <summary>
/// <para>
/// #GScanner variant of gtk_accel_map_load().
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner which has already been provided with an input file
/// </param>

	public static void LoadScanner(MentorLake.GLib.GScannerHandle scanner)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_load_scanner(scanner);
	}

/// <summary>
/// <para>
/// Locks the given accelerator path. If the accelerator map doesn’t yet contain
/// an entry for @accel_path, a new one is created.
/// </para>
/// <para>
/// Locking an accelerator path prevents its accelerator from being changed
/// during runtime. A locked accelerator path can be unlocked by
/// gtk_accel_map_unlock_path(). Refer to gtk_accel_map_change_entry()
/// for information about runtime accelerator changes.
/// </para>
/// <para>
/// If called more than once, @accel_path remains locked until
/// gtk_accel_map_unlock_path() has been called an equivalent number
/// of times.
/// </para>
/// <para>
/// Note that locking of individual accelerator paths is independent from
/// locking the #GtkAccelGroup containing them. For runtime accelerator
/// changes to be possible, both the accelerator path and its #GtkAccelGroup
/// have to be unlocked.
/// </para>
/// </summary>

/// <param name="accel_path">
/// a valid accelerator path
/// </param>

	public static void LockPath(string accel_path)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_lock_path(accel_path);
	}

/// <summary>
/// <para>
/// Looks up the accelerator entry for @accel_path and fills in @key.
/// </para>
/// </summary>

/// <param name="accel_path">
/// a valid accelerator path
/// </param>
/// <param name="key">
/// the accelerator key to be filled in (optional)
/// </param>
/// <return>
/// %TRUE if @accel_path is known, %FALSE otherwise
/// </return>

	public static bool LookupEntry(string accel_path, out MentorLake.Gtk.GtkAccelKey key)
	{
		return GtkAccelMapHandleExterns.gtk_accel_map_lookup_entry(accel_path, out key);
	}

/// <summary>
/// <para>
/// Saves current accelerator specifications (accelerator path, key
/// and modifiers) to @file_name.
/// The file is written in a format suitable to be read back in by
/// gtk_accel_map_load().
/// </para>
/// </summary>

/// <param name="file_name">
/// the name of the file to contain
///   accelerator specifications, in the GLib file name encoding
/// </param>

	public static void Save(string file_name)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_save(file_name);
	}

/// <summary>
/// <para>
/// Filedescriptor variant of gtk_accel_map_save().
/// </para>
/// <para>
/// Note that the file descriptor will not be closed by this function.
/// </para>
/// </summary>

/// <param name="fd">
/// a valid writable file descriptor
/// </param>

	public static void SaveFd(int fd)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_save_fd(fd);
	}

/// <summary>
/// <para>
/// Undoes the last call to gtk_accel_map_lock_path() on this @accel_path.
/// Refer to gtk_accel_map_lock_path() for information about accelerator path locking.
/// </para>
/// </summary>

/// <param name="accel_path">
/// a valid accelerator path
/// </param>

	public static void UnlockPath(string accel_path)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_unlock_path(accel_path);
	}

}
public static class GtkAccelMapHandleSignalExtensions
{
/// <summary>
/// <para>
/// Notifies of a change in the global accelerator map.
/// The path is also used as the detail for the signal,
/// so it is possible to connect to
/// changed::`accel_path`.
/// </para>
/// </summary>

	public static IObservable<GtkAccelMapHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkAccelMapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAccelMapHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkAccelMapHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkAccelMapHandle self,  string accel_path,  uint accel_key,  MentorLake.Gdk.GdkModifierType accel_mods,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelMapHandleSignalStructs.ChangedSignal()
				{
					Self = self, AccelPath = accel_path, AccelKey = accel_key, AccelMods = accel_mods, UserData = user_data
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
}

public static class GtkAccelMapHandleSignalStructs
{

public class ChangedSignal
{

	public MentorLake.Gtk.GtkAccelMapHandle Self;
/// <summary>
/// <para>
/// the path of the accelerator that changed
/// </para>
/// </summary>

	public string AccelPath;
/// <summary>
/// <para>
/// the key value for the new accelerator
/// </para>
/// </summary>

	public uint AccelKey;
/// <summary>
/// <para>
/// the modifier mask for the new accelerator
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkModifierType AccelMods;

	public IntPtr UserData;
}
}

public static class GtkAccelMapHandleSignalDelegates
{

/// <summary>
/// <para>
/// Notifies of a change in the global accelerator map.
/// The path is also used as the detail for the signal,
/// so it is possible to connect to
/// changed::`accel_path`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="accel_path">
/// the path of the accelerator that changed
/// </param>
/// <param name="accel_key">
/// the key value for the new accelerator
/// </param>
/// <param name="accel_mods">
/// the modifier mask for the new accelerator
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelMapHandle>))] MentorLake.Gtk.GtkAccelMapHandle self, string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, IntPtr user_data);

}


public static class GtkAccelMapHandleExtensions
{
}

internal class GtkAccelMapHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_add_entry(string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_add_filter(string filter_pattern);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_map_change_entry(string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, bool replace);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_foreach(IntPtr data, MentorLake.Gtk.GtkAccelMapForeach foreach_func);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_foreach_unfiltered(IntPtr data, MentorLake.Gtk.GtkAccelMapForeach foreach_func);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelMapHandle>))]
	internal static extern MentorLake.Gtk.GtkAccelMapHandle gtk_accel_map_get();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_load(string file_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_load_fd(int fd);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_load_scanner([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_lock_path(string accel_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_map_lookup_entry(string accel_path, out MentorLake.Gtk.GtkAccelKey key);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_save(string file_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_save_fd(int fd);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_map_unlock_path(string accel_path);

}
