namespace MentorLake.Gdk;

public class GdkAppLaunchContextHandle : GAppLaunchContextHandle
{
	public static MentorLake.Gdk.GdkAppLaunchContextHandle New()
	{
		return GdkAppLaunchContextHandleExterns.gdk_app_launch_context_new();
	}

}

public static class GdkAppLaunchContextHandleExtensions
{
	public static T SetDesktop<T>(this T context, int desktop) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_desktop(context, desktop);
		return context;
	}

	public static T SetDisplay<T>(this T context, MentorLake.Gdk.GdkDisplayHandle display) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_display(context, display);
		return context;
	}

	public static T SetIcon<T>(this T context, MentorLake.Gio.GIconHandle icon) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_icon(context, icon);
		return context;
	}

	public static T SetIconName<T>(this T context, string icon_name) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_icon_name(context, icon_name);
		return context;
	}

	public static T SetScreen<T>(this T context, MentorLake.Gdk.GdkScreenHandle screen) where T : GdkAppLaunchContextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GdkAppLaunchContextHandle)");
		GdkAppLaunchContextHandleExterns.gdk_app_launch_context_set_screen(context, screen);
		return context;
	}

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
