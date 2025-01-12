namespace MentorLake.Gtk3.Gdk3;

public class GdkAppLaunchContextHandle : GAppLaunchContextHandle
{
	public static GdkAppLaunchContextHandle New()
	{
		return GdkAppLaunchContextExterns.gdk_app_launch_context_new();
	}

}

public static class GdkAppLaunchContextHandleExtensions
{
	public static T SetDesktop<T>(this T context, int desktop) where T : GdkAppLaunchContextHandle
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_desktop(context, desktop);
		return context;
	}

	public static T SetDisplay<T>(this T context, GdkDisplayHandle display) where T : GdkAppLaunchContextHandle
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_display(context, display);
		return context;
	}

	public static T SetIcon<T>(this T context, GIconHandle icon) where T : GdkAppLaunchContextHandle
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_icon(context, icon);
		return context;
	}

	public static T SetIconName<T>(this T context, string icon_name) where T : GdkAppLaunchContextHandle
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_icon_name(context, icon_name);
		return context;
	}

	public static T SetScreen<T>(this T context, GdkScreenHandle screen) where T : GdkAppLaunchContextHandle
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_screen(context, screen);
		return context;
	}

	public static T SetTimestamp<T>(this T context, uint timestamp) where T : GdkAppLaunchContextHandle
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_timestamp(context, timestamp);
		return context;
	}

}

internal class GdkAppLaunchContextExterns
{
	[DllImport(Libraries.Gdk3)]
	internal static extern GdkAppLaunchContextHandle gdk_app_launch_context_new();

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_app_launch_context_set_desktop(GdkAppLaunchContextHandle context, int desktop);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_app_launch_context_set_display(GdkAppLaunchContextHandle context, GdkDisplayHandle display);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_app_launch_context_set_icon(GdkAppLaunchContextHandle context, GIconHandle icon);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_app_launch_context_set_icon_name(GdkAppLaunchContextHandle context, string icon_name);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_app_launch_context_set_screen(GdkAppLaunchContextHandle context, GdkScreenHandle screen);

	[DllImport(Libraries.Gdk3)]
	internal static extern void gdk_app_launch_context_set_timestamp(GdkAppLaunchContextHandle context, uint timestamp);

}
