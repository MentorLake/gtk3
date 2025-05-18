namespace MentorLake.Graphene;

public class graphene_matrix_tHandle : BaseSafeHandle
{
	public static MentorLake.Graphene.graphene_matrix_tHandle Alloc()
	{
		return graphene_matrix_tExterns.graphene_matrix_alloc();
	}

}


public static class graphene_matrix_tExtensions
{
	public static bool Decompose(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_vec3_t translate, out MentorLake.Graphene.graphene_vec3_t scale, out MentorLake.Graphene.graphene_quaternion_t rotate, out MentorLake.Graphene.graphene_vec3_t shear, out MentorLake.Graphene.graphene_vec4_t perspective)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_decompose(m, out translate, out scale, out rotate, out shear, out perspective);
	}

	public static float Determinant(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_determinant(m);
	}

	public static bool Equal(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_equal(a, b);
	}

	public static bool EqualFast(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_equal_fast(a, b);
	}

	public static void Free(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_free(m);
	}

	public static void GetRow(this MentorLake.Graphene.graphene_matrix_tHandle m, uint index_, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_get_row(m, index_, out res);
	}

	public static float GetValue(this MentorLake.Graphene.graphene_matrix_tHandle m, uint row, uint col)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_value(m, row, col);
	}

	public static float GetXScale(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_x_scale(m);
	}

	public static float GetXTranslation(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_x_translation(m);
	}

	public static float GetYScale(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_y_scale(m);
	}

	public static float GetYTranslation(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_y_translation(m);
	}

	public static float GetZScale(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_z_scale(m);
	}

	public static float GetZTranslation(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_get_z_translation(m);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFrom2D(this MentorLake.Graphene.graphene_matrix_tHandle m, double xx, double yx, double xy, double yy, double x_0, double y_0)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_2d(m, xx, yx, xy, yy, x_0, y_0);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFromFloat(this MentorLake.Graphene.graphene_matrix_tHandle m, float[] v)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_float(m, v);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFromMatrix(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_matrix_tHandle src)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_matrix(m, src);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFromVec4(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec4_tHandle v0, MentorLake.Graphene.graphene_vec4_tHandle v1, MentorLake.Graphene.graphene_vec4_tHandle v2, MentorLake.Graphene.graphene_vec4_tHandle v3)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_from_vec4(m, v0, v1, v2, v3);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitFrustum(this MentorLake.Graphene.graphene_matrix_tHandle m, float left, float right, float bottom, float top, float z_near, float z_far)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_frustum(m, left, right, bottom, top, z_near, z_far);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitIdentity(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_identity(m);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitLookAt(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec3_tHandle eye, MentorLake.Graphene.graphene_vec3_tHandle center, MentorLake.Graphene.graphene_vec3_tHandle up)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_look_at(m, eye, center, up);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitOrtho(this MentorLake.Graphene.graphene_matrix_tHandle m, float left, float right, float top, float bottom, float z_near, float z_far)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_ortho(m, left, right, top, bottom, z_near, z_far);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitPerspective(this MentorLake.Graphene.graphene_matrix_tHandle m, float fovy, float aspect, float z_near, float z_far)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_perspective(m, fovy, aspect, z_near, z_far);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitRotate(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle, MentorLake.Graphene.graphene_vec3_tHandle axis)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_rotate(m, angle, axis);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitScale(this MentorLake.Graphene.graphene_matrix_tHandle m, float x, float y, float z)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_scale(m, x, y, z);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitSkew(this MentorLake.Graphene.graphene_matrix_tHandle m, float x_skew, float y_skew)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_skew(m, x_skew, y_skew);
	}

	public static MentorLake.Graphene.graphene_matrix_tHandle InitTranslate(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point3d_tHandle p)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_init_translate(m, p);
	}

	public static void Interpolate(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b, double factor, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_interpolate(a, b, factor, out res);
	}

	public static bool Inverse(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_inverse(m, out res);
	}

	public static bool Is2D(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_2d(m);
	}

	public static bool IsBackfaceVisible(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_backface_visible(m);
	}

	public static bool IsIdentity(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_identity(m);
	}

	public static bool IsSingular(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_is_singular(m);
	}

	public static void Multiply(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_multiply(a, b, out res);
	}

	public static bool Near(this MentorLake.Graphene.graphene_matrix_tHandle a, MentorLake.Graphene.graphene_matrix_tHandle b, float epsilon)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_near(a, b, epsilon);
	}

	public static void Normalize(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_normalize(m, out res);
	}

	public static void Perspective(this MentorLake.Graphene.graphene_matrix_tHandle m, float depth, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_perspective(m, depth, out res);
	}

	public static void Print(this MentorLake.Graphene.graphene_matrix_tHandle m)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_print(m);
	}

	public static void ProjectPoint(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_point_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_project_point(m, p, out res);
	}

	public static void ProjectRect(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_quad_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_project_rect(m, r, out res);
	}

	public static void ProjectRectBounds(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_project_rect_bounds(m, r, out res);
	}

	public static void Rotate(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle, MentorLake.Graphene.graphene_vec3_tHandle axis)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate(m, angle, axis);
	}

	public static void RotateEuler(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_euler_tHandle e)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_euler(m, e);
	}

	public static void RotateQuaternion(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_quaternion_tHandle q)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_quaternion(m, q);
	}

	public static void RotateX(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_x(m, angle);
	}

	public static void RotateY(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_y(m, angle);
	}

	public static void RotateZ(this MentorLake.Graphene.graphene_matrix_tHandle m, float angle)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_rotate_z(m, angle);
	}

	public static void Scale(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor_x, float factor_y, float factor_z)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_scale(m, factor_x, factor_y, factor_z);
	}

	public static void SkewXy(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_skew_xy(m, factor);
	}

	public static void SkewXz(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_skew_xz(m, factor);
	}

	public static void SkewYz(this MentorLake.Graphene.graphene_matrix_tHandle m, float factor)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_skew_yz(m, factor);
	}

	public static bool To2D(this MentorLake.Graphene.graphene_matrix_tHandle m, out double xx, out double yx, out double xy, out double yy, out double x_0, out double y_0)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		return graphene_matrix_tExterns.graphene_matrix_to_2d(m, out xx, out yx, out xy, out yy, out x_0, out y_0);
	}

	public static void ToFloat(this MentorLake.Graphene.graphene_matrix_tHandle m, out float[] v)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_to_float(m, out v);
	}

	public static void TransformBounds(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_bounds(m, r, out res);
	}

	public static void TransformBox(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_box_tHandle b, out MentorLake.Graphene.graphene_box_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_box(m, b, out res);
	}

	public static void TransformPoint(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point_tHandle p, out MentorLake.Graphene.graphene_point_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_point(m, p, out res);
	}

	public static void TransformPoint3D(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point3d_tHandle p, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_point3d(m, p, out res);
	}

	public static void TransformRay(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_ray_tHandle r, out MentorLake.Graphene.graphene_ray_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_ray(m, r, out res);
	}

	public static void TransformRect(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, out MentorLake.Graphene.graphene_quad_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_rect(m, r, out res);
	}

	public static void TransformSphere(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_sphere_tHandle s, out MentorLake.Graphene.graphene_sphere_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_sphere(m, s, out res);
	}

	public static void TransformVec3(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec3_tHandle v, out MentorLake.Graphene.graphene_vec3_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_vec3(m, v, out res);
	}

	public static void TransformVec4(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_vec4_tHandle v, out MentorLake.Graphene.graphene_vec4_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transform_vec4(m, v, out res);
	}

	public static void Translate(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_point3d_tHandle pos)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_translate(m, pos);
	}

	public static void Transpose(this MentorLake.Graphene.graphene_matrix_tHandle m, out MentorLake.Graphene.graphene_matrix_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_transpose(m, out res);
	}

	public static void UnprojectPoint3D(this MentorLake.Graphene.graphene_matrix_tHandle projection, MentorLake.Graphene.graphene_matrix_tHandle modelview, MentorLake.Graphene.graphene_point3d_tHandle point, out MentorLake.Graphene.graphene_point3d_t res)
	{
		if (projection.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_unproject_point3d(projection, modelview, point, out res);
	}

	public static void UntransformBounds(this MentorLake.Graphene.graphene_matrix_tHandle m, MentorLake.Graphene.graphene_rect_tHandle r, MentorLake.Graphene.graphene_rect_tHandle bounds, out MentorLake.Graphene.graphene_rect_t res)
	{
		if (m.IsInvalid) throw new Exception("Invalid handle (graphene_matrix_t)");
		graphene_matrix_tExterns.graphene_matrix_untransform_bounds(m, r, bounds, out res);
	}

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
	internal static extern void graphene_matrix_to_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Graphene.graphene_matrix_tHandle>))] MentorLake.Graphene.graphene_matrix_tHandle m, out float[] v);

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

public struct graphene_matrix_t
{
}
