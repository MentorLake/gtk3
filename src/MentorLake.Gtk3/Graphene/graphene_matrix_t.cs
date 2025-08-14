namespace MentorLake.Graphene;

/// <summary>
/// <para>
/// A structure capable of holding a 4x4 matrix.
/// </para>
/// <para>
/// The contents of the #graphene_matrix_t structure are private and
/// should never be accessed directly.
/// </para>
/// </summary>

public class graphene_matrix_tHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Allocates a new #graphene_matrix_t.
/// </para>
/// </summary>

/// <return>
/// the newly allocated matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle Alloc()
	{
		return graphene_matrix_tExterns.graphene_matrix_alloc();
	}

}


public static class graphene_matrix_tExtensions
{
/// <summary>
/// <para>
/// Decomposes a transformation matrix into its component transformations.
/// </para>
/// <para>
/// The algorithm for decomposing a matrix is taken from the
/// [CSS3 Transforms specification](http://dev.w3.org/csswg/css-transforms/);
/// specifically, the decomposition code is based on the equivalent code
/// published in "Graphics Gems II", edited by Jim Arvo, and
/// [available online](http://web.archive.org/web/20150512160205/http://tog.acm.org/resources/GraphicsGems/gemsii/unmatrix.c).
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="translate">
/// the translation vector
/// </param>
/// <param name="scale">
/// the scale vector
/// </param>
/// <param name="rotate">
/// the rotation quaternion
/// </param>
/// <param name="shear">
/// the shear vector
/// </param>
/// <param name="perspective">
/// the perspective vector
/// </param>
/// <return>
/// `true` if the matrix could be decomposed
/// </return>

	public static bool Decompose(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_vec3_t translate, out MentorLake.Graphene.graphene_vec3_t scale, out MentorLake.Graphene.graphene_quaternion_t rotate, out MentorLake.Graphene.graphene_vec3_t shear, out MentorLake.Graphene.graphene_vec4_t perspective)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_decompose(m, out translate, out scale, out rotate, out shear, out perspective);
	}

/// <summary>
/// <para>
/// Computes the determinant of the given matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the value of the determinant
/// </return>

	public static float Determinant(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_determinant(m);
	}

/// <summary>
/// <para>
/// Checks whether the two given #graphene_matrix_t matrices are equal.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_matrix_t
/// </param>
/// <param name="b">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// `true` if the two matrices are equal, and `false` otherwise
/// </return>

	public static bool Equal(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_equal(a, b);
	}

/// <summary>
/// <para>
/// Checks whether the two given #graphene_matrix_t matrices are
/// byte-by-byte equal.
/// </para>
/// <para>
/// While this function is faster than graphene_matrix_equal(), it
/// can also return false negatives, so it should be used in
/// conjuction with either graphene_matrix_equal() or
/// graphene_matrix_near(). For instance:
/// </para>
/// <para>
/// |[<!-- language="C" -->
///   if (graphene_matrix_equal_fast (a, b))
///     {
///       // matrices are definitely the same
///     }
///   else
///     {
///       if (graphene_matrix_equal (a, b))
///         // matrices contain the same values within an epsilon of FLT_EPSILON
///       else if (graphene_matrix_near (a, b, 0.0001))
///         // matrices contain the same values within an epsilon of 0.0001
///       else
///         // matrices are not equal
///     }
/// ]|
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_matrix_t
/// </param>
/// <param name="b">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// `true` if the matrices are equal. and `false` otherwise
/// </return>

	public static bool EqualFast(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_equal_fast(a, b);
	}

/// <summary>
/// <para>
/// Frees the resources allocated by graphene_matrix_alloc().
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>

	public static void Free(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_free(m);
	}

/// <summary>
/// <para>
/// Retrieves the given row vector at @index_ inside a matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="index_">
/// the index of the row vector, between 0 and 3
/// </param>
/// <param name="res">
/// return location for the #graphene_vec4_t
///   that is used to store the row vector
/// </param>

	public static void GetRow(this MentorLake.Graphene.graphene_matrix_tHandle m, uint index_, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_get_row(m, index_, out res);
	}

