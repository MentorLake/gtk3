using GCHandle = System.Runtime.InteropServices.GCHandle;

namespace MentorLake.GObject;

public partial class GObjectHandle
{
	private IntPtr _contextHandle = IntPtr.Zero;

	protected override void Dispose(bool disposing)
	{
		if (!IsInvalid && _contextHandle != IntPtr.Zero)
		{
			g_main_context_invoke_full(g_main_context_default(), 0, Unref, _contextHandle, null);
		}

		base.Dispose(disposing);
	}

	private static bool Unref(IntPtr data)
	{
		var gch = GCHandle.FromIntPtr(data);
		var context = (HandleContext) gch.Target;

		if (!context.IsInvalid)
		{
			g_object_weak_unref(context.Ptr, InvalidateHandle, data);
			g_object_unref(context.Ptr);
		}

		gch.Free();
		return false;
	}

	public void Init(bool addRef)
	{
		if (IsInvalid || IsClosed) return;

		if (this.IsFloating()) g_object_ref_sink(handle);
		else if (addRef) g_object_ref(handle);

		_contextHandle = GCHandle.ToIntPtr(GCHandle.Alloc(new HandleContext() { Ptr = handle }));
		g_object_weak_ref(handle, InvalidateHandle, _contextHandle);
	}

	private static void InvalidateHandle(IntPtr ptr, IntPtr _)
	{
		var gch = GCHandle.FromIntPtr(ptr);
		var handle = (HandleContext) gch.Target;
		handle.IsInvalid = true;
	}

	[DllImport(GObjectLibrary.Name)]
	private static extern IntPtr g_object_ref(IntPtr @object);

	[DllImport(GObjectLibrary.Name)]
	private static extern void g_object_unref(IntPtr @object);

	[DllImport(GObjectLibrary.Name)]
	private static extern IntPtr g_object_ref_sink(IntPtr @object);

	[DllImport(GLibLibrary.Name)]
	private static extern IntPtr g_main_context_default();

	[DllImport(GLibLibrary.Name)]
	private static extern void g_main_context_invoke_full(IntPtr context, int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GObjectLibrary.Name)]
	private static extern void g_object_weak_ref(nint @object, GWeakNotify notify, IntPtr data);

	[DllImport(GObjectLibrary.Name)]
	private static extern void g_object_weak_unref(nint @object, GWeakNotify notify, IntPtr data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void GWeakNotify(IntPtr data, IntPtr where_the_object_was);

	private class HandleContext
	{
		public nint Ptr { get; set; }
		public bool IsInvalid { get; set; }
	}
}
