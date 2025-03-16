namespace MentorLake.Vulkan;

public class VkVertexInputBindingDivisorDescriptionEXTHandle : BaseSafeHandle
{
}


public static class VkVertexInputBindingDivisorDescriptionEXTExtensions
{

	public static VkVertexInputBindingDivisorDescriptionEXT Dereference(this VkVertexInputBindingDivisorDescriptionEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVertexInputBindingDivisorDescriptionEXT>(x.DangerousGetHandle());
}
internal class VkVertexInputBindingDivisorDescriptionEXTExterns
{
}

public struct VkVertexInputBindingDivisorDescriptionEXT
{
}
