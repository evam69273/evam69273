/// <summary>
/// One scheduled pulse: the moment it leaves its spawn point, the lane it rides and
/// whether it is a crimson shard (must meet the shield) or a teal charge (must find
/// an open lane).
/// </summary>
public struct PulseTicket
{
    public float ReleaseTime;
    public int Lane;
    public bool IsDanger;
    public PulseTicket(float _0xb340d18b, int _0xf4e3353f, bool _0x41acb0f6)
    {
        this.ReleaseTime = _0xb340d18b;
        this.Lane = _0xf4e3353f;
        this.IsDanger = _0x41acb0f6;
    }
}