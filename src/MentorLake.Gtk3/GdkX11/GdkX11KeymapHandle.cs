namespace MentorLake.GdkX11;

public class GdkX11KeymapHandle : GdkKeymapHandle
{
}

public static class GdkX11KeymapHandleExtensions
{
	public static int GetGroupForState(this MentorLake.GdkX11.GdkX11KeymapHandle keymap, uint state)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkX11KeymapHandle)");
		return GdkX11KeymapHandleExterns.gdk_x11_keymap_get_group_for_state(keymap, state);
	}

	public static bool KeyIsModifier(this MentorLake.GdkX11.GdkX11KeymapHandle keymap, uint keycode)
	{
		if (keymap.IsInvalid || keymap.IsClosed) throw new Exception("Invalid or closed handle (GdkX11KeymapHandle)");
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
