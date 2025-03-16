namespace MentorLake.Vulkan;

public class VkVertexInputBindingDescription2EXTHandle : BaseSafeHandle
{
}


public static class VkVertexInputBindingDescription2EXTExtensions
{

	public static VkVertexInputBindingDescription2EXT Dereference(this VkVertexInputBindingDescription2EXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVertexInputBindingDescription2EXT>(x.DangerousGetHandle());
}
internal class VkVertexInputBindingDescription2EXTExterns
{
}

public struct VkVertexInputBindingDescription2EXT
{
}
