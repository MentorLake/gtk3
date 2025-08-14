namespace MentorLake.Vulkan;


public class VkCudaFunctionNVHandle : BaseSafeHandle
{
}


public static class VkCudaFunctionNVExtensions
{

	public static VkCudaFunctionNV Dereference(this VkCudaFunctionNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCudaFunctionNV>(x.DangerousGetHandle());
}
internal class VkCudaFunctionNVExterns
{
}


public struct VkCudaFunctionNV
{
}
