namespace MentorLake.Vulkan;


public class VkTransformMatrixKHRHandle : BaseSafeHandle
{
}


public static class VkTransformMatrixKHRExtensions
{

	public static VkTransformMatrixKHR Dereference(this VkTransformMatrixKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTransformMatrixKHR>(x.DangerousGetHandle());
}
internal class VkTransformMatrixKHRExterns
{
}


public struct VkTransformMatrixKHR
{
}
