using GCHandle = System.Runtime.InteropServices.GCHandle;

namespace MentorLake.Gtk3;

public class GObjectMarshallingHelper
{
	[DllImport(GObjectLibrary.Name)]
	private static extern IntPtr g_object_ref(IntPtr @object);

	[DllImport(GObjectLibrary.Name)]
	private static extern void g_object_unref(IntPtr @object);

	public static bool EnableLogging { get; set; } = false;

	private class GObjectState
	{
		public GObjectHandle Handle { get; set; }
		public IntPtr WeakPointer = 3;
		public bool WasFloating { get; set; }
		public string Name { get; set; }
	}

	public static void HandleGObjectHandle(GObjectHandle gObjectHandle, bool refObject)
	{
		var state = new GObjectState()
		{
			Handle = gObjectHandle,
			WasFloating = gObjectHandle.IsFloating(),
			Name = EnableLogging ? GObjectGlobalFunctions.TypeNameFromInstance(gObjectHandle) : null,
		};

		if (refObject) g_object_ref(gObjectHandle.DangerousGetHandle());

		if (EnableLogging)
		{
			gObjectHandle.WeakRef(static (data, _) =>
			{
				var gcHandleInner = GCHandle.FromIntPtr(data);
				Console.WriteLine("Finalize: " + ((string) gcHandleInner.Target));
				gcHandleInner.Free();
			}, GCHandle.ToIntPtr(GCHandle.Alloc(state.Name)));
		}

		gObjectHandle.AddWeakPointer(ref state.WeakPointer);

		gObjectHandle.AddReleaseAction(static data =>
		{
			var s = (GObjectState) data;

			if (!s.Handle.IsInvalid && s.WeakPointer != IntPtr.Zero && (!s.WasFloating || s.Handle.IsFloating()))
			{
				if (EnableLogging) Console.WriteLine("Unref: " + s.Name);
				g_object_unref(s.Handle.DangerousGetHandle());
			}
		}, state);
	}
}
