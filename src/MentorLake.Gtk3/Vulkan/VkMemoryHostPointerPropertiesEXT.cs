namespace MentorLake.Vulkan;

public class VkMemoryHostPointerPropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkMemoryHostPointerPropertiesEXTExtensions
{

	public static VkMemoryHostPointerPropertiesEXT Dereference(this VkMemoryHostPointerPropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryHostPointerPropertiesEXT>(x.DangerousGetHandle());
}
internal class VkMemoryHostPointerPropertiesEXTExterns
{
}

public struct VkMemoryHostPointerPropertiesEXT
{
}
