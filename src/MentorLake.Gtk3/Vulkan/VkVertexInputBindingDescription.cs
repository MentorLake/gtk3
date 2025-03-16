namespace MentorLake.Vulkan;

public class VkVertexInputBindingDescriptionHandle : BaseSafeHandle
{
}


public static class VkVertexInputBindingDescriptionExtensions
{

	public static VkVertexInputBindingDescription Dereference(this VkVertexInputBindingDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVertexInputBindingDescription>(x.DangerousGetHandle());
}
internal class VkVertexInputBindingDescriptionExterns
{
}

public struct VkVertexInputBindingDescription
{
}