/// <summary>
/// <para>
/// Retrieves the value at the given @row and @col index.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="row">
/// the row index
/// </param>
/// <param name="col">
/// the column index
/// </param>
/// <return>
/// the value at the given indices
/// </return>

	public static float GetValue(this MentorLake.Graphene.graphene_matrix_tHandle m, uint row, uint col)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_value(m, row, col);
	}

/// <summary>
/// <para>
/// Retrieves the scaling factor on the X axis in @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the value of the scaling factor
/// </return>

	public static float GetXScale(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_x_scale(m);
	}

/// <summary>
/// <para>
/// Retrieves the translation component on the X axis from @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the translation component
/// </return>

	public static float GetXTranslation(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_x_translation(m);
	}

/// <summary>
/// <para>
/// Retrieves the scaling factor on the Y axis in @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the value of the scaling factor
/// </return>

	public static float GetYScale(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_y_scale(m);
	}

/// <summary>
/// <para>
/// Retrieves the translation component on the Y axis from @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the translation component
/// </return>

	public static float GetYTranslation(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_y_translation(m);
	}

/// <summary>
/// <para>
/// Retrieves the scaling factor on the Z axis in @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the value of the scaling factor
/// </return>

	public static float GetZScale(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_z_scale(m);
	}

/// <summary>
/// <para>
/// Retrieves the translation component on the Z axis from @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the translation component
/// </return>

	public static float GetZTranslation(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_z_translation(m);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t from the values of an affine
/// transformation matrix.
/// </para>
/// <para>
/// The arguments map to the following matrix layout:
/// </para>
/// <para>
/// |[<!-- language="plain" -->
///   ⎛ xx  yx ⎞   ⎛  a   b  0 ⎞
///   ⎜ xy  yy ⎟ = ⎜  c   d  0 ⎟
///   ⎝ x0  y0 ⎠   ⎝ tx  ty  1 ⎠
/// ]|
/// </para>
/// <para>
/// This function can be used to convert between an affine matrix type
/// from other libraries and a #graphene_matrix_t.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="xx">
/// the xx member
/// </param>
/// <param name="yx">
/// the yx member
/// </param>
/// <param name="xy">
/// the xy member
/// </param>
/// <param name="yy">
/// the yy member
/// </param>
/// <param name="x_0">
/// the x0 member
/// </param>
/// <param name="y_0">
/// the y0 member
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFrom2D(this MentorLake.Graphene.graphene_matrix_tHandle m, double xx, double yx, double xy, double yy, double x_0, double y_0)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_2d(m, xx, yx, xy, yy, x_0, y_0);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with the given array of floating
/// point values.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="v">
/// an array of at least 16 floating
///   point values
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFromFloat(this MentorLake.Graphene.graphene_matrix_tHandle m, float[] v)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_float(m, v);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t using the values of the
/// given matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="src">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_matrix_tHandle src)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_matrix(m, src);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with the given four row
/// vectors.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="v0">
/// the first row vector
/// </param>
/// <param name="v1">
/// the second row vector
/// </param>
/// <param name="v2">
/// the third row vector
/// </param>
/// <param name="v3">
/// the fourth row vector
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFromVec4(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec4_tHandle v0, MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2, MentorLake.Graphene.graphene_vec4_tHandle v3)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_vec4(m, v0, v1, v2, v3);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t compatible with #graphene_frustum_t.
/// </para>
/// <para>
/// See also: graphene_frustum_init_from_matrix()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="left">
/// distance of the left clipping plane
/// </param>
/// <param name="right">
/// distance of the right clipping plane
/// </param>
/// <param name="bottom">
/// distance of the bottom clipping plane
/// </param>
/// <param name="top">
/// distance of the top clipping plane
/// </param>
/// <param name="z_near">
/// distance of the near clipping plane
/// </param>
/// <param name="z_far">
/// distance of the far clipping plane
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFrustum(this MentorLake.Graphene.graphene_matrix_tHandle m, float left, float right, float bottom, float top, float z_near, float z_far)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_frustum(m, left, right, bottom, top, z_near, z_far);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with the identity matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitIdentity(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_identity(m);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t so that it positions the "camera"
/// at the given @eye coordinates towards an object at the @center
/// coordinates. The top of the camera is aligned to the direction
/// of the @up vector.
/// </para>
/// <para>
/// Before the transform, the camera is assumed to be placed at the
/// origin, looking towards the negative Z axis, with the top side of
/// the camera facing in the direction of the Y axis and the right
/// side in the direction of the X axis.
/// </para>
/// <para>
/// In theory, one could use @m to transform a model of such a camera
/// into world-space. However, it is more common to use the inverse of
/// @m to transform another object from world coordinates to the view
/// coordinates of the camera. Typically you would then apply the
/// camera projection transform to get from view to screen
/// coordinates.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="eye">
/// the vector describing the position to look from
/// </param>
/// <param name="center">
/// the vector describing the position to look at
/// </param>
/// <param name="up">
/// the vector describing the world's upward direction; usually,
///   this is the graphene_vec3_y_axis() vector
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitLookAt(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec3_tHandle eye, MentorLake.Graphene.graphene_vec3_tHandle center, MentorLake.Graphene.graphene_vec3_tHandle up)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_look_at(m, eye, center, up);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with an orthographic projection.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="left">
/// the left edge of the clipping plane
/// </param>
/// <param name="right">
/// the right edge of the clipping plane
/// </param>
/// <param name="top">
/// the top edge of the clipping plane
/// </param>
/// <param name="bottom">
/// the bottom edge of the clipping plane
/// </param>
/// <param name="z_near">
/// the distance of the near clipping plane
/// </param>
/// <param name="z_far">
/// the distance of the far clipping plane
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitOrtho(this MentorLake.Graphene.graphene_matrix_tHandle m, float left, float right, float top, float bottom, float z_near, float z_far)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_ortho(m, left, right, top, bottom, z_near, z_far);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with a perspective projection.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="fovy">
/// the field of view angle, in degrees
/// </param>
/// <param name="aspect">
/// the aspect value
/// </param>
/// <param name="z_near">
/// the near Z plane
/// </param>
/// <param name="z_far">
/// the far Z plane
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitPerspective(this MentorLake.Graphene.graphene_matrix_tHandle m, float fovy, float aspect, float z_near, float z_far)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_perspective(m, fovy, aspect, z_near, z_far);
	}

/// <summary>
/// <para>
/// Initializes @m to represent a rotation of @angle degrees on
/// the axis represented by the @axis vector.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="angle">
/// the rotation angle, in degrees
/// </param>
/// <param name="axis">
/// the axis vector as a #graphene_vec3_t
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitRotate(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle, MentorLake.Graphene.graphene_vec3_tHandle axis)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_rotate(m, angle, axis);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with the given scaling factors.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="x">
/// the scale factor on the X axis
/// </param>
/// <param name="y">
/// the scale factor on the Y axis
/// </param>
/// <param name="z">
/// the scale factor on the Z axis
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitScale(this MentorLake.Graphene.graphene_matrix_tHandle m, float x, float y, float z)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_scale(m, x, y, z);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with a skew transformation
/// with the given factors.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="x_skew">
/// skew factor, in radians, on the X axis
/// </param>
/// <param name="y_skew">
/// skew factor, in radians, on the Y axis
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitSkew(this MentorLake.Graphene.graphene_matrix_tHandle m, float x_skew, float y_skew)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_skew(m, x_skew, y_skew);
	}

