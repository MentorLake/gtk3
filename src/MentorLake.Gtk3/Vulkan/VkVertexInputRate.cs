namespace MentorLake.Vulkan;


public class VkVertexInputRateHandle : BaseSafeHandle
{
}


public static class VkVertexInputRateExtensions
{

	public static VkVertexInputRate Dereference(this VkVertexInputRateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVertexInputRate>(x.DangerousGetHandle());
}
internal class VkVertexInputRateExterns
{
}


public struct VkVertexInputRate
{
}
