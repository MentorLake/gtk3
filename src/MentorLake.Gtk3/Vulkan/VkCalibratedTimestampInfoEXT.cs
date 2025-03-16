namespace MentorLake.Vulkan;

public class VkCalibratedTimestampInfoEXTHandle : BaseSafeHandle
{
}


public static class VkCalibratedTimestampInfoEXTExtensions
{

	public static VkCalibratedTimestampInfoEXT Dereference(this VkCalibratedTimestampInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCalibratedTimestampInfoEXT>(x.DangerousGetHandle());
}
internal class VkCalibratedTimestampInfoEXTExterns
{
}

public struct VkCalibratedTimestampInfoEXT
{
}