/// <summary>
/// <para>
/// Initializes a #graphene_matrix_t with a translation to the
/// given coordinates.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="p">
/// the translation coordinates
/// </param>
/// <return>
/// the initialized matrix
/// </return>

	public static MentorLake.Graphene.graphene_matrix_tHandle InitTranslate(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_translate(m, p);
	}

/// <summary>
/// <para>
/// Linearly interpolates the two given #graphene_matrix_t by
/// interpolating the decomposed transformations separately.
/// </para>
/// <para>
/// If either matrix cannot be reduced to their transformations
/// then the interpolation cannot be performed, and this function
/// will return an identity matrix.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_matrix_t
/// </param>
/// <param name="b">
/// a #graphene_matrix_t
/// </param>
/// <param name="factor">
/// the linear interpolation factor
/// </param>
/// <param name="res">
/// return location for the
///   interpolated matrix
/// </param>

	public static void Interpolate(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b, double factor, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_interpolate(a, b, factor, out res);
	}

/// <summary>
/// <para>
/// Inverts the given matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="res">
/// return location for the
///   inverse matrix
/// </param>
/// <return>
/// `true` if the matrix is invertible
/// </return>

	public static bool Inverse(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_inverse(m, out res);
	}

/// <summary>
/// <para>
/// Checks whether the given #graphene_matrix_t is compatible with an
/// a 2D affine transformation matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// `true` if the matrix is compatible with an affine
///   transformation matrix
/// </return>

	public static bool Is2D(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_2d(m);
	}

