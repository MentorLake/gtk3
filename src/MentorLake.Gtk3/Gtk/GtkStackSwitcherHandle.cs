namespace MentorLake.Gtk;

public class GtkStackSwitcherHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkStackSwitcherHandle New()
	{
		return GtkStackSwitcherHandleExterns.gtk_stack_switcher_new();
	}

}

public static class GtkStackSwitcherHandleExtensions
{
	public static MentorLake.Gtk.GtkStackHandle GetStack(this MentorLake.Gtk.GtkStackSwitcherHandle switcher)
	{
		return GtkStackSwitcherHandleExterns.gtk_stack_switcher_get_stack(switcher);
	}

	public static T SetStack<T>(this T switcher, MentorLake.Gtk.GtkStackHandle stack) where T : GtkStackSwitcherHandle
	{
		GtkStackSwitcherHandleExterns.gtk_stack_switcher_set_stack(switcher, stack);
		return switcher;
	}

}

internal class GtkStackSwitcherHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStackSwitcherHandle gtk_stack_switcher_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStackHandle gtk_stack_switcher_get_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSwitcherHandle>))] MentorLake.Gtk.GtkStackSwitcherHandle switcher);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_switcher_set_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSwitcherHandle>))] MentorLake.Gtk.GtkStackSwitcherHandle switcher, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

}
