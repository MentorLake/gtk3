namespace MentorLake.cairo;

/// <summary>
/// <para>
/// #cairo_path_data_t is used to represent the path data inside a
/// #cairo_path_t.
/// </para>
/// <para>
/// The data structure is designed to try to balance the demands of
/// efficiency and ease-of-use. A path is represented as an array of
/// #cairo_path_data_t, which is a union of headers and points.
/// </para>
/// <para>
/// Each portion of the path is represented by one or more elements in
/// the array, (one header followed by 0 or more points). The length
/// value of the header is the number of array elements for the current
/// portion including the header, (ie. length == 1 + # of points), and
/// where the number of points for each element type is as follows:
/// </para>
/// <para>
/// &amp;lt;programlisting&amp;gt;
///     %CAIRO_PATH_MOVE_TO:     1 point
///     %CAIRO_PATH_LINE_TO:     1 point
///     %CAIRO_PATH_CURVE_TO:    3 points
///     %CAIRO_PATH_CLOSE_PATH:  0 points
/// &amp;lt;/programlisting&amp;gt;
/// </para>
/// <para>
/// The semantics and ordering of the coordinate values are consistent
/// with cairo_move_to(), cairo_line_to(), cairo_curve_to(), and
/// cairo_close_path().
/// </para>
/// <para>
/// Here is sample code for iterating through a #cairo_path_t:
/// </para>
/// <para>
/// &amp;lt;informalexample&amp;gt;&amp;lt;programlisting&amp;gt;
///      int i;
///      cairo_path_t *path;
///      cairo_path_data_t *data;
/// &amp;nbsp;
///      path = cairo_copy_path (cr);
/// &amp;nbsp;
///      for (i=0; i &amp;lt; path-&amp;gt;num_data; i += path-&amp;gt;data[i].header.length) {
///          data = &amp;amp;path-&amp;gt;data[i];
///          switch (data-&amp;gt;header.type) {
///          case CAIRO_PATH_MOVE_TO:
///              do_move_to_things (data[1].point.x, data[1].point.y);
///              break;
///          case CAIRO_PATH_LINE_TO:
///              do_line_to_things (data[1].point.x, data[1].point.y);
///              break;
///          case CAIRO_PATH_CURVE_TO:
///              do_curve_to_things (data[1].point.x, data[1].point.y,
///                                  data[2].point.x, data[2].point.y,
///                                  data[3].point.x, data[3].point.y);
///              break;
///          case CAIRO_PATH_CLOSE_PATH:
///              do_close_path_things ();
///              break;
///          }
///      }
///      cairo_path_destroy (path);
/// &amp;lt;/programlisting&amp;gt;&amp;lt;/informalexample&amp;gt;
/// </para>
/// <para>
/// As of cairo 1.4, cairo does not mind if there are more elements in
/// a portion of the path than needed.  Such elements can be used by
/// users of the cairo API to hold extra values in the path data
/// structure.  For this reason, it is recommended that applications
/// always use &amp;lt;literal&amp;gt;data-&amp;gt;header.length&amp;lt;/literal&amp;gt; to
/// iterate over the path data, instead of hardcoding the number of
/// elements for each element type.
/// </para>
/// </summary>


public class cairo_path_data_t_headerHandle : BaseSafeHandle
{
}


public static class cairo_path_data_t_headerExtensions
{

	public static cairo_path_data_t_header Dereference(this cairo_path_data_t_headerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_data_t_header>(x.DangerousGetHandle());
}
internal class cairo_path_data_t_headerExterns
{
}


public struct cairo_path_data_t_header
{
	
public cairo_path_data_type_t type;
	
public int length;
}


public class cairo_path_data_t_pointHandle : BaseSafeHandle
{
}


public static class cairo_path_data_t_pointExtensions
{

	public static cairo_path_data_t_point Dereference(this cairo_path_data_t_pointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_data_t_point>(x.DangerousGetHandle());
}
internal class cairo_path_data_t_pointExterns
{
}


public struct cairo_path_data_t_point
{
	
public double x;
	
public double y;
}

public class cairo_path_data_tHandle : BaseSafeHandle
{
}


public static class cairo_path_data_tExtensions
{

	public static cairo_path_data_t Dereference(this cairo_path_data_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_path_data_t>(x.DangerousGetHandle());
}
internal class cairo_path_data_tExterns
{
}

/// <summary>
/// <para>
/// #cairo_path_data_t is used to represent the path data inside a
/// #cairo_path_t.
/// </para>
/// <para>
/// The data structure is designed to try to balance the demands of
/// efficiency and ease-of-use. A path is represented as an array of
/// #cairo_path_data_t, which is a union of headers and points.
/// </para>
/// <para>
/// Each portion of the path is represented by one or more elements in
/// the array, (one header followed by 0 or more points). The length
/// value of the header is the number of array elements for the current
/// portion including the header, (ie. length == 1 + # of points), and
/// where the number of points for each element type is as follows:
/// </para>
/// <para>
/// &amp;lt;programlisting&amp;gt;
///     %CAIRO_PATH_MOVE_TO:     1 point
///     %CAIRO_PATH_LINE_TO:     1 point
///     %CAIRO_PATH_CURVE_TO:    3 points
///     %CAIRO_PATH_CLOSE_PATH:  0 points
/// &amp;lt;/programlisting&amp;gt;
/// </para>
/// <para>
/// The semantics and ordering of the coordinate values are consistent
/// with cairo_move_to(), cairo_line_to(), cairo_curve_to(), and
/// cairo_close_path().
/// </para>
/// <para>
/// Here is sample code for iterating through a #cairo_path_t:
/// </para>
/// <para>
/// &amp;lt;informalexample&amp;gt;&amp;lt;programlisting&amp;gt;
///      int i;
///      cairo_path_t *path;
///      cairo_path_data_t *data;
/// &amp;nbsp;
///      path = cairo_copy_path (cr);
/// &amp;nbsp;
///      for (i=0; i &amp;lt; path-&amp;gt;num_data; i += path-&amp;gt;data[i].header.length) {
///          data = &amp;amp;path-&amp;gt;data[i];
///          switch (data-&amp;gt;header.type) {
///          case CAIRO_PATH_MOVE_TO:
///              do_move_to_things (data[1].point.x, data[1].point.y);
///              break;
///          case CAIRO_PATH_LINE_TO:
///              do_line_to_things (data[1].point.x, data[1].point.y);
///              break;
///          case CAIRO_PATH_CURVE_TO:
///              do_curve_to_things (data[1].point.x, data[1].point.y,
///                                  data[2].point.x, data[2].point.y,
///                                  data[3].point.x, data[3].point.y);
///              break;
///          case CAIRO_PATH_CLOSE_PATH:
///              do_close_path_things ();
///              break;
///          }
///      }
///      cairo_path_destroy (path);
/// &amp;lt;/programlisting&amp;gt;&amp;lt;/informalexample&amp;gt;
/// </para>
/// <para>
/// As of cairo 1.4, cairo does not mind if there are more elements in
/// a portion of the path than needed.  Such elements can be used by
/// users of the cairo API to hold extra values in the path data
/// structure.  For this reason, it is recommended that applications
/// always use &amp;lt;literal&amp;gt;data-&amp;gt;header.length&amp;lt;/literal&amp;gt; to
/// iterate over the path data, instead of hardcoding the number of
/// elements for each element type.
/// </para>
/// </summary>

public struct cairo_path_data_t
{
	public cairo_path_data_t_header header;
	public cairo_path_data_t_point point;
}
