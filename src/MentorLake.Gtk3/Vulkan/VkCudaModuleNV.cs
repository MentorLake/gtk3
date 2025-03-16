namespace MentorLake.Vulkan;

public class VkCudaModuleNVHandle : BaseSafeHandle
{
}


public static class VkCudaModuleNVExtensions
{

	public static VkCudaModuleNV Dereference(this VkCudaModuleNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCudaModuleNV>(x.DangerousGetHandle());
}
internal class VkCudaModuleNVExterns
{
}

public struct VkCudaModuleNV
{
}
