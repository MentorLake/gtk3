namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The GtkStack widget is a container which only shows
/// one of its children at a time. In contrast to GtkNotebook,
/// GtkStack does not provide a means for users to change the
/// visible child. Instead, the #GtkStackSwitcher widget can be
/// used with GtkStack to provide this functionality.
/// </para>
/// <para>
/// Transitions between pages can be animated as slides or
/// fades. This can be controlled with gtk_stack_set_transition_type().
/// These animations respect the #GtkSettings:gtk-enable-animations
/// setting.
/// </para>
/// <para>
/// The GtkStack widget was added in GTK+ 3.10.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkStack has a single CSS node named stack.
/// </para>
/// </summary>

public class GtkStackHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkStack container.
/// </para>
/// </summary>

/// <return>
/// a new #GtkStack
/// </return>

	public static MentorLake.Gtk.GtkStackHandle New()
	{
		return GtkStackHandleExterns.gtk_stack_new();
	}

}

public static class GtkStackHandleExtensions
{
/// <summary>
/// <para>
/// Adds a child to @stack.
/// The child is identified by the @name.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="child">
/// the widget to add
/// </param>
/// <param name="name">
/// the name for @child
/// </param>

	public static T AddNamed<T>(this T stack, MentorLake.Gtk.GtkWidgetHandle child, string name) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_add_named(stack, child, name);
		return stack;
	}

/// <summary>
/// <para>
/// Adds a child to @stack.
/// The child is identified by the @name. The @title
/// will be used by #GtkStackSwitcher to represent
/// @child in a tab bar, so it should be short.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="child">
/// the widget to add
/// </param>
/// <param name="name">
/// the name for @child
/// </param>
/// <param name="title">
/// a human-readable title for @child
/// </param>

	public static T AddTitled<T>(this T stack, MentorLake.Gtk.GtkWidgetHandle child, string name, string title) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_add_titled(stack, child, name, title);
		return stack;
	}

/// <summary>
/// <para>
/// Finds the child of the #GtkStack with the name given as
/// the argument. Returns %NULL if there is no child with this
/// name.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="name">
/// the name of the child to find
/// </param>
/// <return>
/// the requested child of the #GtkStack
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetChildByName(this MentorLake.Gtk.GtkStackHandle stack, string name)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_child_by_name(stack, name);
	}

/// <summary>
/// <para>
/// Gets whether @stack is horizontally homogeneous.
/// See gtk_stack_set_hhomogeneous().
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// whether @stack is horizontally homogeneous.
/// </return>

	public static bool GetHhomogeneous(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_hhomogeneous(stack);
	}

/// <summary>
/// <para>
/// Gets whether @stack is homogeneous.
/// See gtk_stack_set_homogeneous().
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// whether @stack is homogeneous.
/// </return>

	public static bool GetHomogeneous(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_homogeneous(stack);
	}

/// <summary>
/// <para>
/// Returns wether the #GtkStack is set up to interpolate between
/// the sizes of children on page switch.
/// </para>
/// </summary>

/// <param name="stack">
/// A #GtkStack
/// </param>
/// <return>
/// %TRUE if child sizes are interpolated
/// </return>

	public static bool GetInterpolateSize(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_interpolate_size(stack);
	}

/// <summary>
/// <para>
/// Returns the amount of time (in milliseconds) that
/// transitions between pages in @stack will take.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// the transition duration
/// </return>

	public static uint GetTransitionDuration(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_transition_duration(stack);
	}

/// <summary>
/// <para>
/// Returns whether the @stack is currently in a transition from one page to
/// another.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// %TRUE if the transition is currently running, %FALSE otherwise.
/// </return>

	public static bool GetTransitionRunning(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_transition_running(stack);
	}

/// <summary>
/// <para>
/// Gets the type of animation that will be used
/// for transitions between pages in @stack.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// the current transition type of @stack
/// </return>

	public static MentorLake.Gtk.GtkStackTransitionType GetTransitionType(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_transition_type(stack);
	}

/// <summary>
/// <para>
/// Gets whether @stack is vertically homogeneous.
/// See gtk_stack_set_vhomogeneous().
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// whether @stack is vertically homogeneous.
/// </return>

	public static bool GetVhomogeneous(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_vhomogeneous(stack);
	}

/// <summary>
/// <para>
/// Gets the currently visible child of @stack, or %NULL if
/// there are no visible children.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// the visible child of the #GtkStack
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetVisibleChild(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_visible_child(stack);
	}

/// <summary>
/// <para>
/// Returns the name of the currently visible child of @stack, or
/// %NULL if there is no visible child.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <return>
/// the name of the visible child of the #GtkStack
/// </return>

	public static string GetVisibleChildName(this MentorLake.Gtk.GtkStackHandle stack)
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		return GtkStackHandleExterns.gtk_stack_get_visible_child_name(stack);
	}

