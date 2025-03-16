namespace MentorLake.Vulkan;

public class VkSampleLocationEXTHandle : BaseSafeHandle
{
}


public static class VkSampleLocationEXTExtensions
{

	public static VkSampleLocationEXT Dereference(this VkSampleLocationEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSampleLocationEXT>(x.DangerousGetHandle());
}
internal class VkSampleLocationEXTExterns
{
}

public struct VkSampleLocationEXT
{
}
