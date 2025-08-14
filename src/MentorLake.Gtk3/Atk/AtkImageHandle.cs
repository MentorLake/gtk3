namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK Interface implemented by components
///  which expose image or pixmap content on-screen.
/// </para>
/// <para>
/// #AtkImage should be implemented by #AtkObject subtypes on behalf of
/// components which display image/pixmap information onscreen, and
/// which provide information (other than just widget borders, etc.)
/// via that image content.  For instance, icons, buttons with icons,
/// toolbar elements, and image viewing panes typically should
/// implement #AtkImage.
/// </para>
/// <para>
/// #AtkImage primarily provides two types of information: coordinate
/// information (useful for screen review mode of screenreaders, and
/// for use by onscreen magnifiers), and descriptive information.  The
/// descriptive information is provided for alternative, text-only
/// presentation of the most significant information present in the
/// image.
/// </para>
/// </summary>

public interface AtkImageHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkImageHandleImpl : BaseSafeHandle, AtkImageHandle
{
}

public static class AtkImageHandleExtensions
{
/// <summary>
/// <para>
/// Get a textual description of this image.
/// </para>
/// </summary>

/// <param name="image">
/// a #GObject instance that implements AtkImageIface
/// </param>
/// <return>
/// a string representing the image description
/// </return>

	public static string GetImageDescription(this MentorLake.Atk.AtkImageHandle image)
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (AtkImageHandle)");
		return AtkImageHandleExterns.atk_image_get_image_description(image);
	}

/// <summary>
/// <para>
/// Retrieves the locale identifier associated to the #AtkImage.
/// </para>
/// </summary>

/// <param name="image">
/// An #AtkImage
/// </param>
/// <return>
/// a string corresponding to the POSIX
///   `LC_MESSAGES` locale used by the image description, or
///   %NULL if the image does not specify a locale.
/// </return>

	public static string GetImageLocale(this MentorLake.Atk.AtkImageHandle image)
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (AtkImageHandle)");
		return AtkImageHandleExterns.atk_image_get_image_locale(image);
	}

/// <summary>
/// <para>
/// Gets the position of the image in the form of a point specifying the
/// images top-left corner.
/// </para>
/// <para>
/// If the position can not be obtained (e.g. missing support), x and y are set
/// to -1.
/// </para>
/// </summary>

/// <param name="image">
/// a #GObject instance that implements AtkImageIface
/// </param>
/// <param name="x">
/// address of #gint to put x coordinate position; otherwise, -1 if value cannot be obtained.
/// </param>
/// <param name="y">
/// address of #gint to put y coordinate position; otherwise, -1 if value cannot be obtained.
/// </param>
/// <param name="coord_type">
/// specifies whether the coordinates are relative to the screen
/// or to the components top level window
/// </param>

	public static T GetImagePosition<T>(this T image, out int x, out int y, MentorLake.Atk.AtkCoordType coord_type) where T : AtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (AtkImageHandle)");
		AtkImageHandleExterns.atk_image_get_image_position(image, out x, out y, coord_type);
		return image;
	}

/// <summary>
/// <para>
/// Get the width and height in pixels for the specified image.
/// The values of @width and @height are returned as -1 if the
/// values cannot be obtained (for instance, if the object is not onscreen).
/// </para>
/// <para>
/// If the size can not be obtained (e.g. missing support), x and y are set
/// to -1.
/// </para>
/// </summary>

/// <param name="image">
/// a #GObject instance that implements AtkImageIface
/// </param>
/// <param name="width">
/// filled with the image width, or -1 if the value cannot be obtained.
/// </param>
/// <param name="height">
/// filled with the image height, or -1 if the value cannot be obtained.
/// </param>

	public static T GetImageSize<T>(this T image, out int width, out int height) where T : AtkImageHandle
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (AtkImageHandle)");
		AtkImageHandleExterns.atk_image_get_image_size(image, out width, out height);
		return image;
	}

/// <summary>
/// <para>
/// Sets the textual description for this image.
/// </para>
/// </summary>

/// <param name="image">
/// a #GObject instance that implements AtkImageIface
/// </param>
/// <param name="description">
/// a string description to set for @image
/// </param>
/// <return>
/// boolean TRUE, or FALSE if operation could
/// not be completed.
/// </return>

	public static bool SetImageDescription(this MentorLake.Atk.AtkImageHandle image, string description)
	{
		if (image.IsInvalid) throw new Exception("Invalid handle (AtkImageHandle)");
		return AtkImageHandleExterns.atk_image_set_image_description(image, description);
	}

}

internal class AtkImageHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_image_get_image_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_image_get_image_locale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_image_get_image_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image, out int x, out int y, MentorLake.Atk.AtkCoordType coord_type);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_image_get_image_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image, out int width, out int height);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_image_set_image_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkImageHandleImpl>))] MentorLake.Atk.AtkImageHandle image, string description);

}