/// <summary>
/// <para>
/// Sets the #GtkStack to be horizontally homogeneous or not.
/// If it is homogeneous, the #GtkStack will request the same
/// width for all its children. If it isn&apos;t, the stack
/// may change width when a different child becomes visible.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="hhomogeneous">
/// %TRUE to make @stack horizontally homogeneous
/// </param>

	public static T SetHhomogeneous<T>(this T stack, bool hhomogeneous) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_hhomogeneous(stack, hhomogeneous);
		return stack;
	}

/// <summary>
/// <para>
/// Sets the #GtkStack to be homogeneous or not. If it
/// is homogeneous, the #GtkStack will request the same
/// size for all its children. If it isn&apos;t, the stack
/// may change size when a different child becomes visible.
/// </para>
/// <para>
/// Since 3.16, homogeneity can be controlled separately
/// for horizontal and vertical size, with the
/// #GtkStack:hhomogeneous and #GtkStack:vhomogeneous.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="homogeneous">
/// %TRUE to make @stack homogeneous
/// </param>

	public static T SetHomogeneous<T>(this T stack, bool homogeneous) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_homogeneous(stack, homogeneous);
		return stack;
	}

/// <summary>
/// <para>
/// Sets whether or not @stack will interpolate its size when
/// changing the visible child. If the #GtkStack:interpolate-size
/// property is set to %TRUE, @stack will interpolate its size between
/// the current one and the one it&apos;ll take after changing the
/// visible child, according to the set transition duration.
/// </para>
/// </summary>

/// <param name="stack">
/// A #GtkStack
/// </param>
/// <param name="interpolate_size">
/// the new value
/// </param>

	public static T SetInterpolateSize<T>(this T stack, bool interpolate_size) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_interpolate_size(stack, interpolate_size);
		return stack;
	}

/// <summary>
/// <para>
/// Sets the duration that transitions between pages in @stack
/// will take.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="duration">
/// the new duration, in milliseconds
/// </param>

	public static T SetTransitionDuration<T>(this T stack, uint duration) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_transition_duration(stack, duration);
		return stack;
	}

/// <summary>
/// <para>
/// Sets the type of animation that will be used for
/// transitions between pages in @stack. Available
/// types include various kinds of fades and slides.
/// </para>
/// <para>
/// The transition type can be changed without problems
/// at runtime, so it is possible to change the animation
/// based on the page that is about to become current.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="transition">
/// the new transition type
/// </param>

	public static T SetTransitionType<T>(this T stack, MentorLake.Gtk.GtkStackTransitionType transition) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_transition_type(stack, transition);
		return stack;
	}

/// <summary>
/// <para>
/// Sets the #GtkStack to be vertically homogeneous or not.
/// If it is homogeneous, the #GtkStack will request the same
/// height for all its children. If it isn&apos;t, the stack
/// may change height when a different child becomes visible.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="vhomogeneous">
/// %TRUE to make @stack vertically homogeneous
/// </param>

	public static T SetVhomogeneous<T>(this T stack, bool vhomogeneous) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_vhomogeneous(stack, vhomogeneous);
		return stack;
	}

/// <summary>
/// <para>
/// Makes @child the visible child of @stack.
/// </para>
/// <para>
/// If @child is different from the currently
/// visible child, the transition between the
/// two will be animated with the current
/// transition type of @stack.
/// </para>
/// <para>
/// Note that the @child widget has to be visible itself
/// (see gtk_widget_show()) in order to become the visible
/// child of @stack.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="child">
/// a child of @stack
/// </param>

	public static T SetVisibleChild<T>(this T stack, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_visible_child(stack, child);
		return stack;
	}

/// <summary>
/// <para>
/// Makes the child with the given name visible.
/// </para>
/// <para>
/// Note that the child widget has to be visible itself
/// (see gtk_widget_show()) in order to become the visible
/// child of @stack.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="name">
/// the name of the child to make visible
/// </param>
/// <param name="transition">
/// the transition type to use
/// </param>

	public static T SetVisibleChildFull<T>(this T stack, string name, MentorLake.Gtk.GtkStackTransitionType transition) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_visible_child_full(stack, name, transition);
		return stack;
	}

/// <summary>
/// <para>
/// Makes the child with the given name visible.
/// </para>
/// <para>
/// If @child is different from the currently
/// visible child, the transition between the
/// two will be animated with the current
/// transition type of @stack.
/// </para>
/// <para>
/// Note that the child widget has to be visible itself
/// (see gtk_widget_show()) in order to become the visible
/// child of @stack.
/// </para>
/// </summary>

/// <param name="stack">
/// a #GtkStack
/// </param>
/// <param name="name">
/// the name of the child to make visible
/// </param>

	public static T SetVisibleChildName<T>(this T stack, string name) where T : GtkStackHandle
	{
		if (stack.IsInvalid) throw new Exception("Invalid handle (GtkStackHandle)");
		GtkStackHandleExterns.gtk_stack_set_visible_child_name(stack, name);
		return stack;
	}

}

internal class GtkStackHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))]
	internal static extern MentorLake.Gtk.GtkStackHandle gtk_stack_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_add_named([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_stack_add_titled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStackHandle>))] MentorLake.Gtk.GtkStackHandle stack, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string name, string title);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
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
