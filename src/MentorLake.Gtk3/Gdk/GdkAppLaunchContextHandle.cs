namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// GdkAppLaunchContext is an implementation of #GAppLaunchContext that
/// handles launching an application in a graphical context. It provides
/// startup notification and allows to launch applications on a specific
/// screen or workspace.
/// </para>
/// <para>
/// ## Launching an application
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// GdkAppLaunchContext *context;
/// </para>
/// <para>
/// context = gdk_display_get_app_launch_context (display);
/// </para>
/// <para>
/// gdk_app_launch_context_set_screen (screen);
/// gdk_app_launch_context_set_timestamp (event->time);
/// </para>
/// <para>
/// if (!g_app_info_launch_default_for_uri ("http://www.gtk.org", context, &error))
///   g_warning ("Launching failed: %s\n", error->message);
/// </para>
/// <para>
/// g_object_unref (context);
/// ]|
/// </para>
/// </summary>

public class GdkAppLaunchContextHandle : GAppLaunchContextHandle
{
/// <summary>
/// <para>
/// Creates a new #GdkAppLaunchContext.
/// </para>
/// </summary>

/// <return>
/// a new #GdkAppLaunchContext
/// </return>

	public static MentorLake.Gdk.GdkAppLaunchContextHandle New()
	{
		return GdkAppLaunchContextHandleExterns.gdk_app_launch_context_new();
	}

}

public static class GdkAppLaunchContextHandleExtensions
{
/// <summary>
/// <para>
/// Sets the workspace on which applications will be launched when
/// using this context when running under a window manager that
/// supports multiple workspaces, as described in the
/// [Extended Window Manager Hints](http://www.freedesktop.org/Standards/wm-spec).
/// </para>
/// <para>
/// When the workspace is not specified or @desktop is set to -1,
/// it is up to the window manager to pick one, typically it will
/// be the current workspace.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkAppLaunchContext
/// </param>
/// <param name="desktop">
/// the number of a workspace, or -1
/// </param>

	public static T SetDesktop<T>(this T context, int desktop) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_desktop(context, desktop);
		return context;
	}

/// <summary>
/// <para>
/// Sets the display on which applications will be launched when
/// using this context. See also gdk_app_launch_context_set_screen().
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkAppLaunchContext
/// </param>
/// <param name="display">
/// a #GdkDisplay
/// </param>

	public static T SetDisplay<T>(this T context, MentorLake.Gdk.GdkDisplayHandle display) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_display(context, display);
		return context;
	}

/// <summary>
/// <para>
/// Sets the icon for applications that are launched with this
/// context.
/// </para>
/// <para>
/// Window Managers can use this information when displaying startup
/// notification.
/// </para>
/// <para>
/// See also gdk_app_launch_context_set_icon_name().
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkAppLaunchContext
/// </param>
/// <param name="icon">
/// a #GIcon, or %NULL
/// </param>

	public static T SetIcon<T>(this T context, MentorLake.Gio.GIconHandle icon) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_icon(context, icon);
		return context;
	}

/// <summary>
/// <para>
/// Sets the icon for applications that are launched with this context.
/// The @icon_name will be interpreted in the same way as the Icon field
/// in desktop files. See also gdk_app_launch_context_set_icon().
/// </para>
/// <para>
/// If both @icon and @icon_name are set, the @icon_name takes priority.
/// If neither @icon or @icon_name is set, the icon is taken from either
/// the file that is passed to launched application or from the #GAppInfo
/// for the launched application itself.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkAppLaunchContext
/// </param>
/// <param name="icon_name">
/// an icon name, or %NULL
/// </param>

	public static T SetIconName<T>(this T context, string icon_name) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_icon_name(context, icon_name);
		return context;
	}

/// <summary>
/// <para>
/// Sets the screen on which applications will be launched when
/// using this context. See also gdk_app_launch_context_set_display().
/// </para>
/// <para>
/// Note that, typically, a #GdkScreen represents a logical screen,
/// not a physical monitor.
/// </para>
/// <para>
/// If both @screen and @display are set, the @screen takes priority.
/// If neither @screen or @display are set, the default screen and
/// display are used.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkAppLaunchContext
/// </param>
/// <param name="screen">
/// a #GdkScreen
/// </param>

	public static T SetScreen<T>(this T context, MentorLake.Gdk.GdkScreenHandle screen) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_screen(context, screen);
		return context;
	}

/// <summary>
/// <para>
/// Sets the timestamp of @context. The timestamp should ideally
/// be taken from the event that triggered the launch.
/// </para>
/// <para>
/// Window managers can use this information to avoid moving the
/// focus to the newly launched application when the user is busy
/// typing in another window. This is also known as 'focus stealing
/// prevention'.
/// </para>
/// </summary>

/// <param name="context">
/// a #GdkAppLaunchContext
/// </param>
/// <param name="timestamp">
/// a timestamp
/// </param>

	public static T SetTimestamp<T>(this T context, uint timestamp) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_timestamp(context, timestamp);
		return context;
	}

}

internal class GdkAppLaunchContextHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))]
	internal static extern MentorLake.Gdk.GdkAppLaunchContextHandle gdk_app_launch_context_new();

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_app_launch_context_set_desktop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))] MentorLake.Gdk.GdkAppLaunchContextHandle context, int desktop);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_app_launch_context_set_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))] MentorLake.Gdk.GdkAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_app_launch_context_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))] MentorLake.Gdk.GdkAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_app_launch_context_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))] MentorLake.Gdk.GdkAppLaunchContextHandle context, string icon_name);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_app_launch_context_set_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))] MentorLake.Gdk.GdkAppLaunchContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle screen);

	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_app_launch_context_set_timestamp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkAppLaunchContextHandle>))] MentorLake.Gdk.GdkAppLaunchContextHandle context, uint timestamp);

}