/// <summary>
/// <para>
/// Checks whether a #graphene_matrix_t has a visible back face.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// `true` if the back face of the matrix is visible
/// </return>

	public static bool IsBackfaceVisible(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_backface_visible(m);
	}

/// <summary>
/// <para>
/// Checks whether the given #graphene_matrix_t is the identity matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// `true` if the matrix is the identity matrix
/// </return>

	public static bool IsIdentity(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_identity(m);
	}

/// <summary>
/// <para>
/// Checks whether a matrix is singular.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <return>
/// `true` if the matrix is singular
/// </return>

	public static bool IsSingular(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_singular(m);
	}

/// <summary>
/// <para>
/// Multiplies two #graphene_matrix_t.
/// </para>
/// <para>
/// Matrix multiplication is not commutative in general; the order of the factors matters.
/// The product of this multiplication is (@a × @b)
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_matrix_t
/// </param>
/// <param name="b">
/// a #graphene_matrix_t
/// </param>
/// <param name="res">
/// return location for the matrix
///   result
/// </param>

	public static void Multiply(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_multiply(a, b, out res);
	}

/// <summary>
/// <para>
/// Compares the two given #graphene_matrix_t matrices and checks
/// whether their values are within the given @epsilon of each
/// other.
/// </para>
/// </summary>

/// <param name="a">
/// a #graphene_matrix_t
/// </param>
/// <param name="b">
/// a #graphene_matrix_t
/// </param>
/// <param name="epsilon">
/// the threshold between the two matrices
/// </param>
/// <return>
/// `true` if the two matrices are near each other, and
///   `false` otherwise
/// </return>

	public static bool Near(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b, float epsilon)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_near(a, b, epsilon);
	}

/// <summary>
/// <para>
/// Normalizes the given #graphene_matrix_t.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="res">
/// return location for the normalized matrix
/// </param>

	public static void Normalize(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_normalize(m, out res);
	}

/// <summary>
/// <para>
/// Applies a perspective of @depth to the matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="depth">
/// the depth of the perspective
/// </param>
/// <param name="res">
/// return location for the
///   perspective matrix
/// </param>

	public static void Perspective(this MentorLake.Graphene.graphene_matrix_tHandle m, float depth, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_perspective(m, depth, out res);
	}

/// <summary>
/// <para>
/// Prints the contents of a matrix to the standard error stream.
/// </para>
/// <para>
/// This function is only useful for debugging; there are no guarantees
/// made on the format of the output.
/// </para>
/// </summary>

/// <param name="m">
/// The matrix to print
/// </param>

	public static void Print(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_print(m);
	}

/// <summary>
/// <para>
/// Projects a #graphene_point_t using the matrix @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <param name="res">
/// return location for the projected
///   point
/// </param>

	public static void ProjectPoint(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_point_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_project_point(m, p, out res);
	}

/// <summary>
/// <para>
/// Projects all corners of a #graphene_rect_t using the given matrix.
/// </para>
/// <para>
/// See also: graphene_matrix_project_point()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for the projected
///   rectangle
/// </param>

	public static void ProjectRect(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_quad_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_project_rect(m, r, out res);
	}

