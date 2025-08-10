namespace MentorLake.Gtk;

public class GtkIconThemeHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkIconThemeHandle New()
	{
		return GtkIconThemeHandleExterns.gtk_icon_theme_new();
	}

	public static void AddBuiltinIcon(string icon_name, int size, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf)
	{
		GtkIconThemeHandleExterns.gtk_icon_theme_add_builtin_icon(icon_name, size, pixbuf);
	}

	public static MentorLake.Gtk.GtkIconThemeHandle GetDefault()
	{
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_default();
	}

	public static MentorLake.Gtk.GtkIconThemeHandle GetForScreen(MentorLake.Gdk.GdkScreenHandle screen)
	{
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_for_screen(screen);
	}

}
public static class GtkIconThemeHandleSignalExtensions
{

	public static IObservable<GtkIconThemeHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkIconThemeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkIconThemeHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkIconThemeHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkIconThemeHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconThemeHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
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

public static class GtkIconThemeHandleSignalStructs
{

public class ChangedSignal
{
	public MentorLake.Gtk.GtkIconThemeHandle Self;
	public IntPtr UserData;
}
}

public static class GtkIconThemeHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle self, IntPtr user_data);

}


public static class GtkIconThemeHandleExtensions
{
	public static T AddResourcePath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_add_resource_path(icon_theme, path);
		return icon_theme;
	}

	public static T AppendSearchPath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_append_search_path(icon_theme, path);
		return icon_theme;
	}

	public static MentorLake.Gtk.GtkIconInfoHandle ChooseIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_choose_icon(icon_theme, icon_names, size, flags);
	}

	public static MentorLake.Gtk.GtkIconInfoHandle ChooseIconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_choose_icon_for_scale(icon_theme, icon_names, size, scale, flags);
	}

	public static string GetExampleIconName(this MentorLake.Gtk.GtkIconThemeHandle icon_theme)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_example_icon_name(icon_theme);
	}

	public static int[] GetIconSizes(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_get_icon_sizes(icon_theme, icon_name);
	}

	public static T GetSearchPath<T>(this T icon_theme, out string[] path, out int n_elements) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_get_search_path(icon_theme, out path, out n_elements);
		return icon_theme;
	}

	public static bool HasIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_has_icon(icon_theme, icon_name);
	}

	public static MentorLake.GLib.GListHandle ListContexts(this MentorLake.Gtk.GtkIconThemeHandle icon_theme)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_list_contexts(icon_theme);
	}

	public static MentorLake.GLib.GListHandle ListIcons(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string context)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_list_icons(icon_theme, context);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		var externCallResult = GtkIconThemeHandleExterns.gtk_icon_theme_load_icon(icon_theme, icon_name, size, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle LoadIconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		var externCallResult = GtkIconThemeHandleExterns.gtk_icon_theme_load_icon_for_scale(icon_theme, icon_name, size, scale, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.cairo.cairo_surface_tHandle LoadSurface(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gdk.GdkWindowHandle for_window, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		var externCallResult = GtkIconThemeHandleExterns.gtk_icon_theme_load_surface(icon_theme, icon_name, size, scale, for_window, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gtk.GtkIconInfoHandle LookupByGicon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, MentorLake.Gio.GIconHandle icon, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_by_gicon(icon_theme, icon, size, flags);
	}

	public static MentorLake.Gtk.GtkIconInfoHandle LookupByGiconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, MentorLake.Gio.GIconHandle icon, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_by_gicon_for_scale(icon_theme, icon, size, scale, flags);
	}

	public static MentorLake.Gtk.GtkIconInfoHandle LookupIcon(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_icon(icon_theme, icon_name, size, flags);
	}

	public static MentorLake.Gtk.GtkIconInfoHandle LookupIconForScale(this MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_lookup_icon_for_scale(icon_theme, icon_name, size, scale, flags);
	}

	public static T PrependSearchPath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_prepend_search_path(icon_theme, path);
		return icon_theme;
	}

	public static bool RescanIfNeeded(this MentorLake.Gtk.GtkIconThemeHandle icon_theme)
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		return GtkIconThemeHandleExterns.gtk_icon_theme_rescan_if_needed(icon_theme);
	}

	public static T SetCustomTheme<T>(this T icon_theme, string theme_name) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_set_custom_theme(icon_theme, theme_name);
		return icon_theme;
	}

	public static T SetScreen<T>(this T icon_theme, MentorLake.Gdk.GdkScreenHandle screen) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_set_screen(icon_theme, screen);
		return icon_theme;
	}

	public static T SetSearchPath<T>(this T icon_theme, string[] path, int n_elements) where T : GtkIconThemeHandle
	{
		if (icon_theme.IsInvalid) throw new Exception("Invalid handle (GtkIconThemeHandle)");
		GtkIconThemeHandleExterns.gtk_icon_theme_set_search_path(icon_theme, path, n_elements);
		return icon_theme;
	}

}

internal class GtkIconThemeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))]
	internal static extern MentorLake.Gtk.GtkIconThemeHandle gtk_icon_theme_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_add_resource_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_append_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_choose_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_choose_icon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] icon_names, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_theme_get_example_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme);

	[DllImport(GtkLibrary.Name)]
	internal static extern int[] gtk_icon_theme_get_icon_sizes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_get_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out string[] path, out int n_elements);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_theme_has_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_icon_theme_list_contexts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_icon_theme_list_icons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string context);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_theme_load_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_icon_theme_load_icon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_icon_theme_load_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle for_window, MentorLake.Gtk.GtkIconLookupFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_by_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, int size, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_by_gicon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIconInfoHandle>))]
	internal static extern MentorLake.Gtk.GtkIconInfoHandle gtk_icon_theme_lookup_icon_for_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, MentorLake.Gtk.GtkIconLookupFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_prepend_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_icon_theme_rescan_if_needed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_set_custom_theme([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string theme_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_set_search_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))] MentorLake.Gtk.GtkIconThemeHandle icon_theme, string[] path, int n_elements);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_icon_theme_add_builtin_icon(string icon_name, int size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))]
	internal static extern MentorLake.Gtk.GtkIconThemeHandle gtk_icon_theme_get_default();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIconThemeHandle>))]
	internal static extern MentorLake.Gtk.GtkIconThemeHandle gtk_icon_theme_get_for_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

}
