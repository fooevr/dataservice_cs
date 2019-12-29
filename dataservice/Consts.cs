using System;

namespace com.variflight.dataservice.cs
{
    public enum ChangeType
    {
        Unchagned = 0b00000000,
        Created = 0b01000000,
        Updated = 0b10000000,
        Deleted = 0b11000000
    }
}
