namespace MentorLake.PangoFc;

/// <summary>
/// <para>
/// `PangoFcFontMap` is a base class for font map implementations using the
/// Fontconfig and FreeType libraries.
/// </para>
/// <para>
/// It is used in the Xft and FreeType backends shipped with Pango,
/// but can also be used when creating new backends. Any backend
/// deriving from this base class will take advantage of the wide
/// range of shapers implemented using FreeType that come with Pango.
/// </para>
/// </summary>

public class PangoFcFontMapHandle : PangoFontMapHandle, GListModelHandle
{
}
public static class PangoFcFontMapHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted whenever items were added to or removed
/// from @list. At @position, @removed items were removed and @added
/// items were added in their place.
/// </para>
/// <para>
/// Note: If `removed != added`, the positions of all later items
/// in the model change.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the position at which @list changed
/// </para>
/// </summary>

	public uint Position;
/// <summary>
/// <para>
/// the number of items removed
/// </para>
/// </summary>

	public uint Removed;
/// <summary>
/// <para>
/// the number of items added
/// </para>
/// </summary>

	public uint Added;

	public IntPtr UserData;
}
}

public static class PangoFcFontMapHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted whenever items were added to or removed
/// from @list. At @position, @removed items were removed and @added
/// items were added in their place.
/// </para>
/// <para>
/// Note: If `removed != added`, the positions of all later items
/// in the model change.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="position">
/// the position at which @list changed
/// </param>
/// <param name="removed">
/// the number of items removed
/// </param>
/// <param name="added">
/// the number of items added
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void items_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GListModelHandleImpl>))] MentorLake.Gio.GListModelHandle self, uint position, uint removed, uint added, IntPtr user_data);

}


public static class PangoFcFontMapHandleExtensions
{
/// <summary>
/// <para>
/// This function saves a callback method in the `PangoFcFontMap` that
/// will be called whenever new fonts are created.
/// </para>
/// <para>
/// If the function returns a `PangoFcDecoder`, that decoder will be used
/// to determine both coverage via a `FcCharSet` and a one-to-one mapping
/// of characters to glyphs. This will allow applications to have
/// application-specific encodings for various fonts.
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// The `PangoFcFontMap` to add this method to.
/// </param>
/// <param name="findfunc">
/// The `PangoFcDecoderFindFunc` callback function
/// </param>
/// <param name="user_data">
/// User data.
/// </param>
/// <param name="dnotify">
/// A `GDestroyNotify` callback that will be called when the
///   fontmap is finalized and the decoder is released.
/// </param>

	public static T AddDecoderFindFunc<T>(this T fcfontmap, MentorLake.PangoFc.PangoFcDecoderFindFunc findfunc, IntPtr user_data, MentorLake.GLib.GDestroyNotify dnotify) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_add_decoder_find_func(fcfontmap, findfunc, user_data, dnotify);
		return fcfontmap;
	}

/// <summary>
/// <para>
/// Clear all cached information and fontsets for this font map.
/// </para>
/// <para>
/// This should be called whenever there is a change in the
/// output of the default_substitute() virtual function of the
/// font map, or if fontconfig has been reinitialized to new
/// configuration.
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// a `PangoFcFontMap`
/// </param>

	public static T CacheClear<T>(this T fcfontmap) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_cache_clear(fcfontmap);
		return fcfontmap;
	}

/// <summary>
/// <para>
/// Informs font map that the fontconfig configuration (i.e., FcConfig
/// object) used by this font map has changed.
/// </para>
/// <para>
/// This currently calls [method@PangoFc.FontMap.cache_clear] which
/// ensures that list of fonts, etc will be regenerated using the
/// updated configuration.
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// a `PangoFcFontMap`
/// </param>

	public static T ConfigChanged<T>(this T fcfontmap) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_config_changed(fcfontmap);
		return fcfontmap;
	}

/// <summary>
/// <para>
/// Creates a new context for this fontmap.
/// </para>
/// <para>
/// This function is intended only for backend implementations deriving
/// from `PangoFcFontMap`; it is possible that a backend will store
/// additional information needed for correct operation on the `PangoContext`
/// after calling this function.
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// a `PangoFcFontMap`
/// </param>
/// <return>
/// a new `PangoContext`
/// </return>

	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_create_context(fcfontmap);
	}

/// <summary>
/// <para>
/// Finds the decoder to use for @pattern.
/// </para>
/// <para>
/// Decoders can be added to a font map using
/// [method@PangoFc.FontMap.add_decoder_find_func].
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// The `PangoFcFontMap` to use.
/// </param>
/// <param name="pattern">
/// The `FcPattern` to find the decoder for.
/// </param>
/// <return>
/// a newly created `PangoFcDecoder`
///   object or %NULL if no decoder is set for @pattern.
/// </return>

	public static MentorLake.PangoFc.PangoFcDecoderHandle FindDecoder(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, MentorLake.fontconfig.FcPatternHandle pattern)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_find_decoder(fcfontmap, pattern);
	}

