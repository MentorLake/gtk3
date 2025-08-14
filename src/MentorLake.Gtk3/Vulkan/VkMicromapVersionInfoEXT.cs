namespace MentorLake.Vulkan;


public class VkMicromapVersionInfoEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapVersionInfoEXTExtensions
{

	public static VkMicromapVersionInfoEXT Dereference(this VkMicromapVersionInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapVersionInfoEXT>(x.DangerousGetHandle());
}
internal class VkMicromapVersionInfoEXTExterns
{
}


public struct VkMicromapVersionInfoEXT
{
}
