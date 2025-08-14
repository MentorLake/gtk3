namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The type of license for an application.
/// </para>
/// <para>
/// This enumeration can be expanded at later date.
/// </para>
/// </summary>

[Flags]
public enum GtkLicense
{
/// <summary>
/// <para>
/// No license specified
/// </para>
/// </summary>

	GTK_LICENSE_UNKNOWN = 0,
/// <summary>
/// <para>
/// A license text is going to be specified by the
///   developer
/// </para>
/// </summary>

	GTK_LICENSE_CUSTOM = 1,
/// <summary>
/// <para>
/// The GNU General Public License, version 2.0 or later
/// </para>
/// </summary>

	GTK_LICENSE_GPL_2_0 = 2,
/// <summary>
/// <para>
/// The GNU General Public License, version 3.0 or later
/// </para>
/// </summary>

	GTK_LICENSE_GPL_3_0 = 3,
/// <summary>
/// <para>
/// The GNU Lesser General Public License, version 2.1 or later
/// </para>
/// </summary>

	GTK_LICENSE_LGPL_2_1 = 4,
/// <summary>
/// <para>
/// The GNU Lesser General Public License, version 3.0 or later
/// </para>
/// </summary>

	GTK_LICENSE_LGPL_3_0 = 5,
/// <summary>
/// <para>
/// The BSD standard license
/// </para>
/// </summary>

	GTK_LICENSE_BSD = 6,
/// <summary>
/// <para>
/// The MIT/X11 standard license
/// </para>
/// </summary>

	GTK_LICENSE_MIT_X11 = 7,
/// <summary>
/// <para>
/// The Artistic License, version 2.0
/// </para>
/// </summary>

	GTK_LICENSE_ARTISTIC = 8,
/// <summary>
/// <para>
/// The GNU General Public License, version 2.0 only. Since 3.12.
/// </para>
/// </summary>

	GTK_LICENSE_GPL_2_0_ONLY = 9,
/// <summary>
/// <para>
/// The GNU General Public License, version 3.0 only. Since 3.12.
/// </para>
/// </summary>

	GTK_LICENSE_GPL_3_0_ONLY = 10,
/// <summary>
/// <para>
/// The GNU Lesser General Public License, version 2.1 only. Since 3.12.
/// </para>
/// </summary>

	GTK_LICENSE_LGPL_2_1_ONLY = 11,
/// <summary>
/// <para>
/// The GNU Lesser General Public License, version 3.0 only. Since 3.12.
/// </para>
/// </summary>

	GTK_LICENSE_LGPL_3_0_ONLY = 12,
/// <summary>
/// <para>
/// The GNU Affero General Public License, version 3.0 or later. Since: 3.22.
/// </para>
/// </summary>

	GTK_LICENSE_AGPL_3_0 = 13,
/// <summary>
/// <para>
/// The GNU Affero General Public License, version 3.0 only. Since: 3.22.27.
/// </para>
/// </summary>

	GTK_LICENSE_AGPL_3_0_ONLY = 14,
/// <summary>
/// <para>
/// The 3-clause BSD licence. Since: 3.24.20.
/// </para>
/// </summary>

	GTK_LICENSE_BSD_3 = 15,
/// <summary>
/// <para>
/// The Apache License, version 2.0. Since: 3.24.20.
/// </para>
/// </summary>

	GTK_LICENSE_APACHE_2_0 = 16,
/// <summary>
/// <para>
/// The Mozilla Public License, version 2.0. Since: 3.24.20.
/// </para>
/// </summary>

	GTK_LICENSE_MPL_2_0 = 17
}