/// <summary>
/// <para>
/// Projects a #graphene_rect_t using the given matrix.
/// </para>
/// <para>
/// The resulting rectangle is the axis aligned bounding rectangle capable
/// of fully containing the projected rectangle.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for the projected
///   rectangle
/// </param>

	public static void ProjectRectBounds(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_project_rect_bounds(m, r, out res);
	}

/// <summary>
/// <para>
/// Adds a rotation transformation to @m, using the given @angle
/// and @axis vector.
/// </para>
/// <para>
/// This is the equivalent of calling graphene_matrix_init_rotate() and
/// then multiplying the matrix @m with the rotation matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="angle">
/// the rotation angle, in degrees
/// </param>
/// <param name="axis">
/// the rotation axis, as a #graphene_vec3_t
/// </param>

	public static void Rotate(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle, MentorLake.Graphene.graphene_vec3_tHandle axis)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate(m, angle, axis);
	}

/// <summary>
/// <para>
/// Adds a rotation transformation to @m, using the given
/// #graphene_euler_t.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="e">
/// a rotation described by a #graphene_euler_t
/// </param>

	public static void RotateEuler(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_euler(m, e);
	}

/// <summary>
/// <para>
/// Adds a rotation transformation to @m, using the given
/// #graphene_quaternion_t.
/// </para>
/// <para>
/// This is the equivalent of calling graphene_quaternion_to_matrix() and
/// then multiplying @m with the rotation matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="q">
/// a rotation described by a #graphene_quaternion_t
/// </param>

	public static void RotateQuaternion(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_quaternion_tHandle q)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_quaternion(m, q);
	}

/// <summary>
/// <para>
/// Adds a rotation transformation around the X axis to @m, using
/// the given @angle.
/// </para>
/// <para>
/// See also: graphene_matrix_rotate()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="angle">
/// the rotation angle, in degrees
/// </param>

	public static void RotateX(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_x(m, angle);
	}

/// <summary>
/// <para>
/// Adds a rotation transformation around the Y axis to @m, using
/// the given @angle.
/// </para>
/// <para>
/// See also: graphene_matrix_rotate()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="angle">
/// the rotation angle, in degrees
/// </param>

	public static void RotateY(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_y(m, angle);
	}

/// <summary>
/// <para>
/// Adds a rotation transformation around the Z axis to @m, using
/// the given @angle.
/// </para>
/// <para>
/// See also: graphene_matrix_rotate()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="angle">
/// the rotation angle, in degrees
/// </param>

	public static void RotateZ(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_z(m, angle);
	}

/// <summary>
/// <para>
/// Adds a scaling transformation to @m, using the three
/// given factors.
/// </para>
/// <para>
/// This is the equivalent of calling graphene_matrix_init_scale() and then
/// multiplying the matrix @m with the scale matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="factor_x">
/// scaling factor on the X axis
/// </param>
/// <param name="factor_y">
/// scaling factor on the Y axis
/// </param>
/// <param name="factor_z">
/// scaling factor on the Z axis
/// </param>

	public static void Scale(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor_x, float factor_y, float factor_z)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_scale(m, factor_x, factor_y, factor_z);
	}

/// <summary>
/// <para>
/// Adds a skew of @factor on the X and Y axis to the given matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="factor">
/// skew factor
/// </param>

	public static void SkewXy(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_skew_xy(m, factor);
	}

/// <summary>
/// <para>
/// Adds a skew of @factor on the X and Z axis to the given matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="factor">
/// skew factor
/// </param>

	public static void SkewXz(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_skew_xz(m, factor);
	}

/// <summary>
/// <para>
/// Adds a skew of @factor on the Y and Z axis to the given matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="factor">
/// skew factor
/// </param>

	public static void SkewYz(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_skew_yz(m, factor);
	}

