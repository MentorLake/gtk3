namespace MentorLake.Gtk3.Gtk3;

public class GtkIconThemeHandle : GObjectHandle
{
	public static GtkIconThemeHandle New()
	{
		return GtkIconThemeExterns.gtk_icon_theme_new();
	}

	public static void AddBuiltinIcon(string icon_name, int size, GdkPixbufHandle pixbuf)
	{
		GtkIconThemeExterns.gtk_icon_theme_add_builtin_icon(icon_name, size, pixbuf);
	}

	public static GtkIconThemeHandle GetDefault()
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_default();
	}

	public static GtkIconThemeHandle GetForScreen(GdkScreenHandle screen)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_for_screen(screen);
	}

}

public static class GtkIconThemeSignalExtensions
{

	public static IObservable<GtkIconThemeSignalStructs.ChangedSignal> Signal_Changed(this GtkIconThemeHandle instance)
	{
		return Observable.Create((IObserver<GtkIconThemeSignalStructs.ChangedSignal> obs) =>
		{
			GtkIconThemeSignalDelegates.changed handler = (GtkIconThemeHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkIconThemeSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
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

public static class GtkIconThemeSignalStructs
{

public struct ChangedSignal
{
	public GtkIconThemeHandle Self;
	public IntPtr UserData;
}
}

public static class GtkIconThemeSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIconThemeHandle>))] GtkIconThemeHandle self, IntPtr user_data);

}


public static class GtkIconThemeHandleExtensions
{
	public static T AddResourcePath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		GtkIconThemeExterns.gtk_icon_theme_add_resource_path(icon_theme, path);
		return icon_theme;
	}

	public static T AppendSearchPath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		GtkIconThemeExterns.gtk_icon_theme_append_search_path(icon_theme, path);
		return icon_theme;
	}

	public static GtkIconInfoHandle ChooseIcon(this GtkIconThemeHandle icon_theme, string[] icon_names, int size, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_choose_icon(icon_theme, icon_names, size, flags);
	}

	public static GtkIconInfoHandle ChooseIconForScale(this GtkIconThemeHandle icon_theme, string[] icon_names, int size, int scale, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_choose_icon_for_scale(icon_theme, icon_names, size, scale, flags);
	}

	public static string GetExampleIconName(this GtkIconThemeHandle icon_theme)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_example_icon_name(icon_theme);
	}

	public static IntPtr GetIconSizes(this GtkIconThemeHandle icon_theme, string icon_name)
	{
		return GtkIconThemeExterns.gtk_icon_theme_get_icon_sizes(icon_theme, icon_name);
	}

	public static T GetSearchPath<T>(this T icon_theme, out string[] path, out int n_elements) where T : GtkIconThemeHandle
	{
		GtkIconThemeExterns.gtk_icon_theme_get_search_path(icon_theme, out path, out n_elements);
		return icon_theme;
	}

	public static bool HasIcon(this GtkIconThemeHandle icon_theme, string icon_name)
	{
		return GtkIconThemeExterns.gtk_icon_theme_has_icon(icon_theme, icon_name);
	}

	public static GListHandle ListContexts(this GtkIconThemeHandle icon_theme)
	{
		return GtkIconThemeExterns.gtk_icon_theme_list_contexts(icon_theme);
	}

	public static GListHandle ListIcons(this GtkIconThemeHandle icon_theme, string context)
	{
		return GtkIconThemeExterns.gtk_icon_theme_list_icons(icon_theme, context);
	}

	public static GdkPixbufHandle LoadIcon(this GtkIconThemeHandle icon_theme, string icon_name, int size, GtkIconLookupFlags flags, out GErrorHandle error)
	{
		return GtkIconThemeExterns.gtk_icon_theme_load_icon(icon_theme, icon_name, size, flags, out error);
	}

	public static GdkPixbufHandle LoadIconForScale(this GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, GtkIconLookupFlags flags, out GErrorHandle error)
	{
		return GtkIconThemeExterns.gtk_icon_theme_load_icon_for_scale(icon_theme, icon_name, size, scale, flags, out error);
	}

	public static cairo_surface_tHandle LoadSurface(this GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, GdkWindowHandle for_window, GtkIconLookupFlags flags, out GErrorHandle error)
	{
		return GtkIconThemeExterns.gtk_icon_theme_load_surface(icon_theme, icon_name, size, scale, for_window, flags, out error);
	}

	public static GtkIconInfoHandle LookupByGicon(this GtkIconThemeHandle icon_theme, GIconHandle icon, int size, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_by_gicon(icon_theme, icon, size, flags);
	}

	public static GtkIconInfoHandle LookupByGiconForScale(this GtkIconThemeHandle icon_theme, GIconHandle icon, int size, int scale, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_by_gicon_for_scale(icon_theme, icon, size, scale, flags);
	}

	public static GtkIconInfoHandle LookupIcon(this GtkIconThemeHandle icon_theme, string icon_name, int size, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_icon(icon_theme, icon_name, size, flags);
	}

	public static GtkIconInfoHandle LookupIconForScale(this GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, GtkIconLookupFlags flags)
	{
		return GtkIconThemeExterns.gtk_icon_theme_lookup_icon_for_scale(icon_theme, icon_name, size, scale, flags);
	}

	public static T PrependSearchPath<T>(this T icon_theme, string path) where T : GtkIconThemeHandle
	{
		GtkIconThemeExterns.gtk_icon_theme_prepend_search_path(icon_theme, path);
		return icon_theme;
	}

	public static bool RescanIfNeeded(this GtkIconThemeHandle icon_theme)
	{
		return GtkIconThemeExterns.gtk_icon_theme_rescan_if_needed(icon_theme);
	}

	public static T SetCustomTheme<T>(this T icon_theme, string theme_name) where T : GtkIconThemeHandle
	{
		GtkIconThemeExterns.gtk_icon_theme_set_custom_theme(icon_theme, theme_name);
		return icon_theme;
	}

	public static T SetScreen<T>(this T icon_theme, GdkScreenHandle screen) where T : GtkIconThemeHandle
	{
		GtkIconThemeExterns.gtk_icon_theme_set_screen(icon_theme, screen);
		return icon_theme;
	}

	public static T SetSearchPath<T>(this T icon_theme, string[] path, int n_elements) where T : GtkIconThemeHandle
	{
		GtkIconThemeExterns.gtk_icon_theme_set_search_path(icon_theme, path, n_elements);
		return icon_theme;
	}

}

