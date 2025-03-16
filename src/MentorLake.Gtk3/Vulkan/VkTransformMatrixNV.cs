namespace MentorLake.Vulkan;

public class VkTransformMatrixNVHandle : BaseSafeHandle
{
}


public static class VkTransformMatrixNVExtensions
{

	public static VkTransformMatrixNV Dereference(this VkTransformMatrixNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTransformMatrixNV>(x.DangerousGetHandle());
}
internal class VkTransformMatrixNVExterns
{
}

public struct VkTransformMatrixNV
{
}
