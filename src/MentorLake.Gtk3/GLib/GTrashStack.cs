namespace MentorLake.GLib;

public class GTrashStackHandle : BaseSafeHandle
{
}


public static class GTrashStackExtensions
{

	public static GTrashStack Dereference(this GTrashStackHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTrashStack>(x.DangerousGetHandle());
}
internal class GTrashStackExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_trash_stack_height(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_trash_stack_peek(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_trash_stack_pop(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_trash_stack_push(IntPtr stack_p, IntPtr data_p);

}

public struct GTrashStack
{
	public IntPtr next;
	public static uint Height(IntPtr stack_p)
	{
		return GTrashStackExterns.g_trash_stack_height(stack_p);
	}

	public static IntPtr Peek(IntPtr stack_p)
	{
		return GTrashStackExterns.g_trash_stack_peek(stack_p);
	}

	public static IntPtr Pop(IntPtr stack_p)
	{
		return GTrashStackExterns.g_trash_stack_pop(stack_p);
	}

	public static void Push(IntPtr stack_p, IntPtr data_p)
	{
		GTrashStackExterns.g_trash_stack_push(stack_p, data_p);
	}

}