internal class GtkIconThemeExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconThemeHandle gtk_icon_theme_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_add_resource_path(GtkIconThemeHandle icon_theme, string path);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_append_search_path(GtkIconThemeHandle icon_theme, string path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_theme_choose_icon(GtkIconThemeHandle icon_theme, string[] icon_names, int size, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_theme_choose_icon_for_scale(GtkIconThemeHandle icon_theme, string[] icon_names, int size, int scale, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_icon_theme_get_example_icon_name(GtkIconThemeHandle icon_theme);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_icon_theme_get_icon_sizes(GtkIconThemeHandle icon_theme, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_get_search_path(GtkIconThemeHandle icon_theme, out string[] path, out int n_elements);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_theme_has_icon(GtkIconThemeHandle icon_theme, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_icon_theme_list_contexts(GtkIconThemeHandle icon_theme);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_icon_theme_list_icons(GtkIconThemeHandle icon_theme, string context);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_theme_load_icon(GtkIconThemeHandle icon_theme, string icon_name, int size, GtkIconLookupFlags flags, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_icon_theme_load_icon_for_scale(GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, GtkIconLookupFlags flags, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_surface_tHandle gtk_icon_theme_load_surface(GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, GdkWindowHandle for_window, GtkIconLookupFlags flags, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_theme_lookup_by_gicon(GtkIconThemeHandle icon_theme, GIconHandle icon, int size, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_theme_lookup_by_gicon_for_scale(GtkIconThemeHandle icon_theme, GIconHandle icon, int size, int scale, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_theme_lookup_icon(GtkIconThemeHandle icon_theme, string icon_name, int size, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconInfoHandle gtk_icon_theme_lookup_icon_for_scale(GtkIconThemeHandle icon_theme, string icon_name, int size, int scale, GtkIconLookupFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_prepend_search_path(GtkIconThemeHandle icon_theme, string path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_icon_theme_rescan_if_needed(GtkIconThemeHandle icon_theme);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_set_custom_theme(GtkIconThemeHandle icon_theme, string theme_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_set_screen(GtkIconThemeHandle icon_theme, GdkScreenHandle screen);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_set_search_path(GtkIconThemeHandle icon_theme, string[] path, int n_elements);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_icon_theme_add_builtin_icon(string icon_name, int size, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconThemeHandle gtk_icon_theme_get_default();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconThemeHandle gtk_icon_theme_get_for_screen(GdkScreenHandle screen);

}
