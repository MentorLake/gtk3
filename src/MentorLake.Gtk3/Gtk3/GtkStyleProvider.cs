namespace MentorLake.Gtk3.Gtk3;

public interface GtkStyleProviderHandle
{
}

internal class GtkStyleProviderHandleImpl : BaseSafeHandle, GtkStyleProviderHandle
{
}

public static class GtkStyleProviderHandleExtensions
{
	public static GtkIconFactoryHandle GetIconFactory(this GtkStyleProviderHandle provider, GtkWidgetPathHandle path)
	{
		return GtkStyleProviderExterns.gtk_style_provider_get_icon_factory(provider, path);
	}

	public static GtkStylePropertiesHandle GetStyle(this GtkStyleProviderHandle provider, GtkWidgetPathHandle path)
	{
		return GtkStyleProviderExterns.gtk_style_provider_get_style(provider, path);
	}

	public static bool GetStyleProperty(this GtkStyleProviderHandle provider, GtkWidgetPathHandle path, GtkStateFlags state, GParamSpecHandle pspec, out GValue value)
	{
		return GtkStyleProviderExterns.gtk_style_provider_get_style_property(provider, path, state, pspec, out value);
	}

}

internal class GtkStyleProviderExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIconFactoryHandle gtk_style_provider_get_icon_factory(GtkStyleProviderHandle provider, GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStylePropertiesHandle gtk_style_provider_get_style(GtkStyleProviderHandle provider, GtkWidgetPathHandle path);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_style_provider_get_style_property(GtkStyleProviderHandle provider, GtkWidgetPathHandle path, GtkStateFlags state, GParamSpecHandle pspec, out GValue value);

}
