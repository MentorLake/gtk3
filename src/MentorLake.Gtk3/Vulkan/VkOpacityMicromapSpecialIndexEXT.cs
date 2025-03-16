namespace MentorLake.Vulkan;

public class VkOpacityMicromapSpecialIndexEXTHandle : BaseSafeHandle
{
}


public static class VkOpacityMicromapSpecialIndexEXTExtensions
{

	public static VkOpacityMicromapSpecialIndexEXT Dereference(this VkOpacityMicromapSpecialIndexEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpacityMicromapSpecialIndexEXT>(x.DangerousGetHandle());
}
internal class VkOpacityMicromapSpecialIndexEXTExterns
{
}

public struct VkOpacityMicromapSpecialIndexEXT
{
}
