namespace MentorLake.Pango;

public class PangoFontMapHandle : GObjectHandle, GListModelHandle
{
}
public static class PangoFontMapHandleSignalExtensions
{

	public static IObservable<PangoFontMapHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this PangoFontMapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<PangoFontMapHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			PangoFontMapHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GListModelHandle self,  uint position,  uint removed,  uint added,  IntPtr user_data) =>
			{
				

				var signalStruct = new PangoFontMapHandleSignalStructs.ItemsChangedSignal()
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

public static class PangoFontMapHandleSignalStructs
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

public static class PangoFontMapHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle self, uint position, uint removed, uint added, IntPtr user_data);

}


public static class PangoFontMapHandleExtensions
{
	public static bool AddFontFile(this MentorLake.Pango.PangoFontMapHandle fontmap, string filename)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		var externCallResult = PangoFontMapHandleExterns.pango_font_map_add_font_file(fontmap, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T Changed<T>(this T fontmap) where T : PangoFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		PangoFontMapHandleExterns.pango_font_map_changed(fontmap);
		return fontmap;
	}

	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.Pango.PangoFontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_create_context(fontmap);
	}

	public static MentorLake.Pango.PangoFontFamilyHandle GetFamily(this MentorLake.Pango.PangoFontMapHandle fontmap, string name)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_get_family(fontmap, name);
	}

	public static uint GetSerial(this MentorLake.Pango.PangoFontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_get_serial(fontmap);
	}

	public static T ListFamilies<T>(this T fontmap, out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families) where T : PangoFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		PangoFontMapHandleExterns.pango_font_map_list_families(fontmap, out families, out n_families);
		return fontmap;
	}

	public static MentorLake.Pango.PangoFontHandle LoadFont(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_load_font(fontmap, context, desc);
	}

	public static MentorLake.Pango.PangoFontsetHandle LoadFontset(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoContextHandle context, MentorLake.Pango.PangoFontDescriptionHandle desc, MentorLake.Pango.PangoLanguageHandle language)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_load_fontset(fontmap, context, desc, language);
	}

	public static MentorLake.Pango.PangoFontHandle ReloadFont(this MentorLake.Pango.PangoFontMapHandle fontmap, MentorLake.Pango.PangoFontHandle font, double scale, MentorLake.Pango.PangoContextHandle context, string variations)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFontMapHandle)");
		return PangoFontMapHandleExterns.pango_font_map_reload_font(fontmap, font, scale, context, variations);
	}

}

internal class PangoFontMapHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_font_map_add_font_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_map_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle pango_font_map_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, string name);

	[DllImport(PangoLibrary.Name)]
	internal static extern uint pango_font_map_get_serial([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_font_map_list_families([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontFamilyHandle>))] out MentorLake.Pango.PangoFontFamilyHandle[] families, out int n_families);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_map_load_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontsetHandle>))]
	internal static extern MentorLake.Pango.PangoFontsetHandle pango_font_map_load_fontset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] MentorLake.Pango.PangoLanguageHandle language);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))]
	internal static extern MentorLake.Pango.PangoFontHandle pango_font_map_reload_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle fontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, double scale, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, string variations);

}