/// <summary>
/// <para>
/// Fetches the `FcConfig` attached to a font map.
/// </para>
/// <para>
/// See also: [method@PangoFc.FontMap.set_config].
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// a `PangoFcFontMap`
/// </param>
/// <return>
/// the `FcConfig` object attached to
///   @fcfontmap, which might be %NULL. The return value is
///   owned by Pango and should not be freed.
/// </return>

	public static MentorLake.fontconfig.FcConfigHandle GetConfig(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_get_config(fcfontmap);
	}

/// <summary>
/// <para>
/// Retrieves the `hb_face_t` for the given `PangoFcFont`.
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// a `PangoFcFontMap`
/// </param>
/// <param name="fcfont">
/// a `PangoFcFont`
/// </param>
/// <return>
/// the `hb_face_t`
///   for the given font
/// </return>

	public static MentorLake.HarfBuzz.hb_face_tHandle GetHbFace(this MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap, MentorLake.PangoFc.PangoFcFontHandle fcfont)
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		return PangoFcFontMapHandleExterns.pango_fc_font_map_get_hb_face(fcfontmap, fcfont);
	}

/// <summary>
/// <para>
/// Set the `FcConfig` for this font map to use.
/// </para>
/// <para>
/// The default value
/// is %NULL, which causes Fontconfig to use its global "current config".
/// You can create a new `FcConfig` object and use this API to attach it
/// to a font map.
/// </para>
/// <para>
/// This is particularly useful for example, if you want to use application
/// fonts with Pango. For that, you would create a fresh `FcConfig`, add your
/// app fonts to it, and attach it to a new Pango font map.
/// </para>
/// <para>
/// If @fcconfig is different from the previous config attached to the font map,
/// [method@PangoFc.FontMap.config_changed] is called.
/// </para>
/// <para>
/// This function acquires a reference to the `FcConfig` object; the caller
/// does **not** need to retain a reference.
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// a `PangoFcFontMap`
/// </param>
/// <param name="fcconfig">
/// a `FcConfig`
/// </param>

	public static T SetConfig<T>(this T fcfontmap, MentorLake.fontconfig.FcConfigHandle fcconfig) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_set_config(fcfontmap, fcconfig);
		return fcfontmap;
	}

/// <summary>
/// <para>
/// Sets a function that will be called to do final configuration
/// substitution on a `FcPattern` before it is used to load
/// the font.
/// </para>
/// <para>
/// This function can be used to do things like set
/// hinting and antialiasing options.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFcFontMap`
/// </param>
/// <param name="func">
/// function to call to to do final config tweaking on `FcPattern` objects
/// </param>
/// <param name="data">
/// data to pass to @func
/// </param>
/// <param name="notify">
/// function to call when @data is no longer used
/// </param>

	public static T SetDefaultSubstitute<T>(this T fontmap, MentorLake.PangoFc.PangoFcSubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : PangoFcFontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_set_default_substitute(fontmap, func, data, notify);
		return fontmap;
	}

/// <summary>
/// <para>
/// Clears all cached information for the fontmap and marks
/// all fonts open for the fontmap as dead.
/// </para>
/// <para>
/// See the shutdown() virtual function of `PangoFcFont`.
/// </para>
/// <para>
/// This function might be used by a backend when the underlying
/// windowing system for the font map exits. This function is only
/// intended to be called only for backend implementations deriving
/// from `PangoFcFontMap`.
/// </para>
/// </summary>

/// <param name="fcfontmap">
/// a `PangoFcFontMap`
/// </param>

	public static T Shutdown<T>(this T fcfontmap) where T : PangoFcFontMapHandle
	{
		if (fcfontmap.IsInvalid) throw new Exception("Invalid handle (PangoFcFontMapHandle)");
		PangoFcFontMapHandleExterns.pango_fc_font_map_shutdown(fcfontmap);
		return fcfontmap;
	}

/// <summary>
/// <para>
/// Call this function any time the results of the default
/// substitution function set with
/// [method@PangoFc.FontMap.set_default_substitute] change.
/// </para>
/// <para>
/// That is, if your substitution function will return different
/// results for the same input pattern, you must call this function.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFcFontMap`
/// </param>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_fc_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFc.PangoFcFontMapHandle>))] MentorLake.PangoFc.PangoFcFontMapHandle fcfontmap);

	[DllImport(PangoFcLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.PangoFc.PangoFcDecoderHandle>))]
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
