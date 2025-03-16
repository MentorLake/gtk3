namespace MentorLake.Vulkan;

public class VkComponentMappingHandle : BaseSafeHandle
{
}


public static class VkComponentMappingExtensions
{

	public static VkComponentMapping Dereference(this VkComponentMappingHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkComponentMapping>(x.DangerousGetHandle());
}
internal class VkComponentMappingExterns
{
}

public struct VkComponentMapping
{
}
