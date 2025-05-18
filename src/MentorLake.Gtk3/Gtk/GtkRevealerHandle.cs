namespace MentorLake.Gtk;

public class GtkRevealerHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkRevealerHandle New()
	{
		return GtkRevealerHandleExterns.gtk_revealer_new();
	}

}

public static class GtkRevealerHandleExtensions
{
	public static bool GetChildRevealed(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_child_revealed(revealer);
	}

	public static bool GetRevealChild(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_reveal_child(revealer);
	}

	public static uint GetTransitionDuration(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_transition_duration(revealer);
	}

	public static MentorLake.Gtk.GtkRevealerTransitionType GetTransitionType(this MentorLake.Gtk.GtkRevealerHandle revealer)
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		return GtkRevealerHandleExterns.gtk_revealer_get_transition_type(revealer);
	}

	public static T SetRevealChild<T>(this T revealer, bool reveal_child) where T : GtkRevealerHandle
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		GtkRevealerHandleExterns.gtk_revealer_set_reveal_child(revealer, reveal_child);
		return revealer;
	}

	public static T SetTransitionDuration<T>(this T revealer, uint duration) where T : GtkRevealerHandle
	{
		if (revealer.IsInvalid) throw new Exception("Invalid handle (GtkRevealerHandle)");
		GtkRevealerHandleExterns.gtk_revealer_set_transition_duration(revealer, duration);
		return revealer;
	}

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
