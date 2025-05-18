namespace MentorLake.PangoFc;

public class PangoFcFontMapHandle : PangoFontMapHandle, GListModelHandle
{
}
public static class PangoFcFontMapHandleSignalExtensions
{

	public static IObservable<PangoFcFontMapHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this PangoFcFontMapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<PangoFcFontMapHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			PangoFcFontMapHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GListModelHandle self,  uint position,  uint removed,  uint added,  IntPtr user_data) =>
			{
				

				var signalStruct = new PangoFcFontMapHandleSignalStructs.ItemsChangedSignal()
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

public static class PangoFcFontMapHandleSignalStructs
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

public static class PangoFcFontMapHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle self, uint position, uint removed, uint added, IntPtr user_data);

}


public static class PangoFcFontMapHandleExtensions
{
	public static T AddDecoderFindFunc<T>(this T fcfontmap, MentorLake.PangoFc.PangoFcDecoderFindFunc findfunc, IntPtr user_data, MentorLake.GLib.GDestroyNotify dnotify) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_add_decoder_find_func(fcfontmap, findfunc, user_data, dnotify);
		return fcfontmap;
	}

	public static T CacheClear<T>(this T fcfontmap) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_cache_clear(fcfontmap);
		return fcfontmap;
	}

	public static T ConfigChanged<T>(this T fcfontmap) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_config_changed(fcfontmap);
		return fcfontmap;
	}

	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_create_context(fcfontmap);
	}

	public static MentorLake.PangoFc.PangoFcDecoderHandle FindDecoder(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, MentorLake.fontconfig.FcPatternHandle pattern)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_find_decoder(fcfontmap, pattern);
	}

	public static MentorLake.fontconfig.FcConfigHandle GetConfig(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_get_config(fcfontmap);
	}

	public static MentorLake.HarfBuzz.hb_face_tHandle GetHbFace(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, MentorLake.PangoFc.PangoFcFontHandle fcfont)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_get_hb_face(fcfontmap, fcfont);
	}

	public static T SetConfig<T>(this T fcfontmap, MentorLake.fontconfig.FcConfigHandle fcconfig) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_set_config(fcfontmap, fcconfig);
		return fcfontmap;
	}

	public static T SetDefaultSubstitute<T>(this T fontmap, MentorLake.PangoFc.PangoFcSubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : PangoFcFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_set_default_substitute(fontmap, func, data, notify);
		return fontmap;
	}

	public static T Shutdown<T>(this T fcfontmap) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_shutdown(fcfontmap);
		return fcfontmap;
	}

	public static T SubstituteChanged<T>(this T fontmap) where T : PangoFcFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_substitute_changed(fontmap);
		return fontmap;
	}

}

internal class PangoFcFontMapHandleExterns
{
	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_map_add_decoder_find_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, MentorLake.PangoFc.PangoFcDecoderFindFunc findfunc, IntPtr user_data, MentorLake.GLib.GDestroyNotify dnotify);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_map_cache_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_map_config_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap);

	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_fc_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap);

	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcDecoderHandle>))]
	internal static extern MentorLake.PangoFc.PangoFcDecoderHandle pango_fc_font_map_find_decoder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcPatternHandle>))] MentorLake.fontconfig.FcPatternHandle pattern);

	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcConfigHandle>))]
	internal static extern MentorLake.fontconfig.FcConfigHandle pango_fc_font_map_get_config([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap);

	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.HarfBuzz.hb_face_tHandle>))]
	internal static extern MentorLake.HarfBuzz.hb_face_tHandle pango_fc_font_map_get_hb_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontHandle>))] MentorLake.PangoFc.PangoFcFontHandle fcfont);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_map_set_config([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.fontconfig.FcConfigHandle>))] MentorLake.fontconfig.FcConfigHandle fcconfig);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_map_set_default_substitute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fontmap, MentorLake.PangoFc.PangoFcSubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_map_shutdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap);

	[DllImport(PangoFcLibrary.Name)]
	internal static extern void pango_fc_font_map_substitute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fontmap);

}
