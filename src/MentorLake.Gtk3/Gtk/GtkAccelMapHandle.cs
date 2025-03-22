namespace MentorLake.Gtk;

public class GtkAccelMapHandle : GObjectHandle
{
	public static void AddEntry(string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_add_entry(accel_path, accel_key, accel_mods);
	}

	public static void AddFilter(string filter_pattern)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_add_filter(filter_pattern);
	}

	public static bool ChangeEntry(string accel_path, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, bool replace)
	{
		return GtkAccelMapHandleExterns.gtk_accel_map_change_entry(accel_path, accel_key, accel_mods, replace);
	}

	public static void Foreach(IntPtr data, MentorLake.Gtk.GtkAccelMapForeach foreach_func)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_foreach(data, foreach_func);
	}

	public static void ForeachUnfiltered(IntPtr data, MentorLake.Gtk.GtkAccelMapForeach foreach_func)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_foreach_unfiltered(data, foreach_func);
	}

	public static MentorLake.Gtk.GtkAccelMapHandle Get()
	{
		return GtkAccelMapHandleExterns.gtk_accel_map_get();
	}

	public static void Load(string file_name)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_load(file_name);
	}

	public static void LoadFd(int fd)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_load_fd(fd);
	}

	public static void LoadScanner(MentorLake.GLib.GScannerHandle scanner)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_load_scanner(scanner);
	}

	public static void LockPath(string accel_path)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_lock_path(accel_path);
	}

	public static bool LookupEntry(string accel_path, out MentorLake.Gtk.GtkAccelKey key)
	{
		return GtkAccelMapHandleExterns.gtk_accel_map_lookup_entry(accel_path, out key);
	}

	public static void Save(string file_name)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_save(file_name);
	}

	public static void SaveFd(int fd)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_save_fd(fd);
	}

	public static void UnlockPath(string accel_path)
	{
		GtkAccelMapHandleExterns.gtk_accel_map_unlock_path(accel_path);
	}

}
public static class GtkAccelMapHandleSignalExtensions
{

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

public struct ChangedSignal
{
	public MentorLake.Gtk.GtkAccelMapHandle Self;
	public string AccelPath;
	public uint AccelKey;
	public MentorLake.Gdk.GdkModifierType AccelMods;
	public IntPtr UserData;
}
}

public static class GtkAccelMapHandleSignalDelegates
{

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
