namespace MentorLake.Vulkan;


public class VkDisplayEventInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDisplayEventInfoEXTExtensions
{

	public static VkDisplayEventInfoEXT Dereference(this VkDisplayEventInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayEventInfoEXT>(x.DangerousGetHandle());
}
internal class VkDisplayEventInfoEXTExterns
{
}


public struct VkDisplayEventInfoEXT
{
}
