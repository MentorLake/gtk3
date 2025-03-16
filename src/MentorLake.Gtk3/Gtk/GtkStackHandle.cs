namespace MentorLake.Gtk;

public class GtkStackHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkStackHandle New()
	{
		return GtkStackHandleExterns.gtk_stack_new();
	}

}

public static class GtkStackHandleExtensions
{
	public static T AddNamed<T>(this T stack, MentorLake.Gtk.GtkWidgetHandle child, string name) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_add_named(stack, child, name);
		return stack;
	}

	public static T AddTitled<T>(this T stack, MentorLake.Gtk.GtkWidgetHandle child, string name, string title) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_add_titled(stack, child, name, title);
		return stack;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetChildByName(this MentorLake.Gtk.GtkStackHandle stack, string name)
	{
		return GtkStackHandleExterns.gtk_stack_get_child_by_name(stack, name);
	}

	public static bool GetHhomogeneous(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_hhomogeneous(stack);
	}

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_homogeneous(stack);
	}

	public static bool GetInterpolateSize(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_interpolate_size(stack);
	}

	public static uint GetTransitionDuration(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_transition_duration(stack);
	}

	public static bool GetTransitionRunning(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_transition_running(stack);
	}

	public static MentorLake.Gtk.GtkStackTransitionType GetTransitionType(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_transition_type(stack);
	}

	public static bool GetVhomogeneous(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_vhomogeneous(stack);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetVisibleChild(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_visible_child(stack);
	}

	public static string GetVisibleChildName(this MentorLake.Gtk.GtkStackHandle stack)
	{
		return GtkStackHandleExterns.gtk_stack_get_visible_child_name(stack);
	}

	public static T SetHhomogeneous<T>(this T stack, bool hhomogeneous) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_hhomogeneous(stack, hhomogeneous);
		return stack;
	}

	public static T SetHomogeneous<T>(this T stack, bool homogeneous) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_homogeneous(stack, homogeneous);
		return stack;
	}

	public static T SetInterpolateSize<T>(this T stack, bool interpolate_size) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_interpolate_size(stack, interpolate_size);
		return stack;
	}

	public static T SetTransitionDuration<T>(this T stack, uint duration) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_transition_duration(stack, duration);
		return stack;
	}

	public static T SetTransitionType<T>(this T stack, MentorLake.Gtk.GtkStackTransitionType transition) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_transition_type(stack, transition);
		return stack;
	}

	public static T SetVhomogeneous<T>(this T stack, bool vhomogeneous) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_vhomogeneous(stack, vhomogeneous);
		return stack;
	}

	public static T SetVisibleChild<T>(this T stack, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_visible_child(stack, child);
		return stack;
	}

	public static T SetVisibleChildFull<T>(this T stack, string name, MentorLake.Gtk.GtkStackTransitionType transition) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_visible_child_full(stack, name, transition);
		return stack;
	}

	public static T SetVisibleChildName<T>(this T stack, string name) where T : GtkStackHandle
	{
		GtkStackHandleExterns.gtk_stack_set_visible_child_name(stack, name);
		return stack;
	}

}

internal class GtkStackHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStackHandle gtk_stack_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_add_named([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_add_titled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string name, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_stack_get_child_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_stack_get_hhomogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_stack_get_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_stack_get_interpolate_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_stack_get_transition_duration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_stack_get_transition_running([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStackTransitionType gtk_stack_get_transition_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_stack_get_vhomogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_stack_get_visible_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_stack_get_visible_child_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_hhomogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, bool hhomogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_homogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, bool homogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_interpolate_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, bool interpolate_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_transition_duration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, uint duration);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_transition_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, MentorLake.Gtk.GtkStackTransitionType transition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_vhomogeneous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, bool vhomogeneous);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_visible_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_visible_child_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, string name, MentorLake.Gtk.GtkStackTransitionType transition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_set_visible_child_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, string name);

}
