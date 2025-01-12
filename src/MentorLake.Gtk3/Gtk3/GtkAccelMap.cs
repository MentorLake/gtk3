namespace MentorLake.Gtk3.Gtk3;

public class GtkAccelMapHandle : GObjectHandle
{
	public static void AddEntry(string accel_path, uint accel_key, GdkModifierType accel_mods)
	{
		GtkAccelMapExterns.gtk_accel_map_add_entry(accel_path, accel_key, accel_mods);
	}

	public static void AddFilter(string filter_pattern)
	{
		GtkAccelMapExterns.gtk_accel_map_add_filter(filter_pattern);
	}

	public static bool ChangeEntry(string accel_path, uint accel_key, GdkModifierType accel_mods, bool replace)
	{
		return GtkAccelMapExterns.gtk_accel_map_change_entry(accel_path, accel_key, accel_mods, replace);
	}

	public static void Foreach(IntPtr data, GtkAccelMapForeach foreach_func)
	{
		GtkAccelMapExterns.gtk_accel_map_foreach(data, foreach_func);
	}

	public static void ForeachUnfiltered(IntPtr data, GtkAccelMapForeach foreach_func)
	{
		GtkAccelMapExterns.gtk_accel_map_foreach_unfiltered(data, foreach_func);
	}

	public static GtkAccelMapHandle Get()
	{
		return GtkAccelMapExterns.gtk_accel_map_get();
	}

	public static void Load(string file_name)
	{
		GtkAccelMapExterns.gtk_accel_map_load(file_name);
	}

	public static void LoadFd(int fd)
	{
		GtkAccelMapExterns.gtk_accel_map_load_fd(fd);
	}

	public static void LoadScanner(GScannerHandle scanner)
	{
		GtkAccelMapExterns.gtk_accel_map_load_scanner(scanner);
	}

	public static void LockPath(string accel_path)
	{
		GtkAccelMapExterns.gtk_accel_map_lock_path(accel_path);
	}

	public static bool LookupEntry(string accel_path, out GtkAccelKey key)
	{
		return GtkAccelMapExterns.gtk_accel_map_lookup_entry(accel_path, out key);
	}

	public static void Save(string file_name)
	{
		GtkAccelMapExterns.gtk_accel_map_save(file_name);
	}

	public static void SaveFd(int fd)
	{
		GtkAccelMapExterns.gtk_accel_map_save_fd(fd);
	}

	public static void UnlockPath(string accel_path)
	{
		GtkAccelMapExterns.gtk_accel_map_unlock_path(accel_path);
	}

}

public static class GtkAccelMapSignalExtensions
{

	public static IObservable<GtkAccelMapSignalStructs.ChangedSignal> Signal_Changed(this GtkAccelMapHandle instance)
	{
		return Observable.Create((IObserver<GtkAccelMapSignalStructs.ChangedSignal> obs) =>
		{
			GtkAccelMapSignalDelegates.changed handler = (GtkAccelMapHandle self, string accel_path, uint accel_key, ref GdkModifierType accel_mods, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAccelMapSignalStructs.ChangedSignal()
				{
					Self = self, AccelPath = accel_path, AccelKey = accel_key, AccelMods = accel_mods, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkAccelMapSignalStructs
{

public struct ChangedSignal
{
	public GtkAccelMapHandle Self;
	public string AccelPath;
	public uint AccelKey;
	public GdkModifierType AccelMods;
	public IntPtr UserData;
}
}

public static class GtkAccelMapSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAccelMapHandle>))] GtkAccelMapHandle self, string accel_path, uint accel_key, ref GdkModifierType accel_mods, IntPtr user_data);

}


public static class GtkAccelMapHandleExtensions
{
}

internal class GtkAccelMapExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_add_entry(string accel_path, uint accel_key, GdkModifierType accel_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_add_filter(string filter_pattern);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_map_change_entry(string accel_path, uint accel_key, GdkModifierType accel_mods, bool replace);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_foreach(IntPtr data, GtkAccelMapForeach foreach_func);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_foreach_unfiltered(IntPtr data, GtkAccelMapForeach foreach_func);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAccelMapHandle gtk_accel_map_get();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_load(string file_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_load_fd(int fd);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_load_scanner(GScannerHandle scanner);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_lock_path(string accel_path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_accel_map_lookup_entry(string accel_path, out GtkAccelKey key);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_save(string file_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_save_fd(int fd);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_accel_map_unlock_path(string accel_path);

}
