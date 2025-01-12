namespace MentorLake.Gtk3.GLib;

public class GTrashStackHandle : BaseSafeHandle
{
}


public static class GTrashStackHandleExtensions
{
	public static uint Height(this GTrashStackHandle stack_p)
	{
		return GTrashStackExterns.g_trash_stack_height(ref stack_p);
	}

	public static IntPtr Peek(this GTrashStackHandle stack_p)
	{
		return GTrashStackExterns.g_trash_stack_peek(ref stack_p);
	}

	public static IntPtr Pop(this GTrashStackHandle stack_p)
	{
		return GTrashStackExterns.g_trash_stack_pop(ref stack_p);
	}

	public static GTrashStackHandle Push(this GTrashStackHandle stack_p, IntPtr data_p)
	{
		GTrashStackExterns.g_trash_stack_push(ref stack_p, data_p);
		return stack_p;
	}

}
internal class GTrashStackExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern uint g_trash_stack_height(ref GTrashStackHandle stack_p);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_trash_stack_peek(ref GTrashStackHandle stack_p);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_trash_stack_pop(ref GTrashStackHandle stack_p);

	[DllImport(Libraries.GLib)]
	internal static extern void g_trash_stack_push(ref GTrashStackHandle stack_p, IntPtr data_p);

}

public struct GTrashStack
{
	public GTrashStackHandle next;
}
