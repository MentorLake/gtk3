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
	public static GdkAppLaunchContextHandle SetDesktop(this GdkAppLaunchContextHandle context, int desktop)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_desktop(context, desktop);
		return context;
	}

	public static GdkAppLaunchContextHandle SetDisplay(this GdkAppLaunchContextHandle context, GdkDisplayHandle display)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_display(context, display);
		return context;
	}

	public static GdkAppLaunchContextHandle SetIcon(this GdkAppLaunchContextHandle context, GIconHandle icon)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_icon(context, icon);
		return context;
	}

	public static GdkAppLaunchContextHandle SetIconName(this GdkAppLaunchContextHandle context, string icon_name)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_icon_name(context, icon_name);
		return context;
	}

	public static GdkAppLaunchContextHandle SetScreen(this GdkAppLaunchContextHandle context, GdkScreenHandle screen)
	{
		GdkAppLaunchContextExterns.gdk_app_launch_context_set_screen(context, screen);
		return context;
	}

	public static GdkAppLaunchContextHandle SetTimestamp(this GdkAppLaunchContextHandle context, uint timestamp)
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
