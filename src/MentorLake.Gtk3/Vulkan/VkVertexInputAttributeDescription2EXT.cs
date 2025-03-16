namespace MentorLake.Vulkan;

public class VkVertexInputAttributeDescription2EXTHandle : BaseSafeHandle
{
}


public static class VkVertexInputAttributeDescription2EXTExtensions
{

	public static VkVertexInputAttributeDescription2EXT Dereference(this VkVertexInputAttributeDescription2EXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVertexInputAttributeDescription2EXT>(x.DangerousGetHandle());
}
internal class VkVertexInputAttributeDescription2EXTExterns
{
}

public struct VkVertexInputAttributeDescription2EXT
{
}