/// <summary>
/// <para>
/// Converts a #graphene_matrix_t to an affine transformation
/// matrix, if the given matrix is compatible.
/// </para>
/// <para>
/// The returned values have the following layout:
/// </para>
/// <para>
/// |[<!-- language="plain" -->
///   ⎛ xx  yx ⎞   ⎛  a   b  0 ⎞
///   ⎜ xy  yy ⎟ = ⎜  c   d  0 ⎟
///   ⎝ x0  y0 ⎠   ⎝ tx  ty  1 ⎠
/// ]|
/// </para>
/// <para>
/// This function can be used to convert between a #graphene_matrix_t
/// and an affine matrix type from other libraries.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="xx">
/// return location for the xx member
/// </param>
/// <param name="yx">
/// return location for the yx member
/// </param>
/// <param name="xy">
/// return location for the xy member
/// </param>
/// <param name="yy">
/// return location for the yy member
/// </param>
/// <param name="x_0">
/// return location for the x0 member
/// </param>
/// <param name="y_0">
/// return location for the y0 member
/// </param>
/// <return>
/// `true` if the matrix is compatible with an affine
///   transformation matrix
/// </return>

	public static bool To2D(this MentorLake.Graphene.graphene_matrix_tHandle m, out double xx, out double yx, out double xy, out double yy, out double x_0, out double y_0)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_to_2d(m, out xx, out yx, out xy, out yy, out x_0, out y_0);
	}

/// <summary>
/// <para>
/// Converts a #graphene_matrix_t to an array of floating point
/// values.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="v">
/// return location
///   for an array of floating point values. The array must be capable
///   of holding at least 16 values.
/// </param>

	public static void ToFloat(this MentorLake.Graphene.graphene_matrix_tHandle m, out float[] v)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_to_float(m, out v);
	}

/// <summary>
/// <para>
/// Transforms each corner of a #graphene_rect_t using the given matrix @m.
/// </para>
/// <para>
/// The result is the axis aligned bounding rectangle containing the coplanar
/// quadrilateral.
/// </para>
/// <para>
/// See also: graphene_matrix_transform_point()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for the bounds
///   of the transformed rectangle
/// </param>

	public static void TransformBounds(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_bounds(m, r, out res);
	}

/// <summary>
/// <para>
/// Transforms the vertices of a #graphene_box_t using the given matrix @m.
/// </para>
/// <para>
/// The result is the axis aligned bounding box containing the transformed
/// vertices.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="b">
/// a #graphene_box_t
/// </param>
/// <param name="res">
/// return location for the bounds
///   of the transformed box
/// </param>

	public static void TransformBox(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_box(m, b, out res);
	}

/// <summary>
/// <para>
/// Transforms the given #graphene_point_t using the matrix @m.
/// </para>
/// <para>
/// Unlike graphene_matrix_transform_vec3(), this function will take into
/// account the fourth row vector of the #graphene_matrix_t when computing
/// the dot product of each row vector of the matrix.
/// </para>
/// <para>
/// See also: graphene_simd4x4f_point3_mul()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <param name="res">
/// return location for the
///   transformed #graphene_point_t
/// </param>

	public static void TransformPoint(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_point_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_point(m, p, out res);
	}

/// <summary>
/// <para>
/// Transforms the given #graphene_point3d_t using the matrix @m.
/// </para>
/// <para>
/// Unlike graphene_matrix_transform_vec3(), this function will take into
/// account the fourth row vector of the #graphene_matrix_t when computing
/// the dot product of each row vector of the matrix.
/// </para>
/// <para>
/// See also: graphene_simd4x4f_point3_mul()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="p">
/// a #graphene_point3d_t
/// </param>
/// <param name="res">
/// return location for the result
/// </param>

	public static void TransformPoint3D(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_point3d(m, p, out res);
	}

/// <summary>
/// <para>
/// Transform a #graphene_ray_t using the given matrix @m.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="r">
/// a #graphene_ray_t
/// </param>
/// <param name="res">
/// return location for the
///   transformed ray
/// </param>

	public static void TransformRay(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_ray_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_ray(m, r, out res);
	}

