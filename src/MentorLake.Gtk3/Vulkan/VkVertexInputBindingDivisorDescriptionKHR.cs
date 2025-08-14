namespace MentorLake.Vulkan;


public class VkVertexInputBindingDivisorDescriptionKHRHandle : BaseSafeHandle
{
}


public static class VkVertexInputBindingDivisorDescriptionKHRExtensions
{

	public static VkVertexInputBindingDivisorDescriptionKHR Dereference(this VkVertexInputBindingDivisorDescriptionKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVertexInputBindingDivisorDescriptionKHR>(x.DangerousGetHandle());
}
internal class VkVertexInputBindingDivisorDescriptionKHRExterns
{
}


public struct VkVertexInputBindingDivisorDescriptionKHR
{
}
