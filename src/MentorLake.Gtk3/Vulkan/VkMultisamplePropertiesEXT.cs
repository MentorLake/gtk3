namespace MentorLake.Vulkan;

public class VkMultisamplePropertiesEXTHandle : BaseSafeHandle
{
}


public static class VkMultisamplePropertiesEXTExtensions
{

	public static VkMultisamplePropertiesEXT Dereference(this VkMultisamplePropertiesEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMultisamplePropertiesEXT>(x.DangerousGetHandle());
}
internal class VkMultisamplePropertiesEXTExterns
{
}

public struct VkMultisamplePropertiesEXT
{
}