/// <summary>
/// <para>
/// Transforms each corner of a #graphene_rect_t using the given matrix @m.
/// </para>
/// <para>
/// The result is a coplanar quadrilateral.
/// </para>
/// <para>
/// See also: graphene_matrix_transform_point()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="res">
/// return location for the
///   transformed quad
/// </param>

	public static void TransformRect(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_quad_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_rect(m, r, out res);
	}

/// <summary>
/// <para>
/// Transforms a #graphene_sphere_t using the given matrix @m. The
/// result is the bounding sphere containing the transformed sphere.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="s">
/// a #graphene_sphere_t
/// </param>
/// <param name="res">
/// return location for the bounds
///   of the transformed sphere
/// </param>

	public static void TransformSphere(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_sphere_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_sphere(m, s, out res);
	}

/// <summary>
/// <para>
/// Transforms the given #graphene_vec3_t using the matrix @m.
/// </para>
/// <para>
/// This function will multiply the X, Y, and Z row vectors of the matrix @m
/// with the corresponding components of the vector @v. The W row vector will
/// be ignored.
/// </para>
/// <para>
/// See also: graphene_simd4x4f_vec3_mul()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="v">
/// a #graphene_vec3_t
/// </param>
/// <param name="res">
/// return location for a #graphene_vec3_t
/// </param>

	public static void TransformVec3(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_vec3(m, v, out res);
	}

/// <summary>
/// <para>
/// Transforms the given #graphene_vec4_t using the matrix @m.
/// </para>
/// <para>
/// See also: graphene_simd4x4f_vec4_mul()
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="v">
/// a #graphene_vec4_t
/// </param>
/// <param name="res">
/// return location for a #graphene_vec4_t
/// </param>

	public static void TransformVec4(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_vec4(m, v, out res);
	}

/// <summary>
/// <para>
/// Adds a translation transformation to @m using the coordinates
/// of the given #graphene_point3d_t.
/// </para>
/// <para>
/// This is the equivalent of calling graphene_matrix_init_translate() and
/// then multiplying @m with the translation matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="pos">
/// a #graphene_point3d_t
/// </param>

	public static void Translate(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point3d_tHandle pos)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_translate(m, pos);
	}

/// <summary>
/// <para>
/// Transposes the given matrix.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="res">
/// return location for the
///   transposed matrix
/// </param>

	public static void Transpose(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transpose(m, out res);
	}

/// <summary>
/// <para>
/// Unprojects the given @point using the @projection matrix and
/// a @modelview matrix.
/// </para>
/// </summary>

