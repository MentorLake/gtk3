namespace MentorLake.Vulkan;

public class VkExternalMemoryPropertiesHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryPropertiesExtensions
{

	public static VkExternalMemoryProperties Dereference(this VkExternalMemoryPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryProperties>(x.DangerousGetHandle());
}
internal class VkExternalMemoryPropertiesExterns
{
}

public struct VkExternalMemoryProperties
{
}
