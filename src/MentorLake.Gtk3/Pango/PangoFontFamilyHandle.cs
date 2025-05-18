namespace MentorLake.Pango;

public class PangoFontFamilyHandle : GObjectHandle, GListModelHandle
{
}
public static class PangoFontFamilyHandleSignalExtensions
{

	public static IObservable<PangoFontFamilyHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this PangoFontFamilyHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<PangoFontFamilyHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			PangoFontFamilyHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GListModelHandle self,  uint position,  uint removed,  uint added,  IntPtr user_data) =>
			{
				

				var signalStruct = new PangoFontFamilyHandleSignalStructs.ItemsChangedSignal()
				{
					Self = self, Position = position, Removed = removed, Added = added, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "items-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class PangoFontFamilyHandleSignalStructs
{

public class ItemsChangedSignal
{
	public MentorLake.Gio.GListModelHandle Self;
	public uint Position;
	public uint Removed;
	public uint Added;
	public IntPtr UserData;
}
}

public static class PangoFontFamilyHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle self, uint position, uint removed, uint added, IntPtr user_data);

}


public static class PangoFontFamilyHandleExtensions
{
	public static MentorLake.Pango.PangoFontFaceHandle GetFace(this MentorLake.Pango.PangoFontFamilyHandle family, string name)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_get_face(family, name);
	}

	public static string GetName(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_get_name(family);
	}

	public static bool IsMonospace(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_is_monospace(family);
	}

	public static bool IsVariable(this MentorLake.Pango.PangoFontFamilyHandle family)
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		return PangoFontFamilyHandleExterns.pango_font_family_is_variable(family);
	}

	public static T ListFaces<T>(this T family, out MentorLake.Pango.PangoFontFaceHandle[] faces, out int n_faces) where T : PangoFontFamilyHandle
	{
		if (family.IsInvalid) throw new Exception("Invalid handle (PangoFontFamilyHandle)");
		PangoFontFamilyHandleExterns.pango_font_family_list_faces(family, out faces, out n_faces);
		return family;
	}

}

internal class PangoFontFamilyHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))]
	internal static extern MentorLake.Pango.PangoFontFaceHandle pango_font_family_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family, string name);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_family_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_family_is_monospace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_family_is_variable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_family_list_faces([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] MentorLake.Pango.PangoFontFamilyHandle family, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFaceHandle>))] out MentorLake.Pango.PangoFontFaceHandle[] faces, out int n_faces);

}