/// <param name="projection">
/// a #graphene_matrix_t for the projection matrix
/// </param>
/// <param name="modelview">
/// a #graphene_matrix_t for the modelview matrix; this is
///   the inverse of the modelview used when projecting the point
/// </param>
/// <param name="point">
/// a #graphene_point3d_t with the coordinates of the point
/// </param>
/// <param name="res">
/// return location for the unprojected
///   point
/// </param>

	public static void UnprojectPoint3D(this MentorLake.Graphene.graphene_matrix_tHandle projection, MentorLake.Graphene.graphene_matrix_tHandle modelview, MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (projection.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_unproject_point3d(projection, modelview, point, out res);
	}

/// <summary>
/// <para>
/// Undoes the transformation on the corners of a #graphene_rect_t using the
/// given matrix, within the given axis aligned rectangular @bounds.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="r">
/// a #graphene_rect_t
/// </param>
/// <param name="bounds">
/// the bounds of the transformation
/// </param>
/// <param name="res">
/// return location for the
///   untransformed rectangle
/// </param>

	public static void UntransformBounds(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_rect_tHandle bounds, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_untransform_bounds(m, r, bounds, out res);
	}

/// <summary>
/// <para>
/// Undoes the transformation of a #graphene_point_t using the
/// given matrix, within the given axis aligned rectangular @bounds.
/// </para>
/// </summary>

/// <param name="m">
/// a #graphene_matrix_t
/// </param>
/// <param name="p">
/// a #graphene_point_t
/// </param>
/// <param name="bounds">
/// the bounds of the transformation
/// </param>
/// <param name="res">
/// return location for the
///   untransformed point
/// </param>
/// <return>
/// `true` if the point was successfully untransformed
/// </return>

	public static bool UntransformPoint(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point_tHandle p, MentorLake.Graphene.graphene_rect_tHandle bounds, out MentorLake.Graphene.graphene_point_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_untransform_point(m, p, bounds, out res);
	}


	public static graphene_matrix_t Dereference(this graphene_matrix_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<graphene_matrix_t>(x.DangerousGetHandle());
}
internal class graphene_matrix_tExterns
{
	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_alloc();

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_decompose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_vec3_t translate, out MentorLake.Graphene.graphene_vec3_t scale, out MentorLake.Graphene.graphene_quaternion_t rotate, out MentorLake.Graphene.graphene_vec3_t shear, out MentorLake.Graphene.graphene_vec4_t perspective);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_determinant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_equal_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle b);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_get_row([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, uint index_, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, uint row, uint col);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_get_x_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_get_x_translation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_get_y_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_get_y_translation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_get_z_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern float graphene_matrix_get_z_translation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_from_2d([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, double xx, double yx, double xy, double yy, double x_0, double y_0);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_from_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float[] v);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_from_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle src);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_from_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v0, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v3);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_frustum([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float left, float right, float bottom, float top, float z_near, float z_far);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_look_at([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle eye, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle center, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle up);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_ortho([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float left, float right, float top, float bottom, float z_near, float z_far);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_perspective([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float fovy, float aspect, float z_near, float z_far);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_rotate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float angle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle axis);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float x, float y, float z);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_skew([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float x_skew, float y_skew);

	[DllImport(GrapheneLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))]
	internal static extern MentorLake.Graphene.graphene_matrix_tHandle graphene_matrix_init_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_interpolate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle b, double factor, out MentorLake.Graphene.graphene_matrix_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_inverse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_is_2d([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_is_backface_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_is_identity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_is_singular([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_multiply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle b, out MentorLake.Graphene.graphene_matrix_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_near([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle b, float epsilon);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_normalize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_perspective([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float depth, out MentorLake.Graphene.graphene_matrix_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_project_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_point_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_project_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_quad_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_project_rect_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_rotate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float angle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle axis);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_rotate_euler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_euler_tHandle>))] MentorLake.Graphene.graphene_euler_tHandle e);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_rotate_quaternion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_quaternion_tHandle>))] MentorLake.Graphene.graphene_quaternion_tHandle q);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_rotate_x([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float angle);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_rotate_y([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float angle);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_rotate_z([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float angle);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_scale([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float factor_x, float factor_y, float factor_z);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_skew_xy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float factor);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_skew_xz([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float factor);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_skew_yz([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, float factor);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_to_2d([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, out double xx, out double yx, out double xy, out double yy, out double x_0, out double y_0);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_to_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] out float[] v);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_box([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_box_tHandle>))] MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_point_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_point3d([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_ray([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_ray_tHandle>))] MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_ray_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_rect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_quad_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_sphere([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_sphere_tHandle>))] MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_sphere_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_vec3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec3_tHandle>))] MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transform_vec4([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_vec4_tHandle>))] MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_translate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle pos);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_transpose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_unproject_point3d([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle projection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle modelview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point3d_tHandle>))] MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_point3d_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern void graphene_matrix_untransform_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle r, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle bounds, out MentorLake.Graphene.graphene_rect_t res);

	[DllImport(GrapheneLibrary.Name)]
	internal static extern bool graphene_matrix_untransform_point([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_point_tHandle>))] MentorLake.Graphene.graphene_point_tHandle p, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_rect_tHandle>))] MentorLake.Graphene.graphene_rect_tHandle bounds, out MentorLake.Graphene.graphene_point_t res);

}

/// <summary>
/// <para>
/// A structure capable of holding a 4x4 matrix.
/// </para>
/// <para>
/// The contents of the #graphene_matrix_t structure are private and
/// should never be accessed directly.
/// </para>
/// </summary>

public struct graphene_matrix_t
{
}
