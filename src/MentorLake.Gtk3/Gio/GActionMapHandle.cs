namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GActionMap` is an interface for action containers.
/// </para>
/// <para>
/// The `GActionMap` interface is implemented by [iface@Gio.ActionGroup]
/// implementations that operate by containing a number of named
/// [iface@Gio.Action] instances, such as [class@Gio.SimpleActionGroup].
/// </para>
/// <para>
/// One useful application of this interface is to map the
/// names of actions from various action groups to unique,
/// prefixed names (e.g. by prepending &quot;app.&quot; or &quot;win.&quot;).
/// This is the motivation for the ‘Map’ part of the interface
/// name.
/// </para>
/// </summary>

public interface GActionMapHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GActionMapHandleImpl : BaseSafeHandle, GActionMapHandle
{
}

public static class GActionMapHandleExtensions
{
/// <summary>
/// <para>
/// Adds an action to the @action_map.
/// </para>
/// <para>
/// If the action map already contains an action with the same name
/// as @action then the old action is dropped from the action map.
/// </para>
/// <para>
/// The action map takes its own reference on @action.
/// </para>
/// </summary>

/// <param name="action_map">
/// an action map
/// </param>
/// <param name="action">
/// a [iface@Gio.Action]
/// </param>

	public static T AddAction<T>(this T action_map, MentorLake.Gio.GActionHandle action) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_add_action(action_map, action);
		return action_map;
	}

/// <summary>
/// <para>
/// A convenience function for creating multiple [class@Gio.SimpleAction]
/// instances and adding them to a [iface@Gio.ActionMap].
/// </para>
/// <para>
/// Each action is constructed as per one [struct@Gio.ActionEntry].
/// </para>
/// <para>
/// ```c
/// static void
/// activate_quit (GSimpleAction *simple,
///                GVariant      *parameter,
///                gpointer       user_data)
/// {
///   exit (0);
/// }
/// </para>
/// <para>
/// static void
/// activate_print_string (GSimpleAction *simple,
///                        GVariant      *parameter,
///                        gpointer       user_data)
/// {
///   g_print (&quot;%s\n&quot;, g_variant_get_string (parameter, NULL));
/// }
/// </para>
/// <para>
/// static GActionGroup *
/// create_action_group (void)
/// {
///   const GActionEntry entries[] = {
///     { &quot;quit&quot;,         activate_quit              },
///     { &quot;print-string&quot;, activate_print_string, &quot;s&quot; }
///   };
///   GSimpleActionGroup *group;
/// </para>
/// <para>
///   group = g_simple_action_group_new ();
///   g_action_map_add_action_entries (G_ACTION_MAP (group), entries, G_N_ELEMENTS (entries), NULL);
/// </para>
/// <para>
///   return G_ACTION_GROUP (group);
/// }
/// ```
/// </para>
/// </summary>

/// <param name="action_map">
/// an action map
/// </param>
/// <param name="entries">
/// a pointer to
///   the first item in an array of [struct@Gio.ActionEntry] structs
/// </param>
/// <param name="n_entries">
/// the length of @entries, or -1 if @entries is `NULL`-terminated
/// </param>
/// <param name="user_data">
/// the user data for signal connections
/// </param>

	public static T AddActionEntries<T>(this T action_map, MentorLake.Gio.GActionEntryHandle[] entries, int n_entries, IntPtr user_data) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_add_action_entries(action_map, entries, n_entries, user_data);
		return action_map;
	}

/// <summary>
/// <para>
/// Looks up the action with the name @action_name in @action_map.
/// </para>
/// <para>
/// If no such action exists, returns `NULL`.
/// </para>
/// </summary>

/// <param name="action_map">
/// an action map
/// </param>
/// <param name="action_name">
/// the name of an action
/// </param>
/// <return>
/// a [iface@Gio.Action]
/// </return>

	public static MentorLake.Gio.GActionHandle LookupAction(this MentorLake.Gio.GActionMapHandle action_map, string action_name)
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		return GActionMapHandleExterns.g_action_map_lookup_action(action_map, action_name);
	}

/// <summary>
/// <para>
/// Removes the named action from the action map.
/// </para>
/// <para>
/// If no action of this name is in the map then nothing happens.
/// </para>
/// </summary>

/// <param name="action_map">
/// an action map
/// </param>
/// <param name="action_name">
/// the name of the action
/// </param>

	public static T RemoveAction<T>(this T action_map, string action_name) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_remove_action(action_map, action_name);
		return action_map;
	}

/// <summary>
/// <para>
/// Remove actions from a [iface@Gio.ActionMap]. This is meant as the reverse of
/// [method@Gio.ActionMap.add_action_entries].
/// </para>
/// 
/// <para>
/// ```c
/// static const GActionEntry entries[] = {
///     { &quot;quit&quot;,         activate_quit              },
///     { &quot;print-string&quot;, activate_print_string, &quot;s&quot; }
/// };
/// </para>
/// <para>
/// void
/// add_actions (GActionMap *map)
/// {
///   g_action_map_add_action_entries (map, entries, G_N_ELEMENTS (entries), NULL);
/// }
/// </para>
/// <para>
/// void
/// remove_actions (GActionMap *map)
/// {
///   g_action_map_remove_action_entries (map, entries, G_N_ELEMENTS (entries));
/// }
/// ```
/// </para>
/// </summary>

/// <param name="action_map">
/// The [iface@Gio.ActionMap]
/// </param>
/// <param name="entries">
/// a pointer to
///   the first item in an array of [struct@Gio.ActionEntry] structs
/// </param>
/// <param name="n_entries">
/// the length of @entries, or -1 if @entries is `NULL`-terminated
/// </param>

	public static T RemoveActionEntries<T>(this T action_map, MentorLake.Gio.GActionEntryHandle[] entries, int n_entries) where T : GActionMapHandle
	{
		if (action_map.IsInvalid) throw new Exception("Invalid handle (GActionMapHandle)");
		GActionMapHandleExterns.g_action_map_remove_action_entries(action_map, entries, n_entries);
		return action_map;
	}

}

internal class GActionMapHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_add_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))] MentorLake.Gio.GActionHandle action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_add_action_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionEntryHandle>))] MentorLake.Gio.GActionEntryHandle[] entries, int n_entries, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionHandleImpl>))]
	internal static extern MentorLake.Gio.GActionHandle g_action_map_lookup_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_remove_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, string action_name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_action_map_remove_action_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionMapHandleImpl>))] MentorLake.Gio.GActionMapHandle action_map, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionEntryHandle>))] MentorLake.Gio.GActionEntryHandle[] entries, int n_entries);

}
