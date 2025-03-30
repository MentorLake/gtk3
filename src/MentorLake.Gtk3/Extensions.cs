using GCHandle = System.Runtime.InteropServices.GCHandle;

namespace MentorLake.Gtk3;

public static class Extensions
{
	public static T With<T>(this T o, Action<T> action)
	{
		action(o);
		return o;
	}

	public static int[] MarshalIntArray(this IntPtr source, int size)
	{
		var dest = new int[size];
		Marshal.Copy(source, dest, 0, size);
		return dest;
	}

	public static byte[] MarshalByteArray(this IntPtr source, int size)
	{
		var dest = new byte[size];
		Marshal.Copy(source, dest, 0, size);
		return dest;
	}

	public static string[] MarshalStringArray(this IntPtr source, int size)
	{
		var dest = new IntPtr[size];
		Marshal.Copy(source, dest, 0, size);
		var result = new string[size];

		for (int i = 0; i < size; i++)
		{
			result[i] = Marshal.PtrToStringBSTR(dest[i]);
		}

		return result;
	}

	public static List<string> GetSignals(this GObjectHandle o)
	{
		var typeName = GObjectGlobalFunctions.TypeNameFromInstance(o);
		var gtype = GObjectGlobalFunctions.TypeFromName(typeName);
		var ids = GObjectGlobalFunctions.SignalListIds(gtype, out _);
		//Marshal.FreeHGlobal(idArrayPointer);
		return ids.Select(id => GObjectGlobalFunctions.SignalName((uint)id)).ToList();
	}

	private static readonly Dictionary<IntPtr, object> s_managedData = new();

	public static T SetManagedData<T>(this T obj, object key, object val) where T : GObjectHandle
	{
		lock (s_managedData)
		{
			s_managedData[obj.DangerousGetHandle()] = val;
			GCHandle gcHandle = default;
			GWeakNotify handler = (_, _) =>
			{
				lock (s_managedData) s_managedData.Remove(obj.DangerousGetHandle());
				gcHandle.Free();
			};
			gcHandle = GCHandle.Alloc(handler);
			obj.WeakRef(handler, IntPtr.Zero);
		}

		return obj;
	}

	public static T GetManagedData<T>(this GObjectHandle obj, object key)
	{
		lock (s_managedData)
		{
			return (T) s_managedData[obj.DangerousGetHandle()];
		}
	}

	public static T ToHandle<T>(this BaseSafeHandle handle) where T : BaseSafeHandle, new()
	{
		var newHandle = new T();
		Marshal.InitHandle(newHandle, handle.DangerousGetHandle());
		return newHandle;
	}
}
