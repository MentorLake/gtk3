namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The GtkRevealer widget is a container which animates
/// the transition of its child from invisible to visible.
/// </para>
/// <para>
/// The style of transition can be controlled with
/// gtk_revealer_set_transition_type().
/// </para>
/// <para>
/// These animations respect the #GtkSettings:gtk-enable-animations
/// setting.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkRevealer has a single CSS node with name revealer.
/// </para>
/// <para>
/// The GtkRevealer widget was added in GTK+ 3.10.
/// </para>
/// </summary>

public class GtkRevealerHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRevealer.
/// </para>
/// </summary>

/// <return>
/// a newly created #GtkRevealer
/// </return>

	public static MentorLake.Gtk.GtkRevealerHandle New()
	{
		return GtkRevealerHandleExterns.gtk_revealer_new();
	}

}

public static class GtkRevealerHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether the child is fully revealed, in other words whether
/// the transition to the revealed state is completed.
/// </para>
/// </summary>

/// <param name="revealer">
/// a #GtkRevealer
/// </param>
/// <return>
/// %TRUE if the child is fully revealed
/// </return>

	public static bool GetChildRevealed(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_child_revealed(revealer);
	}

/// <summary>
/// <para>
/// Returns whether the child is currently
/// revealed. See gtk_revealer_set_reveal_child().
/// </para>
/// <para>
/// This function returns %TRUE as soon as the transition
/// is to the revealed state is started. To learn whether
/// the child is fully revealed (ie the transition is completed),
/// use gtk_revealer_get_child_revealed().
/// </para>
/// </summary>

/// <param name="revealer">
/// a #GtkRevealer
/// </param>
/// <return>
/// %TRUE if the child is revealed.
/// </return>

	public static bool GetRevealChild(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_reveal_child(revealer);
	}

/// <summary>
/// <para>
/// Returns the amount of time (in milliseconds) that
/// transitions will take.
/// </para>
/// </summary>

/// <param name="revealer">
/// a #GtkRevealer
/// </param>
/// <return>
/// the transition duration
/// </return>

	public static uint GetTransitionDuration(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_transition_duration(revealer);
	}

/// <summary>
/// <para>
/// Gets the type of animation that will be used
/// for transitions in @revealer.
/// </para>
/// </summary>

/// <param name="revealer">
/// a #GtkRevealer
/// </param>
/// <return>
/// the current transition type of @revealer
/// </return>

	public static MentorLake.Gtk.GtkRevealerTransitionType GetTransitionType(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_transition_type(revealer);
	}

/// <summary>
/// <para>
/// Tells the #GtkRevealer to reveal or conceal its child.
/// </para>
/// <para>
/// The transition will be animated with the current
/// transition type of @revealer.
/// </para>
/// </summary>

/// <param name="revealer">
/// a #GtkRevealer
/// </param>
/// <param name="reveal_child">
/// %TRUE to reveal the child
/// </param>

	public static T SetRevealChild<T>(this T revealer, bool reveal_child) where T : GtkRevealerHandle
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		GtkRevealerHandleExterns.gtk_revealer_set_reveal_child(revealer, reveal_child);
		return revealer;
	}

/// <summary>
/// <para>
/// Sets the duration that transitions will take.
/// </para>
/// </summary>

/// <param name="revealer">
/// a #GtkRevealer
/// </param>
/// <param name="duration">
/// the new duration, in milliseconds
/// </param>

	public static T SetTransitionDuration<T>(this T revealer, uint duration) where T : GtkRevealerHandle
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		GtkRevealerHandleExterns.gtk_revealer_set_transition_duration(revealer, duration);
		return revealer;
	}

/// <summary>
/// <para>
/// Sets the type of animation that will be used for
/// transitions in @revealer. Available types include
/// various kinds of fades and slides.
/// </para>
/// </summary>

/// <param name="revealer">
/// a #GtkRevealer
/// </param>
/// <param name="transition">
/// the new transition type
/// </param>

	public static T SetTransitionType<T>(this T revealer, MentorLake.Gtk.GtkRevealerTransitionType transition) where T : GtkRevealerHandle
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		GtkRevealerHandleExterns.gtk_revealer_set_transition_type(revealer, transition);
		return revealer;
	}

}

internal class GtkRevealerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))]
	internal static extern MentorLake.Gtk.GtkRevealerHandle gtk_revealer_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_revealer_get_child_revealed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))] MentorLake.Gtk.GtkRevealerHandle revealer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_revealer_get_reveal_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))] MentorLake.Gtk.GtkRevealerHandle revealer);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_revealer_get_transition_duration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))] MentorLake.Gtk.GtkRevealerHandle revealer);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRevealerTransitionType gtk_revealer_get_transition_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))] MentorLake.Gtk.GtkRevealerHandle revealer);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_revealer_set_reveal_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))] MentorLake.Gtk.GtkRevealerHandle revealer, bool reveal_child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_revealer_set_transition_duration([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))] MentorLake.Gtk.GtkRevealerHandle revealer, uint duration);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_revealer_set_transition_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRevealerHandle>))] MentorLake.Gtk.GtkRevealerHandle revealer, MentorLake.Gtk.GtkRevealerTransitionType transition);

}
