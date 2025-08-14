namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GTrashStack` is an efficient way to keep a stack of unused allocated
/// memory chunks. Each memory chunk is required to be large enough to hold
/// a `gpointer`. This allows the stack to be maintained without any space
/// overhead, since the stack pointers can be stored inside the memory chunks.
/// </para>
/// <para>
/// There is no function to create a `GTrashStack`. A `NULL` `GTrashStack*`
/// is a perfectly valid empty stack.
/// </para>
/// <para>
/// Each piece of memory that is pushed onto the stack is cast to a
/// `GTrashStack*`.
/// </para>
/// <para>
/// There is no longer any good reason to use `GTrashStack`.  If you have
/// extra pieces of memory, `free()` them and allocate them again later.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// A `GTrashStack` is an efficient way to keep a stack of unused allocated
/// memory chunks. Each memory chunk is required to be large enough to hold
/// a `gpointer`. This allows the stack to be maintained without any space
/// overhead, since the stack pointers can be stored inside the memory chunks.
/// </para>
/// <para>
/// There is no function to create a `GTrashStack`. A `NULL` `GTrashStack*`
/// is a perfectly valid empty stack.
/// </para>
/// <para>
/// Each piece of memory that is pushed onto the stack is cast to a
/// `GTrashStack*`.
/// </para>
/// <para>
/// There is no longer any good reason to use `GTrashStack`.  If you have
/// extra pieces of memory, `free()` them and allocate them again later.
/// </para>
/// </summary>

public struct GTrashStack
{
	/// <summary>
/// <para>
/// pointer to the previous element of the stack,
///     gets stored in the first `sizeof (gpointer)`
///     bytes of the element
/// </para>
/// </summary>

public IntPtr next;
/// <summary>
/// <para>
/// Returns the height of a #GTrashStack.
/// </para>
/// <para>
/// Note that execution of this function is of O(N) complexity
/// where N denotes the number of items on the stack.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <return>
/// the height of the stack
/// </return>

	public static uint Height(IntPtr stack_p)
	{
		return GTrashStackExterns.g_trash_stack_height(stack_p);
	}

/// <summary>
/// <para>
/// Returns the element at the top of a #GTrashStack
/// which may be %NULL.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <return>
/// the element at the top of the stack
/// </return>

	public static IntPtr Peek(IntPtr stack_p)
	{
		return GTrashStackExterns.g_trash_stack_peek(stack_p);
	}

/// <summary>
/// <para>
/// Pops a piece of memory off a #GTrashStack.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <return>
/// the element at the top of the stack
/// </return>

	public static IntPtr Pop(IntPtr stack_p)
	{
		return GTrashStackExterns.g_trash_stack_pop(stack_p);
	}

/// <summary>
/// <para>
/// Pushes a piece of memory onto a #GTrashStack.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <param name="data_p">
/// the piece of memory to push on the stack
/// </param>

	public static void Push(IntPtr stack_p, IntPtr data_p)
	{
		GTrashStackExterns.g_trash_stack_push(stack_p, data_p);
	}

}
