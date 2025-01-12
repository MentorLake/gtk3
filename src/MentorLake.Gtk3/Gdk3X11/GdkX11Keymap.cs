namespace MentorLake.Gtk3.Gdk3X11;

public class GdkX11KeymapHandle : GdkKeymapHandle
{
}

public static class GdkX11KeymapHandleExtensions
{
	public static int GetGroupForState(GdkKeymapHandle keymap, uint state)
	{
		return GdkX11KeymapExterns.gdk_x11_keymap_get_group_for_state(keymap, state);
	}

	public static bool KeyIsModifier(GdkKeymapHandle keymap, uint keycode)
	{
		return GdkX11KeymapExterns.gdk_x11_keymap_key_is_modifier(keymap, keycode);
	}

}

internal class GdkX11KeymapExterns
{
	[DllImport(Libraries.Gdk3X11)]
	internal static extern int gdk_x11_keymap_get_group_for_state(GdkKeymapHandle keymap, uint state);

	[DllImport(Libraries.Gdk3X11)]
	internal static extern bool gdk_x11_keymap_key_is_modifier(GdkKeymapHandle keymap, uint keycode);

}
