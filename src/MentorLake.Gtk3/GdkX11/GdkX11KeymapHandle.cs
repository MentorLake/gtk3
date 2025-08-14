namespace MentorLake.GdkX11;


public class GdkX11KeymapHandle : GdkKeymapHandle
{
}

public static class GdkX11KeymapHandleExtensions
{
/// <summary>
/// <para>
/// Extracts the group from the state field sent in an X Key event.
/// This is only needed for code processing raw X events, since #GdkEventKey
/// directly includes an is_modifier field.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkX11Keymap
/// </param>
/// <param name="state">
/// raw state returned from X
/// </param>
/// <return>
/// the index of the active keyboard group for the event
/// </return>

	public static int GetGroupForState(this MentorLake.GdkX11.GdkX11KeymapHandle keymap, uint state)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkX11KeymapHandle)");
		return GdkX11KeymapHandleExterns.gdk_x11_keymap_get_group_for_state(keymap, state);
	}

/// <summary>
/// <para>
/// Determines whether a particular key code represents a key that
/// is a modifier. That is, it’s a key that normally just affects
/// the keyboard state and the behavior of other keys rather than
/// producing a direct effect itself. This is only needed for code
/// processing raw X events, since #GdkEventKey directly includes
/// an is_modifier field.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkX11Keymap
/// </param>
/// <param name="keycode">
/// the hardware keycode from a key event
/// </param>
/// <return>
/// %TRUE if the hardware keycode is a modifier key
/// </return>

	public static bool KeyIsModifier(this MentorLake.GdkX11.GdkX11KeymapHandle keymap, uint keycode)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkX11KeymapHandle)");
		return GdkX11KeymapHandleExterns.gdk_x11_keymap_key_is_modifier(keymap, keycode);
	}

}

internal class GdkX11KeymapHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern int gdk_x11_keymap_get_group_for_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11KeymapHandle>))] MentorLake.GdkX11.GdkX11KeymapHandle keymap, uint state);

	[DllImport(GdkX11Library.Name)]
	internal static extern bool gdk_x11_keymap_key_is_modifier([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11KeymapHandle>))] MentorLake.GdkX11.GdkX11KeymapHandle keymap, uint keycode);

}
