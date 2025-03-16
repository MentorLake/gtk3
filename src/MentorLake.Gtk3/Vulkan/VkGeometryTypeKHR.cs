namespace MentorLake.Vulkan;

public class VkGeometryTypeKHRHandle : BaseSafeHandle
{
}


public static class VkGeometryTypeKHRExtensions
{

	public static VkGeometryTypeKHR Dereference(this VkGeometryTypeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGeometryTypeKHR>(x.DangerousGetHandle());
}
internal class VkGeometryTypeKHRExterns
{
}

public struct VkGeometryTypeKHR
{
}
