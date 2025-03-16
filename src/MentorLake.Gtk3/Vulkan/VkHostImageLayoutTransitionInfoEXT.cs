namespace MentorLake.Vulkan;

public class VkHostImageLayoutTransitionInfoEXTHandle : BaseSafeHandle
{
}


public static class VkHostImageLayoutTransitionInfoEXTExtensions
{

	public static VkHostImageLayoutTransitionInfoEXT Dereference(this VkHostImageLayoutTransitionInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkHostImageLayoutTransitionInfoEXT>(x.DangerousGetHandle());
}
internal class VkHostImageLayoutTransitionInfoEXTExterns
{
}

public struct VkHostImageLayoutTransitionInfoEXT
{
}
