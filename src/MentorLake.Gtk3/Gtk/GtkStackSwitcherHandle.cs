namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The GtkStackSwitcher widget acts as a controller for a
/// #GtkStack; it shows a row of buttons to switch between
/// the various pages of the associated stack widget.
/// </para>
/// <para>
/// All the content for the buttons comes from the child properties
/// of the #GtkStack; the button visibility in a #GtkStackSwitcher
/// widget is controlled by the visibility of the child in the
/// #GtkStack.
/// </para>
/// <para>
/// It is possible to associate multiple #GtkStackSwitcher widgets
/// with the same #GtkStack widget.
/// </para>
/// <para>
/// The GtkStackSwitcher widget was added in 3.10.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkStackSwitcher has a single CSS node named stackswitcher and
/// style class .stack-switcher.
/// </para>
/// <para>
/// When circumstances require it, GtkStackSwitcher adds the
/// .needs-attention style class to the widgets representing the
/// stack pages.
/// </para>
/// </summary>

public class GtkStackSwitcherHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Create a new #GtkStackSwitcher.
/// </para>
/// </summary>

/// <return>
/// a new #GtkStackSwitcher.
/// </return>

	public static MentorLake.Gtk.GtkStackSwitcherHandle New()
	{
		return GtkStackSwitcherHandleExterns.gtk_stack_switcher_new();
	}

}

public static class GtkStackSwitcherHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the stack.
/// See gtk_stack_switcher_set_stack().
/// </para>
/// </summary>

/// <param name="switcher">
/// a #GtkStackSwitcher
/// </param>
/// <return>
/// the stack, or %NULL if
///    none has been set explicitly.
/// </return>

	public static MentorLake.Gtk.GtkStackHandle GetStack(this MentorLake.Gtk.GtkStackSwitcherHandle switcher)
	{
		if (switcher.IsInvalid) throw new Exception("Invalid handle (GtkStackSwitcherHandle)");
		return GtkStackSwitcherHandleExterns.gtk_stack_switcher_get_stack(switcher);
	}

/// <summary>
/// <para>
/// Sets the stack to control.
/// </para>
/// </summary>

/// <param name="switcher">
/// a #GtkStackSwitcher
/// </param>
/// <param name="stack">
/// a #GtkStack
/// </param>

	public static T SetStack<T>(this T switcher, MentorLake.Gtk.GtkStackHandle stack) where T : GtkStackSwitcherHandle
	{
		if (switcher.IsInvalid) throw new Exception("Invalid handle (GtkStackSwitcherHandle)");
		GtkStackSwitcherHandleExterns.gtk_stack_switcher_set_stack(switcher, stack);
		return switcher;
	}

}

internal class GtkStackSwitcherHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStackSwitcherHandle>))]
	internal static extern MentorLake.Gtk.GtkStackSwitcherHandle gtk_stack_switcher_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))]
	internal static extern MentorLake.Gtk.GtkStackHandle gtk_stack_switcher_get_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSwitcherHandle>))] MentorLake.Gtk.GtkStackSwitcherHandle switcher);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_switcher_set_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackSwitcherHandle>))] MentorLake.Gtk.GtkStackSwitcherHandle switcher, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack);

}
