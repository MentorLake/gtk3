namespace MentorLake.Gtk3.Gtk3;

public class GtkStackHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkStackHandle New()
	{
		return GtkStackExterns.gtk_stack_new();
	}

}

public static class GtkStackHandleExtensions
{
	public static T AddNamed<T>(this T stack, GtkWidgetHandle child, string name) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_add_named(stack, child, name);
		return stack;
	}

	public static T AddTitled<T>(this T stack, GtkWidgetHandle child, string name, string title) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_add_titled(stack, child, name, title);
		return stack;
	}

	public static GtkWidgetHandle GetChildByName(this GtkStackHandle stack, string name)
	{
		return GtkStackExterns.gtk_stack_get_child_by_name(stack, name);
	}

	public static bool GetHhomogeneous(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_hhomogeneous(stack);
	}

	public static bool GetHomogeneous(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_homogeneous(stack);
	}

	public static bool GetInterpolateSize(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_interpolate_size(stack);
	}

	public static uint GetTransitionDuration(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_duration(stack);
	}

	public static bool GetTransitionRunning(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_running(stack);
	}

	public static GtkStackTransitionType GetTransitionType(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_transition_type(stack);
	}

	public static bool GetVhomogeneous(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_vhomogeneous(stack);
	}

	public static GtkWidgetHandle GetVisibleChild(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_visible_child(stack);
	}

	public static string GetVisibleChildName(this GtkStackHandle stack)
	{
		return GtkStackExterns.gtk_stack_get_visible_child_name(stack);
	}

	public static T SetHhomogeneous<T>(this T stack, bool hhomogeneous) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_hhomogeneous(stack, hhomogeneous);
		return stack;
	}

	public static T SetHomogeneous<T>(this T stack, bool homogeneous) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_homogeneous(stack, homogeneous);
		return stack;
	}

	public static T SetInterpolateSize<T>(this T stack, bool interpolate_size) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_interpolate_size(stack, interpolate_size);
		return stack;
	}

	public static T SetTransitionDuration<T>(this T stack, uint duration) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_transition_duration(stack, duration);
		return stack;
	}

	public static T SetTransitionType<T>(this T stack, GtkStackTransitionType transition) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_transition_type(stack, transition);
		return stack;
	}

	public static T SetVhomogeneous<T>(this T stack, bool vhomogeneous) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_vhomogeneous(stack, vhomogeneous);
		return stack;
	}

	public static T SetVisibleChild<T>(this T stack, GtkWidgetHandle child) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_visible_child(stack, child);
		return stack;
	}

	public static T SetVisibleChildFull<T>(this T stack, string name, GtkStackTransitionType transition) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_visible_child_full(stack, name, transition);
		return stack;
	}

	public static T SetVisibleChildName<T>(this T stack, string name) where T : GtkStackHandle
	{
		GtkStackExterns.gtk_stack_set_visible_child_name(stack, name);
		return stack;
	}

}

internal class GtkStackExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStackHandle gtk_stack_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_add_named(GtkStackHandle stack, GtkWidgetHandle child, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_add_titled(GtkStackHandle stack, GtkWidgetHandle child, string name, string title);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_stack_get_child_by_name(GtkStackHandle stack, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_stack_get_hhomogeneous(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_stack_get_homogeneous(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_stack_get_interpolate_size(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_stack_get_transition_duration(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_stack_get_transition_running(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStackTransitionType gtk_stack_get_transition_type(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_stack_get_vhomogeneous(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_stack_get_visible_child(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_stack_get_visible_child_name(GtkStackHandle stack);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_hhomogeneous(GtkStackHandle stack, bool hhomogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_homogeneous(GtkStackHandle stack, bool homogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_interpolate_size(GtkStackHandle stack, bool interpolate_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_transition_duration(GtkStackHandle stack, uint duration);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_transition_type(GtkStackHandle stack, GtkStackTransitionType transition);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_vhomogeneous(GtkStackHandle stack, bool vhomogeneous);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_visible_child(GtkStackHandle stack, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_visible_child_full(GtkStackHandle stack, string name, GtkStackTransitionType transition);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_stack_set_visible_child_name(GtkStackHandle stack, string name);

}
