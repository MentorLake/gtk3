namespace MentorLake.Vulkan;

public class VkCudaFunctionCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkCudaFunctionCreateInfoNVExtensions
{

	public static VkCudaFunctionCreateInfoNV Dereference(this VkCudaFunctionCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCudaFunctionCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkCudaFunctionCreateInfoNVExterns
{
}

public struct VkCudaFunctionCreateInfoNV
{
}
