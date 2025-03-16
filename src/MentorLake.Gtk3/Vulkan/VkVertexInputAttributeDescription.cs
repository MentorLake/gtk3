namespace MentorLake.Vulkan;

public class VkVertexInputAttributeDescriptionHandle : BaseSafeHandle
{
}


public static class VkVertexInputAttributeDescriptionExtensions
{

	public static VkVertexInputAttributeDescription Dereference(this VkVertexInputAttributeDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVertexInputAttributeDescription>(x.DangerousGetHandle());
}
internal class VkVertexInputAttributeDescriptionExterns
{
}

public struct VkVertexInputAttributeDescription
{
}
