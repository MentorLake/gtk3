namespace MentorLake.PangoFT2;

/// <summary>
/// <para>
/// The `PangoFT2FontMap` is the `PangoFontMap` implementation for FreeType fonts.
/// </para>
/// </summary>

public class PangoFT2FontMapHandle : PangoFcFontMapHandle, GListModelHandle
{
/// <summary>
/// <para>
/// Create a new `PangoFT2FontMap` object.
/// </para>
/// <para>
/// A fontmap is used to cache information about available fonts,
/// and holds certain global parameters such as the resolution and
/// the default substitute function (see
/// [method@PangoFT2.FontMap.set_default_substitute]).
/// </para>
/// </summary>

/// <return>
/// the newly created fontmap object. Unref
/// with g_object_unref() when you are finished with it.
/// </return>

	public static MentorLake.PangoFT2.PangoFT2FontMapHandle New()
	{
		return PangoFT2FontMapHandleExterns.pango_ft2_font_map_new();
	}

/// <summary>
/// <para>
/// Returns a `PangoFT2FontMap`.
/// </para>
/// <para>
/// This font map is cached and should
/// not be freed. If the font map is no longer needed, it can
/// be released with pango_ft2_shutdown_display(). Use of the
/// global PangoFT2 fontmap is deprecated; use pango_ft2_font_map_new()
/// instead.
/// </para>
/// </summary>

/// <return>
/// a `PangoFT2FontMap`.
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle ForDisplay()
	{
		return PangoFT2FontMapHandleExterns.pango_ft2_font_map_for_display();
	}

}
public static class PangoFT2FontMapHandleSignalExtensions
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

	public static IObservable<PangoFT2FontMapHandleSignalStructs.ItemsChangedSignal> Signal_ItemsChanged(this PangoFT2FontMapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<PangoFT2FontMapHandleSignalStructs.ItemsChangedSignal> obs) =>
		{
			PangoFT2FontMapHandleSignalDelegates.items_changed handler = ( MentorLake.Gio.GListModelHandle self,  uint position,  uint removed,  uint added,  IntPtr user_data) =>
			{
				

				var signalStruct = new PangoFT2FontMapHandleSignalStructs.ItemsChangedSignal()
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

public static class PangoFT2FontMapHandleSignalStructs
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

public static class PangoFT2FontMapHandleSignalDelegates
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


public static class PangoFT2FontMapHandleExtensions
{
/// <summary>
/// <para>
/// Create a `PangoContext` for the given fontmap.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFT2FontMap`
/// </param>
/// <return>
/// the newly created context; free with
///     g_object_unref().
/// </return>

	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap)
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFT2FontMapHandle)");
		return PangoFT2FontMapHandleExterns.pango_ft2_font_map_create_context(fontmap);
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
/// a `PangoFT2FontMap`
/// </param>
/// <param name="func">
/// function to call to to do final config tweaking
///        on #FcPattern objects.
/// </param>
/// <param name="data">
/// data to pass to @func
/// </param>
/// <param name="notify">
/// function to call when @data is no longer used.
/// </param>

	public static T SetDefaultSubstitute<T>(this T fontmap, MentorLake.PangoFT2.PangoFT2SubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify) where T : PangoFT2FontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFT2FontMapHandle)");
		PangoFT2FontMapHandleExterns.pango_ft2_font_map_set_default_substitute(fontmap, func, data, notify);
		return fontmap;
	}

/// <summary>
/// <para>
/// Sets the horizontal and vertical resolutions for the fontmap.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFT2FontMap`
/// </param>
/// <param name="dpi_x">
/// dots per inch in the X direction
/// </param>
/// <param name="dpi_y">
/// dots per inch in the Y direction
/// </param>

	public static T SetResolution<T>(this T fontmap, double dpi_x, double dpi_y) where T : PangoFT2FontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFT2FontMapHandle)");
		PangoFT2FontMapHandleExterns.pango_ft2_font_map_set_resolution(fontmap, dpi_x, dpi_y);
		return fontmap;
	}

/// <summary>
/// <para>
/// Call this function any time the results of the
/// default substitution function set with
/// pango_ft2_font_map_set_default_substitute() change.
/// </para>
/// <para>
/// That is, if your substitution function will return different
/// results for the same input pattern, you must call this function.
/// </para>
/// </summary>

/// <param name="fontmap">
/// a `PangoFT2FontMap`
/// </param>

	public static T SubstituteChanged<T>(this T fontmap) where T : PangoFT2FontMapHandle
	{
		if (fontmap.IsInvalid) throw new Exception("Invalid handle (PangoFT2FontMapHandle)");
		PangoFT2FontMapHandleExterns.pango_ft2_font_map_substitute_changed(fontmap);
		return fontmap;
	}

}

internal class PangoFT2FontMapHandleExterns
{
	[DllImport(PangoFT2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))]
	internal static extern MentorLake.PangoFT2.PangoFT2FontMapHandle pango_ft2_font_map_new();

	[DllImport(PangoFT2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_ft2_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_font_map_set_default_substitute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap, MentorLake.PangoFT2.PangoFT2SubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_font_map_set_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap, double dpi_x, double dpi_y);

	[DllImport(PangoFT2Library.Name)]
	internal static extern void pango_ft2_font_map_substitute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoFT2.PangoFT2FontMapHandle>))] MentorLake.PangoFT2.PangoFT2FontMapHandle fontmap);

	[DllImport(PangoFT2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_ft2_font_map_for_display();

}
